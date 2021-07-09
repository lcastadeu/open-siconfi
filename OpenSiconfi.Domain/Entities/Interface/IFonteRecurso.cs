namespace OpenSiconfi.Domain.Entities.Interface
{
	public partial interface IFonteRecurso : IAbstractModel
	{
		string CodigoExercicioCorrente {get;}
    string CodigoExercicioAnterior { get; }
		string CodigoPrincipal { get; set; }
		string Detalhamento { get; set; }
		string Nome { get; set; }
		string Especificacao { get; set; }
	}
}