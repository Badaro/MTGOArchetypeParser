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
#01 Genxim: Green Tron (G)
#02 Lannynyny: Niv To Light (WUBRG)
#03 rofelos: Bant Control (WUG)
#04 TSPJendrek: WUBG Control (WUBG)
#05 CavalloGoloso: Izzet Control (UR)
#06 WhiTe TsaR: Mono Red Prowess (R)
#07 Azngangbuzta: Mono Red Prowess (R)
#08 SunofNothing: Uroza (URG)
#09 triosk: Jund Midrange (BRG)
#10 kanister: Bant Control (WUG)
#11 joetru: Jund Midrange (BRG)
#12 achillies27: Gifts Storm (URG)
#13 JinMoRi: Jund Midrange (BRG)
#14 Mistakenn: Amulet Titan (URG)
#15 albert62: Jund Midrange (BRG)
#16 bolov0: Humans (WUBRG)
#17 fatkiddestroyers: Bant Midrange (WUG)
#18 fradev1988: Electro Balance (UR)
#19 BlueLips: Bant Control (WUG)
#20 Phill_Hellmuth: Uroza (URG)
#21 Gerardo94: Bant Control (WUG)
#22 Graciasportanto: Uroza (URG)
#23 lighdar: Eldrazi Tron (C)
#24 HarlanMTG: Thopter Urza (WUR)
#25 otakkun: Green Tron (G)
#26 musasabi: Amulet Titan (UG)
#27 Milkk: Green Tron (G)
#28 UmekawaneikU: Uroza (URG)
#29 Playmobil: Uroza (URG)
#30 SrTortinha: Thopter Urza (WUR)
#31 A22en: Sultai Midrange (UBG)
#32 stonepeanut: Green Tron (G)
#33 pablohotdog: Green Tron (G)
#34 SYMO991: Jund Midrange (BRG)
#35 DDMeelow: Uroza (URG)
#36 _Batutinha_: Eldrazi Tron (C)
#37 Mateusf34: Eldrazi Tron (C)
#38 kthanakit26: Burn (WRG)
#39 Atticuslol: Amulet Titan (UG)
#40 EduFonseca: Primeval Titan (BG)
#41 TombSimon: Eldrazi Tron (C)
#42 Jositoshekel: Green Tron (G)
#43 Tonynine: Gruul Midrange (RG)
#44 Trellon: Blue Tron (U)
#45 RCMerriam: Dredge (WBRG)
#46 yanmaster: Devoted (WBG)
#47 ander_lizarrakoa: Green Tron (G)
#48 Engelsdorfer: Jund Shadow (BRG)
#49 Capriccioso: Green Tron (G)
#50 Devil_: Mono Red Prowess (R)
#51 Kazuga: Mono Red Prowess (R)
#52 BSK_hercules: Eldrazi Tron (C)
#53 pbarrrgh: WURG Control (WURG)
#54 joker10289: Uroza (URG)
#55 Wolfie98: Izzet Control (UR)
#56 YBLime: Mono Red Prowess (R)
#57 im2g00t4ubarn: Uroza (UG)
#58 StormlightReaper: Eldrazi Tron (C)
#59 122pablo: Ascendancy Combo (WURG)
#60 __matsugan: Neobrand (UG)
#61 levunga21: Jund Midrange (BRG)
#62 cicciogire: Eldrazi Tron (C)
#63 Hfang1: Infect (UG)
#64 ArchaeusDota: Eldrazi Tron (C)
#65 Dreddybajs: Green Tron (G)
#66 Jenara19: Uroza (URG)
#67 Oderus Urungus: Jund Midrange (BRG)
#68 snapcaster____mage: Eldrazi Tron (C)
#69 Benburr: Dredge (BRG)
#70 TheTunnelingCat: Eldrazi Tron (C)
#71 EmmeBi: Ad Nauseam (WUB)
#72 Kisfor: UBRG Shadow (UBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_03_19 : EventTest
    {
        [Test]
        public void Deck01_Genxim_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",0),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck02_Lannynyny_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",1),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck03_rofelos_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",2),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_TSPJendrek_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",3),
                "PostOuatBan",
                ArchetypeColor.WUBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_CavalloGoloso_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",4),
                "PostOuatBan",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_WhiTeTsaR_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",5),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck07_Azngangbuzta_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",6),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck08_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",7),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck09_triosk_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",8),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_kanister_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",9),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_joetru_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",10),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck12_achillies27_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",11),
                "PostOuatBan",
                ArchetypeColor.URG,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck13_JinMoRi_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",12),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Mistakenn_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",13),
                "PostOuatBan",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck15_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",14),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_bolov0_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",15),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck17_fatkiddestroyers_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",16),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck18_fradev1988_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",17),
                "PostOuatBan",
                ArchetypeColor.UR,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck19_BlueLips_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",18),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck20_PhillHellmuth_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",19),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Gerardo94_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",20),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Graciasportanto_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",21),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck23_lighdar_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",22),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck24_HarlanMTG_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",23),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck25_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",24),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck26_musasabi_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",25),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck27_Milkk_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",26),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck28_UmekawaneikU_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",27),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Playmobil_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",28),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck30_SrTortinha_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",29),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck31_A22en_SultaiMidrange_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",30),
                "PostOuatBan",
                ArchetypeColor.UBG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck32_stonepeanut_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",31),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck33_pablohotdog_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",32),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck34_SYMO991_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",33),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck35_DDMeelow_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",34),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck36_Batutinha_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",35),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck37_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",36),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck38_kthanakit26_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",37),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck39_Atticuslol_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",38),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck40_EduFonseca_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",39),
                "PostOuatBan",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck41_TombSimon_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",40),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck42_Jositoshekel_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",41),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck43_Tonynine_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",42),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck44_Trellon_BlueTron_U()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",43),
                "PostOuatBan",
                ArchetypeColor.U,
                "Tron",
                "BlueTron",
                null
            );
        }

        [Test]
        public void Deck45_RCMerriam_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",44),
                "PostOuatBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck46_yanmaster_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",45),
                "PostOuatBan",
                ArchetypeColor.WBG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck47_anderlizarrakoa_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",46),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck48_Engelsdorfer_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",47),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck49_Capriccioso_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",48),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck50_Devil_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",49),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck51_Kazuga_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",50),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck52_BSKhercules_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",51),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck53_pbarrrgh_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",52),
                "PostOuatBan",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck54_joker10289_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",53),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck55_Wolfie98_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",54),
                "PostOuatBan",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck56_YBLime_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",55),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck57_im2g00t4ubarn_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",56),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck58_StormlightReaper_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",57),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck59_122pablo_AscendancyCombo_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",58),
                "PostOuatBan",
                ArchetypeColor.WURG,
                "AscendancyCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck60_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",59),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck61_levunga21_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",60),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck62_cicciogire_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",61),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck63_Hfang1_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",62),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck64_ArchaeusDota_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",63),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck65_Dreddybajs_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",64),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck66_Jenara19_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",65),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck67_OderusUrungus_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",66),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck68_snapcastermage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",67),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck69_Benburr_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",68),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck70_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",69),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck71_EmmeBi_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",70),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck72_Kisfor_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-19",71),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }


    }
}
