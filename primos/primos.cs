using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primos
{
    class primos
    {
        private Double valor;

        public string recebe
        {
            set
            {
                valor = Convert.ToDouble(value);
            }
        }


        public string envia
        {
            get
            {
                bool primo = true;
                for (int i = 2; i < valor; i++) ;
                {
                    if (valor % 1 == 0) primo = false;
                }
                if (primo) return "O numero " + valor + " é Primo";
                else return "O numero " + valor + " não é Primo";
            }
        }
    }   
}
