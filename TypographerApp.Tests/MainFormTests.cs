using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TypographerApp.Tests
{
    [TestClass]
    public class MainFormTests
    {
        [TestMethod]
        public void RemoveExtraSpaces_OneSpaceReturned()
        {
            //arrange
            string text = "    ";
            string expected = " ";

            //act
            MainForm form = new MainForm();
            string actual = form.RemoveExtraSpaces(text);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReplaceQuotationMarks_QuotationMarksReturned()
        {
            //arrange
            string text = "\"Война и мир\"";
            string expected = "«Война и мир»";

            //act
            MainForm form = new MainForm();
            string actual = form.ReplaceQuotationMarks(text);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReplaceQuotationMarks_ReplaceWithoutQuotesReturned()
        {
            // arrange
            string text = "«»";
            string expected = "«»";

            // act
            MainForm form = new MainForm();
            string actual = form.ReplaceQuotationMarks(text);

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReplaceHyphen_HyphenReturned()
        {
            //arrange
            string text = "Книга - источник знания";
            string expected = "Книга — источник знания";

            //act
            MainForm form = new MainForm();
            string actual = form.ReplaceHyphen(text);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Replacingpoints_PointsReturned()
        {
            //arrange
            string text = "В.В.Путин и т.д.";
            string expected = "В. В. Путин и т. д. ";

            //act
            MainForm form = new MainForm();
            string actual = form.Replacingpoints(text);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReplacePlusMinus_PlusMinusReturned()
        {
            //arrange
            string text = "+-";
            string expected = "±";

            //act
            MainForm form = new MainForm();
            string actual = form.ReplacePlusMinus(text);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReplacePlusMinus_WithoutPlusMinusReturned()
        {
            //arrange
            string text = "-+";
            string expected = "-+";

            //act
            MainForm form = new MainForm();
            string actual = form.ReplacePlusMinus(text);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReplacingExpression_ExpressionReturned()
        {
            //arrange
            string text = "хахаха";
            string expected = "=)";

            //act
            MainForm form = new MainForm();
            string actual = form.ReplacingExpression(text);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReplaceWord_WordReturned()
        {
            //arrange
            string text = "стыд";
            string expected = "кринж";

            //act
            MainForm form = new MainForm();
            string actual = form.ReplaceWord(text);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void LimitPunctuationMarks_PunctuationMarksReturned()
        {
            //arrange
            string text = "!!!!!Что??????.....";
            string expected = "!!!Что???...";

            //act
            MainForm form = new MainForm();
            string actual = form.LimitPunctuationMarks(text);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
