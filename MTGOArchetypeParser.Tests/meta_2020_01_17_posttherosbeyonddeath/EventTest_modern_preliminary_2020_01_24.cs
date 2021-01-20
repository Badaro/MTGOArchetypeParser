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
#01 JustBurn420: Slivers (WUBRG)
#02 Tiemuuu: Izzet Control (UR)
#03 Janh: Saheeli Combo (WUR)
#04 timmojay: Green Tron (G)
#05 BReal2: Mardu Midrange (WBR)
#06 Waumpus: Bant Midrange (WUG)
#07 SourceOdin: Primeval Titan (UG)
#08 yamakiller: Eldrazi Tron (G)
#09 PRGJJAR: Dredge (BRG)
#10 Nammersquats: Mono Red Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_01_24 : EventTest
    {
        [Test]
        public void Deck01_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Janh_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck04_timmojay_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck05_BReal2_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Waumpus_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_SourceOdin_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck08_yamakiller_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck09_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Nammersquats_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }


    }
}
