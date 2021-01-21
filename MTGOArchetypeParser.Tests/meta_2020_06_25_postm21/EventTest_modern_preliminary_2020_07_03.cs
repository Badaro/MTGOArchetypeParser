using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Thrall90: Jund Midrange (BRG)
#02 _titoWii_96: WURG Control (WURG, Yorion)
#03 Boin: Eldrazi Tron (C)
#04 jdez: Orzhov Shadow (WB)
#05 triosk: Hardened Scales (G)
#06 Laplasjan: Devoted (WG, Lurrus)
#07 Dai1412: Izzet Prowess (UR)
#08 ecobaronen: Sultai Control (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_03 : EventTest
    {
        [Test]
        public void Deck01_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",0),
                "PostM21",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck02_titoWii96_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",1),
                "PostM21",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_Boin_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",2),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck04_jdez_OrzhovShadow_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",3),
                "PostM21",
                ArchetypeColor.WB,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck05_triosk_HardenedScales_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",4),
                "PostM21",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",5),
                "PostM21",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Dai1412_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",6),
                "PostM21",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck08_ecobaronen_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",7),
                "PostM21",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
