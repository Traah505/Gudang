using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;


namespace GUedang
{
    public partial class UC_LaporanAktivitas : UserControl
    {
        public UC_LaporanAktivitas()
        {
            InitializeComponent();
            dgvAktivitas.AutoGenerateColumns = false;

            string waktu = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            cmbPeran.Items.Clear();
            cmbPeran.Items.Add("Semua");
            cmbPeran.Items.Add("Admin");
            cmbPeran.Items.Add("Kasir");
            cmbPeran.Items.Add("Gudang");

            cmbPeran.SelectedIndex = 0;

            cmbPeran.SelectedIndexChanged += cmbPeran_SelectedIndexChanged;

            TampilkanAktivitas();

        }
        private void TampilkanAktivitas()
        {
            var data = AktivitasStore.AmbilSemua();

            string peran = cmbPeran.SelectedItem?.ToString();

            if (peran != "Semua" && !string.IsNullOrEmpty(peran))
            {
                data = data.Where(x => x.Peran == peran).ToList();
            }

            dgvAktivitas.DataSource = null;

            dgvAktivitas.DataSource = data
                .OrderByDescending(x => x.Waktu)
                .Select(x => new
                {
                    Waktu = x.Waktu.ToString("dd/MM/yyyy HH:mm:ss"),
                    x.Nama,
                    x.Peran,
                    x.Aktivitas
                })
                .ToList();
        }
        private void cmbPeran_SelectedIndexChanged(object sender, EventArgs e)
        {
            TampilkanAktivitas();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelLaporanAktivitas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerJam_Tick(object sender, EventArgs e)
        {
            dtpWaktu.Value = DateTime.Now;

        }
    }
}
