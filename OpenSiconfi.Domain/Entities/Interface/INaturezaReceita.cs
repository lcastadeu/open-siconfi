namespace OpenSiconfi.Domain.Entities.Interface
{
  public partial interface INaturezaReceita : IAbstractModel
  {
    string C { get; set; }
    string O { get; set; }
    string E { get; set; }
    string D1 { get; set; }
    string DD2 { get; set; }
    string D3 { get; set; }
    string T { get; set; }
    string NR { get; set; }
    string Especificacao { get; set; }
    string Descriciao { get; set; }
    string NormaCorrespondente { get; set; }
    string Valorizavel { get; set; }
  }
}