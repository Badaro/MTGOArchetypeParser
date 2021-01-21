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
#01 Gigy: Gruul Midrange (RG)
#02 sff_mtg: Green Tron (G)
#03 J000111: Dredge (WBRG)
#04 WanderingOnes: Green Tron (G)
#05 Janh: Scapeshift (URG, Yorion)
#06 HouseOfManaMTG: Amulet Titan (UG)
#07 katoriarch123: Bant Control (WUG)
#08 Engelsdorfer: Grixis Shadow (UBR)
#09 zumekun19850204: Sultai Control (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_10 : EventTest
    {
        [Test]
        public void Deck01_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",0),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck02_sffmtg_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",1),
                "PostM21",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck03_J000111_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",2),
                "PostM21",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck04_WanderingOnes_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",3),
                "PostM21",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck05_Janh_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",4),
                "PostM21",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_HouseOfManaMTG_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",5),
                "PostM21",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck07_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",6),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Engelsdorfer_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",7),
                "PostM21",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck09_zumekun19850204_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",8),
                "PostM21",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
