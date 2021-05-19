using System;

namespace OpenSiconfi.Domain.Entities.Interface
{
    public interface IAbstractModel
    {
        Guid Id { get; set; }
        int Exercicio { get; set; }
    }
}