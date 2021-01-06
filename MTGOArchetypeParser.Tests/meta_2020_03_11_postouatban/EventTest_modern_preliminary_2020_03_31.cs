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
#01 ArchaeusDota: Eldrazi Tron (C)
#02 Dalbert: Mono Red Prowess (R)
#03 Finalnub: Scapeshift (WURG)
#04 joetru: Jund Midrange (BRG)
#05 shufflerpwned: Sultai Control (UBG)
#06 Icteridae: Eldrazi Tron (C)
#07 l337erhosen: Elementals (WUBRG)
#08 runon123: Devoted (WG)
#09 grinderA: Bushwhacker Zoo (WRG)
#10 TheWholePeter: Bant Control (WUG)
#11 cometa183: Bant Control (WUG)
#12 SourceOdin: Thopter Urza (WUR)
#13 qbturtle15: Jund Midrange (BRG)
#14 PanJ: Mardu Shadow (WBR)
#15 RNGspecialist: Uroza (UG)
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
#26 MEG: Dredge (BRG)
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
#37 Toastxp: Uroza (UG)
#38 sicsmoo: Eldrazi Tron (C)
#39 Mordeka1ser: Niv To Light (WUBRG)
#40 martyr1207: Green Tron (G)
#41 bigjc00: Amulet Titan (G)
#42 el-pollo-lolo: Rakdos Midrange (BR)
#43 Josh12597: Jund Midrange (BRG)
#44 ThePainTrain9: Gruul Midrange (RG)
#45 ApesOfWrath: Burn (R)
#46 Sprouts: Jund Midrange (BRG)
#47 krxn: Jund Midrange (BRG)
#48 excrement: Nykthos Devotion (W)
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
#60 SunofNothing: Uroza (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_03_31 : EventTest
    {
        [Test]
        public void Deck01_ArchaeusDota_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",0),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_Dalbert_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",1),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Finalnub_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",2),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck04_joetru_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",3),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_shufflerpwned_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",4),
                new PostOuatBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Icteridae_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",5),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_l337erhosen_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",6),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck08_runon123_Devoted_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",7),
                new PostOuatBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck09_grinderA_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",8),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck10_TheWholePeter_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",9),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_cometa183_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",10),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_SourceOdin_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",11),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck13_qbturtle15_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",12),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_PanJ_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",13),
                new PostOuatBan(),
                ArchetypeColor.WBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck15_RNGspecialist_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",14),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Rav104_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",15),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck17_nickrelativity_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",16),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck18_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",17),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Butakov_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",18),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_JustIn_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",19),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_billsive_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",20),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck22_Boland_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",21),
                new PostOuatBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck23_sandydogmtg_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",22),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck24_joker10289_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",23),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_dbroncs1_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",24),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_MEG_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",25),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Redgy_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",26),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_mazenemaze_SaheeliCombo_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",27),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Fugate_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",28),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Codeman138_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",29),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck31_quinniac_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",30),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck32_bresett123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",31),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Trieste_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",32),
                new PostOuatBan(),
                ArchetypeColor.WBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck34_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",33),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck35_jorgefpcardoso_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",34),
                new PostOuatBan(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck36_ibTRUE_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",35),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Toastxp_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",36),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck38_sicsmoo_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",37),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck39_Mordeka1ser_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",38),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck40_martyr1207_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",39),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck41_bigjc00_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",40),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck42_elpollololo_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",41),
                new PostOuatBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Josh12597_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",42),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck44_ThePainTrain9_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",43),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck45_ApesOfWrath_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",44),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck46_Sprouts_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",45),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck47_krxn_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",46),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck48_excrement_NykthosDevotion_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",47),
                new PostOuatBan(),
                ArchetypeColor.W,
                typeof(NykthosDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck49_biterror_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",48),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Shatun_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",49),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Parole_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",50),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Jobbermann_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",51),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck53_Redgy819_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",52),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck54_ConnorM426_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",53),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck55_Gerardo94_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",54),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck56_lukystrike_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",55),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck57_Shadowz2005_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",56),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck58_NuBlkAu_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",57),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck59_Ramunap_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",58),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck60_SunofNothing_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-31",59),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }


    }
}
