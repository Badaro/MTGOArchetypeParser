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
#01 sydneydude: Boros Prowess (WR, Lurrus)
#02 DreamsOfAshiok: Eldrazi Tron (C)
#03 DDMeelow: Uroza (URG, Yorion)
#04 Nrm1998: Bogles (WG, Lurrus)
#05 triosk: Uroza (URG, Yorion)
#06 RearrangedAS: Spirits (WU)
#07 TennTyou: Niv To Light (WUBRG)
#08 fradev1988: Bant Control (WUG)
#09 coert: Burn (WR, Lurrus)
#10 Laplasjan: Devoted (WG, Lurrus)
#11 johnyvolta: Kiki Chord (WURG, Yorion)
#12 bomberboss: Humans (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_01 : EventTest
    {
        [Test]
        public void Deck01_sydneydude_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-01",0),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-01",1),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck03_DDMeelow_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-01",2),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Nrm1998_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-01",3),
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_triosk_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-01",4),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_RearrangedAS_Spirits_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-01",5),
                "PostIkoria",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck07_TennTyou_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-01",6),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck08_fradev1988_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-01",7),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_coert_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-01",8),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-01",9),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_johnyvolta_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-01",10),
                "PostIkoria",
                ArchetypeColor.WURG,
                "KikiChord",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_bomberboss_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-01",11),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }


    }
}
