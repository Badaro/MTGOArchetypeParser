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
#12 Store_Shop5: Simic Control (UG)
#13 maxxattack: Infect (UG)
#14 cicciogire: Jund Midrange (BRG, Lurrus)
#15 snapcaster____mage: Primeval Titan (BG)
#16 hoveydw: Delver (UBR, Lurrus)
#17 Searzist: Burn (WR, Lurrus)
#18 joker10289: Jeskai Control (WUR, Lurrus)
#19 pizzaslinger: Golgari Midrange (BG, Lurrus)
#20 CookieKid00: Jund Midrange (BRG, Lurrus)
#21 qbturtle15: Heliod Combo (WG, Zirda)
#22 Hemsley: Hardened Scales (G, Lurrus)
#23 Magicofplayer1: Dredge (BRG)
#24 SrTortinha: Unknown (BRG)
#25 SunofNothing: Burn (WR, Lurrus)
#26 ilsecco14: Burn (WR, Lurrus)
#27 Moctzal: Burn (WR)
#28 hugo87: Gifts Storm (UR)
#29 Mistakenn: Amulet Titan (UG)
#30 MinT_: Ad Nauseam,Inverter Combo (WUB)
#31 Naisirc: Hardened Scales (BG, Lurrus)
#32 DrDub: Unknown (R)
#33 cometa183: Neobrand (UG)
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
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck02_tangrams_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",1),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_ManavonRX_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",2),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck04_GhostfaceVanilla_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",3),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_twinlesstwin_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",4),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Delver),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_KIMCHIMAN_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",5),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Ouranos139_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",6),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_exoticherman_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",7),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_MdvWin_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",8),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_smurph729_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",9),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_AvocadoToast_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",10),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_StoreShop5_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",11),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_maxxattack_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",12),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck14_cicciogire_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",13),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_snapcastermage_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",14),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck16_hoveydw_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",15),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Delver),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_Searzist_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",16),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_joker10289_JeskaiControl_WUR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",17),
                new PostIkoria(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_pizzaslinger_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",18),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_CookieKid00_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",19),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_qbturtle15_HeliodCombo_WG_Zirda()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",20),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck22_Hemsley_HardenedScales_G_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",21),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_Magicofplayer1_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",22),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck24_SrTortinha_Unknown_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",23),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck25_SunofNothing_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",24),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_ilsecco14_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",25),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_Moctzal_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",26),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck28_hugo87_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",27),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Mistakenn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",28),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck30_MinT_Unknown_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",29),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(InverterCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Naisirc_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",30),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_DrDub_Unknown_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",31),
                new PostIkoria(),
                ArchetypeColor.R,
                typeof(EightWhack),
                null,
                null
            );
        }

        [Test]
        public void Deck33_cometa183_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",32),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck34_LordBeerus_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-23",33),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
