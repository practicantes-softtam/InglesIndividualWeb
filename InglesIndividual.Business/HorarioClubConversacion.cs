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

        public List<Entities.HorarioClubConversacion> ListarHorarioClubConversacion(InglesIndividual.Entities.JQXGridSettings settings, int claCampus)
        {
            return this.Data.ListarHorarioClubConversacion(settings, claCampus);
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
