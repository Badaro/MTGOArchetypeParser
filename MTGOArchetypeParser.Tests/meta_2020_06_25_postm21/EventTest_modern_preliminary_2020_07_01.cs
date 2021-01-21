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
#01 Paeng_Paeng: Merfolk (U)
#02 JV_7777: Dredge (BRG)
#03 Whitecell: Eldrazi Tron (C)
#04 nathanb1992: Infect (UG)
#05 _INF_: Gifts Storm (UR)
#06 bladede: Eldrazi Tron (C)
#07 otakkun: Green Tron (G)
#08 Aluren85: Dredge (UBRG)
#09 MlckyB: Bogles (WG)
#10 Eaglov: Titan Shift (RG)
#11 fradev1988: Bant Control (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_01 : EventTest
    {
        [Test]
        public void Deck01_PaengPaeng_Merfolk_U()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",0),
                "PostM21",
                ArchetypeColor.U,
                "Merfolk",
                null,
                null
            );
        }

        [Test]
        public void Deck02_JV7777_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",1),
                "PostM21",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Whitecell_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",2),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck04_nathanb1992_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",3),
                "PostM21",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck05_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",4),
                "PostM21",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck06_bladede_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",5),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",6),
                "PostM21",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck08_Aluren85_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",7),
                "PostM21",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck09_MlckyB_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",8),
                "PostM21",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Eaglov_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",9),
                "PostM21",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck11_fradev1988_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",10),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
