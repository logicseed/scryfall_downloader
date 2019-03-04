using System;
using System.Collections.Generic;

namespace ScryfallDownloader
{
    interface ICard
    {
        string Name { get; }
        string CollectorNumber { get; }
        string SetName { get; }
        string SetCode { get; }
        string Layout { get; }
        DateTime ReleaseDate { get; }
        bool IsBanned { get; }
        bool IsOversized { get; }
        bool HasHighresImage { get; }
        Dictionary<string, string> ImageUris { get; }
    }
}
