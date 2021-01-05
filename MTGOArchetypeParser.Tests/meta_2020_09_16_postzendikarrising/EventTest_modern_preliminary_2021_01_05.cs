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
#01 Mogged: Gruul Midrange (RG, Obosh)
#02 Kokka4887: Mardu Midrange (WBR)
#03 Masontj: Heliod Combo (WG)
#04 naddyeffintabs: Grishoalbrand (BR)
#05 Pintogeddon2: Hammer Time (W, Lurrus)
#06 Jedgi: WURG Control (WURG)
#07 Kazuga: Shadow Prowess (BR, Lurrus)
#08 patheus_84: Ad Nauseam (WUB)
#09 SIMONEFIERRO: Burn (WR)
#10 Oderus Urungus: Hammer Time (WB, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_05 : EventTest
    {
        [Test]
        public void Deck01_Mogged_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",0),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_Kokka4887_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",1),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Masontj_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",2),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck04_naddyeffintabs_Grishoalbrand_BR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",3),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Grishoalbrand),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Pintogeddon2_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",4),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_Jedgi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",5),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Kazuga_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",6),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",7),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck09_SIMONEFIERRO_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",8),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck10_OderusUrungus_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-05",9),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
