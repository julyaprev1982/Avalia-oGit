namespace ProjAvaliacao
{
    partial class Especialidades
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EspecialidadeTxt = new System.Windows.Forms.TextBox();
            this.IdEspecialidadeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeletarBt = new System.Windows.Forms.Button();
            this.ConsultarBt = new System.Windows.Forms.Button();
            this.AlterarBt = new System.Windows.Forms.Button();
            this.InserirBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // EspecialidadeTxt
            // 
            this.EspecialidadeTxt.Location = new System.Drawing.Point(98, 46);
            this.EspecialidadeTxt.Name = "EspecialidadeTxt";
            this.EspecialidadeTxt.Size = new System.Drawing.Size(276, 20);
            this.EspecialidadeTxt.TabIndex = 16;
            // 
            // IdEspecialidadeTxt
            // 
            this.IdEspecialidadeTxt.Location = new System.Drawing.Point(98, 20);
            this.IdEspecialidadeTxt.Name = "IdEspecialidadeTxt";
            this.IdEspecialidadeTxt.Size = new System.Drawing.Size(276, 20);
            this.IdEspecialidadeTxt.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Especialidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Id";
            // 
            // DeletarBt
            // 
            this.DeletarBt.Location = new System.Drawing.Point(286, 86);
            this.DeletarBt.Name = "DeletarBt";
            this.DeletarBt.Size = new System.Drawing.Size(75, 23);
            this.DeletarBt.TabIndex = 12;
            this.DeletarBt.Text = "Deletar";
            this.DeletarBt.UseVisualStyleBackColor = true;
            // 
            // ConsultarBt
            // 
            this.ConsultarBt.Location = new System.Drawing.Point(205, 86);
            this.ConsultarBt.Name = "ConsultarBt";
            this.ConsultarBt.Size = new System.Drawing.Size(75, 23);
            this.ConsultarBt.TabIndex = 11;
            this.ConsultarBt.Text = "Consultar";
            this.ConsultarBt.UseVisualStyleBackColor = true;
            // 
            // AlterarBt
            // 
            this.AlterarBt.Location = new System.Drawing.Point(124, 86);
            this.AlterarBt.Name = "AlterarBt";
            this.AlterarBt.Size = new System.Drawing.Size(75, 23);
            this.AlterarBt.TabIndex = 10;
            this.AlterarBt.Text = "Alterar";
            this.AlterarBt.UseVisualStyleBackColor = true;
            // 
            // InserirBt
            // 
            this.InserirBt.Location = new System.Drawing.Point(49, 86);
            this.InserirBt.Name = "InserirBt";
            this.InserirBt.Size = new System.Drawing.Size(75, 23);
            this.InserirBt.TabIndex = 9;
            this.InserirBt.Text = "Inserir";
            this.InserirBt.UseVisualStyleBackColor = true;
            this.InserirBt.Click += new System.EventHandler(this.InserirBt_Click);
            // 
            // Especialidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 293);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EspecialidadeTxt);
            this.Controls.Add(this.IdEspecialidadeTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeletarBt);
            this.Controls.Add(this.ConsultarBt);
            this.Controls.Add(this.AlterarBt);
            this.Controls.Add(this.InserirBt);
            this.Name = "Especialidade";
            this.Text = "Especialidade";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox EspecialidadeTxt;
        private System.Windows.Forms.TextBox IdEspecialidadeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeletarBt;
        private System.Windows.Forms.Button ConsultarBt;
        private System.Windows.Forms.Button AlterarBt;
        private System.Windows.Forms.Button InserirBt;
    }
}