using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinMetasisLP.Entities.Base
{
    public interface IEntity
    {
        EntityOptions Options { get; set; }
    }
}
