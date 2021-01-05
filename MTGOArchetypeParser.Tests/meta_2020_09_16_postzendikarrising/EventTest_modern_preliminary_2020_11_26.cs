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
#01 ArchaeusDota: Dredge (BRG)
#02 swiftwarkite2: Hammer Time (W, Lurrus)
#03 naddyeffintabs: Shadow Prowess (BR, Lurrus)
#04 1yo2yo: Thopter Urza (WUBR)
#05 Mcleskey: Shadow Prowess (BR, Lurrus)
#06 SoulStrong: Bant Blink (WUG)
#07 Jaberwocki: Rogues (UB, Lurrus)
#08 HB360: KGC Tron (G)
#09 CaptainFarbosa: Ad Nauseam (WUB)
#10 pokerswizard: Obosh Aggro (R, Obosh)
#11 karatedom: Heliod Combo (WG)
#12 Theo_Jung: Reclaimer Titan (WG)
#13 azax: Reclaimer Titan (WG)
#14 bolov0: Reclaimer Titan (WRG)
#15 MZBlazer: Shadow Prowess (BR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_26 : EventTest
    {
        [Test]
        public void Deck01_ArchaeusDota_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-26",0),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck02_swiftwarkite2_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-26",1),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_naddyeffintabs_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-26",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_1yo2yo_ThopterUrza_WUBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-26",3),
                new PostZendikarRising(),
                ArchetypeColor.WUBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Mcleskey_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-26",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_SoulStrong_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-26",5),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Jaberwocki_Rogues_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-26",6),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Rogues),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_HB360_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-26",7),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck09_CaptainFarbosa_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-26",8),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck10_pokerswizard_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-26",9),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck11_karatedom_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-26",10),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck12_TheoJung_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-26",11),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck13_azax_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-26",12),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck14_bolov0_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-26",13),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck15_MZBlazer_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-26",14),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
