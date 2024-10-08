/**
 * JobTag automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using Sdkgen.Client;
using Sdkgen.Client.Exception;

namespace DeutschlandAPI.SDK;

public class JobTag : TagAbstract {
    public JobTag(RestClient httpClient, Parser parser): base(httpClient, parser)
    {
    }


    /**
     * Returns all available jobs
     */
    public async Task<JobCollection> GetAll(int page, string search, string location, string employer)
    {
        Dictionary<string, object> pathParams = new();

        Dictionary<string, object> queryParams = new();
        queryParams.Add("page", page);
        queryParams.Add("search", search);
        queryParams.Add("location", location);
        queryParams.Add("employer", employer);

        List<string> queryStructNames = new();

        RestRequest request = new(this.Parser.Url("/job", pathParams), Method.Get);
        this.Parser.Query(request, queryParams, queryStructNames);

        RestResponse response = await this.HttpClient.ExecuteAsync(request);

        if (response.IsSuccessful)
        {
            return this.Parser.Parse<JobCollection>(response.Content);
        }

        throw (int) response.StatusCode switch
        {
            400 => new ResponseException(this.Parser.Parse<Response>(response.Content)),
            404 => new ResponseException(this.Parser.Parse<Response>(response.Content)),
            500 => new ResponseException(this.Parser.Parse<Response>(response.Content)),
            _ => throw new UnknownStatusCodeException("The server returned an unknown status code"),
        };
    }


}
