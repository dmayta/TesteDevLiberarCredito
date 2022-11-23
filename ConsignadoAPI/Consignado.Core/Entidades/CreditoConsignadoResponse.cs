using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consignado.Core.Entidades
{
    public class CreditoConsignadoResponse
    {
        public string StatusCredito { get; set; }
        public double ValorTotal { get; set; }
        public double ValorJuros { get; set; }
        public string Mensagem { get; set; }
    }
}
