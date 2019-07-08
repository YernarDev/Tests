using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class AnotherService
    {
        List<int> Col;
        public AnotherService(List<int> _col)
        {
            Col = _col;
        }

        public int SomeMethod()
        {
            return Col.Last();
        }
    }
}
