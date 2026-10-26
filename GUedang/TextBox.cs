using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUedang
{
    [DefaultEvent("TextChanged")]
    public class CustomTextBox : UserControl
    {
        // Fields
        private Color borderColor = Color.FromArgb(230, 230, 230);
        private Color borderFocusColor = Color.FromArgb(70, 130, 241);
        private int borderSize = 1;
        private int borderRadius = 6; // Diubah jadi 6 agar lengkungannya tipis/sedang (tidak terlalu bulat)

        private bool isFocused = false;
        private TextBox textBox1;
        private Image iconImage = null;
        private string placeholderText = "";
        private Color placeholderColor = Color.DarkGray;
        private bool isPlaceholder = false;

        public CustomTextBox()
        {
            textBox1 = new TextBox();
            this.SuspendLayout();

            // Setup internal TextBox
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.None;
            textBox1.Font = new Font("Segoe UI", 9.5F);
            textBox1.Enter += TextBox1_Enter;
            textBox1.Leave += TextBox1_Leave;
            textBox1.TextChanged += TextBox1_TextChanged;

            // Setup UserControl Container
            this.AutoScaleMode = AutoScaleMode.None;
            this.Controls.Add(textBox1);
            this.Padding = new Padding(10, 7, 10, 7);
            this.Size = new Size(250, 38);
            this.BackColor = Color.White;

            this.ResumeLayout(false);
            UpdateControlHeight();
        }

        // Properties
        [Category("Custom Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; this.Invalidate(); }
        }

        [Category("Custom Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BorderFocusColor
        {
            get => borderFocusColor;
            set => borderFocusColor = value;
        }

        [Category("Custom Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; this.Invalidate(); }
        }

        [Category("Custom Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }

        [Category("Custom Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image IconImage
        {
            get => iconImage;
            set
            {
                iconImage = value;
                UpdateTextBoxPosition();
                this.Invalidate();
            }
        }

        [Category("Custom Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string PlaceholderText
        {
            get => placeholderText;
            set
            {
                placeholderText = value;
                if (string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(value))
                {
                    SetPlaceholder();
                }
            }
        }

        [Category("Custom Properties")]
        public override string Text
        {
            get
            {
                if (isPlaceholder) return "";
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                RemovePlaceholder();
            }
        }

        [Category("Custom Properties")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool UseSystemPasswordChar { get; internal set; }

        // Methods / Events
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrEmpty(placeholderText))
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
            }
        }

        private void RemovePlaceholder()
        {
            if (isPlaceholder)
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
            }
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            this.OnTextChanged(e);
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

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
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int currentRadius = Math.Min(borderRadius, this.Height / 2);

            if (currentRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, currentRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, currentRadius))
                using (Pen penBorder = new Pen(isFocused ? borderFocusColor : borderColor, borderSize))
                {
                    this.Region = new Region(pathSurface);
                    g.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                using (Pen penBorder = new Pen(isFocused ? borderFocusColor : borderColor, borderSize))
                {
                    g.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }

            // Gambar Ikon (jika ada)
            int leftPadding = 10;
            if (iconImage != null)
            {
                int iconSize = 16;
                int iconY = (this.Height - iconSize) / 2;
                g.DrawImage(iconImage, new Rectangle(10, iconY, iconSize, iconSize));
                leftPadding = 32;
            }

            // Atur posisi TextBox internal
            textBox1.Location = new Point(leftPadding, (this.Height - textBox1.Height) / 2);
            textBox1.Width = this.Width - leftPadding - 10;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                txtHeight = TextRenderer.MeasureText("Text", this.Font).Height;
                textBox1.Height = txtHeight;
                this.Height = Math.Max(this.Height, textBox1.Height + this.Padding.Top + this.Padding.Bottom);
            }
        }

        private int txtHeight = 0;

        private void UpdateTextBoxPosition()
        {
            this.Invalidate();
        }
    }
}