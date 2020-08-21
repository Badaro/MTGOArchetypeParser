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
#01 Janh: SnowShift (URG, Yorion)
#02 medvedev: ETron (C)
#03 otakkun: KGCTron (G)
#04 fistfullofmetal: ETron (C)
#05 sff_mtg: KGCTron (G)
#06 PRGJJAR: Dredge (BRG)
#07 ZYURYO: SnowControl (WUG)
#08 spellvine: IzzetProwess (UR)
#09 WanderingOnes: KGCTron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_08 : EventTest
    {
        [Test]
        public void Deck01_Janh_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",0),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowShift),
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
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck03_otakkun_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",2),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
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
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck05_sffmtg_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",4),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
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
        public void Deck07_ZYURYO_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",6),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_spellvine_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",7),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck09_WanderingOnes_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-08",8),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }


    }
}
