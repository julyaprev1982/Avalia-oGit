using DB;
using Entidade;
using System;
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
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void InserirBt_Click(object sender, EventArgs e)
        {

            //Incluindo as informações da tela no objeto Profissionais 
            Agendae agenda = new Agendae()
            {
                NomePaciente = new Pacientee()
                {
                    IdPaciente = int.Parse(ComboNomePaciente.SelectedValue.ToString()),
                    Nome = ComboNomePaciente.Text
                },

                NomeProfissional = new Profissionaise()
                {
                    IdProfissional = int.Parse(ComboNomeProfissional.SelectedValue.ToString()),
                    Profissional = ComboNomeProfissional.Text
                },
                Valor = ValorTxt.Text,
                Horario = ValorTxt.Text,
                Data = ValorTxt.Text
              
            };

            //Inserir dados
            InserirAgenda(agenda);
            //Atualizar dados na grid
            CarregarGridAgenda();
        }


        private void CarregarComboPaciente()
        {
            ComboNomePaciente.DataSource = ConnectionSQLite.GetPacienteAll();
            ComboNomePaciente.ValueMember = "IdPaciente";
            ComboNomePaciente.DisplayMember = "NomePac";
        }

        private void CarregarComboProfissional()
        {
            ComboNomeProfissional.DataSource = ConnectionSQLite.GetProfissionaisAll();
            ComboNomeProfissional.ValueMember = "IdProfissionais";
            ComboNomeProfissional.DisplayMember = "Profissional";
        }

        private void CarregarGridAgenda()
        {
            dataGridView1.DataSource = ConnectionSQLite.GetAgendasAll();

        }


        private void InserirAgenda(Agendae agenda)
        {
            try
            {
                ConnectionSQLite.AddAgenda(agenda);
                MessageBox.Show("Profissional Inserida com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

       
        private void Agenda_Load(object sender, EventArgs e)
        {
            CarregarComboPaciente();
            CarregarComboProfissional();
            CarregarGridAgenda();

        }
    }
}

