using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Assert;

namespace paskaita2.Tests
{
    public class ProgramTests
    {
        [Test()]
        public void TreciosUzduotiesPIrmaDalisTest()
        {
            // Arange

            int skaicius = 2;

            // Act

            string answer = Program.TreciosUzduotiesPIrmaDalis(skaicius);

            // Assert
            Assert.AreEqual("Geros dienos!", answer);
        }
    }
}