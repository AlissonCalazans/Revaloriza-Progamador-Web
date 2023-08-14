using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DesafioReval.Models
{
    [Table("Cliente")]
    public class ClienteModel
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Razão Social")]
        [Display(Name = "Razão Social")]
        public string razaosocial { get; set; }

        [Column("Nome Fantasia")]
        [Display(Name = "Nome Fantasia")]
        public string nomefantasia { get; set; }

        [Required]
        [Column("CNPJ")]
        [Display(Name = "CNPJ")]
        [Cnpj]
        public string cnpj { get; set; }

        [Column("Inscrição Estadual")]
        [Display(Name = "Inscrição Estadual")]
        public string inscrisaoe { get; set; }

        [Column("Nome Responsável")]
        [Display(Name = "Nome Responsável")]
        public string nomeresp { get; set; }

        [Required]
        [Column("Email")]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Column("Telefone")]
        [Display(Name = "Telefone")]
        public int telefone { get; set; }

        [Column("CEP")]
        [Display(Name = "CEP")]
        public int cep { get; set; }

        [Column("Cidade")]
        [Display(Name = "Cidade")]
        public string cidade { get; set; }

        [Column("Estado")]
        [Display(Name = "Estado")]
        public string estado { get; set; }
    }
}
