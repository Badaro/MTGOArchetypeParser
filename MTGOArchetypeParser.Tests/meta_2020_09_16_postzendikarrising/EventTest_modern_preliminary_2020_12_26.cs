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
#01 BERNASTORRES: KGC Tron (G)
#02 kiko: Azorius Taxes (WU, Yorion)
#03 medvedev: Dimir Control (UB)
#04 Scabs: Heliod Combo (WR)
#05 Lavaridge: Temur Control (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_26 : EventTest
    {
        [Test]
        public void Deck01_BERNASTORRES_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-26",0),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck02_kiko_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-26",1),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_medvedev_DimirControl_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-26",2),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Scabs_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-26",3),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Lavaridge_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-26",4),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
