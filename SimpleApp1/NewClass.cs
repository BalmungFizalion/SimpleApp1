using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp1
{
    public class NewClass
    {
        public string Name 
        { 
            get;
            set; 
        }

        public void SetName(string name) 
        {
            Name = name;
        }

        public void DoSomething()
        {
            //здесь что-то происходит
        }

    }
}
