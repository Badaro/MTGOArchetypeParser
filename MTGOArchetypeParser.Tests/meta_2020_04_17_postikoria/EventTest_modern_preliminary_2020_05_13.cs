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
#01 azatoyellow: Bogles (WG, Lurrus)
#02 Heibing: Ad Nauseam (WUBG)
#03 kefka27: Boros Prowess (WR, Lurrus)
#04 spellvine: Boros Prowess (WR, Lurrus)
#05 Toastxp: Mardu Prowess (WBR, Lurrus)
#06 ImmanuelKantrolGod: Azorius Control (WU, Kaheera)
#07 otakkun: Eldrazi Tron (C)
#08 aooaaooa: Gyruda Reanimator (WBRG, Gyruda)
#09 Dafne17: Gruul Midrange (RG, Obosh)
#10 Venom1: Jund Midrange (BRG, Lurrus)
#11 Doni_Dominaria: Gruul Midrange (RG, Obosh)
#12 _Batutinha_: Boros Prowess (WR, Lurrus)
#13 Butakov: Bogles (WG, Lurrus)
#14 signblindman: Jund Midrange (BRG, Obosh)
#15 CamKelly13: Green Tron (G, Jegantha)
#16 TSPJendrek: Azorius Control (WU)
#17 Dai1412: Bogles (WG, Lurrus)
#18 eresopacaso: Burn (WR, Lurrus)
#19 kanister: WURG Control (WURG, Yorion)
#20 albert62: Jund Midrange (BRG, Lurrus)
#21 _INF_: Gifts Storm (UR, Jegantha)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_13 : EventTest
    {
        [Test]
        public void Deck01_azatoyellow_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",0),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Heibing_AdNauseam_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",1),
                new PostIkoria(),
                ArchetypeColor.WUBG,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck03_kefka27_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",2),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_spellvine_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",3),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Toastxp_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",4),
                new PostIkoria(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_ImmanuelKantrolGod_AzoriusControl_WU_Kaheera()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",5),
                new PostIkoria(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck07_otakkun_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",6),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck08_aooaaooa_GyrudaReanimator_WBRG_Gyruda()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",7),
                new PostIkoria(),
                ArchetypeColor.WBRG,
                typeof(GyrudaReanimator),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck09_Dafne17_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",8),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck10_Venom1_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",9),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_DoniDominaria_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",10),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck12_Batutinha_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",11),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Butakov_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",12),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_signblindman_JundMidrange_BRG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",13),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck15_CamKelly13_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",14),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck16_TSPJendrek_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",15),
                new PostIkoria(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Dai1412_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",16),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_eresopacaso_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",17),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_kanister_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",18),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_albert62_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",19),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_INF_GiftsStorm_UR_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",20),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                ArchetypeCompanion.Jegantha
            );
        }


    }
}
