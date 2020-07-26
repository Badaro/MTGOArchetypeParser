using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_26_postm21
{
    public class EventTest_modern_preliminary_2020_07_10 : EventTest
    {
        [Test]
        public void Deck01_Gigy_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_preliminary_2020_07_10.Deck01_Gigy_Ponza_RG(),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck02_sffmtg_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_preliminary_2020_07_10.Deck02_sffmtg_GTron_KGCTron_G(),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck03_J000111_Dredge_WBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_preliminary_2020_07_10.Deck03_J000111_Dredge_WBRG(),
                new PostM21(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_WanderingOnes_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_preliminary_2020_07_10.Deck04_WanderingOnes_GTron_KGCTron_G(),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck05_Janh_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_preliminary_2020_07_10.Deck05_Janh_SnowControl_SnowShift_URG_Yorion(),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_HouseOfManaMTG_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_preliminary_2020_07_10.Deck06_HouseOfManaMTG_PrimevalTitan_AmuletTitan_WUBRG(),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_katoriarch123_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_preliminary_2020_07_10.Deck07_katoriarch123_SnowControl_WUG(),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Engelsdorfer_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_preliminary_2020_07_10.Deck08_Engelsdorfer_DeathsShadow_GrixisShadow_UBR(),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck09_zumekun19850204_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_26_postm21.modern_preliminary_2020_07_10.Deck09_zumekun19850204_SnowControl_SultaiSnow_UBG(),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }


    }
}
