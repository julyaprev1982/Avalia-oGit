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
    public partial class Profissionaiss : Form
    {
        public Profissionaiss()
        {
            InitializeComponent();
        }


        private void InserirBt_Click(object sender, EventArgs e)
        {
            //Incluindo as informações da tela no objeto Profissionais 
            Profissionaise profissionais = new Profissionaise()
            {

                Profissional = ProfissionalTxt.Text,
                Cpf = CpfTxt.Text,
                Cidade = new Cidadee()
                {
                    Id = int.Parse(ComboCidade.SelectedValue.ToString()),
                    NomeCidade = ComboCidade.Text
                },
                Especialidade = new Especialidadee()
                {
                    IdEspecialidade = int.Parse(ComboEspecialidade.SelectedValue.ToString()),
                    NomeEspecialidade = ComboEspecialidade.Text
                },
            };

            //Inserir dados
           InserirProfissional(profissionais);
            //Atualizar dados na grid
            CarregarGridProfissionais();
        }

    

        private void CarregarComboCidade()
        {
            ComboCidade.DataSource = ConnectionSQLite.GetCidadeAll();
            ComboCidade.ValueMember = "IdCidade";
            ComboCidade.DisplayMember = "Cidade";
        }

       private void CarregarComboEspecialidade()
       {
            ComboEspecialidade.DataSource = ConnectionSQLite.GetEspecialidadeAll();
            ComboEspecialidade.ValueMember = "IdEsp";
            ComboEspecialidade.DisplayMember = "Especialidade";
        }

        private void CarregarGridProfissionais()
        {
            dataGridView1.DataSource = ConnectionSQLite.GetProfissionaisAll();
            
        }


        private void InserirProfissional(Profissionaise profissionais)
        {
            try
            {
                ConnectionSQLite.AddProfissionais(profissionais);
                MessageBox.Show("Profissional Inserida com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.Message);
            }
        }

        private void Profissionaiss_Load_1(object sender, EventArgs e)
        {
            CarregarComboCidade();
            CarregarComboEspecialidade();
            CarregarGridProfissionais();
        }
    }
}
