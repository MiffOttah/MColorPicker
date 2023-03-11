namespace MColorPicker.Components
{
    partial class RgbSliders
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RedSlider = new MColorPicker.SliderWithValue();
            this.GreenSlider = new MColorPicker.SliderWithValue();
            this.BlueSlider = new MColorPicker.SliderWithValue();
            this.SuspendLayout();
            // 
            // RedSlider
            // 
            this.RedSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.RedSlider.Label = "R";
            this.RedSlider.Location = new System.Drawing.Point(0, 0);
            this.RedSlider.Name = "RedSlider";
            this.RedSlider.Size = new System.Drawing.Size(150, 30);
            this.RedSlider.TabIndex = 0;
            this.RedSlider.ValueChanged += new System.EventHandler(this.SliderValueChanged);
            // 
            // GreenSlider
            // 
            this.GreenSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.GreenSlider.Label = "G";
            this.GreenSlider.Location = new System.Drawing.Point(0, 30);
            this.GreenSlider.Name = "GreenSlider";
            this.GreenSlider.Size = new System.Drawing.Size(150, 30);
            this.GreenSlider.TabIndex = 1;
            this.GreenSlider.ValueChanged += new System.EventHandler(this.SliderValueChanged);
            // 
            // BlueSlider
            // 
            this.BlueSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.BlueSlider.Label = "B";
            this.BlueSlider.Location = new System.Drawing.Point(0, 60);
            this.BlueSlider.Name = "BlueSlider";
            this.BlueSlider.Size = new System.Drawing.Size(150, 30);
            this.BlueSlider.TabIndex = 2;
            this.BlueSlider.ValueChanged += new System.EventHandler(this.SliderValueChanged);
            // 
            // RgbSliders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BlueSlider);
            this.Controls.Add(this.GreenSlider);
            this.Controls.Add(this.RedSlider);
            this.Name = "RgbSliders";
            this.ResumeLayout(false);

        }

        #endregion

        private SliderWithValue RedSlider;
        private SliderWithValue GreenSlider;
        private SliderWithValue BlueSlider;
    }
}
