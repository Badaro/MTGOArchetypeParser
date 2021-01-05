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
#01 Gerschi: Oops All Spells (WUBG)
#02 Metaponto: Bant Spirits (WUG)
#03 Mulldrifter: Shadow Prowess (WBR, Lurrus)
#04 Tiemuuu: Izzet Control (UR)
#05 BERNASTORRES: WURG Control (WURG)
#06 Damgar: KGC Tron (G)
#07 grinderA: Devoted (WG, Lurrus)
#08 Paeng_Paeng: Gifts Storm (UR)
#09 Wyern: Belcher (RG)
#10 MiamiKidz: Reclaimer Titan (WRG)
#11 Sam_Lewin: Boros Land Destruction (WR)
#12 Lukas261997: Grixis Shadow (UBR)
#13 2k4mmorton: Mono Red Prowess (R)
#14 CavalloGoloso: Izzet Control (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_04 : EventTest
    {
        [Test]
        public void Deck01_Gerschi_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-04",0),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Metaponto_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-04",1),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Mulldrifter_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-04",2),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-04",3),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_BERNASTORRES_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-04",4),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Damgar_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-04",5),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                null
            );
        }

        [Test]
        public void Deck07_grinderA_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-04",6),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_PaengPaeng_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-04",7),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Wyern_Belcher_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-04",8),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck10_MiamiKidz_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-04",9),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck11_SamLewin_BorosLandDestruction_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-04",10),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(LandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Lukas261997_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-04",11),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck13_2k4mmorton_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-04",12),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck14_CavalloGoloso_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-04",13),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
