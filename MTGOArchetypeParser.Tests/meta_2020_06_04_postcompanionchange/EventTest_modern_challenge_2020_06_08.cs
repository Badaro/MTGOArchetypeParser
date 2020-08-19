using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_challenge_2020_06_08 : EventTest
    {
        [Test]
        public void Deck01_TSPJendrek_SnowControl_SnowBlade_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",0),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck02_ZYURYO_SnowControl_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",1),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_JB2002_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",2),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Yanti_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",3),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Blitzlion27_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",4),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck06_AstralPlane_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",5),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck07_SvenSvenSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",6),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_signblindman_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",7),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_hugo87_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",8),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Tw33Ty_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",9),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Cherryxman_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",10),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Trid0n_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",11),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",12),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",13),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck15_LordBeerus_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",14),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Batutinha_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",15),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_ScreenwriterNY_SnowControl_SultaiSnow_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",16),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_Erik157751_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",17),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck19_sffmtg_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",18),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck20_ScaccoMalto_Prowess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",19),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck21_mosskami_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",20),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck22_indianpancake_Devoted_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",21),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Koso_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",22),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck24_WeareVenom_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",23),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_robb93_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",24),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck26_leclairandy_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",25),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_MathGod_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",26),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Wartico1_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",27),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Nightblue_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",28),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck30_ilsecco14_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",29),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Moniz0801_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",30),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck32_OscarFranco_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-08",31),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }


    }
}
