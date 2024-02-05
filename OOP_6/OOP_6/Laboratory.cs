﻿using OOP_6;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    internal partial class Laboratory
    {
        public List<Product> arr;
       public int Size
        {
            get => Count;
        }
       protected int Count = 0;

       public Laboratory()
        {
            arr=new List<Product>();
        }

        public void Add(Product A)
        {
            if (A == null)
            {
                throw new NullPtr();
            }
            arr.Add(A);
            Count++;
        }

        public void Remove(Product A)
        {
            arr.Remove(A);
            Count--;
        }
    }
}
