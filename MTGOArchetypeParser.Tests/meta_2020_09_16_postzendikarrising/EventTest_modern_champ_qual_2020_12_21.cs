using FluentAssertions;
using MTGOArchetypeParser.Model;
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
#10 Snapcaster-Bolt: Reclamation (UG)
#11 HummingBard: Blue Tron (U)
#12 SknerusMcKwacz: WURG Control (WURG)
#13 thedoc96: Shadow Prowess (BR, Lurrus)
#14 Lavaridge: Reclamation (URG)
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
#25 NorrathDecay: Green Tron (G)
#26 MrRaeb: UBRG Control (UBRG)
#27 _gabrielfehr_: Izzet Control (UR)
#28 alemilan19: WURG Control (WURG)
#29 Veronkierto: Dredge (BRG)
#30 Ma7x: Shadow Prowess (BRG, Lurrus)
#31 Egze249: Ad Nauseam (WUB)
#32 eclipse4343: Miracles (WU)
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
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck02_Graciasportanto_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",1),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_im2g00t4ubarn_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",2),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",3),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck05_kaikalbuquerque_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",4),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck06_Borjillamtg10_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",5),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_TwistedWombat_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",6),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Comebackkid_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",7),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_TwitchAwP_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",8),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck10_SnapcasterBolt_Reclamation_UG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",9),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck11_HummingBard_BlueTron_U()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",10),
                "PostZendikarRising",
                ArchetypeColor.U,
                "Tron",
                "BlueTron",
                null
            );
        }

        [Test]
        public void Deck12_SknerusMcKwacz_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",11),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_thedoc96_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",12),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Lavaridge_Reclamation_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",13),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Gifted_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",14),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",15),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck17_SourceOdin_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",16),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck18_Parrit_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",17),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_Darkiundsa_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",18),
                "PostZendikarRising",
                ArchetypeColor.WUBG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Jedgi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",19),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_weishengzhishabi_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",20),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck22_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",21),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_ACG88_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",22),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck24_Kenzaburo_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",23),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_NorrathDecay_GreenTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",24),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck26_MrRaeb_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",25),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck27_gabrielfehr_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",26),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck28_alemilan19_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",27),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Veronkierto_Dredge_BRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",28),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Ma7x_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",29),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_Egze249_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",30),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck32_eclipse4343_Miracles_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-12-21",31),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Miracles",
                null,
                null
            );
        }


    }
}
