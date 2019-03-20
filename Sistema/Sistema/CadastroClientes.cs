using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string vegano, lactose, diabetico, vegetariano, estadocivil;

            if(ckbVegano.Checked == true)
            {
                vegano = "sim";
            }
            else
            {
                vegano = "não";
            }

            if(ckbVegetariano.Checked == true)
            {
                vegetariano = "sim";
            }
            else
            {
                vegetariano = "não";
            }

            if(ckbLactose.Checked == true)
            {
                lactose = "sim";
            }
            else
            {
                lactose = "não";
            }

            if(ckbDiabetico.Checked == true)
            {
                diabetico = "sim";
            }
            else
            {
                diabetico = "não";
            }

            if(rbtnCasado.Checked == true)
            {
                estadocivil = "Casado";
            }else if(rbtnSolteiro.Checked == true)
            {
                estadocivil = "Solteiro";
            }
            else
            {
                estadocivil = "";
            }
            GravarCliente(txtNome.Text, txtEmail.Text, mtxtTelefone.Text, mtxtCelular.Text, cbxCidade.Items[cbxCidade.SelectedIndex].ToString(), cbxEstado.Items[cbxEstado.SelectedIndex].ToString(), estadocivil, vegetariano, vegano, lactose, diabetico);
            MessageBox.Show("Cliente cadastrado com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparClientes();
        }
        private void GravarCliente(string nome, string email, string telefone, string celular, string cidade, string estado, string estadocivil, string vegetariano, string lactose, string vegano, string diabetico)
        {
            StreamWriter arquivo;
            string caminho = "";

            arquivo = File.AppendText(caminho);
            arquivo.WriteLine("Nome: " + nome);
            arquivo.WriteLine("E-mail: " + email);
            arquivo.WriteLine("Telefone: " + telefone);
            arquivo.WriteLine("Celular: " + celular);
            arquivo.WriteLine("Cidade: " + cidade);
            arquivo.WriteLine("Estado: " + estado);
            arquivo.WriteLine("Vegano?: " + vegano);
            arquivo.WriteLine("DIabético?: " + diabetico);
            arquivo.WriteLine("Intolerante à lactose?: " + lactose);
            arquivo.WriteLine("Vegetariano?: " + vegetariano);
            arquivo.WriteLine("--------------------------");
            arquivo.WriteLine("");
            arquivo.Close();
        }
        private void LimparClientes()
        {
            txtNome.Clear();
            txtEmail.Clear();
            mtxtTelefone.Clear();
            mtxtCelular.Clear();
            cbxCidade.SelectedIndex = -1;
            cbxEstado.SelectedIndex = -1;
            ckbVegetariano.Checked = false;
            ckbVegano.Checked = false;
            ckbLactose.Checked = false;
            ckbDiabetico.Checked = false;
        }
    }
}
