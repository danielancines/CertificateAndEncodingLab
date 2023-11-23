using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Maui.CertificateAndEncodingLab.App.HttpResponseHandlers
{
    public class HttpSslValidationHandler : HttpClientHandler
    {
        #region Constructor

        public HttpSslValidationHandler()
        {
            ServerCertificateCustomValidationCallback = CertificateValidationHandler;
        }

        #endregion

        #region Private Methods

        private bool CertificateValidationHandler(HttpRequestMessage message, X509Certificate2 certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return false;
        }

        #endregion
    }
}
