using FluentAssertions;
using MTGOArchetypeParser.Model;
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
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck02_ThePainTrain9_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",1),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck03_raisans_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",2),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck04_RicardoMSLan_GreenTron_WG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",3),
                "PostOuatBan",
                ArchetypeColor.WG,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck05_DDMeelow_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",4),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck06_kg_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",5),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_MadMaxErnst_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",6),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck08_ChillingLauge_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",7),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck09_IlNano_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",8),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck10_3HaLeX1_Bogles_WG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",9),
                "PostOuatBan",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck11_CapitanoCL_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",10),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck12_muckymuckdc5_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",11),
                "PostOuatBan",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck13_wrennandsixnine_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",12),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Brener_ThopterUrza_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",13),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck15_Maccaciock_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",14),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_SoIMBAAirwave_GreenEldrazi_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",15),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GreenEldrazi",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Vasoi2323_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",16),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Coly2_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",17),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck19_MartinezDP_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",18),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Aira_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",19),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_exoticherman_Infect_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",20),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck22_fgfonseca182_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",21),
                "PostOuatBan",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck23_idutra_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",22),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck24_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",23),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck25_HeirofElendil15_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",24),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck26_anaccidentalman_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",25),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck27_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",26),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck28_Mistakenn_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",27),
                "PostOuatBan",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck29_zMunkeyXz_Mill_UBG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",28),
                "PostOuatBan",
                ArchetypeColor.UBG,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck30_OscarFranco_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",29),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck31_thepensword_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",30),
                "PostOuatBan",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck32_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-07",31),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }


    }
}
