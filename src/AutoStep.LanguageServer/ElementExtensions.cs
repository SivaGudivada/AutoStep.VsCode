﻿using AutoStep.Elements;
using AutoStep.Language.Position;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Range = OmniSharp.Extensions.LanguageServer.Protocol.Models.Range;

namespace AutoStep.LanguageServer
{
    public static class ElementExtensions
    {
        public static Range Range(this PositionalElement element)
        {
            return new Range(element.Start(), element.End());
        }

        public static Position Start(this PositionalElement element)
        {
            return new Position(element.SourceLine - 1, element.StartColumn - 1);
        }

        public static Position End(this PositionalElement element)
        {
            return new Position(element.EndLine - 1, element.EndColumn);
        }

        public static Position Start(this PositionLineToken token, long line)
        {
            return new Position(line, token.StartColumn - 1);
        }

        public static Position End(this PositionLineToken token, long line)
        {
            return new Position(line, token.EndColumn);
        }
    }
}
