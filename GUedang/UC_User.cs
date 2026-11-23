using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_User : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NamaAdminAktif { get; set; } = "admin";

        public UC_User()
        {
            InitializeComponent();
        }

        public void RefreshData(DataGridView dgv, string kataCari = "", string jenis = "Semua")
        {
            var q = UserStore.Muat().AsEnumerable();
            if (!string.IsNullOrWhiteSpace(kataCari))
            {
                string k = kataCari.Trim().ToLower();
                q = q.Where(u =>
                    (u.Nama ?? "").ToLower().Contains(k) ||
                    (u.Role ?? "").ToLower().Contains(k) ||
                    (u.Aktif ? "aktif" : "nonaktif").Contains(k));
            }
            if (!string.IsNullOrWhiteSpace(jenis) && jenis != "Semua")
                q = q.Where(u => string.Equals(u.Role, jenis, StringComparison.OrdinalIgnoreCase));

            dgv.DataSource = q.OrderBy(u => u.Id).Select(u => new
            {
                u.Id,
                u.Nama,
                Jenis = u.Role,
                Status = u.Aktif ? "Aktif" : "Nonaktif",
                u.Dibuat
            }).ToList();
        }

        public bool Tambah(string nama, string jenis, string password, out string pesan)
            => UserStore.TambahUser(nama, jenis, password, out pesan);

        public bool HapusUser(int idUser, out string pesan)
            => UserStore.Hapus(idUser, out pesan);

        public bool UbahStatus(int idUser, out string pesan)
            => UserStore.UbahStatus(idUser, out pesan);

        public bool ResetPwUser(int idUser, out string passwordBaru, out string pesan)
            => UserStore.ResetPassword(idUser, out passwordBaru, out pesan);
        



         private void btnHapus_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnGanti_Click(object sender, EventArgs e)
        {

        }

        private void tlpRoot_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}