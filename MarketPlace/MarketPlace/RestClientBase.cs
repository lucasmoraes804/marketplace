using Newtonsoft.Json;
using RestSharp;
using System;

namespace MarketPlace
{
    public class RestClientBase : RestClient
    {
        public string requestResult { get; set; }
        public string responsetResult { get; set; }
        public RestClientBase():base()
        {
                
        }

        public RestClientBase(string baseUrl):base(baseUrl)
        {

        }
        //
        // Resumo:
        //     Sets the BaseUrl property for requests made by this client instance
        //
        // Parâmetros:
        //   baseUrl:
        public RestClientBase(Uri baseUrl) : base(baseUrl)
        {

        }

        public override IRestResponse Execute(IRestRequest request)
        {
            var restSerializable = JsonConvert.SerializeObject(request);

            if (!string.IsNullOrEmpty(restSerializable))
                this.requestResult = restSerializable;
            
            var response = base.Execute(request);
            if (response != null)
                this.responsetResult = JsonConvert.SerializeObject(response);

            return response;
        }

    }
}
