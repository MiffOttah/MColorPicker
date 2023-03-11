using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MColorPicker
{
    internal partial class SliderWithValue : UserControl
    {
        public SliderWithValue()
        {
            InitializeComponent();
        }

        // This event may fire when valu is not changed.
        public event EventHandler? ValueChanged;

        public TrackBar TrackBar => trackBar1;
        public int Value
        {
            get => trackBar1.Value;
            set => SetValue(value);
        }

        string? _Label;
        public string? Label
        {
            get => _Label;
            set
            {
                _Label = value;
                if (string.IsNullOrEmpty(value))
                {
                    label1.Visible = false;
                }
                else
                {
                    label1.Visible = true;
                    label1.Text = value;
                }
            }
        }

        public int LabelSize
        {
            get => label1.Width;
            set => label1.Width = value;
        }

        public void SetValue(int value, int? min = null, int? max = null)
        {
            if (min.HasValue) trackBar1.Minimum = min.Value;
            if (max.HasValue) trackBar1.Maximum = max.Value;

            if (TrackBar.Value != value)
            {
                TrackBar.Value = value;
                _UpdateValue();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            _UpdateValue();
        }

        private void _UpdateValue()
        {
            textBox1.Text = TrackBar.Value.ToString();
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                trackBar1.Value = Math.Clamp(value, trackBar1.Minimum, trackBar1.Maximum);
            }
            _UpdateValue();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            _UpdateValue();
        }
    }
}
