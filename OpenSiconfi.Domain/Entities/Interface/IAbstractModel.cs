using System;

namespace OpenSiconfi.Domain.Entities.Interface
{
    public interface IAbstractModel
    {
        int Id { get; set; }
        int Exercicio { get; set; }
    }
}