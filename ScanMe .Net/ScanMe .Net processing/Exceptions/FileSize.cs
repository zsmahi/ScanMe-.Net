using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScanMe.Net_processing.Exceptions
{
    class FileSize : Exception
    {
        /// <summary>
        /// it is used when size limit is reached or exceeded > 32 Mbytes.
        /// </summary>
        public FileSize(string alert) : base(alert){}
  

    }
}
