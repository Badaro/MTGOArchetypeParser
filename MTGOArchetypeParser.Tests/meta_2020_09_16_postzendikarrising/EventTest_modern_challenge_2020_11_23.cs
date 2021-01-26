using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 billster47: Hammer Time (W, Lurrus)
#02 McWinSauce: WURG Control (WURG)
#03 kiko: Azorius Taxes (WU, Yorion)
#04 Sodeq: Belcher (URG)
#05 mariogomes097: Grixis Shadow (UBR)
#06 Samlg01: Amulet Titan (RG)
#07 pokerswizard: Shadow Prowess (BR, Lurrus)
#08 SvenSveeterSven: Mardu Midrange (WBR)
#09 ZYURYO: Temur Control (URG)
#10 Better_than_Average: Obosh Aggro (R, Obosh)
#11 KamiTech: Electro End (UR)
#12 Trellon: Blue Tron (UR)
#13 NorrathDecay: Eldrazi Tron (C)
#14 Kurusu: Kiki Chord (WRG, Yorion)
#15 RespectTheCat: Rakdos Midrange (BR)
#16 Binolino: Reclaimer Titan (WRG)
#17 patheus_84: Ad Nauseam (WUB)
#18 Darkiundsa: Esper Control (WUB)
#19 nazart: Heliod Combo (WRG)
#20 ACG88: Green Tron (G)
#21 musasabi: Shadow Prowess (BR, Lurrus)
#22 Filyoni: Heliod Combo (WRG)
#23 MrRaeb: UBRG Control (UBRG)
#24 FriskiFraska: Reclaimer Titan (WRG)
#25 _Batutinha_: Reclaimer Titan (WUG)
#26 Parrit: Mono White Taxes (W)
#27 jmeyer2030: Obosh Aggro (R, Obosh)
#28 Rinko: Enduring Ideal (WR)
#29 Aluren85: Mono White Taxes (W)
#30 ArchaeusDota: Esper Control (WUB)
#31 PRGJJAR: Dredge (BRG)
#32 coomback: Mill (UB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_11_23 : EventTest
    {
        [Test]
        public void Deck01_billster47_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",0),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_kiko_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",2),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Taxes",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Sodeq_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",3),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck05_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",4),
                "PostZendikarRising",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Samlg01_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",5),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck07_pokerswizard_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",6),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_SvenSveeterSven_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",7),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_ZYURYO_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",8),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_BetterthanAverage_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",9),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck11_KamiTech_ElectroEnd_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",10),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "FreeSpells",
                "ElectroEnd",
                null
            );
        }

        [Test]
        public void Deck12_Trellon_BlueTron_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",11),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "Tron",
                "BlueTron",
                null
            );
        }

        [Test]
        public void Deck13_NorrathDecay_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",12),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck14_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",13),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "KikiChord",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_RespectTheCat_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",14),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Binolino_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",15),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck17_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",16),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Darkiundsa_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",17),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck19_nazart_HeliodCombo_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",18),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck20_ACG88_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",19),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck21_musasabi_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",20),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_Filyoni_HeliodCombo_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",21),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck23_MrRaeb_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",22),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck24_FriskiFraska_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",23),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck25_Batutinha_ReclaimerTitan_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",24),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck26_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",25),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck27_jmeyer2030_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",26),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck28_Rinko_EnduringIdeal_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",27),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "EnduringIdeal",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Aluren85_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",28),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck30_ArchaeusDota_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",29),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck31_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",30),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck32_coomback_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",31),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                null
            );
        }


    }
}
