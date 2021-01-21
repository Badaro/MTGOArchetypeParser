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
#01 ElevatahPartay: Thopter Urza (UB)
#02 Kricha13: Mono Red Prowess (R)
#03 fling5133: Bant Control (WUG)
#04 samsherman: Eldrazi Tron (G)
#05 Sam_Lewin: Skelementals (BR)
#06 122pablo: Ascendancy Combo (WURG)
#07 selbstdenker: Amulet Titan (UG)
#08 TheYostWithTheMost: Neobrand (UG)
#09 VTCLA: Jund Shadow (BRG)
#10 azax: Neobrand (UG)
#11 __matsugan: Devoted (WG)
#12 _Batutinha_: Heliod Combo (WBG)
#13 ComradeKahla: Bant Control (WUG)
#14 RNGspecialist: Mardu Midrange (WBR)
#15 Sonic_Smasher: Dice Factory Tron (C)
#16 Tyerube1618: Gifts Storm (UR)
#17 gazmon48: Mono Red Prowess (R)
#18 dejoyjoe: Amulet Titan (UG)
#19 canderson3000: UBRG Shadow (UBRG)
#20 Oderus Urungus: Eldrazi Tron (G)
#21 coldfire153: Mono Red Prowess (R)
#22 3HDgamers: Burn (WR)
#23 mac121711: Sultai Control (UBG)
#24 zachattack23: Mono Red Prowess (R)
#25 GedionRavenor: Azorius Control (WU)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_22 : EventTest
    {
        [Test]
        public void Deck01_ElevatahPartay_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck02_Kricha13_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck03_fling5133_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_samsherman_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck05_SamLewin_Skelementals_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.BR,
                "Skelementals",
                null,
                null
            );
        }

        [Test]
        public void Deck06_122pablo_AscendancyCombo_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "AscendancyCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck07_selbstdenker_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck08_TheYostWithTheMost_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck09_VTCLA_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck10_azax_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck11_matsugan_Devoted_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.WG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Batutinha_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck13_ComradeKahla_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck14_RNGspecialist_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_SonicSmasher_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.C,
                "Tron",
                "DiceFactoryTron",
                null
            );
        }

        [Test]
        public void Deck16_Tyerube1618_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck17_gazmon48_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck18_dejoyjoe_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck19_canderson3000_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",18),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck20_OderusUrungus_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",19),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck21_coldfire153_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",20),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck22_3HDgamers_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",21),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck23_mac121711_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",22),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck24_zachattack23_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",23),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck25_GedionRavenor_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-22",24),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }


    }
}
