using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DFleet_CRUD.Models.Dominio
{
    public class Abastecimento
    {
        [Key]
        public int AbastecimentoId { get; set; }
        
        [MaxLength(100)]
        public string? Nome { get; set; }

        [Display(Name = "Qual o Estado?")]
        [MaxLength(100)]
        public string? Estado { get; set; }

        [Display(Name = "Qual a Cidade?")]
        [MaxLength(100)]
        public string? Cidade { get; set; }

        [MaxLength(100)]
        public string? Veiculo { get; set; }

        [StringLength(100)]
        [MaxLength(100)]
        public string? Frentista { get; set; }

        [Display(Name = "Combustível Utilizado")]
        public string? CombustivelUtilizado { get; set; }

        [Display(Name = "Quantidade de Litros?")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal QuantidadeLitros { get; set; }

        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999999.999, ErrorMessage = "Digite um preço entre 1 e 999999,999")] 
        public decimal ValorLitro { get; set; }

        [Display(Name = "Tipo de Abastecimento")]
        public string? TipoAbastecimento { get; set; }

        [Display(Name = "Completou o Tanque?")]
        public string? CompletouTanque { get; set; }

        [Display(Name = "Estabelecimento")]
        public string? Estabelecimento { get; set; }

        [Display(Name = "Data Abastecimento")]
        [DataType(DataType.Date)]
        public DateTime? DataAbastecimento { get; set; }

    }


}