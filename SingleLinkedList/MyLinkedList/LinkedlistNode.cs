using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
  public  class MyLinkedlistNode<T> 
    {
        public T Data { get; internal set; }
        public MyLinkedlistNode<T> Next
        {
            get;
            internal  set;
        }
        public MyLinkedlistNode(T data)
        {
            this.Data = data;
            
        }

        
    }
}
