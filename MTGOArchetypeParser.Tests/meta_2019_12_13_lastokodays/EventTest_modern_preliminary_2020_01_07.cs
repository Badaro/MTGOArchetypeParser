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
#02 SoulStrong: Simic Control (UG)
#03 Beekeeper: Humans (WUBRG)
#04 azax: Sultai Prowess (UBG)
#05 MLupa: Devoted (WUG)
#06 McWinSauce: Bant Control (WUG)
#07 n00bcheesepwner: Amulet Titan (UG)
#08 benchsummer: Sultai Shadow (UBG)
#09 fried-liver-attack: Eldrazi Tron (C)
#10 sandydogmtg: Burn (R)
#11 bradyoo: Simic Control (UG)
#12 vini_torres: Gifts Storm (UR)
#13 frozenian: Crabvine (UBG)
#14 YawgmothPT: Humans (WUBRG)
#15 Kricha13: Thopter Urza (WUR)
#16 xame3: Burn (WR)
#17 SlyDaniel7787: Eldrazi Tron (G)
#18 dillyg10: Bant Midrange (WUG)
#19 THEsneakyhomunculous: Sultai Prowess (UBG)
#20 karatedom: Primeval Titan (UG)
#21 Nope5390: Sultai Prowess (UBG)
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
                new LastOkoDays(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck02_SoulStrong_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",1),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Beekeeper_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",2),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck04_azax_SultaiProwess_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",3),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck05_MLupa_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",4),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck06_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",5),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_n00bcheesepwner_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",6),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_benchsummer_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",7),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck09_friedliverattack_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",8),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck10_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",9),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck11_bradyoo_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",10),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck12_vinitorres_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",11),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck13_frozenian_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",12),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck14_YawgmothPT_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",13),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Kricha13_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",14),
                new LastOkoDays(),
                ArchetypeColor.WUR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck16_xame3_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",15),
                new LastOkoDays(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck17_SlyDaniel7787_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",16),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck18_dillyg10_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",17),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_THEsneakyhomunculous_SultaiProwess_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",18),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck20_karatedom_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",19),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Nope5390_SultaiProwess_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",20),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck22_ERUERUFU_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-07",21),
                new LastOkoDays(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }


    }
}
