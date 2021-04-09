using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public enum StatusEnum
    {
        WaitingForApprove = 1,
        Declined = 2,
        NeedsEdit = 3,
        Paid = 4
    }
}
