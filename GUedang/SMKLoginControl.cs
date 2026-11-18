using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUedang
{
    internal static class SmkGfx
    {
        public static GraphicsPath Round(RectangleF r, float radius)
        {
            var p = new GraphicsPath();
            float d = Math.Max(1f, Math.Min(radius * 2f, Math.Min(r.Width, r.Height)));
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }
    }

    /// <summary>Panel kiri: gradasi biru + bulatan dekoratif + kartu dashboard mini + pill footer.</summary>
    [DesignerCategory("Code")]
    public class SmkGradientPanel : Panel
    {
        private static readonly Font BadgeFont = new Font("Segoe UI", 8.5f, FontStyle.Bold);
        private static readonly Font FooterFont = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        private static readonly Font DonutFont = new Font("Segoe UI", 7.5f, FontStyle.Bold);
        private static readonly Font StatLabelFont = new Font("Segoe UI", 8f);
        private static readonly Font StatValueFont = new Font("Segoe UI", 12f, FontStyle.Bold);

        private Color _top = Color.FromArgb(76, 102, 255);
        private Color _bottom = Color.FromArgb(40, 175, 255);
        private string _footer = "";

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ColorTop { get { return _top; } set { _top = value; Invalidate(); } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ColorBottom { get { return _bottom; } set { _bottom = value; Invalidate(); } }

        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string FooterText { get { return _footer; } set { _footer = value ?? ""; Invalidate(); } }

        private Rectangle _logoCard = Rectangle.Empty;
        /// <summary>Area kartu putih di belakang logo (kosong = tidak digambar).</summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Rectangle LogoCard { get { return _logoCard; } set { _logoCard = value; Invalidate(); } }

        public SmkGradientPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        private static void Glow(Graphics g, RectangleF r, int alpha)
        {
            using (var b = new SolidBrush(Color.FromArgb(alpha, 255, 255, 255)))
                g.FillEllipse(b, r);
        }

        private static void Sparkle(Graphics g, float x, float y, float r, int alpha)
        {
            float k = r * 0.28f;
            var pts = new PointF[]
            {
                new PointF(x, y - r), new PointF(x + k, y - k), new PointF(x + r, y), new PointF(x + k, y + k),
                new PointF(x, y + r), new PointF(x - k, y + k), new PointF(x - r, y), new PointF(x - k, y - k)
            };
            using (var b = new SolidBrush(Color.FromArgb(alpha, 255, 255, 255)))
                g.FillPolygon(b, pts);
        }

        private static void Plus(Graphics g, float x, float y, float s, int alpha)
        {
            using (var pen = new Pen(Color.FromArgb(alpha, 255, 255, 255), 2f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                g.DrawLine(pen, x - s, y, x + s, y);
                g.DrawLine(pen, x, y - s, x, y + s);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rc = ClientRectangle;
            if (rc.Width < 50 || rc.Height < 50) return;
            float w = Width, h = Height;

            using (var br = new LinearGradientBrush(rc, _top, _bottom, 60f))
                g.FillRectangle(br, rc);

            // bulatan dekoratif
            Glow(g, new RectangleF(-w * 0.30f, h * 0.60f, w * 0.85f, w * 0.85f), 26);
            Glow(g, new RectangleF(w * 0.58f, -h * 0.14f, w * 0.60f, w * 0.60f), 22);
            Glow(g, new RectangleF(w * 0.74f, h * 0.70f, w * 0.30f, w * 0.30f), 34);
            float rx = w * 0.04f, ry = h * 0.405f, rs = w * 0.20f;
            using (var pen = new Pen(Color.FromArgb(90, 255, 255, 255), 1.6f))
                g.DrawEllipse(pen, rx, ry, rs, rs);
            using (var b = new SolidBrush(Color.FromArgb(235, 255, 255, 255)))
                g.FillEllipse(b, rx + rs / 2f - rs / 2f * 0.707f - 5, ry + rs / 2f - rs / 2f * 0.707f - 5, 10, 10);

            // gelombang di bagian bawah
            using (var wave = new GraphicsPath())
            {
                wave.AddBezier(0, h - 120, w * 0.30f, h - 170, w * 0.62f, h - 60, w, h - 130);
                wave.AddLine(w, h - 130, w, h);
                wave.AddLine(w, h, 0, h);
                wave.CloseFigure();
                using (var wb = new SolidBrush(Color.FromArgb(22, 255, 255, 255))) g.FillPath(wb, wave);
            }
            using (var wave2 = new GraphicsPath())
            {
                wave2.AddBezier(0, h - 80, w * 0.35f, h - 120, w * 0.70f, h - 30, w, h - 90);
                wave2.AddLine(w, h - 90, w, h);
                wave2.AddLine(w, h, 0, h);
                wave2.CloseFigure();
                using (var wb = new SolidBrush(Color.FromArgb(18, 255, 255, 255))) g.FillPath(wb, wave2);
            }

            // kartu putih untuk logo
            if (!_logoCard.IsEmpty)
            {
                var lc = new RectangleF(_logoCard.X, _logoCard.Y, _logoCard.Width, _logoCard.Height);
                for (int i = 0; i < 5; i++)
                {
                    var r = RectangleF.Inflate(lc, i * 2f, i * 2f);
                    r.Offset(0, 5);
                    using (var sp = SmkGfx.Round(r, 22 + i * 2))
                    using (var sb = new SolidBrush(Color.FromArgb(10, 10, 20, 90)))
                        g.FillPath(sb, sp);
                }
                using (var path = SmkGfx.Round(lc, 22))
                    g.FillPath(Brushes.White, path);
            }

            // tanda plus + kotak miring
            Plus(g, w - 34, 196, 6, 150);
            Plus(g, 26, 330, 6, 130);
            Plus(g, 190, 482, 5, 110);
            Plus(g, w - 30, 440, 5, 120);
            var tr = g.Save();
            g.TranslateTransform(w - 36, h * 0.60f);
            g.RotateTransform(25f);
            using (var pen = new Pen(Color.FromArgb(120, 255, 255, 255), 1.6f))
                g.DrawRectangle(pen, -8, -8, 16, 16);
            g.Restore(tr);
            Sparkle(g, w - 48, 142, 9, 210);
            Sparkle(g, w - 30, 300, 6, 150);
            Sparkle(g, w - 36, 482, 8, 170);

            // grid titik
            using (var b = new SolidBrush(Color.FromArgb(120, 255, 255, 255)))
                for (int i = 0; i < 5; i++)
                    for (int j = 0; j < 4; j++)
                        g.FillEllipse(b, w - 112 + i * 14, 56 + j * 14, 4, 4);

            // kartu dashboard mini
            var card = new RectangleF(w * 0.14f, h * 0.43f, w * 0.72f, h * 0.29f);
            using (var sh = SmkGfx.Round(new RectangleF(card.X, card.Y + 10, card.Width, card.Height), 18))
            using (var sb = new SolidBrush(Color.FromArgb(46, 10, 20, 80)))
                g.FillPath(sb, sh);
            using (var path = SmkGfx.Round(card, 18))
                g.FillPath(Brushes.White, path);

            using (var bar = new SolidBrush(Color.FromArgb(226, 232, 248)))
            {
                using (var p1 = SmkGfx.Round(new RectangleF(card.X + 22, card.Y + 22, 96, 10), 5)) g.FillPath(bar, p1);
                using (var p2 = SmkGfx.Round(new RectangleF(card.X + 22, card.Y + 40, 56, 8), 4)) g.FillPath(bar, p2);
            }

            float[] hs = { 0.30f, 0.52f, 0.42f, 0.72f, 0.58f, 0.92f };
            float areaH = card.Height - 92f;
            float bw = 28f;
            float gap = (card.Width - 44f - hs.Length * bw) / (hs.Length - 1);
            float baseY = card.Bottom - 20f;
            var pts = new PointF[hs.Length];
            for (int i = 0; i < hs.Length; i++)
            {
                float bh = Math.Max(10f, areaH * hs[i]);
                var br2 = new RectangleF(card.X + 22 + i * (bw + gap), baseY - bh, bw, bh);
                using (var path = SmkGfx.Round(br2, 7))
                using (var lg = new LinearGradientBrush(br2, _bottom, _top, 90f))
                    g.FillPath(lg, path);
                pts[i] = new PointF(br2.X + bw / 2f, br2.Y - 14f);
            }

            // garis tren oranye
            Color orange = Color.FromArgb(255, 184, 76);
            using (var pen = new Pen(orange, 2.5f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                g.DrawCurve(pen, pts, 0.4f);
            }
            using (var pen = new Pen(orange, 2f))
                foreach (var pt in pts)
                {
                    g.FillEllipse(Brushes.White, pt.X - 4, pt.Y - 4, 8, 8);
                    g.DrawEllipse(pen, pt.X - 4, pt.Y - 4, 8, 8);
                }

            // donut progres di dalam kartu
            var dn = new RectangleF(card.X + 141, card.Y + 14, 40, 40);
            using (var pen = new Pen(Color.FromArgb(226, 232, 248), 5f))
                g.DrawEllipse(pen, dn);
            using (var pen = new Pen(_top, 5f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                g.DrawArc(pen, dn, -90, 260);
            }
            TextRenderer.DrawText(g, "72%", DonutFont, Rectangle.Round(dn), Color.FromArgb(22, 41, 94),
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);

            // badge melayang
            var badge = new RectangleF(card.Right - 118, card.Y - 20, 132, 36);
            using (var path = SmkGfx.Round(badge, 18))
            {
                g.FillPath(Brushes.White, path);
                using (var pen = new Pen(Color.FromArgb(220, 228, 248), 1f)) g.DrawPath(pen, path);
            }
            using (var gb = new SolidBrush(Color.FromArgb(46, 204, 142)))
                g.FillEllipse(gb, badge.X + 14, badge.Y + 12, 12, 12);
            TextRenderer.DrawText(g, "Stok aman", BadgeFont,
                new Rectangle((int)badge.X + 32, (int)badge.Y, (int)badge.Width - 36, (int)badge.Height),
                Color.FromArgb(30, 50, 110),
                TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);

            // kartu statistik kedua
            var stat = new RectangleF(card.Right - 168, card.Bottom - 8, 168, 58);
            using (var sp = SmkGfx.Round(new RectangleF(stat.X, stat.Y + 6, stat.Width, stat.Height), 16))
            using (var sb = new SolidBrush(Color.FromArgb(44, 10, 20, 80)))
                g.FillPath(sb, sp);
            using (var path = SmkGfx.Round(stat, 16))
            {
                g.FillPath(Brushes.White, path);
                using (var pen = new Pen(Color.FromArgb(220, 228, 248), 1f)) g.DrawPath(pen, path);
            }
            Color green = Color.FromArgb(46, 204, 142);
            using (var ib = new SolidBrush(Color.FromArgb(40, green)))
                g.FillEllipse(ib, stat.X + 12, stat.Y + 13, 32, 32);
            TextRenderer.DrawText(g, "\u2191", BadgeFont, new Rectangle((int)stat.X + 12, (int)stat.Y + 13, 32, 32), green,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
            TextRenderer.DrawText(g, "Penjualan", StatLabelFont, new Rectangle((int)stat.X + 54, (int)stat.Y + 9, 106, 16),
                Color.FromArgb(120, 132, 158), TextFormatFlags.Left | TextFormatFlags.NoPadding);
            TextRenderer.DrawText(g, "+12%", StatValueFont, new Rectangle((int)stat.X + 54, (int)stat.Y + 26, 106, 24),
                Color.FromArgb(22, 41, 94), TextFormatFlags.Left | TextFormatFlags.NoPadding);

            // ikon kotak 3D (barang)
            float cx0 = 64f, cy0 = 452f;
            var topF = new PointF[] { new PointF(cx0, cy0 - 22), new PointF(cx0 + 22, cy0 - 11), new PointF(cx0, cy0), new PointF(cx0 - 22, cy0 - 11) };
            var leftF = new PointF[] { new PointF(cx0 - 22, cy0 - 11), new PointF(cx0, cy0), new PointF(cx0, cy0 + 24), new PointF(cx0 - 22, cy0 + 13) };
            var rightF = new PointF[] { new PointF(cx0, cy0), new PointF(cx0 + 22, cy0 - 11), new PointF(cx0 + 22, cy0 + 13), new PointF(cx0, cy0 + 24) };
            using (var b = new SolidBrush(Color.FromArgb(220, 255, 255, 255))) g.FillPolygon(b, topF);
            using (var b = new SolidBrush(Color.FromArgb(130, 255, 255, 255))) g.FillPolygon(b, leftF);
            using (var b = new SolidBrush(Color.FromArgb(80, 255, 255, 255))) g.FillPolygon(b, rightF);

            // ubin barcode
            var tile = new RectangleF(106, 438, 70, 40);
            using (var path = SmkGfx.Round(tile, 12))
            using (var fill = new SolidBrush(Color.FromArgb(36, 255, 255, 255)))
            using (var pen = new Pen(Color.FromArgb(90, 255, 255, 255), 1f))
            {
                g.FillPath(fill, path);
                g.DrawPath(pen, path);
            }
            int[] bars = { 2, 1, 3, 1, 2, 1, 3, 2, 1, 2 };
            float bx0 = tile.X + 12;
            using (var b = new SolidBrush(Color.FromArgb(215, 255, 255, 255)))
                foreach (int bwid in bars)
                {
                    g.FillRectangle(b, bx0, tile.Y + 9, bwid, 22);
                    bx0 += bwid + 3;
                }

            // pill footer
            if (_footer.Length > 0)
            {
                Size sz = TextRenderer.MeasureText(_footer, FooterFont);
                var pill = new RectangleF((w - (sz.Width + 44)) / 2f, h - 76, sz.Width + 44, 38);
                using (var path = SmkGfx.Round(pill, 19))
                using (var fill = new SolidBrush(Color.FromArgb(40, 255, 255, 255)))
                using (var pen = new Pen(Color.FromArgb(90, 255, 255, 255), 1f))
                {
                    g.FillPath(fill, path);
                    g.DrawPath(pen, path);
                }
                TextRenderer.DrawText(g, _footer, FooterFont,
                    new Rectangle((int)pill.X, (int)pill.Y, (int)pill.Width, (int)pill.Height), Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
            }
        }
    }

    /// <summary>Panel kanan: latar biru muda bergradasi + bulatan dekoratif + kartu putih berbayang.</summary>
    [DesignerCategory("Code")]
    public class SmkSoftPanel : Panel
    {
        private Color _top = Color.FromArgb(76, 102, 255);
        private Color _bottom = Color.FromArgb(40, 175, 255);
        private int _mx = 28, _my = 24;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color AccentTop { get { return _top; } set { _top = value; Invalidate(); } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color AccentBottom { get { return _bottom; } set { _bottom = value; Invalidate(); } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CardMarginX { get { return _mx; } set { _mx = value; Invalidate(); } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CardMarginY { get { return _my; } set { _my = value; Invalidate(); } }

        public SmkSoftPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var rc = ClientRectangle;
            if (rc.Width < 100 || rc.Height < 100) return;
            float w = Width, h = Height;

            // latar biru muda
            using (var br = new LinearGradientBrush(rc, Color.FromArgb(244, 248, 255), Color.FromArgb(216, 232, 255), 60f))
                g.FillRectangle(br, rc);

            // bulatan dekoratif (mengintip di sekitar kartu)
            using (var b = new SolidBrush(Color.FromArgb(40, _top)))
                g.FillEllipse(b, w - 150, -90, 260, 260);
            using (var b = new SolidBrush(Color.FromArgb(34, _bottom)))
                g.FillEllipse(b, -100, h - 170, 270, 270);
            using (var b = new SolidBrush(Color.FromArgb(26, _top)))
                g.FillEllipse(b, w - 74, h - 112, 124, 124);
            using (var pen = new Pen(Color.FromArgb(90, _bottom), 1.6f))
                g.DrawEllipse(pen, -34, 76, 92, 92);

            // kartu putih + bayangan lembut
            var card = new RectangleF(_mx, _my, w - 2 * _mx, h - 2 * _my);
            for (int i = 0; i < 7; i++)
            {
                var r = RectangleF.Inflate(card, i * 2f, i * 2f);
                r.Offset(0, 6);
                using (var sp = SmkGfx.Round(r, 26 + i * 2))
                using (var sb = new SolidBrush(Color.FromArgb(9, 30, 60, 140)))
                    g.FillPath(sb, sp);
            }

            using (var path = SmkGfx.Round(card, 26))
            {
                g.FillPath(Brushes.White, path);

                var state = g.Save();
                g.SetClip(path, CombineMode.Intersect);

                // garis aksen di atas kartu
                var bar = new RectangleF(card.X, card.Y, card.Width, 6);
                using (var lg = new LinearGradientBrush(bar, _top, _bottom, 0f))
                    g.FillRectangle(lg, bar);

                // lingkaran lembut di pojok kanan atas kartu
                using (var b = new SolidBrush(Color.FromArgb(22, _bottom)))
                    g.FillEllipse(b, card.Right - 120, card.Y - 60, 190, 190);
                using (var pen = new Pen(Color.FromArgb(60, _top), 1.4f))
                    g.DrawEllipse(pen, card.Right - 78, card.Y + 22, 64, 64);

                g.Restore(state);
            }
        }
    }

    /// <summary>Kotak input membulat; border berubah warna saat isinya fokus.</summary>
    [DesignerCategory("Code")]
    public class SmkRoundPanel : Panel
    {
        private int _radius = 24;
        private Color _fill = Color.White;
        private Color _border = Color.FromArgb(205, 215, 235);
        private Color _focus = Color.FromArgb(76, 102, 255);
        private bool _focused;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CornerRadius { get { return _radius; } set { _radius = value; Invalidate(); } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color FillColor { get { return _fill; } set { _fill = value; Invalidate(); } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor { get { return _border; } set { _border = value; Invalidate(); } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color FocusColor { get { return _focus; } set { _focus = value; Invalidate(); } }

        public SmkRoundPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.Enter += (s, a) => { _focused = true; Invalidate(); };
            e.Control.Leave += (s, a) => { _focused = false; Invalidate(); };
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            foreach (Control c in Controls)
                if (c is TextBox) { c.Focus(); break; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Parent != null ? Parent.BackColor : BackColor);

            var rect = new RectangleF(0.75f, 0.75f, Width - 2f, Height - 2f);
            if (rect.Width < 4 || rect.Height < 4) return;
            using (var path = SmkGfx.Round(rect, _radius))
            using (var fill = new SolidBrush(_fill))
            using (var pen = new Pen(_focused ? _focus : _border, _focused ? 1.8f : 1.4f))
            {
                g.FillPath(fill, path);
                g.DrawPath(pen, path);
            }
        }
    }

    /// <summary>Tombol pill dengan gradasi horizontal + efek hover/tekan.</summary>
    [DesignerCategory("Code")]
    public class SmkRoundButton : Button
    {
        private Color _c1 = Color.FromArgb(76, 102, 255);
        private Color _c2 = Color.FromArgb(40, 175, 255);
        private int _radius = 25;
        private bool _hover, _down;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ColorStart { get { return _c1; } set { _c1 = value; Invalidate(); } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color ColorEnd { get { return _c2; } set { _c2 = value; Invalidate(); } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int CornerRadius { get { return _radius; } set { _radius = value; Invalidate(); } }

        public SmkRoundButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
            ForeColor = Color.White;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; _down = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs e) { _down = true; Invalidate(); base.OnMouseDown(e); }
        protected override void OnMouseUp(MouseEventArgs e) { _down = false; Invalidate(); base.OnMouseUp(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Parent != null ? Parent.BackColor : BackColor);

            var rect = new RectangleF(0, 0, Width - 1, Height - 1);
            if (rect.Width < 4 || rect.Height < 4) return;

            Color a = _c1, b = _c2;
            if (!Enabled) { a = Color.FromArgb(170, 180, 205); b = a; }
            else if (_down) { a = ControlPaint.Dark(a, 0.1f); b = ControlPaint.Dark(b, 0.1f); }
            else if (_hover) { a = ControlPaint.Light(a, 0.2f); b = ControlPaint.Light(b, 0.2f); }

            using (var path = SmkGfx.Round(rect, _radius))
            using (var br = new LinearGradientBrush(rect, a, b, 0f))
                g.FillPath(br, path);

            TextRenderer.DrawText(g, Text, Font, Rectangle.Round(rect), Color.White,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter |
                TextFormatFlags.NoPadding | TextFormatFlags.EndEllipsis);
        }
    }

    /// <summary>TextBox dengan placeholder (cue banner).</summary>
    [DesignerCategory("Code")]
    public class SmkTextBox : TextBox
    {
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        private string _placeholder = "";

        [DefaultValue("")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Placeholder
        {
            get { return _placeholder; }
            set { _placeholder = value ?? ""; Apply(); }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Apply();
        }

        private void Apply()
        {
            if (IsHandleCreated) SendMessage(Handle, 0x1501, (IntPtr)1, _placeholder);
        }
    }
}