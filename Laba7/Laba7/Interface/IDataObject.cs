using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7.Interface
{
    interface IDataObject
    {
        bool SetLiteralProperty(string Name, string Value);//метод установливает значение произвольно заданному свойству
        IDictionary<string, object> Content();//Метод обеспечивает возможность получить текущее состояние объекта 
        //Возможность работы со структурированной информацией 
    }
}
