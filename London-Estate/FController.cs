using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace London_Estate
{
    class FController
    {
        private DController dbC = new DController();
        public int addPlaza(string name, int floors, int shops, int flats, string add, string loc)
        {
            dbC.addPlaza("abc",3 , 3, 3, "basb", "isb");
            return 0;

        }
    }

}
