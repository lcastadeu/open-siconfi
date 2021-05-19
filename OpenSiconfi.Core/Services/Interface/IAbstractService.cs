using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OpenSiconfi.Domain.Dto;
using OpenSiconfi.Domain.Entities.Interface;

namespace OpenSiconfi.Application.Services.Interface
{
  public partial interface IAbstractService
  {
    Type ServiceType { get; set; }
    List<PropsDto> GetEntityProperties();
  }
}