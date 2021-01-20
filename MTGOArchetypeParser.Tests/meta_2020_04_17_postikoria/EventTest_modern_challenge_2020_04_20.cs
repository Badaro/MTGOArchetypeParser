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
#01 McWinSauce: UBRG Control (UBRG, Lurrus)
#02 elad3127: Burn (WR, Lurrus)
#03 SebastianStueckl: Jund Midrange (BRG, Lurrus)
#04 musasabi: Hardened Scales (G, Lurrus)
#05 dejoyjoe: Uroza (URG, Yorion)
#06 D00mwake: Boros Prowess (WR, Lurrus)
#07 dm95: Delver (UBR, Lurrus)
#08 __BMJ__: Devoted (WG, Lurrus)
#09 updraftelemental: Boros Prowess (WR, Lurrus)
#10 Fluorspar: Humans (WUBRG, Jegantha)
#11 audio336: Humans (WUBRG, Jegantha)
#12 LiturgijskaKnjiga: Infect (UG)
#13 J000111: Dredge (BRG)
#14 Acekiller: Burn (WR, Lurrus)
#15 Bullz0Eye: Jund Midrange (BRG, Lurrus)
#16 _LSN_: Burn (WR, Lurrus)
#17 albert62: Jund Midrange (BRG, Lurrus)
#18 bladede: Jund Midrange (BRG)
#19 gardrd: Mono Red Prowess (R)
#20 Sodeq: Dredge (BRG)
#21 albertoSD: Niv To Light (WUBRG)
#22 Asmodean1990: Jund Midrange (BRG, Lurrus)
#23 XxShuicunexX: Burn (WR)
#24 CookieKid00: Delver (UBR, Lurrus)
#25 eduardo_ossorio: Delver (UBR, Lurrus)
#26 Second_Sunrise: Neobrand (UG)
#27 MaxMagicer: Humans (WUBRG)
#28 minaki: Humans (WUBRG)
#29 bobthedog: WURG Blink (WURG, Yorion)
#30 WeareVenom: Bant Control (WUG)
#31 Tonynine: Gruul Midrange (RG)
#32 Naisirc: Jund Midrange (BRG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_challenge_2020_04_20 : EventTest
    {
        [Test]
        public void Deck01_McWinSauce_UBRGControl_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",0),
                new PostIkoria(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_elad3127_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",1),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_SebastianStueckl_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",2),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_musasabi_HardenedScales_G_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",3),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_dejoyjoe_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",4),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_D00mwake_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",5),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_dm95_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",6),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Delver),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_BMJ_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",7),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_updraftelemental_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",8),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Fluorspar_Humans_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",9),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck11_audio336_Humans_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",10),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck12_LiturgijskaKnjiga_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",11),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck13_J000111_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",12),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Acekiller_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",13),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_Bullz0Eye_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",14),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_LSN_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",15),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_albert62_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",16),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_bladede_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",17),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_gardrd_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",18),
                new PostIkoria(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck20_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",19),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck21_albertoSD_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",20),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Asmodean1990_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",21),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_XxShuicunexX_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",22),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck24_CookieKid00_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",23),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Delver),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_eduardoossorio_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",24),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Delver),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_SecondSunrise_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",25),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck27_MaxMagicer_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",26),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck28_minaki_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",27),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck29_bobthedog_WURGBlink_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",28),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck30_WeareVenom_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",29),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Tonynine_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",30),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Naisirc_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-04-20",31),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
