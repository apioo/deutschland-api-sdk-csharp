/**
 * MessageException automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */


using Sdkgen.Client.Exception;

namespace DeutschlandAPI.SDK;

public class MessageException : KnownStatusCodeException
{
    public Message Payload;

    public MessageException(Message payload)
    {
        this.Payload = payload;
    }
}
