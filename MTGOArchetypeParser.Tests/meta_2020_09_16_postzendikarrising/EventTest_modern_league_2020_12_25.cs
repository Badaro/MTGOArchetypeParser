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
#01 MagicEd: Shadow Prowess (BR, Lurrus)
#02 klien7: Dredge (BRG)
#03 Mogged: G Tron (G, Jegantha)
#04 scalo94: Heliod Combo (WR)
#05 Foxantes: Oops All Spells (WUBG)
#06 ashame: Shadow Prowess (BR, Lurrus)
#07 hugofreitas1: Gifts Storm (UR)
#08 Curryvore: Azorius Blink (WU)
#09 NorrathDecay: Burn (WR)
#10 AlabasterWolfie: Snoop Goblins (BR)
#11 Kurusu: Kiki Chord (WURG, Yorion)
#12 ziyanghuakai: Jund Midrange (BRG)
#13 brunocaffaro: Belcher (URG)
#14 Voltzwagon: Gruul Midrange (RG)
#15 FlxEx: Battle Of Wits (WUBRG, Yorion)
#16 Haricot-Rouge: Hammer Time (W, Lurrus)
#17 LLegend: Izzet Restore Balance (UR)
#18 Smdster: Amulet Titan (RG)
#19 ACG88: E Tron (C)
#20 Borjillamtg10: Living End (BRG)
#21 DemianDesposito10: Mono Red Prowess (R, Jegantha)
#22 Edoz13: Yawgmoth (BG)
#23 SpedeRip: Smallpox (WB)
#24 HummingBard: U Tron (U)
#25 penips: Mono White Taxes (W)
#26 Kzrds: Sultai Control (UBG)
#27 Math_God: Grixis Shadow (UBR, Lurrus)
#28 Dieguz88: Infect (BG)
#29 smoran02: Mill (UB, Lurrus)
#30 Musagete: Heliod Combo (WG)
#31 ContraEgo: Thopter Urza (WUB)
#32 Traft: Rogues (UB, Lurrus)
#33 Sonkerz: Izzet Control (UR)
#34 MrRaeb: UBRG Control (UBRG, Yorion)
#35 WhiteOleander: Bant Spirits (WUG)
#36 wutang08: UBRG Shadow (UBRG, Lurrus)
#37 ZTL2991: Obosh Aggro (R, Obosh)
#38 mashmalovsky: Ad Nauseam (WUB)
#39 Rosentree: Dice Factory Tron (C)
#40 katoriarch123: WURG Control (WURG)
#41 nahuel10: Izzet Prowess (UR)
#42 TuggaNaxos: Sultai Control (UBG)
#43 Jadisouzaft: Primeval Titan (UG)
#44 tribalmaster: Humans (WUBRG)
#45 Parrit: Mono White Taxes (W, Yorion)
#46 Patxi: Dimir Control (UB)
#47 TSPJendrek: Simic Control (UG)
#48 greatnate: Azorius Control (WU)
#49 SpiderSpace: Hammer Time (WR, Lurrus)
#50 Nikachu: Merfolk (U)
#51 DoctorQueller: Spirits (WU)
#52 fgfonseca182: Rakdos Midrange (BR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_12_25 : EventTest
    {
        [Test]
        public void Deck01_MagicEd_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-25",0),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_klien7_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",1),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Mogged_GTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-12-25",2),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck04_scalo94_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-25",3),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Foxantes_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",4),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ashame_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-25",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-25",6),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Curryvore_AzoriusBlink_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-25",7),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck09_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-25",8),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck10_AlabasterWolfie_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-25",9),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck11_Kurusu_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-25",10),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_ziyanghuakai_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",11),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_brunocaffaro_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",12),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Voltzwagon_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",13),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_FlxEx_BattleOfWits_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-25",14),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BattleOfWits),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_HaricotRouge_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-25",15),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_LLegend_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-25",16),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck18_Smdster_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",17),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck19_ACG88_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-12-25",18),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Borjillamtg10_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",19),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck21_DemianDesposito10_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-12-25",20),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck22_Edoz13_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",21),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck23_SpedeRip_Smallpox_WB()
        {
            Test(
                GetDeck("modern-league-2020-12-25",22),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck24_HummingBard_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-12-25",23),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck25_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-12-25",24),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Kzrds_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",25),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_MathGod_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-25",26),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_Dieguz88_Infect_BG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",27),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck29_smoran02_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-25",28),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_Musagete_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",29),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck31_ContraEgo_ThopterUrza_WUB()
        {
            Test(
                GetDeck("modern-league-2020-12-25",30),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Traft_Rogues_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-25",31),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Rogues),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck33_Sonkerz_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-25",32),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_MrRaeb_UBRGControl_UBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-25",33),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck35_WhiteOleander_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",34),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck36_wutang08_UBRGShadow_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-25",35),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck37_ZTL2991_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-12-25",36),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck38_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-12-25",37),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Rosentree_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-league-2020-12-25",38),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(DiceFactoryTron),
                null,
                null
            );
        }

        [Test]
        public void Deck40_katoriarch123_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",39),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck41_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-25",40),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck42_TuggaNaxos_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",41),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Jadisouzaft_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",42),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck44_tribalmaster_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",43),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Parrit_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-25",44),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck46_Patxi_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-12-25",45),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_TSPJendrek_SimicControl_UG()
        {
            Test(
                GetDeck("modern-league-2020-12-25",46),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck48_greatnate_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-25",47),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_SpiderSpace_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-25",48),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck50_Nikachu_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-12-25",49),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck51_DoctorQueller_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-25",50),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck52_fgfonseca182_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-25",51),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
