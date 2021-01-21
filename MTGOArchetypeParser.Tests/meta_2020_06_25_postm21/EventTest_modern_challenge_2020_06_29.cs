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
#01 katoriarch123: Bant Control (WUG)
#02 bobthedog: Sultai Control (UBG)
#03 gazmon48: Mono Red Prowess (R)
#04 kbr3: Scapeshift (URG)
#05 Lavaridge: Sultai Control (UBG)
#06 OYU: Infect (UG)
#07 RogerSteady: Delver (UBR)
#08 E-GirlUWU: Amulet Titan (URG)
#09 v3sp_tv: Elementals (WUBRG)
#10 distanthamster: Goblins (BR)
#11 mariogomes097: Grixis Shadow (UBR)
#12 Mr_Sheep: Gruul Midrange (RG)
#13 WuYuHsien: Bant Control (WUG)
#14 Voltzwagon: Gruul Midrange (RG)
#15 McWinSauce: WUBG Control (WUBG)
#16 Janh: Sultai Control (UBG)
#17 stainerson: Elves (BG)
#18 ncowden: Reclamation (UBG)
#19 2radMTG: Reclamation (URG)
#20 indianpancake: Gruul Midrange (RG)
#21 TwistedWombat: Amulet Titan (URG)
#22 Blitzlion27: Mill (UB)
#23 roter_Erzengel: Infect (WUG)
#24 FranPi: Gifts Storm (UR)
#25 D00mwake: Amulet Titan (URG)
#26 unicornparadise: Infect (WUG)
#27 bladede: Green Tron (G)
#28 medvedev: Sultai Control (UBG)
#29 _Shatun_: Gruul Midrange (RG)
#30 sora1248: Goblins (BR)
#31 ArchaeusDota: Green Tron (G, Jegantha)
#32 SkiLwrAp: Reclamation (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_challenge_2020_06_29 : EventTest
    {
        [Test]
        public void Deck01_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",0),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_bobthedog_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",1),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_gazmon48_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",2),
                new PostM21(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck04_kbr3_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",3),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Lavaridge_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",4),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_OYU_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",5),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck07_RogerSteady_Delver_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",6),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(Delver),
                null,
                null
            );
        }

        [Test]
        public void Deck08_EGirlUWU_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",7),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck09_v3sptv_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",8),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck10_distanthamster_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",9),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck11_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",10),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck12_MrSheep_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",11),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_WuYuHsien_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",12),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Voltzwagon_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",13),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_McWinSauce_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",14),
                new PostM21(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Janh_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",15),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_stainerson_Elves_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",16),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(Elves),
                null,
                null
            );
        }

        [Test]
        public void Deck18_ncowden_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",17),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Reclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck19_2radMTG_Reclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",18),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Reclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck20_indianpancake_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",19),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_TwistedWombat_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",20),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck22_Blitzlion27_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",21),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck23_roterErzengel_Infect_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",22),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck24_FranPi_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",23),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck25_D00mwake_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",24),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck26_unicornparadise_Infect_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",25),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck27_bladede_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",26),
                new PostM21(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck28_medvedev_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",27),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",28),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck30_sora1248_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",29),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck31_ArchaeusDota_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",30),
                new PostM21(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck32_SkiLwrAp_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-29",31),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Reclamation),
                null,
                null
            );
        }


    }
}
