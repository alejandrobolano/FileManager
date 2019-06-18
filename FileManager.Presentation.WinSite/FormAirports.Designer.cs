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
            // FormAirports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(555, 200);
            this.Controls.Add(this.comboDestination);
            this.Controls.Add(this.comboOrigin);
            this.Name = "FormAirports";
            this.Text = "Form Airports";
            this.Load += new System.EventHandler(this.FormAirports_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboOrigin;
        private System.Windows.Forms.ComboBox comboDestination;
    }
}