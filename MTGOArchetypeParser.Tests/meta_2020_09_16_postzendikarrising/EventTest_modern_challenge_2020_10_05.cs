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
#01 Parrit: Mono White Taxes (W)
#02 kiko: Mono White Taxes (W)
#03 Do0mSwitch: WURG Control (WURG)
#04 unicornparadise: Spirits (WU)
#05 cityofcards: Shadow Prowess (WBR, Lurrus)
#06 tkcheungab: Green Tron (G)
#07 AstralPlane: Shadow Prowess (BR, Lurrus)
#08 drVendigo: Jund Midrange (BRG)
#09 Zar0s: Shadow Prowess (WBR, Lurrus)
#10 bmac668: Shadow Prowess (BR, Lurrus)
#11 _Batutinha_: Shadow Prowess (WBR, Lurrus)
#12 Toastxp: Shadow Prowess (BR, Lurrus)
#13 Kenzaburo: Azorius Control (WU)
#14 Trid0n: Belcher (RG)
#15 NorrathDecay: Burn (WR)
#16 Gabriele2020: Humans (WUBRG)
#17 il_matagatto: Humans (WUBRG)
#18 _Falcon_: Izzet Prowess (UR)
#19 ZYURYO: WURG Control (WURG)
#20 Dazai: UBRG Control (UBRG)
#21 BERNASTORRES: Shadow Prowess (WBR, Lurrus)
#22 MrRaeb: Sultai Control (UBG)
#23 Wizard_2002: Humans (WUBRG)
#24 Ouranos139: Amulet Titan (UG)
#25 coert: Heliod Combo (WG)
#26 JustJack: Humans (WUBRG)
#27 Kurusu: Kiki Chord (WRG, Yorion)
#28 josetorr87: Reclaimer Titan (WRG)
#29 McWinSauce: WURG Control (WURG)
#30 Erik157751: Shadow Prowess (BR, Lurrus)
#31 MissTrigger: Humans (WUBRG)
#32 futureshok: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_10_05 : EventTest
    {
        [Test]
        public void Deck01_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",0),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck02_kiko_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",1),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Do0mSwitch_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_unicornparadise_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",3),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck05_cityofcards_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",4),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_tkcheungab_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",5),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck07_AstralPlane_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",6),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_drVendigo_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",7),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Zar0s_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",8),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_bmac668_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",9),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Batutinha_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",10),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Toastxp_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",11),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Kenzaburo_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",12),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Trid0n_Belcher_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",13),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck15_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",14),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Gabriele2020_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",15),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck17_ilmatagatto_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",16),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Falcon_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",17),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck19_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",18),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Dazai_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",19),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_BERNASTORRES_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",20),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_MrRaeb_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",21),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Wizard2002_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",22),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Ouranos139_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",23),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck25_coert_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",24),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck26_JustJack_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",25),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",26),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck28_josetorr87_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",27),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck29_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",28),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Erik157751_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",29),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_MissTrigger_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",30),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck32_futureshok_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-05",31),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
