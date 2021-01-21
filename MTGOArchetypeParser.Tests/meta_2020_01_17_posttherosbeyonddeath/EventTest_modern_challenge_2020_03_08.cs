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
#01 Dazai: Bant Control (WUG)
#02 McWinSauce: Azorius Control (WU)
#03 __matsugan: Neobrand (UG)
#04 joker10289: Amulet Titan (UG)
#05 npercario: Amulet Titan (WUG)
#06 Busterbrown52: Humans (WUBRG)
#07 MissTrigger: Jund Midrange (BRG)
#08 stainerson: Gruul Midrange (RG)
#09 musasabi: Amulet Titan (G)
#10 scipios: Crabvine (UBG)
#11 qbturtle15: Azorius Control (WU)
#12 Zar0s: Grinding Breach (WUBR)
#13 jon_cli: UBRG Shadow (UBRG)
#14 LORiWWA: Eldrazi Tron (G)
#15 twinlesstwin: Azorius Control (WU)
#16 SickWorld: Infect (UG)
#17 tangrams: Uroza (UG)
#18 benchsummer: UBRG Shadow (UBRG)
#19 Entman: Gruul Midrange (RG)
#20 Diem4x: Uroza (URG)
#21 NinoMtg: Thopter Urza (UBR)
#22 offline: Amulet Titan (UG)
#23 magical_me32: Dredge (BRG)
#24 MiguelCaster: Temur Control (URG)
#25 ecobaronen: Bant Control (WUG)
#26 ziofrancone: Gifts Storm (UR)
#27 GGoggles: Primeval Titan (BG)
#28 Sonic_Smasher: Primeval Titan (UG)
#29 trader08111: Primeval Titan (BG)
#30 Laplasjan: Eldrazi Tron (C)
#31 patheus_84: Ad Nauseam (WUB)
#32 svessesvv: Eldrazi Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_challenge_2020_03_08 : EventTest
    {
        [Test]
        public void Deck01_Dazai_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_McWinSauce_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck04_joker10289_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck05_npercario_AmuletTitan_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck06_Busterbrown52_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck07_MissTrigger_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_stainerson_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_musasabi_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck10_scipios_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck11_qbturtle15_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Zar0s_GrindingBreach_WUBR()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUBR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck13_joncli_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck14_LORiWWA_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck15_twinlesstwin_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_SickWorld_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck17_tangrams_Uroza_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck18_benchsummer_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Entman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",18),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Diem4x_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",19),
                "PostTherosBeyondDeath",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck21_NinoMtg_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",20),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck22_offline_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",21),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck23_magicalme32_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",22),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck24_MiguelCaster_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",23),
                "PostTherosBeyondDeath",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck25_ecobaronen_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",24),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck26_ziofrancone_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",25),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck27_GGoggles_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",26),
                "PostTherosBeyondDeath",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck28_SonicSmasher_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",27),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck29_trader08111_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",28),
                "PostTherosBeyondDeath",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Laplasjan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",29),
                "PostTherosBeyondDeath",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck31_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",30),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck32_svessesvv_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-03-08",31),
                "PostTherosBeyondDeath",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }


    }
}
