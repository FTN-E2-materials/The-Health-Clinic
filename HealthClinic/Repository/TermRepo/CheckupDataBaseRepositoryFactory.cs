// File:    CheckupDataBaseRepositoryFactory.cs
// Author:  Vaxi
// Created: Friday, May 29, 2020 5:40:45 PM
// Purpose: Definition of Class CheckupDataBaseRepositoryFactory

using System;

namespace Repository.TermRepo
{
    public class CheckupDataBaseRepositoryFactory : ITermRepositoryFactory
    {
        public OperationRepository CreateoperationRepository()
        {
            throw new NotImplementedException();
        }
    }
}