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
#01 Naisirc: Gruul Midrange (RG)
#02 GiestOfIWin: Primeval Titan (UG)
#03 Cygnus86: Eldrazi Tron (C)
#04 BReal2: Mardu Midrange (WBR)
#05 Misplacedginger: Bant Control (WUG)
#06 Toastxp: Uroza (URG)
#07 cftsoc3: Simic Control (UG)
#08 exoticherman: Infect (UG)
#09 Gigy: Gruul Midrange (RG)
#10 twinlesstwin: Scapeshift (UBRG)
#11 Insidious: Burn (WR)
#12 RealJoy: Amulet Titan (UG)
#13 t_k_h_r: Uroza (URG)
#14 maear: Ad Nauseam (WUB)
#15 Ouranos139: Amulet Titan (UG)
#16 natedognpeking: Naya Midrange (WRG)
#17 penips: Mono White Taxes (W)
#18 signblindman: Gruul Midrange (RG)
#19 SvenSveeterSven: Mardu Midrange (WBR)
#20 zMagic4ever: Gruul Midrange (RG)
#21 PhReSHTinGZ: Amulet Titan (UG)
#22 HappySandwich: Gruul Midrange (RG)
#23 eclipse4343: Azorius Control (WU)
#24 Hyeri0418: Dredge (BRG)
#25 qcsando: Heliod Combo (WBG)
#26 Janh: Saheeli Combo (WUR)
#27 BaronOfBacon: Uroza (WURG)
#28 bamzing: Primeval Titan (BG)
#29 Manacymbal: UBRG Control (UBRG)
#30 Cryptic_Remand: Bant Control (WUG)
#31 _Ingles_: Burn (WR)
#32 AvocadoToast: Primeval Titan (BG)
#33 quinniac: Burn (WR)
#34 Lord_of_Puntlantis: Bushwhacker Zoo (WRG)
#35 AndyAWKWARD: Bant Control (WUG)
#36 TheTunnelingCat: Eldrazi Tron (C)
#37 yamakiller: Gruul Midrange (RG)
#38 David1987: Niv To Light (WUBRG)
#39 egadd2894: Niv To Light (WUBRG)
#40 instantQ: Burn (WR)
#41 sydneydude: Uroza (URG)
#42 RandomOctopus: Uroza (URG)
#43 Tsubasa_Cat: Burn (WR)
#44 SouthernSliver: Slivers (WUBRG)
#45 remf: Gruul Midrange (RG)
#46 fgfonseca182: Gruul Midrange (RG)
#47 LickNsticK: Golgari Midrange (BG)
#48 nahuel10: Burn (WR)
#49 FreshKale: Gruul Midrange (RG)
#50 TFTIjhub: Niv To Light (WUBRG)
#51 genkytoro: Jund Midrange (BRG)
#52 ThePainTrain9: Gruul Midrange (RG)
#53 LLegend: Electro Balance (URG)
#54 goodplayer95: Uroza (UG)
#55 mao1986: Izzet Control (UR)
#56 mansak: Jund Midrange (BRG)
#57 AndyGrey: Niv To Light (WUBRG)
#58 nola_gold: Yawgmoth (BG)
#59 taylor91: Neobrand (UG)
#60 Werepigs: Spirits (WU)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_04_11 : EventTest
    {
        [Test]
        public void Deck01_Naisirc_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",0),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_GiestOfIWin_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",1),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Cygnus86_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",2),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck04_BReal2_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",3),
                new PostOuatBan(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Misplacedginger_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",4),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Toastxp_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",5),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck07_cftsoc3_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",6),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_exoticherman_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",7),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",8),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_twinlesstwin_Scapeshift_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",9),
                new PostOuatBan(),
                ArchetypeColor.UBRG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Insidious_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",10),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck12_RealJoy_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",11),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_tkhr_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",12),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck14_maear_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",13),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Ouranos139_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",14),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck16_natedognpeking_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",15),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",16),
                new PostOuatBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck18_signblindman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",17),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_SvenSveeterSven_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",18),
                new PostOuatBan(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_zMagic4ever_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",19),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_PhReSHTinGZ_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",20),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck22_HappySandwich_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",21),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",22),
                new PostOuatBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Hyeri0418_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",23),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck25_qcsando_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",24),
                new PostOuatBan(),
                ArchetypeColor.WBG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Janh_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",25),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck27_BaronOfBacon_Uroza_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",26),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck28_bamzing_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",27),
                new PostOuatBan(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Manacymbal_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",28),
                new PostOuatBan(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_CrypticRemand_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",29),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Ingles_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",30),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck32_AvocadoToast_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",31),
                new PostOuatBan(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck33_quinniac_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",32),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck34_LordofPuntlantis_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",33),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck35_AndyAWKWARD_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",34),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck36_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",35),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck37_yamakiller_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",36),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck38_David1987_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",37),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck39_egadd2894_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",38),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck40_instantQ_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",39),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck41_sydneydude_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",40),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck42_RandomOctopus_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",41),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck43_TsubasaCat_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",42),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck44_SouthernSliver_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",43),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck45_remf_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",44),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck46_fgfonseca182_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",45),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck47_LickNsticK_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",46),
                new PostOuatBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck48_nahuel10_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",47),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck49_FreshKale_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",48),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck50_TFTIjhub_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",49),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck51_genkytoro_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",50),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck52_ThePainTrain9_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",51),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck53_LLegend_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",52),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck54_goodplayer95_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",53),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck55_mao1986_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",54),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck56_mansak_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",55),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck57_AndyGrey_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",56),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck58_nolagold_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",57),
                new PostOuatBan(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck59_taylor91_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",58),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck60_Werepigs_Spirits_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-11",59),
                new PostOuatBan(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }


    }
}
