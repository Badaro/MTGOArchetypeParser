using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class LeagueTest_Modern_2020_06_05 : LeagueTest
    {
        [Test]
        public void Deck01_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck01_Prowess_R(),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Prowess)
            );
        }

        [Test]
        public void Deck02_Devoted_WG_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck02_Devoted_WG_Lurrus(),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck03_Ponza_RG(),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza)
            );
        }

        [Test]
        public void Deck04_Inverter_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck04_Inverter_UB(),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Inverter)
            );
        }

        [Test]
        public void Deck05_Scales_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck05_Scales_G(),
                typeof(MTGOArchetypeParser.Archetypes.Modern.HardenedScales)
            );
        }

        [Test]
        public void Deck06_Shadow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck06_Shadow_UBRG(),
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.TraverseShadow)
            );
        }

        [Test]
        public void Deck07_NivToLight_WUBRG_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck07_NivToLight_WUBRG_Jegantha(),
                typeof(MTGOArchetypeParser.Archetypes.Modern.BringToNiv),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck08_GiftsStorm_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck08_GiftsStorm_URG(),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm)
            );
        }

        [Test]
        public void Deck09_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck09_Dredge_BRG(),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge)
            );
        }

        [Test]
        public void Deck10_SnowControl_WUG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck10_SnowControl_WUG_Yorion(),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_Shadow_UBR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck11_Shadow_UBR_Lurrus(),
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisShadow),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Devoted_WGB_Heliod()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck18_Devoted_WGB_Heliod_Yorion(),
                typeof(MTGOArchetypeParser.Archetypes.Modern.Devoted),
                typeof(MTGOArchetypeParser.Archetypes.Modern.HeliodDevoted),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck37_Tron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_league_2020_06_05.Deck37_Tron_G_Jegantha(),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                null,
                ArchetypeCompanion.Jegantha
            );
        }
    }
}
