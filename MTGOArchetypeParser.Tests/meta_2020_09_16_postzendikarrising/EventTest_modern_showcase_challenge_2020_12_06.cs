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
#01 Xwhale: Reclaimer Titan (WRG)
#02 tkcheungab: Green Tron (G)
#03 cws: Gifts Storm (UR)
#04 JUJUBEAN__2004: Heliod Combo (WG)
#05 Smdster: Heliod Combo (WR)
#06 TuggaNaxos: Temur Control (URG)
#07 Gerardo94: WURG Control (WURG)
#08 Vansguy: WURG Control (WURG)
#09 WhiteOleander: Shadow Prowess (BR, Lurrus)
#10 Lordzedane: Shadow Prowess (BR, Lurrus)
#11 Mistakenn: Amulet Titan (RG)
#12 Leviathan102: Reclaimer Titan (WG)
#13 Tiemuuu: Izzet Control (UR)
#14 Gaffiere1903: Ad Nauseam (WUB)
#15 mashmalovsky: Ad Nauseam (WUB)
#16 mariogomes097: Shadow Prowess (UBR, Lurrus)
#17 gravy98: Ad Nauseam (WUB)
#18 Bullwinkkle6705: Goblins (BR)
#19 _Shatun_: Obosh Aggro (R, Obosh)
#20 Misplacedginger: WURG Control (WURG)
#21 MagicalHack99: Sultai Control (UBG)
#22 mmapson125: Heliod Combo (WG)
#23 Tweedel: Obosh Aggro (R, Obosh)
#24 Saviall: Green Tron (G)
#25 ConnorM426: Reclaimer Titan (WRG)
#26 bresett123: WURG Control (WURG)
#27 PeanutBrittle: WURG Control (WURG)
#28 NobodyKnowsImADog: Green Tron (G)
#29 nickrelativity: Oops All Spells (WUBRG)
#30 coert: Heliod Combo (WG)
#31 tzio: Orzhov Midrange (WB)
#32 RespectTheCat: Rakdos Midrange (BR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_showcase_challenge_2020_12_06 : EventTest
    {
        [Test]
        public void Deck01_Xwhale_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",0),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck02_tkcheungab_GreenTron_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",1),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck03_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",2),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck04_JUJUBEAN2004_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",3),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Smdster_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",4),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck06_TuggaNaxos_TemurControl_URG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",5),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",6),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Vansguy_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_WhiteOleander_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",8),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Lordzedane_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",9),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Mistakenn_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",10),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_Leviathan102_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",11),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck13_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",12),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Gaffiere1903_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",13),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck15_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",14),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck16_mariogomes097_ShadowProwess_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",15),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_gravy98_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",16),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Bullwinkkle6705_Goblins_BR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",17),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Shatun_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",18),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck20_Misplacedginger_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",19),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_MagicalHack99_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",20),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_mmapson125_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",21),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Tweedel_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",22),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck24_Saviall_GreenTron_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",23),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck25_ConnorM426_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",24),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck26_bresett123_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",25),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_PeanutBrittle_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",26),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_NobodyKnowsImADog_GreenTron_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",27),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck29_nickrelativity_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",28),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck30_coert_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",29),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck31_tzio_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",30),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_RespectTheCat_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-12-06",31),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
