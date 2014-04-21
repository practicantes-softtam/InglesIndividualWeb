using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Framework;

namespace InglesIndividual.Business
{
    public class HorarioClubConversacion : InglesIndividualBusinessObject
    {
        private Data.HorarioClubConversacion Data
        {
            get { return this.DataObject as Data.HorarioClubConversacion; }

        }

        public HorarioClubConversacion()
        {
            this.DataObject = new Data.HorarioClubConversacion();
        }

        public List<Entities.HorarioClubConversacion> ListarHorarioClubConversacion(InglesIndividual.Entities.JQXGridSettings settings, int claCampus, int claEmpleado, int claHorario, int claDia)
        {
            return this.Data.ListarHorarioClubConversacion(settings, claCampus, claEmpleado, claHorario, claDia);
        }

        public List<Exception> Eliminar(int[] clas)
        {
            List<Exception> list = new List<Exception>();
            if (clas != null && clas.Length > 0)
            {
                foreach (int cla in clas)
                {
                    Entities.HorarioClubConversacion item = new Entities.HorarioClubConversacion(true);
                    item.ClaCampus = Utils.IsNull(cla, 0);
                    item.ClaEmpleado = Utils.IsNull(cla, 0);
                    item.ClaHorario = Utils.IsNull(cla, 0);
                    item.ClaDia = Utils.IsNull(cla, 0);
                    

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
