using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace GUedang
{
    public class RoundedPanel : Panel
    {
        private int cornerRadius = 30;
        private Color panelColor = Color.White;
        private Color borderColor = Color.Transparent;
        private int borderSize = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CornerRadius
        {
            get => cornerRadius;
            set
            {
                cornerRadius = value;
                this.Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color PanelColor
        {
            get => panelColor;
            set
            {
                panelColor = value;
                this.Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderSize
        {
            get => borderSize;
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public RoundedPanel()
        {
            this.DoubleBuffered = true;
            this.Size = new Size(350, 400);
            this.BackColor = Color.Transparent; // Latar belakang luar transparan agar sudut melengkung bersih
        }

        private GraphicsPath GetRoundedPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);

            if (cornerRadius > 2)
            {
                using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, cornerRadius))
                using (Brush brushPanel = new SolidBrush(panelColor))
                {
                    // Potong area kerja panel sesuai bentuk sudut melengkung
                    this.Region = new Region(pathSurface);

                    // Gambar isi panel
                    g.FillPath(brushPanel, pathSurface);

                    // Gambar border jika ada
                    if (borderSize >= 1)
                    {
                        using (Pen penBorder = new Pen(borderColor, borderSize))
                        {
                            penBorder.Alignment = PenAlignment.Inset;
                            g.DrawPath(penBorder, pathSurface);
                        }
                    }
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                using (Brush brushPanel = new SolidBrush(panelColor))
                {
                    g.FillRectangle(brushPanel, rectSurface);
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