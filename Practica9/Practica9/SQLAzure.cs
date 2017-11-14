using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace Practica9
{
    public  interface SQLAzure
    {
        Task<MobileServiceUser> Authenticate();
    }
}
