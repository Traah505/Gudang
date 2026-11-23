using System.Drawing.Drawing2D;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUedang
{
    // Grafik batang sederhana digambar manual (GDI+), tanpa library tambahan.
    public class MiniBarChartUI2     : Control
    {
        private List<(string Label, decimal Value)> _data = new();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BarColor { get; set; } = Color.FromArgb(30, 136, 229);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color NegativeColor { get; set; } = Color.FromArgb(220, 80, 80);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color TextColor { get; set; } = Color.FromArgb(90, 110, 140);

        public MiniBarChartUI2()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
            BackColor = Color.Transparent;
            Font = new Font("Segoe UI", 8.5F);
        }

        public void SetData(IEnumerable<(string Label, decimal Value)> data)
        {
            _data = data.ToList();
            Invalidate();
        }

        private static string Singkat(decimal v)
        {
            decimal a = Math.Abs(v);
            string s = a >= 1_000_000 ? $"{a / 1_000_000:0.#}jt"
                     : a >= 1_000 ? $"{a / 1_000:0.#}rb"
                     : $"{a:0}";
            return v < 0 ? "-" + s : s;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            if (_data.Count == 0)
            {
                TextRenderer.DrawText(g, "Belum ada data", Font, ClientRectangle, TextColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                return;
            }

            const int bawah = 28, atas = 20;
            var area = new Rectangle(0, atas, Width, Height - atas - bawah);

            decimal max = Math.Max(_data.Max(d => d.Value), 0);
            decimal min = Math.Min(_data.Min(d => d.Value), 0);
            decimal range = max - min;
            if (range == 0) range = 1;

            float nolY = area.Top + (float)(max / range) * area.Height;

            float slot = (float)Width / _data.Count;
            float lebar = Math.Min(slot * 0.6f, 60f);

            using var garisNol = new Pen(Color.FromArgb(214, 228, 245));
            g.DrawLine(garisNol, 0, nolY, Width, nolY);

            for (int i = 0; i < _data.Count; i++)
            {
                var (label, val) = _data[i];
                float tinggi = (float)(Math.Abs(val) / range) * area.Height;
                float x = i * slot + (slot - lebar) / 2;
                float y = val >= 0 ? nolY - tinggi : nolY;

                var rect = new RectangleF(x, y, lebar, Math.Max(tinggi, 1f));
                using var br = new SolidBrush(val >= 0 ? BarColor : NegativeColor);
                g.FillRectangle(br, rect);

                // nilai di atas/bawah batang
                var nilai = Singkat(val);
                var szN = TextRenderer.MeasureText(nilai, Font);
                float ny = val >= 0 ? y - szN.Height : y + tinggi;
                TextRenderer.DrawText(g, nilai, Font,
                    new Point((int)(x + lebar / 2 - szN.Width / 2f), (int)ny), TextColor);

                // label kategori di bawah
                string lb = label.Length > 10 ? label.Substring(0, 9) + "…" : label;
                if (label.Length == 10 && label[2] == '/') lb = label.Substring(0, 5); // dd/MM
                var szL = TextRenderer.MeasureText(lb, Font);
                TextRenderer.DrawText(g, lb, Font,
                    new Point((int)(i * slot + slot / 2 - szL.Width / 2f), Height - bawah + 6), TextColor);
            }
        }
    }
}