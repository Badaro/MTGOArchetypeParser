using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest_modern_preliminary_2020_07_10 : EventTest
    {
        [Test]
        public void Deck01_Gigy_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_07_10.Deck01_Gigy_Ponza_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck02_sffmtg_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_07_10.Deck02_sffmtg_GTron_KGCTron_G(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                null
            );
        }

        [Test]
        public void Deck03_J000111_Dredge_WBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_07_10.Deck03_J000111_Dredge_WBRG(),
                ArchetypeColor.WBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_WanderingOnes_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_07_10.Deck04_WanderingOnes_GTron_KGCTron_G(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                null
            );
        }

        [Test]
        public void Deck05_Janh_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_07_10.Deck05_Janh_SnowControl_SnowShift_URG_Yorion(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_HouseOfManaMTG_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_07_10.Deck06_HouseOfManaMTG_PrimevalTitan_AmuletTitan_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_katoriarch123_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_07_10.Deck07_katoriarch123_SnowControl_WUG(),
                ArchetypeColor.WUG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Engelsdorfer_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_07_10.Deck08_Engelsdorfer_DeathsShadow_GrixisShadow_UBR(),
                ArchetypeColor.UBR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.DeathsShadow),
                typeof(MTGOArchetypeParser.Archetypes.Modern.GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck09_zumekun19850204_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_07_10.Deck09_zumekun19850204_SnowControl_SultaiSnow_UBG(),
                ArchetypeColor.UBG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                typeof(MTGOArchetypeParser.Archetypes.Modern.SultaiSnow),
                null
            );
        }


    }
}
