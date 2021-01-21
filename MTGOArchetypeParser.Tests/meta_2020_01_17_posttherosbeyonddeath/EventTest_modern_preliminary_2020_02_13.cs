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
#01 therock988: Thopter Urza (UBR)
#02 idutra: Gruul Midrange (RG)
#03 SoulStrong: Bant Control (WUG)
#04 joker10289: Azorius Control (WU)
#05 josetorr87: Primeval Titan (WG)
#06 MrDynamite: Primeval Titan (WG)
#07 MissTrigger: Eldrazi Tron (C)
#08 Paskardi: Titan Shift (RG)
#09 HannoLee: Jund Midrange (BRG)
#10 Kazuga: Azorius Control (WU)
#11 Cherryxman: Grinding Breach (WUR)
#12 martyr1207: Humans (WUBRG)
#13 pegajusus: Uroza (UG)
#14 PTarts2win: Dredge (BRG)
#15 AlabasterWolfie: Grinding Breach (UBR)
#16 Bayesta_93: Grixis Shadow (UBR)
#17 helvetti: Thopter Urza (UBR)
#18 Tiemuuu: Izzet Control (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_13 : EventTest
    {
        [Test]
        public void Deck01_therock988_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck02_idutra_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_SoulStrong_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_joker10289_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_josetorr87_PrimevalTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.WG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck06_MrDynamite_PrimevalTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.WG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck07_MissTrigger_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_Paskardi_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck09_HannoLee_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Kazuga_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Cherryxman_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck12_martyr1207_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck13_pegajusus_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck14_PTarts2win_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck15_AlabasterWolfie_GrindingBreach_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Bayesta93_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck17_helvetti_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck18_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-13",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }


    }
}
