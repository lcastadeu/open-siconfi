namespace OpenSiconfi.Domain.Entities.Interface
{
  public partial interface IInformacaoComplementar : IAbstractModel
  {
    string CodigoIC { get; set; }
    string Nome { get; set; }
    int Digito { get; set; }
    string Formato { get; }
    string Descricao { get; set; }
    string Finalidade { get; set; }
  }
}