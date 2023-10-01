using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public  interface  IMyCloneable <T> where T : class
    {
        public T MyClone();
        
        
    }
}
