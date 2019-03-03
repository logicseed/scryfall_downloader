using Newtonsoft.Json;

namespace ScryfallJsonParser
{
    // https://scryfall.com/docs/api/cards#related-card-objects
    public class RelatedCardDTO
    {
        public string id { get; set; } //Guid

        [JsonProperty("object")]
        public string content_type { get; set; }

        public string component { get; set; }

        [JsonProperty("name")]
        public string card_name { get; set; }

        public string type_line { get; set; }

        [JsonProperty("uri")]
        public string api_uri { get; set; }
    }
}
