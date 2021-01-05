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
#01 Hamuda: Hammer Time (WB, Lurrus)
#02 Edel: Rakdos Midrange (BR)
#03 UmekawaneikU: Shadow Prowess (BR, Lurrus)
#04 katoriarch123: WURG Control (WURG)
#05 The_nayr: Obosh Aggro (R, Obosh)
#06 Condescend: WURG Control (WURG)
#07 Blitzlion27: Mill (UB, Lurrus)
#08 rodeo: Oops All Spells (WUBRG)
#09 coert: Heliod Combo (WG)
#10 billster47: Hammer Time (W, Lurrus)
#11 poorkid676: Belcher (URG)
#12 Jositoshekel: Heliod Combo (WG)
#13 Diem4x: Sultai Control (UBG)
#14 GodOfSlaughter: Shadow Prowess (BR, Lurrus)
#15 kanister: Primeval Titan (UG)
#16 nazart: Heliod Combo (WG)
#17 SweetIto: Shadow Prowess (BR, Lurrus)
#18 Gigy: Gruul Midrange (RG)
#19 MastaHorus: Izzet Living End (UR)
#20 Sodeq: Dredge (BRG)
#21 Filyoni: Heliod Combo (WG)
#22 Gernardi: Izzet Control (UR)
#23 Kurusu: Kiki Chord (WURG, Yorion)
#24 CrusherBotBG: Hammer Time (W, Lurrus)
#25 Tweedel: Obosh Aggro (R, Obosh)
#26 Imaeda: Izzet Prowess (UR)
#27 Rulleboren: Reclaimer Titan (WRG)
#28 ATGerwaz: Mill (UB, Lurrus)
#29 ACG88: Naya Midrange (WRG)
#30 Binolino: Reclaimer Titan (WG)
#31 TSPJendrek: Azorius Control (WU)
#32 DaniMRebel: Shadow Prowess (BR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_12_14 : EventTest
    {
        [Test]
        public void Deck01_Hamuda_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",0),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Edel_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",1),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_UmekawaneikU_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_katoriarch123_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",3),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Thenayr_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",4),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_Condescend_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",5),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Blitzlion27_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",6),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_rodeo_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",7),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck09_coert_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",8),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck10_billster47_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",9),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_poorkid676_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",10),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Jositoshekel_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",11),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Diem4x_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",12),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_GodOfSlaughter_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",13),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_kanister_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",14),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck16_nazart_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",15),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck17_SweetIto_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",16),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",17),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_MastaHorus_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",18),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroEnd),
                null
            );
        }

        [Test]
        public void Deck20_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",19),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Filyoni_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",20),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Gernardi_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",21),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Kurusu_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",22),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck24_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",23),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Tweedel_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",24),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck26_Imaeda_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",25),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Rulleboren_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",26),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck28_ATGerwaz_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",27),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_ACG88_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",28),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Binolino_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",29),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck31_TSPJendrek_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",30),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_DaniMRebel_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-14",31),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
