using System;
using System.Linq;
using System.Data.Linq.SqlClient;


namespace ApteanEdgeBankDataLayer
{
    public class ActivityDL
    {
        ApteanEdgeBankMasterDatabaseDataContext dbBank = new ApteanEdgeBankMasterDatabaseDataContext();
        public IQueryable<Activity> GetAllTheActivity(string _accountId)
        {
            try
            {
                var activityList = from activity in dbBank.Activities where SqlMethods.Like(activity.AccoutId.ToString(),_accountId+"%") select activity;
                return activityList;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
