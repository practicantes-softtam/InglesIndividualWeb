
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework;

namespace InglesIndividual.Business
{
    public class Salones : InglesIndividualBusinessObject
    {
        private Data.Salones Data
        {
            get { return this.DataObject as Data.Salones; }
        }

        public Salones()
        {
            this.DataObject = new Data.Salones();
        }

        public List<Entities.Salones> ListarSalones(InglesIndividual.Entities.JQXGridSettings settings, string nomSalon)
        {
            return this.Data.ListarSalones(settings, nomSalon);
        }

        public List<Exception> Eliminar(string[] ids)
        {
            List<Exception> list = new List<Exception>();
            if (ids != null && ids.Length > 0)
            {
                foreach (string id in ids)
                {
                    Entities.Salones item = new Entities.Salones(true);
                    item.ID = Utils.IsNull(id, 0);

                    try
                    {
                        this.Data.Delete(item);
                    }
                    catch (Exception ex)
                    {
                        list.Add(ex);
                    }
                }
            }

            return list;
        }

        public List<Entities.Salones> Combo()
        {
            return this.Data.Combo();
        }

    }
}
