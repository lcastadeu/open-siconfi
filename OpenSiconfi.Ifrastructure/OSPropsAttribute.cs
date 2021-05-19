using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenSiconfi.Infrastructure
{
    [AttributeUsage(AttributeTargets.Property)]
    public partial class OSPropsAttribute : Attribute
    {   
        public bool isProp;
        
        public OSPropsAttribute(bool isProp)
        {
            this.isProp = isProp;
        }
    }
}