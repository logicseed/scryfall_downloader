using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ScryfallJsonParser
{
    public class Parser
    {
        public List<CardDTO> Cards { get; private set; }

        public async Task ParseCards(string file)
        {
            Cards = new List<CardDTO>();

            using (var stream = new StreamReader(file))
            using (var reader = new JsonTextReader(stream))
            {
                // TODO: implement progress indicator
                var serializer = new JsonSerializer();
                while (await reader.ReadAsync())
                {
                    if (reader.TokenType == JsonToken.StartObject)
                    {
                        var card = serializer.Deserialize<CardDTO>(reader);
                        Cards.Add(card);
                    }
                }
            }

            return;
        }
    }
}
