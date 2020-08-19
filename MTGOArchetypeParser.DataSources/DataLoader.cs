using System;
using MTGOArchetypeParser.DataSources.Model;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace MTGOArchetypeParser.DataSources
{
    public static class DataLoader
    {
        public static Tournament[] GetTournaments(DateTime startDate, Func<string, bool> filter = null)
        {
            if (filter == null) filter = n => true;

            List<Tournament> result = new List<Tournament>();

            Console.WriteLine("Downloading tournament list");
            foreach (var tournament in MTGODecklistParser.Data.TournamentLoader.GetTournaments(startDate, DateTime.UtcNow).Where(t => filter(t.Name)))
            {
                result.Add(new Tournament()
                {
                    Name = tournament.Name,
                    Uri = tournament.Uri,
                    Decks = GetDecks(tournament.Uri)
                });
            }

            return result.ToArray();
        }

        public static Deck[] GetDecks(Uri uri)
        {
            List<Deck> result = new List<Deck>();

            Console.WriteLine($"Downloading {uri}");
            foreach (var deck in MTGODecklistParser.Data.DeckLoader.GetDecks(uri))
            {
                result.Add(new Deck()
                {
                    Player = deck.Player,
                    AnchorUri = deck.AnchorUri,
                    Date = deck.Date,
                    Mainboard = deck.Mainboard.Select(c => new DeckItem() { Count = c.Count, CardName = c.CardName }).ToArray(),
                    Sideboard = deck.Sideboard.Select(c => new DeckItem() { Count = c.Count, CardName = c.CardName }).ToArray(),
                });
            }

            return result.ToArray();
        }
    }
}
