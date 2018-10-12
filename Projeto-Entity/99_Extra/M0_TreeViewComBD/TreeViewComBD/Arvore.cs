using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeViewComBD
{
    public class Arvore<T>
    {
        private List<T> lista;

        public T root;

        public Arvore<T> Filhos;

        public Arvore()
        {
            lista = new List<T>();
        }
    }
}
