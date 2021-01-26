using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 McWinSauce: WURG Control (WURG)
#02 Draccon136: Bogles (WG, Lurrus)
#03 Jaberwocki: Jund Midrange (BRG)
#04 lordavery: Bant Midrange (WUG)
#05 Mcleskey: Obosh Aggro (R, Obosh)
#06 TheMelkMan: Eldrazi Tron (C)
#07 Bohnz: WURG Control (WURG)
#08 Rav104: Oops All Spells (WUBRG)
#09 timewalkinonsunshine: Taking Turns (URG)
#10 wambocombo2020: Shadow Prowess (WBR, Lurrus)
#11 Clockwork Dean: Mono White Taxes (W)
#12 yamakiller: Reclaimer Titan (WRG)
#13 ziofrancone: Elementals (WUBRG)
#14 maikage: Belcher (RG)
#15 karatedom: Crabvine (UBG)
#16 AbelMolto: Burn (WRG)
#17 Gobern: Niv To Light (WUBRG, Yorion)
#18 tibalt_of_red_sub: Mill (UB, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_09 : EventTest
    {
        [Test]
        public void Deck01_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",0),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Draccon136_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",1),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Jaberwocki_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",2),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_lordavery_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",3),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Mcleskey_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",4),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_TheMelkMan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",5),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_Bohnz_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",6),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Rav104_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",7),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck09_timewalkinonsunshine_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",8),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "TakingTurns",
                null,
                null
            );
        }

        [Test]
        public void Deck10_wambocombo2020_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",9),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_ClockworkDean_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",10),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck12_yamakiller_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",11),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck13_ziofrancone_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",12),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Elementals",
                null,
                null
            );
        }

        [Test]
        public void Deck14_maikage_Belcher_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",13),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck15_karatedom_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",14),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck16_AbelMolto_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",15),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck17_Gobern_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",16),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_tibaltofredsub_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",17),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
