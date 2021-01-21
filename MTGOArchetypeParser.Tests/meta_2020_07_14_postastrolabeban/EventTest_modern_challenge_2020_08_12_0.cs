using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 blastoids: Azorius Control (WU)
#02 GedionRavenor: Reclamation (WUG)
#03 LyaApocalypse: Green Tron (G)
#04 qbturtle15: Jund Midrange (BRG)
#05 indianpancake: Jund Shadow (BRG, Lurrus)
#06 Samcaster-Mage: Eldrazi Tron (C)
#07 andrw1232: Rakdos Prowess (BR, Lurrus)
#08 _Falcon_: Izzet Prowess (UR)
#09 cftsoc3: Bant Blink (WUG)
#10 D00mwake: Rakdos Prowess (BR, Lurrus)
#11 exoticherman: Rakdos Prowess (BR, Lurrus)
#12 tanisong1221: Sultai Control (UBG)
#13 CHILLEDADED: Gruul Midrange (RG)
#14 RCMerriam: UBRG Shadow (UBRG)
#15 Oscar_Franco: Jund Midrange (BRG)
#16 sultai4lyfe: Dimir Control (UB)
#17 MissTrigger: Burn (R)
#18 patheus_84: Ad Nauseam (WUB)
#19 JV_7777: Eldrazi Tron (C)
#20 CanadianNinja: Niv To Light (WUBRG, Yorion)
#21 yu-ki: Eldrazi Tron (C)
#22 didoguidotti1: Bant Control (WUG)
#23 Xwhale: Izzet Prowess (UR)
#24 Maox: Izzet Prowess (UR)
#25 NorrathDecay: Green Tron (G)
#26 anamika: Elementals (WUBRG)
#27 lilianaofthevess: Jund Shadow (BRG)
#28 bigjc00: Amulet Titan (URG)
#29 cws: Gifts Storm (UR)
#30 aspiringspike: Azorius Control (WU)
#31 kthanakit26: Izzet Prowess (UR)
#32 Xenowan: Hardened Scales (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_08_12_0 : EventTest
    {
        [Test]
        public void Deck01_blastoids_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",0),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_GedionRavenor_Reclamation_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",1),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck03_LyaApocalypse_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",2),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck04_qbturtle15_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",3),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_indianpancake_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",4),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_SamcasterMage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",5),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_andrw1232_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",6),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Falcon_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",7),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck09_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",8),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                null
            );
        }

        [Test]
        public void Deck10_D00mwake_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",9),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_exoticherman_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",10),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_tanisong1221_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",11),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_CHILLEDADED_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",12),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_RCMerriam_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",13),
                "PostAstrolabeBan",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck15_OscarFranco_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",14),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_sultai4lyfe_DimirControl_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",15),
                "PostAstrolabeBan",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck17_MissTrigger_Burn_R()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",16),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck18_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",17),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck19_JV7777_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",18),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck20_CanadianNinja_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",19),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck21_yuki_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",20),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck22_didoguidotti1_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",21),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Xwhale_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",22),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck24_Maox_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",23),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck25_NorrathDecay_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",24),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck26_anamika_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",25),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Elementals",
                null,
                null
            );
        }

        [Test]
        public void Deck27_lilianaofthevess_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",26),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck28_bigjc00_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",27),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck29_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",28),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck30_aspiringspike_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",29),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck31_kthanakit26_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",30),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck32_Xenowan_HardenedScales_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-12-0",31),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                null
            );
        }


    }
}
