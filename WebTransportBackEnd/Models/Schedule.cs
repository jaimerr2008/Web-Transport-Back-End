using System.ComponentModel.DataAnnotations.Schema;

namespace WebTransportBackEnd.Models
{
    public class Schedule
    {
        [Column(TypeName = "INT")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int route_id { get; set; }
        public int week_num { get; set; }
        public DateTime from { get; set; }
        public DateTime to { get; set; }
        public bool active { get; set; }
    }
}
