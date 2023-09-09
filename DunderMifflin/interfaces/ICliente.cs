using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DunderMifflin.interfaces
{
    internal interface ICliente
    {
        double? Cadastro { get; set; }
        string? Nome { get; set; }
        string? Telefone { get; set; }
        string? Email { get; set; }
        string? Endereco { get; set; }

    }
}
