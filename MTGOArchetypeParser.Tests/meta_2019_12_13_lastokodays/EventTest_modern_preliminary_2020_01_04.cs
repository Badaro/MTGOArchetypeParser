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
#01 xfile: Eldrazi Tron (G)
#02 MentalMisstep: Simic Control (UG)
#03 fried-liver-attack: Eldrazi Tron (C)
#04 122pablo: Ascendancy Combo (WURG)
#05 penips: Orzhov Taxes (WB)
#06 Wolvenjoe1984: Thopter Urza (UBG)
#07 Volcano666: Crabvine (UBG)
#08 Coly2: Mono Red Prowess (R)
#09 JustBurn420: Slivers (WUBRG)
#10 Sanchez5272: Mono Red Prowess (R)
#11 sandydogmtg: Burn (R)
#12 Oderus Urungus: Burn (R)
#13 tangrams: Primeval Titan (UG)
#14 Theo_Jung: Eldrazi Tron (C)
#15 TheYostWithTheMost: Simic Control (UG)
#16 qbturtle15: Gruul Midrange (RG)
#17 fistfullofmetal: Green Tron (G)
#18 SourceOdin: Simic Control (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2020_01_04 : EventTest
    {
        [Test]
        public void Deck01_xfile_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",0),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_MentalMisstep_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",1),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck03_friedliverattack_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",2),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck04_122pablo_AscendancyCombo_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",3),
                new LastOkoDays(),
                ArchetypeColor.WURG,
                typeof(AscendancyCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck05_penips_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",4),
                new LastOkoDays(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Wolvenjoe1984_ThopterUrza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",5),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck07_Volcano666_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",6),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Coly2_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",7),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",8),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Sanchez5272_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",9),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck11_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",10),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck12_OderusUrungus_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",11),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck13_tangrams_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",12),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck14_TheoJung_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",13),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck15_TheYostWithTheMost_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",14),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck16_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",15),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_fistfullofmetal_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",16),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck18_SourceOdin_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-04",17),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }


    }
}
