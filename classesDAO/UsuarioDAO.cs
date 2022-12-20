using controle_de_estoque.classes;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace controle_de_estoque.classesDAO
{
    public class UsuarioDAO
    {
        private MySqlConnection conexao;

        public UsuarioDAO()
         {
            this.conexao = new ConnectDb().getconnection();
        }

        #region CadastrarUsuario

        //Metodo cadastro de usuários
        //Ao chamar o metodo cadastrarUsuario é passado por referência o objeto tipo Usuarios(classe Usurios)
        public void cadastrarUsuario(Usuarios obj) 
        {
            try
            {
                //Comando SQL - insert into
                string dadosSql = @"insert into usuarios(nome, sobrenome, cpf, rg, tel, cel, cargo, usuario, senha)
                    values(@nome, @sobrenome, @cpf, @rg, @tel, @cel, @cargo, @usuario, @senha)";

                MySqlCommand executaCmdSql = new MySqlCommand(dadosSql, conexao);
                executaCmdSql.Parameters.AddWithValue("@nome", obj.nome);
                executaCmdSql.Parameters.AddWithValue("@sobrenome", obj.sobrenome);
                executaCmdSql.Parameters.AddWithValue("@cpf", obj.cpf);
                executaCmdSql.Parameters.AddWithValue("@rg", obj.rg);
                executaCmdSql.Parameters.AddWithValue("@tel", obj.telefone);
                executaCmdSql.Parameters.AddWithValue("@cel", obj.celular);
                executaCmdSql.Parameters.AddWithValue("@cargo", obj.cargo);
                executaCmdSql.Parameters.AddWithValue("@usuario", obj.usuario);
                executaCmdSql.Parameters.AddWithValue("@senha", obj.senha);

                //Abre conexão
                conexao.Open();
                executaCmdSql.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado!");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro: " + erro);
                
            }

        }
        #endregion
    }
}
