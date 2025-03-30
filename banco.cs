using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;  
using System.Windows.Forms;
using System.Data.Common;

namespace aulaSqlite
{
    internal class banco
    {

        private static SQLiteConnection conexao;

        //funções genericas
        public static DataTable dql(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    da.Fill(dt);
                    conexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                conexaoBanco().Close();
                throw ex;

            }
        }
        public static void dml(string q, string msgOK = null, string msgErro = null)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = q;
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    cmd.ExecuteNonQuery();
                    conexaoBanco().Close();
                    if (msgOK != null)
                    {
                        MessageBox.Show(msgOK);
                    }
                }
            }
            catch (Exception ex)
            {
                if (msgErro != null)
                {
                    MessageBox.Show(msgErro+"\n"+ex.Message);
                }
                conexaoBanco().Close();
                throw ex;
            }
        }

        private static SQLiteConnection conexaoBanco()
        {

            conexao = new SQLiteConnection("Data Source="+globais.caminhoBanco+globais.nomeBanco);
            conexao.Open();
            return conexao;
        }


        public static DataTable obterUsuario()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Tb_Usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    da.Fill(dt);
                    conexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                conexaoBanco().Close();
                throw ex;
            }
        }
      
        /// metodo para inserir usuario
        public static void novoUsuario(Usuario u)
        {
            if (exixteUsername(u))
            {
                MessageBox.Show("Username já existe");
                return;
            }
            try
            {
                var cmd = conexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO Tb_Usuarios (T_NomeUsuario,T_UserName,T_SenhaUsuario,T_StatusUsuario,N_NivelUsuario) VALUES (@nome,@username,@senha,@status,@nivel)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.ExecuteNonQuery();
                conexaoBanco().Close();
                MessageBox.Show("Usuario Cadastrado com Sucesso");
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Cadastrar Usuario");
                conexaoBanco().Close();

            }
        }

        /// metodo para verificar username igual
        public static bool exixteUsername(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT T_UserName FROM Tb_Usuarios WHERE T_UserName='" + u.username + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
        /// metodo para mostrar o banco no datata grid
        public static DataTable obterUsuarioIDnome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT N_IdUsuarios as 'ID Usuario',T_NomeUsuario as 'Nome Usuario',T_StatusUsuario as'Staus Usuario',N_NivelUsuario as 'Nivel Usuario' FROM Tb_Usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    da.Fill(dt);
                    conexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                conexaoBanco().Close();
                throw ex;
            }
        }
        public static DataTable obterDadosUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Tb_Usuarios WHERE N_IdUsuarios="+id;
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    da.Fill(dt);
                    conexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                conexaoBanco().Close();
                throw ex;
            }
        }
        public static void AtualizarUsuario(Usuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "UPDATE Tb_Usuarios SET T_NomeUsuario='"+u.nome+ "',T_UserName='"+u.username+ "', T_SenhaUsuario='"+u.senha+ "',T_StatusUsuario='"+u.status+ "',N_NivelUsuario='"+u.nivel+ "'WHERE N_IdUsuarios="+u.id;
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    cmd.ExecuteNonQuery();
                    conexaoBanco().Close();
                    
                }
            }
            catch (Exception ex)
            {
                conexaoBanco().Close();
                throw ex;
            }
        }
        /// metodo para deletar usuario
        public static void DeletarUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Tb_Usuarios WHERE N_IdUsuarios="+id;
                    da = new SQLiteDataAdapter(cmd.CommandText, conexaoBanco());
                    cmd.ExecuteNonQuery();
                    conexaoBanco().Close();

                }
            }
            catch (Exception ex)
            {
                conexaoBanco().Close();
                throw ex;
            }
        }
    }
}
