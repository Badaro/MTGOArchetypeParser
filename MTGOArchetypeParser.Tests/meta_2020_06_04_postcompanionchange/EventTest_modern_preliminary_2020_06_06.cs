using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Diatomic: Bant Control (WUG)
#02 _Shatun_: Gruul Midrange (RG)
#03 _INF_: Gifts Storm (UR)
#04 ZYURYO: WUBG Control (WUBG)
#05 slsh: Gruul Midrange (RG)
#06 Do0mSwitch: Bant Control (WUG)
#07 ilsecco14: Golgari Midrange (BG)
#08 kanister: Humans (WUBRG)
#09 audio336: Dredge (BRG)
#10 12Days: Jund Midrange (BRG, Obosh)
#11 sff_mtg: Green Tron (G)
#12 elad3127: Gruul Midrange (RG)
#13 Doomed_Necromancer: Abzan Midrange (WBG)
#14 nielsen333: Jeskai Control (WUR)
#15 matyo804: Humans (WUBRG)
#16 ktmr-39: Green Tron (G, Jegantha)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_06 : EventTest
    {
        [Test]
        public void Deck01_Diatomic_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",0),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",1),
                "PostCompanionChange",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",2),
                "PostCompanionChange",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck04_ZYURYO_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",3),
                "PostCompanionChange",
                ArchetypeColor.WUBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_slsh_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",4),
                "PostCompanionChange",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",5),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_ilsecco14_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",6),
                "PostCompanionChange",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_kanister_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",7),
                "PostCompanionChange",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck09_audio336_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",8),
                "PostCompanionChange",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck10_12Days_JundMidrange_BRG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",9),
                "PostCompanionChange",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck11_sffmtg_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",10),
                "PostCompanionChange",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck12_elad3127_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",11),
                "PostCompanionChange",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_DoomedNecromancer_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",12),
                "PostCompanionChange",
                ArchetypeColor.WBG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_nielsen333_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",13),
                "PostCompanionChange",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_matyo804_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",14),
                "PostCompanionChange",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck16_ktmr39_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-06",15),
                "PostCompanionChange",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }


    }
}
