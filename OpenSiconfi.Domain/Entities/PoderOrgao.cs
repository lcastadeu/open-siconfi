using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OpenSiconfi.Infrastructure;

namespace OpenSiconfi.Domain.Entities
{
  public partial class PoderOrgao : AbstractModel
  {
    [
        Column("codigo"),
        Display(Name = "Código"),
        OSProps(true)
    ]
    public int Codigo { get; set; }

    [
        Column("nomenclatura"),
        Display(Name = "Nomenclatura"),
        Required(AllowEmptyStrings = false, ErrorMessage = "Campo Obrigatório")
    ]
    public string Nomenclatura { get; set; }
  }
}