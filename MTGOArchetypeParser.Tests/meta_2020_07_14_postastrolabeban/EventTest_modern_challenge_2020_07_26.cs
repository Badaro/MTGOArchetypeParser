using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Mateusf34: Eldrazi Tron (C)
#02 Shazzam: Bant Control (WUG)
#03 Shorak123: Reclamation (UBG)
#04 mariogomes097: Grixis Shadow (UBR)
#05 SebastianStueckl: Dredge (BRG)
#06 hoveydw: Jund Shadow (BRG)
#07 gazmon48: Gruul Midrange (RG)
#08 Magicofplayer1: Dredge (WBRG)
#09 CarlSwaggin: Gruul Midrange (RG)
#10 Numena_Lowallyn: Scapeshift (URG)
#11 Lord_of_Puntlantis: Electro Balance (URG)
#12 Kuhb: Gifts Storm (UR)
#13 Edel: Jund Midrange (BRG)
#14 lsv: Azorius Control (WU)
#15 andrw1232: Rakdos Prowess (BR, Lurrus)
#16 TombSimon: Crabvine (UBG)
#17 exoticherman: Rakdos Prowess (BR, Lurrus)
#18 belanna999: Eldrazi Tron (C)
#19 Jokersrwild: Goblins (BR)
#20 crazybaloth: Humans (WUBRG)
#21 MaxMagicer: Humans (WUBRG)
#22 Janh: Saheeli Combo (WUR)
#23 Moniz0801: Amulet Titan (WUG)
#24 chococookie: Miracles (WU)
#25 Oscar_Franco: Jund Midrange (BRG)
#26 TheAfterman: Humans (WUBRG)
#27 bbq42069dude: Izzet Prowess (UR)
#28 CrusherBotBG: Hammer Time (W)
#29 Jok87: Izzet Control (UR)
#30 toondoslav: Dredge (WBRG)
#31 indianpancake: Azorius Control (WU)
#32 sultai4lyfe: Dimir Control (UB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_07_26 : EventTest
    {
        [Test]
        public void Deck01_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",0),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck02_Shazzam_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",1),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Shorak123_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",2),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck04_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",3),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck05_SebastianStueckl_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",4),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck06_hoveydw_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",5),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck07_gazmon48_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",6),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Magicofplayer1_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",7),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck09_CarlSwaggin_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",8),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_NumenaLowallyn_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",9),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck11_LordofPuntlantis_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",10),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck12_Kuhb_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",11),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Edel_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",12),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_lsv_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",13),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_andrw1232_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",14),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_TombSimon_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",15),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck17_exoticherman_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",16),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_belanna999_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",17),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck19_Jokersrwild_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",18),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck20_crazybaloth_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",19),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck21_MaxMagicer_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",20),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Janh_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",21),
                "PostAstrolabeBan",
                ArchetypeColor.WUR,
                "SaheeliCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Moniz0801_AmuletTitan_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",22),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck24_chococookie_Miracles_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",23),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "Miracles",
                null,
                null
            );
        }

        [Test]
        public void Deck25_OscarFranco_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",24),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck26_TheAfterman_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",25),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck27_bbq42069dude_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",26),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck28_CrusherBotBG_HammerTime_W()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",27),
                "PostAstrolabeBan",
                ArchetypeColor.W,
                "HammerTime",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Jok87_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",28),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck30_toondoslav_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",29),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck31_indianpancake_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",30),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck32_sultai4lyfe_DimirControl_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",31),
                "PostAstrolabeBan",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                null
            );
        }


    }
}
