using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade17
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QuantidadeEmEstoque { get; set; }

        public double CalcularValorTotalEmEstoque()
        {
            return Preco * QuantidadeEmEstoque;
        }
    }

}
