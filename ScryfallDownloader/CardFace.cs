using System;
using System.Collections.Generic;

namespace ScryfallDownloader
{
    public class CardFace : ICard
    {
        public string Name { get; private set; }
        public Dictionary<string, string> ImageUris { get; private set; }
        private Card Card { get; set; }

        public CardFace(Card card, CardFaceDTO cardFaceDTO)
        {
            Card = card;
            Name = cardFaceDTO.face_name;
            ImageUris = cardFaceDTO.image_uris;
        }

        public string CollectorNumber => Card.CollectorNumber;
        public string SetName => Card.SetName;
        public string SetCode => Card.SetCode;
        public string Layout => Card.Layout;
        public DateTime ReleaseDate => Card.ReleaseDate;
        public bool IsBanned => Card.IsBanned;
        public bool IsOversized => Card.IsOversized;
        public bool HasHighresImage => Card.HasHighresImage;
    }
}
