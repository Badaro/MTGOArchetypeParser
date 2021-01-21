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
#01 IPlayBadDecks: Twiddle Storm (UBR)
#02 billster47: Hammer Time (WB, Lurrus)
#03 patheus_84: Ad Nauseam (WUB)
#04 musasabi: WURG Control (WURG)
#05 _Batutinha_: Reclaimer Titan (WRG)
#06 B1gDan: Shadow Prowess (BRG, Lurrus)
#07 MrRaeb: UBRG Control (UBRG)
#08 Magic_Dan: Shadow Prowess (BRG, Lurrus)
#09 PuntThenWhine: Amulet Titan (G)
#10 shine0905: Temur Control (URG)
#11 MagicalSnap: Izzet Prowess (UR)
#12 MarySue: WURG Control (WURG)
#13 penips: Mono White Taxes (W)
#14 yuukisyuzo1: Hammer Time (WB, Lurrus)
#15 kaktusowysmok: Goblins (BR)
#16 Talisker: Infect (UG)
#17 OiGachi1: Heliod Combo (WG)
#18 _LSN_: Burn (WR)
#19 daibloXSC: Grinding Breach (WUR)
#20 Rank1Lynx: Heliod Combo (WRG)
#21 Filyoni: Heliod Combo (WG)
#22 maxbv: Mono White Taxes (W)
#23 Nerdkneereape: Infect (UG)
#24 sokos13: Infect (UG)
#25 Arrias: Heliod Combo (WRG)
#26 Mazzu93: Shadow Prowess (BR, Lurrus)
#27 tibalt_of_red_sub: Mill (UB, Lurrus)
#28 DeltaCx: Spirits (WU)
#29 TheJigIsAlwaysup: WURG Control (WURG)
#30 Tweedel: Obosh Aggro (R, Obosh)
#31 shadow_PT: Dredge (BRG)
#32 MastaHorus: Electro End (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2021_01_18 : EventTest
    {
        [Test]
        public void Deck01_IPlayBadDecks_TwiddleStorm_UBR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",0),
                "PostZendikarRising",
                ArchetypeColor.UBR,
                "TwiddleStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck02_billster47_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",1),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",2),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck04_musasabi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",3),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Batutinha_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",4),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck06_B1gDan_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",5),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_MrRaeb_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",6),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_MagicDan_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",7),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_PuntThenWhine_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",8),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck10_shine0905_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",9),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_MagicalSnap_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",10),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck12_MarySue_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",11),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",12),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck14_yuukisyuzo1_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",13),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_kaktusowysmok_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",14),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Talisker_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",15),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck17_OiGachi1_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",16),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck18_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",17),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck19_daibloXSC_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",18),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Rank1Lynx_HeliodCombo_WRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",19),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Filyoni_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",20),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck22_maxbv_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",21),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Nerdkneereape_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",22),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck24_sokos13_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",23),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck25_Arrias_HeliodCombo_WRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",24),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Mazzu93_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",25),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_tibaltofredsub_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",26),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_DeltaCx_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",27),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck29_TheJigIsAlwaysup_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",28),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Tweedel_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",29),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck31_shadowPT_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",30),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck32_MastaHorus_ElectroEnd_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-18",31),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "FreeSpells",
                "ElectroEnd",
                null
            );
        }


    }
}
