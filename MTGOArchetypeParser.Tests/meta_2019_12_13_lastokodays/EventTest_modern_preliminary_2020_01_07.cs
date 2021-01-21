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
#01 l337erhosen: Bogles (WG)
#02 SoulStrong: Urza Oko (UG)
#03 Beekeeper: Humans (WUBRG)
#04 azax: Urza Oko (UBG)
#05 MLupa: Devoted (WUG)
#06 McWinSauce: Bant Control (WUG)
#07 n00bcheesepwner: Amulet Titan (UG)
#08 benchsummer: UBRG Shadow (UBRG)
#09 fried-liver-attack: Eldrazi Tron (G)
#10 sandydogmtg: Burn (R)
#11 bradyoo: Urza Oko (UG)
#12 vini_torres: Gifts Storm (UR)
#13 frozenian: Crabvine (UBRG)
#14 YawgmothPT: Humans (WUBRG)
#15 Kricha13: Thopter Urza (WUBR)
#16 xame3: Burn (WR)
#17 SlyDaniel7787: Eldrazi Tron (G)
#18 dillyg10: Bant Midrange (WUG)
#19 THEsneakyhomunculous: Urza Oko (UBG)
#20 karatedom: Primeval Titan (UG)
#21 Nope5390: Urza Oko (UBG)
#22 ERUERUFU: Bushwhacker Zoo (WRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2020_01_07 : EventTest
    {
        [Test]
        public void Deck01_l337erhosen_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",0),
                "LastOkoDays",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck02_SoulStrong_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",1),
                "LastOkoDays",
                ArchetypeColor.UG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Beekeeper_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",2),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck04_azax_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",3),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck05_MLupa_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",4),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck06_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",5),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_n00bcheesepwner_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",6),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck08_benchsummer_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",7),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck09_friedliverattack_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",8),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck10_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",9),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck11_bradyoo_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",10),
                "LastOkoDays",
                ArchetypeColor.UG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck12_vinitorres_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",11),
                "LastOkoDays",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck13_frozenian_Crabvine_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",12),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck14_YawgmothPT_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",13),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Kricha13_ThopterUrza_WUBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",14),
                "LastOkoDays",
                ArchetypeColor.WUBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck16_xame3_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",15),
                "LastOkoDays",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck17_SlyDaniel7787_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",16),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck18_dillyg10_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",17),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck19_THEsneakyhomunculous_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",18),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck20_karatedom_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",19),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Nope5390_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",20),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck22_ERUERUFU_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",21),
                "LastOkoDays",
                ArchetypeColor.WRG,
                "BushwhackerZoo",
                null,
                null
            );
        }


    }
}
