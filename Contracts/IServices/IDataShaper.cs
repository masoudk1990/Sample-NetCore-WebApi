using System.Collections.Generic;
using System.Dynamic;

namespace Contracts.IServices
{
    public interface IDataShaper<T>
    {
        IEnumerable<ExpandoObject> ShapeData(IEnumerable<T> entities, string fieldString);
        ExpandoObject ShapeData(T entity, string fieldsString);
    }
}
