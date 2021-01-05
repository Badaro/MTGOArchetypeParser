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
#01 MrRaeb: Uroza (UBG, Yorion)
#02 StormQrow: Titan Shift (RG)
#03 PRGJJAR: Dredge (BRG)
#04 BananOlaf: Rakdos Prowess (BR, Lurrus)
#05 Lavaridge: UBRG Control (UBRG, Lurrus)
#06 coert: Burn (WR, Lurrus)
#07 bobthedog: Scapeshift (URG, Yorion)
#08 joetru: Niv To Light (WUBRG, Jegantha)
#09 SIN: Jund Midrange (BRG, Lurrus)
#10 Toastxp: Mardu Prowess (WBR, Lurrus)
#11 MGGX: Azorius Control (WU, Kaheera)
#12 patheus_84: Ad Nauseam (WUB)
#13 2jjm: Burn (WR, Lurrus)
#14 CNewman: Scapeshift (URG, Yorion)
#15 gilliganisla: Eldrazi Tron (C)
#16 AliraSirin: Bogles (WG)
#17 AutumnLily: Sultai Control (UBG, Yorion)
#18 meanfannypack: Devoted (WG, Lurrus)
#19 Traft: Jund Midrange (BRG, Lurrus)
#20 UnsungZero: Golgari Midrange (BG, Lurrus)
#21 Pintogeddon2: Burn (WR, Lurrus)
#22 TSPJendrek: Azorius Control (WU, Yorion)
#23 Blade400: Eldrazi Tron (C)
#24 bmac668: Burn (WR, Lurrus)
#25 Mordeka1ser: Niv To Light (WUBRG, Yorion)
#26 Venom1: Jund Midrange (BRG, Lurrus)
#27 robb93: Jund Midrange (BRG, Lurrus)
#28 SebastianStueckl: Boros Prowess (WR, Lurrus)
#29 ArchaeusDota: Green Tron (G)
#30 iL_Tedesco: Jund Midrange (BRG, Lurrus)
#31 trader08111: Bogles (WG, Lurrus)
#32 musasabi: Hardened Scales (BG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_challenge_2020_05_18 : EventTest
    {
        [Test]
        public void Deck01_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",0),
                new PostIkoria(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_StormQrow_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",1),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck03_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",2),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_BananOlaf_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",3),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Lavaridge_UBRGControl_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",4),
                new PostIkoria(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_coert_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",5),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_bobthedog_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",6),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_joetru_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",7),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck09_SIN_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",8),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Toastxp_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",9),
                new PostIkoria(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_MGGX_AzoriusControl_WU_Kaheera()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",10),
                new PostIkoria(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck12_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",11),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck13_2jjm_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",12),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_CNewman_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",13),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_gilliganisla_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",14),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck16_AliraSirin_Bogles_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",15),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck17_AutumnLily_SultaiControl_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",16),
                new PostIkoria(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_meanfannypack_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",17),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_Traft_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",18),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_UnsungZero_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",19),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_Pintogeddon2_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",20),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_TSPJendrek_AzoriusControl_WU_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",21),
                new PostIkoria(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck23_Blade400_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",22),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck24_bmac668_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",23),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Mordeka1ser_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",24),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck26_Venom1_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",25),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_robb93_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",26),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_SebastianStueckl_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",27),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_ArchaeusDota_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",28),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck30_iLTedesco_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",29),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_trader08111_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",30),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_musasabi_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-18",31),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}