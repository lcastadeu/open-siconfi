using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSiconfi.Domain.Entities
{   
    [Table("complemento_fonte_recurso")]
    public partial class ComplementoFonteRecurso : AbstractModel
    {
        [
            Column("codigo"),
            Display(Name = "Código"),
            RegularExpression(@"[0-9]"),
            Required(AllowEmptyStrings = false, ErrorMessage = "Campo Obrigatório"),
            StringLength(4, ErrorMessage = "O Campo {0} deve ter {1} caracter!")
        ]
        public int Codigo{ get; set; }

        [
            Column("nomenclatura"),
            Display(Name = "Nomenclatura"),
            Required(AllowEmptyStrings = false, ErrorMessage = "Campo Obrigatório"),
            StringLength(500, ErrorMessage = "O Campo {0} deve ter {1} caractres!")
        ]
        public string Nomenclatura { get; set; }

        [
            Column("especificacao"),
            Display(Name = "Especificação"),
            StringLength(1000, ErrorMessage = "O Campo {0} deve ter {1} caractres!")
        ]
        public string Especificacao { get; set; }
    }
}
