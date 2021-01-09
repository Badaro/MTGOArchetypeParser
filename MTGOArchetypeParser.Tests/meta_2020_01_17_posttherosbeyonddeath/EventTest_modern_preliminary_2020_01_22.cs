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
#01 shadow_PT: Azorius Control (WU)
#02 G0NZO: Amulet Titan (RG)
#03 RicardoMSLan: Naya Midrange (WRG)
#04 McWinSauce: Bant Control (WUG)
#05 _Shatun_: Mono Red Prowess (R)
#06 Irra0770: Jund Midrange (BRG)
#07 emorton13: Spirits (WU)
#08 Mogged: Mono Red Prowess (R)
#09 Rinko: Goryo Reanimator (BRG)
#10 heqingbai2019: Titan Shift (RG)
#11 Erik157751: Crabvine (UBG)
#12 joker10289: Azorius Control (WU)
#13 SoulStrong: Amulet Titan (UG)
#14 JustBurn420: Slivers (WUBRG)
#15 Bugsy69: Dredge (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_01_22 : EventTest
    {
        [Test]
        public void Deck01_shadowPT_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_G0NZO_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck03_RicardoMSLan_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Irra0770_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_emorton13_Spirits_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Mogged_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Rinko_GoryoReanimator_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GoryoReanimator),
                null,
                null
            );
        }

        [Test]
        public void Deck10_heqingbai2019_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck11_Erik157751_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck12_joker10289_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_SoulStrong_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck14_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Bugsy69_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }


    }
}
