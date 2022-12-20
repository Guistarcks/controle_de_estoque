using System;
using System.Collections.Generic;
using System.Configuration;     //Biblioteca necessária para acessar ConfigurationManager
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;   //Biblioteca necessária para conexão com banco de dados - MySqlConnection

namespace controle_de_estoque.classes
{
    public class ConnectDb
    {
        public  MySqlConnection databaseConnection = null;
        // Metodo que conecta ao banco de dados
        public  MySqlConnection getconnection()
        {
            //Faz a conexão com o arquivo App.config e chama o nome da conectionString - EX: "sql10584764"         
            
            if (databaseConnection == null)
            {
             string connectionString = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
              databaseConnection = new MySqlConnection(connectionString) ; 

            }
            return databaseConnection;//Retorna a conexao com o banco de dados
        }
    }
}
