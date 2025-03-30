namespace aulaSqlite
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lb_versao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_NomeUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Acesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_ledLigado = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.gestãoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastroDeChavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cadastroUsuarioDeCavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.novoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gestãoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informaçõesDoDesenvolvedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.Cb_Chaves_Registradas = new System.Windows.Forms.ComboBox();
            this.Cb_UsuariosDeChaves_Registrados = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.Btn_Apagar = new System.Windows.Forms.Button();
            this.Btn_AtualizarLista = new System.Windows.Forms.Button();
            this.DgV_Chaves = new System.Windows.Forms.DataGridView();
            this.Tb_Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLigado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgV_Chaves)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.Lb_versao);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lb_NomeUsuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_Acesso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pb_ledLigado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 116);
            this.panel1.TabIndex = 0;
            // 
            // Lb_versao
            // 
            this.Lb_versao.AutoSize = true;
            this.Lb_versao.Location = new System.Drawing.Point(763, 94);
            this.Lb_versao.Name = "Lb_versao";
            this.Lb_versao.Size = new System.Drawing.Size(16, 13);
            this.Lb_versao.TabIndex = 2;
            this.Lb_versao.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::aulaSqlite.Properties.Resources.logo_pousada_pedra_azul1;
            this.pictureBox1.Location = new System.Drawing.Point(821, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lb_NomeUsuario
            // 
            this.lb_NomeUsuario.AutoSize = true;
            this.lb_NomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomeUsuario.Location = new System.Drawing.Point(296, 49);
            this.lb_NomeUsuario.Name = "lb_NomeUsuario";
            this.lb_NomeUsuario.Size = new System.Drawing.Size(39, 20);
            this.lb_NomeUsuario.TabIndex = 4;
            this.lb_NomeUsuario.Text = "......";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Administrador";
            // 
            // lb_Acesso
            // 
            this.lb_Acesso.AutoSize = true;
            this.lb_Acesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Acesso.Location = new System.Drawing.Point(145, 49);
            this.lb_Acesso.Name = "lb_Acesso";
            this.lb_Acesso.Size = new System.Drawing.Size(19, 20);
            this.lb_Acesso.TabIndex = 2;
            this.lb_Acesso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso";
            // 
            // pb_ledLigado
            // 
            this.pb_ledLigado.Image = global::aulaSqlite.Properties.Resources.led_vermelho;
            this.pb_ledLigado.Location = new System.Drawing.Point(3, 28);
            this.pb_ledLigado.Name = "pb_ledLigado";
            this.pb_ledLigado.Size = new System.Drawing.Size(51, 50);
            this.pb_ledLigado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ledLigado.TabIndex = 0;
            this.pb_ledLigado.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estoqueToolStripMenuItem,
            this.chavesToolStripMenuItem,
            this.usuariosToolStripMenuItem1,
            this.usuariosToolStripMenuItem,
            this.informaçõesDoDesenvolvedorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.cadastroDeProdutosToolStripMenuItem,
            this.toolStripSeparator3,
            this.gestãoDeProdutosToolStripMenuItem});
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 6);
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
            // 
            // gestãoDeProdutosToolStripMenuItem
            // 
            this.gestãoDeProdutosToolStripMenuItem.Name = "gestãoDeProdutosToolStripMenuItem";
            this.gestãoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.gestãoDeProdutosToolStripMenuItem.Text = "Gestão de Produtos";
            this.gestãoDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeProdutosToolStripMenuItem_Click);
            // 
            // chavesToolStripMenuItem
            // 
            this.chavesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.cadastroDeChavesToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cadastroUsuarioDeCavesToolStripMenuItem});
            this.chavesToolStripMenuItem.Name = "chavesToolStripMenuItem";
            this.chavesToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.chavesToolStripMenuItem.Text = "Chaves";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(218, 6);
            // 
            // cadastroDeChavesToolStripMenuItem
            // 
            this.cadastroDeChavesToolStripMenuItem.Name = "cadastroDeChavesToolStripMenuItem";
            this.cadastroDeChavesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.cadastroDeChavesToolStripMenuItem.Text = "Cadastro de Chaves";
            this.cadastroDeChavesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeChavesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(218, 6);
            // 
            // cadastroUsuarioDeCavesToolStripMenuItem
            // 
            this.cadastroUsuarioDeCavesToolStripMenuItem.Name = "cadastroUsuarioDeCavesToolStripMenuItem";
            this.cadastroUsuarioDeCavesToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.cadastroUsuarioDeCavesToolStripMenuItem.Text = "Cadastro Usuario de Chaves";
            this.cadastroUsuarioDeCavesToolStripMenuItem.Click += new System.EventHandler(this.cadastroUsuarioDeCavesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem1
            // 
            this.usuariosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoUsuarioToolStripMenuItem,
            this.toolStripSeparator2,
            this.gestãoDeUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem1.Name = "usuariosToolStripMenuItem1";
            this.usuariosToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem1.Text = "Usuarios";
            // 
            // novoUsuarioToolStripMenuItem
            // 
            this.novoUsuarioToolStripMenuItem.Name = "novoUsuarioToolStripMenuItem";
            this.novoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.novoUsuarioToolStripMenuItem.Text = "Novo Usuario";
            this.novoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.novoUsuarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // gestãoDeUsuariosToolStripMenuItem
            // 
            this.gestãoDeUsuariosToolStripMenuItem.Name = "gestãoDeUsuariosToolStripMenuItem";
            this.gestãoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gestãoDeUsuariosToolStripMenuItem.Text = "Gestão de Usuarios";
            this.gestãoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.gestãoDeUsuariosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.toolStripSeparator1,
            this.logoutToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.usuariosToolStripMenuItem.Text = "Login";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // informaçõesDoDesenvolvedorToolStripMenuItem
            // 
            this.informaçõesDoDesenvolvedorToolStripMenuItem.Name = "informaçõesDoDesenvolvedorToolStripMenuItem";
            this.informaçõesDoDesenvolvedorToolStripMenuItem.Size = new System.Drawing.Size(183, 20);
            this.informaçõesDoDesenvolvedorToolStripMenuItem.Text = "Informações do Desenvolvedor";
            this.informaçõesDoDesenvolvedorToolStripMenuItem.Click += new System.EventHandler(this.informaçõesDoDesenvolvedorToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Relatório do uso das Chaves";
            // 
            // Cb_Chaves_Registradas
            // 
            this.Cb_Chaves_Registradas.FormattingEnabled = true;
            this.Cb_Chaves_Registradas.Location = new System.Drawing.Point(93, 105);
            this.Cb_Chaves_Registradas.Name = "Cb_Chaves_Registradas";
            this.Cb_Chaves_Registradas.Size = new System.Drawing.Size(332, 21);
            this.Cb_Chaves_Registradas.TabIndex = 4;
            // 
            // Cb_UsuariosDeChaves_Registrados
            // 
            this.Cb_UsuariosDeChaves_Registrados.FormattingEnabled = true;
            this.Cb_UsuariosDeChaves_Registrados.Location = new System.Drawing.Point(443, 105);
            this.Cb_UsuariosDeChaves_Registrados.Name = "Cb_UsuariosDeChaves_Registrados";
            this.Cb_UsuariosDeChaves_Registrados.Size = new System.Drawing.Size(332, 21);
            this.Cb_UsuariosDeChaves_Registrados.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Usuarios das Chaves";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Chaves";
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Btn_Registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registrar.Location = new System.Drawing.Point(781, 105);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(127, 113);
            this.Btn_Registrar.TabIndex = 8;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // Btn_Apagar
            // 
            this.Btn_Apagar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Btn_Apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Apagar.Location = new System.Drawing.Point(781, 245);
            this.Btn_Apagar.Name = "Btn_Apagar";
            this.Btn_Apagar.Size = new System.Drawing.Size(127, 113);
            this.Btn_Apagar.TabIndex = 9;
            this.Btn_Apagar.Text = "Apagar";
            this.Btn_Apagar.UseVisualStyleBackColor = false;
            this.Btn_Apagar.Click += new System.EventHandler(this.Btn_Apagar_Click);
            // 
            // Btn_AtualizarLista
            // 
            this.Btn_AtualizarLista.Location = new System.Drawing.Point(12, 87);
            this.Btn_AtualizarLista.Name = "Btn_AtualizarLista";
            this.Btn_AtualizarLista.Size = new System.Drawing.Size(72, 48);
            this.Btn_AtualizarLista.TabIndex = 10;
            this.Btn_AtualizarLista.Text = "Atualizar Listas";
            this.Btn_AtualizarLista.UseVisualStyleBackColor = true;
            this.Btn_AtualizarLista.Click += new System.EventHandler(this.Btn_AtualizarLista_Click);
            // 
            // DgV_Chaves
            // 
            this.DgV_Chaves.AllowUserToAddRows = false;
            this.DgV_Chaves.AllowUserToDeleteRows = false;
            this.DgV_Chaves.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
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
            this.DgV_Chaves.Location = new System.Drawing.Point(93, 141);
            this.DgV_Chaves.MultiSelect = false;
            this.DgV_Chaves.Name = "DgV_Chaves";
            this.DgV_Chaves.ReadOnly = true;
            this.DgV_Chaves.RowHeadersVisible = false;
            this.DgV_Chaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgV_Chaves.Size = new System.Drawing.Size(682, 227);
            this.DgV_Chaves.TabIndex = 11;
            this.DgV_Chaves.SelectionChanged += new System.EventHandler(this.DgV_Chaves_SelectionChanged);
            // 
            // Tb_Id
            // 
            this.Tb_Id.Location = new System.Drawing.Point(12, 164);
            this.Tb_Id.Name = "Tb_Id";
            this.Tb_Id.Size = new System.Drawing.Size(72, 20);
            this.Tb_Id.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 490);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tb_Id);
            this.Controls.Add(this.DgV_Chaves);
            this.Controls.Add(this.Btn_AtualizarLista);
            this.Controls.Add(this.Btn_Apagar);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cb_UsuariosDeChaves_Registrados);
            this.Controls.Add(this.Cb_Chaves_Registradas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Controles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ledLigado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgV_Chaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pb_ledLigado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lb_Acesso;
        public System.Windows.Forms.Label lb_NomeUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label Lb_versao;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeChavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cadastroUsuarioDeCavesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeProdutosToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cb_Chaves_Registradas;
        private System.Windows.Forms.ComboBox Cb_UsuariosDeChaves_Registrados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.Button Btn_Apagar;
        private System.Windows.Forms.Button Btn_AtualizarLista;
        private System.Windows.Forms.DataGridView DgV_Chaves;
        private System.Windows.Forms.ToolStripMenuItem informaçõesDoDesenvolvedorToolStripMenuItem;
        private System.Windows.Forms.TextBox Tb_Id;
        private System.Windows.Forms.Label label6;
    }
}

