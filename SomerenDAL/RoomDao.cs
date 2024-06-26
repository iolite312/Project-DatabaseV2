﻿using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using SomerenModel;


namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT id, KamerNummer, Verdieping FROM Kamer";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    Id = (int)dr["id"],
                    RoomNumber = (string)dr["KamerNummer"],
                    Floor = (int)dr["Verdieping"]
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
