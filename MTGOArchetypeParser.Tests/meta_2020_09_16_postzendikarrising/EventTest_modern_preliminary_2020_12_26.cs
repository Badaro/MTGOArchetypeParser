using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 BERNASTORRES: Green Tron (G)
#02 kiko: Azorius Taxes (WU, Yorion)
#03 medvedev: Dimir Control (UB)
#04 Scabs: Heliod Combo (WR)
#05 Lavaridge: Reclamation (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_26 : EventTest
    {
        [Test]
        public void Deck01_BERNASTORRES_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-26",0),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck02_kiko_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-26",1),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "GenericTaxes",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_medvedev_DimirControl_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-26",2),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Scabs_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-26",3),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Lavaridge_Reclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-26",4),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }


    }
}
