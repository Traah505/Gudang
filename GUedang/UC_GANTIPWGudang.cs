using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUedang
{
    public partial class UC_GANTIPWGudang : UserControl
    {
        public UC_GANTIPWGudang()
        {
            InitializeComponent();
        }

        private void txtSimpanGPG_Click(object sender, EventArgs e)
        {
            if (txtBaruGPG.Text != txtKonfGPG.Text)
            {
                MessageBox.Show("Konfirmasi tidak sama.", "Peringatan");
                return;
            }

            bool ok = UserStore.GantiPassword(txtNamaGPG.Text.Trim(), txtLamaGPG.Text,
                                              txtBaruGPG.Text, out string pesan);

            MessageBox.Show(pesan, "Ganti Password", MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);

            if (ok) BersihkanGP();
        }

        // tombol Batal di panel Ganti Password (double-click di designer juga)
        private void btnBatalGP_Click(object sender, EventArgs e)
        {
            BersihkanGP();
        }

        private void BersihkanGP()
        {
            txtNamaGPG.Text = "";
            txtLamaGPG.Text = "";
            txtBaruGPG.Text = "";
            txtKonfGPG.Text = "";
        }
    }
    
}
