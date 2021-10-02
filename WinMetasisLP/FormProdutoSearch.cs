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
using WinMetasisLP.Entities.Base;

namespace WinMetasisLP
{
    public partial class FormProdutoSearch : Form
    {
        public string ResultValue;
        EntityPage<Produto> _ProdutosPage;

        public FormProdutoSearch()
        {
            InitializeComponent();
            ResultValue = "";
            _ProdutosPage = new EntityPage<Produto>();
            _ProdutosPage.PageNumber = 1;
            _ProdutosPage.PageSize = 3;
            NuPage.Minimum = 1;
            NuPage.Maximum = 1;
        }

        public async void LoadGrid()
        {
            try
            {
                NuPage.Maximum = 99999;
                dgProdutos.Rows.Clear();

                ProdutoDTO _ProdutoModel = new ProdutoDTO
                {
                    produtoId = int.TryParse(edtProdutoId.Text, out int i) ? Convert.ToInt32(edtProdutoId.Text) : 0,
                    descricao = EdtDescricao.Text,
                    precoIni = double.TryParse(edtPrecoIni.Text, out double n1) ? Convert.ToDouble(edtPrecoIni.Text) : 0,
                    precoFim = double.TryParse(EdtPrecoFim.Text, out double n2) ? Convert.ToDouble(EdtPrecoFim.Text) : 0
                };

                //List<Produto> _Produtos;
                //_Produtos = await UtilAPI.PostFilterAsync<List<Produto>,ProdutoDTO>(_ProdutoModel);

                _ProdutosPage = await
                        UtilAPI.PostFilterAsyncPage<Produto, ProdutoDTO>(
                            _ProdutoModel, 
                            _ProdutosPage.PageNumber, 
                            _ProdutosPage.PageSize);
     
                if (_ProdutosPage.Items != null)
                {
                    foreach (Produto _Produto in _ProdutosPage.Items)
                    {
                        dgProdutos.Rows.Add(_Produto.produtoId, _Produto.descricao, _Produto.preco);
                    }
                }
            }
            finally
            {
                NuPage.Value = _ProdutosPage.PageNumber <= 0 ? 1 : _ProdutosPage.PageNumber;
                NuPage.Maximum = _ProdutosPage.PageCount <= 0 ? 1 : _ProdutosPage.PageCount;
                lbCount.Text = $"Número de Registros: {_ProdutosPage.TotalItemCount}";
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //NuPage.Value++;
            LoadGrid();
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPosterior_Click(object sender, EventArgs e)
        {
            if (_ProdutosPage.PageNumber < _ProdutosPage.PageCount) 
            {
                _ProdutosPage.PageNumber++;
            };
            LoadGrid();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (_ProdutosPage.PageNumber > 1) { _ProdutosPage.PageNumber--; };
            LoadGrid();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            _ProdutosPage.PageNumber = 1;
            LoadGrid();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            _ProdutosPage.PageNumber = _ProdutosPage.PageCount;
            LoadGrid();
        }
    }
}
