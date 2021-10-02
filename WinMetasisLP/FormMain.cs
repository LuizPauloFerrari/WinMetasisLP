using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinMetasisLP.Util;

namespace WinMetasisLP
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            UtilAPI.ConfigureClient(Properties.Settings.Default.URLAPIMetasis);
        }

        private void BtnProduto_Click(object sender, EventArgs e)
        {
            FormProduto _Form = new FormProduto
            {
                MdiParent = this
            };
            _Form.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
