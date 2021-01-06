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
#01 Lord_Beerus: Burn (WR)
#02 SourEggnog: Jund Midrange (BRG)
#03 SunofNothing: Uroza (UG)
#04 MEG: Dredge (BRG)
#05 katoriarch123: Bant Control (WUG)
#06 esatheking: Boros Prowess (WR)
#07 GGoggles: Humans (WUBRG)
#08 l337erhosen: Elementals (WUBRG)
#09 RNGspecialist: Bant Control (WUG)
#10 EdB: Amulet Titan (G)
#11 joaoclaudioms: Gruul Midrange (RG)
#12 penips: Orzhov Taxes (WB)
#13 Xwhale: Eldrazi Tron (C)
#14 Capitano_CL: Dredge (BRG)
#15 DreamsOfAshiok: Eldrazi Tron (C)
#16 StoreShop216: Simic Control (UG)
#17 SrTortinha: Gruul Midrange (RG)
#18 _Antoniou_: Orzhov Shadow (WB)
#19 snapcaster____mage: Gruul Midrange (RG)
#20 Caleb_Yetman: Simic Control (UG)
#21 twinlesstwin: Humans (WUBRG)
#22 Dragonjonz: Grixis Shadow (UBR)
#23 TradewindRider: Bant Control (WUG)
#24 Icteridae: Devoted (WUG)
#25 pbarrrgh: Simic Control (UG)
#26 fgfonseca182: Gruul Midrange (RG)
#27 kthanakit26: Burn (WR)
#28 Ma7x: Niv To Light (WUBRG)
#29 HappySandwich: Gruul Midrange (RG)
#30 rastaf: Gruul Midrange (RG)
#31 MastaHorus: Rakdos Midrange (BR)
#32 Toastxp: Uroza (UG)
#33 Itchyone: Gruul Midrange (RG)
#34 qbturtle15: Naya Midrange (WRG)
#35 bernardocssa: Bant Control (WUG)
#36 Snapcaster-Bolt: Amulet Titan (URG)
#37 AvocadoToast: Primeval Titan (BG)
#38 yamakiller: Dredge (BRG)
#39 supermariobro2005: Green Tron (G)
#40 dough_shack: Primeval Titan (UBG)
#41 FlamboyasaurusSex: Dredge (BRG)
#42 ForThoseWhoHaveHeart: Bant Control (WUG)
#43 Gigy: Gruul Midrange (RG)
#44 ReturnToDust: Sun And Moon (WR)
#45 _Shatun_: Gruul Prowess (RG)
#46 CReactor: Dredge (BRG)
#47 __matsugan: Neobrand (UG)
#48 Cuthbertthecat: Bant Control (WUG)
#49 Sonso JF: Dredge (BRG)
#50 quinniac: Burn (WR)
#51 bigjc00: Amulet Titan (G)
#52 Bounds: Bant Control (WUG)
#53 flatnose: Merfolk (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_04_17_0 : EventTest
    {
        [Test]
        public void Deck01_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",0),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck02_SourEggnog_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",1),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_SunofNothing_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",2),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck04_MEG_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",3),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck05_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",4),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_esatheking_BorosProwess_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",5),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck07_GGoggles_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",6),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck08_l337erhosen_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",7),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck09_RNGspecialist_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",8),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_EdB_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",9),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck11_joaoclaudioms_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",10),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_penips_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",11),
                new PostOuatBan(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Xwhale_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",12),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_CapitanoCL_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",13),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck15_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",14),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck16_StoreShop216_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",15),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_SrTortinha_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",16),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Antoniou_OrzhovShadow_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",17),
                new PostOuatBan(),
                ArchetypeColor.WB,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck19_snapcastermage_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",18),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_CalebYetman_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",19),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_twinlesstwin_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",20),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Dragonjonz_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",21),
                new PostOuatBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck23_TradewindRider_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",22),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",23),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck25_pbarrrgh_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",24),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_fgfonseca182_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",25),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck27_kthanakit26_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",26),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Ma7x_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",27),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck29_HappySandwich_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",28),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck30_rastaf_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",29),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_MastaHorus_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",30),
                new PostOuatBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Toastxp_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",31),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Itchyone_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",32),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck34_qbturtle15_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",33),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck35_bernardocssa_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",34),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck36_SnapcasterBolt_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",35),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck37_AvocadoToast_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",36),
                new PostOuatBan(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck38_yamakiller_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",37),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck39_supermariobro2005_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",38),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck40_doughshack_PrimevalTitan_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",39),
                new PostOuatBan(),
                ArchetypeColor.UBG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck41_FlamboyasaurusSex_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",40),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck42_ForThoseWhoHaveHeart_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",41),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",42),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck44_ReturnToDust_SunAndMoon_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",43),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(SunAndMoon),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Shatun_GruulProwess_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",44),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck46_CReactor_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",45),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck47_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",46),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck48_Cuthbertthecat_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",47),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_SonsoJF_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",48),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck50_quinniac_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",49),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck51_bigjc00_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",50),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck52_Bounds_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",51),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck53_flatnose_Merfolk_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-0",52),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }


    }
}
