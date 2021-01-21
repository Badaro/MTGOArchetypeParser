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
#01 _EzMud1: Bant Control (WUG)
#02 Sharkcaster_Mage: Primeval Titan (BG)
#03 Oscar_Franco: Ad Nauseam (WUB)
#04 gnorilgrande: Grinding Breach (WUR)
#05 __matsugan: Neobrand (UG)
#06 coert: Burn (WR)
#07 _Batutinha_: Bant Control (WUG)
#08 gyyby297: Thopter Urza (UB)
#09 Kurfty: Burn (WR)
#10 brothernova: Eldrazi Tron (C)
#11 herrelljp: Mono Red Prowess (R)
#12 Lollopollo2001: Burn (WR)
#13 Moniz0801: Amulet Titan (UG)
#14 ZoeR: Burn (WR)
#15 NorrathDecay: Burn (WR)
#16 CookieKid00: Niv To Light (WUBRG)
#17 maxxattack: Infect (UG)
#18 ACG88: Burn (WR)
#19 _LSN_: Burn (WR)
#20 katoriarch123: Bant Control (WUG)
#21 el-pollo-lolo: Rakdos Midrange (BR)
#22 TheRealRickJames: Mono Red Prowess (R)
#23 Medrix: Electro Balance (URG)
#24 Gigy: Gruul Midrange (RG)
#25 Oderus Urungus: Humans (WUBRG)
#26 kthanakit26: Burn (WR)
#27 flankattack27: Uroza (URG)
#28 Znapcaster: Humans (WUBRG)
#29 Rav104: Green Tron (RG)
#30 StormlightReaper: Eldrazi Tron (C)
#31 Sarv: Uroza (URG)
#32 RealJoy: Amulet Titan (UG)
#33 Searzist: Infect (UG)
#34 Mlgb92: Niv To Light (WUBRG)
#35 SaxManSax: Titan Shift (RG)
#36 RNGspecialist: Niv To Light (WUBRG)
#37 quinniac: Burn (WR)
#38 mechint: Uroza (URG)
#39 genkytoro: Jund Midrange (BRG)
#40 rastaf: Gruul Midrange (RG)
#41 Gernardi: Gruul Midrange (RG)
#42 oniiman: Mono Red Prowess (R)
#43 Blackout28: Green Tron (G)
#44 rusty_gates: Burn (WR)
#45 in5ano: Thopter Urza (WUR)
#46 __BMJ__: Gruul Midrange (RG)
#47 Baufos: Uroza (URG)
#48 BReal2: Hollow One (BR)
#49 PivoUlivo: Burn (WR)
#50 J000111: Dredge (BRG)
#51 Mistakenn: Amulet Titan (URG)
#52 Trisky: Infect (UG)
#53 red_lymphocyte: Infect (UG)
#54 _Antoniou_: Niv To Light (WUBRG)
#55 mansak: Jund Midrange (BRG)
#56 selbstdenker: Niv To Light (WUBRG)
#57 JustBurn420: Slivers (WUBRG)
#58 Mercenario: Dredge (UBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_04_09 : EventTest
    {
        [Test]
        public void Deck01_EzMud1_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",0),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_SharkcasterMage_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",1),
                "PostOuatBan",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck03_OscarFranco_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",2),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck04_gnorilgrande_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",3),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck05_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",4),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck06_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",5),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck07_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",6),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_gyyby297_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",7),
                "PostOuatBan",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck09_Kurfty_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",8),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck10_brothernova_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",9),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck11_herrelljp_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",10),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck12_Lollopollo2001_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",11),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck13_Moniz0801_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",12),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck14_ZoeR_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",13),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck15_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",14),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck16_CookieKid00_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",15),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck17_maxxattack_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",16),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck18_ACG88_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",17),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck19_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",18),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck20_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",19),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_elpollololo_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",20),
                "PostOuatBan",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck22_TheRealRickJames_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",21),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck23_Medrix_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",22),
                "PostOuatBan",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck24_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",23),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck25_OderusUrungus_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",24),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck26_kthanakit26_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",25),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck27_flankattack27_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",26),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck28_Znapcaster_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",27),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Rav104_GreenTron_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",28),
                "PostOuatBan",
                ArchetypeColor.RG,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck30_StormlightReaper_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",29),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck31_Sarv_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",30),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck32_RealJoy_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",31),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck33_Searzist_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",32),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck34_Mlgb92_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",33),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck35_SaxManSax_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",34),
                "PostOuatBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck36_RNGspecialist_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",35),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck37_quinniac_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",36),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck38_mechint_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",37),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck39_genkytoro_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",38),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck40_rastaf_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",39),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck41_Gernardi_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",40),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck42_oniiman_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",41),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck43_Blackout28_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",42),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck44_rustygates_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",43),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck45_in5ano_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",44),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck46_BMJ_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",45),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck47_Baufos_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",46),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck48_BReal2_HollowOne_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",47),
                "PostOuatBan",
                ArchetypeColor.BR,
                "HollowOne",
                null,
                null
            );
        }

        [Test]
        public void Deck49_PivoUlivo_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",48),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck50_J000111_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",49),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck51_Mistakenn_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",50),
                "PostOuatBan",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck52_Trisky_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",51),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck53_redlymphocyte_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",52),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck54_Antoniou_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",53),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck55_mansak_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",54),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck56_selbstdenker_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",55),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck57_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",56),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck58_Mercenario_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-09",57),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }


    }
}
