using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaSqlite
{
    internal class Banco_Tb_Usuario_Chaves
    {
        
        private static SQLiteConnection conexao;
        private static SQLiteConnection conexaoBanco()
        {

            conexao = new SQLiteConnection("Data Source=" + globais.caminhoBanco + globais.nomeBanco);
            conexao.Open();
            return conexao;
        }
        public static bool existeUsuarioChaves(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT T_Usuario_Chaves FROM Tb_Usuarios_Chaves WHERE T_Usuario_Chaves='" + u.Usuario_Chaves + "'";
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

        /// metodo para inserir um usuario chave no cadastro de chaves
        public static void novoUsuarioChave(Usuario u)
        {
            if (existeUsuarioChaves(u))
            {
                MessageBox.Show("Usuario da chave já existe");
                return;
            }
            try
            {
                var cmd = conexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO Tb_Usuarios_Chaves (T_Usuario_Chaves) VALUES (@Usuario_Chaves)";
                cmd.Parameters.AddWithValue("@Usuario_Chaves", u.Usuario_Chaves);

                cmd.ExecuteNonQuery();
                conexaoBanco().Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Cadastrar Usuario Chave");
                conexaoBanco().Close();

            }
        }
        /// metodo para mostrar o banco no datata grid
        public static DataTable obterUsuariochavesIDnome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT Id_Usuario_Chaves as 'ID',T_Usuario_Chaves as 'Usuario Chaves' FROM Tb_Usuarios_Chaves";
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
        /// metodo para deletar usuario chaves
        public static void DeletarUsuarioChaves(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Tb_Usuarios_Chaves WHERE Id_Usuario_Chaves=" + id;
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
        /// metodo para obter dados do usuario chave    
        public static DataTable obterDadosUsuarioChaves(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Tb_Usuarios_Chaves WHERE Id_Usuario_Chaves="+id;
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
    }
}

