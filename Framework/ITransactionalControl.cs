using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework
{
    public interface ITransactionalControl
    {
        void Search();
        void New();
        void Edit();
        void Delete();
        void DeleteMultiple();
        void Save();
    }
}
