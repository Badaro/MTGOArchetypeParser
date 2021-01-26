using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 remf: Spirits (WU)
#02 dm95: WURG Control (WURG)
#03 B1gDan: Shadow Prowess (BR, Lurrus)
#04 MaxMagicer: Humans (WUBRG)
#05 sokos13: Infect (UG)
#06 Mateusf34: Eldrazi Tron (C)
#07 Mazzu93: Izzet Prowess (UR)
#08 daibloXSC: Grinding Breach (WUR)
#09 Tixis: Omnath Saheeli (WURG, Yorion)
#10 kanister: Izzet Prowess (UR)
#11 Blitzlion27: Mill (UB, Lurrus)
#12 ACG88: Spirits (WU)
#13 kiko: Azorius Taxes (WU, Yorion)
#14 musasabi: Mardu Midrange (WBR)
#15 KarmageTSH: Green Tron (G)
#16 mariogomes097: Esper Shadow (WUB)
#17 __BMJ__: Shadow Prowess (BR, Lurrus)
#18 Binolino: Reclaimer Titan (WRG)
#19 Nastier: Rakdos Midrange (BR)
#20 N3to: Gifts Storm (UR)
#21 Laplasjan: Hammer Time (WB, Lurrus)
#22 ZYURYO: WURG Control (WURG)
#23 bubbsei: Shadow Prowess (BR, Lurrus)
#24 penips: Mono White Taxes (W)
#25 unicornparadise: Hammer Time (WB, Lurrus)
#26 alemilan19: Reclamation (UBG)
#27 paucr5: Hammer Time (WB, Lurrus)
#28 wild88plk: Reclaimer Titan (WRG)
#29 Never_DidntHaveIt: Eight Whack (R)
#30 OtherWhiteStuff: Rakdos Prowess (BR, Lurrus)
#31 Pintogeddon2: Humans (WUBRG)
#32 fgfonseca182: Rakdos Midrange (BR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2021_01_21 : EventTest
    {
        [Test]
        public void Deck01_remf_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",0),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck02_dm95_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_B1gDan_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",2),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_MaxMagicer_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",3),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck05_sokos13_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",4),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",5),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_Mazzu93_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",6),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck08_daibloXSC_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",7),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Tixis_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",8),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck10_kanister_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",9),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck11_Blitzlion27_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",10),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_ACG88_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",11),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck13_kiko_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",12),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Taxes",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck14_musasabi_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",13),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_KarmageTSH_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",14),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck16_mariogomes097_EsperShadow_WUB()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",15),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck17_BMJ_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",16),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Binolino_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",17),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck19_Nastier_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",18),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck20_N3to_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",19),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Laplasjan_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",20),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",21),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_bubbsei_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",22),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",23),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck25_unicornparadise_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",24),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_alemilan19_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",25),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck27_paucr5_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",26),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_wild88plk_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",27),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck29_NeverDidntHaveIt_EightWhack_R()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",28),
                "PostZendikarRising",
                ArchetypeColor.R,
                "EightWhack",
                null,
                null
            );
        }

        [Test]
        public void Deck30_OtherWhiteStuff_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",29),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_Pintogeddon2_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",30),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck32_fgfonseca182_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-21",31),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
