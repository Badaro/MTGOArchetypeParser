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
#05 bnlunt: U Tron (U)
#06 nielsen333: Primeval Titan (BG)
#07 Laessoe: Gruul Midrange (RG)
#08 siomomi: KGC Tron (G)
#09 triosk: Snoop Goblins (BR)
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
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SongStorm),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck02_ZYURYO_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",1),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_ManuelJacob_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",2),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",3),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck05_bnlunt_UTron_U()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",4),
                new PostM21(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck06_nielsen333_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",5),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Laessoe_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",6),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_siomomi_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",7),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck09_triosk_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",8),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck10_cjucjujp_BushwhackerZoo_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-04",9),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }


    }
}
