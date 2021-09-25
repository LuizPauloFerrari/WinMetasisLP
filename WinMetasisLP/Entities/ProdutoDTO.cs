using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinMetasisLP.Util;
using WinMetasisLP.Entities.Base;

namespace WinMetasisLP.Entities
{
    public class ProdutoDTO: IEntity
    {
        public int produtoId { get; set; }
        public string descricao { get; set; }
        public double precoIni { get; set; }
        public double precoFim { get; set; }
        public EntityOptions Options { get; set; }

        public ProdutoDTO()
        {
            Options = new EntityOptions();
            Options.Found = false;
            Options.Status = StatusRecord.Inserting;
        }

        public override string ToString()
        {
            return "Produto";
        }
    }
    
}
