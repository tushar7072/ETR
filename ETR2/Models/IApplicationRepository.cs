using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETR2.Models
{
    interface IApplicationRepository
    {
        Application GetApplicationDetails(int AppID);

    }
}
