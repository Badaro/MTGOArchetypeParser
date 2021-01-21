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
#01 hcook725: Uroza (WUG)
#02 DreamsOfAshiok: Rakdos Prowess (BR, Lurrus)
#03 bigjc00: Amulet Titan (URG)
#04 _goblinlackey: Mardu Prowess (WBR, Lurrus)
#05 yamakiller: Obosh Aggro (R, Obosh)
#06 SpiderSpace: Humans (WUBRG)
#07 qbturtle15: Gruul Midrange (RG)
#08 Jack_Kashtan: Ad Nauseam (WUB)
#09 FreedMania: Amulet Titan (UG)
#10 BigPanda_559: Burn (WR)
#11 SpicyLeche: Jund Shadow (BRG, Lurrus)
#12 exoticherman: Mardu Prowess (WBR, Lurrus)
#13 trader08111: Izzet Prowess (UR)
#14 Fluorspar: Humans (WUBRG)
#15 crazybaloth: Humans (WUBRG)
#16 Trellon: Blue Tron (U)
#17 blastoids: Bant Control (WUG)
#18 PvtEnormous: Bant Control (WUG)
#19 Day_man: Reclamation (URG)
#20 Midguy: Green Tron (G)
#21 Lord_of_Puntlantis: Electro Balance (URG)
#22 FloorFlower: Gruul Midrange (RG)
#23 raven0904: Green Tron (G)
#24 Corrado: Rakdos Prowess (BR, Lurrus)
#25 FestiFan: Reclamation (URG)
#26 scipios: Crabvine (UBG)
#27 cws: Gifts Storm (UR)
#28 hoveydw: Jund Shadow (BRG)
#29 benchsummer: UBRG Shadow (UBRG)
#30 HouseOfManaMTG: Dredge (WBRG)
#31 patheus_84: Ad Nauseam (WUB)
#32 ReturnToDust: Reclaimer Titan (WG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_08_30 : EventTest
    {
        [Test]
        public void Deck01_hcook725_Uroza_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",0),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck02_DreamsOfAshiok_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",1),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_bigjc00_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",2),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck04_goblinlackey_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",3),
                "PostAstrolabeBan",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_yamakiller_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",4),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_SpiderSpace_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",5),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck07_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",6),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_JackKashtan_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",7),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck09_FreedMania_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",8),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck10_BigPanda559_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",9),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck11_SpicyLeche_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",10),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_exoticherman_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",11),
                "PostAstrolabeBan",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_trader08111_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",12),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck14_Fluorspar_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",13),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck15_crazybaloth_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",14),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Trellon_BlueTron_U()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",15),
                "PostAstrolabeBan",
                ArchetypeColor.U,
                "Tron",
                "BlueTron",
                null
            );
        }

        [Test]
        public void Deck17_blastoids_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",16),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck18_PvtEnormous_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",17),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Dayman_Reclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",18),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Midguy_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",19),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck21_LordofPuntlantis_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",20),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck22_FloorFlower_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",21),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck23_raven0904_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",22),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck24_Corrado_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",23),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_FestiFan_Reclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",24),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck26_scipios_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",25),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck27_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",26),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck28_hoveydw_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",27),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck29_benchsummer_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",28),
                "PostAstrolabeBan",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck30_HouseOfManaMTG_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",29),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck31_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",30),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck32_ReturnToDust_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",31),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }


    }
}
