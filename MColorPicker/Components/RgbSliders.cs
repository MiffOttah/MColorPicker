using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MColorPicker.Components
{
    internal partial class RgbSliders : UserControl, IPickerComponent
    {
        Color _LastColor;
        public Color SelectedColor {
            get => Color.FromArgb(RedSlider.Value, GreenSlider.Value, BlueSlider.Value);
            set => _UpdateColor(value);
        }

        private void _UpdateColor(Color value)
        {
            RedSlider.Value = value.R;
            GreenSlider.Value = value.G;
            BlueSlider.Value = value.B;
            if (!Helpers.ColorsAreEqual(value, _LastColor))
            {
                UpdateColor?.Invoke(this, new UpdateColorEventArgs(value));
            }
            _LastColor = value;
        }

        public string Title => "RGB";
        public event EventHandler<UpdateColorEventArgs>? UpdateColor;

        public RgbSliders()
        {
            InitializeComponent();
        }

        private void SliderValueChanged(object sender, EventArgs e)
        {
            _UpdateColor(SelectedColor);
        }
    }
}
