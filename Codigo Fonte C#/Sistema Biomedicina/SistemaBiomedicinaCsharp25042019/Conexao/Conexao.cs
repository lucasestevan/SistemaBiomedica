using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SistemaBiomedicinaCsharp25042019.Conexao
{
    class Conexao
    {
             
    //CRIAR CONEXAO COM BD SERVER
     public static SqlConnection con = new SqlConnection("Server=DESKTOP-628SFJB;DataBase=SistemaBio;User=lucas;Password=699002");

    //METODO ABRIR CONEXAO
    public static void abrir()
    {
      if ((int)con.State == 0)
      {
       con.Open();
      }
    }

    //METODO FECHAR CONEXAO
    public static void fechar()
    {
      if ((int)con.State == 1)
      {
       con.Close();
       }
    }

    //CRIAR USUARIOS PARA DEFINIR O NIVEL DE ACESSO
    public static string usuarioNome;

        
    }
}
