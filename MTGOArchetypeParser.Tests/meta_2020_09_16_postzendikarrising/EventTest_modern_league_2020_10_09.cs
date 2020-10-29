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
#01 UrbanPope: Rakdos Prowess (BR, Lurrus)
#02 Foxantes: E Tron (C)
#03 merliche: Bant Blink (WUG, Yorion)
#04 BaDzIo: Mono Red Prowess (R)
#05 katoriarch123: Bant Control (WUG)
#06 DukeVitro: Sultai Shadow (UBG)
#07 Delthar: Infect (BG)
#08 coert: Heliod Combo (WG)
#09 Chipsoss: Golgari Midrange (BG)
#10 FunkiMunki: Jeskai Control (WUR)
#11 doughhater: WURG Control (WURG)
#12 FreakNightmare: Oops All Spells (WUBRG)
#13 Evaros: Omnath Saheeli (WURG, Yorion)
#14 SCJ: Sultai Control (UBG)
#15 Boland: Dredge (BRG)
#16 Chrhey: Izzet Prowess (UR)
#17 wgary86: Rakdos Midrange (BR)
#18 StreexIT: Spirits (WU)
#19 AJV20: Burn (BR, Lurrus)
#20 The_Demon_Inside07: Belcher (RG)
#21 Beicodegeia: Gifts Storm (UR)
#22 thefuryone987: Shadow Prowess (WBR, Lurrus)
#23 fradev1988: Izzet Restore Balance (URG)
#24 aspiringspike: Azorius Control (WU)
#25 jvidarte: Burn (WR, Lurrus)
#26 Yozis: Mill (UB, Lurrus)
#27 Marisa_Margatroid: Grixis Shadow (UBR)
#28 Parrit: Mono White Taxes (W)
#29 Sharkcaster_Mage: Reclaimer Titan (WRG)
#30 TuggaNaxos: Obosh Aggro (R, Obosh)
#31 __BMJ__: Kinnan Legends (WURG, Jegantha)
#32 Loco78: Jund Midrange (BRG)
#33 calexa: KGC Tron (G)
#34 RearrangedAS: Bant Spirits (WUG)
#35 chihoi: Amulet Titan (WUBRG)
#36 Antoine57437: Abzan Company (WBRG)
#37 balltap: Jeskai Breach (WURG, Jegantha)
#38 Beicodegeia: Grixis Control (UBR)
#39 Wtnof: Saheeli Combo (WUR)
#40 Tiemuuu: Izzet Control (UR)
#41 wefald: Inverter (UB)
#42 aronfreyr1212: Hardened Scales (G)
#43 bresett123: Humans (WUBRG)
#44 SeeFour: Hammer Time (W)
#45 Gobern: Bring To Niv (WUBRG, Yorion)
#46 DarkKeeper: WURG Control (WURG)
#47 moralmar: Heliod Devoted (WBG)
#48 MtGilligan: Temur Control (URG)
#49 TERROl2: Jund Shadow (BRG)
#50 PartyJaceBeleren04: Titan Shift (RG)
#51 GideonRavensword: Ad Nauseam (WUB)
#52 Kenzaburo: Azorius Control (WU)
#53 fishstza: Boros Midrange (WR)
#54 MartinezDP: Bring To Niv (WUBRG, Yorion)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_10_09 : EventTest
    {
        [Test]
        public void Deck01_UrbanPope_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-09",0),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Foxantes_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-10-09",1),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck03_merliche_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-09",2),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_BaDzIo_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-10-09",3),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",4),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_DukeVitro_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",5),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Delthar_Infect_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",6),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck08_coert_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",7),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Chipsoss_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",8),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_FunkiMunki_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-10-09",9),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_doughhater_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",10),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_FreakNightmare_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",11),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Evaros_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-09",12),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck14_SCJ_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",13),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Boland_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",14),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Chrhey_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-09",15),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck17_wgary86_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-09",16),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_StreexIT_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-09",17),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck19_AJV20_Burn_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-09",18),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_TheDemonInside07_Belcher_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",19),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Beicodegeia_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-09",20),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck22_thefuryone987_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-09",21),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_fradev1988_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",22),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck24_aspiringspike_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-09",23),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-09",24),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_Yozis_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-09",25),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_MarisaMargatroid_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-09",26),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-10-09",27),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck29_SharkcasterMage_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",28),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck30_TuggaNaxos_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-10-09",29),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck31_BMJ_KinnanLegends_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-09",30),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(KinnanLegends),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck32_Loco78_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",31),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck33_calexa_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-10-09",32),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck34_RearrangedAS_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",33),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck35_chihoi_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",34),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck36_Antoine57437_AbzanCompany_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",35),
                new PostZendikarRising(),
                ArchetypeColor.WBRG,
                typeof(AbzanCompany),
                null,
                null
            );
        }

        [Test]
        public void Deck37_balltap_JeskaiBreach_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-09",36),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                typeof(JeskaiBreach),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck38_Beicodegeia_GrixisControl_UBR()
        {
            Test(
                GetDeck("modern-league-2020-10-09",37),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Wtnof_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-league-2020-10-09",38),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-09",39),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck41_wefald_Inverter_UB()
        {
            Test(
                GetDeck("modern-league-2020-10-09",40),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck42_aronfreyr1212_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-10-09",41),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck43_bresett123_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",42),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck44_SeeFour_HammerTime_W()
        {
            Test(
                GetDeck("modern-league-2020-10-09",43),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Gobern_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-09",44),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck46_DarkKeeper_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",45),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_moralmar_HeliodDevoted_WBG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",46),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck48_MtGilligan_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",47),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_TERROl2_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",48),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck50_PartyJaceBeleren04_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-09",49),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck51_GideonRavensword_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-10-09",50),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Kenzaburo_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-09",51),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck53_fishstza_BorosMidrange_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-09",52),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck54_MartinezDP_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-09",53),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }


    }
}
