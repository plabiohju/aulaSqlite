namespace aulaSqlite
{
    partial class F_Cadastro_de_Chaves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Cadastro_de_Chaves));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_Id = new System.Windows.Forms.TextBox();
            this.DgV_Chaves = new System.Windows.Forms.DataGridView();
            this.Btn_Apagar = new System.Windows.Forms.Button();
            this.Btn_Cadastrar_Chave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Cadastro_Chave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgV_Chaves)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Tb_Id);
            this.panel1.Controls.Add(this.DgV_Chaves);
            this.panel1.Controls.Add(this.Btn_Apagar);
            this.panel1.Controls.Add(this.Btn_Cadastrar_Chave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Tb_Cadastro_Chave);
            this.panel1.Location = new System.Drawing.Point(33, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 313);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID";
            // 
            // Tb_Id
            // 
            this.Tb_Id.Location = new System.Drawing.Point(426, 27);
            this.Tb_Id.Name = "Tb_Id";
            this.Tb_Id.Size = new System.Drawing.Size(63, 20);
            this.Tb_Id.TabIndex = 5;
            // 
            // DgV_Chaves
            // 
            this.DgV_Chaves.AllowUserToAddRows = false;
            this.DgV_Chaves.AllowUserToDeleteRows = false;
            this.DgV_Chaves.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgV_Chaves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgV_Chaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgV_Chaves.EnableHeadersVisualStyles = false;
            this.DgV_Chaves.Location = new System.Drawing.Point(14, 69);
            this.DgV_Chaves.MultiSelect = false;
            this.DgV_Chaves.Name = "DgV_Chaves";
            this.DgV_Chaves.ReadOnly = true;
            this.DgV_Chaves.RowHeadersVisible = false;
            this.DgV_Chaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgV_Chaves.Size = new System.Drawing.Size(369, 227);
            this.DgV_Chaves.TabIndex = 4;
            this.DgV_Chaves.SelectionChanged += new System.EventHandler(this.DgV_Chaves_SelectionChanged);
            // 
            // Btn_Apagar
            // 
            this.Btn_Apagar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Btn_Apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Apagar.Location = new System.Drawing.Point(405, 160);
            this.Btn_Apagar.Name = "Btn_Apagar";
            this.Btn_Apagar.Size = new System.Drawing.Size(84, 73);
            this.Btn_Apagar.TabIndex = 3;
            this.Btn_Apagar.Text = "Apagar";
            this.Btn_Apagar.UseVisualStyleBackColor = false;
            this.Btn_Apagar.Click += new System.EventHandler(this.Btn_Apagar_Click);
            // 
            // Btn_Cadastrar_Chave
            // 
            this.Btn_Cadastrar_Chave.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Btn_Cadastrar_Chave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cadastrar_Chave.Location = new System.Drawing.Point(405, 69);
            this.Btn_Cadastrar_Chave.Name = "Btn_Cadastrar_Chave";
            this.Btn_Cadastrar_Chave.Size = new System.Drawing.Size(84, 73);
            this.Btn_Cadastrar_Chave.TabIndex = 2;
            this.Btn_Cadastrar_Chave.Text = "Cadastrar";
            this.Btn_Cadastrar_Chave.UseVisualStyleBackColor = false;
            this.Btn_Cadastrar_Chave.Click += new System.EventHandler(this.Btn_Cadastrar_Chave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Da Chave";
            // 
            // Tb_Cadastro_Chave
            // 
            this.Tb_Cadastro_Chave.Location = new System.Drawing.Point(14, 27);
            this.Tb_Cadastro_Chave.Name = "Tb_Cadastro_Chave";
            this.Tb_Cadastro_Chave.Size = new System.Drawing.Size(369, 20);
            this.Tb_Cadastro_Chave.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cadastro das Chaves";
            // 
            // F_Cadastro_de_Chaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Cadastro_de_Chaves";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro_de_Chaves";
            this.Load += new System.EventHandler(this.F_Cadastro_de_Chaves_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgV_Chaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Tb_Cadastro_Chave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Cadastrar_Chave;
        private System.Windows.Forms.DataGridView DgV_Chaves;
        private System.Windows.Forms.Button Btn_Apagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_Id;
    }
}