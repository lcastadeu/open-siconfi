using System;
using System.Collections.Generic;

namespace OpenSiconfi.Domain.Dto
{
    public class PropsDto
    {
        public string Property { get; set; }
        public string Display { get; set; }
        public string Type { get; set; }
        public bool Required { get; set; } = false;
        public int MaxLength { get; set; } = -1;
        public int MinLength { get; set; } = -1;
    }
}