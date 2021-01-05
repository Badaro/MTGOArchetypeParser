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
#01 Patxi: Rakdos Prowess (BR, Lurrus)
#02 SunofNothing: Rakdos Prowess (BR, Lurrus)
#03 AndyAWKWARD: Scapeshift (WURG, Yorion)
#04 zibb: Gruul Midrange (RG, Obosh)
#05 TheYostWithTheMost: Rakdos Prowess (BR, Lurrus)
#06 _LSN_: Burn (WR, Lurrus)
#07 TwistedWombat: Niv To Light (WUBRG, Jegantha)
#08 122pablo: Ascendancy Combo (WURG, Jegantha)
#09 sendoh007: Gruul Midrange (RG, Obosh)
#10 Parrit: Hardened Scales (BG, Lurrus)
#11 matiaskm: Devoted (WG, Lurrus)
#12 fistfullofmetal: Green Tron (G, Jegantha)
#13 PRGJJAR: Dredge (BRG)
#14 tia05: Titan Shift (RG)
#15 Karnesis93: Amulet Titan (G)
#16 xfile: Green Tron (G, Jegantha)
#17 Traft: Scapeshift (URG, Yorion)
#18 Tripalosky: Bogles (WG, Lurrus)
#19 Hoey07: Jund Prowess (BRG, Lurrus)
#20 JOXEMI333: Green Tron (G, Jegantha)
#21 GrandDrou: Rakdos Prowess (BR, Lurrus)
#22 Hemsley: Primeval Titan (BRG, Gyruda)
#23 ArchaeusDota: Green Tron (G, Jegantha)
#24 Karolmo: Jund Midrange (BRG, Lurrus)
#25 Samcaster-Mage: Eldrazi Tron (C)
#26 Thrall90: Jund Midrange (BRG, Lurrus)
#27 Capitano_CL: Rakdos Prowess (BR, Lurrus)
#28 qbturtle15: Jund Midrange (BRG, Lurrus)
#29 SoulStrong: Grixis Control (UBR, Lurrus)
#30 in5ano: Scapeshift (URG, Yorion)
#31 Larry11: Gruul Midrange (RG, Obosh)
#32 Ryan100495: Dredge (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_challenge_2020_05_24 : EventTest
    {
        [Test]
        public void Deck01_Patxi_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",0),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_SunofNothing_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",1),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_AndyAWKWARD_Scapeshift_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",2),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_zibb_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",3),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck05_TheYostWithTheMost_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",4),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_LSN_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",5),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_TwistedWombat_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",6),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck08_122pablo_AscendancyCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",7),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(AscendancyCombo),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck09_sendoh007_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",8),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck10_Parrit_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",9),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_matiaskm_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",10),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_fistfullofmetal_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",11),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck13_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",12),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck14_tia05_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",13),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck15_Karnesis93_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",14),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck16_xfile_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",15),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck17_Traft_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",16),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_Tripalosky_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",17),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_Hoey07_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",18),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_JOXEMI333_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",19),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck21_GrandDrou_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",20),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_Hemsley_PrimevalTitan_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",21),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GyrudaReanimator),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck23_ArchaeusDota_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",22),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck24_Karolmo_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",23),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_SamcasterMage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",24),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck26_Thrall90_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",25),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_CapitanoCL_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",26),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_qbturtle15_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",27),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_SoulStrong_GrixisControl_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",28),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_in5ano_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",29),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_Larry11_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",30),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck32_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-24",31),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }


    }
}
