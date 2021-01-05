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
#01 SoulStrong: Reclaimer Titan (WRG)
#02 aspiringspike: Bant Blink (WUG)
#03 Xwhale: Reclaimer Titan (WG)
#04 Kazuga: Heliod Combo (WG)
#05 CordoTwin: Shadow Prowess (BR, Lurrus)
#06 Nikachu: Merfolk (UG)
#07 Kr0k39: Oops All Spells (WUBG)
#08 DcNo: Humans (WUBRG)
#09 Baku_91: Elementals (WUBRG, Kaheera)
#10 McWinSauce: WURG Control (WURG)
#11 Magicofplayer1: Ad Nauseam (WUB)
#12 Ekeross: Shadow Prowess (BR, Lurrus)
#13 Laplasjan: Amulet Titan (RG)
#14 tibalt_of_red_sub: Mill (UB, Lurrus)
#15 ArchaeusDota: Eldrazi Tron (C)
#16 Dylan_Fay: Bant Control (WUG)
#17 LewisCBR: Scapeshift (URG)
#18 Tarrasque1: Mono White Taxes (W)
#19 Ma7x: Niv To Light (WUBRG, Jegantha)
#20 Samlg01: Amulet Titan (RG)
#21 Jenara19: WURG Control (WURG)
#22 mariogomes097: Grixis Shadow (UBR)
#23 TuggaNaxos: Obosh Aggro (R, Obosh)
#24 Sodeq: Belcher (URG)
#25 Trailovsky: Amulet Titan (RG)
#26 djbmppwns: WURG Control (WURG)
#27 NinoMtg: Izzet Control (UR)
#28 Jedgi: WURG Control (WURG)
#29 oinkmage: WURG Control (WURG)
#30 Oscar_Franco: WURG Control (WURG)
#31 pokerswizard: Shadow Prowess (BR, Lurrus)
#32 toondoslav: Infect (BG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_11_22 : EventTest
    {
        [Test]
        public void Deck01_SoulStrong_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",0),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck02_aspiringspike_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",1),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Xwhale_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",2),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck04_Kazuga_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",3),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck05_CordoTwin_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",4),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_Nikachu_Merfolk_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",5),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Kr0k39_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",6),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck08_DcNo_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",7),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Baku91_Elementals_WUBRG_Kaheera()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",8),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck10_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",9),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Magicofplayer1_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",10),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Ekeross_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",11),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Laplasjan_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",12),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck14_tibaltofredsub_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",13),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_ArchaeusDota_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",14),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck16_DylanFay_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",15),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_LewisCBR_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",16),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Tarrasque1_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",17),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Ma7x_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",18),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck20_Samlg01_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",19),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck21_Jenara19_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",20),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",21),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck23_TuggaNaxos_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",22),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck24_Sodeq_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",23),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Trailovsky_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",24),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck26_djbmppwns_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",25),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_NinoMtg_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",26),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Jedgi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",27),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_oinkmage_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",28),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_OscarFranco_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",29),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_pokerswizard_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",30),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_toondoslav_Infect_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-22",31),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }


    }
}
