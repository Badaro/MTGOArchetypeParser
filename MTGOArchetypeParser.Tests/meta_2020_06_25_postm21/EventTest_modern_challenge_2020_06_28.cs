using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 SebastianStueckl: Goblins (BR)
#02 Mateusf34: Eldrazi Tron (C)
#03 Sodeq: Dredge (BRG)
#04 FestiFan: Bant Control (WUG)
#05 shoktroopa: Blue Tron (U)
#06 Thrall90: Jund Midrange (BRG)
#07 dm95: Azorius Control (WU)
#08 djbmppwns: Gruul Midrange (RG)
#09 Moniz0801: Amulet Titan (URG)
#10 MasterA: Goblins (BRG)
#11 Trisky: Jund Shadow (BRG)
#12 mariogomes097: Grixis Shadow (UBR)
#13 indianpancake: Gruul Midrange (RG)
#14 NorrathDecay: Burn (WR)
#15 Sanchez5272: Green Tron (G)
#16 Diatomic: Bant Control (WUG)
#17 qbturtle15: Gruul Midrange (RG, Obosh)
#18 wambocombo2020: Burn (WR)
#19 FranPi: Gifts Storm (UR)
#20 Danny_Bambino: Jund Midrange (BRG)
#21 Mercenario: Dredge (UBRG)
#22 toondoslav: Dredge (BRG)
#23 Curtisaxel: Spirits (WUG)
#24 CNewman: Goblins (BR)
#25 no_lyfe: Mono Red Prowess (R)
#26 fingers1991: Burn (WR, Lurrus)
#27 sheastrausman: Reclamation (URG)
#28 kbr3: Scapeshift (URG)
#29 jessy_samek: Rakdos Prowess (BR, Lurrus)
#30 yamakiller: Gruul Midrange (RG, Obosh)
#31 ivan229: Gruul Midrange (RG)
#32 DreamsOfAshiok: Eldrazi Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_challenge_2020_06_28 : EventTest
    {
        [Test]
        public void Deck01_SebastianStueckl_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",0),
                "PostM21",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",1),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck03_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",2),
                "PostM21",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck04_FestiFan_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",3),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_shoktroopa_BlueTron_U()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",4),
                "PostM21",
                ArchetypeColor.U,
                "Tron",
                "BlueTron",
                null
            );
        }

        [Test]
        public void Deck06_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",5),
                "PostM21",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_dm95_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",6),
                "PostM21",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_djbmppwns_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",7),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Moniz0801_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",8),
                "PostM21",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck10_MasterA_Goblins_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",9),
                "PostM21",
                ArchetypeColor.BRG,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Trisky_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",10),
                "PostM21",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck12_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",11),
                "PostM21",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck13_indianpancake_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",12),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",13),
                "PostM21",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck15_Sanchez5272_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",14),
                "PostM21",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck16_Diatomic_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",15),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck17_qbturtle15_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",16),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck18_wambocombo2020_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",17),
                "PostM21",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck19_FranPi_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",18),
                "PostM21",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck20_DannyBambino_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",19),
                "PostM21",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Mercenario_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",20),
                "PostM21",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck22_toondoslav_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",21),
                "PostM21",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Curtisaxel_Spirits_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",22),
                "PostM21",
                ArchetypeColor.WUG,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck24_CNewman_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",23),
                "PostM21",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck25_nolyfe_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",24),
                "PostM21",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck26_fingers1991_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",25),
                "PostM21",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_sheastrausman_Reclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",26),
                "PostM21",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck28_kbr3_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",27),
                "PostM21",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck29_jessysamek_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",28),
                "PostM21",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_yamakiller_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",29),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck31_ivan229_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",30),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck32_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-28",31),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }


    }
}
