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
#01 FranPi: Gifts Storm (UR)
#02 Chefen: Eldrazi Tron (G)
#03 phol: Uroza (UG)
#04 AronGomu: Amulet Titan (UG)
#05 TheTunnelingCat: Eldrazi Tron (C)
#06 EtherSnake: Mono Red Prowess (R)
#07 Mistakenn: Amulet Titan (UG)
#08 Twibs: Green Tron (G)
#09 122pablo: Ascendancy Combo (WURG)
#10 Xwhale: Primeval Titan (WG)
#11 kefka27: Eldrazi Tron (C)
#12 TheMarin: Grixis Shadow (UBR)
#13 Fnoop: Green Tron (G)
#14 Tweedel: Humans (WUBRG)
#15 ecobaronen: Jund Midrange (BRG)
#16 salty12ZA: Dredge (BRG)
#17 Scooter8968: Sultai Control (UBG)
#18 crazybaloth: Devoted (WG)
#19 Slaydftw: Eldrazi Tron (G)
#20 yPrincipe: Amulet Titan (UG)
#21 Bruno_Mineiro: UBRG Shadow (UBRG)
#22 jhk_: Jund Midrange (BRG)
#23 kmacy90: Burn (WR)
#24 tako110: Jund Midrange (BRG)
#25 s063: Sultai Control (UBG)
#26 Poderosisimo: Crabvine (UBG)
#27 Delve3: Izzet Control (UR)
#28 Lanteror: Assault Loam (RG)
#29 Sodeq: Dredge (BRG)
#30 fradev1988: Electro Balance (UR)
#31 TheRiedl: Uroza (URG)
#32 Kazuga: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_challenge_2020_02_09 : EventTest
    {
        [Test]
        public void Deck01_FranPi_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Chefen_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck03_phol_Uroza_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck04_AronGomu_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck05_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck06_EtherSnake_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck07_Mistakenn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck08_Twibs_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck09_122pablo_AscendancyCombo_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "AscendancyCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Xwhale_PrimevalTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.WG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck11_kefka27_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck12_TheMarin_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Fnoop_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck14_Tweedel_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck15_ecobaronen_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_salty12ZA_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Scooter8968_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck18_crazybaloth_Devoted_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.WG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Slaydftw_EldraziTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",18),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck20_yPrincipe_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",19),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck21_BrunoMineiro_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",20),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck22_jhk_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",21),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck23_kmacy90_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",22),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck24_tako110_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",23),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck25_s063_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",24),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Poderosisimo_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",25),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck27_Delve3_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",26),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck28_Lanteror_AssaultLoam_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",27),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "AssaultLoam",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",28),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck30_fradev1988_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",29),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck31_TheRiedl_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",30),
                "PostTherosBeyondDeath",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck32_Kazuga_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-02-09",31),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
