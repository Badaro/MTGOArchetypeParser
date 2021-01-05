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
#01 billster47: Hammer Time (W, Lurrus)
#02 McWinSauce: WURG Control (WURG)
#03 kiko: Azorius Taxes (WU, Yorion)
#04 Sodeq: Belcher (URG)
#05 mariogomes097: Grixis Shadow (UBR)
#06 Samlg01: Amulet Titan (RG)
#07 pokerswizard: Shadow Prowess (BR, Lurrus)
#08 SvenSveeterSven: Mardu Midrange (WBR)
#09 ZYURYO: Temur Control (URG)
#10 Better_than_Average: Obosh Aggro (R, Obosh)
#11 KamiTech: Electro End (UR)
#12 Trellon: Blue Tron (UR)
#13 NorrathDecay: Eldrazi Tron (C)
#14 Kurusu: Kiki Chord (WRG, Yorion)
#15 RespectTheCat: Rakdos Midrange (BR)
#16 Binolino: Reclaimer Titan (WRG)
#17 patheus_84: Ad Nauseam (WUB)
#18 Darkiundsa: Esper Control (WUB)
#19 nazart: Heliod Combo (WRG)
#20 ACG88: Green Tron (G)
#21 musasabi: Shadow Prowess (BR, Lurrus)
#22 Filyoni: Heliod Combo (WG)
#23 MrRaeb: UBRG Control (UBRG)
#24 FriskiFraska: Reclaimer Titan (WRG)
#25 _Batutinha_: Reclaimer Titan (WUG)
#26 Parrit: Mono White Taxes (W)
#27 jmeyer2030: Obosh Aggro (R, Obosh)
#28 Rinko: Enduring Ideal (WR)
#29 Aluren85: Mono White Taxes (W)
#30 ArchaeusDota: Esper Control (WUB)
#31 PRGJJAR: Dredge (BRG)
#32 coomback: Mill (UB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_11_23 : EventTest
    {
        [Test]
        public void Deck01_billster47_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",0),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_kiko_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",2),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Sodeq_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",3),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck05_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",4),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Samlg01_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",5),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_pokerswizard_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",6),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_SvenSveeterSven_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",7),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_ZYURYO_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",8),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_BetterthanAverage_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",9),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck11_KamiTech_ElectroEnd_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",10),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroEnd),
                null
            );
        }

        [Test]
        public void Deck12_Trellon_BlueTron_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",11),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(Tron),
                typeof(BlueTron),
                null
            );
        }

        [Test]
        public void Deck13_NorrathDecay_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",12),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",13),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_RespectTheCat_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",14),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Binolino_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",15),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck17_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",16),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Darkiundsa_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",17),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_nazart_HeliodCombo_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",18),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck20_ACG88_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",19),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck21_musasabi_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",20),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_Filyoni_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",21),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck23_MrRaeb_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",22),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_FriskiFraska_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",23),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck25_Batutinha_ReclaimerTitan_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",24),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck26_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",25),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck27_jmeyer2030_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",26),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck28_Rinko_EnduringIdeal_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",27),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(EnduringIdeal),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Aluren85_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",28),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck30_ArchaeusDota_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",29),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",30),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck32_coomback_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-23",31),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }


    }
}
