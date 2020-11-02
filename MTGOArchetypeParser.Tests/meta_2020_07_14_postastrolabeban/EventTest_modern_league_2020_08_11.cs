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
#01 Gods_Shadow: Infect (UG)
#02 Lannynyny: Niv To Light (WUBRG)
#03 cccaspar: White Devotion (W)
#04 scipios: Crabvine (UBG)
#05 AlphaBlade: E Tron (C)
#06 Jaberwocki: Jund Midrange (BRG)
#07 shiven djinn: Obosh Aggro (R, Obosh)
#08 Hetteshkane: Burn (WR)
#09 ltbeast: Scapeshift (URG)
#10 Nextep: Sultai Control (UBG)
#11 didoguidotti1: Temur Reclamation (URG)
#12 junghans: Heliod Combo (WG)
#13 imperatorek: Devoted (WG, Lurrus)
#14 Sharkcaster_Mage: Sultai Reclamation (UBG)
#15 zildjian88: Dredge (BRG)
#16 mrounds1216: Orzhov Eldrazi Taxes (WB)
#17 _VFS_: Sultai Control (UBG)
#18 _MRZ_: Sultai Midrange (UBG)
#19 Thekkar: Ad Nauseam (WUB)
#20 ferrum0728: Mardu Shadow (WBR)
#21 Bishark: Blue Devotion (U)
#22 Simarisu: Izzet Prowess (UR)
#23 sultai4lyfe: Dimir Control (UB)
#24 DoorDie: KGC Tron (G)
#25 Zpz: KGC Tron (G)
#26 Volollo: Mardu Prowess (WBR, Lurrus)
#27 RileyCurran: Heliod Devoted (WBG)
#28 FSkura: Sultai Control (UBG)
#29 bobthedog: Heliod Sisters (W)
#30 drVendigo: Gruul Midrange (RG)
#31 I_DEEED_IT: Mono Red Prowess (R)
#32 musasabi: KGC Amulet Titan (UBRG)
#33 kid: Azorius Control (WU)
#34 Storytime: Kinnan Devoted (WUG)
#35 lokarionn: Hardened Scales (WG, Lurrus)
#36 l337erhosen: White Devotion (W, Yorion)
#37 MinT_: Ad Nauseam (WUB)
#38 Sfugliatella: Incinerator Burn (WR)
#39 crackerpack: Enduring Ideal (W)
#40 Esoda: Bant Midrange (WUG)
#41 Yugornot: Jund Shadow (BRG)
#42 ThePhatty500: Orzhov Tokens (WB)
#43 Lexmart: Bant Control (WUG)
#44 brainstorm39: Jeskai Control (WUR, Yorion)
#45 SebastianStueckl: Humans (WUBRG)
#46 SixScry: Azorius Control (WU)
#47 axisplus1: Bogles (WG)
#48 TheDogFish: Merfolk (WU, Lurrus)
#49 WeGoingSizzler: Elementals (WUBRG)
#50 Bobthebuilder24: Grixis Shadow (UBR)
#51 Waumpus: Heliod Combo (WUG)
#52 CTherapy: Gifts Storm (UR)
#53 Nekonii: Golgari Elves (BG)
#54 DethFrmAbove: Tokens (WB)
#55 Asoen: Rakdos Midrange (BR)
#56 Iceman76: Snoop Goblins (BR)
#57 kaktusowysmok: Merfolk (U)
#58 Middeterminist: Simic Reclamation (UG)
#59 CrusherBotBG: Hammer Time (W)
#60 DieSense84: Golgari Midrange (BG)
#61 ivan229: Izzet Control (UR)
#62 danidpf: Thopter Urza (UBR)
#63 Parrit: Hardened Scales (G)
#64 Qernavak: Dice Factory Tron (C)
#65 _Makaveli: Azorius Control (WU)
#66 sfitz: Thopter Urza (UBR)
#67 The_GingerBrute: Hammer Time (WR, Lurrus)
#68 CasperKhaos: Izzet Restore Balance (URG)
#69 aspiringspike: Esper Shadow (WUB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_08_11 : EventTest
    {
        [Test]
        public void Deck01_GodsShadow_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",0),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Lannynyny_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck03_cccaspar_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-league-2020-08-11",2),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck04_scipios_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck05_AlphaBlade_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-08-11",4),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Jaberwocki_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",5),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_shivendjinn_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-08-11",6),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck08_Hetteshkane_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_ltbeast_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",8),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Nextep_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",9),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_didoguidotti1_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",10),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck12_junghans_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck13_imperatorek_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-11",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_SharkcasterMage_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck15_zildjian88_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck16_mrounds1216_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-11",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck17_VFS_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",16),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_MRZ_SultaiMidrange_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",17),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Thekkar_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-11",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck20_ferrum0728_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Bishark_BlueDevotion_U()
        {
            Test(
                GetDeck("modern-league-2020-08-11",20),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(BlueDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Simarisu_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck23_sultai4lyfe_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-08-11",22),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_DoorDie_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-08-11",23),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck25_Zpz_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-08-11",24),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck26_Volollo_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-11",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_RileyCurran_HeliodDevoted_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck28_FSkura_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",27),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_bobthedog_HeliodSisters_W()
        {
            Test(
                GetDeck("modern-league-2020-08-11",28),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(SoulSisters),
                typeof(HeliodSisters),
                null
            );
        }

        [Test]
        public void Deck30_drVendigo_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",29),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_IDEEEDIT_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-08-11",30),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck32_musasabi_KGCAmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",31),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck33_kid_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-11",32),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Storytime_KinnanDevoted_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",33),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                typeof(KinnanDevoted),
                null
            );
        }

        [Test]
        public void Deck35_lokarionn_HardenedScales_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-11",34),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck36_l337erhosen_WhiteDevotion_W_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-11",35),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck37_MinT_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-11",36),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck38_Sfugliatella_IncineratorBurn_WR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",37),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck39_crackerpack_EnduringIdeal_W()
        {
            Test(
                GetDeck("modern-league-2020-08-11",38),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(EnduringIdeal),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Esoda_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",39),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Yugornot_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",40),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck42_ThePhatty500_OrzhovTokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-11",41),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Tokens),
                typeof(OrzhovTokens),
                null
            );
        }

        [Test]
        public void Deck43_Lexmart_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",42),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck44_brainstorm39_JeskaiControl_WUR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-11",43),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck45_SebastianStueckl_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",44),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck46_SixScry_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-11",45),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_axisplus1_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",46),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck48_TheDogFish_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-11",47),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck49_WeGoingSizzler_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",48),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Bobthebuilder24_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",49),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Waumpus_HeliodCombo_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",50),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck52_CTherapy_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",51),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck53_Nekonii_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",52),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck54_DethFrmAbove_Tokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-11",53),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck55_Asoen_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",54),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck56_Iceman76_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",55),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck57_kaktusowysmok_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-08-11",56),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck58_Middeterminist_SimicReclamation_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",57),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck59_CrusherBotBG_HammerTime_W()
        {
            Test(
                GetDeck("modern-league-2020-08-11",58),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck60_DieSense84_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",59),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck61_ivan229_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",60),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck62_danidpf_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",61),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck63_Parrit_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-08-11",62),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck64_Qernavak_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-league-2020-08-11",63),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(DiceFactoryTron),
                null,
                null
            );
        }

        [Test]
        public void Deck65_Makaveli_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-11",64),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck66_sfitz_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",65),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck67_TheGingerBrute_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-11",66),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck68_CasperKhaos_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",67),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck69_aspiringspike_EsperShadow_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-11",68),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(GenericShadow),
                null,
                null
            );
        }


    }
}
