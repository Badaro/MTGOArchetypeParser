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
#01 bomberboss: Humans (WUBRG)
#02 selbstdenker: Amulet Titan (URG)
#03 _Batutinha_: Boros Prowess (WR, Lurrus)
#04 grinderA: Gruul Midrange (RG, Obosh)
#05 triosk: Primeval Titan (BG)
#06 Venom1: Burn (WR, Lurrus)
#07 coert: Burn (WR, Lurrus)
#08 MrJACEone: Heliod Combo (WG, Zirda)
#09 Toastxp: UBRG Control (UBRG, Lurrus)
#10 MissTrigger: Burn (WR, Lurrus)
#11 dout: Humans (WUBRG)
#12 sydneydude: Boros Prowess (WR, Lurrus)
#13 gabrialfo: Burn (WR, Lurrus)
#14 Doomed_Necromancer: Goblins (BRG)
#15 Rinko: Goryo Reanimator (BRG)
#16 MiamiKidz: Heliod Combo (WG, Zirda)
#17 NosonosaN: Uroza (URG, Yorion)
#18 Albimtg: Golgari Midrange (BG, Lurrus)
#19 NBAtor16: Ad Nauseam (WUB)
#20 fradev1988: Neobrand (UG)
#21 GiovaniMF: Boros Prowess (WR, Lurrus)
#22 Larry11: Hardened Scales (BG, Lurrus)
#23 signblindman: Gruul Midrange (RG, Obosh)
#24 MaxMagicer: Humans (WUBRG)
#25 Naisirc: Hardened Scales (BG, Lurrus)
#26 kbr3: Hardened Scales (WG, Lurrus)
#27 Vita_89: Golgari Midrange (BG, Lurrus)
#28 NathanLipetz: Izzet Control (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_04_29 : EventTest
    {
        [Test]
        public void Deck01_bomberboss_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",0),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck02_selbstdenker_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",1),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck03_Batutinha_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",2),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_grinderA_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",3),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck05_triosk_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",4),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Venom1_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",5),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_coert_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",6),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_MrJACEone_HeliodCombo_WG_Zirda()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",7),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck09_Toastxp_UBRGControl_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",8),
                new PostIkoria(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_MissTrigger_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",9),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_dout_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",10),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck12_sydneydude_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",11),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_gabrialfo_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",12),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_DoomedNecromancer_Goblins_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",13),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Rinko_GoryoReanimator_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",14),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GoryoReanimator),
                null,
                null
            );
        }

        [Test]
        public void Deck16_MiamiKidz_HeliodCombo_WG_Zirda()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",15),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck17_NosonosaN_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",16),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_Albimtg_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",17),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_NBAtor16_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",18),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck20_fradev1988_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",19),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck21_GiovaniMF_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",20),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_Larry11_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",21),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_signblindman_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",22),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck24_MaxMagicer_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",23),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Naisirc_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",24),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_kbr3_HardenedScales_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",25),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_Vita89_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",26),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_NathanLipetz_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-29",27),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
