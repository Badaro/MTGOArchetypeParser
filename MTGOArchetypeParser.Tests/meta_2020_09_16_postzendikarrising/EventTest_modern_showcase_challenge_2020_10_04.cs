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
#01 D00mwake: Shadow Prowess (WBR, Lurrus)
#02 Frejat: Reclaimer Titan (WRG)
#03 moyashi0904: WURG Control (WURG)
#04 __BMJ__: Shadow Prowess (BR, Lurrus)
#05 audio336: Shadow Prowess (BR, Lurrus)
#06 starfall: Obosh Aggro (R, Obosh)
#07 TrueHero: UBRG Control (UBRG)
#08 Parrit: Mono White Taxes (W)
#09 bigjc00: Amulet Titan (UG)
#10 AstralPlane: Shadow Prowess (BR, Lurrus)
#11 AlexanderRosdahl: Sultai Control (UBG)
#12 Zar0s: Niv To Light (WUBRG, Jegantha)
#13 SpiderSpace: Mono White Taxes (W)
#14 _Stream: Izzet Prowess (UR)
#15 juzam_gin: Dredge (BRG)
#16 kanister: Humans (WUBRG)
#17 SpicyLeche: Mono White Taxes (W)
#18 Joao_Andrade: Belcher (WURG)
#19 fuma-mtgcampinas: Eldrazi Tron (C)
#20 Nammersquats: Humans (WUBRG)
#21 cntrlfreak: Grixis Shadow (UBR)
#22 pootisgodsamongus: Obosh Aggro (R, Obosh)
#23 NosonosaN: WURG Control (WURG)
#24 bamzing: Reclaimer Titan (WRG)
#25 fradelrock: Izzet Prowess (UR)
#26 Rav104: Oops All Spells (WUBRG)
#27 Icteridae: Gruul Midrange (RG)
#28 exoticherman: Shadow Prowess (BR, Lurrus)
#29 NorrathDecay: Burn (WR)
#30 GGBud1717: Izzet Prowess (UR)
#31 CHILLEDADED: Humans (WUBRG)
#32 Aphiladon: Hardened Scales (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_showcase_challenge_2020_10_04 : EventTest
    {
        [Test]
        public void Deck01_D00mwake_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",0),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Frejat_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",1),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck03_moyashi0904_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_BMJ_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",3),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_audio336_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_starfall_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",5),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck07_TrueHero_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",6),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",7),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck09_bigjc00_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",8),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck10_AstralPlane_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",9),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_AlexanderRosdahl_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",10),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Zar0s_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",11),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck13_SpiderSpace_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",12),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Stream_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",13),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck15_juzamgin_Dredge_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",14),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck16_kanister_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",15),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck17_SpicyLeche_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",16),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck18_JoaoAndrade_Belcher_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",17),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck19_fumamtgcampinas_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",18),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck20_Nammersquats_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",19),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck21_cntrlfreak_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",20),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck22_pootisgodsamongus_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",21),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck23_NosonosaN_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",22),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_bamzing_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",23),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck25_fradelrock_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",24),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Rav104_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",25),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Icteridae_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",26),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_exoticherman_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",27),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",28),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck30_GGBud1717_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",29),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck31_CHILLEDADED_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",30),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Aphiladon_HardenedScales_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-10-04",31),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }


    }
}
