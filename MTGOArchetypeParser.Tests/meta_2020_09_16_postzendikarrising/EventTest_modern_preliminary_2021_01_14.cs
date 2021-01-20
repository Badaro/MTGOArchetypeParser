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
#01 qbturtle15: Mono White Taxes (W)
#02 Gul_Dukat: WURG Control (WURG)
#03 lwdgg: Ad Nauseam (WUB)
#04 WingedHussar: Mill (UB, Lurrus)
#05 tangrams: WURG Control (WURG)
#06 mchlpp: Shadow Prowess (BR, Lurrus)
#07 JUJUBEAN__2004: Heliod Combo (WG)
#08 pmk: Humans (WUBRG)
#09 abombdiggity: Reclaimer Titan (WRG)
#10 BReal2: Shadow Prowess (BR, Lurrus)
#11 sandydogmtg: Infect (UG)
#12 Chris_Concarnage: Izzet Prowess (UR)
#13 Xwhale: Reclaimer Titan (WRG)
#14 Nammersquats: Infect (UG)
#15 ShotGunNova: Oops All Spells (WUBG)
#16 zachattack23: WURG Control (WURG)
#17 CrusherBotBG: Hammer Time (W, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_14 : EventTest
    {
        [Test]
        public void Deck01_qbturtle15_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",0),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck02_GulDukat_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_lwdgg_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",2),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck04_WingedHussar_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",3),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_tangrams_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",4),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_mchlpp_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_JUJUBEAN2004_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",6),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck08_pmk_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",7),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck09_abombdiggity_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",8),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck10_BReal2_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",9),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_sandydogmtg_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",10),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck12_ChrisConcarnage_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",11),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck13_Xwhale_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",12),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck14_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",13),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck15_ShotGunNova_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",14),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck16_zachattack23_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",15),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-14",16),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
