using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_User : UserControl
    {
        public UC_User()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSImpan_Click(object sender, EventArgs e)
        {
            string namaUser = txtNama.Text.Trim();
            string jenisRole = cbmRole.SelectedItem?.ToString();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(namaUser) || string.IsNullOrEmpty(jenisRole) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Semua field harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<ModelUser> daftarUser = HelperJson.BacaData<ModelUser>("DataUser.json");
            daftarUser.Add(new ModelUser
            {
                Username = namaUser,
                Role = jenisRole,
                Password = password
            });
            HelperJson.SimpanData("DataUser.json", daftarUser);
            MessageBox.Show("Akun berhasil ditambahkan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNama.Text = "";
            txtPassword.Text = "";
            cbmRole.SelectedIndex = -1;
        }
    }
 }

