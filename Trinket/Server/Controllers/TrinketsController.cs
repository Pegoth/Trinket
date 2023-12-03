using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace Trinket.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TrinketsController : ControllerBase
{
    public async Task<IActionResult> Get(CancellationToken cancellationToken) => new JsonResult(JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, TierModel>>>(await System.IO.File.ReadAllTextAsync("trinkets.json", cancellationToken)));

    private class TierModel
    {
        [JsonInclude]
        [JsonPropertyName("tier")]
        public string? Tier { get; set; }

        [JsonInclude]
        [JsonPropertyName("note")]
        public string? Note { get; set; }
    }
}