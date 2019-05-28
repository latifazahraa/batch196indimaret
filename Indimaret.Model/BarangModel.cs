using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indimaret.Model
{
    [Table("IndimaretTable")]
    public class BarangModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ID { get; set; }
        [Required(AllowEmptyStrings = false)]

        public int TokoID { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]

        public string KodeBarang { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]

        public string NamaBarang { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]

        public string AsalPabrik { get; set; }
        [Required(AllowEmptyStrings = false)]

        public int JmlBarang { get; set; }
        [Required(AllowEmptyStrings = false)]

        public int LamaKadaluarsa { get; set; }

    }
}
