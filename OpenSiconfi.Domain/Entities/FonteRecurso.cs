using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OpenSiconfi.Domain.Entities.Interface;
using OpenSiconfi.Infrastructure;
using static OpenSiconfi.Domain.Util.Enums;

namespace OpenSiconfi.Domain.Entities
{
  [Table("fonte_recurso")]
  public partial class FonteRecurso : AbstractModel, IFonteRecurso
  {

    [
        NotMapped,
        Display(Name = "Código Corrente"),
        OSProps(true)
    ]
    public string CodigoExercicioCorrente
    {
      get
      {
          return string.Format("{0}{1}{2}",(int) TipoFonteRecurso.ExercicioCorrente, CodigoPrincipal, Detalhamento);
      }
    }

    [
        NotMapped,
        Display(Name = "Código Anterior"),
        OSProps(true)
    ]
    public string CodigoExercicioAnterior
    {
      get
      {
        return string.Format("{0}{1}{2}", (int) TipoFonteRecurso.ExercicioAnteior, CodigoPrincipal, Detalhamento);
      }
    }


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