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
#01 sultai4lyfe: Dimir Control (UB)
#02 ZYURYO: Azorius Control (WU)
#03 AronGomu: Heliod Combo (WBG)
#04 bntrusty14: Humans (WUBRG)
#05 yamakiller: Eldrazi Tron (G)
#06 Irkus: Green Eldrazi (RG)
#07 Meltiin: Reclaimer Titan (WURG)
#08 Jadacant: Ad Nauseam (WUB)
#09 genkytoro: Jund Midrange (BRG)
#10 Bayesta_93: Grixis Shadow (UBR)
#11 TheTunnelingCat: Eldrazi Tron (C)
#12 SnakeInABlender: Jund Midrange (BRG)
#13 jundilion: Living End (BRG)
#14 lucky_dragon: Jund Midrange (BRG)
#15 nsg1989: Burn (WR)
#16 tangrams: Primeval Titan (UG)
#17 vini_torres: Gifts Storm (UR)
#18 Finalnub: Neobrand (UG)
#19 kanister: Amulet Titan (UG)
#20 Sodeq: Dredge (BRG)
#21 _LSN_: Burn (WR)
#22 TheRealRickJames: Mono Red Prowess (R)
#23 PRGJJAR: Dredge (BRG)
#24 reiderrabbit: Jund Midrange (BRG)
#25 Erik157751: Crabvine (UBG)
#26 Cherryxman: Izzet Control (UR)
#27 mdvayu2: Mono Red Prowess (R)
#28 fooswashere: Jund Midrange (BRG)
#29 powpow5000: Burn (WR)
#30 Entropy263: Yawgmoth (BG)
#31 ssnelson: Jund Shadow (BRG)
#32 ACG88: Mono Red Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_challenge_2020_01_19 : EventTest
    {
        [Test]
        public void Deck01_sultai4lyfe_DimirControl_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_ZYURYO_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_AronGomu_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck04_bntrusty14_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck05_yamakiller_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck06_Irkus_GreenEldrazi_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GreenEldrazi",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Meltiin_ReclaimerTitan_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck08_Jadacant_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck09_genkytoro_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Bayesta93_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck11_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck12_SnakeInABlender_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_jundilion_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "LivingEnd",
                null,
                null
            );
        }

        [Test]
        public void Deck14_luckydragon_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_nsg1989_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck16_tangrams_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck17_vinitorres_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Finalnub_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck19_kanister_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",18),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck20_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",19),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck21_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",20),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck22_TheRealRickJames_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",21),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck23_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",22),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck24_reiderrabbit_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",23),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck25_Erik157751_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",24),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Cherryxman_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",25),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck27_mdvayu2_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",26),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck28_fooswashere_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",27),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck29_powpow5000_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",28),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck30_Entropy263_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",29),
                "PostTherosBeyondDeath",
                ArchetypeColor.BG,
                "Yawgmoth",
                null,
                null
            );
        }

        [Test]
        public void Deck31_ssnelson_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",30),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck32_ACG88_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-01-19",31),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
