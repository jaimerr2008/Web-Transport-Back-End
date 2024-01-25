using System.ComponentModel.DataAnnotations.Schema;

namespace WebTransportBackEnd.Models
{
    public class Route
    {
        [Column(TypeName = "INT")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string description { get; set; }
        public int driver_id { get; set; }
        public int vehicle_id { get; set; }
        public bool active { get; set; }
    }
}
