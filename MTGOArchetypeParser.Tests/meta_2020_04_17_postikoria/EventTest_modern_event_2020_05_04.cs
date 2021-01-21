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
#01 al8ert.dk: Gruul Midrange (RG, Obosh)
#02 PieGonti: Humans (WUBRG, Jegantha)
#03 Nikito18: Bant Control (WUG)
#04 MATTHEWFOULKES: Uroza (URG, Yorion)
#05 toondoslav: Burn (WR, Lurrus)
#06 triosk: Boros Prowess (WR, Lurrus)
#07 romanmy: WURG Control (WURG, Yorion)
#08 Whitecell: Neobrand (UG)
#09 qbturtle15: Jund Midrange (BRG, Lurrus)
#10 PhReSHTinGZ: Amulet Titan (UG)
#11 Magicofplayer1: Devoted (WG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_event_2020_05_04 : EventTest
    {
        [Test]
        public void Deck01_al8ertdk_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-event-2020-05-04",0),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_PieGonti_Humans_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-event-2020-05-04",1),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck03_Nikito18_BantControl_WUG()
        {
            Test(
                GetDeck("modern-event-2020-05-04",2),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_MATTHEWFOULKES_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-event-2020-05-04",3),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck05_toondoslav_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-event-2020-05-04",4),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_triosk_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-event-2020-05-04",5),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_romanmy_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-event-2020-05-04",6),
                "PostIkoria",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_Whitecell_Neobrand_UG()
        {
            Test(
                GetDeck("modern-event-2020-05-04",7),
                "PostIkoria",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck09_qbturtle15_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-event-2020-05-04",8),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_PhReSHTinGZ_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-event-2020-05-04",9),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck11_Magicofplayer1_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-event-2020-05-04",10),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
