using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormHome
{
    class Imovel
    {
        private int id;
        private string decricao;

        public int Id
        {
            get

            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Decricao
        {
            get
            {
                return decricao;
            }

            set
            {
                decricao = value;
            }
        }
    }
}
