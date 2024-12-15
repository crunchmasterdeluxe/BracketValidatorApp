using NUnit.Framework;

namespace BracketValidatorApp.Tests
{
    [TestFixture]
    public class BracketMatcherTests
    {
        [Test]
        public void TestMatchingBrackets_SinglePair_ShouldReturnTrue()
        {
            string input = "<>";
            bool result = BracketMatcher.HasMatchingBrackets(input);
            Assert.IsTrue(result, "The brackets <> should be correctly matched.");
        }

        [Test]
        public void TestClosingBeforeOpening_ShouldReturnFalse()
        {
            string input = "><";
            bool result = BracketMatcher.HasMatchingBrackets(input);
            Assert.IsFalse(result, "The brackets >< should be mismatched.");
        }

        [Test]
        public void TestUnclosedBrackets_ShouldReturnFalse()
        {
            string input = "<<>";
            bool result = BracketMatcher.HasMatchingBrackets(input);
            Assert.IsFalse(result, "The brackets <<> should be mismatched.");
        }

        [Test]
        public void TestEmptyString_ShouldReturnTrue()
        {
            string input = "";
            bool result = BracketMatcher.HasMatchingBrackets(input);
            Assert.IsTrue(result, "An empty string should be considered as having no mismatched brackets.");
        }

        [Test]
        public void TestBracketsWithNonBracketCharacters_ShouldReturnTrue()
        {
            string input = "<abc...xyz>";
            bool result = BracketMatcher.HasMatchingBrackets(input);
            Assert.IsTrue(result, "The string <abc...xyz> should be correctly matched, ignoring non-bracket characters.");
        }

        // Additional test cases to ensure comprehensive coverage
        [Test]
        public void TestMultipleCorrectPairs_ShouldReturnTrue()
        {
            string input = "<{[()]}>";
            bool result = BracketMatcher.HasMatchingBrackets(input);
            Assert.IsTrue(result, "The brackets <{[()]} should be correctly matched.");
        }

        [Test]
        public void TestMultipleMismatchedPairs_ShouldReturnFalse()
        {
            string input = "<{[()}>";
            bool result = BracketMatcher.HasMatchingBrackets(input);
            Assert.IsFalse(result, "The brackets <{[()} should be mismatched.");
        }

        [Test]
        public void TestOnlyClosingBrackets_ShouldReturnFalse()
        {
            string input = ">)";
            bool result = BracketMatcher.HasMatchingBrackets(input);
            Assert.IsFalse(result, "The string >) should be mismatched because it starts with a closing bracket.");
        }
    }
}
