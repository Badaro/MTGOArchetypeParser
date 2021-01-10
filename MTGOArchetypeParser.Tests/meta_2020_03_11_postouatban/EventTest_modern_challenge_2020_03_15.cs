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
#01 Edel: Jund Midrange (BRG)
#02 sinforlife54: Mono White Taxes (W)
#03 danielmos: Bant Control (WUG)
#04 MiguelCaster: Mono White Taxes (W)
#05 PuntThenWhine: Amulet Titan (UG)
#06 _goblinlackey: Green Tron (G)
#07 SunofNothing: Uroza (UG)
#08 Laplasjan: Eldrazi Tron (C)
#09 A22en: Bant Control (WUG)
#10 Ma7x: Niv To Light (WUBRG)
#11 Tiemuuu: Izzet Control (UR)
#12 Leyline_Of_The_Boys: Bant Control (WUG)
#13 TrollingSaruman: Dredge (WBRG)
#14 haubidtran: Uroza (URG)
#15 _Phoenix_: Humans (WUBRG)
#16 caronte1991: Azorius Control (WU)
#17 oniiman: Mono Red Prowess (R)
#18 Trellon: Blue Tron (U)
#19 ThePurpleMage: Devoted (WBG)
#20 HarlanMTG: Azorius Control (WU)
#21 Sharkcaster_Mage: Green Tron (G)
#22 angelsjeffrey: Mono Red Prowess (R)
#23 Patxi: Dredge (BRG)
#24 oppodump: WURG Control (WURG)
#25 TSPJendrek: Bant Control (WUG)
#26 Higdur: Infect (UG)
#27 Chipsoss: Golgari Midrange (BG)
#28 Gerardo94: Bant Control (WUG)
#29 Maccaciock: Izzet Control (UR)
#30 Epachniak: Mono Red Prowess (R)
#31 Aje8: Mono Red Prowess (R)
#32 BlueLips: Bant Control (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_challenge_2020_03_15 : EventTest
    {
        [Test]
        public void Deck01_Edel_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",0),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_sinforlife54_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",1),
                new PostOuatBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck03_danielmos_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",2),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_MiguelCaster_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",3),
                new PostOuatBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck05_PuntThenWhine_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",4),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck06_goblinlackey_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",5),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck07_SunofNothing_Uroza_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",6),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Laplasjan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",7),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck09_A22en_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",8),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Ma7x_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",9),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",10),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_LeylineOfTheBoys_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",11),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_TrollingSaruman_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",12),
                new PostOuatBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck14_haubidtran_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",13),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Phoenix_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",14),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck16_caronte1991_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",15),
                new PostOuatBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_oniiman_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",16),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Trellon_BlueTron_U()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",17),
                new PostOuatBan(),
                ArchetypeColor.U,
                typeof(Tron),
                typeof(BlueTron),
                null
            );
        }

        [Test]
        public void Deck19_ThePurpleMage_Devoted_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",18),
                new PostOuatBan(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck20_HarlanMTG_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",19),
                new PostOuatBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_SharkcasterMage_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",20),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck22_angelsjeffrey_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",21),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Patxi_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",22),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck24_oppodump_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",23),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_TSPJendrek_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",24),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Higdur_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",25),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Chipsoss_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",26),
                new PostOuatBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Gerardo94_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",27),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Maccaciock_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",28),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Epachniak_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",29),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Aje8_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",30),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck32_BlueLips_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-15",31),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
