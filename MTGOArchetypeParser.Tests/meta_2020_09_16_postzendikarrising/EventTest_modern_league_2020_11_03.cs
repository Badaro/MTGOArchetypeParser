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
#01 polishdynamit3: Shadow Prowess (WBR, Lurrus)
#02 fake-news: Primeval Titan (WURG)
#03 meanfannypack: Orzhov Eldrazi Taxes (WB, Yorion)
#04 Tarrasque1: Zombies (WB)
#05 tortillathehun: Rakdos Midrange (BR)
#06 MaxMagicer: Scapeshift (URG, Yorion)
#07 Bullwinkkle6705: Omnath Saheeli (WURG, Yorion)
#08 Steppelhoff: Heliod Combo (WG)
#09 Curtisaxel: Heliod Devoted (WG)
#10 MChoq: Titan Stompy (RG)
#11 weishengzhishabi: Sultai Control (UBG)
#12 Salva1994: Merfolk (WU, Lurrus)
#13 RespectTheCat: Azorius Taxes (WU, Yorion)
#14 GideonRavensword: Heliod Devoted (WG)
#15 Costola91: Humans (WUBRG)
#16 wynn1006: Izzet Phoenix (UR)
#17 MagicalHack99: KGC Amulet Titan (WUBRG)
#18 IgorBarbosa: Serum Powder Eldrazi (R)
#19 misterfister: Polymorph (WURG)
#20 N3to: Gifts Storm (UR)
#21 azax: Reclaimer Titan (WRG)
#22 Damgar: KGC Tron (G)
#23 HeyPharaoh: Jeskai Control (WUR)
#24 nahuel10: Izzet Prowess (UR)
#25 hermanomlg: Scapeshift (URG)
#26 ittoku1: Bant Blink (WUG)
#27 122pablo: Heliod Combo (WG)
#28 BluePlasma: Burn (WR)
#29 Tiemuuu: Izzet Control (UR)
#30 sicsmoo: WURG Control (WURG)
#31 Voltzwagon: Gruul Midrange (RG)
#32 LordOfDarkness25: Bogles (WG)
#33 Antoine57437: Abzan Company (WBRG)
#34 Caleb_Yetman: Omnath Saheeli (WURG, Jegantha)
#35 SpiderSpace: Snoop Goblins (BR)
#36 Megalov: Titan Stompy (BRG, Gyruda)
#37 iuriper: Ad Nauseam (WUB)
#38 Hitokiri1984: Golgari Midrange (BG)
#39 DoctorQueller: Spirits (WUG)
#40 yneves: Neobrand (UG)
#41 flamedragons2: Grixis Shadow (UBR)
#42 Intrepid91: Oops All Spells (WUBRG)
#43 Curryvore: Azorius Control (WU, Yorion)
#44 thahoppa: Jund Shadow (BRG, Lurrus)
#45 POC: Infect (BG, Lurrus)
#46 osmanozguney: Mill (UB, Lurrus)
#47 shoktroopa: U Tron (UB)
#48 Nikachu: Vampires (B)
#49 Selfeisek: Living End (BRG)
#50 serum_visions: Jund Midrange (BRG)
#51 Ibaitor: Golgari Midrange (BG)
#52 Erik157751: Crabvine (UBG)
#53 geodarno: Dredge (UBRG)
#54 Hamuda: Hardened Scales (G)
#55 keyan926: Tribal Zoo (WUBRG, Lurrus)
#56 Kaizer_Kahn: Obosh Aggro (R, Obosh)
#57 albert62: WURG Control (WURG)
#58 FlxEx: Battle Of Wits (WUBRG, Yorion)
#59 Rauptro: Izzet Control (UR)
#60 hoek47: Mono Red Prowess (R)
#61 vdboule: Scapeshift (WURG)
#62 Vasoi2323: Sultai Reclamation (UBG)
#63 daibloXSC: Azorius Control (WU)
#64 Shou-T: E Tron (C)
#65 CCM777: Hollow One (URG)
#66 TscheggschDePoegg: Selenya Taxes (WG)
#67 --Phoenix77--: Rakdos Midrange (BR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_11_03 : EventTest
    {
        [Test]
        public void Deck01_polishdynamit3_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-03",0),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_fakenews_PrimevalTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck03_meanfannypack_OrzhovEldraziTaxes_WB_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-03",2),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Tarrasque1_Zombies_WB()
        {
            Test(
                GetDeck("modern-league-2020-11-03",3),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(Zombies),
                null,
                null
            );
        }

        [Test]
        public void Deck05_tortillathehun_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-11-03",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_MaxMagicer_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-03",5),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_Bullwinkkle6705_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-03",6),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_Steppelhoff_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",7),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Curtisaxel_HeliodDevoted_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",8),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck10_MChoq_TitanStompy_RG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",9),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(TitanStompy),
                null,
                null
            );
        }

        [Test]
        public void Deck11_weishengzhishabi_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",10),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Salva1994_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-03",11),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_RespectTheCat_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-03",12),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck14_GideonRavensword_HeliodDevoted_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",13),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck15_Costola91_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",14),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck16_wynn1006_IzzetPhoenix_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-03",15),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetPhoenix),
                null,
                null
            );
        }

        [Test]
        public void Deck17_MagicalHack99_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",16),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck18_IgorBarbosa_SerumPowderEldrazi_R()
        {
            Test(
                GetDeck("modern-league-2020-11-03",17),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(SerumPowderEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck19_misterfister_Polymorph_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",18),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(Polymorph),
                null,
                null
            );
        }

        [Test]
        public void Deck20_N3to_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-03",19),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck21_azax_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",20),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck22_Damgar_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-11-03",21),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck23_HeyPharaoh_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-11-03",22),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-03",23),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck25_hermanomlg_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",24),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck26_ittoku1_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",25),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck27_122pablo_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",26),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck28_BluePlasma_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-11-03",27),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-03",28),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_sicsmoo_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",29),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Voltzwagon_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",30),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_LordOfDarkness25_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",31),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Antoine57437_AbzanCompany_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",32),
                new PostZendikarRising(),
                ArchetypeColor.WBRG,
                typeof(AbzanCompany),
                null,
                null
            );
        }

        [Test]
        public void Deck34_CalebYetman_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-11-03",33),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck35_SpiderSpace_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-11-03",34),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck36_Megalov_TitanStompy_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-league-2020-11-03",35),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(TitanStompy),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck37_iuriper_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-11-03",36),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck38_Hitokiri1984_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",37),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck39_DoctorQueller_Spirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",38),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck40_yneves_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",39),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck41_flamedragons2_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-11-03",40),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck42_Intrepid91_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",41),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Curryvore_AzoriusControl_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-03",42),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck44_thahoppa_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-03",43),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck45_POC_Infect_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-03",44),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck46_osmanozguney_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-03",45),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck47_shoktroopa_UTron_UB()
        {
            Test(
                GetDeck("modern-league-2020-11-03",46),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck48_Nikachu_Vampires_B()
        {
            Test(
                GetDeck("modern-league-2020-11-03",47),
                new PostZendikarRising(),
                ArchetypeColor.B,
                typeof(Vampires),
                null,
                null
            );
        }

        [Test]
        public void Deck49_Selfeisek_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",48),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck50_serumvisions_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",49),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Ibaitor_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",50),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Erik157751_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",51),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck53_geodarno_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",52),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck54_Hamuda_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-11-03",53),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck55_keyan926_TribalZoo_WUBRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-03",54),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(TribalZoo),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck56_KaizerKahn_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-11-03",55),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck57_albert62_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",56),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck58_FlxEx_BattleOfWits_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-03",57),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BattleOfWits),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck59_Rauptro_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-03",58),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck60_hoek47_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-11-03",59),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck61_vdboule_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",60),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck62_Vasoi2323_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",61),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck63_daibloXSC_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-03",62),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck64_ShouT_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-11-03",63),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck65_CCM777_HollowOne_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",64),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(HollowOne),
                null,
                null
            );
        }

        [Test]
        public void Deck66_TscheggschDePoegg_SelenyaTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-03",65),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck67_Phoenix77_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-11-03",66),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
