using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Drug
    {
        public Drug(string _drugName, int _drugCount)
        {
            DrugName = _drugName;
            DrugCount = _drugCount;
        }
        public string DrugName { get; set; }
        public int DrugCount { get; set; }
    }
}
