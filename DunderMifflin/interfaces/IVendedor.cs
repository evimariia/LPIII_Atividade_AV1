using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunderMifflin.interfaces
{
    interface IVendedor
    {
        string? Nome { get; set; }

        double? Cadastro { get; set; }

        string? Telefone { get; set; }
    }
}
