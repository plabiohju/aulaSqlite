using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace aulaSqlite
{
    public partial class F_Gestao_Usuarios : Form
    {
        public F_Gestao_Usuarios()
        {
            InitializeComponent();
        }

        private void Btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_Gestao_Usuarios_Load(object sender, EventArgs e)
        {
           Dgv_Usuarios.DataSource = banco.obterUsuarioIDnome();
           Dgv_Usuarios.Columns[0].Width = 50;
           Dgv_Usuarios.Columns[1].Width = 190;
           Dgv_Usuarios.Columns[2].Width = 190;
           Dgv_Usuarios.Columns[3].Width = 190;
        }

        private void Dgv_Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = banco.obterDadosUsuario(id);
                Tb_Id.Text = dt.Rows[0].Field<Int64>("N_IdUsuarios").ToString();
                Tb_Nome.Text = dt.Rows[0].Field<string>("T_NomeUsuario");
                Tb_Username.Text = dt.Rows[0].Field<string>("T_UserName");
                Tb_Senha.Text = dt.Rows[0].Field<string>("T_SenhaUsuario");
                N_Nivel.Value = dt.Rows[0].Field<Int64>("N_NivelUsuario");
                Cb_Status.Text = dt.Rows[0].Field<string>("T_StatusUsuario");   
            }


        }

        private void Btn_Novo_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f = new F_NovoUsuario();
            f.ShowDialog();
            Dgv_Usuarios.DataSource = banco.obterUsuarioIDnome();
        }

        private void Btn_Alterar_Click(object sender, EventArgs e)
        {
            int linhas = Dgv_Usuarios.SelectedRows[0].Index;
            Usuario u = new Usuario();
            u.id = Convert.ToInt32(Tb_Id.Text);
            u.nome = Tb_Nome.Text;
            u.username = Tb_Username.Text;
            u.senha = Tb_Senha.Text;
            u.nivel = Convert.ToInt32(Math.Round(N_Nivel.Value, 0));
            u.status = Cb_Status.Text;
            banco.AtualizarUsuario(u);
            Dgv_Usuarios.DataSource = banco.obterUsuarioIDnome();
            MessageBox.Show("Usuario Atualizado com Sucesso");
            Dgv_Usuarios.CurrentCell = Dgv_Usuarios[0, linhas];
        }

        private void Btn_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir o usuario?", "Excluir", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                banco.DeletarUsuario(Tb_Id.Text);
                Dgv_Usuarios.DataSource = banco.obterUsuarioIDnome();

            }
        }

     
    }
}
