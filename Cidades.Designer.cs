namespace ProjAvaliacao
{
    partial class Cidades
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
            this.ConsultarBt = new System.Windows.Forms.Button();
            this.AlterarBt = new System.Windows.Forms.Button();
            this.InserirBt = new System.Windows.Forms.Button();
            this.EstadoTxt = new System.Windows.Forms.TextBox();
            this.CidadeTxt = new System.Windows.Forms.TextBox();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // ConsultarBt
            // 
            this.ConsultarBt.Location = new System.Drawing.Point(370, 95);
            this.ConsultarBt.Name = "ConsultarBt";
            this.ConsultarBt.Size = new System.Drawing.Size(75, 23);
            this.ConsultarBt.TabIndex = 18;
            this.ConsultarBt.Text = "Consultar";
            this.ConsultarBt.UseVisualStyleBackColor = true;
            this.ConsultarBt.Click += new System.EventHandler(this.ConsultarBt_Click);
            // 
            // AlterarBt
            // 
            this.AlterarBt.Location = new System.Drawing.Point(370, 62);
            this.AlterarBt.Name = "AlterarBt";
            this.AlterarBt.Size = new System.Drawing.Size(75, 23);
            this.AlterarBt.TabIndex = 17;
            this.AlterarBt.Text = "Excluir";
            this.AlterarBt.UseVisualStyleBackColor = true;
            this.AlterarBt.Click += new System.EventHandler(this.AlterarBt_Click);
            // 
            // InserirBt
            // 
            this.InserirBt.Location = new System.Drawing.Point(370, 26);
            this.InserirBt.Name = "InserirBt";
            this.InserirBt.Size = new System.Drawing.Size(75, 23);
            this.InserirBt.TabIndex = 16;
            this.InserirBt.Text = "Inserir";
            this.InserirBt.UseVisualStyleBackColor = true;
            this.InserirBt.Click += new System.EventHandler(this.InserirBt_Click);
            // 
            // EstadoTxt
            // 
            this.EstadoTxt.Location = new System.Drawing.Point(70, 92);
            this.EstadoTxt.Name = "EstadoTxt";
            this.EstadoTxt.Size = new System.Drawing.Size(249, 20);
            this.EstadoTxt.TabIndex = 15;
            // 
            // CidadeTxt
            // 
            this.CidadeTxt.Location = new System.Drawing.Point(70, 59);
            this.CidadeTxt.Name = "CidadeTxt";
            this.CidadeTxt.Size = new System.Drawing.Size(249, 20);
            this.CidadeTxt.TabIndex = 14;
            // 
            // IdTxt
            // 
            this.IdTxt.Location = new System.Drawing.Point(70, 26);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(249, 20);
            this.IdTxt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Id";
            // 
            // Cidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 302);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ConsultarBt);
            this.Controls.Add(this.AlterarBt);
            this.Controls.Add(this.InserirBt);
            this.Controls.Add(this.EstadoTxt);
            this.Controls.Add(this.CidadeTxt);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cidades";
            this.Text = "Cidade";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ConsultarBt;
        private System.Windows.Forms.Button AlterarBt;
        private System.Windows.Forms.Button InserirBt;
        private System.Windows.Forms.TextBox EstadoTxt;
        private System.Windows.Forms.TextBox CidadeTxt;
        private System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}