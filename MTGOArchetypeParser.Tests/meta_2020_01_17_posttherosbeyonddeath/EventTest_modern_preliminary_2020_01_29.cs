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
#01 McWinSauce: WURG Control (WURG)
#02 kefka27: Eldrazi Tron (G)
#03 Searzist: Mono Red Prowess (R)
#04 jack_anid: Humans (WUBRG)
#05 Accelerator_GTR: Jund Midrange (BRG)
#06 ecobaronen: Jund Midrange (BRG)
#07 z00t: Primeval Titan (UG)
#08 Cherryxman: Bushwhacker Zoo (WRG)
#09 misonikomi: Amulet Titan (G)
#10 antonio00: Green Devotion (RG)
#11 Blitzlion27: Primeval Titan (UG)
#12 tritty: Yawgmoth (BG)
#13 lSoLlAKirA: Thopter Urza (UB)
#14 swff: WURG Control (WURG)
#15 MrJACEone: Primeval Titan (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_01_29 : EventTest
    {
        [Test]
        public void Deck01_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-29",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_kefka27_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-29",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck03_Searzist_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-29",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck04_jackanid_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-29",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_AcceleratorGTR_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-29",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ecobaronen_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-29",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_z00t_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-29",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Cherryxman_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-29",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck09_misonikomi_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-29",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck10_antonio00_GreenDevotion_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-29",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GreenDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Blitzlion27_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-29",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck12_tritty_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-29",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck13_lSoLlAKirA_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-29",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck14_swff_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-29",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_MrJACEone_PrimevalTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-29",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }


    }
}
