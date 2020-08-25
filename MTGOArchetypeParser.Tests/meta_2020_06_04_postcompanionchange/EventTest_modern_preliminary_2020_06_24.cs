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
#01 mariogomes097: GrixisShadow (UBR)
#02 WhiTe TsaR: SultaiSnow (UBG)
#03 _INF_: GiftsStorm (UR)
#04 Janh: SnowReclamation (URG)
#05 bubbsei: Dredge (BRG)
#06 ZYURYO: Jund (BRG)
#07 2k4mmorton: Prowess (R)
#08 skeptimist: SnowControl (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_24 : EventTest
    {
        [Test]
        public void Deck01_mariogomes097_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",0),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck02_WhiTeTsaR_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",1),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",2),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Janh_SnowControl_SnowReclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",3),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck05_bubbsei_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",4),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ZYURYO_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",5),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_2k4mmorton_Prowess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",6),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck08_skeptimist_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-24",7),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
