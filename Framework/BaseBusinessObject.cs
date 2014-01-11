using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework
{
    public class BaseBusinessObject
    {
        private BaseDataObject _data;

        protected BaseDataObject DataObject
        {
            get { return this._data; }
            set { this._data = value; }
        }

        public virtual void Save(Framework.Entity entity)
        {
            if (entity != null)
            {
                if (entity.FromDataSource)
                {
                    this.DataObject.Update(entity);
                }
                else
                {
                    this.DataObject.Insert(entity);
                }
            }
        }

        public virtual void PrepareEntityForEdition(Entity entity)
        {
            if (entity != null && this.DataObject != null)
            {
                if (entity.FromDataSource)
                {
                    this.DataObject.PrepareEntityForEdition(entity);
                }
                else
                {
                    this.DataObject.PrepareNewEntity(entity);
                }
            }
        }

        public virtual void Delete(Entity entity)
        {
            if (entity != null && this.DataObject != null)
            {
                DataTransaction tran = new DataTransaction(this.DataObject.ConnectionString);
                try
                {
                    this.DataObject.Delete(entity, tran);
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
                tran.Commit();
            }
        }
    }
}
