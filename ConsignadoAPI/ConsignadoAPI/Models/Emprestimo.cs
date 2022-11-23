using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsignadoAPI.Models
{
    public class Emprestimo : IValidatableObject
    {
        public int Id { get; set; }
        public int TipoCredito { get; set; }
        public double ValorCredito { get; set; }

        [Range(5, 72, ErrorMessage = "A quantidade de parcela minima é 5x e a máxima é 72x")]
        public int QuantidadeParcelas { get; set; }
        public DateTime DataPrimeiroVencimento{ get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(this.TipoCredito == 3 && this.ValorCredito > 15000)
            {
                yield return new ValidationResult("O valor do crédito maximo permitido para Credito Pessoa Juridica é de 15.000,00");
            }
            if (ValorCredito > 1000000)
            {
                yield return new ValidationResult("O valor do crédito maximo permitido é de 1.000.000,00");
            }
            //if (this.QuantidadeParcelas < 5 || this.QuantidadeParcelas > 72)
            //{
            //    yield return new ValidationResult("A quantidade mínima de parcelas é de 5x e a máxima é de 72x");
            //}
        }
    }
}
