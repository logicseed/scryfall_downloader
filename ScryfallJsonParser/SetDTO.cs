using Newtonsoft.Json;
using System;

namespace ScryfallJsonParser
{
    // https://scryfall.com/docs/api/sets
    public class SetDTO
    {
        public string id { get; set; } // Guid

        public string code { get; set; }

        public string mtgo_code { get; set; }

        public int? tcgplayer_id { get; set; }

        [JsonProperty("name")]
        public string set_name { get; set; }

        public string set_type { get; set; }

        public DateTime? released_at { get; set; }

        public string block_code { get; set; }

        public string block { get; set; }

        public string parent_set_code { get; set; }

        public int card_count { get; set; }

        public bool digital { get; set; }

        public bool foil_only { get; set; }

        public string scryfall_uri { get; set; }

        [JsonProperty("uri")]
        public string api_uri { get; set; }

        public string icon_svg_uri { get; set; }

        public string search_uri { get; set; }
    }
}
