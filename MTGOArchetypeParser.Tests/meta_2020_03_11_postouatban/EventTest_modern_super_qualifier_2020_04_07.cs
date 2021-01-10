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
#01 RNGspecialist: Niv To Light (WUBRG)
#02 ThePainTrain9: Humans (WUBRG)
#03 raisans: Thopter Urza (WUR)
#04 RicardoMSLan: Green Tron (WG)
#05 DDMeelow: Uroza (URG)
#06 _kg: Gruul Midrange (RG)
#07 MadMaxErnst: Uroza (URG)
#08 ChillingLauge: Dredge (BRG)
#09 _IlNano_: Humans (WUBRG)
#10 3HaLeX1: Bogles (WG)
#11 Capitano_CL: Dredge (UBRG)
#12 muckymuck_dc5: Mono White Taxes (W)
#13 wrenn_and_sixnine: Humans (WUBRG)
#14 Brener: Thopter Urza (WUB)
#15 Maccaciock: Bant Control (WUG)
#16 SoIMBA_Airwave: Green Eldrazi (RG)
#17 Vasoi2323: Bant Control (WUG)
#18 Coly2: Gruul Midrange (RG)
#19 MartinezDP: Uroza (URG)
#20 Aira-: Bant Control (WUG)
#21 exoticherman: Infect (UG)
#22 fgfonseca182: Heliod Combo (WG)
#23 idutra: Gruul Midrange (RG)
#24 JustBurn420: Slivers (WUBRG)
#25 Heir_of_Elendil15: Naya Midrange (WRG)
#26 anaccidentalman: Dredge (BRG)
#27 __matsugan: Neobrand (UG)
#28 Mistakenn: Amulet Titan (URG)
#29 zMunkeyXz: Mill (UBG)
#30 Oscar_Franco: Ad Nauseam (WUB)
#31 thepensword: Izzet Control (UR)
#32 coert: Burn (WR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_super_qualifier_2020_04_07 : EventTest
    {
        [Test]
        public void Deck01_RNGspecialist_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",0),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck02_ThePainTrain9_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",1),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck03_raisans_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",2),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck04_RicardoMSLan_GreenTron_WG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",3),
                new PostOuatBan(),
                ArchetypeColor.WG,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck05_DDMeelow_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",4),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck06_kg_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",5),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_MadMaxErnst_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",6),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck08_ChillingLauge_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",7),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck09_IlNano_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",8),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_3HaLeX1_Bogles_WG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",9),
                new PostOuatBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck11_CapitanoCL_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",10),
                new PostOuatBan(),
                ArchetypeColor.UBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_muckymuckdc5_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",11),
                new PostOuatBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck13_wrennandsixnine_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",12),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Brener_ThopterUrza_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",13),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck15_Maccaciock_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",14),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_SoIMBAAirwave_GreenEldrazi_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",15),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GreenEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Vasoi2323_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",16),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Coly2_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",17),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_MartinezDP_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",18),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Aira_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",19),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_exoticherman_Infect_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",20),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck22_fgfonseca182_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",21),
                new PostOuatBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck23_idutra_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",22),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",23),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck25_HeirofElendil15_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",24),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_anaccidentalman_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",25),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck27_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",26),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Mistakenn_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",27),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck29_zMunkeyXz_Mill_UBG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",28),
                new PostOuatBan(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck30_OscarFranco_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",29),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck31_thepensword_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",30),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",31),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }


    }
}
