// File:    BlogPostFileRepository.cs
// Author:  Vaxi
// Created: Saturday, May 2, 2020 5:16:42 PM
// Purpose: Definition of Class BlogPostFileRepository

using System;

namespace Repository
{
   public class BlogPostFileRepository<BlogPost,int> : BlogPostRepository where BlogPost : T
    where int : ID
   {
      private string filePath;
      
      public Iterable<BlogPost> FindAllById(Iterable<int> ids)
      {
         throw new NotImplementedException();
      }
      
      public int Count()
      {
         throw new NotImplementedException();
      }
      
      public void Delete(BlogPost entity)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteAll()
      {
         throw new NotImplementedException();
      }
      
      public void DeleteById(int identificator)
      {
         throw new NotImplementedException();
      }
      
      public Boolean ExistsById(int id)
      {
         throw new NotImplementedException();
      }
      
      public Iterable<BlogPost> FindAll()
      {
         throw new NotImplementedException();
      }
      
      public BlogPost FindById(int id)
      {
         throw new NotImplementedException();
      }
      
      public void Save(BlogPost entity)
      {
         throw new NotImplementedException();
      }
      
      public void SaveAll(Iterable<BlogPost> entities)
      {
         throw new NotImplementedException();
      }
      
      public List<Comment> GetComments(int blogPostId)
      {
         throw new NotImplementedException();
      }
      
      public void OpenFile()
      {
         throw new NotImplementedException();
      }
      
      public void CloseFile()
      {
         throw new NotImplementedException();
      }
   
   }
}