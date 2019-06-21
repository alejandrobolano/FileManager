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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudent));
            this.buttonSaveTxt = new System.Windows.Forms.Button();
            this.labelStudentId = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textStudentId = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.textDateOfBirth = new System.Windows.Forms.TextBox();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.radioButtonTxt = new System.Windows.Forms.RadioButton();
            this.radioButtonXML = new System.Windows.Forms.RadioButton();
            this.radioButtonJson = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spanishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSaveTxt
            // 
            resources.ApplyResources(this.buttonSaveTxt, "buttonSaveTxt");
            this.buttonSaveTxt.Name = "buttonSaveTxt";
            this.buttonSaveTxt.UseVisualStyleBackColor = true;
            this.buttonSaveTxt.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelStudentId
            // 
            resources.ApplyResources(this.labelStudentId, "labelStudentId");
            this.labelStudentId.Name = "labelStudentId";
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.Name = "labelName";
            // 
            // labelSurname
            // 
            resources.ApplyResources(this.labelSurname, "labelSurname");
            this.labelSurname.Name = "labelSurname";
            // 
            // labelDateOfBirth
            // 
            resources.ApplyResources(this.labelDateOfBirth, "labelDateOfBirth");
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            // 
            // textStudentId
            // 
            resources.ApplyResources(this.textStudentId, "textStudentId");
            this.textStudentId.Name = "textStudentId";
            this.textStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextStudentId_KeyPress);
            // 
            // textName
            // 
            resources.ApplyResources(this.textName, "textName");
            this.textName.Name = "textName";
            // 
            // textSurname
            // 
            resources.ApplyResources(this.textSurname, "textSurname");
            this.textSurname.Name = "textSurname";
            // 
            // textDateOfBirth
            // 
            resources.ApplyResources(this.textDateOfBirth, "textDateOfBirth");
            this.textDateOfBirth.Name = "textDateOfBirth";
            this.textDateOfBirth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextDateOfBirth_KeyPress);
            // 
            // buttonClearFields
            // 
            resources.ApplyResources(this.buttonClearFields, "buttonClearFields");
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.ButtonClearFields_Click);
            // 
            // radioButtonTxt
            // 
            resources.ApplyResources(this.radioButtonTxt, "radioButtonTxt");
            this.radioButtonTxt.Name = "radioButtonTxt";
            this.radioButtonTxt.TabStop = true;
            this.radioButtonTxt.UseVisualStyleBackColor = true;
            // 
            // radioButtonXML
            // 
            resources.ApplyResources(this.radioButtonXML, "radioButtonXML");
            this.radioButtonXML.Name = "radioButtonXML";
            this.radioButtonXML.TabStop = true;
            this.radioButtonXML.UseVisualStyleBackColor = true;
            // 
            // radioButtonJson
            // 
            resources.ApplyResources(this.radioButtonJson, "radioButtonJson");
            this.radioButtonJson.Checked = true;
            this.radioButtonJson.Name = "radioButtonJson";
            this.radioButtonJson.TabStop = true;
            this.radioButtonJson.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.spanishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItem_Click);
            // 
            // spanishToolStripMenuItem
            // 
            this.spanishToolStripMenuItem.Name = "spanishToolStripMenuItem";
            resources.ApplyResources(this.spanishToolStripMenuItem, "spanishToolStripMenuItem");
            this.spanishToolStripMenuItem.Click += new System.EventHandler(this.SpanishToolStripMenuItem_Click);
            // 
            // FormStudent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radioButtonJson);
            this.Controls.Add(this.radioButtonXML);
            this.Controls.Add(this.radioButtonTxt);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.textDateOfBirth);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textStudentId);
            this.Controls.Add(this.labelDateOfBirth);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelStudentId);
            this.Controls.Add(this.buttonSaveTxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStudent";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveTxt;
        private System.Windows.Forms.Label labelStudentId;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textStudentId;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.TextBox textDateOfBirth;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.RadioButton radioButtonTxt;
        private System.Windows.Forms.RadioButton radioButtonXML;
        private System.Windows.Forms.RadioButton radioButtonJson;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spanishToolStripMenuItem;
    }
}

