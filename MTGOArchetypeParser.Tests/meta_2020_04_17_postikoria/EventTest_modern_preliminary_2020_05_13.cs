using FluentAssertions;
using MTGOArchetypeParser.Model;
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
#06 ImmanuelKantrolGod: Miracles (WU, Kaheera)
#07 otakkun: Eldrazi Tron (C)
#08 aooaaooa: Gyruda Reanimator (WUBRG, Gyruda)
#09 Dafne17: Gruul Midrange (RG, Obosh)
#10 Venom1: Jund Midrange (BRG, Lurrus)
#11 Doni_Dominaria: Gruul Midrange (RG, Obosh)
#12 _Batutinha_: Boros Prowess (WR, Lurrus)
#13 Butakov: Bogles (WG, Lurrus)
#14 signblindman: Jund Midrange (BRG, Obosh)
#15 CamKelly13: Green Tron (G, Jegantha)
#16 TSPJendrek: Miracles (WU)
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
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Heibing_AdNauseam_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",1),
                "PostIkoria",
                ArchetypeColor.WUBG,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck03_kefka27_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",2),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_spellvine_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",3),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Toastxp_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",4),
                "PostIkoria",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_ImmanuelKantrolGod_Miracles_WU_Kaheera()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",5),
                "PostIkoria",
                ArchetypeColor.WU,
                "Miracles",
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck07_otakkun_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",6),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_aooaaooa_GyrudaReanimator_WUBRG_Gyruda()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",7),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "GyrudaReanimator",
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck09_Dafne17_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",8),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck10_Venom1_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",9),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_DoniDominaria_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",10),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck12_Batutinha_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",11),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Butakov_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",12),
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_signblindman_JundMidrange_BRG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",13),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck15_CamKelly13_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",14),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck16_TSPJendrek_Miracles_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",15),
                "PostIkoria",
                ArchetypeColor.WU,
                "Miracles",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Dai1412_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",16),
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_eresopacaso_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",17),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_kanister_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",18),
                "PostIkoria",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_albert62_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",19),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_INF_GiftsStorm_UR_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-13",20),
                "PostIkoria",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                ArchetypeCompanion.Jegantha
            );
        }


    }
}
