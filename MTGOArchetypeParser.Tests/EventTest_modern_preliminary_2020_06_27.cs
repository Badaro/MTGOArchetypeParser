using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests
{
    public class EventTest_modern_preliminary_2020_06_27 : EventTest
    {
        [Test]
        public void Deck01_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27.Deck01_PrimevalTitan_KGCAmuletTitan_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.PrimevalTitan),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27.Deck02_GTron_KGCTron_G(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                null
            );
        }

        [Test]
        public void Deck03_Urza_ThopterUrza_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27.Deck03_Urza_ThopterUrza_UB(),
                ArchetypeColor.UB,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Urza),
                typeof(MTGOArchetypeParser.Archetypes.Modern.ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck04_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27.Deck04_GTron_KGCTron_G(),
                ArchetypeColor.G,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GTron),
                typeof(MTGOArchetypeParser.Archetypes.Modern.KGCTron),
                null
            );
        }

        [Test]
        public void Deck05_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27.Deck05_GiftsStorm_UR(),
                ArchetypeColor.UR,
                typeof(MTGOArchetypeParser.Archetypes.Modern.GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck06_SnowControl_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27.Deck06_SnowControl_URG(),
                ArchetypeColor.URG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27.Deck07_Humans_WUBRG(),
                ArchetypeColor.WUBRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Winota_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27.Deck08_Winota_WRG(),
                ArchetypeColor.WRG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.Winota),
                null,
                null
            );
        }

        [Test]
        public void Deck09_EightWhack_AtarkaWhack_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.modern_preliminary_2020_06_27.Deck09_EightWhack_AtarkaWhack_RG(),
                ArchetypeColor.RG,
                typeof(MTGOArchetypeParser.Archetypes.Modern.EightWhack),
                typeof(MTGOArchetypeParser.Archetypes.Modern.AtarkaWhack),
                null
            );
        }


    }
}
