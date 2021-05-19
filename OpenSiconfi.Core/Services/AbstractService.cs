using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenSiconfi.Application.Services.Interface;
using OpenSiconfi.Domain.Dto;
using OpenSiconfi.Domain.Entities.Interface;
using OpenSiconfi.Domain.Repositories.Interface;
using OpenSiconfi.Infrastructure;

namespace OpenSiconfi.Application.Services
{
  public partial class AbstractService : IAbstractService
  {
    public Type ServiceType { get; set; }
    
    public AbstractService()
    {
      
    }

    public List<PropsDto> GetEntityProperties()
    {
      if (ServiceType == null)
      {
        throw new Exception("Tipo do serviço não definido!");
      }

      List<PropsDto> properties = new();
      foreach (PropertyInfo propertyInfo in ServiceType.GetProperties())
      {
        var property = ServiceType.GetProperty(propertyInfo.Name).GetCustomAttribute(typeof(OSPropsAttribute));
        if (property != null && (property as OSPropsAttribute).isProp)
        {
          PropsDto props = new()
          {
            Property = propertyInfo.Name,
            Type = ServiceType.GetProperty(propertyInfo.Name).PropertyType.Name
          };

          var displayAttribute = ServiceType.GetProperty(propertyInfo.Name).GetCustomAttribute(typeof(DisplayAttribute));
          if (displayAttribute != null)
            props.Display = (displayAttribute as DisplayAttribute).GetName();

          var requiredAttribute = ServiceType.GetProperty(propertyInfo.Name).GetCustomAttribute(typeof(RequiredAttribute));
          props.Required = requiredAttribute != null;

          var stringLengthAttribute = ServiceType.GetProperty(propertyInfo.Name).GetCustomAttribute(typeof(StringLengthAttribute));
          if (stringLengthAttribute != null)
          {
            props.MaxLength = (stringLengthAttribute as StringLengthAttribute).MaximumLength;
            props.MinLength = (stringLengthAttribute as StringLengthAttribute).MinimumLength;
          }

          properties.Add(props);
        }
      }

      return properties;
    }

  }
}