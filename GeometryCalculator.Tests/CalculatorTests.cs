using GeometryCalculator.Figure;

namespace GeometryCalculator.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleAreaTest()
        {
            Circle circle = new Circle(5);
            double area = circle.CalculateArea();
            Assert.AreEqual(Math.PI * 25, area, 1e-10, "������� ����� ���������� �������.");
        }

        [Test]
        public void TriangleAreaTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double area = triangle.CalculateArea();
            Assert.AreEqual(6, area, 1e-10, "������� ������������ ���������� �������.");
        }

        [Test]
        public void IsRightTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool isRight = triangle.IsRightTriangle();
            Assert.IsTrue(isRight, "����������� � ��������� 3, 4, 5 ������ ���� �������������.");
        }

        [Test]
        public void IsNotRightTriangleTest()
        {
            Triangle triangle = new Triangle(3, 4, 6);
            bool isRight = triangle.IsRightTriangle();
            Assert.IsFalse(isRight, "����������� �� ��������� 3, 4, 6 �� ������ ���� �������������.");
        }
    }
}