using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev200601019
{
    public abstract class ADT<T>
    {
        public abstract List<T> DisplayElements();





        public Node<T> Head;


        public int Size = 0;



        public abstract void Delete(T value);

        public abstract void Insert(T value);

        

        
    }
}
