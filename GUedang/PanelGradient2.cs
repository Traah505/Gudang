using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUedang
{
    [ToolboxItem(true)]
    public class PanelGradient : Panel
    {
        public PanelGradient()
        {
            DoubleBuffered = true;
            ResizeRedraw = true;
        }

        [Category("Gradient")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ColorTop { get; set; } = Color.FromArgb(38, 119, 74);

        [Category("Gradient")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ColorBottom { get; set; } = Color.FromArgb(26, 90, 56);

        [Category("Gradient")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float Angle { get; set; } = 90f;

        [Category("Gradient")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public float GradientHeightFraction { get; set; } = 0.5f;

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (Width <= 0 || Height <= 0) return;

            try
            {
                using var b = new LinearGradientBrush(ClientRectangle, ColorTop, ColorBottom, Angle == 0 ? 0.001f : Angle);

                b.InterpolationColors = new ColorBlend(3)
                {
                    Colors = new Color[] { ColorTop, ColorBottom, ColorBottom },
                    Positions = new float[] { 0.0f, GradientHeightFraction, 1.0f }
                };

                e.Graphics.FillRectangle(b, ClientRectangle);
            }
            catch
            {
                base.OnPaintBackground(e);
            }
        }

        public void DrawBackground(Graphics g, Control child)
        {
            if (Width <= 0 || Height <= 0) return;

            try
            {
                using var b = new LinearGradientBrush(ClientRectangle, ColorTop, ColorBottom, Angle == 0 ? 0.001f : Angle);
                b.InterpolationColors = new ColorBlend(3)
                {
                    Colors = new Color[] { ColorTop, ColorBottom, ColorBottom },
                    Positions = new float[] { 0.0f, GradientHeightFraction, 1.0f }
                };

                g.TranslateTransform(-child.Location.X, -child.Location.Y);
                g.FillRectangle(b, ClientRectangle);
                g.ResetTransform();
            }
            catch
            {
                // Fallback jika terjadi error transformasi
            }
        }
    }
}