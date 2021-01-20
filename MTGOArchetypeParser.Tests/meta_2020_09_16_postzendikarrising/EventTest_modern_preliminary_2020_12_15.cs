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
#01 ConnorM426: Reclaimer Titan (WRG)
#02 Blitzlion27: Mill (UB, Lurrus)
#03 k1113r0b0t: Izzet Prowess (UR)
#04 UnderwaterBimbo: Delver (UR)
#05 Predicted: Yawgmoth (WBG)
#06 BSK_hercules: Temur Control (URG)
#07 kanister: Primeval Titan (UG)
#08 Do0mSwitch: WURG Control (WURG)
#09 Lukas261997: WURG Control (WURG)
#10 MZBlazer: Reclaimer Titan (WRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_15 : EventTest
    {
        [Test]
        public void Deck01_ConnorM426_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-15",0),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck02_Blitzlion27_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-15",1),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_k1113r0b0t_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-15",2),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck04_UnderwaterBimbo_Delver_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-15",3),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(Delver),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Predicted_Yawgmoth_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-15",4),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck06_BSKhercules_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-15",5),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_kanister_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-15",6),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Do0mSwitch_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-15",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Lukas261997_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-15",8),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_MZBlazer_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-15",9),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }


    }
}
