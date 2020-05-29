using System;
using Entidade;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;

namespace ProjAvaliacao
{
    public partial class Cidades : Form
    {
        public Cidades()
        {
            InitializeComponent();
        }

        private void InserirBt_Click(object sender, EventArgs e)
        {
            //Incluindo as informações da tela no objeto Cliente
            Cidadee cidade = new Cidadee()
            {

                NomeCidade = CidadeTxt.Text,
                Estado = EstadoTxt.Text
              
            };
            
            //Inserir dados
            InserirCidade(cidade);
            
            //Atualizar dados na grid
            CarregarCidade();
        }
        private void Cidade_Load(object sender, EventArgs e)
        {
            CarregarCidade();
        }

        private void CarregarCidade()
        {
            dataGridView1.DataSource = ConnectionSQLite.GetCidadeAll();
               
        }

        private void InserirCidade(Cidadee cidade)
        {
            try
            {
                ConnectionSQLite.Add(cidade);
                MessageBox.Show("Cidade Inserida com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO Cidade não inserida:" + ex.Message);

            }
        }

        private void ConsultarBt_Click(object sender, EventArgs e)
        {
            CarregarCidade();        }

        private void AlterarBt_Click(object sender, EventArgs e)
        {
           
        }
    }
}
