using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace BusinessLayer
{
    public class StatusEnumHelper
    {

        public static string getStatusString(byte statusID)
        {
            switch (statusID)
            {
                case 1:
                    return "WaitingForApprove";
                case 2:
                    return "Declined";
                case 3:
                    return "NeedsEdit";
                case 4:
                    return "Paid";
                default:
                    return string.Empty;
            }
        }

        public static string getStatusString(StatusEnum status)
        {
            switch (status)
            {
                case StatusEnum.WaitingForApprove:
                    return "WaitingForApprove";
                case StatusEnum.Declined:
                    return "Declined";
                case StatusEnum.NeedsEdit:
                    return "NeedsEdit";
                case StatusEnum.Paid:
                    return "Paid";
                default:
                    return string.Empty;
            }
        }
    }
}
