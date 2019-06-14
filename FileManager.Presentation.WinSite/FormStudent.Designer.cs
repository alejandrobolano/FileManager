namespace FileManager.Presentation.WinSite
{
    partial class FormStudent
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textStudentId = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textDateOfBirth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(329, 209);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(143, 45);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelStudentId
            // 
            this.labelStudentId.AutoSize = true;
            this.labelStudentId.Location = new System.Drawing.Point(33, 35);
            this.labelStudentId.Name = "labelStudentId";
            this.labelStudentId.Size = new System.Drawing.Size(80, 20);
            this.labelStudentId.TabIndex = 1;
            this.labelStudentId.Text = "StudentId";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(33, 76);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(33, 117);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(74, 20);
            this.labelSurname.TabIndex = 3;
            this.labelSurname.Text = "Surname";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(33, 156);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(99, 20);
            this.labelDateOfBirth.TabIndex = 4;
            this.labelDateOfBirth.Text = "Date of Birth";
            // 
            // textStudentId
            // 
            this.textStudentId.Location = new System.Drawing.Point(158, 35);
            this.textStudentId.Name = "textStudentId";
            this.textStudentId.Size = new System.Drawing.Size(314, 26);
            this.textStudentId.TabIndex = 5;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(158, 76);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(314, 26);
            this.textName.TabIndex = 6;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(158, 117);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(314, 26);
            this.textSurname.TabIndex = 7;
            // 
            // textDateOfBirth
            // 
            this.textDateOfBirth.Location = new System.Drawing.Point(158, 156);
            this.textDateOfBirth.Name = "textDateOfBirth";
            this.textDateOfBirth.Size = new System.Drawing.Size(314, 26);
            this.textDateOfBirth.TabIndex = 8;
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 284);
            this.Controls.Add(this.textDateOfBirth);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textStudentId);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormStudent";
            this.Text = "Form Student";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textStudentId;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textDateOfBirth;
    }
}

