using NUnit.Framework;
using AppBody;

namespace Console_Math_Aplication_Tests
{
    internal class ProgramClassTests
    {
        Calculations calculations = new Calculations();

        [Test]
        public void RectangularTriangleFiled_Test()
        {
            double field = calculations.RectangularTriangleFiled(2, 4);
            double CorrectField = 4;
            Assert.AreEqual(CorrectField, field);   
        }
        [Test]
        public void RectangleField_Test()
        {
            double field = calculations.RectangleField(2, 4);
            double CorrectField = 8;
            Assert.AreEqual(CorrectField, field);
        }
        [Test]
        public void SquareField_Test() 
        {
            double field = calculations.SquareField(10);
            double CorrectField = 100;
            Assert.AreEqual(CorrectField, field);
            

        }
        [Test]
        public void OneZeroPlace_Test() 
        {
            double ZeroPlaceValue = calculations.OneZeroPlace(5, 10);
            double CorrectZeroPlaceValue = -1;
            Assert.AreEqual(CorrectZeroPlaceValue, ZeroPlaceValue);   
        }
        [Test]
        public void ZeroPlacesCounterx2_Test()
        {
            double ZeroPlacex2 = calculations.ZeroPlacesCounterx2(5,-5, 25);
            double CorrectZeroPlacex2 = 1;
            Assert.AreEqual(CorrectZeroPlacex2, ZeroPlacex2);
        }
        [Test]
        public void ZeroPlacesCounterx1_Test()
        {
            double ZeroPlacex1 = calculations.ZeroPlacesCounterx2(5, -5, 25);
            double CorrectZeroPlacex1 = 1;
            Assert.AreEqual(CorrectZeroPlacex1, ZeroPlacex1);
        }
        [Test]
        public void UnitCoverter_test()
        {
            string[] BaseMilimeters = calculations.UnitConverterLenght(1, 10);
            string[] CorrectValue = { "Centimetres: 1", "Meters: 10000 ", "Milimeters:10" };
            Assert.AreEqual(CorrectValue, BaseMilimeters);

        }



    }
}

