using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenSiconfi.Domain.Entities
{
    [Table("informacao_complementar")]
    public partial class InformacaoComplementar : AbstractModel
    {   
        [
            Column("codigo_ic"), 
            Display(Name = "Código IC"), 
            Required(AllowEmptyStrings = false, ErrorMessage = "Campo {0} é de preenchimento obrigatório"), 
            StringLength(2, ErrorMessage = "O Campo {0} deve ter {1} caractres!")
        ]
        public string CodigoIC{get;set;}

        [
            Column("nome"), 
            Display(Name = "Nome")
        ]
        public string Nome { get; set; }
        
        [
            Column("digito"), 
            Display(Name = "Dígito")
        ]
        public int Digito { get; set; }
        
        [
            NotMapped, 
            Display(Name = "Formato")
        ]
        public string Formato { 
            get {
                return "x".PadLeft(Digito, 'x');
            }
        }
        
        [
            Column("descricao"), 
            Display(Name = "Descrição")
        ]
        public string Descricao { get; set; }
        
        [
            Column("finalidade"), 
            Display(Name = "Finalidade")
        ]
        public string Finalidade { get; set; }
    }
}