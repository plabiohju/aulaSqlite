using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaSqlite
{

    public partial class Form1 : Form
    {

        private Timer timer;
        public Form1()
        {
            InitializeComponent();
            F_Login f_Login = new F_Login(this);
            f_Login.ShowDialog();
        }




        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globais.logado == false)
            {
                F_Login f_Login = new F_Login(this);
                f_Login.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario já Logado");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_Acesso.Text = "0";

            lb_NomeUsuario.Text = "...";

            pb_ledLigado.Image = Properties.Resources.led_vermelho;
            globais.nivel = 0;
            globais.logado = false;

        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globais.logado == true)
            {
                if (globais.nivel >= 2)
                {
                    F_CadastroDeProdutos c = new F_CadastroDeProdutos();
                    c.ShowDialog(); 
                }
                else
                {
                    MessageBox.Show("Acesso Negado");
                }

            }
            else
            {
                MessageBox.Show("Usuario não Logado");
            }
        }

        private void gestãoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globais.logado == true)
            {
                if (globais.nivel == 3)
                {
                    F_Gestao_Usuarios f_Gestao_Usuarios = new F_Gestao_Usuarios();
                    f_Gestao_Usuarios.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso Negado");
                }

            }
            else
            {
                MessageBox.Show("Usuario não Logado");
            }

        }

        private void novoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globais.logado == true)
            {
                if (globais.nivel == 3)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso Negado");
                }

            }
            else
            {
                MessageBox.Show("Usuario não Logado");
            }

        }

        private void cadastroDeChavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globais.logado == true)
            {
                if (globais.nivel >= 2)
                {
                    F_Cadastro_de_Chaves f = new F_Cadastro_de_Chaves();
                    f.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Acesso Negado");
                }

            }
            else
            {
                MessageBox.Show("Usuario não Logado");
            }
        }

        private void cadastroUsuarioDeCavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globais.logado == true)
            {
                if (globais.nivel >= 2)
                {
                    F_Cadastro_Usuarios_Chaves f = new F_Cadastro_Usuarios_Chaves();
                    f.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Acesso Negado");
                }

            }
            else
            {
                MessageBox.Show("Usuario não Logado");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            Lb_versao.Text = globais.versao;
            DgV_Chaves.DataSource = Banco_MovimentoChaves.obterchavesMovIDnome();
            DgV_Chaves.Columns[0].Width = 50;
            DgV_Chaves.Columns[1].Width = 150;
            DgV_Chaves.Columns[2].Width = 150;
            DgV_Chaves.Columns[3].Width = 150;
            DgV_Chaves.Columns[4].Width = 150;
            ListarChaveBombobox();
            ListarChaveBombobox2(); 

        }
        public void ListarChaveBombobox()
        {
            string vqueryChaves = @"SELECT Id_Chaves,T_Chaves FROM Tb_Chaves ORDER BY Id_Chaves";
            Cb_Chaves_Registradas.Items.Clear();
            Cb_Chaves_Registradas.DataSource = banco.dql(vqueryChaves);
            Cb_Chaves_Registradas.DisplayMember = "T_Chaves";
            Cb_Chaves_Registradas.ValueMember = "Id_Chaves";
        }
        public void ListarChaveBombobox2()
        {
            string vqueryChaves = @"SELECT Id_Usuario_Chaves,T_Usuario_Chaves FROM Tb_Usuarios_Chaves ORDER BY Id_Usuario_Chaves";
            Cb_UsuariosDeChaves_Registrados.Items.Clear();
            Cb_UsuariosDeChaves_Registrados.DataSource = banco.dql(vqueryChaves);
            Cb_UsuariosDeChaves_Registrados.DisplayMember = "T_Usuario_Chaves";
            Cb_UsuariosDeChaves_Registrados.ValueMember = "Id_Usuario_Chaves";
        }

        private void Btn_AtualizarLista_Click(object sender, EventArgs e)
        {
            string vqueryChaves = @"SELECT Id_Chaves,T_Chaves FROM Tb_Chaves ORDER BY Id_Chaves";
           
            Cb_Chaves_Registradas.DataSource = banco.dql(vqueryChaves);
            Cb_Chaves_Registradas.DisplayMember = "T_Chaves";
            Cb_Chaves_Registradas.ValueMember = "Id_Chaves";


            string vqueryuChaves = @"SELECT Id_Usuario_Chaves,T_Usuario_Chaves FROM Tb_Usuarios_Chaves ORDER BY Id_Usuario_Chaves";
            
            Cb_UsuariosDeChaves_Registrados.DataSource = banco.dql(vqueryuChaves);
            Cb_UsuariosDeChaves_Registrados.DisplayMember = "T_Usuario_Chaves";
            Cb_UsuariosDeChaves_Registrados.ValueMember = "Id_Usuario_Chaves";
        }

        private void informaçõesDoDesenvolvedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_InformacoesDEsenvolvedor f = new F_InformacoesDEsenvolvedor();
            f.ShowDialog();
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
          
            if (globais.logado == true)
            {
                if (globais.nivel >= 1)
                {
                    if (Cb_Chaves_Registradas.Text == "" || Cb_UsuariosDeChaves_Registrados.Text == "")
                    {
                        MessageBox.Show("Preencha todos os Campos");
                        return;
                    }

                    string data = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    Usuario usuario = new Usuario();
                    usuario.UsuarioChaveMov = Cb_UsuariosDeChaves_Registrados.Text;
                    usuario.ChaveMov = Cb_Chaves_Registradas.Text;
                    usuario.Responsavel = lb_NomeUsuario.Text;
                    usuario.DataHora = data;


                    Banco_MovimentoChaves.novaChaveMov(usuario);
                    DgV_Chaves.DataSource = Banco_MovimentoChaves.obterchavesMovIDnome();

                }
                else
                {
                    MessageBox.Show("Acesso Negado");
                }

            }
            else
            {
                MessageBox.Show("Usuario não Logado");
            }
        }

        private void Btn_Apagar_Click(object sender, EventArgs e)
        {
          
            if (globais.logado == true)
            {
                if (globais.nivel >= 1)
                {
                    DialogResult res = MessageBox.Show("Deseja realmente excluir o Movimento?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        Banco_MovimentoChaves.DeletarChavesMov(Tb_Id.Text);
                        DgV_Chaves.DataSource = Banco_MovimentoChaves.obterchavesMovIDnome();

                    }

                }
                else
                {
                    MessageBox.Show("Acesso Negado");
                }

            }
            else
            {
                MessageBox.Show("Usuario não Logado");
            }
        }

        private void DgV_Chaves_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco_MovimentoChaves.obterDadosChaveMov(id);
                Tb_Id.Text = dt.Rows[0].Field<Int64>("Id_MovimentoChaves").ToString();
               


            }
        }

        private void gestãoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globais.logado == true)
            {
                if (globais.nivel >= 2)
                {
                    F_Estoque f = new F_Estoque();
                    f.ShowDialog(); 
                }
                else
                {
                    MessageBox.Show("Acesso Negado");
                }

            }
            else
            {
                MessageBox.Show("Usuario não Logado");
            }

        }
    } 
   
        
        
    
}
