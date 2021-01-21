using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Atticuslol: Amulet Titan (URG)
#02 AshawXL: Burn (WR)
#03 _Antoniou_: Orzhov Shadow (WB)
#04 sydneydude: Naya Midrange (WRG)
#05 audio336: Bant Control (WUG)
#06 JustBurn420: Slivers (WUBRG)
#07 joetru: Niv To Light (WUBRG, Jegantha)
#08 dejoyjoe: Uroza (URG)
#09 Aluren85: Dredge (UBRG)
#10 Capitano_CL: Dredge (UBRG)
#11 AlerionONE: Niv To Light (WUBRG)
#12 PRGJJAR: Dredge (BRG)
#13 coert: Burn (WR)
#14 signblindman: Naya Midrange (WRG)
#15 Parrit: Orzhov Taxes (WB)
#16 Mistakenn: Amulet Titan (UG)
#17 LORiWWA: Eldrazi Tron (C)
#18 Dafne17: Naya Midrange (WRG)
#19 uwata: Devoted (WG)
#20 gyyby297: Thopter Urza (UB)
#21 ACG88: Primeval Titan (BG)
#22 Maccaciock: Mono Red Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_04_18 : EventTest
    {
        [Test]
        public void Deck01_Atticuslol_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",0),
                "PostIkoria",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck02_AshawXL_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",1),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck03_Antoniou_OrzhovShadow_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",2),
                "PostIkoria",
                ArchetypeColor.WB,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck04_sydneydude_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",3),
                "PostIkoria",
                ArchetypeColor.WRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_audio336_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",4),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",5),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck07_joetru_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",6),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck08_dejoyjoe_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",7),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Aluren85_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",8),
                "PostIkoria",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck10_CapitanoCL_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",9),
                "PostIkoria",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck11_AlerionONE_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",10),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck12_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",11),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck13_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",12),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck14_signblindman_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",13),
                "PostIkoria",
                ArchetypeColor.WRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Parrit_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",14),
                "PostIkoria",
                ArchetypeColor.WB,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Mistakenn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",15),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck17_LORiWWA_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",16),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck18_Dafne17_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",17),
                "PostIkoria",
                ArchetypeColor.WRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck19_uwata_Devoted_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",18),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck20_gyyby297_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",19),
                "PostIkoria",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck21_ACG88_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",20),
                "PostIkoria",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Maccaciock_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-18",21),
                "PostIkoria",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
