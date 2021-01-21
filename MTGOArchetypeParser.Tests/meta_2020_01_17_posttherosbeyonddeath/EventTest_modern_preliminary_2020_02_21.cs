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
#01 Darkiundsa: Eldrazi Tron (G)
#02 VampireGodric: Mono Red Prowess (R)
#03 Matti: Dredge (BRG)
#04 pepeteam: Amulet Titan (UG)
#05 Oderus Urungus: Eldrazi Tron (G)
#06 quinniac: Burn (WR)
#07 Kazuga: Jund Midrange (BRG)
#08 Gobern: Bant Control (WUG)
#09 toondoslav: Primeval Titan (BG)
#10 _Shatun_: Mono Red Prowess (R)
#11 Folero: Pyro Ascension (WUR)
#12 ComradeKahla: Bant Control (WUG)
#13 Fnoop: Green Tron (G)
#14 yamakiller: Ad Nauseam (WUB)
#15 ecobaronen: Bant Control (WUG)
#16 el-pollo-lolo: Rakdos Midrange (BR)
#17 McWinSauce: WURG Control (WURG)
#18 tanisong1221: Orzhov Midrange (WB)
#19 bolov0: Burn (WR)
#20 Twibs: Green Tron (G)
#21 Blueliner: Jund Midrange (BRG)
#22 Mercenario: Dredge (UBRG)
#23 _IlNano_: Eldrazi Tron (G)
#24 vinnyrussian123: Primeval Titan (UG)
#25 MATTHEWFOULKES: Mono Red Prowess (R)
#26 LMKNAO: Uroza (UBG)
#27 mac121711: Sultai Control (UBG)
#28 AllOfMe: Burn (WR)
#29 Icteridae: Devoted (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_21 : EventTest
    {
        [Test]
        public void Deck01_Darkiundsa_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck02_VampireGodric_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck03_Matti_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck04_pepeteam_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck05_OderusUrungus_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck06_quinniac_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck07_Kazuga_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Gobern_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_toondoslav_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck11_Folero_PyroAscension_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUR,
                "PyroAscension",
                null,
                null
            );
        }

        [Test]
        public void Deck12_ComradeKahla_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Fnoop_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck14_yamakiller_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck15_ecobaronen_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_elpollololo_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck17_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck18_tanisong1221_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.WB,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck19_bolov0_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",18),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck20_Twibs_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",19),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck21_Blueliner_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",20),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Mercenario_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",21),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck23_IlNano_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",22),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck24_vinnyrussian123_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",23),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck25_MATTHEWFOULKES_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",24),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck26_LMKNAO_Uroza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",25),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck27_mac121711_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",26),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck28_AllOfMe_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",27),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck29_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-21",28),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "Devoted",
                null,
                null
            );
        }


    }
}
