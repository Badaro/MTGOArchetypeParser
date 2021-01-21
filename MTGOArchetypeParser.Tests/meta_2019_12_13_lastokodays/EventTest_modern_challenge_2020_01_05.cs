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
#01 LillHalonen: Bogles (WG)
#02 Elnitzo: Eldrazi Tron (C)
#03 exoticherman: Infect (UG)
#04 austinflakesss: Primeval Titan (UG)
#05 lan2_13: Niv To Light (WUBRG)
#06 llawtonss: Urza Oko (UG)
#07 rksgsn: Burn (R)
#08 Samcaster-Mage: Eldrazi Tron (G)
#09 CraigMack378: Green Tron (G)
#10 failbotover9000: Jund Midrange (BRG)
#11 xfile: Eldrazi Tron (G)
#12 JHF: Urza Oko (UG)
#13 mindcandy: Eldrazi Tron (C)
#14 GodOfSlaughter: Bant Midrange (WUG)
#15 VTCLA: Urza Oko (UG)
#16 yPrincipe: Eldrazi Tron (C)
#17 SoulStrong: UBRG Shadow (UBRG)
#18 NuBlkAu: UBRG Shadow (UBRG)
#19 Andreas_Mueller: Urza Oko (UG)
#20 JustBurn420: Slivers (WUBRG)
#21 bradyoo: Urza Oko (UG)
#22 cityofcards: Azorius Control (WU)
#23 Kazuga: Primeval Titan (WG)
#24 ZackyChan: Urza Oko (URG)
#25 RicardoMSLan: Eldrazi Tron (C)
#26 Szelma: Eldrazi Tron (C)
#27 fradev1988: Electro Balance (UR)
#28 CHILLEDADED: Burn (WR)
#29 CarlSwaggin: Green Tron (G)
#30 MGGX: Grixis Shadow (UBR)
#31 yamakiller: Titan Shift (RG)
#32 NorrathDecay: Burn (WR)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_challenge_2020_01_05 : EventTest
    {
        [Test]
        public void Deck01_LillHalonen_Bogles_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",0),
                "LastOkoDays",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Elnitzo_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",1),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck03_exoticherman_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",2),
                "LastOkoDays",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck04_austinflakesss_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",3),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck05_lan213_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",4),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck06_llawtonss_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",5),
                "LastOkoDays",
                ArchetypeColor.UG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck07_rksgsn_Burn_R()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",6),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck08_SamcasterMage_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",7),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck09_CraigMack378_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",8),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck10_failbotover9000_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",9),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_xfile_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",10),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck12_JHF_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",11),
                "LastOkoDays",
                ArchetypeColor.UG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck13_mindcandy_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",12),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck14_GodOfSlaughter_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",13),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_VTCLA_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",14),
                "LastOkoDays",
                ArchetypeColor.UG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck16_yPrincipe_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",15),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck17_SoulStrong_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",16),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck18_NuBlkAu_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",17),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck19_AndreasMueller_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",18),
                "LastOkoDays",
                ArchetypeColor.UG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck20_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",19),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck21_bradyoo_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",20),
                "LastOkoDays",
                ArchetypeColor.UG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck22_cityofcards_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",21),
                "LastOkoDays",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Kazuga_PrimevalTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",22),
                "LastOkoDays",
                ArchetypeColor.WG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck24_ZackyChan_UrzaOko_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",23),
                "LastOkoDays",
                ArchetypeColor.URG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck25_RicardoMSLan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",24),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck26_Szelma_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",25),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck27_fradev1988_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",26),
                "LastOkoDays",
                ArchetypeColor.UR,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck28_CHILLEDADED_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",27),
                "LastOkoDays",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck29_CarlSwaggin_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",28),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck30_MGGX_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",29),
                "LastOkoDays",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck31_yamakiller_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",30),
                "LastOkoDays",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck32_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-01-05",31),
                "LastOkoDays",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }


    }
}
