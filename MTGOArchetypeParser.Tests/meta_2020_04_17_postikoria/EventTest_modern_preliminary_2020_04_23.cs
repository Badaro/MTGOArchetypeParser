using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Icteridae: Devoted (WUG)
#02 tangrams: Uroza (URG, Yorion)
#03 ManavonRX: Amulet Titan (UG)
#04 GhostfaceVanilla: Burn (WR, Lurrus)
#05 twinlesstwin: Delver (UBR, Lurrus)
#06 KIMCHIMAN: Burn (WR, Lurrus)
#07 Ouranos139: Amulet Titan (UG)
#08 exoticherman: Golgari Midrange (BG, Lurrus)
#09 MdvWin: Boros Prowess (WR, Lurrus)
#10 s_murph729: Burn (WR, Lurrus)
#11 AvocadoToast: Jund Midrange (BRG, Lurrus)
#12 Store_Shop5: Reclamation (UG)
#13 maxxattack: Infect (UG)
#14 cicciogire: Jund Midrange (BRG, Lurrus)
#15 snapcaster____mage: Primeval Titan (BG)
#16 hoveydw: Delver (UBR, Lurrus)
#17 Searzist: Burn (WR, Lurrus)
#18 joker10289: Jeskai Control (WUR, Lurrus)
#19 pizzaslinger: Golgari Midrange (BG, Lurrus)
#20 CookieKid00: Jund Midrange (BRG, Lurrus)
#21 qbturtle15: Selesnya Midrange (WG, Zirda)
#22 Hemsley: Hardened Scales (G, Lurrus)
#23 Magicofplayer1: Dredge (BRG)
#24 SrTortinha: Living End (BRG)
#25 SunofNothing: Burn (WR, Lurrus)
#26 ilsecco14: Burn (WR, Lurrus)
#27 Moctzal: Burn (WR)
#28 hugo87: Gifts Storm (UR)
#29 Mistakenn: Amulet Titan (UG)
#30 MinT_: Inverter Combo (WUB)
#31 Naisirc: Hardened Scales (BG, Lurrus)
#32 DrDub: Eight Whack (R)
#33 cometa183: Neobrand (URG)
#34 Lord_Beerus: Burn (WR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_04_23 : EventTest
    {
        [Test]
        public void Deck01_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",0),
                "PostIkoria",
                ArchetypeColor.WUG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck02_tangrams_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",1),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_ManavonRX_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",2),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck04_GhostfaceVanilla_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",3),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_twinlesstwin_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",4),
                "PostIkoria",
                ArchetypeColor.UBR,
                "Delver",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_KIMCHIMAN_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",5),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Ouranos139_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",6),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck08_exoticherman_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",7),
                "PostIkoria",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_MdvWin_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",8),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_smurph729_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",9),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_AvocadoToast_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",10),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_StoreShop5_Reclamation_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",11),
                "PostIkoria",
                ArchetypeColor.UG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck13_maxxattack_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",12),
                "PostIkoria",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck14_cicciogire_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",13),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_snapcastermage_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",14),
                "PostIkoria",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck16_hoveydw_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",15),
                "PostIkoria",
                ArchetypeColor.UBR,
                "Delver",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_Searzist_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",16),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_joker10289_JeskaiControl_WUR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",17),
                "PostIkoria",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_pizzaslinger_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",18),
                "PostIkoria",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_CookieKid00_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",19),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_qbturtle15_SelesnyaMidrange_WG_Zirda()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",20),
                "PostIkoria",
                ArchetypeColor.WG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck22_Hemsley_HardenedScales_G_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",21),
                "PostIkoria",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_Magicofplayer1_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",22),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck24_SrTortinha_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",23),
                "PostIkoria",
                ArchetypeColor.BRG,
                "LivingEnd",
                null,
                null
            );
        }

        [Test]
        public void Deck25_SunofNothing_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",24),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_ilsecco14_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",25),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_Moctzal_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",26),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck28_hugo87_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",27),
                "PostIkoria",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Mistakenn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",28),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck30_MinT_InverterCombo_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",29),
                "PostIkoria",
                ArchetypeColor.WUB,
                "InverterCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Naisirc_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",30),
                "PostIkoria",
                ArchetypeColor.BG,
                "HardenedScales",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_DrDub_EightWhack_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",31),
                "PostIkoria",
                ArchetypeColor.R,
                "EightWhack",
                null,
                null
            );
        }

        [Test]
        public void Deck33_cometa183_Neobrand_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",32),
                "PostIkoria",
                ArchetypeColor.URG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck34_LordBeerus_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",33),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
