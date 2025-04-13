using NUnit.Framework;

namespace Calculator.UnitTest
{
    public class Tests
    {
        private PhepToan calc;

        [SetUp]
        public void Setup()
        {
            calc = new PhepToan();
        }

        // GiaiPhuongTrinhBacHai
        [Test]
        public void GiaiPhuongTrinhBacHai_ValidCoefficients_TwoSolutions()
        {
            // Given
            double a = 1, b = -3, c = 2; // x^2 - 3x + 2 = 0
            double x1 = 0, x2 = 0;
            string expected = "Phương trình có 2 nghiệm";
            double expectedX1 = 2, expectedX2 = 1;

            // When
            string result = calc.GiaiPhuongTrinhBacHai(a, b, c, ref x1, ref x2);

            // Then
            Assert.AreEqual(expected, result, "Expected two solutions.");
            Assert.AreEqual(expectedX1, x1, 0.0001, "x1 incorrect.");
            Assert.AreEqual(expectedX2, x2, 0.0001, "x2 incorrect.");
        }

        [Test]
        public void GiaiPhuongTrinhBacHai_ZeroDiscriminant_OneSolution()
        {
            // Given
            double a = 1, b = -2, c = 1; // x^2 - 2x + 1 = 0
            double x1 = 0, x2 = 0;
            string expected = "Phương trình có 1 nghiệm";
            double expectedX1 = 1;

            // When
            string result = calc.GiaiPhuongTrinhBacHai(a, b, c, ref x1, ref x2);

            // Then
            Assert.AreEqual(expected, result, "Expected one solution.");
            Assert.AreEqual(expectedX1, x1, 0.0001, "x1 incorrect.");
        }

        [Test]
        public void GiaiPhuongTrinhBacHai_NegativeDiscriminant_NoSolution()
        {
            // Given
            double a = 1, b = 0, c = 1; // x^2 + 1 = 0
            double x1 = 0, x2 = 0;
            string expected = "Phương trình vô nghiệm";

            // When
            string result = calc.GiaiPhuongTrinhBacHai(a, b, c, ref x1, ref x2);

            // Then
            Assert.AreEqual(expected, result, "Expected no solution.");
        }

        [Test]
        public void GiaiPhuongTrinhBacHai_AZeroBNonZero_OneSolution()
        {
            // Given
            double a = 0, b = 2, c = -4; // 2x - 4 = 0
            double x1 = 0, x2 = 0;
            string expected = "Phương trình có 1 nghiệm";
            double expectedX1 = 2;

            // When
            string result = calc.GiaiPhuongTrinhBacHai(a, b, c, ref x1, ref x2);

            // Then
            Assert.AreEqual(expected, result, "Expected one solution.");
            Assert.AreEqual(expectedX1, x1, 0.0001, "x1 incorrect.");
        }

        [Test]
        public void GiaiPhuongTrinhBacHai_AZeroBZeroCZero_InfiniteSolutions()
        {
            // Given
            double a = 0, b = 0, c = 0; // 0 = 0
            double x1 = 0, x2 = 0;
            string expected = "Phương trình vô số nghiệm";

            // When
            string result = calc.GiaiPhuongTrinhBacHai(a, b, c, ref x1, ref x2);

            // Then
            Assert.AreEqual(expected, result, "Expected infinite solutions.");
        }

        // GiaiHPTBacNhat2An
        [Test]
        public void GiaiHPTBacNhat2An_ValidCoefficients_OneSolution()
        {
            // Given
            double a1 = 1, b1 = 2, c1 = 5; // x + 2y = 5
            double a2 = 3, b2 = 4, c2 = 11; // 3x + 4y = 11
            double x = 0, y = 0;
            string expected = "Hệ phương trình có 1 nghiệm";
            double expectedX = 1, expectedY = 2;

            // When
            string result = calc.GiaiHPTBacNhat2An(a1, b1, c1, a2, b2, c2, ref x, ref y);

            // Then
            Assert.AreEqual(expected, result, "Expected one solution.");
            Assert.AreEqual(expectedX, x, 0.0001, "x incorrect.");
            Assert.AreEqual(expectedY, y, 0.0001, "y incorrect.");
        }

        [Test]
        public void GiaiHPTBacNhat2An_ZeroDeterminant_InfiniteSolutions()
        {
            // Given
            double a1 = 1, b1 = 2, c1 = 3; // x + 2y = 3
            double a2 = 2, b2 = 4, c2 = 6; // 2x + 4y = 6
            double x = 0, y = 0;
            string expected = "Hệ phương trình vô số nghiệm";

            // When
            string result = calc.GiaiHPTBacNhat2An(a1, b1, c1, a2, b2, c2, ref x, ref y);

            // Then
            Assert.AreEqual(expected, result, "Expected infinite solutions.");
        }

        [Test]
        public void GiaiHPTBacNhat2An_ZeroDeterminant_NoSolution()
        {
            // Given
            double a1 = 1, b1 = 2, c1 = 3; // x + 2y = 3
            double a2 = 1, b2 = 2, c2 = 4; // x + 2y = 4
            double x = 0, y = 0;
            string expected = "Hệ phương trình vô nghiệm";

            // When
            string result = calc.GiaiHPTBacNhat2An(a1, b1, c1, a2, b2, c2, ref x, ref y);

            // Then
            Assert.AreEqual(expected, result, "Expected no solution.");
        }

        // GiaiHPTBacNhat3An
        [Test]
        public void GiaiHPTBacNhat3An_ValidCoefficients_OneSolution()
        {
            // Given
            double a1 = 1, b1 = 1, c1 = 1, d1 = 6; // x + y + z = 6
            double a2 = 1, b2 = 2, c2 = 3, d2 = 14; // x + 2y + 3z = 14
            double a3 = 2, b3 = 5, c3 = 5, d3 = 27; // 2x + 5y + 5z = 27
            double x = 0, y = 0, z = 0;
            string expected = "Hệ phương trình có 1 nghiệm";
            double expectedX = 1, expectedY = 2, expectedZ = 3;

            // When
            string result = calc.GiaiHPTBacNhat3An(a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, ref x, ref y, ref z);

            // Then
            Assert.AreEqual(expected, result, "Expected one solution.");
            Assert.AreEqual(expectedX, x, 0.0001, "x incorrect.");
            Assert.AreEqual(expectedY, y, 0.0001, "y incorrect.");
            Assert.AreEqual(expectedZ, z, 0.0001, "z incorrect.");
        }

        [Test]
        public void GiaiHPTBacNhat3An_ZeroDeterminant_InfiniteSolutions()
        {
            // Given
            double a1 = 1, b1 = 1, c1 = 1, d1 = 3; // x + y + z = 3
            double a2 = 1, b2 = 1, c2 = 1, d2 = 3; // x + y + z = 3
            double a3 = 1, b3 = 1, c3 = 1, d3 = 3; // x + y + z = 3
            double x = 0, y = 0, z = 0;
            string expected = "Hệ phương trình vô số nghiệm";

            // When
            string result = calc.GiaiHPTBacNhat3An(a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, ref x, ref y, ref z);

            // Then
            Assert.AreEqual(expected, result, "Expected infinite solutions.");
        }

        [Test]
        public void GiaiHPTBacNhat3An_ZeroDeterminant_NoSolution()
        {
            // Given
            double a1 = 1, b1 = 1, c1 = 1, d1 = 3; // x + y + z = 3
            double a2 = 1, b2 = 1, c2 = 1, d2 = 4; // x + y + z = 4
            double a3 = 1, b3 = 1, c3 = 1, d3 = 5; // x + y + z = 5
            double x = 0, y = 0, z = 0;
            string expected = "Hệ phương trình vô nghiệm";

            // When
            string result = calc.GiaiHPTBacNhat3An(a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, ref x, ref y, ref z);

            // Then
            Assert.AreEqual(expected, result, "Expected no solution.");
        }
    }
}