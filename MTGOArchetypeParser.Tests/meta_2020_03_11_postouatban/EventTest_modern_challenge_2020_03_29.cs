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
#01 Graciasportanto: Uroza (URG)
#02 xame3: Burn (WR)
#03 122pablo: Ascendancy Combo (WURG)
#04 fatkiddestroyers: Bant Midrange (WUG)
#05 genkytoro: Jund Midrange (BRG)
#06 Traft: Humans (WUBRG)
#07 oniiman: Mono Red Prowess (R)
#08 APAKane: Gruul Midrange (RG)
#09 kastermester: Jund Midrange (BRG)
#10 mashmalovsky: Bushwhacker Zoo (WRG)
#11 Capitano_CL: Dredge (BRG)
#12 WeareVenom: Bant Control (WUG)
#13 _LSN_: Burn (WR)
#14 Leyline_Of_The_Boys: Bant Control (WUG)
#15 remf: Gruul Midrange (RG)
#16 Laplasjan: Eldrazi Tron (C)
#17 _Phoenix_: Amulet Titan (UG)
#18 ReturnToDust: Eldrazi Tron (C)
#19 Grischdl: Jund Midrange (BRG)
#20 SCJ: Uroza (URG)
#21 Epachniak: Titan Shift (RG)
#22 stainerson: Niv To Light (WUBRG)
#23 SoulStrong: Bant Control (WUG)
#24 quinniac: Green Tron (G)
#25 ConnorM426: Bant Control (WUG)
#26 staples87: Eldrazi Tron (C)
#27 MiniCrow: Humans (WUBRG)
#28 AbelMolto: Burn (WRG)
#29 Parrit: Mono White Taxes (W)
#30 Maox: Dredge (BRG)
#31 Jsnyder207: Knightfall (WUG)
#32 FlyersIHC: Infect (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_challenge_2020_03_29 : EventTest
    {
        [Test]
        public void Deck01_Graciasportanto_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",0),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck02_xame3_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",1),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck03_122pablo_AscendancyCombo_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",2),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(AscendancyCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck04_fatkiddestroyers_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",3),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_genkytoro_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",4),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Traft_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",5),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck07_oniiman_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",6),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck08_APAKane_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",7),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_kastermester_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",8),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_mashmalovsky_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",9),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck11_CapitanoCL_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",10),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_WeareVenom_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",11),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",12),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck14_LeylineOfTheBoys_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",13),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_remf_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",14),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Laplasjan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",15),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck17_Phoenix_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",16),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck18_ReturnToDust_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",17),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck19_Grischdl_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",18),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_SCJ_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",19),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Epachniak_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",20),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck22_stainerson_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",21),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck23_SoulStrong_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",22),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_quinniac_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",23),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck25_ConnorM426_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",24),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_staples87_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",25),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck27_MiniCrow_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",26),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck28_AbelMolto_Burn_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",27),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck29_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",28),
                new PostOuatBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Maox_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",29),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Jsnyder207_Knightfall_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",30),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(Knightfall),
                null,
                null
            );
        }

        [Test]
        public void Deck32_FlyersIHC_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-29",31),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }


    }
}
