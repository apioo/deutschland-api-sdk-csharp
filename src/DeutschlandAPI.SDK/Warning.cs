/**
 * Warning automatically generated by SDKgen please do not edit this file manually
 * @see https://sdkgen.app
 */

using System.Text.Json.Serialization;
namespace DeutschlandAPI.SDK;
public class Warning
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }
    [JsonPropertyName("urgency")]
    public string? Urgency { get; set; }
    [JsonPropertyName("type")]
    public string? Type { get; set; }
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("startDate")]
    public DateTime? StartDate { get; set; }
    [JsonPropertyName("expiresDate")]
    public DateTime? ExpiresDate { get; set; }
}
