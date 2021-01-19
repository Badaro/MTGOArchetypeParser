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
#01 kaktusowysmok: Goblins (BR)
#02 Gerardo94: WURG Control (WURG)
#03 thedoc96: Shadow Prowess (BR, Lurrus)
#04 Redgy819: Green Tron (G)
#05 Ryan_39: Shadow Prowess (BR, Lurrus)
#06 Condescend: WURG Control (WURG)
#07 lsmguys: Shadow Prowess (BR, Lurrus)
#08 EdB: Amulet Titan (G)
#09 Patxi: Gruul Midrange (RG)
#10 SoulStrong: Bant Blink (WUG)
#11 HardcoreHenry: Shadow Prowess (BR, Lurrus)
#12 Chichichi: Amulet Titan (UG)
#13 qbturtle15: Mono White Taxes (W)
#14 PeanutBrittle: WURG Control (WURG)
#15 KO_Mak: Oops All Spells (UBRG)
#16 joetru: Niv To Light (WUBRG, Yorion)
#17 mashmalovsky: Ad Nauseam (WUB)
#18 SpiderSpace: Hammer Time (WG, Lurrus)
#19 Kaizer_Kahn: Obosh Aggro (R, Obosh)
#20 katoriarch123: WURG Control (WURG)
#21 FreedMania: Amulet Titan (UG)
#22 gottelicious: Green Tron (G)
#23 BReal2: Shadow Prowess (BR, Lurrus)
#24 hugofreitas1: Gifts Storm (UR)
#25 VA1VE: Ad Nauseam (WUB)
#26 Curtisaxel: Blue Tron (UR)
#27 SeitaSan: Gruul Midrange (RG)
#28 bolov0: Obosh Aggro (R, Obosh)
#29 Tarrasque1: Mono White Taxes (W)
#30 Ouranos139: Amulet Titan (G)
#31 Leviathan102: Reclaimer Titan (WG)
#32 wambocombo2020: Temur Control (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_champ_qual_2020_12_05 : EventTest
    {
        [Test]
        public void Deck01_kaktusowysmok_Goblins_BR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",0),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_thedoc96_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Redgy819_GreenTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",3),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck05_Ryan39_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_Condescend_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",5),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_lsmguys_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",6),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_EdB_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",7),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck09_Patxi_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",8),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_SoulStrong_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",9),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck11_HardcoreHenry_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",10),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Chichichi_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",11),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_qbturtle15_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",12),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck14_PeanutBrittle_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",13),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_KOMak_OopsAllSpells_UBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",14),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck16_joetru_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",15),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck17_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",16),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck18_SpiderSpace_HammerTime_WG_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",17),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_KaizerKahn_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",18),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck20_katoriarch123_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",19),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_FreedMania_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",20),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck22_gottelicious_GreenTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",21),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck23_BReal2_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",22),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",23),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck25_VA1VE_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",24),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Curtisaxel_BlueTron_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",25),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(Tron),
                typeof(BlueTron),
                null
            );
        }

        [Test]
        public void Deck27_SeitaSan_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",26),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_bolov0_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",27),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck29_Tarrasque1_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",28),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Ouranos139_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",29),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck31_Leviathan102_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",30),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck32_wambocombo2020_TemurControl_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-05",31),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
