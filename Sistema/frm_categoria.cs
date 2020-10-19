using sistema.DAL;
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
    public partial class frm_categoria : Form
    {
        public frm_categoria()
        {
            InitializeComponent();
        }

        private void frm_categoria_Load(object sender, EventArgs e)
        {
            this.categoriaBindingSource.DataSource = DataContextFactory.DataContext.categoria;
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.AddNew();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (this.validar())
            {
          
            this.categoriaBindingSource.EndEdit();
            DataContextFactory.DataContext.SubmitChanges();
            MessageBox.Show("Categoria Cadastrada com socesso!");

            }
        }
        private bool validar()
        {
            if (txt_categoria.Text.Trim () == string.Empty)
            {
                MessageBox.Show("O campo e obrigatorio");
                txt_categoria.Focus();
                return false;
            }
            return true;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza!", "Confirmacao", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.CategoriaPossuiProduto(this.categoriaAtual))
            
                    MessageBox.Show("Voce nao pode Exclir essa categoria, proque existe produtos nela.");
                else
                {
                    this.categoriaBindingSource.RemoveCurrent();
                    DataContextFactory.DataContext.SubmitChanges();
                    MessageBox.Show("Categoria excluida com socesso!");

                }
                
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.categoriaBindingSource.CancelEdit();
        }

        public categoria categoriaAtual
        {
            get
            {
                return (categoria)this.categoriaBindingSource.Current;

            }
        }

        private bool CategoriaPossuiProduto(categoria categoria)
        {
            var produtos = DataContextFactory.DataContext.produtos.Where(x => x.id_categoria == categoria.id_categoria);
            if (produtos.Count() > 0)
                return true;
            else
                return false;
        }
    }   

}
