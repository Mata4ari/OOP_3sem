using OOP_6;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_6
{
    internal class Controller
    {
       public void OrderByCost(Laboratory lab)
        {
            
            for(int i=0;i<lab.Size;i++)
            {
                for(int j=0;j<lab.Size;j++)
                {
                    if (lab.arr[j].Cost<=0)
                    {
                        throw new CantSort(j);
                    }
                    if (lab.arr[i].Cost> lab.arr[j].Cost)
                        {
                            var temp = lab.arr[i];
                            lab.arr[i] = lab.arr[j];
                            lab.arr[j] = temp;
                        }
                    
                }
            }
        }
        public void Quality(Laboratory lab)
        {
            Types types = new Types();
            foreach (var i in lab.arr)
            {
                for(int j=0;j<types.item.Length;j++)
                {
                    if (i.GetType().Name == types.item[j].name)
                    {
                        types.item[j].col++;
                    }
                }
            }
            foreach(var i in types.item)
            {
                Console.WriteLine(i.name+" "+i.col);
            }
        }
        public void CheakDate(Laboratory lab,int date)
        {
            foreach (var i in lab.arr)
            {
                
                    if(i.Explotation>date)
                    {
                        Console.WriteLine(i.ToString());
                    }
                
            }
        }
    }
    
}
