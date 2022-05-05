using AltaApi.WebClients.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.Collections;


namespace AltaApi.WebClients.Helpers
{
    public class WebHelpers : IWebHelpers
    {
        public string GetValueFromExceptionDATA(Exception ex, string Key)
        {
            string value = string.Empty;
            if (ex.Data.Count > 0)
            {
                foreach (DictionaryEntry de in ex.Data)
                {
                    if (de.Key.Equals(Key))
                    {
                        value = de.Value.ToString();
                        break;
                    }
                }
            }

            return value;
        }

        public string GeValueFromHeader(IHeaderDictionary headers, string key) 
        {
            StringValues stringValue = string.Empty;
            string value = string.Empty;

            headers.TryGetValue(key, out stringValue);

            if (!string.IsNullOrEmpty(stringValue))
            {
                value = stringValue.FirstOrDefault().ToString();
            }

            if (string.IsNullOrEmpty(value))
            {
                throw new Exception(key + " is required on headers");
            }
            return value;

        }
    }
}
