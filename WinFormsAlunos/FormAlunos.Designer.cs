namespace WinFormsAlunos
{
    partial class FormAlunos
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdAluno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.listBoxAlunos = new System.Windows.Forms.ListBox();
            this.btnApagarAluno = new System.Windows.Forms.Button();
            this.btnEditarAluno = new System.Windows.Forms.Button();
            this.listBoxDisciplinasAluno = new System.Windows.Forms.ListBox();
            this.btnRemoverDisciplina = new System.Windows.Forms.Button();
            this.btnAdicionarDisciplina = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id de aluno:";
            // 
            // txtIdAluno
            // 
            this.txtIdAluno.Enabled = false;
            this.txtIdAluno.Location = new System.Drawing.Point(111, 27);
            this.txtIdAluno.Name = "txtIdAluno";
            this.txtIdAluno.Size = new System.Drawing.Size(192, 23);
            this.txtIdAluno.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(38, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Apelido:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(111, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(192, 23);
            this.txtNome.TabIndex = 0;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(111, 145);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(192, 23);
            this.txtApelido.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(210, 204);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(111, 204);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(93, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // listBoxAlunos
            // 
            this.listBoxAlunos.FormattingEnabled = true;
            this.listBoxAlunos.ItemHeight = 15;
            this.listBoxAlunos.Location = new System.Drawing.Point(14, 263);
            this.listBoxAlunos.Name = "listBoxAlunos";
            this.listBoxAlunos.Size = new System.Drawing.Size(192, 139);
            this.listBoxAlunos.TabIndex = 5;
            this.listBoxAlunos.SelectedIndexChanged += new System.EventHandler(this.listBoxAlunos_SelectedIndexChanged);
            // 
            // btnApagarAluno
            // 
            this.btnApagarAluno.Location = new System.Drawing.Point(14, 408);
            this.btnApagarAluno.Name = "btnApagarAluno";
            this.btnApagarAluno.Size = new System.Drawing.Size(93, 23);
            this.btnApagarAluno.TabIndex = 6;
            this.btnApagarAluno.Text = "Apagar Aluno";
            this.btnApagarAluno.UseVisualStyleBackColor = true;
            this.btnApagarAluno.Click += new System.EventHandler(this.btnApagarAluno_Click);
            // 
            // btnEditarAluno
            // 
            this.btnEditarAluno.Location = new System.Drawing.Point(113, 408);
            this.btnEditarAluno.Name = "btnEditarAluno";
            this.btnEditarAluno.Size = new System.Drawing.Size(93, 23);
            this.btnEditarAluno.TabIndex = 7;
            this.btnEditarAluno.Text = "Editar Aluno";
            this.btnEditarAluno.UseVisualStyleBackColor = true;
            this.btnEditarAluno.Click += new System.EventHandler(this.btnEditarAluno_Click);
            // 
            // listBoxDisciplinasAluno
            // 
            this.listBoxDisciplinasAluno.FormattingEnabled = true;
            this.listBoxDisciplinasAluno.ItemHeight = 15;
            this.listBoxDisciplinasAluno.Location = new System.Drawing.Point(210, 263);
            this.listBoxDisciplinasAluno.Name = "listBoxDisciplinasAluno";
            this.listBoxDisciplinasAluno.Size = new System.Drawing.Size(327, 139);
            this.listBoxDisciplinasAluno.TabIndex = 8;
            // 
            // btnRemoverDisciplina
            // 
            this.btnRemoverDisciplina.Location = new System.Drawing.Point(345, 408);
            this.btnRemoverDisciplina.Name = "btnRemoverDisciplina";
            this.btnRemoverDisciplina.Size = new System.Drawing.Size(93, 23);
            this.btnRemoverDisciplina.TabIndex = 6;
            this.btnRemoverDisciplina.Text = "Remover Disciplina";
            this.btnRemoverDisciplina.UseVisualStyleBackColor = true;
            // 
            // btnAdicionarDisciplina
            // 
            this.btnAdicionarDisciplina.Location = new System.Drawing.Point(444, 408);
            this.btnAdicionarDisciplina.Name = "btnAdicionarDisciplina";
            this.btnAdicionarDisciplina.Size = new System.Drawing.Size(93, 23);
            this.btnAdicionarDisciplina.TabIndex = 7;
            this.btnAdicionarDisciplina.Text = "Adicionar";
            this.btnAdicionarDisciplina.UseVisualStyleBackColor = true;
            this.btnAdicionarDisciplina.Click += new System.EventHandler(this.btnAdicionarDisciplina_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(210, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Disciplinas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Alunos:";
            // 
            // FormAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 443);
            this.Controls.Add(this.listBoxDisciplinasAluno);
            this.Controls.Add(this.listBoxAlunos);
            this.Controls.Add(this.btnAdicionarDisciplina);
            this.Controls.Add(this.btnEditarAluno);
            this.Controls.Add(this.btnRemoverDisciplina);
            this.Controls.Add(this.btnApagarAluno);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtApelido);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtIdAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAlunos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtIdAluno;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtApelido;
        private Button btnCancelar;
        private Button btnGuardar;
        private ListBox listBoxAlunos;
        private Button btnApagarAluno;
        private Button btnEditarAluno;
        private ListBox listBoxDisciplinasAluno;
        private Button btnRemoverDisciplina;
        private Button btnAdicionarDisciplina;
        private Label label5;
        private Label label6;
    }
}