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
#01 Janh: Scapeshift (URG, Yorion)
#02 medvedev: Eldrazi Tron (C)
#03 otakkun: Green Tron (G)
#04 fistfullofmetal: Eldrazi Tron (C)
#05 sff_mtg: Green Tron (G)
#06 PRGJJAR: Dredge (BRG)
#07 ZYURYO: Bant Control (WUG)
#08 spellvine: Izzet Prowess (UR)
#09 WanderingOnes: Green Tron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_08 : EventTest
    {
        [Test]
        public void Deck01_Janh_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",0),
                "PostM21",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_medvedev_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",1),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck03_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",2),
                "PostM21",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck04_fistfullofmetal_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",3),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck05_sffmtg_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",4),
                "PostM21",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck06_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",5),
                "PostM21",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck07_ZYURYO_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",6),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_spellvine_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",7),
                "PostM21",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck09_WanderingOnes_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",8),
                "PostM21",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }


    }
}
