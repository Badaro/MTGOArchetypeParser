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
#01 pokerswizard: Shadow Prowess (BR, Lurrus)
#02 PTarts2win: Obosh Aggro (R, Obosh)
#03 Bedell: Sultai Control (UBG)
#04 exoticherman: Shadow Prowess (BRG, Lurrus)
#05 tkcheungab: KGC Tron (G)
#06 Rav104: Obosh Aggro (R, Obosh)
#07 joker10289: Obosh Aggro (R, Obosh)
#08 FerMTG: Jund Midrange (BRG)
#09 Edel: Rakdos Midrange (BR)
#10 rastaf: Obosh Aggro (R, Obosh)
#11 Kuhb: Hammer Time (W, Lurrus)
#12 MZBlazer: Heliod Combo (WG)
#13 Gerardo94: WURG Control (WURG)
#14 McWinSauce: WURG Control (WURG)
#15 MdvWin: Burn (WR)
#16 rodeo: Oops All Spells (WUBRG)
#17 alemilan19: Heliod Combo (WG)
#18 Zar0s: Sultai Control (UBG)
#19 eresopacaso: Heliod Combo (WG, Yorion)
#20 Martin_Dominguez: Heliod Combo (WG)
#21 mahzinha_linda: Ad Nauseam (WUB)
#22 HeyyQT: Reclaimer Titan (WG)
#23 WhiteOleander: WURG Control (WURG)
#24 Ramp: WURG Control (WURG)
#25 lordavery: Bant Midrange (WUG)
#26 mmapson125: Heliod Combo (WG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_03 : EventTest
    {
        [Test]
        public void Deck01_pokerswizard_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",0),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_PTarts2win_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",1),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck03_Bedell_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",2),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_exoticherman_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",3),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_tkcheungab_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",4),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Rav104_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",5),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck07_joker10289_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",6),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck08_FerMTG_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",7),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Edel_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",8),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_rastaf_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",9),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck11_Kuhb_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",10),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_MZBlazer_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",11),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",12),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",13),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_MdvWin_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",14),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck16_rodeo_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",15),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck17_alemilan19_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",16),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Zar0s_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",17),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_eresopacaso_HeliodCombo_WG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",18),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_MartinDominguez_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",19),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck21_mahzinhalinda_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",20),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck22_HeyyQT_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",21),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck23_WhiteOleander_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",22),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Ramp_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",23),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_lordavery_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",24),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_mmapson125_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-03",25),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }


    }
}
