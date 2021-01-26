using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Bullz0Eye: Eldrazi Tron (C)
#02 Zar0s: Urza Oko (WUG)
#03 SoulStrong: UBRG Shadow (UBRG)
#04 btail08: Green Tron (G)
#05 gyyby297: Thopter Urza (UBG)
#06 Phill_Hellmuth: Primeval Titan (UG)
#07 painhuman: Eldrazi Tron (G)
#08 Irra0770: Jund Midrange (BRG)
#09 Laplasjan: Eldrazi Tron (C)
#10 JOXEMI333: Green Tron (G)
#11 V_Olkhovikov: Orzhov Eldrazi Taxes (WB)
#12 phyrexianphenom3: Infect (UG)
#13 ssnelson: UBRG Shadow (UBRG)
#14 iDaveW: Infect (UG)
#15 Ramp: Gifts Storm (UR)
#16 katoriarch123: Urza Oko (UBG)
#17 Dborges7: Urza Oko (UG)
#18 LillHalonen: Bogles (WG)
#19 ACG88: Affinity (R)
#20 LyaApocalypse: Green Tron (G)
#21 RogerSteady: Grixis Control (UBR)
#22 adrianretamosa: Eldrazi Tron (C)
#23 Zanman: Niv To Light (WUBRG)
#24 Albimtg: UBRG Shadow (UBRG)
#25 leclairandy: Temur Midrange (URG)
#26 genkytoro: Jund Midrange (BRG)
#27 crazeejakee07: Bant Midrange (WUG)
#28 AlexCarbajal: Eldrazi Tron (C)
#29 RicardoMSLan: Eldrazi Tron (C)
#30 NuBlkAu: UBRG Shadow (UBRG)
#31 GodOfSlaughter: Amulet Titan (UG)
#32 MadKat: Elementals (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_challenge_2019_12_29 : EventTest
    {
        [Test]
        public void Deck01_Bullz0Eye_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",0),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck02_Zar0s_UrzaOko_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",1),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck03_SoulStrong_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",2),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck04_btail08_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",3),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck05_gyyby297_ThopterUrza_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",4),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck06_PhillHellmuth_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",5),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck07_painhuman_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",6),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_Irra0770_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",7),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Laplasjan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",8),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck10_JOXEMI333_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",9),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck11_VOlkhovikov_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",10),
                "LastOkoDays",
                ArchetypeColor.WB,
                "Taxes",
                "EldraziTaxes",
                null
            );
        }

        [Test]
        public void Deck12_phyrexianphenom3_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",11),
                "LastOkoDays",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck13_ssnelson_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",12),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck14_iDaveW_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",13),
                "LastOkoDays",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Ramp_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",14),
                "LastOkoDays",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck16_katoriarch123_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",15),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Dborges7_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",16),
                "LastOkoDays",
                ArchetypeColor.UG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck18_LillHalonen_Bogles_WG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",17),
                "LastOkoDays",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck19_ACG88_Affinity_R()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",18),
                "LastOkoDays",
                ArchetypeColor.R,
                "Affinity",
                null,
                null
            );
        }

        [Test]
        public void Deck20_LyaApocalypse_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",19),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck21_RogerSteady_GrixisControl_UBR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",20),
                "LastOkoDays",
                ArchetypeColor.UBR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck22_adrianretamosa_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",21),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck23_Zanman_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",22),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck24_Albimtg_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",23),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck25_leclairandy_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",24),
                "LastOkoDays",
                ArchetypeColor.URG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck26_genkytoro_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",25),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck27_crazeejakee07_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",26),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck28_AlexCarbajal_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",27),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck29_RicardoMSLan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",28),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck30_NuBlkAu_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",29),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck31_GodOfSlaughter_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",30),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck32_MadKat_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",31),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "Elementals",
                null,
                null
            );
        }


    }
}
