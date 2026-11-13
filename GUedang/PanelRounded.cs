using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace GUedang
{
    public class PanelRounded: Panel
    {
        private int cornerRadius = 20;
        private Color panelColor = Color.White;
        private Color borderColor = Color.Transparent;
        private int borderSize = 0;

        [Category("Custom Appearance")]
        [Description("Menentukan tingkat kelengkungan sudut panel.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CornerRadius
        {
            get => cornerRadius;
            set { cornerRadius = value; this.Invalidate(); }
        }

        [Category("Custom Appearance")]
        [Description("Warna latar belakang dari rounded panel.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color PanelColor
        {
            get => panelColor;
            set { panelColor = value; this.Invalidate(); }
        }

        [Category("Custom Appearance")]
        [Description("Warna garis pinggir (border) panel.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("Custom Appearance")]
        [Description("Ketebalan garis pinggir (border) panel.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; this.Invalidate(); }
        }

        public PanelRounded()
        {
            // Mengaktifkan DoubleBuffering agar tidak kedip-kedip saat dirender ulang
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            this.Size = new Size(300, 200);
            this.BackColor = Color.Transparent;
        }

        // Fungsi bantu untuk membuat jalur (path) sudut melengkung
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int curveSize = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -1, -1);

            int currentRadius = cornerRadius;
            if (currentRadius > rectSurface.Height / 2)
                currentRadius = rectSurface.Height / 2;

            if (currentRadius > 2)
            {
                // Menggambar Background Panel dengan sudut melengkung
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, currentRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, currentRadius))
                using (SolidBrush brushSurface = new SolidBrush(panelColor))
                {
                    // Isi warna panel
                    e.Graphics.FillPath(brushSurface, pathSurface);

                    // Gambar Border jika ukurannya >= 1 dan tidak transparan
                    if (borderSize >= 1 && borderColor != Color.Transparent)
                    {
                        using (Pen penBorder = new Pen(borderColor, borderSize))
                        {
                            penBorder.Alignment = PenAlignment.Center;
                            e.Graphics.DrawPath(penBorder, pathBorder);
                        }
                    }
                }
            }
            else
            {
                // Jika sudut kecil/tajam (tidak melengkung)
                using (SolidBrush brushSurface = new SolidBrush(panelColor))
                {
                    e.Graphics.FillRectangle(brushSurface, rectSurface);
                    if (borderSize >= 1 && borderColor != Color.Transparent)
                    {
                        using (Pen penBorder = new Pen(borderColor, borderSize))
                        {
                            e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                        }
                    }
                }
            }
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            this.Invalidate();
        }
    }
}