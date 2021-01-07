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
#05 MattiJohansson: Simic Taxes (UG)
#06 JapaneseFisherman: Obligator Eldrazi (RG)
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
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck02_TombSimon_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-20",1),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck03_Pintogeddon2_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-20",2),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Mulldrifter_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-20",3),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_MattiJohansson_SimicTaxes_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-20",4),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GreenEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck06_JapaneseFisherman_ObligatorEldrazi_RG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-20",5),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(GreenEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck07_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-20",6),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck08_PhillHellmuth_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-20",7),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }


    }
}
