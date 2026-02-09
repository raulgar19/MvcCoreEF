using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcCoreEF.Models
{

    [Table("HOSPITAL")]
    public class Hospital
    {
        [Key]
        [Column("HOSPITAL_COD")]
        public int HospitalId { get;set; }

        [Column("HOSPITAL_COD")]
        public string Nombre { get;set; }

        [Column("NOMBRE")]
        public string Direccion { get;set; }

        [Column("TELEFONO")]
        public string Telefono { get;set; }

        [Column("NUM_CAMAS")]
        public int Camas { get;set; }
    }
}