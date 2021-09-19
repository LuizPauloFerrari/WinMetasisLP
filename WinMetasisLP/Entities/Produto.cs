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
        public int produtoId { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }
        public EntityOptions Options { get; set; }

        public Produto()
        {
            Options = new EntityOptions();
            Options.Found = false;
            Options.Status = StatusRecord.Inserting;
        }
    }
    
}
