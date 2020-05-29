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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

      

            private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cidades c = new Cidades();
            {

                c.ShowDialog();
            };
        }

        private void especialidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades es = new Especialidades();
            {
                es.ShowDialog();
            }
        }

        private void profissionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profissionaiss pf = new Profissionaiss();
            {
                pf.ShowDialog();
            }
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paciente pa = new Paciente();
            {
                pa.ShowDialog();
            }
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agenda ag = new Agenda();
            {
                ag.ShowDialog();
            }
        }
    }
}
