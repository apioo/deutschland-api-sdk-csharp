
# DeutschlandAPI SDK

This SDK helps to access the [DeutschlandAPI](https://deutschland-api.dev)

## Usage

The following example shows how you initialize the client:

```csharp
using DeutschlandAPI.SDK.Client;

Client client = Client.BuildAnonymous()

StateCollection collection = client.State().GetAll();
foreach (State state in collection.Entries())
{
    Console.WriteLine(state.Name);
}

```

More information about the complete API at:
https://app.typehub.cloud/d/deutschland-api/sdk
