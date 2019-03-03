using System.Collections.Generic;

namespace ScryfallDownloader
{
    public class Card
    {
        public string Name { get; private set; }
        public string CollectorNumber { get; private set; }
        public List<CardFace> CardFaces { get; private set; }
        public string SetName { get; private set; }
        public string SetCode { get; private set; }
        public bool IsBanned { get; private set; }
        public bool IsOversized { get; private set; }
        public bool HasHighresImage { get; private set; }
        public Dictionary<string, string> ImageUris { get; private set; }

        public Card(CardDTO cardDTO)
        {
            Name = cardDTO.card_name;
            CollectorNumber = cardDTO.collector_number;

            if (cardDTO.card_faces != null)
            {
                CardFaces = new List<CardFace>();
                foreach (var cardFace in cardDTO.card_faces)
                {
                    CardFaces.Add(new CardFace(cardFace));
                }
            }

            SetName = cardDTO.set_name;
            SetCode = cardDTO.set;
            IsBanned = cardDTO.legalities.ContainsValue("banned");
            IsOversized = cardDTO.oversized;
            HasHighresImage = cardDTO.highres_image;
            ImageUris = cardDTO.image_uris;
        }
    }
}
