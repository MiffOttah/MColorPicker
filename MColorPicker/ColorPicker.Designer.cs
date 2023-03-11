namespace MColorPicker
{
    partial class ColorPicker
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AlphaSlider = new MColorPicker.SliderWithValue();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelDialogButton = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.GraphicalTabs = new System.Windows.Forms.TabControl();
            this.SliderTabs = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Location = new System.Drawing.Point(12, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // AlphaSlider
            // 
            this.AlphaSlider.Label = "Alpha";
            this.AlphaSlider.LabelSize = 40;
            this.AlphaSlider.Location = new System.Drawing.Point(148, 408);
            this.AlphaSlider.Name = "AlphaSlider";
            this.AlphaSlider.Size = new System.Drawing.Size(200, 30);
            this.AlphaSlider.TabIndex = 1;
            this.AlphaSlider.Value = 255;
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(632, 393);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 45);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelDialogButton
            // 
            this.CancelDialogButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelDialogButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelDialogButton.Location = new System.Drawing.Point(713, 393);
            this.CancelDialogButton.Name = "CancelDialogButton";
            this.CancelDialogButton.Size = new System.Drawing.Size(75, 45);
            this.CancelDialogButton.TabIndex = 3;
            this.CancelDialogButton.Text = "Cancel";
            this.CancelDialogButton.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.GraphicalTabs);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.SliderTabs);
            this.splitContainer1.Size = new System.Drawing.Size(776, 375);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 4;
            // 
            // GraphicalTabs
            // 
            this.GraphicalTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphicalTabs.Location = new System.Drawing.Point(0, 0);
            this.GraphicalTabs.Name = "GraphicalTabs";
            this.GraphicalTabs.SelectedIndex = 0;
            this.GraphicalTabs.Size = new System.Drawing.Size(258, 375);
            this.GraphicalTabs.TabIndex = 0;
            // 
            // SliderTabs
            // 
            this.SliderTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SliderTabs.Location = new System.Drawing.Point(0, 0);
            this.SliderTabs.Name = "SliderTabs";
            this.SliderTabs.SelectedIndex = 0;
            this.SliderTabs.Size = new System.Drawing.Size(514, 375);
            this.SliderTabs.TabIndex = 0;
            // 
            // ColorPicker
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.CancelDialogButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.AlphaSlider);
            this.Controls.Add(this.groupBox1);
            this.Name = "ColorPicker";
            this.Text = "Color Picker";
            this.Load += new System.EventHandler(this.ColorPicker_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private SliderWithValue AlphaSlider;
        private Button OkButton;
        private Button CancelDialogButton;
        private SplitContainer splitContainer1;
        private TabControl GraphicalTabs;
        private TabControl SliderTabs;
    }
}