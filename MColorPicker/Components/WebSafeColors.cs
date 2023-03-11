using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MColorPicker.Components
{
    internal partial class WebSafeColors : UserControl, IPickerComponent
    {
        private static readonly Bitmap _WebSafePallete = _GenerateWebSafePallete();
        const int SquareSize = 16;

        Color _LastColor;
        public Color SelectedColor
        {
            get => _LastColor;
            set => _UpdateColor(value);
        }

        private void _UpdateColor(Color value)
        {
            if (!Helpers.ColorsAreEqual(value, _LastColor))
            {
                UpdateColor?.Invoke(this, new UpdateColorEventArgs(value));
            }
            _LastColor = value;
        }

        public string Title => "Web Colors";
        public event EventHandler<UpdateColorEventArgs>? UpdateColor;
        public WebSafeColors()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawImage(_WebSafePallete, new Point(SquareSize, SquareSize));
        }

        private static Bitmap _GenerateWebSafePallete()
        {
            const int alphaCombine = unchecked((int)0xFF_00_00_00);

            var bitmap = new Bitmap(SquareSize * 19, SquareSize * 12);
            using var g = Graphics.FromImage(bitmap);

            var lines = Properties.Resources.WebSafeColors.Split(',');

            ReadOnlySpan<char> line;
            Span<char> hexToParse = stackalloc char[6];

            int x = 0;
            int y = 0;

            foreach (var lineStr in lines)
            {
                line = lineStr.AsSpan().Trim();
                var lineParts = new string(line).Split(' ');
                foreach (var linePart in lineParts)
                {
                    hexToParse[0] = linePart[0];
                    hexToParse[1] = linePart[0];
                    hexToParse[2] = linePart[1];
                    hexToParse[3] = linePart[1];
                    hexToParse[4] = linePart[2];
                    hexToParse[5] = linePart[2];

                    int color = int.Parse(hexToParse, NumberStyles.AllowHexSpecifier, CultureInfo.InvariantCulture);
                    using var brush = new SolidBrush(Color.FromArgb(color | alphaCombine));
                    g.FillRectangle(brush, new Rectangle(x, y, SquareSize, SquareSize));
                    x += SquareSize;
                }

                x = 0;
                y += SquareSize;
            }

            return bitmap;
        }

        private void WebSafeColors_MouseUp(object sender, MouseEventArgs e)
        {
            int x = e.X - SquareSize;
            int y = e.Y - SquareSize;

            if (x >= 0 && x < _WebSafePallete.Width && y >= 0 && y < _WebSafePallete.Height)
            {
                SelectedColor = _WebSafePallete.GetPixel(x, y);
            }
        }
    }
}
