using Consignado.Core.Entidades;
using Consignado.Core.Interfaces.Repositorios;
using Consignado.Infra.Persistencia.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consignado.Application.Services
{
    public class LiberaCreditoService : ILiberaCreditoService
    {
        public CreditoConsignadoResponse AvaliarCredito(CreditoConsignado consignado)
        {
            CreditoConsignadoResponse obj = new();

            if (consignado.ValorCredito > 1000000)
            {
                obj.Mensagem = "O valor do crédito maximo permitido é de 1.000.000,00";
                obj.StatusCredito = "Recusado";
                obj.ValorTotal = 0;
                obj.ValorJuros = 0;
                return obj;
            }
            
            if (consignado.QuantidadeParcelas < 5 || consignado.QuantidadeParcelas > 72)
            {
                obj.Mensagem = "A quantidade de parcela minima é 5x e a máxima é 72x";
                obj.StatusCredito = "Recusado";
                obj.ValorTotal = 0;
                obj.ValorJuros = 0;
                return obj;
            }

            obj = CreditoPessoaJuridica(consignado);
            if(obj.StatusCredito != null && obj.StatusCredito.Equals("Recusado"))
                return obj;

            obj = DefinirDataPrimeiroVencimento(consignado);
            if (obj.StatusCredito != null && obj.StatusCredito.Equals("Recusado"))
                return obj;


            obj.StatusCredito = "Aprovado";
            obj.ValorTotal = (consignado.ValorCredito + (consignado.TipoCredito.TaxaCredito / 100) * consignado.ValorCredito);
            obj.ValorJuros = (obj.ValorTotal - consignado.ValorCredito);
            obj.Mensagem = "Emprestimo feito com sucesso";
            return obj;
        }

        public CreditoConsignadoResponse DefinirDataPrimeiroVencimento(CreditoConsignado consignado)
        {
            CreditoConsignadoResponse obj = new();

            if (consignado.DataPrimeiroVencimento.Date >= DateTime.Now.Date.AddDays(40))
            {

                obj.Mensagem = "A data do primeiro vencimento é no maximo 40 dias a partir da Data Atual.";
                obj.StatusCredito = "Recusado";
                obj.ValorTotal = 0;
                obj.ValorJuros = 0;
                return obj;
            }
            else if (consignado.DataPrimeiroVencimento.Date <= DateTime.Now.AddDays(15).Date)
            {
                obj.Mensagem = "A data do primeiro vencimento é no minimo 15 dias a partir da Data Atual.";
                obj.StatusCredito = "Recusado";
                obj.ValorTotal = 0;
                obj.ValorJuros = 0;
                return obj;
            }

            return obj;
        }

        public CreditoConsignadoResponse CreditoPessoaJuridica(CreditoConsignado consignado)
        {
            CreditoConsignadoResponse obj = new();

            if (consignado.TipoCredito.TaxaCredito == 5 && consignado.ValorCredito < 15000)
            {
                obj.Mensagem = "O valor do crédito minimo permitido para Credito Pessoa Juridica é de 15.000,00";
                obj.StatusCredito = "Recusado";
                obj.ValorTotal = 0;
                obj.ValorJuros = 0;
                return obj;
            }

            return obj;
        }
    }
}
