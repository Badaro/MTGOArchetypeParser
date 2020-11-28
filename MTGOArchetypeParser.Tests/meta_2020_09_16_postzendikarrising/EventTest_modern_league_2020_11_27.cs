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
#01 Frank_Bonaparte: Heliod Combo (WR)
#02 TuggaNaxos: Scapeshift (URG)
#03 ljex: Izzet Prowess (UR)
#04 gyyby297: Oops All Spells (WUBRG)
#05 Borjillamtg10: Rakdos Midrange (BR)
#06 meanfannypack: Azorius Taxes (WU, Yorion)
#07 Usama96: Temur Control (URG)
#08 TSPJendrek: Azorius Control (WU)
#09 Muldrotha7912: Dredge (BRG)
#10 Maccaciock: Azorius Control (WU)
#11 The_nayr: Devoted (WG, Lurrus)
#12 DoctorQueller: Bant Spirits (WUG)
#13 xame3: Obosh Aggro (R, Obosh)
#14 TheVlagh: Mono Red Prowess (R)
#15 603Leb: Boros Taxes (WR, Yorion)
#16 rojanosa: Dimir Control (UB)
#17 didoguidotti1: WURG Control (WURG)
#18 Sprouts: Hammer Time (WB, Lurrus)
#19 Munich_Casual: Jund Midrange (BRG)
#20 Mada997: Shadow Prowess (WBR, Lurrus)
#21 Curtisaxel: U Tron (UR)
#22 ZYX_Jerry: Selective Oracle (WU)
#23 JustinAkinori: Orzhov Taxes (WB)
#24 Moyashi01: Shadow Prowess (BRG, Lurrus)
#25 bigjc00: Amulet Titan (UBRG)
#26 Voltzwagon: Gruul Midrange (RG)
#27 MartinezDP: Omnath Saheeli (WURG, Yorion)
#28 Monochrome09: Temur Control (URG)
#29 ZYX_Jerry: Belcher (URG)
#30 kanister: Hammer Time (W, Lurrus)
#31 The_nayr: Izzet Control (UR)
#32 ncowden: Bant Midrange (WUG)
#33 Goose70: Grixis Shadow (UBR)
#34 XxquestionablyawesomexX: Bogles (WG, Lurrus)
#35 ATGerwaz: Reclaimer Titan (WRG)
#36 Parrit: Orzhov Taxes (WB)
#37 FerMTG: Orzhov Midrange (WB)
#38 Wuhsa: Niv To Light (WUBRG, Yorion)
#39 sicsmoo: KGC Tron (G, Jegantha)
#40 crazyklicker: Tokens (WBG)
#41 Patxi: Temur Midrange (URG)
#42 Heisenberg666: Burn (WR)
#43 nazart: Heliod Combo (WG)
#44 pbarrrgh: Sultai Control (UBG)
#45 Zerito: Rakdos Midrange (BR)
#46 Damgar: E Tron (C)
#47 comradGT: Infect (BG)
#48 mashmalovsky: Ad Nauseam (WUB)
#49 Rulleboren: Gifts Storm (UR)
#50 Gods_Shadow: Jeskai Control (WUR)
#51 daibloXSC: Sultai Control (UBG)
#52 Zxrogue: Izzet Restore Balance (URG)
#53 CBotella: Spirits (WU)
#54 sesben1111: Bant Blink (WUG)
#55 SoulStrong: Bant Blink (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_11_27 : EventTest
    {
        [Test]
        public void Deck01_FrankBonaparte_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-league-2020-11-27",0),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck02_TuggaNaxos_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",1),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck03_ljex_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-27",2),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_gyyby297_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",3),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Borjillamtg10_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-11-27",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_meanfannypack_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-27",5),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_Usama96_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",6),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_TSPJendrek_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-27",7),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Muldrotha7912_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",8),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Maccaciock_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-27",9),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Thenayr_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-27",10),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_DoctorQueller_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",11),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck13_xame3_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-11-27",12),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck14_TheVlagh_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-11-27",13),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck15_603Leb_BorosTaxes_WR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-27",14),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_rojanosa_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-11-27",15),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_didoguidotti1_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",16),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Sprouts_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-27",17),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_MunichCasual_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",18),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Mada997_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-27",19),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_Curtisaxel_UTron_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-27",20),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck22_ZYXJerry_SelectiveOracle_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-27",21),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(SelectiveOracle),
                null,
                null
            );
        }

        [Test]
        public void Deck23_JustinAkinori_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-11-27",22),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Moyashi01_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-27",23),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_bigjc00_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",24),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck26_Voltzwagon_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",25),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck27_MartinezDP_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-27",26),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck28_Monochrome09_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",27),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_ZYXJerry_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",28),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck30_kanister_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-27",29),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_Thenayr_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-27",30),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_ncowden_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",31),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Goose70_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-11-27",32),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck34_XxquestionablyawesomexX_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-27",33),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck35_ATGerwaz_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",34),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck36_Parrit_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-11-27",35),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck37_FerMTG_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-11-27",36),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck38_Wuhsa_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-27",37),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck39_sicsmoo_KGCTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-11-27",38),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck40_crazyklicker_Tokens_WBG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",39),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Patxi_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",40),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck42_Heisenberg666_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-11-27",41),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck43_nazart_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",42),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck44_pbarrrgh_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",43),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Zerito_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-11-27",44),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck46_Damgar_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-11-27",45),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck47_comradGT_Infect_BG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",46),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck48_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-11-27",47),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck49_Rulleboren_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-27",48),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck50_GodsShadow_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-11-27",49),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck51_daibloXSC_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",50),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Zxrogue_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",51),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck53_CBotella_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-27",52),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck54_sesben1111_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",53),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck55_SoulStrong_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-27",54),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }


    }
}
