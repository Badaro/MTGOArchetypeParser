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
#01 headshot93: Bogles (WG, Lurrus)
#02 eresopacaso: Burn (WR, Lurrus)
#03 nahuel10: WURG Control (WURG, Yorion)
#04 fistfullofmetal: Green Tron (RG, Jegantha)
#05 Searzist: Jund Midrange (BRG, Lurrus)
#06 2radMTG: Amulet Titan (UG)
#07 Mogged: Boros Prowess (WR, Lurrus)
#08 _Batutinha_: Boros Prowess (WR, Lurrus)
#09 Venom1: Jund Midrange (BRG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_15 : EventTest
    {
        [Test]
        public void Deck01_headshot93_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-15",0),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_eresopacaso_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-15",1),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_nahuel10_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-15",2),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_fistfullofmetal_GreenTron_RG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-15",3),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck05_Searzist_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-15",4),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_2radMTG_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-15",5),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_Mogged_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-15",6),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Batutinha_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-15",7),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Venom1_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-15",8),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
