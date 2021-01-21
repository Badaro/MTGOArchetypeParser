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
#01 yamakiller: Burn (WR)
#02 Simpleliquid: Spirits (WU)
#03 cntrlfreak: Shadow Prowess (BR, Lurrus)
#04 ElectricBob: Rakdos Midrange (BR)
#05 cariollins: Shadow Prowess (BR, Lurrus)
#06 HouseOfManaMTG: Amulet Titan (G)
#07 aplapp: Heliod Combo (WG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_21 : EventTest
    {
        [Test]
        public void Deck01_yamakiller_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-21",0),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck02_Simpleliquid_Spirits_WU()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-21",1),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck03_cntrlfreak_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-21",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_ElectricBob_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-21",3),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_cariollins_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-21",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_HouseOfManaMTG_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-21",5),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_aplapp_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-21",6),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }


    }
}
