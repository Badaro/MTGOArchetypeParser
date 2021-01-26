using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 kanister: Urza Oko (UG)
#02 harukispecial: Jeskai Control (WUR)
#03 rarehunter13: Bant Midrange (WUG)
#04 shadow_PT: Burn (R)
#05 MentalMisstep: Urza Oko (UBG)
#06 Numena_Lowallyn: Eldrazi Tron (G)
#07 McWinSauce: Bant Control (WUG)
#08 helvetti: Primeval Titan (WG)
#09 FREEROLLIN: Urza Oko (UBG)
#10 Boland: Grixis Shadow (UBR)
#11 rdoe14: Jund Midrange (BRG)
#12 iDaveW: Infect (UG)
#13 stonepeanut: Crabvine (UBG)
#14 WangoTango73: Azorius Taxes (WU)
#15 Tyerube1618: Green Tron (G)
#16 ZYURYO: WURG Control (WURG)
#17 JustBurn420: Slivers (WUBRG)
#18 nano_indentertion: Mill (UBG)
#19 SoulStrong: Urza Oko (UBG)
#20 darkpoetbill: UBRG Shadow (UBRG)
#21 Albimtg: UBRG Shadow (UBRG)
#22 lwdgg: Primeval Titan (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2020_01_02 : EventTest
    {
        [Test]
        public void Deck01_kanister_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",0),
                "LastOkoDays",
                ArchetypeColor.UG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck02_harukispecial_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",1),
                "LastOkoDays",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_rarehunter13_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",2),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_shadowPT_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",3),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck05_MentalMisstep_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",4),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck06_NumenaLowallyn_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",5),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",6),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_helvetti_PrimevalTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",7),
                "LastOkoDays",
                ArchetypeColor.WG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck09_FREEROLLIN_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",8),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Boland_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",9),
                "LastOkoDays",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck11_rdoe14_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",10),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck12_iDaveW_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",11),
                "LastOkoDays",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck13_stonepeanut_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",12),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck14_WangoTango73_AzoriusTaxes_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",13),
                "LastOkoDays",
                ArchetypeColor.WU,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Tyerube1618_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",14),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck16_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",15),
                "LastOkoDays",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck17_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",16),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck18_nanoindentertion_Mill_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",17),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck19_SoulStrong_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",18),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck20_darkpoetbill_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",19),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Albimtg_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",20),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck22_lwdgg_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",21),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }


    }
}
