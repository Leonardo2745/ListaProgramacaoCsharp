using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade18
{
    public class Animal
    {
        public string Nome { get; set; }

        public virtual string EmitirSom()
        {
            return "";
        }
    }
}

