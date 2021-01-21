using FluentAssertions;
using MTGOArchetypeParser.Model;
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
#15 Bugsy69: Dredge (UBRG)
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
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_G0NZO_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck03_RicardoMSLan_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.WRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck06_Irra0770_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_emorton13_Spirits_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Mogged_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck09_Rinko_GoryoReanimator_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GoryoReanimator",
                null,
                null
            );
        }

        [Test]
        public void Deck10_heqingbai2019_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck11_Erik157751_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck12_joker10289_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_SoulStrong_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck14_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Bugsy69_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-22",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }


    }
}
