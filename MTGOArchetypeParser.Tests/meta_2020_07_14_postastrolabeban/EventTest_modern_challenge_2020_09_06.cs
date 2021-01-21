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
#01 The_nayr: Obosh Aggro (R, Obosh)
#02 TSPJendrek: Sultai Control (UBG)
#03 D00mwake: Amulet Titan (RG)
#04 AceTrainerBlue: Yawgmoth (BG)
#05 fingers1991: Boros Prowess (WR, Lurrus)
#06 maxxattack: Ad Nauseam (WUB)
#07 Hyeri0418: Crabvine (UBG)
#08 AstralPlane: Mono Red Prowess (R, Jegantha)
#09 fling5133: Green Tron (G)
#10 MaxMagicer: Scapeshift (URG, Yorion)
#11 cws: Gifts Storm (UR)
#12 PTarts2win: Green Tron (G)
#13 HotBread: Izzet Prowess (UR)
#14 frozenian: Izzet Prowess (UR)
#15 klien7: Burn (WR)
#16 TwistedWombat: Rakdos Prowess (BR, Lurrus)
#17 calheiros: Amulet Titan (UG)
#18 zecriah: Green Tron (G)
#19 1yo2yo: Bant Control (WUG)
#20 scipios: Crabvine (UBG)
#21 tylerjjobrien: Niv To Light (WUBRG, Yorion)
#22 DamonXWind: Izzet Prowess (UR)
#23 Gigy: Naya Midrange (WRG)
#24 NobodyKnowsImADog: Green Tron (G)
#25 azax: Grixis Shadow (UBR)
#26 _Stream: Izzet Prowess (UR)
#27 KIMCHIMAN: Goblins (BR)
#28 WareHouseGames: Green Tron (G)
#29 aspiringspike: Sultai Control (UBG)
#30 Toastxp: Reclaimer Titan (WRG)
#31 mot88: Thalia Stompy (WR)
#32 SebastianStueckl: Bogles (WG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_09_06 : EventTest
    {
        [Test]
        public void Deck01_Thenayr_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",0),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",1),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_D00mwake_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",2),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck04_AceTrainerBlue_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",3),
                "PostAstrolabeBan",
                ArchetypeColor.BG,
                "Yawgmoth",
                null,
                null
            );
        }

        [Test]
        public void Deck05_fingers1991_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",4),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_maxxattack_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",5),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Hyeri0418_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",6),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck08_AstralPlane_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",7),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck09_fling5133_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",8),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck10_MaxMagicer_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",9),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",10),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck12_PTarts2win_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",11),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck13_HotBread_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",12),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck14_frozenian_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",13),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck15_klien7_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",14),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck16_TwistedWombat_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",15),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_calheiros_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",16),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck18_zecriah_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",17),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck19_1yo2yo_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",18),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck20_scipios_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",19),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck21_tylerjjobrien_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",20),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck22_DamonXWind_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",21),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck23_Gigy_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",22),
                "PostAstrolabeBan",
                ArchetypeColor.WRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck24_NobodyKnowsImADog_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",23),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck25_azax_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",24),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Stream_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",25),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck27_KIMCHIMAN_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",26),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck28_WareHouseGames_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",27),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck29_aspiringspike_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",28),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Toastxp_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",29),
                "PostAstrolabeBan",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck31_mot88_ThaliaStompy_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",30),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "ThaliaStompy",
                null,
                null
            );
        }

        [Test]
        public void Deck32_SebastianStueckl_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",31),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
