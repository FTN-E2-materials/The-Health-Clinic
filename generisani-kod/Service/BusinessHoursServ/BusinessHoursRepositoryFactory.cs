// File:    BusinessHoursRepositoryFactory.cs
// Author:  Vaxi
// Created: Friday, May 29, 2020 6:25:18 PM
// Purpose: Definition of Interface BusinessHoursRepositoryFactory

using System;

namespace Service.BusinessHoursServ
{
   public interface BusinessHoursRepositoryFactory
   {
      BusinessHoursRepository CreateBusinessHoursRepository();
   
   }
}