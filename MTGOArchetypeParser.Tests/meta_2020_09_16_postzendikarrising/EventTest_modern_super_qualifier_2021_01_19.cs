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
#01 brunocaffaro: Belcher (URG)
#02 Do0mSwitch: WURG Control (WURG)
#03 Skrown: Shadow Prowess (BR, Lurrus)
#04 CanadianBac0nz: Heliod Combo (WR)
#05 Violent_Outburst: Scapeshift (WURG)
#06 edward40hands: Golgari Midrange (BG)
#07 FestiFan: Reclamation (UBG)
#08 cicciogire: WURG Control (WURG)
#09 Talisker: Jund Midrange (BRG)
#10 O_danielakos: Izzet Prowess (UR)
#11 Arrias: Heliod Combo (WRG)
#12 D00mwake: Heliod Combo (WG)
#13 Rauptro: Jeskai Control (WUR)
#14 PietroSas: Hammer Time (WB, Lurrus)
#15 albertoSD: Mill (UB, Lurrus)
#16 Mateusf34: Eldrazi Tron (R)
#17 Bishark: Merfolk (WU, Lurrus)
#18 Traft: Ad Nauseam (WUB)
#19 pablozoo: Green Tron (G, Jegantha)
#20 TSPJendrek: Sultai Control (UBG)
#21 nekonekoneko: Shadow Prowess (WBR, Lurrus)
#22 musasabi: WURG Control (WURG)
#23 Avignon: WURG Control (WURG)
#24 UmekawaneikU: Hammer Time (WB, Lurrus)
#25 remf: Spirits (WU)
#26 GHash77: WURG Control (WURG)
#27 _Shatun_: Obosh Aggro (R, Obosh)
#28 Bunnykept: Dredge (BRG)
#29 Kungpowpow: Heliod Combo (WG)
#30 dolly_d84: Izzet Prowess (UR)
#31 JUJUBEAN__2004: WURG Control (WURG)
#32 bomberboss: Boros Taxes (WR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_super_qualifier_2021_01_19 : EventTest
    {
        [Test]
        public void Deck01_brunocaffaro_Belcher_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",0),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Do0mSwitch_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Skrown_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",2),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_CanadianBac0nz_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",3),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck05_ViolentOutburst_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",4),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck06_edward40hands_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",5),
                "PostZendikarRising",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_FestiFan_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",6),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck08_cicciogire_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",7),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Talisker_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",8),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Odanielakos_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",9),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck11_Arrias_HeliodCombo_WRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",10),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck12_D00mwake_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",11),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Rauptro_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",12),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck14_PietroSas_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",13),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_albertoSD_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",14),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Mateusf34_EldraziTron_R()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",15),
                "PostZendikarRising",
                ArchetypeColor.R,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck17_Bishark_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",16),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Merfolk",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Traft_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",17),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck19_pablozoo_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",18),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck20_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",19),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_nekonekoneko_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",20),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_musasabi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",21),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Avignon_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",22),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck24_UmekawaneikU_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",23),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_remf_Spirits_WU()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",24),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck26_GHash77_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",25),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck27_Shatun_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",26),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck28_Bunnykept_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",27),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Kungpowpow_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",28),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck30_dollyd84_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",29),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck31_JUJUBEAN2004_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",30),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck32_bomberboss_BorosTaxes_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2021-01-19",31),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "GenericTaxes",
                null,
                null
            );
        }


    }
}
