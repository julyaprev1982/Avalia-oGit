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
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
        }

        private void InserirBt_Click(object sender, EventArgs e)
        {
            //Incluindo as informações da tela no objeto Cliente
            Especialidadee especialidade = new Especialidadee()
            {

                NomeEspecialidade = EspecialidadeTxt.Text,
               
              
            };

            //Inserir dados
            InserirEspecialidade(especialidade);
            //Atualizar dados na grid
            CarregarEspecialidade();
        }
        private void Especialdade_Load(object sender, EventArgs e)
        {
            CarregarEspecialidade();
        }

        private void CarregarEspecialidade()
        {
            dataGridView1.DataSource = ConnectionSQLite.GetEspecialidadeAll();

        }

        private void InserirEspecialidade(Especialidadee especialidade)
        {
            try
            {
                ConnectionSQLite.AddEsp(especialidade);
                MessageBox.Show("Especialidade Inserida com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO:" + ex.Message);

            }
        }
    }
}
