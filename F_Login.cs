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
    public partial class F_Login : Form
    {
        Form1 Form1;
        DataTable dt = new DataTable();
        public F_Login(Form1 f)
        {
            InitializeComponent();
             Form1= f;
        }

        private void Btn_Logar_Click(object sender, EventArgs e)
        {
            string username = Tb_Username.Text;
            string senha = Tb_Senha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuario ou Senha Invalidos");
                Tb_Username.Focus();
                return; 
            }
            string sql = "SELECT * FROM Tb_Usuarios WHERE T_UserName ='" + username + "' AND T_SenhaUsuario = '" + senha+"'";
            dt = banco.dql(sql);
            if (dt.Rows.Count == 1)
            {
                Form1.lb_Acesso.Text = dt.Rows[0].ItemArray[5].ToString();

                Form1.lb_NomeUsuario.Text = dt.Rows[0].Field<string>("T_NomeUsuario");

                Form1.pb_ledLigado.Image = Properties.Resources.led_verde;
                globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NivelUsuario").ToString());
                globais.logado = true;
                this.Close();   
            }
            else
            {
                MessageBox.Show("Usuario não Encontrado");
                Tb_Username.Focus();
            }

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();       
        }
    }
}
