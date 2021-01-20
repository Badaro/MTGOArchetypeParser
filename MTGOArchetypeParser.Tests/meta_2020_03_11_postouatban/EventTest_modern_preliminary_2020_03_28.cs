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
#01 ReturnToDust: Eldrazi Tron (C)
#02 genkytoro: Jund Midrange (BRG)
#03 SCJ: Uroza (URG)
#04 fuya: Burn (WR)
#05 yamakiller: Bushwhacker Zoo (WRG)
#06 Ouranos139: Amulet Titan (UG)
#07 Binter: Mono Red Prowess (R)
#08 GGoggles: Dice Factory Tron (C)
#09 Sonic_Smasher: Bant Control (WUG)
#10 hikid: Amulet Titan (UG)
#11 ThatAsianGuy8: Jund Midrange (BRG)
#12 kasa: Amulet Titan (UG)
#13 Usama96: Azorius Control (WU)
#14 Appoggiatura: Bogles (WG)
#15 n00bcheesepwner: Amulet Titan (UG)
#16 AlabasterWolfie: Grinding Breach (UBR)
#17 RealJoy: Humans (WUBRG)
#18 kponceMTG: Boros Taxes (WR)
#19 RandomOctopus: Grixis Shadow (UBR)
#20 Bugsy69: Uroza (URG)
#21 _Batutinha_: Primeval Titan (WUG)
#22 im2g00t4ubarn: Uroza (URG)
#23 bresett123: Bant Control (WUG)
#24 Rexplosion: Jund Midrange (BRG)
#25 gyyby297: Thopter Urza (WUB)
#26 ThePainTrain9: Eldrazi Tron (C)
#27 FranPi: Gifts Storm (UR)
#28 Nammersquats: Infect (UG)
#29 B1gDan: Bant Midrange (WUG)
#30 Boucha: Dredge (BRG)
#31 koji1130: Titan Shift (RG)
#32 signblindman: Uroza (URG)
#33 rickmendi: Mono Red Prowess (R)
#34 taylor91: Neobrand (UG)
#35 Insidious: Mono Red Prowess (R)
#36 TheRealRickJames: Uroza (UBG)
#37 DeepFrdKirby: Slivers (WUBRG)
#38 Theo_Jung: Uroza (URG)
#39 nietzreznor: Primeval Titan (BG)
#40 Draconic1: Gifts Storm (UR)
#41 E_Kaminuma: Titan Shift (RG)
#42 GrapeLightning: Crabvine (UBG)
#43 felider: Gruul Midrange (RG)
#44 ConnorM426: Bant Control (WUG)
#45 ice_nine_: Land Destruction (WR)
#46 chenstein9: Jund Midrange (BRG)
#47 masongrode: Bant Control (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_03_28 : EventTest
    {
        [Test]
        public void Deck01_ReturnToDust_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",0),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_genkytoro_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",1),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_SCJ_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",2),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck04_fuya_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",3),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck05_yamakiller_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",4),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Ouranos139_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",5),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_Binter_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",6),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck08_GGoggles_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",7),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(DiceFactoryTron),
                null
            );
        }

        [Test]
        public void Deck09_SonicSmasher_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",8),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_hikid_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",9),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck11_ThatAsianGuy8_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",10),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_kasa_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",11),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_Usama96_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",12),
                new PostOuatBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Appoggiatura_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",13),
                new PostOuatBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck15_n00bcheesepwner_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",14),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck16_AlabasterWolfie_GrindingBreach_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",15),
                new PostOuatBan(),
                ArchetypeColor.UBR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck17_RealJoy_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",16),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck18_kponceMTG_BorosTaxes_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",17),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck19_RandomOctopus_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",18),
                new PostOuatBan(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Bugsy69_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",19),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Batutinha_PrimevalTitan_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",20),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck22_im2g00t4ubarn_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",21),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck23_bresett123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",22),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Rexplosion_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",23),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_gyyby297_ThopterUrza_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",24),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck26_ThePainTrain9_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",25),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck27_FranPi_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",26),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",27),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck29_B1gDan_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",28),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Boucha_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",29),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck31_koji1130_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",30),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck32_signblindman_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",31),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck33_rickmendi_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",32),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck34_taylor91_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",33),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Insidious_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",34),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck36_TheRealRickJames_Uroza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",35),
                new PostOuatBan(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck37_DeepFrdKirby_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",36),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck38_TheoJung_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",37),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck39_nietzreznor_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",38),
                new PostOuatBan(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Draconic1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",39),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck41_EKaminuma_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",40),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck42_GrapeLightning_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",41),
                new PostOuatBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck43_felider_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",42),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck44_ConnorM426_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",43),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck45_icenine_LandDestruction_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",44),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(LandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck46_chenstein9_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",45),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck47_masongrode_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-28",46),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
