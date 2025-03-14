using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApi3K.Model
{
    public class Skins_Users
    {
        [Key]
        public int id_Skin_User { get; set; }

        [Required]
        [ForeignKey("Users")]
        public int id_User { get; set; }

        [Required]
        [ForeignKey("Skins")]
        public int id_Skin { get; set; }
    }
}
