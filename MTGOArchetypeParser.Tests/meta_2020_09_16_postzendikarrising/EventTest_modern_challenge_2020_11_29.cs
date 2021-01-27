using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Tweedel: Obosh Aggro (R, Obosh)
#02 Xwhale: Reclaimer Titan (WG)
#03 otakkun: Eldrazi Tron (C)
#04 HNSDMPF: Hardened Scales (G)
#05 JUJUBEAN__2004: Heliod Combo (WG)
#06 eclipse4343: Miracles (WU)
#07 Selami: Ad Nauseam (WUB)
#08 AlpInco: Oops All Spells (WUBRG)
#09 Oderus Urungus: Obosh Aggro (R, Obosh)
#10 Amplumnox: Hammer Time (W, Lurrus)
#11 Piproberts: Shadow Prowess (BRG, Lurrus)
#12 CrusherBotBG: Hammer Time (W, Lurrus)
#13 Matty_Mumbles: Scapeshift (URG)
#14 juzam_gin: Dredge (BRG)
#15 mariogomes097: Hammer Time (W, Lurrus)
#16 kanister: Shadow Prowess (BR, Lurrus)
#17 Gifted: Shadow Prowess (BRG, Lurrus)
#18 Nikachu: Merfolk (UG)
#19 PieGonti: Heliod Combo (WG)
#20 silencsong: Electro Balance (URG)
#21 Binolino: Reclaimer Titan (WRG)
#22 Jositoshekel: Heliod Combo (WG)
#23 Aerostar: Merfolk (UG)
#24 benchsummer: UBRG Shadow (UBRG)
#25 cftsoc3: WURG Blink (WURG, Yorion)
#26 MHayashi: Obosh Aggro (R, Obosh)
#27 guiyote: Izzet Prowess (UR)
#28 Do0mSwitch: Azorius Control (WU)
#29 GombleWhop: Amulet Titan (RG)
#30 joetru: Niv To Light (WUBRG)
#31 SvenSveeterSven: Mardu Midrange (WBR)
#32 Better_than_Average: Obosh Aggro (R, Obosh)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_11_29 : EventTest
    {
        [Test]
        public void Deck01_Tweedel_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",0),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_Xwhale_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",1),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck03_otakkun_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",2),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck04_HNSDMPF_HardenedScales_G()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",3),
                "PostZendikarRising",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                null
            );
        }

        [Test]
        public void Deck05_JUJUBEAN2004_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",4),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck06_eclipse4343_Miracles_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",5),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Miracles",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Selami_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",6),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck08_AlpInco_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",7),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck09_OderusUrungus_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",8),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck10_Amplumnox_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",9),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Piproberts_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",10),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",11),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_MattyMumbles_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",12),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck14_juzamgin_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",13),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck15_mariogomes097_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",14),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_kanister_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",15),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_Gifted_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",16),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Nikachu_Merfolk_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",17),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Merfolk",
                null,
                null
            );
        }

        [Test]
        public void Deck19_PieGonti_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",18),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck20_silencsong_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",19),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck21_Binolino_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",20),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck22_Jositoshekel_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",21),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Aerostar_Merfolk_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",22),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Merfolk",
                null,
                null
            );
        }

        [Test]
        public void Deck24_benchsummer_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",23),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck25_cftsoc3_WURGBlink_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",24),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericBlink",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck26_MHayashi_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",25),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck27_guiyote_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",26),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck28_Do0mSwitch_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",27),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck29_GombleWhop_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",28),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck30_joetru_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",29),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck31_SvenSveeterSven_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",30),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck32_BetterthanAverage_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-11-29",31),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }


    }
}
