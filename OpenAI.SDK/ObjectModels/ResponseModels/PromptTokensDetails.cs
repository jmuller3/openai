using System.Text.Json.Serialization;

namespace OpenAI.ObjectModels.ResponseModels
{
    public class PromptTokensDetails
    {
        [JsonPropertyName("cached_tokens")]
        public int? CachedTokens { get; set; }
    }
}

