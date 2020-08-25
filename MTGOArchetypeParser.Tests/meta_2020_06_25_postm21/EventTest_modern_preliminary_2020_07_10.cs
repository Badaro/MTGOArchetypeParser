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
#01 Gigy: Ponza (RG)
#02 sff_mtg: KGCTron (G)
#03 J000111: Dredge (WBRG)
#04 WanderingOnes: KGCTron (G)
#05 Janh: SnowShift (URG, Yorion)
#06 HouseOfManaMTG: AmuletTitan (WUBRG)
#07 katoriarch123: SnowControl (WUG)
#08 Engelsdorfer: GrixisShadow (UBR)
#09 zumekun19850204: SultaiSnow (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_10 : EventTest
    {
        [Test]
        public void Deck01_Gigy_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",0),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_sffmtg_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",1),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck03_J000111_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",2),
                new PostM21(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_WanderingOnes_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",3),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck05_Janh_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",4),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_HouseOfManaMTG_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",5),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_katoriarch123_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",6),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Engelsdorfer_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",7),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck09_zumekun19850204_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-10",8),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
