namespace FileManager.Presentation.WinSite
{
    partial class FormAirports
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboOrigin = new System.Windows.Forms.ComboBox();
            this.comboDestination = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboOrigin
            // 
            this.comboOrigin.FormattingEnabled = true;
            this.comboOrigin.Location = new System.Drawing.Point(62, 53);
            this.comboOrigin.Name = "comboOrigin";
            this.comboOrigin.Size = new System.Drawing.Size(441, 28);
            this.comboOrigin.TabIndex = 0;
            this.comboOrigin.SelectedIndexChanged += new System.EventHandler(this.ComboOrigin_SelectedIndexChanged);
            // 
            // comboDestination
            // 
            this.comboDestination.FormattingEnabled = true;
            this.comboDestination.Location = new System.Drawing.Point(62, 120);
            this.comboDestination.Name = "comboDestination";
            this.comboDestination.Size = new System.Drawing.Size(441, 28);
            this.comboDestination.TabIndex = 1;
            this.comboDestination.SelectedIndexChanged += new System.EventHandler(this.ComboDestination_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label";
            // 
            // FormAirports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(555, 234);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboDestination);
            this.Controls.Add(this.comboOrigin);
            this.Name = "FormAirports";
            this.Text = "Form Airports";
            this.Load += new System.EventHandler(this.FormAirports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboOrigin;
        private System.Windows.Forms.ComboBox comboDestination;
        private System.Windows.Forms.Label label1;
    }
}