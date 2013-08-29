using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScanMe.Net_processing.Exceptions
{
    class AccessDenied : Exception
    {
        /// <summary>
        /// it is used when Access to website is denied.
        /// </summary>
        public AccessDenied(string alert) : base(alert) { }
    }
}
