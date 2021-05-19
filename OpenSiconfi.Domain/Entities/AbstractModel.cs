using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OpenSiconfi.Infrastructure;

namespace OpenSiconfi.Domain.Entities
{
    public class AbstractModel
    {   
        [
            Column("id", Order = 1), 
            Display(Name = "Código Interno"), 
            DatabaseGenerated(DatabaseGeneratedOption.Identity),
            OSProps(true)
        ]
        public Guid Id { get; set; }

        [
            Column("exercicio", Order = 2), 
            Display(Name = "Exercicio"),
            OSProps(false)
        ]
        public int Exercicio { get; set; }
    }
}