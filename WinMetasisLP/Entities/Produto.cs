using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinMetasisLP.Util;
using WinMetasisLP.Entities.Base;

namespace WinMetasisLP.Entities
{
    public class Produto: IEntity
    {
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public EntityOptions Options { get; set; }

        public Produto()
        {
            Options = new EntityOptions
            {
                Found = false,
                Status = StatusRecord.Inserting
            };
        }
    }
    
}
