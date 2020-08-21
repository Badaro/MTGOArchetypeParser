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
#01 Shorak123: SnowReclamation (UBG)
#02 Kazuga: SultaiSnow (UBG)
#03 yuurari_yuko: SnowTurns (WUG, Yorion)
#04 sff_mtg: KGCTron (G)
#05 mariogomes097: GrixisShadow (UBR)
#06 ZYURYO: SnowControl (WUBG)
#07 gyyby297: ThopterUrza (WU)
#08 NickPuiKia: IzzetProwess (UR)
#09 medvedev: ETron (C)
#10 Antarctica: Ponza (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_11 : EventTest
    {
        [Test]
        public void Deck01_Shorak123_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",0),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck02_Kazuga_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",1),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck03_yuurariyuko_SnowControl_SnowTurns_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",2),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowTurns),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_sffmtg_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",3),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck05_mariogomes097_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",4),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck06_ZYURYO_SnowControl_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",5),
                new PostM21(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_gyyby297_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",6),
                new PostM21(),
                ArchetypeColor.WU,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck08_NickPuiKia_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",7),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck09_medvedev_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",8),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Antarctica_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",9),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }


    }
}
