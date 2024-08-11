/**
 * DistrictTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace DeutschlandAPI.SDK;

public class DistrictTag : TagAbstract {
    public DistrictTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    /**
     * Returns a specific district
     */
    public async Task<District> Get(string districtId)
    {
        Dictionary<string, object> pathParams = new();
        pathParams.Add("district_id", districtId);

        Dictionary<string, object> queryParams = new();

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/district/:district_id", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<District>(response.Content);
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
     * Returns all available districts
     */
    public async Task<DistrictCollection> GetAll(int startIndex, string state, string name)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();
        queryParams.Add("startIndex", startIndex);
        queryParams.Add("state", state);
        queryParams.Add("name", name);

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/district", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<DistrictCollection>(response.Content);
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
