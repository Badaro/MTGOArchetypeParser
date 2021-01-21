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
#01 marcofabrizi: Bant Midrange (WUG)
#02 aspiringspike: Bant Blink (WUG)
#03 Eaglov: Amulet Titan (UG)
#04 mashmalovsky: Ad Nauseam (WUB)
#05 exoticherman: Shadow Prowess (BRG, Lurrus)
#06 lordavery: Bant Midrange (WUG)
#07 cntrlfreak: Grixis Shadow (UBR)
#08 McWinSauce: WURG Control (WURG)
#09 kanister: Dimir Control (UB)
#10 musasabi: Shadow Prowess (BR, Lurrus)
#11 DaniMRebel: Shadow Prowess (BR, Lurrus)
#12 CountrytimeCrusher: Ad Nauseam (WUB)
#13 cws: Gifts Storm (UR)
#14 Tiemuuu: Izzet Control (UR)
#15 _Falcon_: Shadow Prowess (BR, Lurrus)
#16 stainerson: Temur Control (URG)
#17 JustBurn420: Slivers (WUBRG)
#18 Chefen: Heliod Combo (WG)
#19 Caleb_Yetman: Omnath Saheeli (WURG, Jegantha)
#20 Capitano_CL: Oops All Spells (WUBRG)
#21 Jinete: WURG Control (WURG)
#22 Gobern: Niv To Light (WUBRG, Yorion)
#23 coert: Heliod Combo (WG, Yorion)
#24 darius89: Ad Nauseam (WUB)
#25 qbturtle15: Azorius Control (WU)
#26 bigjc00: Amulet Titan (RG)
#27 kiwgil01: Electro Balance (URG)
#28 Binolino: Reclaimer Titan (WRG)
#29 patheus_84: Ad Nauseam (WUB)
#30 HouseOfManaMTG: Amulet Titan (RG)
#31 Jositoshekel: Heliod Combo (WG)
#32 stayrospet: Dredge (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_11_15 : EventTest
    {
        [Test]
        public void Deck01_marcofabrizi_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",0),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck02_aspiringspike_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",1),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Eaglov_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",2),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck04_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",3),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck05_exoticherman_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",4),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_lordavery_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",5),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_cntrlfreak_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",6),
                "PostZendikarRising",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck08_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",7),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_kanister_DimirControl_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",8),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_musasabi_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",9),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_DaniMRebel_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",10),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_CountrytimeCrusher_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",11),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck13_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",12),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",13),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Falcon_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",14),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_stainerson_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",15),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck17_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",16),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Chefen_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",17),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck19_CalebYetman_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",18),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck20_CapitanoCL_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",19),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Jinete_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",20),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Gobern_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",21),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck23_coert_HeliodCombo_WG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",22),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck24_darius89_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",23),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck25_qbturtle15_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",24),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck26_bigjc00_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",25),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck27_kiwgil01_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",26),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck28_Binolino_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",27),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck29_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",28),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck30_HouseOfManaMTG_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",29),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck31_Jositoshekel_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",30),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck32_stayrospet_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-11-15",31),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }


    }
}
