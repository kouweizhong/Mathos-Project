﻿using System.Collections.Generic;
using Mathos.Statistics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathosTest.Statistics_and_DiceSim
{
    [TestClass]
    public class LinearModelsTest
    {
        [TestMethod]
        public void PredictionTest()
        {
            var x = new List<decimal> {1, 2, 3, 4, 5, 6, 7};
            var y = new List<decimal> {2, 4, 6, 8, 10, 12, 14};
            var res = LinearModels.LinearRegression(x, y);
            var b = res.Predict(10);

            Assert.AreEqual(b, 20);
        }
    }
}
