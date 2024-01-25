using System.ComponentModel.DataAnnotations.Schema;

namespace WebTransportBackEnd.Models
{
    public class Driver
    {
        [Column(TypeName = "INT")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string ssn { get; set; }
        public DateTime dob { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public long phone { get; set; }
        public bool active { get; set; }
    }
}
