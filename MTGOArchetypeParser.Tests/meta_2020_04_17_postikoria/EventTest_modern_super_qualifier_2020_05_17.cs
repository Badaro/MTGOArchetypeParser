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
#01 otakkun: Eldrazi Tron (C)
#02 karatedom: Boros Prowess (WR, Lurrus)
#03 Beenew: Mardu Prowess (WBR, Lurrus)
#04 _Batutinha_: Jund Midrange (BRG, Lurrus)
#05 Lord_of_Puntlantis: Electro Balance (URG)
#06 gottelicious: Gruul Midrange (RG, Obosh)
#07 ThePurpleMage: Devoted (WBG, Yorion)
#08 Bayesta_93: Boros Prowess (WR, Lurrus)
#09 albert62: Jund Midrange (BRG, Lurrus)
#10 EdB: Rakdos Prowess (BR, Lurrus)
#11 mikeleee: Humans (WUBRG)
#12 oskiyaa: Eldrazi Tron (C)
#13 sydneydude: Boros Prowess (WR, Lurrus)
#14 FallenKonflicz: Mardu Prowess (WBR, Lurrus)
#15 Never_DidntHaveIt: Jund Shadow (BRG, Lurrus)
#16 fistfullofmetal: Green Tron (RG, Jegantha)
#17 ack_s: Hammer Time (WR, Lurrus)
#18 Manuel_Danninger: Jund Midrange (BRG, Lurrus)
#19 DreamsOfAshiok: Eldrazi Tron (C)
#20 VampireGodric: Sultai Control (UBG)
#21 Laplasjan: Devoted (WG, Lurrus)
#22 PTarts2win: Green Tron (G, Jegantha)
#23 TennTyou: Niv To Light (WUBRG, Jegantha)
#24 TscheggschDePoegg: Amulet Titan (URG)
#25 SoulStrong: Azorius Control (WU, Kaheera)
#26 Icteridae: Devoted (WUG)
#27 CitrusD: Hammer Time (WR, Lurrus)
#28 MikeSoles: Mardu Prowess (WBR, Lurrus)
#29 NosonosaN: Ad Nauseam (WUB)
#30 grahams: Green Tron (G)
#31 bmac668: Burn (WR, Lurrus)
#32 jvidarte: Burn (WR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_super_qualifier_2020_05_17 : EventTest
    {
        [Test]
        public void Deck01_otakkun_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",0),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_karatedom_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",1),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Beenew_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",2),
                new PostIkoria(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Batutinha_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",3),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_LordofPuntlantis_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",4),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck06_gottelicious_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",5),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck07_ThePurpleMage_Devoted_WBG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",6),
                new PostIkoria(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_Bayesta93_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",7),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_albert62_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",8),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_EdB_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",9),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_mikeleee_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",10),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck12_oskiyaa_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",11),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck13_sydneydude_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",12),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_FallenKonflicz_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",13),
                new PostIkoria(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_NeverDidntHaveIt_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",14),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_fistfullofmetal_GreenTron_RG_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",15),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck17_acks_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",16),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_ManuelDanninger_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",17),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",18),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck20_VampireGodric_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",19),
                new PostIkoria(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",20),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_PTarts2win_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",21),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck23_TennTyou_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",22),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck24_TscheggschDePoegg_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",23),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck25_SoulStrong_AzoriusControl_WU_Kaheera()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",24),
                new PostIkoria(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck26_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",25),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck27_CitrusD_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",26),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_MikeSoles_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",27),
                new PostIkoria(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_NosonosaN_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",28),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck30_grahams_GreenTron_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",29),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck31_bmac668_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",30),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-17",31),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
