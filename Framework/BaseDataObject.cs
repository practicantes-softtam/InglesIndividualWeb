using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Xml;

namespace Framework
{
    public class BaseDataObject
    {
        public string ConnectionString
        {
            get { return this.GetConnectionString(); }
        }

        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SQLServer"].ConnectionString;
        }

        public virtual int Insert(Entity entity)
        {
            return this.Insert(entity, null);
        }

        public virtual int Insert(Entity entity, DataTransaction tran)
        {
            return 0;
        }

        public virtual int Update(Entity entity)
        {
            return this.Update(entity, null);
        }

        public virtual int Update(Entity entity, DataTransaction tran)
        {
            return 0;
        }

        public virtual int Delete(Entity entity)
        {
            return this.Delete(entity, null);
        }

        public virtual int Delete(Entity entity, DataTransaction tran)
        {
            return 0;
        }

        public virtual void PrepareEntityForEdition(Entity entity)
        {
        }

        public virtual void PrepareNewEntity(Entity entity)
        {
        }
    }
}
