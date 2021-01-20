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
#01 Shorak123: Sultai Control (UBG)
#02 Kazuga: Sultai Control (UBG)
#03 yuurari_yuko: Bant Control (WUG, Yorion)
#04 sff_mtg: Green Tron (G)
#05 mariogomes097: Grixis Shadow (UBR)
#06 ZYURYO: WUBG Control (WUBG)
#07 gyyby297: Thopter Urza (WU)
#08 NickPuiKia: Izzet Prowess (UR)
#09 medvedev: Eldrazi Tron (C)
#10 Antarctica: Gruul Midrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_11 : EventTest
    {
        [Test]
        public void Deck01_Shorak123_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",0),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Kazuga_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",1),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_yuurariyuko_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",2),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_sffmtg_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",3),
                new PostM21(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck05_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",4),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ZYURYO_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",5),
                new PostM21(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
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
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck08_NickPuiKia_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",7),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck09_medvedev_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",8),
                new PostM21(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck10_Antarctica_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-11",9),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
