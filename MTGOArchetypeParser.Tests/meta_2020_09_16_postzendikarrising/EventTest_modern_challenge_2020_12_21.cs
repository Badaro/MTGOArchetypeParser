using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Boucha: Belcher (URG)
#02 kanister: Primeval Titan (UG)
#03 DenebLyrae: Heliod Combo (WRG)
#04 Tiemuuu: Izzet Control (UR)
#05 ElYallo: Heliod Combo (WG)
#06 Benkill: Spirits (WU)
#07 Kurusu: Kiki Chord (WURG, Yorion)
#08 Beekeeper: Dredge (BRG)
#09 nahuel10: Izzet Prowess (UR)
#10 WeareVenom: WURG Control (WURG)
#11 MrRaeb: UBRG Control (UBRG)
#12 Do0mSwitch: WURG Control (WURG)
#13 buddha715: Burn (WR, Lurrus)
#14 KO_Mak: Oops All Spells (UBG)
#15 _Batutinha_: Shadow Prowess (BRG, Lurrus)
#16 Predicted: Yawgmoth (WBG)
#17 AndyBurden: Obosh Aggro (R, Obosh)
#18 Kr0k39: Amulet Titan (G)
#19 Edel: Rakdos Midrange (BR)
#20 rodeo: Oops All Spells (WUBRG)
#21 Moniz0801: Amulet Titan (RG)
#22 _LSN_: Burn (WR)
#23 tzio: Rakdos Midrange (BR)
#24 futureshok: Dredge (BRG)
#25 kiko: Azorius Taxes (WU, Yorion)
#26 Hyeri0418: Gifts Storm (UR)
#27 Hamuda: Hammer Time (WB, Lurrus)
#28 ZYX_Jerry: Belcher (URG)
#29 Laplasjan: Hammer Time (WB, Lurrus)
#30 Binolino: Reclaimer Titan (WBG)
#31 UmekawaneikU: Rakdos Midrange (BR)
#32 Mateusf34: Eldrazi Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_12_21 : EventTest
    {
        [Test]
        public void Deck01_Boucha_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",0),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck02_kanister_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",1),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck03_DenebLyrae_HeliodCombo_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",2),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",3),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_ElYallo_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",4),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Benkill_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",5),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Kurusu_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",6),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "KikiChord",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_Beekeeper_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",7),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck09_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",8),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck10_WeareVenom_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",9),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_MrRaeb_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",10),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Do0mSwitch_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",11),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_buddha715_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",12),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_KOMak_OopsAllSpells_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",13),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Batutinha_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",14),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Predicted_Yawgmoth_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",15),
                "PostZendikarRising",
                ArchetypeColor.WBG,
                "Yawgmoth",
                null,
                null
            );
        }

        [Test]
        public void Deck17_AndyBurden_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",16),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck18_Kr0k39_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",17),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck19_Edel_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",18),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck20_rodeo_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",19),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Moniz0801_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",20),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck22_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",21),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck23_tzio_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",22),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck24_futureshok_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",23),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck25_kiko_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",24),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "GenericTaxes",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck26_Hyeri0418_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",25),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck27_Hamuda_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",26),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_ZYXJerry_Belcher_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",27),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Laplasjan_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",28),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_Binolino_ReclaimerTitan_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",29),
                "PostZendikarRising",
                ArchetypeColor.WBG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck31_UmekawaneikU_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",30),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck32_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-12-21",31),
                "PostZendikarRising",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }


    }
}
