using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 stainerson: Titan Shift (RG)
#02 pbarrrgh: Miracles (WU)
#03 Kuhb: Thopter Urza (UBG)
#04 Cherryxman: Eldrazi Tron (C)
#05 benchsummer: UBRG Shadow (UBRG)
#06 Finalnub: Eldrazi Tron (C)
#07 shoktroopa: Blue Tron (U)
#08 Brener: Infect (UG)
#09 qbturtle15: Jund Midrange (BRG)
#10 Nematic: Urza Oko (UBG)
#11 CaviAck: Eldrazi Tron (G)
#12 McWinSauce: Bant Control (WUG)
#13 UpNorthNorway: UBRG Shadow (UBRG)
#14 yamakiller: Eldrazi Tron (C)
#15 Mulldrifter: Eldrazi Tron (C)
#16 shadow_PT: Eldrazi Tron (C)
#17 patheus_84: Izzet Control (UR)
#18 belanna999: Eldrazi Tron (C)
#19 Poderosisimo: Grixis Shadow (UBR)
#20 122pablo: Ascendancy Combo (WURG)
#21 AbelMolto: Burn (WRG)
#22 Griselpuff: Eldrazi Tron (C)
#23 Sungjin: Bant Control (WUG)
#24 lurtzer: Devoted (WUG)
#25 Ivan_Catanduva_Br: Urza Oko (UBG)
#26 nahuel10: Burn (WR)
#27 Falkoneye: Urza Oko (UBG)
#28 updraftelemental: UBRG Shadow (UBRG)
#29 SourceOdin: Thopter Urza (WURG)
#30 azatoyellow: Temur Control (URG)
#31 kazna: Bant Control (WUG)
#32 OPMegaProEloKoks: Crabvine (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_challenge_2019_12_16 : EventTest
    {
        [Test]
        public void Deck01_stainerson_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",0),
                "LastOkoDays",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck02_pbarrrgh_Miracles_WU()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",1),
                "LastOkoDays",
                ArchetypeColor.WU,
                "Miracles",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Kuhb_ThopterUrza_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",2),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck04_Cherryxman_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",3),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck05_benchsummer_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",4),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Finalnub_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",5),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_shoktroopa_BlueTron_U()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",6),
                "LastOkoDays",
                ArchetypeColor.U,
                "Tron",
                "BlueTron",
                null
            );
        }

        [Test]
        public void Deck08_Brener_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",7),
                "LastOkoDays",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck09_qbturtle15_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",8),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Nematic_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",9),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck11_CaviAck_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",10),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck12_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",11),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_UpNorthNorway_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",12),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck14_yamakiller_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",13),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck15_Mulldrifter_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",14),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck16_shadowPT_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",15),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck17_patheus84_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",16),
                "LastOkoDays",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck18_belanna999_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",17),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck19_Poderosisimo_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",18),
                "LastOkoDays",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck20_122pablo_AscendancyCombo_WURG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",19),
                "LastOkoDays",
                ArchetypeColor.WURG,
                "AscendancyCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck21_AbelMolto_Burn_WRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",20),
                "LastOkoDays",
                ArchetypeColor.WRG,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck22_Griselpuff_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",21),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck23_Sungjin_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",22),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck24_lurtzer_Devoted_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",23),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck25_IvanCatanduvaBr_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",24),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck26_nahuel10_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",25),
                "LastOkoDays",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck27_Falkoneye_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",26),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck28_updraftelemental_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",27),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck29_SourceOdin_ThopterUrza_WURG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",28),
                "LastOkoDays",
                ArchetypeColor.WURG,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck30_azatoyellow_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",29),
                "LastOkoDays",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck31_kazna_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",30),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck32_OPMegaProEloKoks_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-16",31),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }


    }
}
