using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.More
{
    internal class ClsFormat
    {
        public static string DateToShort(DateTime Dt)
        {

            return Dt.ToString("dd/MMM/yyyy");
        }

    }
}
