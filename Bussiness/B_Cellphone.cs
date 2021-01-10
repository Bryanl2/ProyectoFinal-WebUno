using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bussiness
{
    public class B_Cellphone
    {
        public static List<CellphoneEntity> CellphoneList()
        {
            using(var bd=new CellphoneContext())
            {
                return bd.Cellphones.ToList();
            }
        }

        public static void CreateCellphone(CellphoneEntity oCellphone)
        {
            using (var bd = new CellphoneContext())
            {
                bd.Cellphones.Add(oCellphone);
                bd.SaveChanges();
            }
        }

        public static  CellphoneEntity GetCellphoneById(string id)
        {
            using (var bd = new CellphoneContext())
            {
                return bd.Cellphones.FirstOrDefault
                    (c => c.Id == id);
            }
        }

        public static void UpdateCellphone(CellphoneEntity oCellphone)
        {
            using (var bd = new CellphoneContext())
            {
                bd.Cellphones.Update(oCellphone);
                bd.SaveChanges();
            }
        }

        public static void DeleteCellphone(CellphoneEntity oCellphone)
        {
            using (var bd = new CellphoneContext())
            {
                bd.Cellphones.Remove(oCellphone);
                bd.SaveChanges();
            }
        }
    }
}
