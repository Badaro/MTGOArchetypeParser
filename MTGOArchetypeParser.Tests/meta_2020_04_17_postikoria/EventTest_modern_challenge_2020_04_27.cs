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
#01 Oliver_Hart: Grixis Shadow (UBR, Lurrus)
#02 kbr3: Hardened Scales (WG, Lurrus)
#03 coert: Burn (WR, Lurrus)
#04 Gerardo94: Delver (UBR, Lurrus)
#05 joetru: Niv To Light (WUBRG, Jegantha)
#06 Andrea94: Burn (WR, Lurrus)
#07 Laplasjan: Devoted (WG, Lurrus)
#08 sacca93: Primeval Titan (BG)
#09 al8ert.dk: Gruul Midrange (RG, Obosh)
#10 ack_s: Primeval Titan (BG)
#11 meanfannypack: Orzhov Taxes (WB, Lurrus)
#12 SebastianStueckl: Bant Control (WUG, Yorion)
#13 Stabilo: Amulet Titan (G)
#14 patheus_84: Ad Nauseam (WUB)
#15 nsroller: Jund Midrange (BRG, Lurrus)
#16 joker10289: Bant Control (WUG)
#17 matyo804: Primeval Titan (WUG, Gyruda)
#18 Bayesta_93: Burn (WR, Lurrus)
#19 triosk: Hardened Scales (BG, Lurrus)
#20 Redgy819: Ad Nauseam (WUB)
#21 Biednarccio: Amulet Titan (URG)
#22 Reptar_KOTO: Boros Prowess (WR, Lurrus)
#23 bomberboss: Humans (WUBRG)
#24 Trellon: Blue Tron (U)
#25 12Days: Gruul Midrange (RG, Obosh)
#26 2jjm: Burn (WR, Lurrus)
#27 katoriarch123: Bant Control (WUG)
#28 __matsugan: Neobrand (UG)
#29 ArchaeusDota: Eldrazi Tron (C)
#30 iDaveW: Burn (WR, Lurrus)
#31 JOXEMI333: Green Tron (G)
#32 MagicEd: Jund Midrange (BRG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_challenge_2020_04_27 : EventTest
    {
        [Test]
        public void Deck01_OliverHart_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",0),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_kbr3_HardenedScales_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",1),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_coert_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",2),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Gerardo94_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",3),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Delver),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_joetru_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",4),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck06_Andrea94_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",5),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",6),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_sacca93_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",7),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck09_al8ertdk_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",8),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck10_acks_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",9),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck11_meanfannypack_OrzhovTaxes_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",10),
                new PostIkoria(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_SebastianStueckl_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",11),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck13_Stabilo_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",12),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck14_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",13),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck15_nsroller_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",14),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_joker10289_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",15),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_matyo804_PrimevalTitan_WUG_Gyruda()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",16),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GyrudaReanimator),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck18_Bayesta93_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",17),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_triosk_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",18),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_Redgy819_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",19),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Biednarccio_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",20),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck22_ReptarKOTO_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",21),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_bomberboss_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",22),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Trellon_BlueTron_U()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",23),
                new PostIkoria(),
                ArchetypeColor.U,
                typeof(Tron),
                typeof(BlueTron),
                null
            );
        }

        [Test]
        public void Deck25_12Days_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",24),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck26_2jjm_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",25),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",26),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",27),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck29_ArchaeusDota_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",28),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck30_iDaveW_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",29),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_JOXEMI333_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",30),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck32_MagicEd_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-27",31),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
