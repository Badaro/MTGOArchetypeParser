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
#01 Thrall90: JundMidrange (BRG)
#02 _titoWii_96: WURGControl (WURG, Yorion)
#03 Boin: ETron (C)
#04 jdez: OrzhovShadow (WB)
#05 triosk: HardenedScales (G)
#06 Laplasjan: Devoted (WG, Lurrus)
#07 Dai1412: IzzetProwess (UR)
#08 ecobaronen: SultaiControl (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_03 : EventTest
    {
        [Test]
        public void Deck01_Thrall90_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",0),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_titoWii96_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",1),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_Boin_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",2),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck04_jdez_OrzhovShadow_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",3),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck05_triosk_HardenedScales_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",4),
                new PostM21(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",5),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Dai1412_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",6),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck08_ecobaronen_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-03",7),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
