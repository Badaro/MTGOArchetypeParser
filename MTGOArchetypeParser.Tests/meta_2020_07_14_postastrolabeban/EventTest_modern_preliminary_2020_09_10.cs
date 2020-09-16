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
#01 billsive: TemurControl (URG)
#02 NightKnight131: Devoted (WG, Lurrus)
#03 SpikeYou: SultaiReclamation (UBG)
#04 Icteridae: Bogles (WG, Lurrus)
#05 azax: GrixisShadow (UBR)
#06 SunofNothing: SultaiControl (UBG)
#07 xstaytrue1102: JundMidrange (BRG)
#08 karatedom: SultaiControl (UBG)
#09 pokerswizard: BorosProwess (WR, Lurrus)
#10 _Stream: IzzetProwess (UR)
#11 _LSN_: Burn (WR, Lurrus)
#12 qbturtle15: GruulMidrange (RG)
#13 penips: OrzhovEldraziTaxes (WB)
#14 Kricha13: BorosProwess (WR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_10 : EventTest
    {
        [Test]
        public void Deck01_billsive_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",0),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_NightKnight131_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_SpikeYou_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Icteridae_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_azax_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck06_SunofNothing_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_xstaytrue1102_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_karatedom_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_pokerswizard_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Stream_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",9),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck11_LSN_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",11),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_penips_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Kricha13_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
