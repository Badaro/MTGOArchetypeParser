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
#01 Mistakenn: Amulet Titan (UG)
#02 Lord_Beerus: Burn (WR)
#03 il_matagatto: Burn (WR)
#04 _Shatun_: Gruul Midrange (RG)
#05 Sonic_Smasher: Bant Control (WUG)
#06 Lirek154: Azorius Control (WU)
#07 DreamsOfAshiok: Eldrazi Tron (C)
#08 Charlesjacenorman: Burn (WR, Lurrus)
#09 flatnose: Merfolk (UG)
#10 Theo_Jung: Uroza (URG)
#11 PRGJJAR: Dredge (BRG)
#12 Toastxp: Uroza (URG)
#13 EdB: Amulet Titan (G)
#14 Doni_Dominaria: Mono Red Prowess (R, Jegantha)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_11 : EventTest
    {
        [Test]
        public void Deck01_Mistakenn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",0),
                "PostCompanionChange",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck02_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",1),
                "PostCompanionChange",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck03_ilmatagatto_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",2),
                "PostCompanionChange",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck04_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",3),
                "PostCompanionChange",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_SonicSmasher_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",4),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Lirek154_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",5),
                "PostCompanionChange",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",6),
                "PostCompanionChange",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_Charlesjacenorman_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",7),
                "PostCompanionChange",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_flatnose_Merfolk_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",8),
                "PostCompanionChange",
                ArchetypeColor.UG,
                "Merfolk",
                null,
                null
            );
        }

        [Test]
        public void Deck10_TheoJung_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",9),
                "PostCompanionChange",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck11_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",10),
                "PostCompanionChange",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Toastxp_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",11),
                "PostCompanionChange",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck13_EdB_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",12),
                "PostCompanionChange",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck14_DoniDominaria_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-11",13),
                "PostCompanionChange",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Jegantha
            );
        }


    }
}
