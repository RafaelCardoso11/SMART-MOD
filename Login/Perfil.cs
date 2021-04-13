using MySql.Data.MySqlClient;
using SMART_MOD;
using SMART_MOD.Login;
using System.Data;
using System.Windows.Forms;
using System;

class login
{
    Conexao con_mysql = new Conexao();
    page_login erroLogin = new page_login();
    private static string avatar;
    private static string apelidoBanco;
    private static string senhaBanco;

    private string apelido;
    private string senha;
    private string erro;

    private MySqlCommand command;


   
    public void conexaoBanco(MySqlConnection con_mysql)
    {
        con_mysql.Open();
         void ConexaoI
             (
             string apelido,
             string senha
             )
        {
            this.apelido = apelido;
            this.senha = senha;

            checkLogin(apelido, senha, con_mysql);
        }

    }
    private void checkLogin(string apelido, string senha, MySqlConnection con)
    {

        string avatar = login.avatar;
        var validaSenha = EasyEncryption.MD5.ComputeMD5Hash(senha);
        this.apelido = apelido;
        this.senha = senha;
        apelidoBanco = apelido;
        senhaBanco = senha;

        command = new MySqlCommand("select apelido, senha from userlogin where apelido='" + apelido + "'", con);
        MySqlDataReader reader;
        reader = command.ExecuteReader();
        reader.Read();

        apelidoBanco = reader.GetString(0).ToString();
        senhaBanco = reader.GetString(1).ToString();
        con.Close();

        string msg()
        {
            {
                if (apelido == apelidoBanco) // APELIDO DO BANCO DE DADOS
                {
                    if (validaSenha == senhaBanco)// SENHA DO BANCO JÁ COM A MD5
                    {
                        hideLogin(apelido, avatar);
                    }
                    else
                    {
                        erro = "SENHA INVALIDA";
                    }
                }
                else
                {
                    erro = "APELIDO INVALIDO";

                }

                return erro;
            }
        }
   }

    
    private void hideLogin
        (
        string apelido,
        string banco
        )
    {


        if (banco == "PRO")
        {

        }
        else if (banco == "INFLUENCERS")
        {
          
        }
        else if (banco == "ADM")
        {

        }
        else if (banco == "MODERADOR")
        {

        }
        else if (banco == "SUPORTE")
        {

        }
        else
        {
            //Free
        }


    }


}
