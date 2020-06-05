using Flurl;
using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Frank.Brreg
{
    public class BrregClient
    {
        //public async Task<IEnumerable<Organization>> GetOrganizationsAsync()
        //{
        //    new Url("");
        //}

        public async Task<IEnumerable<OrganizationType>> GetOrganizationTypesAsync()
        {
            var url = new Url("https://data.brreg.no/enhetsregisteret/api/organisasjonsformer");
            try
            {
                return await url.GetJsonAsync<List<OrganizationType>>();
            }
            catch (FlurlHttpTimeoutException)
            {
                throw new TimeoutException("Http request timed out");
            }
            //catch (FlurlHttpException ex)
            //{
            //    throw new HttpRequestException(ex.Message + "\n" + ex.Call.Exception.StackTrace);
            //}
        }
    }
}
