﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev200601019
{
    public class Node<T>
    {
        public Node(T value)
        {

            Value = value;


        }


        public Node<T> Next { get; set; }



        public T Value { get; set; }
        



        
    }
}
