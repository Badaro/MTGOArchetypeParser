using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 _Shatun_: Obosh Aggro (R, Obosh)
#02 TSPJendrek: Sultai Control (UBG)
#03 WhiteOleander: Shadow Prowess (BR, Lurrus)
#04 NorrathDecay: Burn (WR)
#05 Mateusf34: Eldrazi Tron (C)
#06 fwdr3: Shadow Prowess (BR, Lurrus)
#07 Poyo_del_Mal: Heliod Combo (WG)
#08 tkcheungab: Green Tron (G)
#09 chengyiw: Sultai Control (UBG)
#10 WhiTe TsaR: Obosh Aggro (R, Obosh)
#11 selbstdenker: Amulet Titan (G)
#12 musasabi: Heliod Combo (WG)
#13 misterfister: Polymorph (WURG)
#14 JV_7777: WURG Control (WURG)
#15 Biednarccio: Hammer Time (W, Lurrus)
#16 Xenowan: Ascendancy Combo (WUR, Jegantha)
#17 Lord_of_Puntlantis: Izzet Control (UR)
#18 conormc530: Reclamation (UBG)
#19 CrusherBotBG: Hammer Time (W, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_05 : EventTest
    {
        [Test]
        public void Deck01_Shatun_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",0),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",1),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_WhiteOleander_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",2),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",3),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck05_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",4),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck06_fwdr3_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",5),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_PoyodelMal_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",6),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck08_tkcheungab_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",7),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck09_chengyiw_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",8),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_WhiTeTsaR_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",9),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck11_selbstdenker_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",10),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck12_musasabi_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",11),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck13_misterfister_Polymorph_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",12),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "Polymorph",
                null,
                null
            );
        }

        [Test]
        public void Deck14_JV7777_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",13),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Biednarccio_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",14),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Xenowan_AscendancyCombo_WUR_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",15),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "AscendancyCombo",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck17_LordofPuntlantis_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",16),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck18_conormc530_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",17),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck19_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-05",18),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
