using System.ComponentModel.DataAnnotations;

namespace TestApi3K.Model
{
    public class Skins
    {
        [Key]
        public int id_Skin { get; set; }
        public string Name { get; set; }
    }
}
