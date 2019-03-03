using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ScryfallDownloader
{
    // https://scryfall.com/docs/api/cards
    public class CardDTO
    {
        public int? arena_id { get; set; }

        public string id { get; set; } //Guid

        public string lang { get; set; }

        public int? mtgo_id { get; set; }

        public int? mtgo_foil_id { get; set; }

        public List<int> multiverse_ids { get; set; }

        // https://docs.tcgplayer.com/docs
        public int? tcgplayer_id { get; set; }

        [JsonProperty("object")]
        public string content_type { get; set; }

        public string oracle_id { get; set; } // Guid

        public string prints_search_uri { get; set; }

        public string rulings_uri { get; set; }

        public string scryfall_uri { get; set; }

        [JsonProperty("uri")]
        public string api_uri { get; set; }

        public List<RelatedCardDTO> all_parts { get; set; }

        public List<CardFaceDTO> card_faces { get; set; }

        public decimal cmc { get; set; }

        // https://scryfall.com/docs/api/colors
        public List<string> colors { get; set; }

        // https://scryfall.com/docs/api/colors
        public List<string> color_identity { get; set; }

        // https://scryfall.com/docs/api/colors
        public List<string> color_indicator { get; set; }

        public int? edhrec_rank { get; set; }

        public bool foil { get; set; }

        public string hand_modifier { get; set; }

        // https://scryfall.com/docs/api/layouts
        public string layout { get; set; }

        public Dictionary<string, string> legalities { get; set; }

        public string life_modifier { get; set; }

        public string loyalty { get; set; }

        public string mana_cost { get; set; }

        [JsonProperty("name")]
        public string card_name { get; set; }

        public bool nonfoil { get; set; }

        public string oracle_text { get; set; }

        public bool oversized { get; set; }

        public string power { get; set; }

        public bool reserved { get; set; }

        public string toughness { get; set; }

        public string type_line { get; set; }

        public string artist { get; set; }

        public string border_color { get; set; }

        public string collector_number { get; set; }

        public bool digital { get; set; }

        public string flavor_text { get; set; }

        // https://scryfall.com/docs/api/layouts
        public string frame_effect { get; set; }

        // https://scryfall.com/docs/api/layouts
        public string frame { get; set; }

        public bool full_art { get; set; }

        public List<string> games { get; set; }

        public bool highres_image { get; set; }

        public string illustration_id { get; set; } // Guid

        public Dictionary<string, string> image_uris { get; set; }

        public Dictionary<string, string> prices { get; set; }

        public string printed_name { get; set; }

        public string printed_text { get; set; }

        public string printed_type_line { get; set; }

        public bool promo { get; set; }

        public Dictionary<string, string> purchase_uris { get; set; }

        public string rarity { get; set; }

        public Dictionary<string, string> related_uris { get; set; }

        public DateTime released_at { get; set; }

        public bool reprint { get; set; }

        public string scryfall_set_uri { get; set; }

        public string set_name { get; set; }

        public string set_search_uri { get; set; }

        public string set_uri { get; set; }

        public string set { get; set; }

        public bool story_spotlight { get; set; }

        public string watermark { get; set; }
    }
}
