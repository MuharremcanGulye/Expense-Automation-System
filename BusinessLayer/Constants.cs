using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer;

namespace BusinessLayer
{
    public static class Constants
    {
        public static string ConnectionString = AppConfigHelper.GetConnectionString("ExpenseAutomationDBConnString");
    }
}
