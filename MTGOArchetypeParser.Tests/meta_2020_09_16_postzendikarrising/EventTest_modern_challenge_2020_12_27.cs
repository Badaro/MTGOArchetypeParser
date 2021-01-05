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
#01 omgitztommy: Izzet Prowess (UR)
#02 Patxi: Dimir Control (UB)
#03 vini_torres: Gifts Storm (UR)
#04 toondoslav: Infect (UG)
#05 KnightOfSuri: Infect (UG)
#06 CrusherBotBG: Hammer Time (W, Lurrus)
#07 abethemage: Thopter Urza (WUB)
#08 eclipse4343: Azorius Control (WU)
#09 Math_God: Grixis Shadow (UBR, Lurrus)
#10 ConnorM426: Reclaimer Titan (WG)
#11 Ryan100495: Dredge (BRG)
#12 Usama96: Belcher (URG)
#13 penips: Mono White Taxes (W)
#14 Hollardustin: Jeskai Control (WUR)
#15 MaxCapone: Oops All Spells (WUBG)
#16 Lord_Beerus: Burn (WR, Lurrus)
#17 L1X0: Mill (UB, Lurrus)
#18 mark_68: Obosh Aggro (R, Obosh)
#19 La_Biscia: Heliod Combo (WR)
#20 ShowTime_: Rakdos Midrange (BR)
#21 AlpInco: Oops All Spells (WUBG)
#22 kmacy90: Mill (UB)
#23 themightylinguine: Shadow Prowess (BR, Lurrus)
#24 NightKnight131: Heliod Combo (WG)
#25 Pintogeddon2: Belcher (URG)
#26 wambocombo2020: Hammer Time (WB, Lurrus)
#27 yamakiller: Obosh Aggro (R, Obosh)
#28 ivanguille: Spirits (WU)
#29 jessy_samek: Rakdos Midrange (BR)
#30 Jedgi: WURG Control (WURG)
#31 paka11: Izzet Prowess (UR)
#32 _Tia93_: Shadow Prowess (BRG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_12_27 : EventTest
    {
        [Test]
        public void Deck01_omgitztommy_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",0),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Patxi_DimirControl_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",1),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_vinitorres_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",2),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck04_toondoslav_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",3),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck05_KnightOfSuri_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",4),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck06_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",5),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_abethemage_ThopterUrza_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",6),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck08_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",7),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_MathGod_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",8),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_ConnorM426_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",9),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck11_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",10),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Usama96_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",11),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck13_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",12),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Hollardustin_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",13),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_MaxCapone_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",14),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck16_LordBeerus_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",15),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_L1X0_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",16),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_mark68_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",17),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck19_LaBiscia_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",18),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck20_ShowTime_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",19),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_AlpInco_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",20),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck22_kmacy90_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",21),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck23_themightylinguine_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",22),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_NightKnight131_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",23),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Pintogeddon2_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",24),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck26_wambocombo2020_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",25),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_yamakiller_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",26),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck28_ivanguille_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",27),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck29_jessysamek_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",28),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Jedgi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",29),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_paka11_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",30),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Tia93_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-27",31),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
