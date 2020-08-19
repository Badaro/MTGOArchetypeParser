using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_challenge_2020_06_28 : EventTest
    {
        [Test]
        public void Deck01_SebastianStueckl_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",0),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck02_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",1),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",2),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_FestiFan_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",3),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_shoktroopa_UTron_U()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",4),
                new PostM21(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Thrall90_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",5),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck07_dm95_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",6),
                new PostM21(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck08_djbmppwns_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",7),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Moniz0801_PrimevalTitan_AmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",8),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck10_MasterA_Goblins_SnoopGoblins_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",9),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck11_Trisky_DeathsShadow_TraverseShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",10),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck12_mariogomes097_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",11),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck13_indianpancake_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",12),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck14_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",13),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Sanchez5272_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",14),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck16_Diatomic_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",15),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_qbturtle15_Ponza_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",16),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck18_wambocombo2020_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",17),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck19_FranPi_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",18),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck20_DannyBambino_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",19),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck21_Mercenario_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",20),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck22_toondoslav_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",21),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Curtisaxel_Spirits_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",22),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck24_CNewman_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",23),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck25_nolyfe_Prowess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",24),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck26_fingers1991_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",25),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_sheastrausman_SnowControl_SnowReclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",26),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck28_kbr3_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",27),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck29_jessysamek_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",28),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_yamakiller_Ponza_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",29),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck31_ivan229_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",30),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck32_DreamsOfAshiok_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",31),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }


    }
}
