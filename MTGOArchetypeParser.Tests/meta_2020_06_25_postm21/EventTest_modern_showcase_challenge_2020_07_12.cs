using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 musasabi: Amulet Titan (UG)
#02 jmeyer2030: Scapeshift (URG, Yorion)
#03 DaniMRebel: Selesnya Taxes (WG)
#04 Thrall90: Jund Midrange (BRG)
#05 SunofNothing: Bant Control (WUG)
#06 MrRaeb: Uroza (UBG, Yorion)
#07 wambocombo2020: Scapeshift (URG, Yorion)
#08 BSK_hercules: Izzet Prowess (UR)
#09 kbr3: Hardened Scales (G)
#10 Shamwowfella: Sultai Control (UBG)
#11 siomomi: Eldrazi Tron (C)
#12 nahuel10: Reclamation (UBG)
#13 mariogomes097: Grixis Shadow (UBR)
#14 EnlargedToShowTexture: Goblins (BR)
#15 Justodeangelo: Bant Control (WUG)
#16 karn_90: Temur Control (URG)
#17 zachattack23: Bant Control (WUG)
#18 ArchaeusDota: Green Tron (G)
#19 MCScards: Jund Midrange (BRG)
#20 MrSeri: Hardened Scales (G)
#21 qbturtle15: Jund Midrange (BRG)
#22 hugofreitas1: Gifts Storm (UR)
#23 cws: Gifts Storm (UR)
#24 otakkun: Green Tron (G)
#25 FreedMania: Amulet Titan (UG)
#26 yamakiller: Dredge (BRG)
#27 Juaspas: Gruul Midrange (RG)
#28 Fenrir18: Goblins (BR)
#29 LORiWWA: Eldrazi Tron (C)
#30 Mateusf34: Eldrazi Tron (C)
#31 N3to: Gifts Storm (UR)
#32 xakx47x: Devoted (WG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_showcase_challenge_2020_07_12 : EventTest
    {
        [Test]
        public void Deck01_musasabi_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",0),
                "PostM21",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck02_jmeyer2030_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",1),
                "PostM21",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_DaniMRebel_SelesnyaTaxes_WG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",2),
                "PostM21",
                ArchetypeColor.WG,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",3),
                "PostM21",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_SunofNothing_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",4),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",5),
                "PostM21",
                ArchetypeColor.UBG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_wambocombo2020_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",6),
                "PostM21",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_BSKhercules_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",7),
                "PostM21",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck09_kbr3_HardenedScales_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",8),
                "PostM21",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Shamwowfella_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",9),
                "PostM21",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_siomomi_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",10),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck12_nahuel10_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",11),
                "PostM21",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck13_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",12),
                "PostM21",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck14_EnlargedToShowTexture_Goblins_BR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",13),
                "PostM21",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Justodeangelo_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",14),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_karn90_TemurControl_URG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",15),
                "PostM21",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck17_zachattack23_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",16),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck18_ArchaeusDota_GreenTron_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",17),
                "PostM21",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck19_MCScards_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",18),
                "PostM21",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck20_MrSeri_HardenedScales_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",19),
                "PostM21",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                null
            );
        }

        [Test]
        public void Deck21_qbturtle15_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",20),
                "PostM21",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck22_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",21),
                "PostM21",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck23_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",22),
                "PostM21",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck24_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",23),
                "PostM21",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck25_FreedMania_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",24),
                "PostM21",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck26_yamakiller_Dredge_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",25),
                "PostM21",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck27_Juaspas_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",26),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck28_Fenrir18_Goblins_BR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",27),
                "PostM21",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck29_LORiWWA_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",28),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck30_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",29),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck31_N3to_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",30),
                "PostM21",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck32_xakx47x_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-07-12",31),
                "PostM21",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
