using Consignado.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consignado.Application.Services
{
    public interface ILiberaCreditoService
    {
        CreditoConsignadoResponse AvaliarCredito(CreditoConsignado consignado);
    }
}
