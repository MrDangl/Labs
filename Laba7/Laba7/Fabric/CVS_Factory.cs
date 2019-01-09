using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba7.Interface;
using System.IO;
namespace Laba7.Fabric
{
    class CVS_Factory : Interface.IDataObjectFactory
    {
        
        List<IDataObject> IDataObjectFactory.Import(string filename)
        {
            List<IDataObject> objects = new List<IDataObject>();
            using (StreamReader sr = new StreamReader(filename,Encoding.Default))
            {
                while (sr.Peek() != -1)
                {

                }
            }
            return objects;
        }
        string IDataObjectFactory.Convert(IDataObject obj)
        {
            throw new NotImplementedException();
        }

        string IDataObjectFactory.ConvertToString(List<IDataObject> emps)
        {
            throw new NotImplementedException();
        }

        IDataObject IDataObjectFactory.CreateObject(string NameOfClass)
        {
            throw new NotImplementedException();
        }

        void IDataObjectFactory.Export(string filename, List<IDataObject> emps)
        {
            throw new NotImplementedException();
        }

      
    }
}
