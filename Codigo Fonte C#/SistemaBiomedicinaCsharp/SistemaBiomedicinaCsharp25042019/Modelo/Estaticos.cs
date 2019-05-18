using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiomedicinaCsharp25042019.Modelo
{
    public static class Estaticos
    {
        public static String nomePaciente; //static nome paciente
        public static String idPaciente; //static id paciente
        public static String nomeColarador; //static nome colaborador
        public static String idColaborador; //static id colaborador

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
