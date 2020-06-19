// File:    SurveyResponseRepository.cs
// Author:  Vaxi
// Created: Saturday, May 2, 2020 7:05:48 PM
// Purpose: Definition of Interface SurveyResponseRepository

using System;

namespace Repository.SurveyResponseRepo
{
   public interface SurveyResponseRepository : Repository.GenericCRUD.GenericInterfaceCRUDDao<T,ID>
   {
   }
}