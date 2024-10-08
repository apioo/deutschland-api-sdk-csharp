/**
 * AutobahnChargingStation automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace DeutschlandAPI.SDK;
public class AutobahnChargingStation
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("description")]
    public List<string>? Description { get; set; }
    [JsonPropertyName("coordinate")]
    public AutobahnCoordinate? Coordinate { get; set; }
}
