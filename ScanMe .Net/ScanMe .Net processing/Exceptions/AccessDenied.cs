using System;

namespace ScanMe.Net_processing.Exceptions
{
    class AccessDenied : Exception
    {
        /// <summary>
        /// it is used when Access to website is denied.
        /// </summary>
        #region constructor
            public AccessDenied(string alert) : base(alert) { }
        #endregion
        
    }
}
