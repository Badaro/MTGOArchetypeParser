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
#01 romanmy: Sultai Shadow (UBG)
#02 Cherryxman: Eldrazi Tron (C)
#03 MATTHEWFOULKES: Grinding Breach (WUR)
#04 selbstdenker: Amulet Titan (G)
#05 pbarrrgh: Temur Control (URG)
#06 jessy_samek: Amulet Titan (UG)
#07 Weiden: Infect (UG)
#08 Tiemuuu: Izzet Control (UR)
#09 patrick50: Sultai Shadow (UBG)
#10 Kitchen_Finks: Esper Control (WUB)
#11 fistfullofmetal: Green Tron (G)
#12 imr107: Bant Control (WUG)
#13 NuBlkAu: Thopter Urza (UB)
#14 stayrospet: Thopter Urza (UB)
#15 gnorilgrande: Humans (WUBRG)
#16 Saviall: Green Tron (G)
#17 _Shatun_: Gruul Midrange (RG)
#18 Voidpaw: Jund Midrange (BRG)
#19 in5ano: Thopter Urza (WUR)
#20 SebastianStueckl: Burn (WR)
#21 MentalMisstep: Esper Control (WUB)
#22 _Batutinha_: Thopter Urza (UB)
#23 katuo079595: Rakdos Midrange (BR)
#24 bernardocssa: Humans (WUBRG)
#25 jstealths17: Sultai Shadow (UBG)
#26 Darkiundsa: Eldrazi Tron (C)
#27 SakeIzumo: Mono Red Prowess (R)
#28 sneaky robot: Bogles (WG)
#29 joker10289: Bant Control (WUG)
#30 meanfannypack: Devoted (WG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_03_05 : EventTest
    {
        [Test]
        public void Deck01_romanmy_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Cherryxman_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck03_MATTHEWFOULKES_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck04_selbstdenker_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck05_pbarrrgh_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_jessysamek_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_Weiden_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_patrick50_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck10_KitchenFinks_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_fistfullofmetal_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck12_imr107_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_NuBlkAu_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck14_stayrospet_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck15_gnorilgrande_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Saviall_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck17_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Voidpaw_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_in5ano_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",18),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck20_SebastianStueckl_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",19),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck21_MentalMisstep_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",20),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Batutinha_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",21),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck23_katuo079595_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",22),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_bernardocssa_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",23),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck25_jstealths17_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",24),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Darkiundsa_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",25),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck27_SakeIzumo_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",26),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck28_sneakyrobot_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",27),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck29_joker10289_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",28),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_meanfannypack_Devoted_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-05",29),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }


    }
}
