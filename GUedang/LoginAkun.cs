using System.Text.Json;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUedang
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_load(object sender, EventArgs e)
        {

        }





        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                roundedTextBox1.UseSystemPasswordChar = false;
            }
            else
            {
                roundedTextBox1.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }




        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string usernameInput = roundedTextBox2.Text.Trim();
            string passwordInput = roundedTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Username dan password tidak boleh kosong.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            List<ModelUser> daftarUser = HelperJson.BacaData<ModelUser>("DataUser.json");

            if (daftarUser == null || daftarUser.Count == 0)
            {
                daftarUser = new List<ModelUser>
        {
            new ModelUser { Username = "admin", Password = "123", Role = "Administrator" }
        };


                HelperJson.SimpanData("DataUser.json", daftarUser);
            }


            ModelUser user = daftarUser.Find(u => u.Username == usernameInput && u.Password == passwordInput);


            if (user != null)
            {
                MessageBox.Show("Login berhasil! Selamat datang, " + user.Username, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (user.Role == "Administrator" || user.Role == "Admin")
                {
                    Admin formAdmin = new Admin();
                    formAdmin.Show();
                    this.Hide();
                }
                else
                {
                    Kasir formKasir = new Kasir();
                    formKasir.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
          
        
    


        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void customTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void roundedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
