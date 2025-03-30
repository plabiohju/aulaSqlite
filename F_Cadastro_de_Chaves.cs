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
    public partial class F_Cadastro_de_Chaves : Form
    {
        public F_Cadastro_de_Chaves()
        {
            InitializeComponent();
        }

        private void Btn_Cadastrar_Chave_Click(object sender, EventArgs e)
        {
            if (Tb_Cadastro_Chave.Text == "")
            {
                MessageBox.Show("Preencha o Campo");
                return;
            }


            Usuario usuario = new Usuario();
            usuario.Chaves = Tb_Cadastro_Chave.Text;
           
            Banco_TbChaves.novaChave(usuario);
            Tb_Cadastro_Chave.Text = "";
            Tb_Cadastro_Chave.Focus();
            DgV_Chaves.DataSource = Banco_TbChaves.obterchavesIDnome();
            F_Cadastro_de_Chaves f = new F_Cadastro_de_Chaves();
            f.F_Cadastro_de_Chaves_Load(sender, e);


        }

        private void F_Cadastro_de_Chaves_Load(object sender, EventArgs e)
        {
            
            DgV_Chaves.DataSource = Banco_TbChaves.obterchavesIDnome();
            DgV_Chaves.Columns[0].Width = 50;
            DgV_Chaves.Columns[1].Width = 290;
        }

        private void Btn_Apagar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja realmente excluir a Chave?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Banco_TbChaves.DeletarChaves(Tb_Id.Text);
                DgV_Chaves.DataSource = Banco_TbChaves.obterchavesIDnome();

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
                dt = Banco_TbChaves.obterDadosChaves(id);
                Tb_Id.Text = dt.Rows[0].Field<Int64>("Id_Chaves").ToString();
                
            }
        }

       
    }
}
