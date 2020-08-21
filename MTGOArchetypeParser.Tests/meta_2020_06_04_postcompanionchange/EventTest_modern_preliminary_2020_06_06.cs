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
#01 Diatomic: SnowBlade (WUG)
#02 _Shatun_: Ponza (RG)
#03 _INF_: GiftsStorm (UR)
#04 ZYURYO: SnowControl (WUBG)
#05 slsh: Ponza (RG)
#06 Do0mSwitch: SnowControl (WUG)
#07 ilsecco14: Rock (BG)
#08 kanister: Humans (WUBRG)
#09 audio336: Dredge (BRG)
#10 12Days: Ponza (BRG, Obosh)
#11 sff_mtg: KGCTron (G)
#12 elad3127: Ponza (RG)
#13 Doomed_Necromancer: AbzanMidrange (WBG)
#14 nielsen333: JeskaiStoneblade (WUR)
#15 matyo804: Humans (WUBRG)
#16 ktmr-39: GolosTron (G, Jegantha)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_06 : EventTest
    {
        [Test]
        public void Deck01_Diatomic_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",0),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck02_Shatun_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",1),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck03_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",2),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck04_ZYURYO_SnowControl_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",3),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_slsh_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",4),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Do0mSwitch_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",5),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_ilsecco14_Rock_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",6),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck08_kanister_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",7),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck09_audio336_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",8),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_12Days_Ponza_BRG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",9),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Ponza),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck11_sffmtg_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",10),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck12_elad3127_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",11),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck13_DoomedNecromancer_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",12),
                new PostCompanionChange(),
                ArchetypeColor.WBG,
                typeof(AbzanMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_nielsen333_JeskaiControl_JeskaiStoneblade_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",13),
                new PostCompanionChange(),
                ArchetypeColor.WUR,
                typeof(JeskaiControl),
                typeof(JeskaiStoneblade),
                null
            );
        }

        [Test]
        public void Deck15_matyo804_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",14),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck16_ktmr39_GTron_GolosTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",15),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(GolosTron),
                ArchetypeCompanion.Jegantha
            );
        }


    }
}
