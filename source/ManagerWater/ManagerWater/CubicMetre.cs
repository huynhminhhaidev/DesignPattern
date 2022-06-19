using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ManagerWater
{

    public class CubicMetre
    {
        //CubicMetre SQL
        private CubicMetreSql cubicMetreSql = new CubicMetreSql();


        //So m3 nuoc da su dung
        public int CubicMetre_ID;
        public float CubicMetre_count;

        //Ham get set
        public int cubicmetre_id { get; set; }
        public float cubicmetre_count { get; set; }
        
        public CubicMetre() { }

        public CubicMetre(int Customer_ID)
        {
            this.CubicMetre_ID = Customer_ID;
        }

        public CubicMetre(int Customer_ID, float CubicMetre_count)
        {
            this.CubicMetre_ID = Customer_ID;
            this.CubicMetre_count = CubicMetre_count;
        }


        //Phan xu ly SQL
        public DataTable getCubicMetre()
        {
            return cubicMetreSql.getCubicMetre();
        }

        public bool addCubicMetre(CubicMetre cubicMetre)
        {
            return cubicMetreSql.addCubicMetre(cubicMetre);
        }

        public bool deleteCubicMetre(int cubicMetre_id)
        {
            return cubicMetreSql.deleteCubicMetre(cubicMetre_id);
        }

        public CubicMetre findCubicMetre(int id)
        {
            return cubicMetreSql.findCubicMetre(id);
        }
    }
}
