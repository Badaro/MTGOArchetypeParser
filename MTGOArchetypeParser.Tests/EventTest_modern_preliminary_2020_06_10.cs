using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest_modern_preliminary_2020_06_10 : EventTest
    {
        [Test]
        public void Deck01_signblindman_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10.Deck01_signblindman_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck02_GedionRavenor_SnowControl_SnowBlade_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10.Deck02_GedionRavenor_SnowControl_SnowBlade_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowBlade),
                null
            );
        }

        [Test]
        public void Deck03_Shatun_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10.Deck03_Shatun_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck04_TSPJendrek_SnowControl_SnowBlade_WUBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10.Deck04_TSPJendrek_SnowControl_SnowBlade_WUBG(),
                ArchetypeColor.WUBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowBlade),
                null
            );
        }

        [Test]
        public void Deck05_Janh_SnowControl_TemurSnow_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10.Deck05_Janh_SnowControl_TemurSnow_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TemurSnow),
                null
            );
        }

        [Test]
        public void Deck06_INF_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10.Deck06_INF_GiftsStorm_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck07_alemilan19_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10.Deck07_alemilan19_SnowControl_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_FabriceK_NinjaFaeries_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10.Deck08_FabriceK_NinjaFaeries_UB(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.NinjaFaeries),
                null,
                null
            );
        }

        [Test]
        public void Deck09_DylanGregory_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10.Deck09_DylanGregory_Humans_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Mcleskey_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10.Deck10_Mcleskey_Burn_WR(),
                ArchetypeColor.WR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck11_DavidDPanda_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10.Deck11_DavidDPanda_ETron_C(),
                ArchetypeColor.C,
                typeof(MTGOArchetypeParser.Archetypes.Modern.ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck12_ZYURYO_SnowControl_WUBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_10.Deck12_ZYURYO_SnowControl_WUBG(),
                ArchetypeColor.WUBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }


    }
}
