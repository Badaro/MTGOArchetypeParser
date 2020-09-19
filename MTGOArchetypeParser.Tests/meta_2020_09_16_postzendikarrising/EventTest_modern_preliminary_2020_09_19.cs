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
#01 Phill_Hellmuth: Devoted (WG, Lurrus)
#02 stonepeanut: KGCTron (G)
#03 andrw1232: WURGControl (WURG)
#04 Hennaruji1: Humans (WUBRG)
#05 Xwhale: Humans (WUBRG)
#06 Wizard_2002: JundMidrange (BRG)
#07 Bullwinkkle6705: WURGControl (WURG)
#08 RearrangedAS: Spirits (WU)
#09 Hoey07: Humans (WUBRG)
#10 Smdster: TemurControl (URG)
#11 Joey_Wheeler: ETron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_09_19 : EventTest
    {
        [Test]
        public void Deck01_PhillHellmuth_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-19",0),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_stonepeanut_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-19",1),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck03_andrw1232_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-19",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Hennaruji1_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-19",3),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Xwhale_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-19",4),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Wizard2002_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-19",5),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Bullwinkkle6705_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-19",6),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_RearrangedAS_Spirits_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-19",7),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Hoey07_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-19",8),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Smdster_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-19",9),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_JoeyWheeler_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-19",10),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }


    }
}
