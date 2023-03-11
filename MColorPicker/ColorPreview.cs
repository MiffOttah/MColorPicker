using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MColorPicker
{
    internal class ColorPreview : Control
    {
        Color _Color = Color.Black;

        public Color PreviewColor
        {
            get => _Color;
            set
            {
                _Color = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(_Color);

            base.OnPaint(e);
        }
    }
}
