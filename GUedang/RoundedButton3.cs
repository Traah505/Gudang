using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUedang
{
    internal static class GfxUtil
    {
        public static GraphicsPath RoundRect(RectangleF r, float radius)
        {
            var path = new GraphicsPath();
            float d = Math.Min(radius * 2f, Math.Min(r.Width, r.Height));
            if (d <= 0.5f)
            {
                path.AddRectangle(r);
                return path;
            }
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        public static GraphicsPath RoundTop(RectangleF r, float radius)
        {
            var path = new GraphicsPath();
            float d = Math.Min(radius * 2f, Math.Min(r.Width, r.Height * 2f));
            if (d <= 0.5f)
            {
                path.AddRectangle(r);
                return path;
            }
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddLine(r.Right, r.Bottom, r.X, r.Bottom);
            path.CloseFigure();
            return path;
        }
    }

    /// <summary>Panel dengan sudut membulat (warna isi = BackColor).</summary>
    public class RoundedPanelDashboard : Panel
    {
        private int _radius = 16;
        private int _borderSize = 1;
        private Color _borderColor = Color.FromArgb(214, 228, 250);

        public RoundedPanelDashboard()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        }

        [Category("Rounded"), DefaultValue(16)]
        public int CornerRadius
        {
            get { return _radius; }
            set { _radius = Math.Max(0, value); Invalidate(); }
        }

        [Category("Rounded"), DefaultValue(1)]
        public int BorderSize
        {
            get { return _borderSize; }
            set { _borderSize = Math.Max(0, value); Invalidate(); }
        }

        [Category("Rounded")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; Invalidate(); }
        }
        private bool ShouldSerializeBorderColor() { return _borderColor != Color.FromArgb(214, 228, 250); }
        private void ResetBorderColor() { _borderColor = Color.FromArgb(214, 228, 250); }

        protected override void OnPaintBackground(PaintEventArgs e) { /* digambar di OnPaint */ }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Parent != null ? Parent.BackColor : SystemColors.Control);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new RectangleF(0, 0, Width - 1, Height - 1);
            using (GraphicsPath path = GfxUtil.RoundRect(rect, _radius))
            using (var fill = new SolidBrush(BackColor))
            {
                g.FillPath(fill, path);
                if (_borderSize > 0)
                    using (var pen = new Pen(_borderColor, _borderSize))
                        g.DrawPath(pen, path);
            }
        }
    }

    /// <summary>Tombol dengan sudut membulat + efek hover/klik.</summary>
    public class RoundedButton3 : Button
    {
        private int _radius = 12;
        private int _borderSize = 0;
        private Color _borderColor = Color.FromArgb(30, 100, 220);
        private Color _hoverColor = Color.Empty;
        private bool _over, _down;

        public RoundedButton3()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
        }

        [Category("Rounded"), DefaultValue(12)]
        public int CornerRadius { get { return _radius; } set { _radius = Math.Max(0, value); Invalidate(); } }

        [Category("Rounded"), DefaultValue(0)]
        public int BorderSize { get { return _borderSize; } set { _borderSize = Math.Max(0, value); Invalidate(); } }

        [Category("Rounded")]
        public Color BorderColor { get { return _borderColor; } set { _borderColor = value; Invalidate(); } }
        private bool ShouldSerializeBorderColor() { return _borderColor != Color.FromArgb(30, 100, 220); }
        private void ResetBorderColor() { _borderColor = Color.FromArgb(30, 100, 220); }

        [Category("Rounded")]
        public Color HoverColor { get { return _hoverColor; } set { _hoverColor = value; Invalidate(); } }
        private bool ShouldSerializeHoverColor() { return _hoverColor != Color.Empty; }
        private void ResetHoverColor() { _hoverColor = Color.Empty; }

        protected override void OnMouseEnter(EventArgs e) { _over = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _over = false; _down = false; Invalidate(); base.OnMouseLeave(e); }
        protected override void OnMouseDown(MouseEventArgs e) { _down = true; Invalidate(); base.OnMouseDown(e); }
        protected override void OnMouseUp(MouseEventArgs e) { _down = false; Invalidate(); base.OnMouseUp(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Parent != null ? Parent.BackColor : SystemColors.Control);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color warna = BackColor;
            if (_over || _down)
            {
                Color hv = _hoverColor.IsEmpty ? ControlPaint.Dark(BackColor, 0.08f) : _hoverColor;
                warna = _down ? ControlPaint.Dark(hv, 0.05f) : hv;
            }

            var rect = new RectangleF(0, 0, Width - 1, Height - 1);
            using (GraphicsPath path = GfxUtil.RoundRect(rect, _radius))
            using (var fill = new SolidBrush(warna))
            {
                g.FillPath(fill, path);
                if (_borderSize > 0)
                    using (var pen = new Pen(_borderColor, _borderSize))
                        g.DrawPath(pen, path);
            }

            TextRenderer.DrawText(g, Text, Font, ClientRectangle, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }
    }
}