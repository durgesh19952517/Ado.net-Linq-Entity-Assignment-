using System;
using System.Data.SqlClient;
using System.Data;



namespace ADO_BusInfo
{
    class BusInfoProg
    {
        static void Main(string[] args)
        {
            BusInfoProg.Connection();
            Console.ReadLine();
        }
        public static void Connection()
        {
            string cs = "Data source=Durgesh;Initial Catalog=League;Integrated security=True";
            SqlConnection conn = new SqlConnection(cs);
            string query = "SELECT BusID,BoardingPoint FROM BusInfo WHERE TravelDate='2017-12-10' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            { 
                Console.WriteLine("BUS ID = " + dr["BusID"] +"Boarding Point = " +dr["BoardingPoint"]);
            }
            conn.Close();
            
        }
    }
}
