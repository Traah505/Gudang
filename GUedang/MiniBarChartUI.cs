using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;

namespace GUedang
{
    /// <summary>Grafik batang sederhana. Isi datanya dengan SetData(label, nilai).</summary>
    public class MiniBarChartUI : Control
    {
        private readonly List<string> _label = new List<string>();
        private readonly List<decimal> _nilai = new List<decimal>();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BarColor { get; set; } = Color.FromArgb(30, 136, 229);

        [DefaultValue("Belum ada data")]
        public string TeksKosong { get; set; } = "Belum ada data";

        public MiniBarChartUI()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.White;
        }

        public void SetData(IList<string> label, IList<decimal> nilai)
        {
            _label.Clear();
            _nilai.Clear();
            for (int i = 0; i < label.Count && i < nilai.Count; i++)
            {
                _label.Add(label[i]);
                _nilai.Add(nilai[i]);
            }
            Invalidate();
        }

        private static string Singkat(decimal v)
        {
            if (v >= 1000000m) return (v / 1000000m).ToString("0.#", Fmt.Id) + " jt";
            if (v >= 1000m) return (v / 1000m).ToString("0", Fmt.Id) + " rb";
            return v.ToString("0", Fmt.Id);
        }

        private static GraphicsPath BatangAtasBulat(RectangleF r, float radius)
        {
            float d = radius * 2;
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddLine(r.Right, r.Y + radius, r.Right, r.Bottom);
            p.AddLine(r.Right, r.Bottom, r.X, r.Bottom);
            p.CloseFigure();
            return p;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(BackColor);

            var abu = Color.FromArgb(120, 135, 160);
            var tua = Color.FromArgb(13, 47, 110);

            using (var f = new Font("Segoe UI", 8F))
            {
                if (_nilai.Count == 0)
                {
                    TextRenderer.DrawText(g, TeksKosong, f, ClientRectangle, abu,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                    return;
                }

                int atas = 22, bawah = 24, kiri = 6, kanan = 6;
                int tinggiArea = Height - atas - bawah;
                if (tinggiArea < 20) return;

                decimal maks = 0;
                foreach (decimal v in _nilai) if (v > maks) maks = v;
                if (maks <= 0) maks = 1;

                int n = _nilai.Count;
                float slot = (Width - kiri - kanan) / (float)n;
                float lebar = Math.Min(48f, slot * 0.62f);

                using (var garis = new Pen(Color.FromArgb(225, 236, 247)))
                    g.DrawLine(garis, kiri, atas + tinggiArea, Width - kanan, atas + tinggiArea);

                using (var kuas = new SolidBrush(BarColor))
                {
                    for (int i = 0; i < n; i++)
                    {
                        float x = kiri + slot * i + (slot - lebar) / 2f;
                        float tinggi = (float)(Math.Max(0m, _nilai[i]) / maks * tinggiArea);
                        if (_nilai[i] > 0 && tinggi < 2f) tinggi = 2f;
                        var batang = new RectangleF(x, atas + tinggiArea - tinggi, lebar, tinggi);

                        if (tinggi >= 6f)
                            using (var path = BatangAtasBulat(batang, 4f)) g.FillPath(kuas, path);
                        else if (tinggi > 0f)
                            g.FillRectangle(kuas, batang);

                        var rNilai = new Rectangle((int)(x - 14), (int)(batang.Top - 18), (int)lebar + 28, 16);
                        TextRenderer.DrawText(g, Singkat(_nilai[i]), f, rNilai, tua,
                            TextFormatFlags.HorizontalCenter | TextFormatFlags.Bottom | TextFormatFlags.NoClipping);

                        var rLabel = new Rectangle((int)(kiri + slot * i), Height - bawah + 5, (int)slot, 16);
                        TextRenderer.DrawText(g, _label[i], f, rLabel, abu,
                            TextFormatFlags.HorizontalCenter | TextFormatFlags.EndEllipsis);
                    }
                }
            }
        }
    }
}