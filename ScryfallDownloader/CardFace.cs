using System.Collections.Generic;

namespace ScryfallDownloader
{
    public class CardFace
    {
        public string Name { get; private set; }
        public Dictionary<string, string> ImageUris { get; private set; }

        public CardFace(CardFaceDTO cardFaceDTO)
        {
            Name = cardFaceDTO.face_name;
            ImageUris = cardFaceDTO.image_uris;
        }
    }
}
