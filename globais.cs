using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaSqlite
{
    internal class globais
    {
        public static string versao = "Versão 1.0";  
        public static Boolean logado = false;
        public static int nivel = 0;
        public static string caminho = System.Environment.CurrentDirectory;
        public static string nomeBanco = "bcc";
        public static string caminhoBanco = caminho + @"\banco\";

        /*
         Tb_Usuarios
         N_IdUsuarios
         T_NomeUsuario
         T_UserName
         T_SenhaUsuario
         T_StatusUsuario
         N_NivelUsuario

         */

    }
}
