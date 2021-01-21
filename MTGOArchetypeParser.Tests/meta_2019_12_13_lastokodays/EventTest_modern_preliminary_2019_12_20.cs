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
#01 Valorj: Green Tron (G)
#02 TombSimon: Titan Shift (RG)
#03 Pintogeddon2: Humans (WUBRG)
#04 Mulldrifter: Eldrazi Tron (C)
#05 MattiJohansson: Green Eldrazi (UG)
#06 JapaneseFisherman: Green Eldrazi (RG)
#07 PRGJJAR: Dredge (BRG)
#08 Phill_Hellmuth: Humans (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2019_12_20 : EventTest
    {
        [Test]
        public void Deck01_Valorj_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-20",0),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck02_TombSimon_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-20",1),
                "LastOkoDays",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck03_Pintogeddon2_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-20",2),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Mulldrifter_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-20",3),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck05_MattiJohansson_GreenEldrazi_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-20",4),
                "LastOkoDays",
                ArchetypeColor.UG,
                "GreenEldrazi",
                null,
                null
            );
        }

        [Test]
        public void Deck06_JapaneseFisherman_GreenEldrazi_RG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-20",5),
                "LastOkoDays",
                ArchetypeColor.RG,
                "GreenEldrazi",
                null,
                null
            );
        }

        [Test]
        public void Deck07_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-20",6),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck08_PhillHellmuth_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-20",7),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }


    }
}
