namespace ProjAvaliacao
{
    partial class Paciente
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
            this.NomeTxt = new System.Windows.Forms.TextBox();
            this.IdPacienteTxt = new System.Windows.Forms.TextBox();
            this.CpfTxt = new System.Windows.Forms.TextBox();
            this.FoneTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeletarBt = new System.Windows.Forms.Button();
            this.ConsultarBt = new System.Windows.Forms.Button();
            this.AlterarBt = new System.Windows.Forms.Button();
            this.InserirBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NomeTxt
            // 
            this.NomeTxt.Location = new System.Drawing.Point(128, 61);
            this.NomeTxt.Name = "NomeTxt";
            this.NomeTxt.Size = new System.Drawing.Size(254, 20);
            this.NomeTxt.TabIndex = 40;
            // 
            // IdPacienteTxt
            // 
            this.IdPacienteTxt.Location = new System.Drawing.Point(128, 27);
            this.IdPacienteTxt.Name = "IdPacienteTxt";
            this.IdPacienteTxt.Size = new System.Drawing.Size(73, 20);
            this.IdPacienteTxt.TabIndex = 39;
            // 
            // CpfTxt
            // 
            this.CpfTxt.Location = new System.Drawing.Point(259, 30);
            this.CpfTxt.Name = "CpfTxt";
            this.CpfTxt.Size = new System.Drawing.Size(123, 20);
            this.CpfTxt.TabIndex = 38;
            // 
            // FoneTxt
            // 
            this.FoneTxt.Location = new System.Drawing.Point(128, 87);
            this.FoneTxt.Name = "FoneTxt";
            this.FoneTxt.Size = new System.Drawing.Size(254, 20);
            this.FoneTxt.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 150);
            this.dataGridView1.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Fone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Cpf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Id";
            // 
            // DeletarBt
            // 
            this.DeletarBt.Location = new System.Drawing.Point(317, 118);
            this.DeletarBt.Name = "DeletarBt";
            this.DeletarBt.Size = new System.Drawing.Size(75, 23);
            this.DeletarBt.TabIndex = 31;
            this.DeletarBt.Text = "Deletar";
            this.DeletarBt.UseVisualStyleBackColor = true;
            // 
            // ConsultarBt
            // 
            this.ConsultarBt.Location = new System.Drawing.Point(236, 118);
            this.ConsultarBt.Name = "ConsultarBt";
            this.ConsultarBt.Size = new System.Drawing.Size(75, 23);
            this.ConsultarBt.TabIndex = 30;
            this.ConsultarBt.Text = "Consultar";
            this.ConsultarBt.UseVisualStyleBackColor = true;
            // 
            // AlterarBt
            // 
            this.AlterarBt.Location = new System.Drawing.Point(155, 118);
            this.AlterarBt.Name = "AlterarBt";
            this.AlterarBt.Size = new System.Drawing.Size(75, 23);
            this.AlterarBt.TabIndex = 29;
            this.AlterarBt.Text = "Alterar";
            this.AlterarBt.UseVisualStyleBackColor = true;
            // 
            // InserirBt
            // 
            this.InserirBt.Location = new System.Drawing.Point(74, 118);
            this.InserirBt.Name = "InserirBt";
            this.InserirBt.Size = new System.Drawing.Size(75, 23);
            this.InserirBt.TabIndex = 28;
            this.InserirBt.Text = "Inserir";
            this.InserirBt.UseVisualStyleBackColor = true;
            this.InserirBt.Click += new System.EventHandler(this.InserirBt_Click);
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.NomeTxt);
            this.Controls.Add(this.IdPacienteTxt);
            this.Controls.Add(this.CpfTxt);
            this.Controls.Add(this.FoneTxt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeletarBt);
            this.Controls.Add(this.ConsultarBt);
            this.Controls.Add(this.AlterarBt);
            this.Controls.Add(this.InserirBt);
            this.Name = "Paciente";
            this.Text = "Paciente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeTxt;
        private System.Windows.Forms.TextBox IdPacienteTxt;
        private System.Windows.Forms.TextBox CpfTxt;
        private System.Windows.Forms.TextBox FoneTxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeletarBt;
        private System.Windows.Forms.Button ConsultarBt;
        private System.Windows.Forms.Button AlterarBt;
        private System.Windows.Forms.Button InserirBt;
    }
}