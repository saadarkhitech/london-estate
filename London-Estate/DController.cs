using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace London_Estate
{
    class DController
    {
        public SqlConnection conect()
        {
            string connString = "Data Source=localhost;Initial Catalog=RsDb;Integrated Security=True";
            SqlConnection abc = new SqlConnection(connString);
            return abc;

        
        }

        public int addPlaza(string name, int floors, int shops, int flats, string add, string loc)
        {
            string q = "Insert into Plaza(p_name,no_floors,no_shops,no_flats,addr,loc) values (@n,@fl,@sh,@ft,@addr,@loc) ";
            SqlConnection conn = this.conect();
            conn.Open();
            SqlCommand sql = new SqlCommand(q, conn);
            sql.Parameters.Add("@n", name);
            sql.Parameters.Add("@fl", floors);
            sql.Parameters.Add("@sh", shops);
            sql.Parameters.Add("@ft", flats);
            sql.Parameters.Add("@addr", add);
            sql.Parameters.Add("@loc", loc);

            sql.ExecuteNonQuery();
            return 0;
        }

    }

}
