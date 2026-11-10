using System;
using System.Windows.Forms;

// Ganti isi LoginAkun.cs (di luar InitializeComponent) dengan kode ini.
// Nama control yang diasumsikan (ubah lewat Properties > (Name) kalau berbeda):
//   txtNama, txtPassword (RoundedTextBox), chkLihatPassword (CheckBox), btnLogin (Button)
namespace GUedang
{
    public partial class LoginAkun : Form
    {
        public LoginAkun()
        {
            InitializeComponent();

            this.AcceptButton = btnLogin;
            

        }

        private void LoginAkun_Load(object sender, EventArgs e)
        {
            btnLogin.Click += btnLogin_Click;
            chkLihatPassword.CheckedChanged += chkLihatPassword_CheckedChanged_1
                ;

            AcceptButton = btnLogin;                
            txtPassword.UseSystemPasswordChar = true;
        }

        

        
        
        private void BukaDashboard(UserAkun user)
        {
            UserControl dashboard;

            switch (user.Role)
            {
                case Roles.Admin: dashboard = new UC_DashboardAdmin(); break;
                case Roles.Kasir: dashboard = new UC_DSHBRDKasir(); break;
                case Roles.Gudang: dashboard = new UC_DSHBRDGudang(); break;
                default:
                    MessageBox.Show("Role \"" + user.Role + "\" tidak dikenali.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

           
            using (var host = new Form())
            {
                host.Text = "SMK Mart - " + user.Role + " (" + user.Nama + ")";
                host.StartPosition = FormStartPosition.CenterScreen;
                host.ClientSize = dashboard.Size;
                dashboard.Dock = DockStyle.Fill;
                host.Controls.Add(dashboard);

                Hide();
                host.ShowDialog();   // kode lanjut di bawah setelah jendela ditutup
            }

            // jendela dashboard ditutup = logout, kembali ke form login
            Session.UserAktif = null;
            txtNama.Text = "";
            txtPassword.Text = "";
            chkLihatPassword.Checked = false;
            Show();
            txtNama.Focus();
        }

        private void chkLihatPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkLihatPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text.Trim();
            string password = txtPassword.Text;

            if (nama.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("Nama dan password harus diisi.", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserAkun user;
            string pesan;
            try
            {
                user = UserStore.Login(nama, password, out pesan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membaca data user:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (user == null)
            {
                MessageBox.Show(pesan, "Login gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtPassword.Focus();
                return;
            }

            Session.UserAktif = user;
            BukaDashboard(user);
        }
    }
 }

