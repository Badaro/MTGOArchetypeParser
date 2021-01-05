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
#01 Gobo2009: Izzet Prowess (UR)
#02 Graciasportanto: Sultai Control (UBG)
#03 im2g00t4ubarn: WURG Control (WURG)
#04 Lord_Beerus: Burn (WR)
#05 kaikalbuquerque: Reclaimer Titan (WG)
#06 Borjillamtg10: Gruul Midrange (RG)
#07 TwistedWombat: WURG Control (WURG)
#08 Comebackkid: Shadow Prowess (BR, Lurrus)
#09 TwitchAwP: Ad Nauseam (WUB)
#10 Snapcaster-Bolt: Simic Control (UG)
#11 HummingBard: U Tron (U)
#12 SknerusMcKwacz: WURG Control (WURG)
#13 thedoc96: Shadow Prowess (BR, Lurrus)
#14 Lavaridge: Temur Control (URG)
#15 Gifted: Jund Shadow (BRG, Lurrus)
#16 hugofreitas1: Gifts Storm (UR)
#17 SourceOdin: Reclaimer Titan (WG)
#18 Parrit: Mono White Taxes (W, Yorion)
#19 Darkiundsa: Oops All Spells (WUBG)
#20 Jedgi: WURG Control (WURG)
#21 weishengzhishabi: Sultai Control (UBG)
#22 McWinSauce: WURG Control (WURG)
#23 ACG88: Naya Midrange (WRG)
#24 Kenzaburo: Shadow Prowess (BR, Lurrus)
#25 NorrathDecay: KGC Tron (G)
#26 MrRaeb: UBRG Control (UBRG)
#27 _gabrielfehr_: Izzet Control (UR)
#28 alemilan19: WURG Control (WURG)
#29 Veronkierto: Dredge (BRG)
#30 Ma7x: Shadow Prowess (BRG, Lurrus)
#31 Egze249: Ad Nauseam (WUB)
#32 eclipse4343: Azorius Control (WU)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_champ_qual_2020_12_21 : EventTest
    {
        [Test]
        public void Deck01_Gobo2009_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",0),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Graciasportanto_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",1),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_im2g00t4ubarn_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",3),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck05_kaikalbuquerque_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",4),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck06_Borjillamtg10_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",5),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_TwistedWombat_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",6),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Comebackkid_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",7),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_TwitchAwP_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",8),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck10_SnapcasterBolt_SimicControl_UG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",9),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_HummingBard_UTron_U()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",10),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(BlueTron),
                null,
                null
            );
        }

        [Test]
        public void Deck12_SknerusMcKwacz_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",11),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_thedoc96_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",12),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Lavaridge_TemurControl_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",13),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Gifted_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",14),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",15),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck17_SourceOdin_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",16),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck18_Parrit_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",17),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_Darkiundsa_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",18),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Jedgi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",19),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_weishengzhishabi_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",20),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",21),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_ACG88_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",22),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Kenzaburo_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",23),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_NorrathDecay_KGCTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",24),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck26_MrRaeb_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",25),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_gabrielfehr_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",26),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_alemilan19_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",27),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Veronkierto_Dredge_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",28),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Ma7x_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",29),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_Egze249_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",30),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck32_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",31),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
