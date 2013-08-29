using System;

namespace ScanMe.Net_processing.Exceptions
{
    class FileSize : Exception
    {
        /// <summary>
        /// it is used when size limit is reached or exceeded > 32 Mbytes.
        /// </summary>
        #region constructor
            public FileSize(string alert) : base(alert){}
        #endregion
  

    }
}
