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
#01 xfile: Golgari Midrange (BG)
#02 2radMTG: Infect (UG)
#03 coert: Devoted (WBG)
#04 swff: WURG Control (WURG)
#05 lSoLlAKirA: Thopter Urza (UB)
#06 Kazuga: Jund Midrange (BRG)
#07 Phill_Hellmuth: Primeval Titan (UG)
#08 SoulStrong: WURG Control (WURG)
#09 SlyDaniel7787: Ad Nauseam (WUB)
#10 McWinSauce: WURG Control (WURG)
#11 MentalMisstep: Yawgmoth (BG)
#12 stollis: Crabvine (UBG)
#13 fistfullofmetal: Green Tron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_05 : EventTest
    {
        [Test]
        public void Deck01_xfile_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-05",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_2radMTG_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-05",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck03_coert_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-05",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck04_swff_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-05",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_lSoLlAKirA_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-05",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck06_Kazuga_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-05",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_PhillHellmuth_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-05",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck08_SoulStrong_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-05",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_SlyDaniel7787_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-05",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck10_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-05",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_MentalMisstep_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-05",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck12_stollis_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-05",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck13_fistfullofmetal_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-05",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }


    }
}
