using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frm_consultaProdutos : Form
    {
        public frm_consultaProdutos()
        {
            InitializeComponent();
        }

        private void frm_consultaProdutos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_sistemaDataSet.tb_categoria'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_categoriaTableAdapter.Fill(this.db_sistemaDataSet.tb_categoria);
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.categoria;

        }
    }
}
