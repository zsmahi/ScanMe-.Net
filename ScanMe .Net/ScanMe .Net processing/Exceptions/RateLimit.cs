using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScanMe.Net_processing.Exceptions
{
    class RateLimit : Exception
    {
        /// <summary>
        /// it is used when Rate Limit is exceeded
        /// </summary>
        public RateLimit(string alert) : base(alert) { }
    }
}
