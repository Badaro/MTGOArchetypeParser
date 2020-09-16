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
#01 Graciasportanto: JundMidrange (BRG)
#02 Icteridae: ETron (C)
#03 PRGJJAR: Dredge (BRG)
#04 wordy333: Merfolk (UG)
#05 samslam: Burn (WR)
#06 andrw1232: Dredge (WBRG)
#07 Samcaster-Mage: ETron (C)
#08 starfall: Merfolk (UG)
#09 Mcleskey: GruulMidrange (RG)
#10 WareHouseGames: AdNauseam (WUB)
#11 Toastxp: BantControl (WUG)
#12 nedyahiske: ETron (C)
#13 atm8162: TitanShift (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_09 : EventTest
    {
        [Test]
        public void Deck01_Graciasportanto_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-09",0),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Icteridae_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-09",1),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck03_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-09",2),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_wordy333_Merfolk_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-09",3),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck05_samslam_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-09",4),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck06_andrw1232_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-09",5),
                new PostM21(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck07_SamcasterMage_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-09",6),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_starfall_Merfolk_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-09",7),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Mcleskey_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-09",8),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_WareHouseGames_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-09",9),
                new PostM21(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Toastxp_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-09",10),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_nedyahiske_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-09",11),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck13_atm8162_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-09",12),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }


    }
}
