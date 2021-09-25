using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinMetasisLP.Entities;
using WinMetasisLP.Util;

namespace WinMetasisLP
{
    public partial class FormProdutoSearch : Form
    {
        public string ResultValue;
        
        public FormProdutoSearch()
        {
            InitializeComponent();
            ResultValue = "";
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            dgProdutos.Rows.Clear();

            ProdutoDTO _ProdutoModel = new ProdutoDTO
            {
                produtoId = int.TryParse(edtProdutoId.Text, out int i) ? Convert.ToInt32(edtProdutoId.Text) : 0,
                descricao = EdtDescricao.Text,
                precoIni = double.TryParse(edtPrecoIni.Text, out double n1) ? Convert.ToDouble(edtPrecoIni.Text) : 0,
                precoFim = double.TryParse(EdtPrecoFim.Text, out double n2) ? Convert.ToDouble(EdtPrecoFim.Text) : 0
            };

            List<Produto> _Produtos;
            _Produtos = await UtilAPI.PostFilterAsync<List<Produto>,ProdutoDTO>(_ProdutoModel);
            if (_Produtos != null)
            {
                foreach (Produto _Produto in _Produtos)
                {
                    dgProdutos.Rows.Add(_Produto.produtoId, _Produto.descricao, _Produto.preco);
                }
            }
        }

        private void dgProdutos_DoubleClick(object sender, EventArgs e)
        {
            ResultValue = dgProdutos.Rows[dgProdutos.CurrentRow.Index].Cells[0].FormattedValue.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ResultValue = dgProdutos.Rows[dgProdutos.CurrentRow.Index].Cells[0].FormattedValue.ToString();
        }

        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
