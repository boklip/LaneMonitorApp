using Dapper;
using LaneMonitorApp2.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaneMonitorApp2.DataAccess
{
    public static class DatabaseHelper
    {
        
        //todo replace your server name with your actual sql server name eg., localhost or ./SQLEXPRESS//
        private static string connectionString = @"Server=DESKTOP-JGPC9T9\SQLEXPRESS;Database=LaneMonitorD;User Id=lane_admin;Password=LaneMonitor@2026;Encrypt=False;TrustServerCertificate=True";

        //<sumary>
        //fetches all active lanes from database
        //</summary>

        public static List<Lane> GetActiveLanes()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string query = "Select LaneID, LaneName, Status FROM Lanes WHERE status = 'active'";
                return db.Query<Lane>(query).ToList();
            }
        }

        //<summary>
        //Fetches all Cameras assigned to a specific lane
        //</summary>
        public static List<Camera> GetCamerasForLane(int laneId)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                string query = "Select CameraID, LaneID, Position, IPAddress,Port, Username, Password FROM Cameras WHERE LaneID = @LaneID";
                return db.Query<Camera>(query, new { LaneID = laneId }).ToList();
            }

        }
        public static void LogIncident(int laneId, int incidentCode)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO AVCIncidents (LaneID, DateTime, IncidentCode) 
                        VALUES (@LaneID, @DateTime, @IncidentCode)";

                //saves to sql
                connection.Execute(query,new { laneId, DateTime = DateTime.Now, IncidentCode = incidentCode });

          
            }
        }
    }
}