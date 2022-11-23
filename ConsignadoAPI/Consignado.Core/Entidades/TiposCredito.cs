using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consignado.Core.Entidades
{
    public class TiposCredito
    {
        public TiposCredito(string descricao, double taxaCredito) 
        {
            Descricao = descricao;
            TaxaCredito = taxaCredito;
        }

        public string Descricao { get; set; }
        public double TaxaCredito { get; set; }
    }
}
