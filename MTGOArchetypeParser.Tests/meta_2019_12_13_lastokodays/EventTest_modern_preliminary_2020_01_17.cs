using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 angelsjeffrey: Mono Red Prowess (R)
#02 BigHuman: Green Devotion (RG)
#03 mindcandy: Green Tron (G)
#04 xfile: Dredge (BRG)
#05 McWinSauce: Bant Midrange (WUG)
#06 Punkah: Humans (WUBRG)
#07 MaLiam: Jund Midrange (BRG)
#08 _Shatun_: Mono Red Prowess (R)
#09 tritty: Spirits (WUG)
#10 Gandalf_the_Grey: Ad Nauseam (WUB)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2020_01_17 : EventTest
    {
        [Test]
        public void Deck01_angelsjeffrey_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-17",0),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck02_BigHuman_GreenDevotion_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-17",1),
                "LastOkoDays",
                ArchetypeColor.RG,
                "GreenDevotion",
                null,
                null
            );
        }

        [Test]
        public void Deck03_mindcandy_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-17",2),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck04_xfile_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-17",3),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck05_McWinSauce_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-17",4),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Punkah_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-17",5),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck07_MaLiam_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-17",6),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-17",7),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck09_tritty_Spirits_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-17",8),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck10_GandalftheGrey_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-17",9),
                "LastOkoDays",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }


    }
}
