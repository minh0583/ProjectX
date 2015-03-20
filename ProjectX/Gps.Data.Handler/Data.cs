using Gps.Common;
using Gps.Data.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gps.Data.Handler
{
    public class GpsRepository : IGpsRepository
    {
        public string GetMessage()
        {
            return "Hello word";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gpsViewModel"></param>
        /// <returns></returns>
        public bool InsertGpsData(GpsViewModel gpsViewModel)
        {
            if (gpsViewModel != null)
            {
                using (var context = new GpsDataEntities())
                {
                    context.Gps.Add(new Gp
                    {
                        ID = gpsViewModel.ID,
                        Code = gpsViewModel.Code,
                        Description = gpsViewModel.Description,
                        LastChanged = DateTime.Now,
                        LastChangedBy = Guid.Empty
                    });

                    context.SaveChanges();
                }

                return true;
            }

            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public GpsViewModel GetGpsData()
        {
            using (var context = new GpsDataEntities())
            {
                var gpModel = context.Gps.FirstOrDefault();
                if (gpModel != null)
                {
                    return new GpsViewModel
                    {
                        ID = gpModel.ID,
                        Code = gpModel.Code,
                        Description = gpModel.Description,
                        LastChanged = gpModel.LastChanged,
                        LastChangedBy = gpModel.LastChangedBy
                    };
                }
            }

            return null;
        }


    }
}
