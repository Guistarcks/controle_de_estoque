using controle_de_estoque.classes;
using controle_de_estoque.classesDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controle_de_estoque.view
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Objeto para a classe Usuarios

            Usuarios obj = new Usuarios();
            
            obj.nome = txtNome.Text;
            obj.sobrenome = txtSobrenome.Text;
            obj.cpf = txtCpf.Text;
            obj.rg = txtRg.Text;
            obj.telefone = txtTelefone.Text;
            obj.celular = txtCelular.Text;
            obj.cargo = cbxCargo.Text;
            obj.setor = cbxSetor.Text;
            obj.usuario = txtUsuario.Text;
            obj.senha = txtSenha.Text;

            //Objeto para a classe UsuarioDAO e chama metodo cadastrarUsuario
            UsuarioDAO dao = new UsuarioDAO();
            dao.cadastrarUsuario(obj);

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void cbxCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
