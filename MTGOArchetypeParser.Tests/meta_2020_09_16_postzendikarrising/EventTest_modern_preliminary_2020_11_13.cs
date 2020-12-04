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
#01 TSPJendrek: Dimir Control (UB)
#02 CrusherBotBG: Hammer Time (W, Lurrus)
#03 darius89: Ad Nauseam (WUB)
#04 Xwhale: E Tron (C)
#05 Redgy819: KGC Tron (G)
#06 _Falcon_: Shadow Prowess (BR, Lurrus)
#07 TombSimon: Heliod Combo (WG)
#08 ArchaeusDota: Bant Control (WUG, Yorion)
#09 lSoLlAKirA: Heliod Combo (WG)
#10 yamakiller: Obosh Aggro (R, Obosh)
#11 ContraEgo: Thopter Urza (WUBR)
#12 Darkiundsa: Bant Control (WUG, Yorion)
#13 RandomOctopus: Oops All Spells (WUBG)
#14 Patxi: WURG Control (WURG)
#15 lucajak: Mono Red Prowess (R)
#16 Lucabireskusku: Izzet Control (UR)
#17 Bedell: Mill (UB, Lurrus)
#18 yumad3988: Primeval Titan (WURG)
#19 GombleWhop: Obosh Aggro (R, Obosh)
#20 Gobern: Niv To Light (WUBRG, Yorion)
#21 s1m0n: Shadow Prowess (BRG, Lurrus)
#22 sandydogmtg: Oops All Spells (WUBG)
#23 MindOfAKid: Bogles (WG, Lurrus)
#24 tzio: Orzhov Midrange (WB)
#25 EskimoJoe: Mono White Taxes (W)
#26 coert: Heliod Combo (WG, Yorion)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_13 : EventTest
    {
        [Test]
        public void Deck01_TSPJendrek_DimirControl_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",0),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",1),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_darius89_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",2),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Xwhale_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",3),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Redgy819_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",4),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck06_Falcon_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_TombSimon_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",6),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck08_ArchaeusDota_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",7),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_lSoLlAKirA_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",8),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck10_yamakiller_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",9),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck11_ContraEgo_ThopterUrza_WUBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",10),
                new PostZendikarRising(),
                ArchetypeColor.WUBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Darkiundsa_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",11),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck13_RandomOctopus_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",12),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Patxi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",13),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_lucajak_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",14),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Lucabireskusku_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",15),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Bedell_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",16),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_yumad3988_PrimevalTitan_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",17),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck19_GombleWhop_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",18),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck20_Gobern_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",19),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck21_s1m0n_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",20),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_sandydogmtg_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",21),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck23_MindOfAKid_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",22),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_tzio_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",23),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_EskimoJoe_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",24),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck26_coert_HeliodCombo_WG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-13",25),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                ArchetypeCompanion.Yorion
            );
        }


    }
}
