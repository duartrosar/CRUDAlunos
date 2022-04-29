namespace WinFormsAlunos
{
    partial class FormDisciplinas
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
            this.listBoxDisciplinas = new System.Windows.Forms.ListBox();
            this.btnEditarDisciplina = new System.Windows.Forms.Button();
            this.btnApagarDisciplina = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdDisciplina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxDisciplinas
            // 
            this.listBoxDisciplinas.FormattingEnabled = true;
            this.listBoxDisciplinas.ItemHeight = 15;
            this.listBoxDisciplinas.Location = new System.Drawing.Point(16, 256);
            this.listBoxDisciplinas.Name = "listBoxDisciplinas";
            this.listBoxDisciplinas.Size = new System.Drawing.Size(515, 139);
            this.listBoxDisciplinas.TabIndex = 16;
            // 
            // btnEditarDisciplina
            // 
            this.btnEditarDisciplina.Location = new System.Drawing.Point(415, 401);
            this.btnEditarDisciplina.Name = "btnEditarDisciplina";
            this.btnEditarDisciplina.Size = new System.Drawing.Size(116, 23);
            this.btnEditarDisciplina.TabIndex = 18;
            this.btnEditarDisciplina.Text = "Editar Disciplina";
            this.btnEditarDisciplina.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarDisciplina.UseVisualStyleBackColor = true;
            this.btnEditarDisciplina.Click += new System.EventHandler(this.btnEditarDisciplina_Click);
            // 
            // btnApagarDisciplina
            // 
            this.btnApagarDisciplina.Location = new System.Drawing.Point(293, 401);
            this.btnApagarDisciplina.Name = "btnApagarDisciplina";
            this.btnApagarDisciplina.Size = new System.Drawing.Size(116, 23);
            this.btnApagarDisciplina.TabIndex = 17;
            this.btnApagarDisciplina.Text = "Apagar Disciplina";
            this.btnApagarDisciplina.UseVisualStyleBackColor = true;
            this.btnApagarDisciplina.Click += new System.EventHandler(this.btnApagarDisciplina_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(113, 214);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 23);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(212, 214);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(113, 151);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(192, 23);
            this.txtDescription.TabIndex = 13;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(113, 88);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(192, 23);
            this.txtNome.TabIndex = 8;
            // 
            // txtIdDisciplina
            // 
            this.txtIdDisciplina.Enabled = false;
            this.txtIdDisciplina.Location = new System.Drawing.Point(113, 25);
            this.txtIdDisciplina.Name = "txtIdDisciplina";
            this.txtIdDisciplina.Size = new System.Drawing.Size(192, 23);
            this.txtIdDisciplina.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(51, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id disciplina:";
            // 
            // FormDisciplinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 449);
            this.Controls.Add(this.listBoxDisciplinas);
            this.Controls.Add(this.btnEditarDisciplina);
            this.Controls.Add(this.btnApagarDisciplina);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtIdDisciplina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDisciplinas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDisciplinas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxDisciplinas;
        private Button btnEditarDisciplina;
        private Button btnApagarDisciplina;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtDescription;
        private TextBox txtNome;
        private TextBox txtIdDisciplina;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}