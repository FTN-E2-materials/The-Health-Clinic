// File:    BusinessHoursController.cs
// Author:  Vaxi
// Created: Sunday, May 3, 2020 8:58:30 PM
// Purpose: Definition of Class BusinessHoursController

using System;

namespace Controller.BusinessHoursContr
{
   public class BusinessHoursController
   {
      public int GetBusinessHours(Doctor doctor, DateTime date)
      {
         throw new NotImplementedException();
      }
      
      public DateTime GetBuisinessDate(Doctor doctor)
      {
         throw new NotImplementedException();
      }
      
      public Model.BusinessHours.BusinessHours AddBusinessHours()
      {
         throw new NotImplementedException();
      }
      
      public void DelteBusinessHours()
      {
         throw new NotImplementedException();
      }
      
      public Service.BusinessHoursServ.BusinessHoursService businessHoursService;
   
   }
}