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
    public class EventTest_modern_preliminary_2020_07_08 : EventTest
    {
        [Test]
        public void Deck01_Janh_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_08.Deck01_Janh_SnowControl_SnowShift_URG_Yorion(),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_medvedev_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_08.Deck02_medvedev_ETron_C(),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck03_otakkun_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_08.Deck03_otakkun_GTron_KGCTron_G(),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck04_fistfullofmetal_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_08.Deck04_fistfullofmetal_ETron_C(),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck05_sffmtg_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_08.Deck05_sffmtg_GTron_KGCTron_G(),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck06_PRGJJAR_Dredge_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_08.Deck06_PRGJJAR_Dredge_BRG(),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck07_ZYURYO_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_08.Deck07_ZYURYO_SnowControl_WUG(),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_spellvine_Prowess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_08.Deck08_spellvine_Prowess_UR(),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_WanderingOnes_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_06_25_postm21.modern_preliminary_2020_07_08.Deck09_WanderingOnes_GTron_KGCTron_G(),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }


    }
}
