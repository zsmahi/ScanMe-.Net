using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp;

namespace ScanMe.Net_processing
{
    public class ScanMe
    {

        #region fields

        private bool _sslEnabled;
        private static RestClient _client = new RestClient();
        private string _apiPublicKey;
        private const long limitFileSize = 33554432; // 32 Mbytes

        

        public bool SslEnabled // using or not SSL 
        {
            get { return _sslEnabled; }
            set
            {
                _sslEnabled = value;
                if (_client.BaseUrl != null)
                    _client.BaseUrl = value ? _client.BaseUrl.Replace("http://", "https://") : _client.BaseUrl.Replace("https://", "http://");
            }
        }

        #endregion

        #region constructor

        public ScanMe(string apiPublicKey)
        {
            if (string.IsNullOrEmpty(apiPublicKey))
            {
                throw new ArgumentException("API Public Key not found", "apiPublicKey");
                    // test wether api key is available or not
            }
            _apiPublicKey = apiPublicKey;
            _client.BaseUrl = "http://www.virustotal.com/vtapi/v2/";
            _client.Proxy = null;
            _client.FollowRedirects = false;
        }

        #endregion


        #region methods
        // this region includes scan files , and result scan methodes.

        #endregion
    }
}
