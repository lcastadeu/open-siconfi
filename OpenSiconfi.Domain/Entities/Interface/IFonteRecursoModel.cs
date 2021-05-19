namespace OpenSiconfi.Domain.Entities.Interface
{
	public partial interface IFonteRecursoModel : IAbstractModel
	{
		string CodigoPrincipal { get; set; }
		string Detalhamento { get; set; }
		string Nome { get; set; }
		string Especificacao { get; set; }
	}
}