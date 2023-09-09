using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunderMifflin.interfaces
{
    internal interface IProduto
    {
        string? Descricao { get; set; }
        double? Valor { get; set; }
    }
}
