using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_04 : EventTest
    {
        [Test]
        public void Deck01_lilianaofthevess_SongStorm_URG_Jegantha()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_04.Deck01_lilianaofthevess_SongStorm_URG_Jegantha(),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SongStorm),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck02_ZYURYO_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_04.Deck02_ZYURYO_SnowControl_WUG(),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_ManuelJacob_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_04.Deck03_ManuelJacob_SnowControl_SultaiSnow_UBG(),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck04_INF_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_04.Deck04_INF_GiftsStorm_UR(),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck05_bnlunt_UTron_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_04.Deck05_bnlunt_UTron_UB(),
                new PostM21(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck06_nielsen333_PrimevalTitan_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_04.Deck06_nielsen333_PrimevalTitan_BRG(),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Laessoe_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_04.Deck07_Laessoe_Ponza_RG(),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck08_siomomi_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_04.Deck08_siomomi_GTron_KGCTron_G(),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck09_triosk_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_04.Deck09_triosk_Goblins_SnoopGoblins_BR(),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck10_cjucjujp_BushwhackerZoo_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_04.Deck10_cjucjujp_BushwhackerZoo_RG(),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }


    }
}
