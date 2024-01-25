using System.ComponentModel.DataAnnotations.Schema;

namespace WebTransportBackEnd.Models
{
    public class Vehicle
    {
        [Column(TypeName = "INT")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string description { get; set; }
        public int year { get; set; }
        public int make { get; set; }
        public int capacity { get; set; }      
        public bool active { get; set; }
    }
}
