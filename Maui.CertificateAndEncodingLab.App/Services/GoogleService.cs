namespace Maui.CertificateAndEncodingLab.App.Services;

public class GoogleService : IGoogleService
{
    #region Constructor

    public GoogleService(HttpClient httpClient)
    {
        var result = httpClient.GetAsync("").Result;
    }

    #endregion

    #region Public Methods

    public void GetHtmlAsync()
    {

    }

    #endregion
}
