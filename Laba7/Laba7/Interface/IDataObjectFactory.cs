using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba7.Interface
{
    interface IDataObjectFactory
    {
        IDataObject CreateObject(string NameOfClass);
        string ConvertToString(List<IDataObject> emps);
        List<IDataObject> Import(string filename);
        void Export(string filename, List<IDataObject> emps);
        string Convert(IDataObject obj);
    }
}
