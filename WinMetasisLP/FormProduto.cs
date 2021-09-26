using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinMetasisLP.Entities;
using WinMetasisLP.Util;

namespace WinMetasisLP
{
    public partial class FormProduto : Form
    {
        Produto _ProdutoModel;

        public FormProduto()
        {
            InitializeComponent();
            
            CreateModels();
        }

        private void CreateModels()
        {
            _ProdutoModel = new Produto();
        }

        private void Reload()
        {
            _ProdutoModel.produtoId = int.TryParse(EdtProdutoId.Text, out int i) ? Convert.ToInt32(EdtProdutoId.Text) : 0;
            _ProdutoModel.descricao = EdtDescricao.Text;
            string _Preco = EdtPreco.Text.Replace(CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, "");
            _ProdutoModel.preco = double.TryParse(_Preco, out double n) ? Convert.ToDouble(_Preco) : 0;
        }

        private void RefreshView()
        {
            EdtProdutoId.Text = _ProdutoModel.produtoId.ToString();
            EdtDescricao.Text = _ProdutoModel.descricao;
            EdtPreco.Text = _ProdutoModel.preco.ToString("C2", CultureInfo.CurrentCulture);
        }

        private void Clean()
        {
            CreateModels();
            RefreshView();
            EdtProdutoId.Focus();
        }
        private void btnClean_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFields(
                );
        }
        
        private void LoadFields()
        {
            Reload();
            try
            {
                //Rodar de Modo Síncrono 
                //   https://stackoverflow.com/questions/53529061/whats-the-right-way-to-use-httpclient-synchronously/53529122
                //   https://docs.microsoft.com/en-us/archive/blogs/jpsanders/asp-net-do-not-use-task-result-in-main-context
                var task = Task.Run(() => UtilAPI.GetAsync<Produto>(_ProdutoModel, _ProdutoModel.produtoId.ToString()));
                task.Wait();
                _ProdutoModel = task.Result;

                //Modo Assincrono
                //_ProdutoModel = await UtilAPI.GetAsync<Produto>(_ProdutoModel, _ProdutoModel.produtoId.ToString());

                if (_ProdutoModel.Options.Status == StatusRecord.Inserting)
                {
                    CreateModels();
                }
            }
            finally
            {
                RefreshView();
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Reload();
            try
            {
                if (_ProdutoModel.Options.Status == StatusRecord.Inserting)
                {
                    var task = Task.Run(() => UtilAPI.CreateAndGetAsync<Produto>(_ProdutoModel));
                    task.Wait();
                    _ProdutoModel = task.Result;
                }
                else
                {
                    var task = Task.Run(() => UtilAPI.UpdateAsync(_ProdutoModel, _ProdutoModel.produtoId.ToString()) );
                    task.Wait();
                }
            }
            finally
            {
                RefreshView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Reload();
            try
            {
                if (_ProdutoModel.Options.Status == StatusRecord.Updating)
                {
                    var task = Task.Run(() => UtilAPI.DeleteAsync(_ProdutoModel, _ProdutoModel.produtoId.ToString()) );
                    task.Wait();
                    var statusCode = task.Result;
                    MessageBox.Show($"Registro Excluído!");
                    Clean();
                }
            }
            finally
            {
                RefreshView();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormProdutoSearch _Form = new FormProdutoSearch();
            if (_Form.ShowDialog() == DialogResult.OK)
            {
                EdtProdutoId.Text = _Form.ResultValue;
                LoadFields();
            }
            EdtProdutoId.Focus();
        }
    }
}
