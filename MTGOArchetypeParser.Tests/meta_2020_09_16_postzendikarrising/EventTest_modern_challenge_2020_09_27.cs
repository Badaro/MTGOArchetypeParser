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
#01 musasabi: Orzhov Midrange (WB)
#02 __matsugan: Oops All Spells (WUBRG)
#03 Bedell: Amulet Titan (URG)
#04 Bullwinkkle6705: UBRG Control (UBRG)
#05 GodOfSlaughter: Niv To Light (WUBRG, Yorion)
#06 rob85tx: Izzet Prowess (UR)
#07 TuggaNaxos: Burn (WBR, Lurrus)
#08 Laplasjan: Devoted (WG, Lurrus)
#09 Morenothings: Humans (WUBRG)
#10 ZYURYO: WURG Control (WURG)
#11 qbturtle15: Mono White Taxes (W)
#12 122pablo: Ascendancy Combo (WURG, Jegantha)
#13 SoulStrong: Shadow Prowess (BR, Lurrus)
#14 Sodeq: Ad Nauseam (WUB)
#15 Antarctica: Mardu Prowess (WBR, Lurrus)
#16 eggybenny: Devoted (WG, Lurrus)
#17 kiko: Mono White Taxes (W)
#18 matiaskm: Devoted (WG, Lurrus)
#19 Lacansa: Humans (WUBRG)
#20 Bayesta_93: Shadow Prowess (BR, Lurrus)
#21 kanister: Oops All Spells (WUBRG)
#22 trader08111: Gruul Midrange (RG)
#23 dough_shack: Amulet Titan (UG)
#24 TSPJendrek: Sultai Control (UBG)
#25 Smdster: Temur Control (URG)
#26 helpfulsheep: Rakdos Prowess (BR, Lurrus)
#27 Disgruntled_Elk: Shadow Prowess (BR, Lurrus)
#28 Side_Arms: Scapeshift (URG)
#29 Flshtoph: Niv To Light (WUBRG, Yorion)
#30 littledarwin: Hammer Time (W)
#31 Metcalf23: Mono White Taxes (W)
#32 HotBread: Gruul Midrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_09_27 : EventTest
    {
        [Test]
        public void Deck01_musasabi_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",0),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck02_matsugan_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",1),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Bedell_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",2),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck04_Bullwinkkle6705_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",3),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_GodOfSlaughter_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",4),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_rob85tx_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",5),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck07_TuggaNaxos_Burn_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",6),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",7),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Morenothings_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",8),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck10_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",9),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_qbturtle15_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",10),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck12_122pablo_AscendancyCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",11),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "AscendancyCombo",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck13_SoulStrong_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",12),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Sodeq_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",13),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Antarctica_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",14),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_eggybenny_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",15),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_kiko_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",16),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck18_matiaskm_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",17),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_Lacansa_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",18),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Bayesta93_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",19),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_kanister_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",20),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck22_trader08111_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",21),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck23_doughshack_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",22),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck24_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",23),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck25_Smdster_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",24),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck26_helpfulsheep_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",25),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_DisgruntledElk_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",26),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_SideArms_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",27),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Flshtoph_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",28),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck30_littledarwin_HammerTime_W()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",29),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Metcalf23_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",30),
                "PostZendikarRising",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck32_HotBread_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",31),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
