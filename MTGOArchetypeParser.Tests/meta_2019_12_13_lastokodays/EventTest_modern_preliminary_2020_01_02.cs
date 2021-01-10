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
#01 kanister: Urza Oko (UG)
#02 harukispecial: Jeskai Control (WUR)
#03 rarehunter13: Bant Midrange (WUG)
#04 shadow_PT: Burn (R)
#05 MentalMisstep: Urza Oko (UG)
#06 Numena_Lowallyn: Eldrazi Tron (C)
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
#19 SoulStrong: Urza Oko (UG)
#20 darkpoetbill: Sultai Shadow (UBG)
#21 Albimtg: Sultai Shadow (UBG)
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
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck02_harukispecial_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",1),
                new LastOkoDays(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_rarehunter13_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",2),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_shadowPT_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",3),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck05_MentalMisstep_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",4),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck06_NumenaLowallyn_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",5),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",6),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_helvetti_PrimevalTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",7),
                new LastOkoDays(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck09_FREEROLLIN_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",8),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Boland_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",9),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck11_rdoe14_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",10),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_iDaveW_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",11),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck13_stonepeanut_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",12),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck14_WangoTango73_AzoriusTaxes_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",13),
                new LastOkoDays(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Tyerube1618_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",14),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck16_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",15),
                new LastOkoDays(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",16),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck18_nanoindentertion_Mill_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",17),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck19_SoulStrong_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",18),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck20_darkpoetbill_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",19),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Albimtg_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",20),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck22_lwdgg_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-02",21),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }


    }
}
