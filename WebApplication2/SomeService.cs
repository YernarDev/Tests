using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class SomeService
    {
        public bool SomeMethod(int num)
        {
            return num > 10 ? true : false;
        }

        public void SomeMethod1()
        {
            throw new ArgumentNullException();
        }

        public async Task SomeMethod2()
        {
            throw new ArgumentNullException();
        }
    }
}
