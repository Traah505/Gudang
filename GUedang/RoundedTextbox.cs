using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUedang
{
    /// <summary>
    /// TextBox satu baris dengan sudut membulat.
    /// Turunan Control; di dalamnya ada TextBox asli (tanpa border) yang dibuat
    /// di konstruktor dan ditambahkan ke Controls.
    /// </summary>
    [ToolboxItem(true)]
    [DefaultProperty("Text")]
    [DefaultEvent("TextChanged")]
    [DesignerCategory("Code")]
    public class RoundedTextBox : Control
    {
        #region Field

        // Dibuat lewat field initializer, jadi tidak pernah null (aman walau
        // dipanggil dari konstruktor base class).
        private readonly TextBox _textBox = new TextBox();

        private int _cornerRadius = 12;
        private int _borderThickness = 1;
        private Color _borderColor = Color.Gray;
        private Color _backColor = SystemColors.Window;
        private Color _foreColor = SystemColors.WindowText;

        #endregion

        #region Konstruktor

        public RoundedTextBox()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw,
                true);

            // Fokus keyboard dipegang TextBox internal, bukan control luar.
            SetStyle(ControlStyles.Selectable, false);

            _textBox.BorderStyle = BorderStyle.None;
            _textBox.BackColor = _backColor;
            _textBox.ForeColor = _foreColor;
            _textBox.Font = Font;

            _textBox.TextChanged += TextBox_TextChanged;
            _textBox.KeyDown += TextBox_KeyDown;
            _textBox.KeyPress += TextBox_KeyPress;
            _textBox.KeyUp += TextBox_KeyUp;

            Controls.Add(_textBox);

            UpdateTextBoxLayout();
        }

        #endregion

        #region Properti kustom

        [Category("Appearance")]
        [Description("Radius sudut dalam piksel. Nilai 0 membuat sudut siku-siku.")]
        [DefaultValue(12)]
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                if (value < 0) value = 0;
                if (_cornerRadius == value) return;
                _cornerRadius = value;
                UpdateTextBoxLayout();
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Warna garis tepi.")]
        [DefaultValue(typeof(Color), "Gray")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                if (value.IsEmpty) value = Color.Gray;
                if (_borderColor == value) return;
                _borderColor = value;
                Invalidate();
            }
        }

        [Category("Appearance")]
        [Description("Ketebalan garis tepi dalam piksel. Nilai 0 menghilangkan garis tepi.")]
        [DefaultValue(1)]
        public int BorderThickness
        {
            get { return _borderThickness; }
            set
            {
                if (value < 0) value = 0;
                if (_borderThickness == value) return;
                _borderThickness = value;
                EnsureMinimumHeight();
                UpdateTextBoxLayout();
                Invalidate();
            }
        }

        [Category("Behavior")]
        [Description("Jika True, teks disembunyikan dengan karakter password bawaan sistem.")]
        [DefaultValue(false)]
        public bool UseSystemPasswordChar
        {
            get { return _textBox.UseSystemPasswordChar; }
            set { _textBox.UseSystemPasswordChar = value; }
        }

        [Category("Appearance")]
        [Description("Perataan teks di dalam kotak.")]
        [DefaultValue(HorizontalAlignment.Left)]
        public HorizontalAlignment TextAlign
        {
            get { return _textBox.TextAlign; }
            set { _textBox.TextAlign = value; }
        }

        [Category("Behavior")]
        [Description("Jumlah karakter maksimum yang boleh diketik.")]
        [DefaultValue(32767)]
        public int MaxLength
        {
            get { return _textBox.MaxLength; }
            set { _textBox.MaxLength = value; }
        }

        [Category("Behavior")]
        [Description("Jika True, teks tidak dapat diubah oleh pengguna.")]
        [DefaultValue(false)]
        public bool ReadOnly
        {
            get { return _textBox.ReadOnly; }
            set { _textBox.ReadOnly = value; }
        }

        #endregion

        #region Properti bawaan yang di-override

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [Localizable(true)]
        [Category("Appearance")]
        [Description("Teks yang ditampilkan di dalam kotak.")]
        [DefaultValue("")]
        public override string Text
        {
            get { return _textBox.Text; }
            set
            {
                // Saat control di-drop dari Toolbox, Visual Studio kadang mengisi Text
                // dengan nama control (mis. "roundedTextBox1"). Itu diabaikan di sini.
                if (DesignMode && Site != null &&
                    string.Equals(value, Site.Name, StringComparison.Ordinal))
                {
                    return;
                }

                _textBox.Text = value;
            }
        }

        [Category("Appearance")]
        [Description("Warna isi (latar) kotak. Transparan tidak didukung.")]
        [DefaultValue(typeof(Color), "Window")]
        public override Color BackColor
        {
            get { return _backColor; }
            set
            {
                if (value.IsEmpty) value = SystemColors.Window;       // dipakai oleh Reset
                if (value.A < 255) value = Color.FromArgb(255, value); // TextBox tidak mendukung transparan
                if (_backColor == value) return;

                _backColor = value;
                _textBox.BackColor = value;
                Invalidate();
                OnBackColorChanged(EventArgs.Empty);
            }
        }

        [Category("Appearance")]
        [Description("Warna teks.")]
        [DefaultValue(typeof(Color), "WindowText")]
        public override Color ForeColor
        {
            get { return _foreColor; }
            set
            {
                if (value.IsEmpty) value = SystemColors.WindowText;   // dipakai oleh Reset
                if (_foreColor == value) return;

                _foreColor = value;
                _textBox.ForeColor = value;
                Invalidate();
                OnForeColorChanged(EventArgs.Empty);
            }
        }

        // Font memakai properti bawaan Control (termasuk perilaku ambient dari Form);
        // perubahannya diteruskan ke TextBox internal di OnFontChanged.

        protected override Size DefaultSize
        {
            get { return new Size(200, 32); }
        }

        #endregion

        #region Method publik

        public void SelectAll()
        {
            _textBox.SelectAll();
        }

        #endregion

        #region Override event / layout

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            _textBox.Font = Font;
            EnsureMinimumHeight();
            UpdateTextBoxLayout();
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateTextBoxLayout();
            Invalidate();
        }

        protected override void OnTabStopChanged(EventArgs e)
        {
            base.OnTabStopChanged(e);
            _textBox.TabStop = TabStop;
        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            Invalidate(); // warna di balik sudut mengikuti BackColor parent
        }

        protected override void OnParentBackColorChanged(EventArgs e)
        {
            base.OnParentBackColorChanged(e);
            Invalidate();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            if (_textBox.CanFocus)
            {
                _textBox.Focus();
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            // Klik di area padding (di luar TextBox internal) tetap memberi fokus ke TextBox.
            if (!_textBox.Focused)
            {
                _textBox.Focus();
            }
        }

        protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
        {
            // Tinggi tidak boleh lebih kecil dari yang dibutuhkan TextBox internal + border.
            int min = GetMinimumHeight();
            if (height < min)
            {
                height = min;
            }

            base.SetBoundsCore(x, y, width, height, specified);
        }

        #endregion

        #region Penggambaran

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Sengaja kosong: seluruh area digambar di OnPaint agar tidak berkedip.
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle client = ClientRectangle;

            if (client.Width > 0 && client.Height > 0)
            {
                // 1) Area di luar bentuk membulat diisi warna latar parent.
                using (SolidBrush outerBrush = new SolidBrush(GetOuterColor()))
                {
                    g.FillRectangle(outerBrush, client);
                }

                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.PixelOffsetMode = PixelOffsetMode.Half;

                // 2) Garis tepi digambar di tengah path, jadi path digeser setengah
                //    ketebalan ke dalam supaya garis tidak terpotong.
                float half = _borderThickness / 2f;
                RectangleF rect = new RectangleF(
                    half,
                    half,
                    client.Width - _borderThickness,
                    client.Height - _borderThickness);

                if (rect.Width > 0f && rect.Height > 0f)
                {
                    float radius = Math.Min(_cornerRadius, Math.Min(rect.Width, rect.Height) / 2f);

                    // 3) Semua objek GDI+ dibuang lewat using (tidak ada kebocoran).
                    using (GraphicsPath path = CreateRoundedPath(rect, radius))
                    using (SolidBrush fillBrush = new SolidBrush(_backColor))
                    {
                        g.FillPath(fillBrush, path);

                        if (_borderThickness > 0)
                        {
                            using (Pen borderPen = new Pen(_borderColor, _borderThickness))
                            {
                                g.DrawPath(borderPen, path);
                            }
                        }
                    }
                }
            }

            base.OnPaint(e);
        }

        private static GraphicsPath CreateRoundedPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();

            if (radius < 0.5f)
            {
                path.AddRectangle(rect);
                return path;
            }

            float d = radius * 2f;

            path.AddArc(rect.X, rect.Y, d, d, 180f, 90f);                    // kiri-atas
            path.AddArc(rect.Right - d, rect.Y, d, d, 270f, 90f);            // kanan-atas
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0f, 90f);     // kanan-bawah
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90f, 90f);            // kiri-bawah
            path.CloseFigure();

            return path;
        }

        private Color GetOuterColor()
        {
            Control ancestor = Parent;
            while (ancestor != null)
            {
                Color c = ancestor.BackColor;
                if (c.A == 255)
                {
                    return c;
                }
                ancestor = ancestor.Parent;
            }
            return SystemColors.Control;
        }

        #endregion

        #region Layout internal

        private int GetMinimumHeight()
        {
            return _textBox.Height + (_borderThickness * 2) + 4;
        }

        private void EnsureMinimumHeight()
        {
            int min = GetMinimumHeight();
            if (Height < min)
            {
                Height = min; // SetBoundsCore menetapkan nilai akhirnya
            }
        }

        private int GetHorizontalInset()
        {
            float maxRadius = Math.Min(Width, Height) / 2f;
            float radius = Math.Min(_cornerRadius, maxRadius);
            return _borderThickness + 4 + (int)(radius * 0.3f);
        }

        private void UpdateTextBoxLayout()
        {
            int inset = GetHorizontalInset();
            int availableWidth = Math.Max(1, ClientSize.Width - (inset * 2));
            int textBoxHeight = _textBox.Height;
            int top = Math.Max(0, (ClientSize.Height - textBoxHeight) / 2);

            _textBox.SetBounds(inset, top, availableWidth, textBoxHeight);
        }

        #endregion

        #region Penerusan event dari TextBox internal

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            OnTextChanged(EventArgs.Empty);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // TextBox satu baris di .NET Framework tidak menangani Ctrl+A.
            if (e.Control && e.KeyCode == Keys.A)
            {
                _textBox.SelectAll();
                e.SuppressKeyPress = true;
            }

            OnKeyDown(e);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        #endregion
    }
}