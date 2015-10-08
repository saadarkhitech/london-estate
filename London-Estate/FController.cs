﻿using System;
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
            dbC.addPlaza(name,floors,shops,flats,add,loc);
            return 0;

        }

        public int addShop(string sId, string fid, int owner_id, int rental_id, int agrmnt_id)
        {
            dbC.addShop(sId, fid, owner_id, rental_id, agrmnt_id);
            return 0; 
        }

        public int addFlat(string ftId, string f_id, int owner_id, int rental_id, int agrmnt_id)
        {
            dbC.addFlat(ftId, f_id, owner_id, rental_id, agrmnt_id);
            return 0;
        }

        public int addOwner(string name, string cnic, DateTime dob, int contact)
        {
            dbC.addOwner(name,cnic,dob,contact);
            return 0;
        }

        public int addRental(string name, string cnic, DateTime dob, int contact)
        {
            dbC.addrental(name, cnic, dob, contact);
            return 0;
        }


    }

}
