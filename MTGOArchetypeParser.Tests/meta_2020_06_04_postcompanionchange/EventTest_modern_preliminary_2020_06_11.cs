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
#01 Mistakenn: KGC Amulet Titan (G)
#02 Lord_Beerus: Burn (WR)
#03 il_matagatto: Burn (WR)
#04 _Shatun_: Gruul Midrange (RG)
#05 Sonic_Smasher: Bant Control (WUG)
#06 Lirek154: Azorius Control (WU)
#07 DreamsOfAshiok: E Tron (C)
#08 Charlesjacenorman: Burn (WR, Lurrus)
#09 flatnose: Merfolk (UG)
#10 Theo_Jung: Uroza (UG)
#11 PRGJJAR: Dredge (BRG)
#12 Toastxp: Uroza (UG)
#13 EdB: Amulet Titan (G)
#14 Doni_Dominaria: Mono Red Prowess (R, Jegantha)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_11 : EventTest
    {
        [Test]
        public void Deck01_Mistakenn_KGCAmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",0),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",1),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck03_ilmatagatto_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",2),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",3),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_SonicSmasher_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",4),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Lirek154_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",5),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_DreamsOfAshiok_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",6),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Charlesjacenorman_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",7),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_flatnose_Merfolk_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",8),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck10_TheoJung_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",9),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck11_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",10),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Toastxp_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",11),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck13_EdB_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",12),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck14_DoniDominaria_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",13),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }


    }
}
