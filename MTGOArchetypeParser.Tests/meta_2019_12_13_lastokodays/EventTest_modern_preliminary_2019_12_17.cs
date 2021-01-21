using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 MLupa: Gifts Storm (URG)
#02 THE_NARD: Mono Red Prowess (R)
#03 Folero: Infect (UG)
#04 scubypandatv: Devoted (WBRG)
#05 Joey_Wheeler: Green Eldrazi (UG)
#06 Finespoo: Infect (UG)
#07 McWinSauce: Bant Control (WUG)
#08 Mulldrifter: Eldrazi Tron (C)
#09 crazeejakee07: Bant Midrange (WUG)
#10 kasa: Green Tron (G)
#11 killersuv: Eldrazi Tron (C)
#12 Bugsy69: Gifts Storm (UR)
#13 TombSimon: Crabvine (UBG)
#14 SoulStrong: UBRG Shadow (UBRG)
#15 Lord_of_Puntlantis: Infect (UG)
#16 qbturtle15: Jund Midrange (BRG)
#17 griffy161: Green Tron (G)
#18 yamakiller: Eldrazi Tron (C)
#19 limp22: Devoted (WUG)
#20 sandydogmtg: Burn (WR)
#21 Atticuslol: Mono Red Prowess (R)
#22 azax: UBRG Shadow (UBRG)
#23 Nammersquats: Humans (WUBRG)
#24 FalseMufn: Amulet Titan (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2019_12_17 : EventTest
    {
        [Test]
        public void Deck01_MLupa_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",0),
                "LastOkoDays",
                ArchetypeColor.URG,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck02_THENARD_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",1),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck03_Folero_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",2),
                "LastOkoDays",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck04_scubypandatv_Devoted_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",3),
                "LastOkoDays",
                ArchetypeColor.WBRG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck05_JoeyWheeler_GreenEldrazi_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",4),
                "LastOkoDays",
                ArchetypeColor.UG,
                "GreenEldrazi",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Finespoo_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",5),
                "LastOkoDays",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck07_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",6),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Mulldrifter_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",7),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck09_crazeejakee07_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",8),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_kasa_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",9),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck11_killersuv_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",10),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck12_Bugsy69_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",11),
                "LastOkoDays",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck13_TombSimon_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",12),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck14_SoulStrong_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",13),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck15_LordofPuntlantis_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",14),
                "LastOkoDays",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck16_qbturtle15_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",15),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck17_griffy161_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",16),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck18_yamakiller_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",17),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck19_limp22_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",18),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck20_sandydogmtg_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",19),
                "LastOkoDays",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck21_Atticuslol_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",20),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck22_azax_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",21),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Nammersquats_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",22),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck24_FalseMufn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-17",23),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }


    }
}
