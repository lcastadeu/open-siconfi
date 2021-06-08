using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OpenSiconfi.Infrastructure;

namespace OpenSiconfi.Domain.Entities
{
  [Table("natureza_receita")]
  public partial class NaturezaReceita : AbstractModel, INaturezaReceita
  {
    [
        Column("c"),
        Display(Name = "C"),
        RegularExpression(@"[0-9]{1}"),
        StringLength(1, ErrorMessage = "O Campo {0} deve ter {1} caracter!")
    ]
    public string C { get; set; }

    [
        Column("o"),
        Display(Name = "O"),
        RegularExpression(@"[0-9]{1}"),
        StringLength(1, ErrorMessage = "O Campo {0} deve ter {1} caracter!")
    ]
    public string O { get; set; }

    [
        Column("E"),
        Display(Name = "E"),
        RegularExpression(@"[0-9]{1}"),
        StringLength(1, ErrorMessage = "O Campo {0} deve ter {1} caracter!")
    ]
    public string E { get; set; }

    [
        Column("d1"),
        Display(Name = "D1"),
        RegularExpression(@"[0-9]{1}"),
        StringLength(1, ErrorMessage = "O Campo {0} deve ter {1} caracter!")
    ]
    public string D1 { get; set; }

    [
        Column("dd2"),
        Display(Name = "DD2"),
        RegularExpression(@"[0-9]{2}"),
        StringLength(2, ErrorMessage = "O Campo {0} deve ter {1} caracter!")
    ]
    public string DD2 { get; set; }

    [
        Column("d3"),
        Display(Name = "D3"),
        RegularExpression(@"[0-9]{1}"),
        StringLength(1, ErrorMessage = "O Campo {0} deve ter {1} caracter!")
    ]
    public string D3 { get; set; }

    [
        Column("t"),
        Display(Name = "T"),
        RegularExpression(@"[0-9]{1}"),
        StringLength(1, ErrorMessage = "O Campo {0} deve ter {1} caracter!")
    ]
    public string T { get; set; }

    [
        Column("nr"),
        Display(Name = "NR"),
        RegularExpression(@"[0-9]{9}"),
        StringLength(9, ErrorMessage = "O Campo {0} deve ter {1} caracter!"),
        OSProps(true)
    ]
    public string NR { get; set; }

    [
        Column("especificacao"),
        Display(Name = "Especificação"),
        Required(AllowEmptyStrings = false, ErrorMessage = "Campo Obrigatório")
    ]
    public string Especificacao { get; set; }

    [
        Column("detalhamento"),
        Display(Name = "Detalhamento"),
        Required(AllowEmptyStrings = false, ErrorMessage = "Campo Obrigatório")
    ]
    public string Descriciao { get; set; }

    [
        Column("norma_correspondente"),
        Display(Name = "Norma Correspondente")
    ]
    public string NormaCorrespondente { get; set; }

    [
        Column("valorizavel"),
        Display(Name = "Valorizável")
    ]
    public string Valorizavel { get; set; }
  }
}
