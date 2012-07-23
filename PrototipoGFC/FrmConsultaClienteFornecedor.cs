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
    public partial class FrmConsultaClienteFornecedor : Form
    {
        public FrmConsultaClienteFornecedor()
        {
            InitializeComponent();
        }

        private void FrmConsultaClienteFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'frametlDataSet.cv001' table. You can move, or remove it, as needed.
            this.cv001TableAdapter.Fill(this.frametlDataSet.cv001);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadastrarClienteFornecedor CadastrarClienteFornecedor = new FrmCadastrarClienteFornecedor();
            CadastrarClienteFornecedor.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
