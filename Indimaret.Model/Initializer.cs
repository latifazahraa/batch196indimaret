using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Model
{
    public class Initializer: DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {   
            List<BarangModel> barangModel = new List<BarangModel>();
            barangModel.Add(new BarangModel { TokoID = 1, KodeBarang = "K001", AsalPabrik = "Jember", JmlBarang = 35, NamaBarang = "Pepsodent", LamaKadaluarsa = 34 });
            barangModel.Add(new BarangModel { TokoID = 2, KodeBarang = "K002", AsalPabrik = "Wonosari", JmlBarang = 20, NamaBarang = "Sunsilk", LamaKadaluarsa = 71 });
            barangModel.Add(new BarangModel { TokoID = 1, KodeBarang = "K003", AsalPabrik = "Jember", JmlBarang = 42, NamaBarang = "Marina", LamaKadaluarsa = 58 });
            barangModel.Add(new BarangModel { TokoID = 3, KodeBarang = "K004", AsalPabrik = "Bandung", JmlBarang = 28, NamaBarang = "Clean & Clear", LamaKadaluarsa = 30 });

            base.Seed(context);
            foreach (BarangModel item in barangModel)
            {
                context.BarangModel.Add(item);
            }
        }
    }
}
