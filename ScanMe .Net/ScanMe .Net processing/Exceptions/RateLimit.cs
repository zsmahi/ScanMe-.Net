using System;

namespace ScanMe.Net_processing.Exceptions
{
    class RateLimit : Exception
    {
        /// <summary>
        /// it is used when Rate Limit is exceeded
        /// </summary>
        #region constructor
            public RateLimit(string alert) : base(alert) { }
        #endregion
    }
}
