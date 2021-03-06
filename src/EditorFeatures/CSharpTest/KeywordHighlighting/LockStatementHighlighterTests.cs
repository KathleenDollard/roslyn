﻿// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis.Editor.CSharp.KeywordHighlighting.KeywordHighlighters;
using Roslyn.Test.Utilities;
using Xunit;

namespace Microsoft.CodeAnalysis.Editor.CSharp.UnitTests.KeywordHighlighting
{
    public class LockStatementHighlighterTests : AbstractCSharpKeywordHighlighterTests
    {
        internal override IHighlighter CreateHighlighter()
        {
            return new LockStatementHighlighter();
        }

        [Fact, Trait(Traits.Feature, Traits.Features.KeywordHighlighting)]
        public void TestExample1_1()
        {
            Test(
        @"class Account {
    object lockObj = new object();
    int balance;

    int Withdraw(int amount) {
        {|Cursor:[|lock|]|} (lockObj) {
            if (balance >= amount) {
                balance = balance – amount;
                return amount;
            }
            else {
                return -1;
            }
        }
    }
}");
        }
    }
}
