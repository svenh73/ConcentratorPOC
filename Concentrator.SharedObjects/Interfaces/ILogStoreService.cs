﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concentrator.Entities;
using Concentrator.SharedObjects.Dtos;

namespace Concentrator.SharedObjects.Interfaces
{
  public interface ILogStoreService : IBaseStoreService, ICrud<LogDto>
  {

  }
}
