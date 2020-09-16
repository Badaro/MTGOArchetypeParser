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
#01 trader08111: GruulMidrange (RG)
#02 Violent_Outburst: Scapeshift (URG)
#03 mogis67: SultaiReclamation (UBG)
#04 Gerschi: MarduProwess (WBR, Lurrus)
#05 Samlg01: KGCAmuletTitan (WURG)
#06 _Stream: IzzetProwess (UR)
#07 IntegralHDK: JundMidrange (BRG)
#08 aarongulevich: IzzetProwess (UR)
#09 ilsecco14: SultaiControl (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_12 : EventTest
    {
        [Test]
        public void Deck01_trader08111_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",0),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_ViolentOutburst_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",1),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck03_mogis67_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Gerschi_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Samlg01_KGCAmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck06_Stream_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck07_IntegralHDK_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_aarongulevich_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_ilsecco14_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",8),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
