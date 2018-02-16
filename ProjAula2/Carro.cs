using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjAula2
{
    class Carro
    {

        #region propriedades

        public int Id { get; set; }
        public string Nome { get; set; }
        public String Cor { get; set; }

        #endregion propriedades

        #region metodos

        public string Imprimir()
        {


            return "Id: " + this.Id + "\nNome: " + this.Nome +
                "\nCor: " + this.Cor
                ;
        }

        #endregion metodos

    }
}
