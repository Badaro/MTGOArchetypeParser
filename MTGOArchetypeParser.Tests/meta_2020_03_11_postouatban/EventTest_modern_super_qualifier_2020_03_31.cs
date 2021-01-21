using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Mercenario: Dredge (UBRG)
#02 tangrams: Uroza (URG)
#03 yamakiller: Gruul Midrange (RG)
#04 Darthkid: Gruul Midrange (RG)
#05 maxxattack: Infect (UG)
#06 TheMelkMan: Green Tron (G)
#07 ecobaronen: Bant Control (WUG)
#08 nekonekoneko: Burn (WR)
#09 ACG88: Primeval Titan (BG)
#10 fpawlusz: Amulet Titan (UG)
#11 frilund: Green Tron (G)
#12 ZoeR: Burn (WR)
#13 SamuelGraebner: Uroza (URG)
#14 SoulStrong: Bant Control (WUG)
#15 Gerschi: Temur Control (URG)
#16 _kg: Ad Nauseam (WUB)
#17 Middeterminist: Temur Midrange (URG)
#18 drVendigo: Mono Red Prowess (R)
#19 Graciasportanto: Uroza (URG)
#20 Jenara19: Primeval Titan (BG)
#21 NoobPT: Uroza (URG)
#22 Jositoshekel: Bushwhacker Zoo (WRG)
#23 aspiringspike: Superfriends (WUBRG)
#24 SunofNothing: Uroza (URG)
#25 pbarrrgh: Temur Control (URG)
#26 CitrusD: Yawgmoth (BG)
#27 instantQ: Burn (WR)
#28 meanfannypack: Humans (WUBRG)
#29 rdoe14: Burn (WRG)
#30 Tirachii: Jund Shadow (BRG)
#31 TSPJendrek: Esper Control (WUB)
#32 5ives: Dredge (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_super_qualifier_2020_03_31 : EventTest
    {
        [Test]
        public void Deck01_Mercenario_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",0),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck02_tangrams_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",1),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck03_yamakiller_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",2),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Darthkid_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",3),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_maxxattack_Infect_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",4),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck06_TheMelkMan_GreenTron_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",5),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck07_ecobaronen_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",6),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_nekonekoneko_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",7),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck09_ACG88_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",8),
                "PostOuatBan",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck10_fpawlusz_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",9),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck11_frilund_GreenTron_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",10),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck12_ZoeR_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",11),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck13_SamuelGraebner_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",12),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck14_SoulStrong_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",13),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Gerschi_TemurControl_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",14),
                "PostOuatBan",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_kg_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",15),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Middeterminist_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",16),
                "PostOuatBan",
                ArchetypeColor.URG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck18_drVendigo_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",17),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck19_Graciasportanto_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",18),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Jenara19_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",19),
                "PostOuatBan",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck21_NoobPT_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",20),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Jositoshekel_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",21),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "BushwhackerZoo",
                null,
                null
            );
        }

        [Test]
        public void Deck23_aspiringspike_Superfriends_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",22),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Superfriends",
                null,
                null
            );
        }

        [Test]
        public void Deck24_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",23),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck25_pbarrrgh_TemurControl_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",24),
                "PostOuatBan",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck26_CitrusD_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",25),
                "PostOuatBan",
                ArchetypeColor.BG,
                "Yawgmoth",
                null,
                null
            );
        }

        [Test]
        public void Deck27_instantQ_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",26),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck28_meanfannypack_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",27),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck29_rdoe14_Burn_WRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",28),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck30_Tirachii_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",29),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck31_TSPJendrek_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",30),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck32_5ives_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-31",31),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }


    }
}
