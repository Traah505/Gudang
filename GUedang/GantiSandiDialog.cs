using GUedang;

public static class GantiSandiDialog
{
    public static void Tampil(IWin32Window owner, string namaUser)
    {
        var f = new Form
        {
            Text = "Ganti Kata Sandi",
            Size = new Size(340, 300),
            StartPosition = FormStartPosition.CenterParent,
            FormBorderStyle = FormBorderStyle.FixedDialog,
            MaximizeBox = false,
            MinimizeBox = false
        };
        TextBox Buat(string label, int y)
        {
            f.Controls.Add(new Label { Text = label, Left = 20, Top = y, AutoSize = true });
            var t = new TextBox { Left = 20, Top = y + 18, Width = 280, UseSystemPasswordChar = true };
            f.Controls.Add(t);
            return t;
        }
        var lama = Buat("Kata sandi lama", 15);
        var baru = Buat("Kata sandi baru", 65);
        var konf = Buat("Konfirmasi kata sandi baru", 115);
        var btn = new Button { Text = "Simpan", Left = 20, Top = 175, Width = 120 };
        f.Controls.Add(btn);

        btn.Click += (s, e) =>
        {
            if (baru.Text != konf.Text)
            { MessageBox.Show("Konfirmasi tidak sama.", "Peringatan"); return; }
            bool ok = UserStore.GantiPassword(namaUser, lama.Text, baru.Text, out string pesan);
            MessageBox.Show(pesan, "Ganti Kata Sandi", MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (ok) f.Close();
        };
        f.ShowDialog(owner);
    }
}
