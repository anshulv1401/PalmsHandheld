using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Technoforte.PALMS.Entities
{
    public interface IEntityKey<E> where E : Entity 
    {
        int GetFieldCount();
        Object GetValue(int field);
        string GetFieldName(int field);
        Type GetType(int field);
        E GetBlankEntityWithKey();
        string GetClassName();
        string ToString();
    }
}
