using MTGOArchetypeParser.Data.Model;
using System;
using System.Diagnostics.CodeAnalysis;

namespace MTGOArchetypeParser.App
{
    public class RecordMatchup
    {
        public string Opponent { get; set; }
        public string OpponentArchetype { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }

        public override string ToString()
        {
            if(Wins>Losses)
            {
                return $"Won {Wins}-{Losses}-{Draws} against {Opponent} ({OpponentArchetype})";
            }
            else
            {
                if(Losses>Wins)
                {
                    return $"Lost {Losses}-{Wins}-{Draws} against {Opponent} ({OpponentArchetype})";
                }
                else
                {
                    return $"Draw {Wins}-{Losses}-{Draws} against {Opponent} ({OpponentArchetype})";
                }
            }
        }
    }
}
