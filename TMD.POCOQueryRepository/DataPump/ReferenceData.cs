using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TMD.Domain.Models;

namespace TMD.POCOQueryRepository.DataPump
{
    public static class ReferenceData
    {

        public static bool PumpStatuses(QueryRepository repository)
        {
            DataStatus s;
            bool retVal = true;

            #region DATA STATUSES
            s = new DataStatus()
            {
                DataStatusName = "Live",
                AddDate = DateTime.Now,
            };
            repository.AddStatus(s);
            s = new DataStatus()
            {
                DataStatusName = "Suspended",
            };
            //repository.AddStatus(s);
            s = new DataStatus()
            {
                DataStatusName = "Mediation",
            };
            //repository.AddStatus(s);
            s = new DataStatus()
            {
                DataStatusName = "Promotion",
            };
            //repository.AddStatus(s);
            s = new DataStatus()
            {
                DataStatusName = "Deleted",
            };
            //repository.AddStatus(s);
            s = new DataStatus()
            {
                DataStatusName = "Incomplete",
            };
            //repository.AddStatus(s);
            s = new DataStatus()
            {
                DataStatusName = "Approval",
            };
            //repository.AddStatus(s);
            #endregion

            return retVal;
        }


    }
}
