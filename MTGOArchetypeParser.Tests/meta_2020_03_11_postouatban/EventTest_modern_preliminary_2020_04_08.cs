using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 in5ano: Thopter Urza (WUR)
#02 mark_68: Mono Red Prowess (R)
#03 HCHAK: Uroza (URG)
#04 Rinko: Goryo Reanimator (BRG)
#05 Dafne17: Gruul Midrange (RG)
#06 Violent_Outburst: Polymorph (WUR)
#07 Gigy: Humans (WUBRG)
#08 _Antoniou_: Niv To Light (WUBRG)
#09 envizz: Jund Midrange (BRG)
#10 a_p_s: Gruul Midrange (RG)
#11 Toastxp: Uroza (URG)
#12 JustBurn420: Slivers (WUBRG)
#13 winterlong: Dredge (BRG)
#14 coert: Burn (WR)
#15 alemilan19: Dredge (BRG)
#16 selbstdenker: Niv To Light (WUBRG)
#17 PRGJJAR: Dredge (BRG)
#18 Laplasjan: Gruul Midrange (RG)
#19 12Days: Gruul Midrange (RG)
#20 Darthkid: Niv To Light (WUBRG)
#21 Blueliner: Green Control (G)
#22 Turn5: Izzet Control (UR)
#23 __matsugan: Neobrand (UG)
#24 ACG88: Niv To Light (WUBRG)
#25 jessy_samek: Uroza (URG)
#26 hikid: Amulet Titan (UG)
#27 grinderA: Gruul Midrange (RG)
#28 IsKeiP529: Green Tron (G)
#29 2n0r1ax: Inverter Combo (WUB)
#30 TSPJendrek: Esper Control (WUB)
#31 Oscar_Franco: Ad Nauseam (WUB)
#32 Rudokant: Temur Control (URG)
#33 Ravnika_on_fire: Dredge (BRG)
#34 penips: Mono White Taxes (W)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_04_08 : EventTest
    {
        [Test]
        public void Deck01_in5ano_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",0),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck02_mark68_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",1),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck03_HCHAK_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",2),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Rinko_GoryoReanimator_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",3),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GoryoReanimator",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Dafne17_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",4),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_ViolentOutburst_Polymorph_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",5),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "Polymorph",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Gigy_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",6),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Antoniou_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",7),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck09_envizz_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",8),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_aps_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",9),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Toastxp_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",10),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck12_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",11),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck13_winterlong_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",12),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck14_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",13),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck15_alemilan19_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",14),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck16_selbstdenker_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",15),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck17_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",16),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Laplasjan_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",17),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck19_12Days_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",18),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Darthkid_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",19),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Blueliner_GreenControl_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",20),
                "PostOuatBan",
                ArchetypeColor.G,
                "GreenControl",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Turn5_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",21),
                "PostOuatBan",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",22),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck24_ACG88_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",23),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck25_jessysamek_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",24),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck26_hikid_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",25),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck27_grinderA_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",26),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck28_IsKeiP529_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",27),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck29_2n0r1ax_InverterCombo_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",28),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "InverterCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck30_TSPJendrek_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",29),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck31_OscarFranco_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",30),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck32_Rudokant_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",31),
                "PostOuatBan",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck33_Ravnikaonfire_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",32),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck34_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",33),
                "PostOuatBan",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }


    }
}
