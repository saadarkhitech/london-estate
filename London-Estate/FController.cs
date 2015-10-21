using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace London_Estate
{
    class FController

    {
        private static FController controoler = new FController();

        private FController()
        { }

        public static FController getController()
        {
            return controoler;
        }

        private DController dbC = new DController();
       
        public int addPlaza(string name, int floors, int shops, int flats, string add, string loc,bool flag,int[] s_f)
        {
            dbC.addPlaza(name,floors,shops,flats,add,loc,flag,s_f);
            return 0;

        }

        public int addShop(string sId, string fid, int owner_id, int rental_id, int agrmnt_id)
        {
            dbC.addShop(sId, fid);
            return 0; 
        }

        public int addFlat(string ftId, string f_id, int owner_id, int rental_id, int agrmnt_id)
        {
            dbC.addFlat(ftId, f_id);
            return 0;
        }

        public int addOwner(string name, string cnic, DateTime dob, string contact, string bankName, string accNo)
        {
            return dbC.addOwner(name, cnic, dob, contact, bankName, accNo);
            
        }

        public int addRental(string name, string cnic, DateTime dob, int contact)
        {
            dbC.addrental(name, cnic, dob, contact);
            return 0;
        }

        public SqlDataReader getShopsOfFloor(string florId)
        {
            return dbC.getShopsOfFloor(florId);
        }

        public SqlDataReader getFlatsOfFloor(string florId)
        {
            return dbC.getFlatsOfFloor(florId);

        }


        public SqlDataReader getFloorsPlaza(int plazaId)
        {
            return dbC.getFloorsPlaza(plazaId);
        }

        public SqlDataReader getAllPlazaIds()
        {
            return dbC.getAllPlazaIds();
        }

        public bool diffRentiateFlatShop(string id)
        {// if shop then returns true, for flat it returns false

            SqlDataReader rdr1 = dbC.searchShop(id);
            SqlDataReader rdr2 = dbC.searchFlat(id);

            if (rdr1.HasRows)
                return true;
            else
                return false;
        }

        public int addOwnerOfShop(string sid, int oid)
        {
            return dbC.addOnwerOfShop(sid, oid);
        }


        public int addOwnerOfFlat(string ftid, int oid)
        {
            return dbC.addOnwerOfFlat(ftid, oid);
        }
    }

}
