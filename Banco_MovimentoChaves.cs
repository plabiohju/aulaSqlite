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
    internal class Banco_MovimentoChaves
    {
        
        private static SQLiteConnection conexao;
        private static SQLiteConnection conexaoBanco()
        {

            conexao = new SQLiteConnection("Data Source=" + globais.caminhoBanco + globais.nomeBanco);
            conexao.Open();
            return conexao;
        }
        public static bool existeMovChaves(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            var cmd = conexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT T_UsuarioChaveMov FROM Tb_MovimentoChaves WHERE T_UsuarioChaveMov='" + u.username + "'";
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

        /// metodo para inserir um movimento de  chave no cadastro 
        public static void novaChaveMov(Usuario u)
        {
            if (existeMovChaves(u))
            {
                MessageBox.Show("chave já existe");
                return;
            }
            try
            {
                var cmd = conexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO Tb_MovimentoChaves (T_UsuarioChaveMov,T_ChaveMov,T_Responsavel,T_DataHora) VALUES (@UsuarioChaveMov,@ChaveMov,@Responsavel,@DataHora)";
                cmd.Parameters.AddWithValue("@UsuarioChaveMov", u.UsuarioChaveMov);
                cmd.Parameters.AddWithValue("@ChaveMov", u.ChaveMov);
                cmd.Parameters.AddWithValue("@Responsavel", u.Responsavel);
                cmd.Parameters.AddWithValue("@DataHora", u.DataHora);

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
        public static DataTable obterchavesMovIDnome()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT Id_MovimentoChaves as 'ID',T_UsuarioChaveMov as 'Usuario',T_ChaveMov as 'Chave',T_Responsavel as 'Responsavel',T_DataHora as 'Data e Hora' FROM Tb_MovimentoChaves";
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
        /// metodo para deletar movimento de chaves 
        public static void DeletarChavesMov(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Tb_MovimentoChaves WHERE Id_MovimentoChaves=" + id;
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
        /// metodo para obter dados do movimento de chave    
        public static DataTable obterDadosChaveMov(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = conexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Tb_MovimentoChaves WHERE Id_MovimentoChaves=" + id;
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
