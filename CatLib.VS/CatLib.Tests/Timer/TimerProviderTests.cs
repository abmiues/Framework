﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 * 
 * Document: http://catlib.io/
 */

using System;
using CatLib.Time;
using CatLib.Timer;
#if UNITY_EDITOR || NUNIT
using NUnit.Framework;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using TestInitialize = NUnit.Framework.SetUpAttribute;
using TestCleanup = NUnit.Framework.TearDownAttribute;
#else
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Category = Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute;
#endif

namespace CatLib.Tests.Timer
{
    [TestClass]
    public class TimerProviderTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            var app = new Application().Bootstrap();
            app.Register(typeof(TimeProvider));
            app.Register(typeof(TimerProvider));
            app.Init();


        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
