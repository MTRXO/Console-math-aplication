using AppBody;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Math_Aplication_Tests
{
    internal class ProgramClassTests
    {
        [Test]

        public void RectangularTriangleFiled_Test()
        {
            Calculations calculations = new Calculations();
            double field = calculations.RectangularTriangleFiled(2, 4);
            double RightField = 4;
            Assert.AreEqual(RightField, field);
            
        }

    }
}
