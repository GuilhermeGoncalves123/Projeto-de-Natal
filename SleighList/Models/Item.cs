using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bibliotec.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        public string? Nome { get; set; }
        public float PrecoUnidade { get; set; }
        public int Quantidade { get; set; }

        [ForeignKey("UsuarioID")]
        public int? UsuarioID { get; set;}
        public Usuario? UsuarioID { get; set;}
        
    }
}


