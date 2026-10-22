using System.Text.Json;

namespace GUedang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string usernameInput = textBox2.Text.Trim();
            string passwordInput = textBox1.Text.Trim();

            string filePath = "Gacor.json";

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Belum ada data pendaftaran!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string jsonText = File.ReadAllText(filePath);
                List<Gacor> listUser = JsonSerializer.Deserialize<List<Gacor>>(jsonText) ?? new List<Gacor>();

                Gacor userCocok = listUser.FirstOrDefault(u => u.Username == usernameInput && u.Password == passwordInput);

                if (userCocok != null)
                {
                    MessageBox.Show("Login Berhasil! Selamat Datang, " + userCocok.Username, "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form2 dashboard = new Form2();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (checkBox1.Checked == true)
            {
                textBox1.UseSystemPasswordChar = false;
            }
            else
            {
                textBox1.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form4 Register = new Form4();
            Register.Show();
            this.Hide();
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
    }
}
