using Newtonsoft.Json;
using System.Collections.Generic;

namespace ScryfallJsonParser
{
    // https://scryfall.com/docs/api/cards#card-face-objects
    public class CardFaceDTO
    {
        public string artist { get; set; }

        // https://scryfall.com/docs/api/colors
        public List<string> color_indicator { get; set; }

        // https://scryfall.com/docs/api/colors
        public List<string> colors { get; set; }

        public string flavor_text { get; set; }

        public string illustration_id { get; set; } // Guid

        public Dictionary<string, string> image_uris { get; set; }

        public string loyalty { get; set; }

        public string mana_cost { get; set; }

        [JsonProperty("name")]
        public string face_name { get; set; }

        [JsonProperty("object")]
        public string content_type { get; set; }

        public string oracle_text { get; set; }

        public string power { get; set; }

        public string printed_name { get; set; }

        public string printed_text { get; set; }

        public string printed_type_line { get; set; }

        public string toughness { get; set; }

        public string type_line { get; set; }

        public string watermark { get; set; }
    }
}
