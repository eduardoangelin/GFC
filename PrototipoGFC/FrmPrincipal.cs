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
            FrmConsultaClienteFornecedor form = new FrmConsultaClienteFornecedor();
            form.ShowDialog();
        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCriarContasAPagar CriarContasAPagar = new FrmCriarContasAPagar();
            CriarContasAPagar.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
        }
    }
}
