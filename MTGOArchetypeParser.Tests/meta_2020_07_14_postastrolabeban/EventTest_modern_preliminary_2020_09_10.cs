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
#01 billsive: Temur Control (URG)
#02 NightKnight131: Devoted (WG, Lurrus)
#03 SpikeYou: Sultai Control (UBG)
#04 Icteridae: Bogles (WG, Lurrus)
#05 azax: Grixis Shadow (UBR)
#06 SunofNothing: Sultai Control (UBG)
#07 xstaytrue1102: Jund Midrange (BRG)
#08 karatedom: Sultai Control (UBG)
#09 pokerswizard: Boros Prowess (WR, Lurrus)
#10 _Stream: Izzet Prowess (UR)
#11 _LSN_: Burn (WR, Lurrus)
#12 qbturtle15: Gruul Midrange (RG)
#13 penips: Orzhov Taxes (WB)
#14 Kricha13: Boros Prowess (WR, Lurrus)
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
        public void Deck03_SpikeYou_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
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
                typeof(Shadow),
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
                typeof(RedAggro),
                typeof(Prowess),
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
                typeof(RedAggro),
                typeof(Prowess),
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
                typeof(RedAggro),
                typeof(Burn),
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
        public void Deck13_penips_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-10",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
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
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
