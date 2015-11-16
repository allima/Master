using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormHome.model
{
    class Aluguel
    {

        private int id;
        private Corretor corretor;
        private Imovel imovel;
        private Inquilino inquilino;

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

        internal Corretor Corretor
        {
            get
            {
                return corretor;
            }

            set
            {
                corretor = value;
            }
        }

        internal Imovel Imovel
        {
            get
            {
                return imovel;
            }

            set
            {
                imovel = value;
            }
        }

        internal Inquilino Inquilino
        {
            get
            {
                return inquilino;
            }

            set
            {
                inquilino = value;
            }
        }
    }
}
