using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LEGO.CORE
{
    public interface IRepository
    {
        // define all the repository interface as generic types

        IList<T> GetAll<T>() where T : class, IIdentifierObject;
        IList<T> GetAll<T>(Expression<Func<T, bool>> expression) where T : class, IIdentifierObject;
        //IList<IIdentifierObject> GetAll(Type type);
        T Get<T>(Guid id) where T : class, IIdentifierObject;
        T Save<T>(T t) where T : class, IIdentifierObject;
        IList<T> Save<T>(IList<T> t) where T : class, IIdentifierObject;
        T Update<T>(T t) where T : class, IIdentifierObject;
        bool Delete<T>(T t) where T : class, IIdentifierObject;
    }
}
