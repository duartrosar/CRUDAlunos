namespace WinFormsAlunos
{
    partial class FormIndex
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
            this.btnAlunos = new System.Windows.Forms.Button();
            this.btnDisciplinas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlunos
            // 
            this.btnAlunos.Location = new System.Drawing.Point(47, 80);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(93, 67);
            this.btnAlunos.TabIndex = 12;
            this.btnAlunos.Text = "Alunos";
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // btnDisciplinas
            // 
            this.btnDisciplinas.Location = new System.Drawing.Point(146, 80);
            this.btnDisciplinas.Name = "btnDisciplinas";
            this.btnDisciplinas.Size = new System.Drawing.Size(93, 67);
            this.btnDisciplinas.TabIndex = 13;
            this.btnDisciplinas.Text = "Disciplinas";
            this.btnDisciplinas.UseVisualStyleBackColor = true;
            this.btnDisciplinas.Click += new System.EventHandler(this.btnDisciplinas_Click);
            // 
            // FormIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 226);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.btnDisciplinas);
            this.Name = "FormIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAlunos;
        private Button btnDisciplinas;
    }
}