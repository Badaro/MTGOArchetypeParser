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
#01 kmacy90: Mill (UB)
#02 twinlesstwin: Mardu Midrange (WBR)
#03 Slatorade: Ascendancy Combo (WURG)
#04 GGoggles: Dice Factory Tron (C)
#05 qbturtle15: Gruul Midrange (RG)
#06 Samcaster-Mage: Eldrazi Tron (C)
#07 SoulStrong: Rakdos Midrange (BR)
#08 magic_viking: Bant Blink (WUG)
#09 Smdster: Heliod Combo (WR)
#10 yashimoro: Temur Control (URG)
#11 azax: Reclaimer Titan (WRG)
#12 NinoMtg: Shadow Prowess (BR, Lurrus)
#13 s063: Reclaimer Titan (WRG)
#14 Samwise_GeeGee: Heliod Combo (WR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_31 : EventTest
    {
        [Test]
        public void Deck01_kmacy90_Mill_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-31",0),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck02_twinlesstwin_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-31",1),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Slatorade_AscendancyCombo_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-31",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(AscendancyCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck04_GGoggles_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-31",3),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(DiceFactoryTron),
                null
            );
        }

        [Test]
        public void Deck05_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-31",4),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_SamcasterMage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-31",5),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_SoulStrong_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-31",6),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_magicviking_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-31",7),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Smdster_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-31",8),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck10_yashimoro_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-31",9),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_azax_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-31",10),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck12_NinoMtg_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-31",11),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_s063_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-31",12),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck14_SamwiseGeeGee_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-31",13),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }


    }
}
