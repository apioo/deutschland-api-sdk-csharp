/**
 * AutobahnParkingLorryCollection automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace DeutschlandAPI.SDK;
public class AutobahnParkingLorryCollection
{
    [JsonPropertyName("entries")]
    public List<AutobahnParkingLorry>? Entries { get; set; }
}
