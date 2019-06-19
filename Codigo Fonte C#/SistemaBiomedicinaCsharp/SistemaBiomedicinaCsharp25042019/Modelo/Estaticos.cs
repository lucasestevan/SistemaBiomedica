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

        //IMPRESSAO bio
        public static String nome;
        public static String datacol;
        public static String colaborador;
        public static String COLESTEROL;
        public static String TRI;
        public static String HDL;
        public static String LDL;
        public static String VI_DL;
        public static String DHE;
        public static String CREATINA;
        public static String TGO;
        public static String TGP;
        public static String BIL_D;
        public static String FERRO;
        public static String PROTEINA;
        public static String CLOR;
        public static String FAL;
        public static String CALCIO;
        public static String ALBUMINA;
        public static String CPK;
        public static String ACIDO_URICO;
        public static String DHL;
        public static String BHCQ;
        public static String PHOS;


        //IMPRESSAO hema
        public static String nomeHema;
        public static String datacolHema;
        public static String colaboradorHema;
        public static String Eritocitos;
        public static String Hemoglobina;
        public static String Hematocrito;
        public static String VCM;
        public static String HCM;
        public static String CHCM;
        public static String Plaquetas;
        public static String Reticulocitos;
        public static String Leucocitos;
        public static String Mielocitos;
        public static String Metamielocitos;
        public static String Bastonetes;
        public static String Segmentados;
        public static String Eosinofilos;
        public static String Basofilos;
        public static String Linfoticos_Tipicos;
        public static String Linfoticos_Atipicos;
        public static String Monocitos;
        public static String Outras;
        public static String Observacao;
        public static String ABO;
        public static String RH;
        public static String VHS;
        public static String Falci;


        //IMPRESSAO MICRO
        public static String nomeMicro;
        public static String datacolMicro;
        public static String colaboradorMicro;
        public static String Material_utilizado;
        public static String Gram;
        public static String Micro1;
        public static String C_Col;
        public static String Micro2;
        public static String C_Col2;
        public static String Baar;
        public static String Gram_2;

        //IMPRESSAO URINALISE
        public static String nomeUri;
        public static String datacolUri;
        public static String colaboradorUri;
        public static String Cor;
        public static String Aspecto;
        public static String Densidade;
        public static String Reacao_pH;
        public static String Proteinas;
        public static String Glicose;
        public static String Urobiolinogenio;
        public static String Bilirrubinas;
        public static String Corpos_Cetonicos;
        public static String HemoglobinaBio;
        public static String Nitrito;
        public static String Celulas_Epiteliais;
        public static String LeucocitosBio;
        public static String Hemacias;
        public static String Bacterias;
        public static String Cilindros;
        public static String Cristais;
        public static String Filamentos_de_muco;
        public static String Trinch;
        public static String Outros_Elementos1;
        public static String Outros_Elementos2;
        

        //CRIAR USUARIOS PARA DEFINIR O NIVEL DE ACESSO
        public static string usuarioNome;
    }
}
