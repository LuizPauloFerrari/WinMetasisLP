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
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public double PrecoIni { get; set; }
        public double PrecoFim { get; set; }
        public EntityOptions Options { get; set; }

        public ProdutoDTO()
        {
            Options = new EntityOptions
            {
                Found = false,
                Status = StatusRecord.Inserting
            };
        }

        public override string ToString()
        {
            return "Produto";
        }
    }
    
}
