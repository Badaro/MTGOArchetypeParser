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
#01 C_E.L: Heliod Combo (WBG)
#02 quinniac: Burn (WR)
#03 CReactor: Eldrazi Tron (G)
#04 katuo079595: Mono Red Prowess (R)
#05 TombSimon: Crabvine (UBG)
#06 Mercenario: Dredge (UBRG)
#07 Heibing: Infect (WUG)
#08 __matsugan: Neobrand (UG)
#09 otakkun: Eldrazi Tron (G)
#10 Sam_Lewin: Skelementals (BR)
#11 Tanzo90: Temur Midrange (URG)
#12 SYMO991: Jund Midrange (BRG)
#13 PRGJJAR: Dredge (BRG)
#14 Fnoop: Green Tron (G)
#15 AllOfMe: Amulet Titan (UG)
#16 tanisong1221: Orzhov Midrange (WB)
#17 Tiemuuu: Izzet Control (UR)
#18 Sodeq: Dredge (WBRG)
#19 kiko: Esper Blink (WUB)
#20 SoulStrong: Thopter Urza (UB)
#21 VampireGodric: Mono Red Prowess (R)
#22 mitchrules25: Eight Whack (R)
#23 im2g00t4ubarn: Amulet Titan (UG)
#24 Yooisa: Primeval Titan (UG)
#25 patheus_84: Ad Nauseam (WUB)
#26 Cherlon: Burn (WR)
#27 Colomino: Thopter Urza (WUR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_20 : EventTest
    {
        [Test]
        public void Deck01_CEL_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck02_quinniac_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck03_CReactor_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck04_katuo079595_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_TombSimon_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Mercenario_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Heibing_Infect_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck08_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck09_otakkun_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck10_SamLewin_Skelementals_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BR,
                typeof(Skelementals),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Tanzo90_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.URG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_SYMO991_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Fnoop_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck15_AllOfMe_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck16_tanisong1221_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Sodeq_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck19_kiko_EsperBlink_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",18),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUB,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck20_SoulStrong_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",19),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck21_VampireGodric_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",20),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck22_mitchrules25_EightWhack_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",21),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(EightWhack),
                null,
                null
            );
        }

        [Test]
        public void Deck23_im2g00t4ubarn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",22),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_Yooisa_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",23),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck25_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",24),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Cherlon_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",25),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Colomino_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-20",26),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }


    }
}
