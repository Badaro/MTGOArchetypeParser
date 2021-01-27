using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Darkiundsa: WUBG Control (WUBG, Yorion)
#02 kaikalbuquerque: Bogles (WG, Lurrus)
#03 haubidtran: Uroza (WUG, Yorion)
#04 patheus_84: Ad Nauseam (WUB)
#05 Mistakenn: Amulet Titan (UG)
#06 ponchonater55: Scapeshift (URG, Yorion)
#07 DreamsOfAshiok: Eldrazi Tron (C)
#08 Just_Roll: Eldrazi Tron (C)
#09 FallenKonflicz: Gruul Midrange (RG, Obosh)
#10 __BMJ__: Mardu Prowess (WBR, Lurrus)
#11 Leafpanda: Eldrazi Tron (C)
#12 Parrit: Hardened Scales (BG, Lurrus)
#13 Fabrice_K: Eldrazi Tron (C)
#14 Wartico1: Mardu Prowess (WBR, Lurrus)
#15 Vasoi2323: Reclamation (UBG)
#16 gottelicious: Miracles (WU, Kaheera)
#17 Larry11: Gruul Midrange (RG, Obosh)
#18 ack_s: Hammer Time (WR, Lurrus)
#19 MadMaxErnst: Rakdos Prowess (BR, Lurrus)
#20 Jaime555d: Eldrazi Tron (C)
#21 Dafne17: Jund Midrange (BRG, Lurrus)
#22 Navas: Miracles (WU, Kaheera)
#23 fradev1988: Electro Balance (URG)
#24 Metal_Buddha: Abzan Midrange (WBG, Yorion)
#25 sff_mtg: Green Tron (G, Jegantha)
#26 mindcandy: Bant Control (WUG, Yorion)
#27 XxquestionablyawesomexX: Bogles (WG, Lurrus)
#28 mephidro: Neobrand (UBG)
#29 Bayesta_93: Boros Prowess (WR, Lurrus)
#30 ScreenwriterNY: Ad Nauseam (WUB)
#31 otakkun: Eldrazi Tron (C)
#32 Darthkid: Boros Prowess (WR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_super_qualifier_2020_05_24 : EventTest
    {
        [Test]
        public void Deck01_Darkiundsa_WUBGControl_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",0),
                "PostIkoria",
                ArchetypeColor.WUBG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_kaikalbuquerque_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",1),
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_haubidtran_Uroza_WUG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",2),
                "PostIkoria",
                ArchetypeColor.WUG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",3),
                "PostIkoria",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Mistakenn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",4),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck06_ponchonater55_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",5),
                "PostIkoria",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",6),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_JustRoll_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",7),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck09_FallenKonflicz_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",8),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck10_BMJ_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",9),
                "PostIkoria",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Leafpanda_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",10),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck12_Parrit_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",11),
                "PostIkoria",
                ArchetypeColor.BG,
                "HardenedScales",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_FabriceK_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",12),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck14_Wartico1_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",13),
                "PostIkoria",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_Vasoi2323_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",14),
                "PostIkoria",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck16_gottelicious_Miracles_WU_Kaheera()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",15),
                "PostIkoria",
                ArchetypeColor.WU,
                "Miracles",
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck17_Larry11_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",16),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck18_acks_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",17),
                "PostIkoria",
                ArchetypeColor.WR,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_MadMaxErnst_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",18),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_Jaime555d_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",19),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck21_Dafne17_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",20),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_Navas_Miracles_WU_Kaheera()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",21),
                "PostIkoria",
                ArchetypeColor.WU,
                "Miracles",
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck23_fradev1988_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",22),
                "PostIkoria",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck24_MetalBuddha_AbzanMidrange_WBG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",23),
                "PostIkoria",
                ArchetypeColor.WBG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck25_sffmtg_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",24),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck26_mindcandy_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",25),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_XxquestionablyawesomexX_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",26),
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_mephidro_Neobrand_UBG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",27),
                "PostIkoria",
                ArchetypeColor.UBG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Bayesta93_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",28),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_ScreenwriterNY_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",29),
                "PostIkoria",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck31_otakkun_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",30),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck32_Darthkid_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-24",31),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
