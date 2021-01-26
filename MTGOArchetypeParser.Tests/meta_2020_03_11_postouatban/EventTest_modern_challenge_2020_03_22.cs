using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 albert62: Jund Midrange (BRG)
#02 nahuel10: Burn (WR)
#03 stainerson: Niv To Light (WUBRG)
#04 SCJ: Jund Midrange (BRG)
#05 _IlNano_: Humans (WUBRG)
#06 remf: Gruul Midrange (RG)
#07 Jenara19: Uroza (URG)
#08 tia05: Primeval Titan (RG)
#09 5ives: Dredge (BRG)
#10 DrPP: Mono Red Prowess (R)
#11 snapcaster____mage: Eldrazi Tron (C)
#12 PRGJJAR: Dredge (BRG)
#13 Kharlem: Mono Red Prowess (R)
#14 ilsecco14: Burn (WR)
#15 stonepeanut: Green Tron (G)
#16 SouthernSliver: Slivers (WUBRG)
#17 MiguelCaster: Mono White Eldrazi Taxes (W)
#18 PermissionMTG: Zoo (WRG)
#19 SunofNothing: Uroza (URG)
#20 SemoMTGBros: WURG Control (WURG)
#21 levunga21: Bant Control (WUG)
#22 TSPJendrek: WUBG Control (WUBG)
#23 Parrit: Orzhov Eldrazi Taxes (WB)
#24 AlexD41: Mono Red Prowess (R)
#25 HarlanMTG: Bant Control (WUG)
#26 yxcvbnm: Bant Control (WUG)
#27 MastaHorus: Electro End (URG)
#28 Gerschi: Thopter Urza (WUR)
#29 pepeteam: Amulet Titan (UG)
#30 Curufinwe: Jund Midrange (BRG)
#31 SlyDaniel7787: Eldrazi Tron (C)
#32 Graciasportanto: Uroza (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_challenge_2020_03_22 : EventTest
    {
        [Test]
        public void Deck01_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",0),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck02_nahuel10_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",1),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck03_stainerson_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",2),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck04_SCJ_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",3),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_IlNano_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",4),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck06_remf_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",5),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Jenara19_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",6),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck08_tia05_PrimevalTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",7),
                "PostOuatBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck09_5ives_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",8),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck10_DrPP_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",9),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck11_snapcastermage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",10),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck12_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",11),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Kharlem_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",12),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck14_ilsecco14_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",13),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck15_stonepeanut_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",14),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck16_SouthernSliver_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",15),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck17_MiguelCaster_MonoWhiteEldraziTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",16),
                "PostOuatBan",
                ArchetypeColor.W,
                "Taxes",
                "EldraziTaxes",
                null
            );
        }

        [Test]
        public void Deck18_PermissionMTG_Zoo_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",17),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "Zoo",
                null,
                null
            );
        }

        [Test]
        public void Deck19_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",18),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck20_SemoMTGBros_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",19),
                "PostOuatBan",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_levunga21_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",20),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck22_TSPJendrek_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",21),
                "PostOuatBan",
                ArchetypeColor.WUBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Parrit_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",22),
                "PostOuatBan",
                ArchetypeColor.WB,
                "Taxes",
                "EldraziTaxes",
                null
            );
        }

        [Test]
        public void Deck24_AlexD41_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",23),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck25_HarlanMTG_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",24),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck26_yxcvbnm_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",25),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck27_MastaHorus_ElectroEnd_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",26),
                "PostOuatBan",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroEnd",
                null
            );
        }

        [Test]
        public void Deck28_Gerschi_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",27),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck29_pepeteam_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",28),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck30_Curufinwe_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",29),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck31_SlyDaniel7787_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",30),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck32_Graciasportanto_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",31),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }


    }
}
