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
#01 PRGJJAR: Dredge (BRG)
#02 yamakiller: Neobrand (UG)
#03 idutra: Gruul Midrange (RG)
#04 McWinSauce: WURG Control (WURG)
#05 stonepeanut: Green Tron (G)
#06 eXavie: Eldrazi Tron (C)
#07 MLupa: Izzet Control (UR)
#08 sandydogmtg: Burn (R)
#09 Ak4suk1: Neobrand (UG)
#10 im2g00t4ubarn: Thopter Urza (UB)
#11 SoulStrong: WURG Control (WURG)
#12 Bugsy69: Dredge (UBRG)
#13 stayrospet: Mono Red Prowess (R)
#14 Rukzah: Amulet Titan (UG)
#15 vini_torres: Gifts Storm (UR)
#16 stollis: Crabvine (UBRG)
#17 Xwhale: Eldrazi Tron (G)
#18 MartinezDP: Saheeli Combo (WURG)
#19 coert: Devoted (WBG)
#20 thugnificent32: Amulet Titan (UG)
#21 Nikito18: Izzet Control (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_04 : EventTest
    {
        [Test]
        public void Deck01_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck02_yamakiller_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck03_idutra_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_stonepeanut_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck06_eXavie_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_MLupa_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck09_Ak4suk1_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck10_im2g00t4ubarn_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck11_SoulStrong_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Bugsy69_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck13_stayrospet_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck14_Rukzah_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck15_vinitorres_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck16_stollis_Crabvine_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Xwhale_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck18_MartinezDP_SaheeliCombo_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck19_coert_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",18),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck20_thugnificent32_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",19),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck21_Nikito18_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-04",20),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }


    }
}
