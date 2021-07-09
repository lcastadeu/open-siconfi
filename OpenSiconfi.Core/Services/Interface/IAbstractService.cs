using System;
using System.Collections.Generic;
using OpenSiconfi.Domain.Dto;

namespace OpenSiconfi.Core.Services.Interface
{
  public interface IAbstractService
  {
    Type ServiceType { get; set; }
    List<PropsDto> GetEntityProperties();
  }
}