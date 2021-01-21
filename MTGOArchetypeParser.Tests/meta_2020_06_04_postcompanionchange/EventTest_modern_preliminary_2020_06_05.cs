using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Violent_Outburst: Reclamation (URG, Yorion)
#02 gazmon48: Gruul Midrange (RG)
#03 LORiWWA: Eldrazi Tron (C)
#04 __matsugan: Neobrand (UG)
#05 PRGJJAR: Dredge (BRG)
#06 fradev1988: Bant Control (WUG)
#07 Cherryxman: Uroza (WUG, Yorion)
#08 sff_mtg: Green Tron (G)
#09 _Shatun_: Titan Shift (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_05 : EventTest
    {
        [Test]
        public void Deck01_ViolentOutburst_Reclamation_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-05",0),
                "PostCompanionChange",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_gazmon48_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-05",1),
                "PostCompanionChange",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_LORiWWA_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-05",2),
                "PostCompanionChange",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck04_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-05",3),
                "PostCompanionChange",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck05_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-05",4),
                "PostCompanionChange",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck06_fradev1988_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-05",5),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Cherryxman_Uroza_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-05",6),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_sffmtg_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-05",7),
                "PostCompanionChange",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck09_Shatun_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-05",8),
                "PostCompanionChange",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }


    }
}
