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
#01 pootisgodsamongus: MonoRedProwess (R, Obosh)
#02 Reynad: JundMidrange (BRG)
#03 RearrangedAS: Spirits (WU)
#04 Phill_Hellmuth: GruulMidrange (RG)
#05 TebbeBear: AdNauseam (WUB)
#06 mathguy31415: KGCTron (G)
#07 Chuckles1248: AdNauseam (WUB)
#08 slow_brz: MarduShadow (WBR)
#09 SKK: Belcher (C)
#10 D00mwake: Mill (UB, Lurrus)
#11 oshea: Humans (WUBRG)
#12 bmwracer0: KGCTron (G)
#13 Alucart: JundMidrange (BRG)
#14 SebastianStueckl: GruulMidrange (RG)
#15 Xwhale: Humans (WUBRG)
#16 ThekingFor1000years: Infect (WUG)
#17 Kricha13: WURGControl (WURG)
#18 Oderus Urungus: Humans (WUBRG)
#19 ghostx02: GruulMidrange (RG)
#20 beastista: AzoriusControl (WU)
#21 Toastxp: GruulMidrange (RG)
#22 ThePurplecow777: Bogles (WG)
#23 Diatomic: GruulMidrange (RG)
#24 TubbyBatman: Delver (UR)
#25 Slinker80: Burn (WR, Lurrus)
#26 SuperCow12653: JundMidrange (BRG)
#27 MagicCardsFunFunFun: GruulMidrange (RG)
#28 nsroller: RakdosProwess (BR, Lurrus)
#29 Strox: JundMidrange (BRG)
#30 Databyss: Mill (UB)
#31 Patxi: Humans (WUBRG)
#32 ScorpionDeathDrop: ETron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_champs_2020_09_21 : EventTest
    {
        [Test]
        public void Deck01_pootisgodsamongus_MonoRedProwess_R_Obosh()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",0),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_Reynad_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",1),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_RearrangedAS_Spirits_WU()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",2),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck04_PhillHellmuth_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",3),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_TebbeBear_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",4),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck06_mathguy31415_KGCTron_G()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",5),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck07_Chuckles1248_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",6),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck08_slowbrz_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",7),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck09_SKK_Belcher_C()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",8),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck10_D00mwake_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",9),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_oshea_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",10),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck12_bmwracer0_KGCTron_G()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",11),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck13_Alucart_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",12),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",13),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Xwhale_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",14),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck16_ThekingFor1000years_Infect_WUG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",15),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Kricha13_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",16),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_OderusUrungus_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",17),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck19_ghostx02_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",18),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_beastista_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",19),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Toastxp_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",20),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_ThePurplecow777_Bogles_WG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",21),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Diatomic_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",22),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_TubbyBatman_Delver_UR()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",23),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(Delver),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Slinker80_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",24),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_SuperCow12653_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",25),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck27_MagicCardsFunFunFun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",26),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_nsroller_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",27),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Strox_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",28),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Databyss_Mill_UB()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",29),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Patxi_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",30),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck32_ScorpionDeathDrop_ETron_C()
        {
            Test(
                GetDeck("modern-champs-2020-09-21",31),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }


    }
}
