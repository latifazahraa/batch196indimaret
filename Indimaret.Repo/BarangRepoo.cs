using Indimaret.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Repo
{
    public class BarangRepoo
    {
        public static List<BarangModel> GetAll()
        {
            List<BarangModel> result = new List<BarangModel>();
            using (DataContext db = new DataContext())
            {
                result = db.BarangModel.ToList();
            }
            return result;
        }

        public static Boolean Createbarang(BarangModel barangModel)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    db.BarangModel.Add(barangModel);
                    db.SaveChanges();
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            return true;
        }

        public static Boolean Deletebarang(int ID)
        {
            try
            {
                BarangModel ambil;
                using (DataContext db = new DataContext())
                {
                    ambil = db.BarangModel.Where(item => item.ID == ID).First();
                    db.BarangModel.Remove(ambil);
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }


        public static BarangModel GetByID(int ID)
        {
                BarangModel ambil;
                using (DataContext db = new DataContext())
                {
                    ambil = db.BarangModel.Where(item => item.ID == ID).First();

                    return ambil;
                }
  
        }

        public static Boolean Editbarang(BarangModel barangModel)
        {
            try
            {
                using (DataContext db = new DataContext())
                {
                    db.Entry(barangModel).State = EntityState.Modified;
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
          //  return true;
        }

    }
}
