using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace GUedang
{
    public partial class UC_LaporanAktivitas : UserControl
    {
        public UC_LaporanAktivitas()
        {
            InitializeComponent();
            cmbPeriode.SelectedIndexChanged += cmbPeriode_SelectedIndexChanged;
            cmbPeran.SelectedIndexChanged += cmbPeran_SelectedIndexChanged;
            dtpDari.ValueChanged += FilterBerubah;
            dtpSampai.ValueChanged += FilterBerubah;
            txtCari.TextChanged += FilterBerubah;
            btnBersihkan.Click += btnBersihkan_Click;

            dtpDari.Value = DateTime.Today;
            dtpSampai.Value = DateTime.Today;

            TampilkanAktivitas();

        }
        private void TampilkanAktivitas()
        {
            List<DataLogAktivitas> data = AktivitasStore.AmbilSemua();

            // Filter peran
            string peran = cmbPeran.Text;

            if (!string.IsNullOrWhiteSpace(peran) &&
                peran != "Semua peran")
            {
                data = data.Where(x =>
                    x.Peran.Equals(peran, StringComparison.OrdinalIgnoreCase)
                ).ToList();
            }

            // Filter periode
            DateTime dari = DateTime.Today;
            DateTime sampai = DateTime.Today;

            switch (cmbPeriode.Text)
            {
                case "Hari ini":
                    dari = DateTime.Today;
                    sampai = DateTime.Today;
                    break;

                case "7 hari terakhir":
                    dari = DateTime.Today.AddDays(-6);
                    sampai = DateTime.Today;
                    break;

                case "30 hari terakhir":
                    dari = DateTime.Today.AddDays(-29);
                    sampai = DateTime.Today;
                    break;

                case "Pilih tanggal":
                    dari = dtpDari.Value.Date;
                    sampai = dtpSampai.Value.Date;
                    break;

                case "Semua":
                default:
                    dari = DateTime.MinValue;
                    sampai = DateTime.MaxValue;
                    break;
            }

            DateTime batas = sampai == DateTime.MaxValue
     ? DateTime.MaxValue
     : sampai.Date.AddDays(1);

            data = data.Where(x =>
                x.Waktu >= dari &&
                x.Waktu < batas
            ).ToList();

            // Pencarian nama atau aktivitas
            string cari = txtCari.Text.Trim();

            if (cari != "")
            {
                data = data.Where(x =>
                    x.Nama.IndexOf(cari, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    x.Aktivitas.IndexOf(cari, StringComparison.OrdinalIgnoreCase) >= 0
                ).ToList();
            }

            // Urutkan dari aktivitas terbaru
            data = data.OrderByDescending(x => x.Waktu).ToList();

            // Tampilkan ke DataGridView
            dgvLog.DataSource = null;

            dgvLog.DataSource = data.Select(x => new
            {
                Waktu = x.Waktu.ToString("dd/MM/yyyy HH:mm:ss"),
                x.Nama,
                x.Peran,
                x.Aktivitas
            }).ToList();

            // Hitung jumlah aktivitas
            lblTotalNilai.Text = data.Count.ToString();

            lblAdminNilai.Text = data.Count(x => x.Peran == "Admin").ToString();

            lblKasirNilai.Text = data.Count(x => x.Peran == "Kasir").ToString();

            lblGudangNilai.Text = data.Count(x => x.Peran == "Gudang").ToString();
        }
        private void tlpRoot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FilterBerubah(object sender, EventArgs e)
        {
            TampilkanAktivitas();
        }

        private void cmbPeriode_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilkanAktivitas();
        }

        private void cmbPeran_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilkanAktivitas();
        }
        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show(
                "Apakah kamu yakin ingin menghapus semua log aktivitas?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (hasil == DialogResult.Yes)
            {
                AktivitasStore.BersihkanSemua();

                TampilkanAktivitas();

                MessageBox.Show(
                    "Semua log aktivitas berhasil dibersihkan.",
                    "Informasi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            if (hasil == DialogResult.Yes)
            {
                AktivitasStore.BersihkanSemua();
                TampilkanAktivitas();
            }
        }
       
    }
}
