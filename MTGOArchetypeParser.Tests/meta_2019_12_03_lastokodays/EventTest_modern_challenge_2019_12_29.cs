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
#01 Bullz0Eye: Eldrazi Tron (C)
#02 Zar0s: Simic Control (UG)
#03 SoulStrong: Sultai Shadow (UBG)
#04 btail08: Green Tron (G)
#05 gyyby297: Thopter Urza (UG)
#06 Phill_Hellmuth: Primeval Titan (UG)
#07 painhuman: Eldrazi Tron (G)
#08 Irra0770: Jund Midrange (BRG)
#09 Laplasjan: Eldrazi Tron (C)
#10 JOXEMI333: Green Tron (G)
#11 V_Olkhovikov: Orzhov Taxes (WB)
#12 phyrexianphenom3: Infect (UG)
#13 ssnelson: Sultai Shadow (UBG)
#14 iDaveW: Infect (UG)
#15 Ramp: Gifts Storm (UR)
#16 katoriarch123: Sultai Control (UBG)
#17 Dborges7: Simic Control (UG)
#18 LillHalonen: Bogles (WG)
#19 ACG88: Affinity (C)
#20 LyaApocalypse: Green Tron (G)
#21 RogerSteady: Grixis Control (UBR)
#22 adrianretamosa: Eldrazi Tron (C)
#23 Zanman: Niv To Light (WUBRG)
#24 Albimtg: Sultai Shadow (UBG)
#25 leclairandy: Temur Midrange (URG)
#26 genkytoro: Jund Midrange (BRG)
#27 crazeejakee07: Bant Midrange (WUG)
#28 AlexCarbajal: Eldrazi Tron (C)
#29 RicardoMSLan: Eldrazi Tron (C)
#30 NuBlkAu: Sultai Shadow (UBG)
#31 GodOfSlaughter: Amulet Titan (UG)
#32 MadKat: Elementals (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_03_lastokodays
{
    public class EventTest_modern_challenge_2019_12_29 : EventTest
    {
        [Test]
        public void Deck01_Bullz0Eye_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",0),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_Zar0s_SimicControl_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",1),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_SoulStrong_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",2),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck04_btail08_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",3),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck05_gyyby297_ThopterUrza_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",4),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck06_PhillHellmuth_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",5),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck07_painhuman_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",6),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck08_Irra0770_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",7),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Laplasjan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",8),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck10_JOXEMI333_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",9),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck11_VOlkhovikov_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",10),
                new LastOkoDays(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck12_phyrexianphenom3_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",11),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck13_ssnelson_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",12),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck14_iDaveW_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",13),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Ramp_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",14),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck16_katoriarch123_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",15),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Dborges7_SimicControl_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",16),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_LillHalonen_Bogles_WG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",17),
                new LastOkoDays(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck19_ACG88_Affinity_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",18),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Affinity),
                null,
                null
            );
        }

        [Test]
        public void Deck20_LyaApocalypse_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",19),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck21_RogerSteady_GrixisControl_UBR()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",20),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_adrianretamosa_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",21),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck23_Zanman_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",22),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Albimtg_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",23),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck25_leclairandy_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",24),
                new LastOkoDays(),
                ArchetypeColor.URG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_genkytoro_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",25),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck27_crazeejakee07_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",26),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_AlexCarbajal_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",27),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck29_RicardoMSLan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",28),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck30_NuBlkAu_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",29),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck31_GodOfSlaughter_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",30),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck32_MadKat_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2019-12-29",31),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }


    }
}
