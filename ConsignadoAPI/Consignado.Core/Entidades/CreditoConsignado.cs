using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consignado.Core.Entidades
{
    public class CreditoConsignado
    {
        public double ValorCredito { get; set; }
        public TiposCredito TipoCredito { get; set; }
        public int QuantidadeParcelas { get; set; }
        public DateTime DataPrimeiroVencimento { get; set; }
    }
}
