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
#02 medvedev: E Tron (C)
#03 otakkun: KGC Tron (G)
#04 fistfullofmetal: E Tron (C)
#05 sff_mtg: KGC Tron (G)
#06 PRGJJAR: Dredge (BRG)
#07 ZYURYO: Bant Control (WUG)
#08 spellvine: Izzet Prowess (UR)
#09 WanderingOnes: KGC Tron (G)
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
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_medvedev_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",1),
                new PostM21(),
                ArchetypeColor.C,
                typeof(EldraziTron),
                null,
                null
            );
        }

        [Test]
        public void Deck03_otakkun_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",2),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck04_fistfullofmetal_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",3),
                new PostM21(),
                ArchetypeColor.C,
                typeof(EldraziTron),
                null,
                null
            );
        }

        [Test]
        public void Deck05_sffmtg_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",4),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck06_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",5),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck07_ZYURYO_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",6),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_spellvine_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",7),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_WanderingOnes_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",8),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }


    }
}
