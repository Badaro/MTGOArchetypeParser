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
#01 albert62: Jund Midrange (BRG)
#02 nahuel10: Burn (WR)
#03 stainerson: Niv To Light (WUBRG)
#04 SCJ: Jund Midrange (BRG)
#05 _IlNano_: Humans (WUBRG)
#06 remf: Gruul Midrange (RG)
#07 Jenara19: Uroza (URG)
#08 tia05: Primeval Titan (RG)
#09 5ives: Dredge (BRG)
#10 DrPP: Mono Red Prowess (R)
#11 snapcaster____mage: Eldrazi Tron (C)
#12 PRGJJAR: Dredge (BRG)
#13 Kharlem: Mono Red Prowess (R)
#14 ilsecco14: Burn (WR)
#15 stonepeanut: Green Tron (G)
#16 SouthernSliver: Slivers (WUBRG)
#17 MiguelCaster: Mono White Taxes (W)
#18 PermissionMTG: Zoo (WRG)
#19 SunofNothing: Uroza (URG)
#20 SemoMTGBros: WURG Control (WURG)
#21 levunga21: Bant Control (WUG)
#22 TSPJendrek: WUBG Control (WUBG)
#23 Parrit: Orzhov Taxes (WB)
#24 AlexD41: Mono Red Prowess (R)
#25 HarlanMTG: Bant Control (WUG)
#26 yxcvbnm: Bant Control (WUG)
#27 MastaHorus: Electro End (URG)
#28 Gerschi: Thopter Urza (WUR)
#29 pepeteam: Amulet Titan (UG)
#30 Curufinwe: Jund Midrange (BRG)
#31 SlyDaniel7787: Eldrazi Tron (C)
#32 Graciasportanto: Uroza (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_challenge_2020_03_22 : EventTest
    {
        [Test]
        public void Deck01_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",0),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_nahuel10_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",1),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck03_stainerson_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",2),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck04_SCJ_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",3),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_IlNano_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",4),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck06_remf_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",5),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Jenara19_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",6),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck08_tia05_PrimevalTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",7),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck09_5ives_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",8),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_DrPP_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",9),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck11_snapcastermage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",10),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck12_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",11),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Kharlem_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",12),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck14_ilsecco14_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",13),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck15_stonepeanut_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",14),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck16_SouthernSliver_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",15),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck17_MiguelCaster_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",16),
                new PostOuatBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck18_PermissionMTG_Zoo_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",17),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(Zoo),
                null,
                null
            );
        }

        [Test]
        public void Deck19_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",18),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck20_SemoMTGBros_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",19),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_levunga21_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",20),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_TSPJendrek_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",21),
                new PostOuatBan(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Parrit_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",22),
                new PostOuatBan(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck24_AlexD41_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",23),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck25_HarlanMTG_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",24),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_yxcvbnm_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",25),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_MastaHorus_ElectroEnd_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",26),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(FreeSpells),
                typeof(ElectroEnd),
                null
            );
        }

        [Test]
        public void Deck28_Gerschi_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",27),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck29_pepeteam_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",28),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck30_Curufinwe_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",29),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_SlyDaniel7787_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",30),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck32_Graciasportanto_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-22",31),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }


    }
}
