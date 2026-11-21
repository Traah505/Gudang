using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUedang
{
    /// <summary>
    /// Panel dengan sudut membulat, border tipis, dan (opsional) garis aksen di sisi kiri.
    /// Dipakai untuk header, kartu statistik, dan panel isi dashboard.
    /// </summary>
    public class RoundedPanelUI : Panel
    {
        [DefaultValue(16)]
        public int Radius { get; set; } = 16;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor { get; set; } = Color.FromArgb(214, 228, 245);
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color AccentColor { get; set; } = Color.Transparent;

        [DefaultValue(5)]
        public int AccentWidth { get; set; } = 5;

        public RoundedPanelUI()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Color back = Parent != null ? Parent.BackColor : SystemColors.Control;
            using (var b = new SolidBrush(back))
                e.Graphics.FillRectangle(b, ClientRectangle);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var path = RoundedRect(rect, Radius))
            using (var fill = new SolidBrush(BackColor))
            using (var pen = new Pen(BorderColor))
            {
                e.Graphics.FillPath(fill, path);
                e.Graphics.DrawPath(pen, path);
            }

            if (AccentColor != Color.Transparent && Height > 40)
            {
                var bar = new Rectangle(14, 18, AccentWidth, Height - 36);
                using (var path = RoundedRect(bar, AccentWidth / 2))
                using (var b = new SolidBrush(AccentColor))
                    e.Graphics.FillPath(b, path);
            }
        }

        internal static GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            int d = Math.Max(1, radius * 2);
            var p = new GraphicsPath();
            p.AddArc(r.X, r.Y, d, d, 180, 90);
            p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            p.CloseFigure();
            return p;
        }
    }

    /// <summary>Tombol membulat dengan efek hover.</summary>
    public class RoundedButtonUI : Button
    {
        private bool _hover;

        [DefaultValue(18)]
        public int Radius { get; set; } = 18;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color HoverColor { get; set; } = Color.FromArgb(21, 101, 192);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor { get; set; } = Color.Transparent;

        public RoundedButtonUI()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Cursor = Cursors.Hand;
        }

        protected override void OnMouseEnter(EventArgs e) { _hover = true; Invalidate(); base.OnMouseEnter(e); }
        protected override void OnMouseLeave(EventArgs e) { _hover = false; Invalidate(); base.OnMouseLeave(e); }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Color back = (Parent != null && Parent.BackColor.A > 0) ? Parent.BackColor : SystemColors.Control;
            g.Clear(back);

            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            using (var path = RoundedPanelUI.RoundedRect(rect, Radius))
            using (var fill = new SolidBrush(_hover ? HoverColor : BackColor))
            {
                g.FillPath(fill, path);
                if (BorderColor != Color.Transparent)
                    using (var pen = new Pen(BorderColor, 1.5f))
                        g.DrawPath(pen, path);
            }

            TextRenderer.DrawText(g, Text, Font, ClientRectangle, ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis);
        }
    }

    /// <summary>Gaya seragam untuk semua DataGridView dashboard.</summary>
    public static class UiStyle
    {
        public static readonly Color Biru = Color.FromArgb(30, 136, 229);
        public static readonly Color BiruTua = Color.FromArgb(13, 47, 110);

        public static void ApplyGrid(DataGridView g)
        {
            g.BackgroundColor = Color.White;
            g.BorderStyle = BorderStyle.None;
            g.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            g.GridColor = Color.FromArgb(225, 236, 247);
            g.EnableHeadersVisualStyles = false;
            g.RowHeadersVisible = false;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.AllowUserToResizeRows = false;
            g.ReadOnly = true;
            g.MultiSelect = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            g.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            g.ColumnHeadersHeight = 34;
            g.ColumnHeadersDefaultCellStyle.BackColor = Biru;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.SelectionBackColor = Biru;
            g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            g.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            g.ColumnHeadersDefaultCellStyle.Padding = new Padding(6, 0, 6, 0);

            g.RowTemplate.Height = 30;
            g.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            g.DefaultCellStyle.ForeColor = Color.FromArgb(30, 50, 90);
            g.DefaultCellStyle.SelectionBackColor = Color.FromArgb(187, 222, 251);
            g.DefaultCellStyle.SelectionForeColor = BiruTua;
            g.DefaultCellStyle.Padding = new Padding(6, 0, 6, 0);
            g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(244, 249, 255);
        }
    }
}