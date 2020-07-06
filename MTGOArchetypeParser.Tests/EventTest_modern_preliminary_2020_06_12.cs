using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest_modern_preliminary_2020_06_12 : EventTest
    {
        [Test]
        public void Deck01_ravensfan52720_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck01_ravensfan52720_Humans_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck02_billsive_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck02_billsive_SnowControl_SnowTitan_WUG_Yorion(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_WebZone_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck03_WebZone_Humans_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck04_PeanutBrittle_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck04_PeanutBrittle_GiftsStorm_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck05_ecobaronen_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck05_ecobaronen_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck06_madechai_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck06_madechai_Prowess_R(),
                ArchetypeColor.R,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck07_brunocaleb_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck07_brunocaleb_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck08_TheTunnelingCat_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck08_TheTunnelingCat_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck09_PRGJJAR_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck09_PRGJJAR_Dredge_BRG(),
                ArchetypeColor.BRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_staples87_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck10_staples87_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck11_benjamin13_PrimevalTitan_TitanShift_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck11_benjamin13_PrimevalTitan_TitanShift_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TitanShift),
                null
            );
        }

        [Test]
        public void Deck12_SonicSmasher_SnowControl_SnowBlade_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck12_SonicSmasher_SnowControl_SnowBlade_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowBlade),
                null
            );
        }

        [Test]
        public void Deck13_ilmatagatto_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck13_ilmatagatto_Burn_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Misplacedginger_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck14_Misplacedginger_SnowControl_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_BSKhercules_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck15_BSKhercules_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck16_lovealienzzz_SnowControl_TemurSnow_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck16_lovealienzzz_SnowControl_TemurSnow_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TemurSnow),
                null
            );
        }

        [Test]
        public void Deck17_yamakiller_SnowControl_SnowReclamation_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck17_yamakiller_SnowControl_SnowReclamation_URG_Yorion(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_PieGonti_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_12.Deck18_PieGonti_Humans_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }


    }
}
