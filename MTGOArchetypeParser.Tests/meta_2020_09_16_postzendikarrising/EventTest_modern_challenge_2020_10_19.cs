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
#01 Darkiundsa: Humans (WUBRG)
#02 stayrospet: Omnath Saheeli (WURG, Jegantha)
#03 Nekonii: Elves (BG)
#04 azax: Reclaimer Titan (WUG)
#05 Jositoshekel: Heliod Combo (WG)
#06 JustJack: Humans (WUBRG)
#07 Mcleskey: Humans (WUBRG)
#08 musasabi: Reclaimer Titan (WG)
#09 WhiTe TsaR: Omnath Saheeli (WURG)
#10 MiamiKidz: Reclaimer Titan (WRG)
#11 MHayashi: Obosh Aggro (R, Obosh)
#12 toondoslav: Mono White Taxes (W)
#13 PhantasmalBear: Sultai Midrange (UBG)
#14 McWinSauce: WURG Control (WURG)
#15 DrDree: Humans (WUBRG)
#16 axk2: Neobrand (UG)
#17 Gods_Shadow: Grixis Control (UBR, Lurrus)
#18 DaniMRebel: Spirits (WU)
#19 Malpyrocky: Shadow Prowess (BR, Lurrus)
#20 KoKonuts: Green Tron (G, Jegantha)
#21 Jenara19: Omnath Saheeli (WURG, Jegantha)
#22 mechint: WURG Control (WURG)
#23 Blitzlion27: Mill (WU)
#24 fedjkeee: Jund Shadow (BRG)
#25 An_Actual_Potato: Humans (WUBRG)
#26 Ibaitor: Golgari Midrange (BG)
#27 AstralPlane: Omnath Saheeli (WURG, Jegantha)
#28 asics112: Humans (WUBRG)
#29 TheSouthDakota: Dredge (BRG)
#30 daibloXSC: Jeskai Control (WUR)
#31 StrawberryMilkShake1: Izzet Control (UR)
#32 aManatease: Shadow Prowess (WBR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_10_19 : EventTest
    {
        [Test]
        public void Deck01_Darkiundsa_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",0),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck02_stayrospet_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck03_Nekonii_Elves_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",2),
                "PostZendikarRising",
                ArchetypeColor.BG,
                "Elves",
                null,
                null
            );
        }

        [Test]
        public void Deck04_azax_ReclaimerTitan_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",3),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck05_Jositoshekel_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",4),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck06_JustJack_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",5),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Mcleskey_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",6),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck08_musasabi_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",7),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck09_WhiTeTsaR_OmnathSaheeli_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",8),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                null
            );
        }

        [Test]
        public void Deck10_MiamiKidz_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",9),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck11_MHayashi_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",10),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck12_toondoslav_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",11),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck13_PhantasmalBear_SultaiMidrange_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",12),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",13),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_DrDree_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",14),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck16_axk2_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",15),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck17_GodsShadow_GrixisControl_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",16),
                "PostZendikarRising",
                ArchetypeColor.UBR,
                "GenericControl",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_DaniMRebel_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",17),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Malpyrocky_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",18),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_KoKonuts_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",19),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck21_Jenara19_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",20),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck22_mechint_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",21),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Blitzlion27_Mill_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",22),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck24_fedjkeee_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",23),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck25_AnActualPotato_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",24),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Ibaitor_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",25),
                "PostZendikarRising",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck27_AstralPlane_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",26),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck28_asics112_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",27),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck29_TheSouthDakota_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",28),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck30_daibloXSC_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",29),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck31_StrawberryMilkShake1_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",30),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck32_aManatease_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-19",31),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
