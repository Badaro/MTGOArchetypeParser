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
#01 Icteridae: Eldrazi Tron (C)
#02 DreamsOfAshiok: Eldrazi Tron (C)
#03 yamakiller: Humans (WUBRG)
#04 Hiru: Rakdos Midrange (BR)
#05 PTarts2win: Dredge (BRG)
#06 flatnose: Merfolk (UG)
#07 ilsecco14: Mono Red Prowess (R)
#08 wambocombo2020: Uroza (UBG, Yorion)
#09 MadCowChicken: Green Eldrazi (WG, Jegantha)
#10 Stompy45: Gruul Midrange (RG)
#11 _LSN_: Burn (WR)
#12 Traft: Ad Nauseam (WUB)
#13 WebZone: Humans (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_18 : EventTest
    {
        [Test]
        public void Deck01_Icteridae_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-18",0),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-18",1),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck03_yamakiller_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-18",2),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Hiru_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-18",3),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_PTarts2win_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-18",4),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck06_flatnose_Merfolk_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-18",5),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck07_ilsecco14_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-18",6),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck08_wambocombo2020_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-18",7),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_MadCowChicken_GreenEldrazi_WG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-18",8),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(GreenEldrazi),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck10_Stompy45_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-18",9),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-18",10),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck12_Traft_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-18",11),
                new PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck13_WebZone_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-18",12),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }


    }
}
