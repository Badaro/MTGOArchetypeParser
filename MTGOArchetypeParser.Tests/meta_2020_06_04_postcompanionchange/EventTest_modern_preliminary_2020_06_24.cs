using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 mariogomes097: Grixis Shadow (UBR)
#02 WhiTe TsaR: Sultai Control (UBG)
#03 _INF_: Gifts Storm (UR)
#04 Janh: Reclamation (URG)
#05 bubbsei: Dredge (BRG)
#06 ZYURYO: Jund Midrange (BRG)
#07 2k4mmorton: Mono Red Prowess (R)
#08 skeptimist: Bant Control (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_24 : EventTest
    {
        [Test]
        public void Deck01_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",0),
                "PostCompanionChange",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck02_WhiTeTsaR_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",1),
                "PostCompanionChange",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",2),
                "PostCompanionChange",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Janh_Reclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",3),
                "PostCompanionChange",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck05_bubbsei_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",4),
                "PostCompanionChange",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck06_ZYURYO_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",5),
                "PostCompanionChange",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_2k4mmorton_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",6),
                "PostCompanionChange",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck08_skeptimist_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",7),
                "PostCompanionChange",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
