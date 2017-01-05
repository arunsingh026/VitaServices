using System.Collections.Generic;
using System.Linq;
using LEGO.CORE;
using LEGO.FDAL.DBContext;
using System;
using System.Linq.Expressions;
using LEGO.ENTITY;
using System.Text.RegularExpressions;

namespace LEGO.FDAL.Repository
{
    public class DBRepository : IUserManagementRepository
    {

       

        public IList<T> GetAll<T>() where T : class, IIdentifierObject
        {
            using (var contxt = new DBContxt())
            {
                return contxt.Set<T>().ToList<T>();
            }
        }

        public IList<T> GetAll<T>(Expression<Func<T, bool>> expression) where T : class, IIdentifierObject
        {
            using (var contxt = new DBContxt())
            {
                var returnData = contxt.Set<T>().Where(expression).ToList<T>();
                return returnData;
            }
            
        }

        //public IList<IIdentifierObject> GetAll(Type type)
        //{
        //    using (var contxt = new DBContxt())
        //    {
        //        return contxt.Set(type).List<IIdentifierObject>();
                
        //    }
        
        //}

        public T Get<T>(Guid id) where T : class, IIdentifierObject
        {
            using (var contxt = new DBContxt())
            {
                return contxt.Set<T>().Where(x => x.Id == id).FirstOrDefault();

            }
          
        }

        public T Save<T>(T t) where T : class, IIdentifierObject
        {
            using (var contxt = new DBContxt())
            {
                using (var tran = contxt.Database.BeginTransaction())
                {
                    try
                    {
                        contxt.Set<T>().Add(t);
                        //saves all above operations within one transaction
                        contxt.SaveChanges();
                        //commit transaction
                        tran.Commit();
                    }
                    catch(Exception)
                    {
                        //Rollback transaction if exception occurs
                        tran.Rollback();
                    }
                }
                return t;
            }
          
        }

        public IList<T> Save<T>(IList<T> t) where T : class, IIdentifierObject
        {
            using (var contxt = new DBContxt())
            {
                using (var tran = contxt.Database.BeginTransaction())
                {
                    try
                    {
                       
                        foreach (var persistant in t)
                        {
                            contxt.Set<T>().Attach(persistant);
                            //saves all above operations within one transaction
                            contxt.SaveChanges();
                        }
                        //commit transaction
                        tran.Commit();
                    }
                    catch(Exception)
                    {
                        //Rollback transaction if exception occurs
                        tran.Rollback();
                    }
                }

                return t;
            }
          
        }

        public T Update<T>(T t) where T : class, IIdentifierObject
        {
            using (var contxt = new DBContxt())
            {
                using (var tran = contxt.Database.BeginTransaction())
                {
                    try
                    {
                        contxt.Entry<T>(t).State = System.Data.Entity.EntityState.Modified;
                        contxt.SaveChanges();
                        tran.Commit();
                    }
                    catch(Exception)
                    {
                        tran.Rollback();
                    }
                }
                return t;
            }
           
        }

        public bool Delete<T>(T t) where T : class, IIdentifierObject
        {
            using (var contxt = new DBContxt())
            {
                using (var tran = contxt.Database.BeginTransaction())
                {
                    try
                    {
                        contxt.Set<T>().Remove(t);
                        contxt.SaveChanges();
                        //commit transaction
                        tran.Commit();
                    }
                    catch(Exception)
                    {
                        //Rollback transaction if exception occurs
                        tran.Rollback();
                    }
                }
                return true;
            }
           
        }

        public bool ValidateUser(string useremail, string password)
        {

            using (var contxt = new DBContxt())
            {
                try
                {
                    var userList = contxt.Set<CoreUser>().Where(x => x.CoreEmail == useremail && x.CorePassword == password).ToList();

                    if (userList == null || userList.Count == 0)
                        return false;
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public bool ValidateOnlyUser(string useremail)
        {
            return true;
        }

        public bool ActiaveUser(string useremail)
        {
            return true;
        }





    }
}
