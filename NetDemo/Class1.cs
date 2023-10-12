using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetDemo
{
    public class Class1
    {
        //public string[] split;
        //public string[] split { get; set; }

        private string[] split;

        // ...

        public void SetSplitValue(string[] values)
        {
            split = values;
        }

        public string[] GetSplitValue()
        {
            return split;
        }
    }

}
