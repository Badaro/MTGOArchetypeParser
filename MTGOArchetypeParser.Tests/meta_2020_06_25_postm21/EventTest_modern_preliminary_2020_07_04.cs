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
#01 lilianaofthevess: Song Storm (URG, Jegantha)
#02 ZYURYO: Bant Control (WUG)
#03 ManuelJacob: Sultai Control (UBG)
#04 _INF_: Gifts Storm (UR)
#05 bnlunt: Blue Tron (U)
#06 nielsen333: Primeval Titan (BG)
#07 Laessoe: Gruul Midrange (RG)
#08 siomomi: Green Tron (G)
#09 triosk: Goblins (BR)
#10 cjucjujp: Bushwhacker Zoo (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_04 : EventTest
    {
        [Test]
        public void Deck01_lilianaofthevess_SongStorm_URG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",0),
                "PostM21",
                ArchetypeColor.URG,
                "SongStorm",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck02_ZYURYO_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",1),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_ManuelJacob_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",2),
                "PostM21",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",3),
                "PostM21",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck05_bnlunt_BlueTron_U()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",4),
                "PostM21",
                ArchetypeColor.U,
                "Tron",
                "BlueTron",
                null
            );
        }

        [Test]
        public void Deck06_nielsen333_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",5),
                "PostM21",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Laessoe_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",6),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_siomomi_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",7),
                "PostM21",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck09_triosk_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",8),
                "PostM21",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck10_cjucjujp_BushwhackerZoo_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",9),
                "PostM21",
                ArchetypeColor.RG,
                "BushwhackerZoo",
                null,
                null
            );
        }


    }
}
