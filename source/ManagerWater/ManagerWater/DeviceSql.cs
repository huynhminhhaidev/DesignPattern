using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace ManagerWater
{
    class DeviceSql: SqlConnect
    {
        public CubicMetre findCubicMetre1(int id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CubicMetre WHERE cubicmetre_id = '"+ id +"'", conn);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Read();
                    return new CubicMetre(int.Parse(sqlDataReader[0].ToString()), float.Parse(sqlDataReader[1].ToString()));
                }
                else
                {
                    return new CubicMetre();
                }
            }
            finally
            {
                conn.Close();
            }
            return new CubicMetre();
        }

        public bool addCubicMetreUsed(CubicMetre cubicMetre)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CubicMetre SET cubicmetre_count = '"+ cubicMetre.CubicMetre_count +"' WHERE cubicmetre_id = '"+ cubicMetre.CubicMetre_ID +"'" ,conn);
                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
