namespace aulaSqlite
{
    partial class F_Estoque
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Estoque));
            this.DgV_Produtos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_DarBaixa = new System.Windows.Forms.Button();
            this.N_QuantidadeA_Subtrair = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_QuantidadeNoEstoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgV_Produtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_QuantidadeA_Subtrair)).BeginInit();
            this.SuspendLayout();
            // 
            // DgV_Produtos
            // 
            this.DgV_Produtos.AllowUserToAddRows = false;
            this.DgV_Produtos.AllowUserToDeleteRows = false;
            this.DgV_Produtos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgV_Produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgV_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgV_Produtos.EnableHeadersVisualStyles = false;
            this.DgV_Produtos.Location = new System.Drawing.Point(23, 85);
            this.DgV_Produtos.MultiSelect = false;
            this.DgV_Produtos.Name = "DgV_Produtos";
            this.DgV_Produtos.ReadOnly = true;
            this.DgV_Produtos.RowHeadersVisible = false;
            this.DgV_Produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgV_Produtos.Size = new System.Drawing.Size(545, 324);
            this.DgV_Produtos.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gestão de Produtos";
            // 
            // Btn_DarBaixa
            // 
            this.Btn_DarBaixa.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Btn_DarBaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_DarBaixa.Location = new System.Drawing.Point(587, 85);
            this.Btn_DarBaixa.Name = "Btn_DarBaixa";
            this.Btn_DarBaixa.Size = new System.Drawing.Size(124, 99);
            this.Btn_DarBaixa.TabIndex = 14;
            this.Btn_DarBaixa.Text = "Dar Baixa";
            this.Btn_DarBaixa.UseVisualStyleBackColor = false;
            // 
            // N_QuantidadeA_Subtrair
            // 
            this.N_QuantidadeA_Subtrair.Location = new System.Drawing.Point(587, 238);
            this.N_QuantidadeA_Subtrair.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.N_QuantidadeA_Subtrair.Name = "N_QuantidadeA_Subtrair";
            this.N_QuantidadeA_Subtrair.Size = new System.Drawing.Size(124, 20);
            this.N_QuantidadeA_Subtrair.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Quantidade a subtrair";
            // 
            // Tb_QuantidadeNoEstoque
            // 
            this.Tb_QuantidadeNoEstoque.Enabled = false;
            this.Tb_QuantidadeNoEstoque.Location = new System.Drawing.Point(587, 321);
            this.Tb_QuantidadeNoEstoque.Name = "Tb_QuantidadeNoEstoque";
            this.Tb_QuantidadeNoEstoque.Size = new System.Drawing.Size(124, 20);
            this.Tb_QuantidadeNoEstoque.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Quantidade no estoque";
            // 
            // Btn_Fechar
            // 
            this.Btn_Fechar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Fechar.Location = new System.Drawing.Point(587, 377);
            this.Btn_Fechar.Name = "Btn_Fechar";
            this.Btn_Fechar.Size = new System.Drawing.Size(124, 32);
            this.Btn_Fechar.TabIndex = 19;
            this.Btn_Fechar.Text = "Fechar";
            this.Btn_Fechar.UseVisualStyleBackColor = false;
            this.Btn_Fechar.Click += new System.EventHandler(this.Btn_Fechar_Click);
            // 
            // F_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 420);
            this.Controls.Add(this.Btn_Fechar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_QuantidadeNoEstoque);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.N_QuantidadeA_Subtrair);
            this.Controls.Add(this.Btn_DarBaixa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgV_Produtos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.DgV_Produtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N_QuantidadeA_Subtrair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgV_Produtos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_DarBaixa;
        private System.Windows.Forms.NumericUpDown N_QuantidadeA_Subtrair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_QuantidadeNoEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Fechar;
    }
}