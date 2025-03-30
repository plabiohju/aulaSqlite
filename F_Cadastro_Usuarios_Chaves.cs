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
    public partial class F_Cadastro_Usuarios_Chaves : Form
    {
        public F_Cadastro_Usuarios_Chaves()
        {
            InitializeComponent();
        }

        private void Btn_Cadastrar_Usuario_Chave_Click(object sender, EventArgs e)
        {
            if (Tb_Cadastro_Usuario_Chave.Text == "")
            {
                MessageBox.Show("Preencha o Campo");
                return;
            }


            Usuario usuario = new Usuario();
            usuario.Usuario_Chaves = Tb_Cadastro_Usuario_Chave.Text;

            Banco_Tb_Usuario_Chaves.novoUsuarioChave(usuario);
            Tb_Cadastro_Usuario_Chave.Text = "";
            Tb_Cadastro_Usuario_Chave.Focus();
            DgV_Usuario_Chaves.DataSource = Banco_Tb_Usuario_Chaves.obterUsuariochavesIDnome();
            F_Cadastro_Usuarios_Chaves f = new F_Cadastro_Usuarios_Chaves();
            f.F_Cadastro_Usuarios_Chaves_Load(sender, e);

        }

        private void F_Cadastro_Usuarios_Chaves_Load(object sender, EventArgs e)
        {
            
            DgV_Usuario_Chaves.DataSource = Banco_Tb_Usuario_Chaves.obterUsuariochavesIDnome();
            
            DgV_Usuario_Chaves.Columns[0].Width = 50;
            DgV_Usuario_Chaves.Columns[1].Width = 290;
            

        }

        private void Btn_Apagar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja excluir o Usuario de Chave?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Banco_Tb_Usuario_Chaves.DeletarUsuarioChaves(Tb_Id.Text);
                DgV_Usuario_Chaves.DataSource = Banco_Tb_Usuario_Chaves.obterUsuariochavesIDnome();

            }
        }

        private void DgV_Usuario_Chaves_SelectionChanged(object sender, EventArgs e)
        {
            
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                DataTable dt = new DataTable();
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco_Tb_Usuario_Chaves.obterDadosUsuarioChaves(id);
                Tb_Id.Text = dt.Rows[0].Field<Int64>("Id_Usuario_Chaves").ToString();

            }
        }
    }
}
