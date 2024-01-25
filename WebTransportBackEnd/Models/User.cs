namespace WebTransportBackEnd.Models
{
    public class User
    {    
        public int id { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public bool active { get; set; }
    }
}
