/**
 * CityTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace DeutschlandAPI.SDK;

public class CityTag : TagAbstract {
    public CityTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    /**
     * Returns a specific city
     */
    public async Task<City> Get(string cityId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("city_id", cityId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/city/:city_id", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<City>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            400 => new MessageException(this.Parser.Parse<Message>(response.Content)),
            404 => new MessageException(this.Parser.Parse<Message>(response.Content)),
            500 => new MessageException(this.Parser.Parse<Message>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }

    /**
     * Returns all available cities
     */
    public async Task<CityCollection> GetAll(int startIndex, string state, string district, string name, string zipCode)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();
        queryParams.Add("startIndex", startIndex);
        queryParams.Add("state", state);
        queryParams.Add("district", district);
        queryParams.Add("name", name);
        queryParams.Add("zipCode", zipCode);

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/city", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<CityCollection>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            400 => new MessageException(this.Parser.Parse<Message>(response.Content)),
            404 => new MessageException(this.Parser.Parse<Message>(response.Content)),
            500 => new MessageException(this.Parser.Parse<Message>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }


}
