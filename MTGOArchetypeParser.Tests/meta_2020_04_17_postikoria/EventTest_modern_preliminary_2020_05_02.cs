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
#01 albertoSD: Amulet Titan (G)
#02 meanfannypack: Devoted (WG, Lurrus)
#03 Bugsy69: Hardened Scales (WG, Lurrus)
#04 ecobaronen: WURG Control (WURG, Yorion)
#05 ZYURYO: Bant Control (WUG, Yorion)
#06 in5ano: Uroza (URG, Yorion)
#07 kashf: Mono White Taxes (W)
#08 eresopacaso: Burn (WR, Lurrus)
#09 Biednarccio: Amulet Titan (RG)
#10 GedionRavenor: Boros Prowess (WR, Lurrus)
#11 joker10289: Dimir Control (UB, Lurrus)
#12 signblindman: Gruul Midrange (RG, Obosh)
#13 triosk: Uroza (URG, Yorion)
#14 Capitano_CL: Neobrand (UG)
#15 Janh: Grixis Shadow (UBR, Lurrus)
#16 GGbizz: Ad Nauseam (WUB)
#17 TSPJendrek: Dimir Control (UB, Lurrus)
#18 Capriccioso: Green Tron (G, Jegantha)
#19 Alakai: Twiddle Storm (UBR, Lurrus)
#20 bomberboss: Humans (WUBRG)
#21 EmErgy: Gruul Midrange (RG, Obosh)
#22 JoseCabezas: Uroza (URG, Yorion)
#23 Logarythme: WURG Control (WURG, Yorion)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_02 : EventTest
    {
        [Test]
        public void Deck01_albertoSD_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",0),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_meanfannypack_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",1),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Bugsy69_HardenedScales_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",2),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_ecobaronen_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",3),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck05_ZYURYO_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",4),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_in5ano_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",5),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_kashf_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",6),
                new PostIkoria(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck08_eresopacaso_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",7),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Biednarccio_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",8),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck10_GedionRavenor_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",9),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_joker10289_DimirControl_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",10),
                new PostIkoria(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_signblindman_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",11),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck13_triosk_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",12),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck14_CapitanoCL_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",13),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Janh_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",14),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_GGbizz_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",15),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck17_TSPJendrek_DimirControl_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",16),
                new PostIkoria(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Capriccioso_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",17),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck19_Alakai_TwiddleStorm_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",18),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(TwiddleStorm),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_bomberboss_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",19),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck21_EmErgy_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",20),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck22_JoseCabezas_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",21),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck23_Logarythme_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-02",22),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }


    }
}
