using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using OpenSiconfi.Infrastructure;

namespace OpenSiconfi.Domain.Entities
{
    public class AbstractModel
    {   
        [
            JsonIgnore,
            Column("id", Order = 1), 
            Display(Name = "Código Interno"), 
            DatabaseGenerated(DatabaseGeneratedOption.Identity),
            OSProps(true)
        ]
        public int Id { get; set; }

        [
            JsonIgnore,
            Column("exercicio", Order = 2), 
            Display(Name = "Exercicio"),
            OSProps(false)
        ]
        public int Exercicio { get; set; }
    }
}