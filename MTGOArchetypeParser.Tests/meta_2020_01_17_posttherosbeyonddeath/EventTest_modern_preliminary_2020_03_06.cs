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
#01 Wurst_: WURG Control (WURG)
#02 JinMoRi: Eldrazi Tron (G)
#03 gardrd: Mono Red Prowess (R)
#04 Nammersquats: Bant Midrange (WUG)
#05 MATTHEWFOULKES: Grinding Breach (WUR)
#06 swff: WURG Control (WURG)
#07 medvedev: Eldrazi Tron (G)
#08 SourceOdin: Amulet Titan (G)
#09 Lukas261997: Primeval Titan (BG)
#10 MaLiam: Eldrazi Tron (G)
#11 Treno: Infect (UG)
#12 Mou: Jund Midrange (BRG)
#13 E_Kaminuma: Devoted (WG)
#14 Juzam-Djinn84: Gifts Storm (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_03_06 : EventTest
    {
        [Test]
        public void Deck01_Wurst_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-06",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_JinMoRi_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-06",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck03_gardrd_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-06",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck04_Nammersquats_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-06",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_MATTHEWFOULKES_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-06",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck06_swff_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-06",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_medvedev_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-06",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck08_SourceOdin_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-06",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck09_Lukas261997_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-06",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck10_MaLiam_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-06",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck11_Treno_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-06",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Mou_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-06",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_EKaminuma_Devoted_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-06",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck14_JuzamDjinn84_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-06",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }


    }
}
