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

        public int addPlaza(string name, int floors, int shops, int flats, string add, string loc,bool flag,int[] s_f)
        {
            string q = "Insert into Plaza(p_name,no_floors,no_shops,no_flats,addr,loc) values (@n,@fl,@sh,@ft,@addr,@loc); Select SCOPE_IDENTITY() ";
            SqlConnection conn = this.conect();
            conn.Open();
            SqlCommand sql = new SqlCommand(q, conn);
            sql.Parameters.Add("@n", name);
            sql.Parameters.Add("@fl", floors);
            sql.Parameters.Add("@sh", shops);
            sql.Parameters.Add("@ft", flats);
            sql.Parameters.Add("@addr", add);
            sql.Parameters.Add("@loc", loc);
            
             int pid = int.Parse( sql.ExecuteScalar().ToString());
             for (int i = 0; i < floors; i++)
             {
                 int a = i + 1;
                 addFloor(pid + "_F"+ a +"", i+"", pid,s_f[i],flag);
             }
             
            return 0;
        }


        public int addFloor(string fId, string fpos, int f_parent,int count,bool flag)
        {
            string q = "Insert into Floor(f_id,f_pos,f_parent) values (@fid,@fpos,@fparnt);";
            SqlConnection conn = this.conect();
            conn.Open();
            SqlCommand sql = new SqlCommand(q, conn);
            sql.Parameters.Add("@fid", fId);
            sql.Parameters.Add("@fpos", fpos);
            sql.Parameters.Add("@fparnt", f_parent);

            // string fid = sql.ExecuteScalar().ToString();
            sql.ExecuteNonQuery();
             if (flag == true && int.Parse(fpos) < 2)
             {
                 // insert shops
                 for(int i=0; i <count; i++)
                 {
                    addShop(fId+"_S"+i+"",fId );
                 }
             }
             else if (flag == false && int.Parse(fpos) < 1)
             {
                 // insert shop
                 for (int i = 0; i < count; i++)
                 {
                     addShop(fId + "_S" + i + "", fId);
                 }
             }
             else
             { 
                //insert flat
                 for (int i = 0; i < count; i++)
                 {
                     addFlat(fId + "_Ft" + i + "", fId);
                 }
             }
            return 0;
        }

        public int addShop(string sId, string fid)
        {
            string q = "Insert into Shop(s_id,f_id) values (@sid,@fid);";
            SqlConnection conn = this.conect();
            conn.Open();
            SqlCommand sql = new SqlCommand(q, conn);
            sql.Parameters.Add("@sid", sId);
            sql.Parameters.Add("@fid", fid);
            //sql.Parameters.Add("@oid", owner_id);
            //sql.Parameters.Add("@rid", rental_id);
            //sql.Parameters.Add("@agid", agrmnt_id);

            sql.ExecuteNonQuery();
            return 0;
        }

        public int addFlat(string ftId, string f_id)
        {
            string q = "Insert into Flat(ft_id,f_id) values (@ftid,@fid);";
            SqlConnection conn = this.conect();
            conn.Open();
            SqlCommand sql = new SqlCommand(q, conn);
            sql.Parameters.Add("@ftid", ftId);
            sql.Parameters.Add("@fid", f_id);
            //sql.Parameters.Add("@oid", owner_id);
            //sql.Parameters.Add("@rid", rental_id);
            //sql.Parameters.Add("@agid", agrmnt_id);

            sql.ExecuteNonQuery();
            return 0;
        }

        public int addOwner(string name, string cnic, DateTime dob, int contact)
        {
            string q = "Insert into Owner(name,cnic,dob,contact) values (@oname,@ocnic,@odob,@ocontact)";
            SqlConnection conn = this.conect();
            conn.Open();
            SqlCommand sql = new SqlCommand(q, conn);
            sql.Parameters.Add("@oname", name);
            sql.Parameters.Add("@ocnic", cnic);
            sql.Parameters.Add("@odob", dob);
            sql.Parameters.Add("@ocontct", contact);
 

            sql.ExecuteNonQuery();
            return 0;
        }

        public int addrental(string name, string cnic, DateTime dob, int contact)
        {
            string q = "Insert into Rental(name,cnic,dob,contact) values (@oname,@ocnic,@odob,@ocontact)";
            SqlConnection conn = this.conect();
            conn.Open();
            SqlCommand sql = new SqlCommand(q, conn);
            sql.Parameters.Add("@oname", name);
            sql.Parameters.Add("@ocnic", cnic);
            sql.Parameters.Add("@odob", dob);
            sql.Parameters.Add("@ocontct", contact);


            sql.ExecuteNonQuery();
            return 0;
        }

        public int addAgremnt(string prptyp, DateTime strtDate, DateTime endDate, int agrPrd, float rentIncPerMont, float RentMonthly, float secAmt)
        {
            string q = "Insert into Adreement(prp_typ,agr_startDate,agr_endDate,agr_period,Rent_incrs_per,rent_monthly,sec_amnt) values (@prpTyp,@strtDate,@endDate,@agr_per,@rentIncr,@rentMon,@secAmt)";
            SqlConnection conn = this.conect();
            conn.Open();
            SqlCommand sql = new SqlCommand(q, conn);
            sql.Parameters.Add("@prp_typ", prptyp);
            sql.Parameters.Add("@agr_startDate", strtDate);
            sql.Parameters.Add("@agr_endDate", endDate);
            sql.Parameters.Add("@agr_period", agrPrd);
            sql.Parameters.Add("@Rent_incrs_per", rentIncPerMont);
            sql.Parameters.Add("@rent_monthly", RentMonthly);
            sql.Parameters.Add("@sec_amnt", secAmt);
            return 0;
        }
    }

}
