// File:    ManagerService.cs
// Author:  Filip Zukovic
// Created: Wednesday, April 1, 2020 9:43:21 PM
// Purpose: Definition of Class ManagerService

using System;

namespace Service
{
   public class ManagerService
   {
      public Doctor RegisterDoctor(Model.Users.Doctor doctor)
      {
         throw new NotImplementedException();
      }
      
      public Report GenerateReport()
      {
         throw new NotImplementedException();
      }
      
      public Model.BusinessHours.BusinessHours GiveDoctorHours(Doctor doctor)
      {
         throw new NotImplementedException();
      }
      
      public Repository.IUserRepositoryFacotory iUserRepositoryFacotory;
   
   }
}