using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace GUedang
{
    public class CurvedSplitPanel : Panel
    {
        private Color primaryColor = Color.FromArgb(24, 43, 73);      // Warna dasar (Biru)
        private Color secondaryColor = Color.FromArgb(249, 115, 22);   // Warna lengkungan (Oranye)

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color PrimaryColor
        {
            get => primaryColor;
            set
            {
                primaryColor = value;
                this.Invalidate();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color SecondaryColor
        {
            get => secondaryColor;
            set
            {
                secondaryColor = value;
                this.Invalidate();
            }
        }

        public CurvedSplitPanel()
        {
            // Mengaktifkan Double Buffering agar gambar mulus dan tidak kedip (flickering) saat di-resize
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw |
                          ControlStyles.UserPaint, true);

            this.Size = new Size(200, 400);
            this.BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            // Mengaktifkan AntiAlias agar garis kurva terlihat halus (tidak pecah-pecah)
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = this.Width;
            int h = this.Height;

            using (Brush brushPrimary = new SolidBrush(primaryColor))
            using (Brush brushSecondary = new SolidBrush(secondaryColor))
            {
                // 1. Mengisi seluruh area panel dengan warna utama (Biru)
                g.FillRectangle(brushPrimary, 0, 0, w, h);

                // 2. Menentukan titik-titik koordinat kurva untuk bagian oranye
                Point[] curvePoints = {
                    new Point(0, 0),                           // Pojok kiri atas
                    new Point((int)(w * 0.7), (int)(h * 0.25)),  // Titik lengkung atas
                    new Point((int)(w * 0.9), (int)(h * 0.5)),   // Puncak lengkung tengah
                    new Point((int)(w * 0.5), (int)(h * 0.75)),  // Titik lengkung bawah
                    new Point(0, h)                            // Pojok kiri bawah
                };

                // 3. Menggambar kurva tertutup dengan warna sekunder (Oranye)
                g.FillClosedCurve(brushSecondary, curvePoints);
            }
        }
    }
}