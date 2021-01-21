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
#01 turbopitufo: Mono Red Prowess (R)
#02 Dazai: Bant Control (WUG)
#03 SunofNothing: Uroza (URG)
#04 angelsjeffrey: Eldrazi Tron (C)
#05 MZBlazer: Jund Midrange (BRG)
#06 Hfang1: Infect (UG)
#07 MissTrigger: Green Tron (G)
#08 ZoeR: Mono Red Prowess (R)
#09 Gernardi: Gifts Storm (UR)
#10 akwafresh: Eldrazi Tron (C)
#11 AndyAWKWARD: Temur Control (URG)
#12 endlessnameless10: Humans (WUBRG)
#13 kvestor: Eldrazi Tron (C)
#14 Sungjin: Scapeshift (WURG)
#15 _Batutinha_: Eldrazi Tron (C)
#16 Boland: Grixis Shadow (UBR)
#17 grumart: Dredge (BRG)
#18 Usama96: Jund Midrange (BRG)
#19 NorrathDecay: Burn (WR)
#20 raisans: Primeval Titan (UG)
#21 BReal2: Rakdos Midrange (BR)
#22 Rav104: Amulet Titan (UG)
#23 thepensword: Izzet Control (UR)
#24 Phill_Hellmuth: Humans (WUBRG)
#25 Shadowz2005: Jund Shadow (BRG)
#26 madechai: Mono Red Prowess (R)
#27 jessy_samek: Uroza (URG)
#28 Giaws: Titan Shift (RG)
#29 VampireGodric: Eldrazi Tron (C)
#30 SourceOdin: Thopter Urza (WU)
#31 cool95: Skelementals (BR)
#32 Bullwinkkle6705: Humans (WUBRG)
#33 Mlgb92: Azorius Control (WU)
#34 Kyle467: Mono Red Prowess (R)
#35 PRGJJAR: Dredge (BRG)
#36 Soixante_Neuf: Humans (WUBRG)
#37 pbarrrgh: WURG Control (WURG)
#38 BERNASTORRES: Bogles (WG)
#39 KelMasterP: Mono White Taxes (W)
#40 phol: Uroza (UG)
#41 xfile: Grinding Breach (URG)
#42 MentalMisstep: WUBG Control (WUBG)
#43 Folero: Dredge (BRG)
#44 AlfredoTorres: Dredge (BRG)
#45 Laplasjan: Eldrazi Tron (C)
#46 zdb: Mono Red Prowess (R)
#47 kponceMTG: Mono White Taxes (W)
#48 medvedev: Green Tron (G)
#49 CavalloGoloso: Bant Control (WUG)
#50 Omegauo: Azorius Control (WU)
#51 strong sad: Izzet Control (UR)
#52 Stompy45: Green Tron (G)
#53 chihoi: Amulet Titan (G)
#54 Stark607: Jund Midrange (BRG)
#55 yamakiller: Eldrazi Tron (C)
#56 SrTortinha: Thopter Urza (UBR)
#57 Kaidosan: Green Tron (G)
#58 Mateusf34: Eldrazi Tron (C)
#59 katoriarch123: Bant Control (WUG)
#60 Maldreck: Reclamation (UBG)
#61 snapcaster____mage: Eldrazi Tron (C)
#62 max_9: Green Tron (G)
#63 i_b_TRUE: Jund Midrange (BRG)
#64 _goblinlackey: Green Tron (G)
#65 Genxim: Green Tron (G)
#66 helvetti: Mono Red Prowess (R)
#67 Coly2: Mono Red Prowess (R)
#68 TerminalJustice: Green Tron (G)
#69 coert: Green Tron (G)
#70 im2g00t4ubarn: Jund Midrange (BRG)
#71 Braiden: Jund Shadow (BRG)
#72 Argi99: Gifts Storm (UR)
#73 TFTIjhub: Eldrazi Tron (C)
#74 hikid: Amulet Titan (UG)
#75 caronte1991: Burn (WR)
#76 lukystrike: Azorius Taxes (WU)
#77 Vidandric: Dredge (UBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_03_17 : EventTest
    {
        [Test]
        public void Deck01_turbopitufo_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",0),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck02_Dazai_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",1),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",2),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck04_angelsjeffrey_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",3),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_MZBlazer_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",4),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Hfang1_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",5),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck07_MissTrigger_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",6),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck08_ZoeR_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",7),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck09_Gernardi_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",8),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck10_akwafresh_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",9),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck11_AndyAWKWARD_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",10),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_endlessnameless10_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",11),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_kvestor_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",12),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_Sungjin_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",13),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Batutinha_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",14),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck16_Boland_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",15),
                new PostOuatBan(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck17_grumart_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",16),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Usama96_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",17),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",18),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck20_raisans_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",19),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck21_BReal2_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",20),
                new PostOuatBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Rav104_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",21),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck23_thepensword_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",22),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_PhillHellmuth_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",23),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Shadowz2005_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",24),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck26_madechai_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",25),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck27_jessysamek_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",26),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Giaws_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",27),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck29_VampireGodric_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",28),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck30_SourceOdin_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",29),
                new PostOuatBan(),
                ArchetypeColor.WU,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck31_cool95_Skelementals_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",30),
                new PostOuatBan(),
                ArchetypeColor.BR,
                typeof(Skelementals),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Bullwinkkle6705_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",31),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Mlgb92_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",32),
                new PostOuatBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Kyle467_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",33),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck35_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",34),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck36_SoixanteNeuf_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",35),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck37_pbarrrgh_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",36),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck38_BERNASTORRES_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",37),
                new PostOuatBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck39_KelMasterP_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",38),
                new PostOuatBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck40_phol_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",39),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck41_xfile_GrindingBreach_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",40),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck42_MentalMisstep_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",41),
                new PostOuatBan(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Folero_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",42),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck44_AlfredoTorres_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",43),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Laplasjan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",44),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck46_zdb_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",45),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck47_kponceMTG_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",46),
                new PostOuatBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck48_medvedev_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",47),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck49_CavalloGoloso_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",48),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Omegauo_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",49),
                new PostOuatBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck51_strongsad_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",50),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Stompy45_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",51),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck53_chihoi_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",52),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck54_Stark607_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",53),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck55_yamakiller_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",54),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck56_SrTortinha_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",55),
                new PostOuatBan(),
                ArchetypeColor.UBR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck57_Kaidosan_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",56),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck58_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",57),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck59_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",58),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck60_Maldreck_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",59),
                new PostOuatBan(),
                ArchetypeColor.UBG,
                typeof(Reclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck61_snapcastermage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",60),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck62_max9_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",61),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck63_ibTRUE_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",62),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck64_goblinlackey_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",63),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck65_Genxim_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",64),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck66_helvetti_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",65),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck67_Coly2_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",66),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck68_TerminalJustice_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",67),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck69_coert_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",68),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck70_im2g00t4ubarn_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",69),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck71_Braiden_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",70),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck72_Argi99_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",71),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck73_TFTIjhub_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",72),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck74_hikid_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",73),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck75_caronte1991_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",74),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck76_lukystrike_AzoriusTaxes_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",75),
                new PostOuatBan(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck77_Vidandric_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-17",76),
                new PostOuatBan(),
                ArchetypeColor.UBRG,
                typeof(Dredge),
                null,
                null
            );
        }


    }
}
