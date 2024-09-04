/**
 * ResponseException automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using Sdkgen.Client.Exception;

namespace DeutschlandAPI.SDK;

public class ResponseException : KnownStatusCodeException
{
    public Response Payload;

    public ResponseException(Response payload)
    {
        this.Payload = payload;
    }
}
