﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Business
{
    public class HorarioMaestros : InglesIndividualBusinessObject
    {
        private Data.HorarioMaestros Data
        {
            get { return this.DataObject as Data.HorarioMaestros; }
        }

        public HorarioMaestros()
        {
            this.DataObject = new Data.HorarioMaestros();
        }

        public List<Entities.HorarioMaestros> ListarHorarioMaestros(InglesIndividual.Entities.JQXGridSettings settings, int ClaEmpleado, int ClaCampus, int ClaHorario)
        {
            return this.Data.ListarHorarioMaestros(settings, ClaEmpleado, ClaCampus, ClaHorario);
        }

        public List<Exception> Eliminar(int[] clas)
        { 
            List<Exception> list = new List<Exception>();
            if (clas != null && clas.Length > 0)
            {
                foreach (int cla in clas)
                {
                    Entities.HorarioMaestros item = new Entities.HorarioMaestros(true);
                    item.Empleado = new Entities.Empleados();
                    item.Empleado.ID = Utils.IsNull(cla, 0);
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
    }
}
