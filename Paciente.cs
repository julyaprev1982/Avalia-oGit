using System;
using Entidade;
using DB;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjAvaliacao
{
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        private void InserirBt_Click(object sender, EventArgs e)
        {
            //Incluindo as informações da tela no objeto Cliente
            Pacientee paciente = new Pacientee()
            {

                Nome = NomeTxt.Text,
                Cpf = CpfTxt.Text,
                Fone = FoneTxt.Text

            };

            //Inserir dados
            InserirPaciente(paciente);

            //Atualizar dados na grid
            CarregarPaciente();
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            CarregarPaciente();
        }

        private void CarregarPaciente()
        {
            dataGridView1.DataSource = ConnectionSQLite.GetPacienteAll();

        }

        private void InserirPaciente(Pacientee paciente)
        {
            try
            {
                ConnectionSQLite.AddPaciente(paciente);
                MessageBox.Show("Paciente Inserida com sucesso");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO Cidade não inserida:" + ex.Message);

            }
        }

        private void ConsultarBt_Click(object sender, EventArgs e)
        {
            CarregarPaciente();
        }
    }
}

