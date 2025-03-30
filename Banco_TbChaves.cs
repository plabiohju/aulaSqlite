using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaSqlite
{
    internal class Banco_TbChaves
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection conexaoBanco()
        {

            conexao = new SQLiteConnection("Data Source=" + globais.caminhoBanco + globais.nomeBanco);
            conexao.Open();
            return conexao;
        }
        public static bool existeChaves(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT T_Chaves FROM Tb_Chaves WHERE T_Chaves='" + u.Chaves + "'";
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

               /// metodo para inserir uma chave no cadastro de chaves
        public static void novaChave(Usuario u)
        {
            if (existeChaves(u))
            {
                MessageBox.Show("chave já existe");
                return;
            }
            try
            {
                var cmd = conexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO Tb_Chaves (T_Chaves) VALUES (@Chaves)";
                cmd.Parameters.AddWithValue("@Chaves", u.Chaves);
                
                cmd.ExecuteNonQuery();
                conexaoBanco().Close();
               
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao Cadastrar Chave");
                conexaoBanco().Close();

            }
        }
        /// metodo para mostrar o banco no datata grid
        public static DataTable obterchavesIDnome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT Id_Chaves as 'ID Chaves',T_Chaves as 'Chaves' FROM Tb_Chaves";
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
        /// metodo para deletar chaves
        public static void DeletarChaves(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Tb_Chaves WHERE Id_Chaves=" + id;
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
        /// metodo para obter dados da chave    
        public static DataTable obterDadosChaves(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Tb_Chaves WHERE Id_Chaves=" + id;
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
