using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 McWinSauce: Bant Control (WUG)
#02 Deathnote1999: Eldrazi Tron (G)
#03 Kazuga: Mono Red Prowess (R)
#04 jessy_samek: Urza Oko (WURG)
#05 UBERMIKEYB: Urza Oko (URG)
#06 Gobo2009: Green Tron (G)
#07 Bohnz: Bant Control (WUG)
#08 Erik157751: Crabvine (UBG)
#09 lSoLlAKirA: Green Tron (G)
#10 _Shatun_: Mono Red Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2020_01_15 : EventTest
    {
        [Test]
        public void Deck01_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",0),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Deathnote1999_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",1),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck03_Kazuga_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",2),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck04_jessysamek_UrzaOko_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",3),
                "LastOkoDays",
                ArchetypeColor.WURG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck05_UBERMIKEYB_UrzaOko_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",4),
                "LastOkoDays",
                ArchetypeColor.URG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Gobo2009_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",5),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck07_Bohnz_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",6),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Erik157751_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",7),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck09_lSoLlAKirA_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",8),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck10_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-15",9),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
