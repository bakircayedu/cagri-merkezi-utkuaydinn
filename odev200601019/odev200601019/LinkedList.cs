using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev200601019
{
    internal class LinkedList<T> :ADT<T>
    {
        public override List<T> DisplayElements()
        {


            var temp=Head;

            List<T> list=new List<T>();

            temp=Head;



            if ( temp==null )
            {
                return list;
            }


            else
            {

                while (temp.Next!=null)
                {

                    list.Add(temp.Value);

                    temp = temp.Next;

                }

                list.Add(temp.Value);

                return list;

            }
        }
        



        public override void Delete(T value)
        {
            


            if ( value==null ) throw new ArgumentNullException();

            
            if ( Head==null ) throw new Exception("veri yok..");


            var current=Head.Next;


            var temp=Head;




            if ( Head.Value.Equals(value) )
            {

                Head=current;


                return;


            }


            while( current!=null )
            {
                if ( current.Value.Equals(value) )
                {


                    temp.Next = current.Next;


                    return;
                }

                current=current.Next;


                temp=temp.Next;


            }


        }


        public override void Insert(T value)
        {
            var current = Head;


            Node<T> newNode = new(value);


            if (Head == null)
            {

                Head = newNode;

                Size++;



                return;
            }



            while (current.Next != null)
            {


                current = current.Next;


            }

            current.Next = newNode;


            Size++;
        }


        
    }
}
