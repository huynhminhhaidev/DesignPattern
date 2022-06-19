using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ManagerWater
{
    class CubicMetreSql: SqlConnect
    {
        public DataTable getCubicMetre()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM CubicMetre", conn);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public bool addCubicMetre(CubicMetre cubicMetre)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO CubicMetre(cubicmetre_count) VALUES ('" + cubicMetre.CubicMetre_count + "')", conn);

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

        public bool deleteCubicMetre(int cubicMetre_id)
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE CubicMetre WHERE cubicmetre_id = '" + cubicMetre_id + "'", conn);

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

        public CubicMetre findCubicMetre(int id)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CubicMetre WHERE cubicmetre_id = '"+ id +"'", conn);
                SqlDataReader r = cmd.ExecuteReader();

                if (r.HasRows)
                {
                    r.Read();
                    return new CubicMetre(int.Parse(r[0].ToString()), float.Parse(r[1].ToString()));
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
    }
}
