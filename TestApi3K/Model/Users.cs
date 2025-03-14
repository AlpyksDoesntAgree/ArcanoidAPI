using System.ComponentModel.DataAnnotations;

namespace TestApi3K.Model
{
    public class Users
    {
        [Key]
        public int id_User { get; set; }
        public string Name { get; set; }
        public int Coins { get; set; } = 0;
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
