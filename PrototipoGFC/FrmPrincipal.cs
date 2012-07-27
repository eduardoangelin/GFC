using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrototipoGFC
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            FrmLogin form = new FrmLogin();
            form.ShowDialog();
        }

        private void clientesFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 2;
        //    FrmConsultaClienteFornecedor form = new FrmConsultaClienteFornecedor();
        //    form.ShowDialog();
        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tablessControl1.SelectedIndex = 1;
          //  FrmCriarContasAPagar CriarContasAPagar = new FrmCriarContasAPagar();
          //  CriarContasAPagar.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
