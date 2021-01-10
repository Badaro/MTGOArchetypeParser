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
#01 Wizard_2002: Green Tron (G)
#02 Ravul: Eldrazi Tron (C)
#03 Mcleskey: Izzet Prowess (UR)
#04 Phill_Hellmuth: Shadow Prowess (WBR, Lurrus)
#05 pokerswizard: Green Tron (RG)
#06 xfile: Mono White Taxes (W)
#07 QuaCk QuaCk: Scapeshift (URG)
#08 DrDree: Gruul Midrange (RG)
#09 Alrawn: Shadow Prowess (BR, Lurrus)
#10 _Stream: Jund Prowess (BRG, Lurrus)
#11 bgv1989: Ad Nauseam (WUB)
#12 SpiderSpace: Electro Balance (URG)
#13 tzio: Orzhov Midrange (WB)
#14 ice_nine_: Land Destruction (WR)
#15 mmapson125: WURG Control (WURG)
#16 Ramp: Reclaimer Titan (WG)
#17 Matteso: Gifts Storm (UR)
#18 fingers1991: Shadow Prowess (BR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_05 : EventTest
    {
        [Test]
        public void Deck01_Wizard2002_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",0),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck02_Ravul_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",1),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck03_Mcleskey_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",2),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_PhillHellmuth_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",3),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_pokerswizard_GreenTron_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",4),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck06_xfile_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",5),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck07_QuaCkQuaCk_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",6),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck08_DrDree_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",7),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Alrawn_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",8),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Stream_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",9),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_bgv1989_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",10),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck12_SpiderSpace_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",11),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck13_tzio_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",12),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_icenine_LandDestruction_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",13),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(LandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck15_mmapson125_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",14),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Ramp_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",15),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck17_Matteso_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",16),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck18_fingers1991_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-05",17),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
