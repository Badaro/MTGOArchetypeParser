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
#01 rastaf: Gruul Midrange (RG)
#02 hugofreitas1: Gifts Storm (UR)
#03 Gernardi: Gruul Midrange (RG)
#04 SunofNothing: Uroza (URG)
#05 ianisrad: Infect (UG)
#06 SENPAI_Peter: Bushwhacker Zoo (WRG)
#07 dgreen16: Burn (WRG)
#08 qbturtle15: Zoo (WRG)
#09 Whitecell: Infect (UG)
#10 SpiderSpace: Selesnya Taxes (WG)
#11 Kazuga: Green Tron (G)
#12 Trisky: Humans (WUBRG)
#13 603Leb: Green Tron (G)
#14 mark_68: Mono Red Prowess (R)
#15 joker10289: Burn (WR)
#16 TehMetal22: Burn (WR)
#17 Berserker_BOB: Gruul Midrange (RG)
#18 StormlightReaper: Eldrazi Tron (C)
#19 MKC: Humans (WUBRG)
#20 Lord_Beerus: Burn (WR)
#21 grinderA: Gruul Midrange (RG)
#22 PhReSHTinGZ: Golgari Midrange (BG)
#23 SixScry: Amulet Titan (UG)
#24 2Clo: Amulet Titan (UG)
#25 cool95: Elementals (WUBRG)
#26 BReal2: Mardu Shadow (WBR)
#27 herrelljp: Mono Red Prowess (R)
#28 _EzMud1: Gruul Midrange (RG)
#29 tillwehavefaces: Humans (WUBRG)
#30 Milkk: Naya Midrange (WRG)
#31 martyr1207: Humans (WUBRG)
#32 BigDaddyVince: Jund Midrange (BRG)
#33 _Logic_: Smallpox (WB)
#34 instantdeath929: Amulet Titan (G)
#35 KILLERNARWHAL: Bant Control (WUG)
#36 over_9000: Titan Shift (RG)
#37 red_lymphocyte: Infect (WUG)
#38 yamakiller: Gruul Midrange (RG)
#39 Icteridae: Mono Red Prowess (R)
#40 nahuel10: Burn (WR)
#41 snapcaster____mage: Gruul Midrange (RG)
#42 D00mwake: Burn (WR)
#43 futiboladex: Bant Control (WUG)
#44 TerminalJustice: Humans (WUBRG)
#45 mccloudbro: Mono Red Prowess (R)
#46 bwheezy: Jeskai Control (WUR)
#47 Funnyman31399: UBRG Shadow (UBRG)
#48 Bigmac1022: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_04_07 : EventTest
    {
        [Test]
        public void Deck01_rastaf_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",0),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",1),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Gernardi_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",2),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",3),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck05_ianisrad_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",4),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck06_SENPAIPeter_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",5),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck07_dgreen16_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",6),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck08_qbturtle15_Zoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",7),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(Zoo),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Whitecell_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",8),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck10_SpiderSpace_SelesnyaTaxes_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",9),
                new PostOuatBan(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Kazuga_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",10),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck12_Trisky_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",11),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_603Leb_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",12),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck14_mark68_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",13),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck15_joker10289_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",14),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck16_TehMetal22_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",15),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck17_BerserkerBOB_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",16),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_StormlightReaper_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",17),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck19_MKC_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",18),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck20_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",19),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck21_grinderA_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",20),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_PhReSHTinGZ_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",21),
                new PostOuatBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_SixScry_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",22),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_2Clo_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",23),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck25_cool95_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",24),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck26_BReal2_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",25),
                new PostOuatBan(),
                ArchetypeColor.WBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck27_herrelljp_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",26),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck28_EzMud1_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",27),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck29_tillwehavefaces_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",28),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Milkk_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",29),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_martyr1207_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",30),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck32_BigDaddyVince_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",31),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Logic_Smallpox_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",32),
                new PostOuatBan(),
                ArchetypeColor.WB,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck34_instantdeath929_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",33),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck35_KILLERNARWHAL_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",34),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck36_over9000_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",35),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck37_redlymphocyte_Infect_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",36),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck38_yamakiller_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",37),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Icteridae_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",38),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck40_nahuel10_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",39),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck41_snapcastermage_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",40),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck42_D00mwake_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",41),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck43_futiboladex_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",42),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck44_TerminalJustice_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",43),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck45_mccloudbro_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",44),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck46_bwheezy_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",45),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Funnyman31399_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",46),
                new PostOuatBan(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck48_Bigmac1022_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-07",47),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
