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
#01 ArchaeusDota: Eldrazi Tron (R)
#02 Dalbert: Mono Red Prowess (R)
#03 Finalnub: Scapeshift (WURG)
#04 joetru: Jund Midrange (BRG)
#05 shufflerpwned: UBRG Control (UBRG)
#06 Icteridae: Eldrazi Tron (C)
#07 l337erhosen: Elementals (WUBRG)
#08 runon123: Devoted (WBG)
#09 grinderA: Bushwhacker Zoo (WRG)
#10 TheWholePeter: Bant Control (WUG)
#11 cometa183: Bant Control (WUG)
#12 SourceOdin: Thopter Urza (WUR)
#13 qbturtle15: Jund Midrange (BRG)
#14 PanJ: Mardu Shadow (WBR)
#15 RNGspecialist: Uroza (URG)
#16 Rav104: Green Tron (G)
#17 nickrelativity: Eldrazi Tron (C)
#18 __matsugan: Neobrand (UG)
#19 Butakov: Jund Midrange (BRG)
#20 Just-In: Gruul Midrange (RG)
#21 billsive: Green Tron (G)
#22 Boland: Grixis Shadow (UBR)
#23 sandydogmtg: Bushwhacker Zoo (WRG)
#24 joker10289: Gruul Midrange (RG)
#25 dbroncs1: Jund Midrange (BRG)
#26 MEG: Dredge (UBRG)
#27 Redgy: Bant Control (WUG)
#28 mazenemaze: Saheeli Combo (WURG)
#29 Fugate: Neobrand (UG)
#30 Codeman138: Titan Shift (RG)
#31 quinniac: Green Tron (G)
#32 bresett123: Bant Control (WUG)
#33 Trieste: Mardu Shadow (WBR)
#34 hugofreitas1: Gifts Storm (UR)
#35 jorgefpcardoso: Mardu Midrange (WBR)
#36 i_b_TRUE: Jund Midrange (BRG)
#37 Toastxp: Uroza (URG)
#38 sicsmoo: Eldrazi Tron (C)
#39 Mordeka1ser: Niv To Light (WUBRG)
#40 martyr1207: Green Tron (G)
#41 bigjc00: Amulet Titan (UG)
#42 el-pollo-lolo: Rakdos Midrange (BR)
#43 Josh12597: Jund Midrange (BRG)
#44 ThePainTrain9: Gruul Midrange (RG)
#45 ApesOfWrath: Burn (R)
#46 Sprouts: Jund Midrange (BRG)
#47 krxn: Jund Midrange (BRG)
#48 excrement: Heliod Sisters (WB)
#49 bit_error: Burn (WR)
#50 _Shatun_: Burn (WR)
#51 Parole: Humans (WUBRG)
#52 Jobbermann: Jund Midrange (BRG)
#53 Redgy819: Green Tron (G)
#54 ConnorM426: Niv To Light (WUBRG)
#55 Gerardo94: Bant Control (WUG)
#56 lukystrike: Burn (WR)
#57 Shadowz2005: Gruul Midrange (RG)
#58 NuBlkAu: Uroza (URG)
#59 Ramunap: Infect (UG)
#60 SunofNothing: Uroza (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_03_31 : EventTest
    {
        [Test]
        public void Deck01_ArchaeusDota_EldraziTron_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",0),
                "PostOuatBan",
                ArchetypeColor.R,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck02_Dalbert_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",1),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck03_Finalnub_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",2),
                "PostOuatBan",
                ArchetypeColor.WURG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck04_joetru_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",3),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_shufflerpwned_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",4),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Icteridae_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",5),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_l337erhosen_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",6),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Elementals",
                null,
                null
            );
        }

        [Test]
        public void Deck08_runon123_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",7),
                "PostOuatBan",
                ArchetypeColor.WBG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck09_grinderA_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",8),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "BushwhackerZoo",
                null,
                null
            );
        }

        [Test]
        public void Deck10_TheWholePeter_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",9),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_cometa183_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",10),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck12_SourceOdin_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",11),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck13_qbturtle15_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",12),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_PanJ_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",13),
                "PostOuatBan",
                ArchetypeColor.WBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck15_RNGspecialist_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",14),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Rav104_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",15),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck17_nickrelativity_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",16),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck18_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",17),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Butakov_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",18),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck20_JustIn_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",19),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck21_billsive_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",20),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck22_Boland_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",21),
                "PostOuatBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck23_sandydogmtg_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",22),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "BushwhackerZoo",
                null,
                null
            );
        }

        [Test]
        public void Deck24_joker10289_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",23),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck25_dbroncs1_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",24),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck26_MEG_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",25),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck27_Redgy_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",26),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck28_mazenemaze_SaheeliCombo_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",27),
                "PostOuatBan",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Fugate_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",28),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Codeman138_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",29),
                "PostOuatBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck31_quinniac_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",30),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck32_bresett123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",31),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck33_Trieste_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",32),
                "PostOuatBan",
                ArchetypeColor.WBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck34_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",33),
                "PostOuatBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck35_jorgefpcardoso_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",34),
                "PostOuatBan",
                ArchetypeColor.WBR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck36_ibTRUE_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",35),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck37_Toastxp_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",36),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck38_sicsmoo_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",37),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck39_Mordeka1ser_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",38),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck40_martyr1207_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",39),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck41_bigjc00_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",40),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck42_elpollololo_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",41),
                "PostOuatBan",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck43_Josh12597_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",42),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck44_ThePainTrain9_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",43),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck45_ApesOfWrath_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",44),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck46_Sprouts_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",45),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck47_krxn_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",46),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck48_excrement_HeliodSisters_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",47),
                "PostOuatBan",
                ArchetypeColor.WB,
                "HeliodSisters",
                null,
                null
            );
        }

        [Test]
        public void Deck49_biterror_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",48),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck50_Shatun_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",49),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck51_Parole_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",50),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck52_Jobbermann_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",51),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck53_Redgy819_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",52),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck54_ConnorM426_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",53),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck55_Gerardo94_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",54),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck56_lukystrike_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",55),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck57_Shadowz2005_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",56),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck58_NuBlkAu_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",57),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck59_Ramunap_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",58),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck60_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",59),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }


    }
}
