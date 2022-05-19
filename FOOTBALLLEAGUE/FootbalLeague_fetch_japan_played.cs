using System;
using System.Data.SqlClient;
using System.Data;



namespace ADO_Footballleague
{
    class FootbalLeague
    {
        static void Main(string[] args)
        {
            FootbalLeague.Connection();
            Console.ReadLine();
        }
        public static void Connection()
        {
            string cs = "Data source=Durgesh;Initial Catalog=League;Integrated security=True";
            SqlConnection conn = new SqlConnection(cs);
            string query = "SELECT * FROM FootBallLeague WHERE TeamName1='Japan' OR TeamName2='Japan' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            { 
                Console.WriteLine("TeamName1 = " +dr["TeamName1"] 
                                + "   TeamName2 = " +dr["TeamName2"]
                                + "   MatchStatus = " + dr["MatchStatus"]
                                + "   Winning Team = " + dr["WinningTeam"]
                                + "   Points = " + dr["Points"]);
            }
            conn.Close();
            
        }
    }
}
