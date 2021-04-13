using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMART_MOD.Login
{
    class Conexao
    {
        login con = new login();
        protected static string server = "*******";
        protected static string port = "**********";
        protected static string Uid = "**********";
        protected static string database = "**********";
        private static string Pwd = "*************";
        private bool existe;

        public bool ConexaoOn
            (
           )
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("server=" + server + ";port=" + port + ";Uid=" + Uid + ";database=" + database + ";Pwd=" + Pwd);

                conexao.Open();
                conexao.Close();
                return existe = true;
                con.conexaoBanco(conexao);
               
            }
            catch
            {
                return existe = false;
            }
        }
    }

}
