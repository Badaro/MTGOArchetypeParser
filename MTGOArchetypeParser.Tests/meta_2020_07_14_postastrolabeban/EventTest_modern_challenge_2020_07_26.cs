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
#01 Mateusf34: Eldrazi Tron (C)
#02 Shazzam: Bant Control (WUG)
#03 Shorak123: Sultai Control (UBG)
#04 mariogomes097: Grixis Shadow (UBR)
#05 SebastianStueckl: Dredge (BRG)
#06 hoveydw: Jund Shadow (BRG)
#07 gazmon48: Gruul Midrange (RG)
#08 Magicofplayer1: Dredge (BRG)
#09 CarlSwaggin: Gruul Midrange (RG)
#10 Numena_Lowallyn: Scapeshift (URG)
#11 Lord_of_Puntlantis: Electro Balance (UR)
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
#24 chococookie: Azorius Control (WU)
#25 Oscar_Franco: Jund Midrange (BRG)
#26 TheAfterman: Humans (WUBRG)
#27 bbq42069dude: Izzet Prowess (UR)
#28 CrusherBotBG: Hammer Time (W)
#29 Jok87: Izzet Control (UR)
#30 toondoslav: Dredge (BRG)
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
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_Shazzam_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Shorak123_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck05_SebastianStueckl_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",4),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck06_hoveydw_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",5),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck07_gazmon48_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",6),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Magicofplayer1_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",7),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck09_CarlSwaggin_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",8),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_NumenaLowallyn_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",9),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck11_LordofPuntlantis_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",10),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck12_Kuhb_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Edel_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",12),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_lsv_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_andrw1232_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_TombSimon_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",15),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck17_exoticherman_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",16),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_belanna999_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",17),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck19_Jokersrwild_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",18),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck20_crazybaloth_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck21_MaxMagicer_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",20),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Janh_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",21),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Moniz0801_AmuletTitan_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_chococookie_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_OscarFranco_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",24),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_TheAfterman_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck27_bbq42069dude_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",26),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck28_CrusherBotBG_HammerTime_W()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",27),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Jok87_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",28),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_toondoslav_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",29),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck31_indianpancake_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_sultai4lyfe_DimirControl_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-07-26",31),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
