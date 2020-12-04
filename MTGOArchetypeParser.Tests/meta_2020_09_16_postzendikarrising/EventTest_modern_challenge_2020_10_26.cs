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
#01 PietroSas: Devoted (WG, Lurrus)
#02 RespectTheCat: Azorius Taxes (WU, Yorion)
#03 fradev1988: Izzet Restore Balance (UR)
#04 coomback: Mill (UB)
#05 TSPJendrek: Izzet Control (UR)
#06 FeeltheRush: Bant Midrange (WUG)
#07 DenebLyrae: Heliod Combo (WG)
#08 musasabi: Reclaimer Titan (WG)
#09 _Shatun_: Mono Red Prowess (R)
#10 mw_94gA: Bant Spirits (WUG)
#11 joetru: Niv To Light (WUBRG, Jegantha)
#12 HouseOfManaMTG: Amulet Titan (RG)
#13 patheus_84: Ad Nauseam (WUB)
#14 Binolino: Amulet Titan (UG)
#15 Smiteon: Amulet Titan (BG)
#16 _Batutinha_: Reclaimer Titan (WRG)
#17 Karnesis93: Amulet Titan (UG)
#18 Kurusu: Kiki Chord (WRG, Yorion)
#19 ecobaronen: WURG Control (WURG)
#20 DaniMRebel: Spirits (WU)
#21 JustJack: Humans (WUBRG)
#22 albert62: WURG Control (WURG)
#23 Jenara19: Azorius Control (WU)
#24 mechint: Azorius Control (WU)
#25 Jack_Kashtan: Ad Nauseam (WUB)
#26 Metcalf23: Mono White Taxes (W)
#27 DrDree: Humans (WUBRG)
#28 drVendigo: Humans (WUBRG)
#29 Lukas261997: Sultai Control (UBG)
#30 Tweedel: Humans (WUBRG)
#31 Ivc: Azorius Control (WU)
#32 Supercazzola: Azorius Control (WU)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_10_26 : EventTest
    {
        [Test]
        public void Deck01_PietroSas_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",0),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_RespectTheCat_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",1),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_fradev1988_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",2),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck04_coomback_Mill_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",3),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck05_TSPJendrek_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",4),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_FeeltheRush_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",5),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_DenebLyrae_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",6),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck08_musasabi_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",7),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck09_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",8),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_mw94gA_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",9),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck11_joetru_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",10),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck12_HouseOfManaMTG_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",11),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",12),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Binolino_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",13),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck15_Smiteon_AmuletTitan_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",14),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck16_Batutinha_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",15),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck17_Karnesis93_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",16),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck18_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",17),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_ecobaronen_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",18),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_DaniMRebel_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",19),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck21_JustJack_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",20),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck22_albert62_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",21),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Jenara19_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",22),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_mechint_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",23),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_JackKashtan_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",24),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Metcalf23_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",25),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck27_DrDree_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",26),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck28_drVendigo_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",27),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Lukas261997_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",28),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Tweedel_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",29),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",30),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Supercazzola_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-10-26",31),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
