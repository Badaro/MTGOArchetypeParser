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
#01 SebastianStueckl: Snoop Goblins (BR)
#02 Mateusf34: E Tron (C)
#03 Sodeq: Dredge (BRG)
#04 FestiFan: Bant Control (WUG)
#05 shoktroopa: U Tron (U)
#06 Thrall90: Jund Midrange (BRG)
#07 dm95: Azorius Control (WU)
#08 djbmppwns: Gruul Midrange (RG)
#09 Moniz0801: Amulet Titan (URG)
#10 MasterA: Snoop Goblins (BR)
#11 Trisky: Jund Shadow (BRG)
#12 mariogomes097: Grixis Shadow (UBR)
#13 indianpancake: Gruul Midrange (RG)
#14 NorrathDecay: Burn (WR)
#15 Sanchez5272: KGC Tron (G)
#16 Diatomic: Bant Control (WUG)
#17 qbturtle15: Gruul Midrange (RG, Obosh)
#18 wambocombo2020: Burn (WR)
#19 FranPi: Gifts Storm (UR)
#20 Danny_Bambino: Jund Midrange (BRG)
#21 Mercenario: Dredge (BRG)
#22 toondoslav: Dredge (BRG)
#23 Curtisaxel: Bant Spirits (WUG)
#24 CNewman: Snoop Goblins (BR)
#25 no_lyfe: Mono Red Prowess (R)
#26 fingers1991: Burn (WR, Lurrus)
#27 sheastrausman: Temur Control (URG)
#28 kbr3: Scapeshift (URG)
#29 jessy_samek: Rakdos Prowess (BR, Lurrus)
#30 yamakiller: Gruul Midrange (RG, Obosh)
#31 ivan229: Gruul Midrange (RG)
#32 DreamsOfAshiok: E Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_challenge_2020_06_28 : EventTest
    {
        [Test]
        public void Deck01_SebastianStueckl_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",0),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
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
                typeof(Tron),
typeof(EldraziTron),
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
        public void Deck04_FestiFan_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",3),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
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
                typeof(Tron),
typeof(BlueTron),
                null
            );
        }

        [Test]
        public void Deck06_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",5),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_dm95_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",6),
                new PostM21(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_djbmppwns_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",7),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Moniz0801_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",8),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck10_MasterA_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",9),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Trisky_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",10),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck12_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",11),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck13_indianpancake_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",12),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
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
        public void Deck15_Sanchez5272_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",14),
                new PostM21(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck16_Diatomic_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",15),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_qbturtle15_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",16),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
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
        public void Deck20_DannyBambino_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",19),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Mercenario_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",20),
                new PostM21(),
                ArchetypeColor.BRG,
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
        public void Deck23_Curtisaxel_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",22),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck24_CNewman_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",23),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck25_nolyfe_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",24),
                new PostM21(),
                ArchetypeColor.R,
                typeof(GenericProwess),
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
        public void Deck27_sheastrausman_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",26),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
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
        public void Deck29_jessysamek_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",28),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_yamakiller_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",29),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck31_ivan229_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",30),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
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
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }


    }
}
