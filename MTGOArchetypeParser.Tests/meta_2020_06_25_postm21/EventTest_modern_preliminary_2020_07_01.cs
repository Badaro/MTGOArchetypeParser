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
#03 Whitecell: ETron (C)
#04 nathanb1992: Infect (UG)
#05 _INF_: GiftsStorm (UR)
#06 bladede: ETron (C)
#07 otakkun: KGCTron (G)
#08 Aluren85: Dredge (UBRG)
#09 MlckyB: Bogles (WG)
#10 Eaglov: TitanShift (RG)
#11 fradev1988: SnowControl (WUG)
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
                new PostM21(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck02_JV7777_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",1),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Whitecell_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",2),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck04_nathanb1992_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",3),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck05_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",4),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck06_bladede_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",5),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck07_otakkun_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",6),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck08_Aluren85_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",7),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck09_MlckyB_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",8),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Eaglov_PrimevalTitan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",9),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck11_fradev1988_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-01",10),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }


    }
}
