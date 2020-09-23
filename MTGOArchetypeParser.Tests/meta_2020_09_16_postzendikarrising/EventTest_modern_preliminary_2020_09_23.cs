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
#01 ZYURYO: WURGControl (WURG)
#02 Rinko: EnduringIdeal (WR)
#03 kanister: RakdosShadow (BR, Lurrus)
#04 Kurusu: KikiChord (WRG, Yorion)
#05 Bohnz: GruulMidrange (RG)
#06 Humpaa: RakdosShadow (BR, Lurrus)
#07 ImmanuelKantrolGod: JeskaiControl (WUR)
#08 spellvine: IzzetProwess (UR)
#09 HouseOfManaMTG: AmuletTitan (UBRG)
#10 tagosaku: Burn (WR)
#11 coert: HeliodCombo (WG)
#12 medvedev: MonoWhiteTaxes (W)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_09_23 : EventTest
    {
        [Test]
        public void Deck01_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Rinko_EnduringIdeal_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",1),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(EnduringIdeal),
                null,
                null
            );
        }

        [Test]
        public void Deck03_kanister_RakdosShadow_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",3),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck05_Bohnz_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",4),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Humpaa_RakdosShadow_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",5),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_ImmanuelKantrolGod_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",6),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_spellvine_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",7),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_HouseOfManaMTG_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",8),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck10_tagosaku_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",9),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck11_coert_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",10),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck12_medvedev_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-23",11),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }


    }
}
