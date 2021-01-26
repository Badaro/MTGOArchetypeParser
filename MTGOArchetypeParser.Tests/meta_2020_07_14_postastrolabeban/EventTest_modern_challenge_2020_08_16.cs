using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 gazmon48: Green Tron (G)
#02 Do0mSwitch: Bant Control (WUG)
#03 aplapp: Rakdos Prowess (BR, Lurrus)
#04 Pennywisse: Grixis Shadow (UBR)
#05 exoticherman: Rakdos Prowess (BR, Lurrus)
#06 flatnose: Merfolk (UG)
#07 Rav104: Rakdos Prowess (BR, Lurrus)
#08 edward40hands: Golgari Midrange (BG)
#09 sinforlife54: Mono White Taxes (W)
#10 otakkun: Green Tron (G)
#11 uaedoliB: Humans (WUBRG)
#12 nick4567: Reclamation (URG)
#13 Laplasjan: Devoted (WG, Lurrus)
#14 Sodeq: Ad Nauseam (WUB)
#15 asnook: Jund Midrange (BRG)
#16 cws: Gifts Storm (UR)
#17 kanister: Bant Control (WUG)
#18 Delthar: Mill (UB)
#19 Toastxp: Bant Control (WUG)
#20 Gigy: Gruul Midrange (RG)
#21 Luzur: Sultai Control (UBG)
#22 spellvine: Izzet Prowess (UR)
#23 HouseOfManaMTG: Reclaimer Titan (WG)
#24 Yanti: Jund Midrange (BRG)
#25 Storytime: Devoted (WUG)
#26 Xuxa: Dredge (BRG)
#27 NorrathDecay: Burn (WR)
#28 ConnorM426: Reclamation (URG)
#29 musasabi: Amulet Titan (UG)
#30 NHA37: Eldrazi Tron (C)
#31 BSK_hercules: Reclamation (URG)
#32 kthanakit26: Burn (WR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_08_16 : EventTest
    {
        [Test]
        public void Deck01_gazmon48_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",0),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck02_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",1),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_aplapp_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",2),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Pennywisse_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",3),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck05_exoticherman_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",4),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_flatnose_Merfolk_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",5),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "Merfolk",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Rav104_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",6),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_edward40hands_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",7),
                "PostAstrolabeBan",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_sinforlife54_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",8),
                "PostAstrolabeBan",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck10_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",9),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck11_uaedoliB_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",10),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck12_nick4567_Reclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",11),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",12),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Sodeq_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",13),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck15_asnook_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",14),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",15),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck17_kanister_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",16),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Delthar_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",17),
                "PostAstrolabeBan",
                ArchetypeColor.UB,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Toastxp_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",18),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",19),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Luzur_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",20),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck22_spellvine_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",21),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck23_HouseOfManaMTG_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",22),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck24_Yanti_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",23),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck25_Storytime_Devoted_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",24),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Xuxa_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",25),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck27_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",26),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck28_ConnorM426_Reclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",27),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck29_musasabi_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",28),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck30_NHA37_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",29),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck31_BSKhercules_Reclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",30),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck32_kthanakit26_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-16",31),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }


    }
}
