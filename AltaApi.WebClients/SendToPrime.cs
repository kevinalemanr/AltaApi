using AltaApi.DTOs;
using AltaApi.UseCases;
using AltaApi.WebClients.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace AltaApi.WebClients
{
    public class SendToPrime : ApiController, ISendToPrime
    {   
        CookieContainer cookies { get; set; }
        CookieContainer cookiesToReques { get; set; }
        private readonly IConfiguration configuration;
        private readonly HttpClient httpClient;

        public SendToPrime(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.cookies = new CookieContainer();
            this.cookiesToReques = new CookieContainer();
            httpClient = new HttpClient();
        }

        public async Task<TransactionResult> SendDataToPrime(dynamic objectData)
        {
            var result = new TransactionResult();
            
            try
            {
                string uri = configuration.GetSection("AppSettings").GetSection("PRIME_WS").GetSection("UrlRequest").Value;
                string usr_id = configuration.GetSection("AppSettings").GetSection("PRIME_WS").GetSection("usr_id").Value;
                string password = configuration.GetSection("AppSettings").GetSection("PRIME_WS").GetSection("usr_id").Value;
                string json = string.Empty;
                string responseData = string.Empty;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.ContentType = "application/json";
                request.Method = "POST";


                request.Method = "POST";    
                request.ContentType = "application/json";

                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                request.CookieContainer = this.cookies;
                request.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;


                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {

                    json =  JsonConvert.SerializeObject(objectData);

                    streamWriter.Write(json);
                }


                using (HttpWebResponse response =  (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.Created)
                    {
                        throw new CreateLineInventoryException("ERROR ON SEND CREATE_LINE_INVENTORY_IN_IFD.");

                    }
                    else
                    {
                        using (Stream stream = response.GetResponseStream())
                        {
                            using (StreamReader reader = new StreamReader(stream))
                            {
                                responseData = reader.ReadToEnd();  
                            }
                        }

                        result.OK = true;
                        result.CODE = (int)response.StatusCode;
                        result.MESSAGE = responseData;
                        result.DATA = json;

                    }
                }
            }
            catch (Exception ex) 
            {
                throw new CreateLineInventoryException("Authentication error: " + ex.Message);
            }

            return  result;

        }


    }
}
