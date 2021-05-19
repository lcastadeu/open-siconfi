using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OpenSiconfi.Domain.Entities.Interface;
using OpenSiconfi.Infrastructure;

namespace OpenSiconfi.Domain.Entities
{
    [Table("fonte_recurso")]
    public partial class FonteRecursoModel : AbstractModel, IFonteRecursoModel
    {   
        [
            Column("codigo_principal"), 
            Display(Name = "Código Principal"), 
            RegularExpression(@"[0-9]"),
            Required(AllowEmptyStrings = false, ErrorMessage = "Campo Obrigatório"), 
            StringLength(4, ErrorMessage = "O Campo {0} deve ter {1} caracter!"),
            OSProps(true)
        ]
        public string CodigoPrincipal { get; set; }
        
        [
            Column("detalhamento"), 
            Display(Name = "Detalhamento"), 
            Required(AllowEmptyStrings = false, ErrorMessage = "Campo Obrigatório"),
            OSProps(true)
        ]
        public string Detalhamento { get; set; }
        
        [
            Column("nome"), 
            Display(Name = "Nome"),
            OSProps(true)
        ]
        public string Nome { get; set; }
        
        [
            Column("especificacao"), 
            Display(Name = "Especificação"),
            OSProps(true)
        ]
        public string Especificacao { get; set; }
    }
}