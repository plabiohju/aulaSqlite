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
    public partial class F_NovoUsuario : Form
    {
       
        public F_NovoUsuario()
        {
            InitializeComponent();
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if(Tb_Nome.Text == "" || Tb_Username.Text == "" || Tb_Senha.Text == "" || Cb_Status.Text == "")
            {
                MessageBox.Show("Preencha todos os Campos");
                return;
            }


            Usuario usuario = new Usuario();
            usuario.nome = Tb_Nome.Text;
            usuario.username = Tb_Username.Text;
            usuario.senha = Tb_Senha.Text;
            usuario.status = Cb_Status.Text;
            usuario.nivel = Convert.ToInt32(Math.Round(N_Nivel.Value,0));
            banco.novoUsuario(usuario);
            limpar_Campus();
            bloquear_Campus();
        }
        public void bloquear_Campus()
        {
            Tb_Nome.Enabled = false;
            Tb_Username.Enabled = false;
            Tb_Senha.Enabled = false;
            Cb_Status.Enabled = false;
            N_Nivel.Enabled = false;
        }
        public void desbloquear_Campus()
        {
            Tb_Nome.Enabled = true;
            Tb_Username.Enabled = true;
            Tb_Senha.Enabled = true;
            Cb_Status.Enabled = false;
            N_Nivel.Enabled = true;
        }
        public void limpar_Campus()
        {
            Tb_Nome.Text = "";
            Tb_Username.Text = "";
            Tb_Senha.Text = "";
            Cb_Status.Text = "A";
            N_Nivel.Value = 0;
        }

        private void F_NovoUsuario_Load(object sender, EventArgs e)
        {
            bloquear_Campus();
        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            desbloquear_Campus();
            limpar_Campus();
            Tb_Nome.Focus();
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpar_Campus();
            Tb_Nome.Focus();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
