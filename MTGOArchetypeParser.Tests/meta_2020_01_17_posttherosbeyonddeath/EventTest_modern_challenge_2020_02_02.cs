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
#01 Antoine57437: Badzan (WBG)
#02 elvin7: Uroza (UG)
#03 katoriarch123: Thopter Urza (UBR)
#04 SebastianStueckl: Humans (WUBRG)
#05 122pablo: Ascendancy Combo (WURG)
#06 _goblinlackey: Green Tron (G)
#07 Beicodegeia: Gifts Storm (UR)
#08 Orim67: Polymorph (WURG)
#09 Tiemuuu: Izzet Control (UR)
#10 cloudthresher77: Eldrazi Tron (C)
#11 Dark_Samurai: Free Spells (UR)
#12 rileydk: Amulet Titan (UG)
#13 Irkus: Green Eldrazi (RG)
#14 yanmaster: Hardened Scales (WG)
#15 Parrit: Orzhov Taxes (WB)
#16 McWinSauce: WURG Control (WURG)
#17 PuntThenWhine: Amulet Titan (UG)
#18 ecobaronen: Jund Midrange (BRG)
#19 2legit2quit: Gruul Midrange (RG)
#20 NuBlkAu: Mardu Shadow (WBR)
#21 yamakiller: Eldrazi Tron (G)
#22 Xtermanator: Mono Red Prowess (R)
#23 joker10289: Heliod Combo (WBG)
#24 Azerate218: UBRG Shadow (UBRG)
#25 echecetmat35: Primeval Titan (UG)
#26 Azngangbuzta: Dredge (BRG)
#27 scarl19: Primeval Titan (UG)
#28 Graciasportanto: Amulet Titan (UG)
#29 FeeltheRush: Devoted (WBG)
#30 AronGomu: Heliod Combo (WBG)
#31 raisans: Primeval Titan (UG)
#32 Papelucho10: Infect (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_challenge_2020_02_02 : EventTest
    {
        [Test]
        public void Deck01_Antoine57437_Badzan_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBG,
                typeof(Badzan),
                null,
                null
            );
        }

        [Test]
        public void Deck02_elvin7_Uroza_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck03_katoriarch123_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck04_SebastianStueckl_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_122pablo_AscendancyCombo_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(AscendancyCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck06_goblinlackey_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck07_Beicodegeia_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Orim67_Polymorph_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(Polymorph),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_cloudthresher77_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck11_DarkSamurai_FreeSpells_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck12_rileydk_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_Irkus_GreenEldrazi_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GreenEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck14_yanmaster_HardenedScales_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WG,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Parrit_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck16_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_PuntThenWhine_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck18_ecobaronen_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_2legit2quit_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",18),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_NuBlkAu_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",19),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBR,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck21_yamakiller_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",20),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck22_Xtermanator_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",21),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck23_joker10289_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",22),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Azerate218_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",23),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck25_echecetmat35_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",24),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Azngangbuzta_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",25),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck27_scarl19_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",26),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Graciasportanto_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",27),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck29_FeeltheRush_Devoted_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",28),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck30_AronGomu_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",29),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck31_raisans_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",30),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Papelucho10_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-02",31),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }


    }
}
