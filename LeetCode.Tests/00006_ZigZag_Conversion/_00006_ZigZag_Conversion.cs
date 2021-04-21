using System;
using LeetCode._00006_ZigZag_Conversion;
using NUnit.Framework;
using Shouldly;

namespace LeetCode.Tests._00006_ZigZag_Conversion
{
    public class _00006_ZigZag_Conversion
    {

        private const string paypal = "PAYPALISHIRING";
        private Solution _sut = new Solution();

        [Test]
        public void ShouldConvertNegativeRows()
        {
            _sut.Convert(paypal, -1).ShouldBe(paypal);
        }
        
        [Test]
        public void ShouldConvert0Rows()
        {
            _sut.Convert(paypal, 0).ShouldBe(paypal);
        }
        
        [Test]
        public void ShouldConvert1Row()
        {
            _sut.Convert(paypal, 1).ShouldBe(paypal);
        }
        
        [Test]
        public void ShouldConvert2Rows()
        {
            _sut.Convert(paypal, 2).ShouldBe("PYAIHRNAPLSIIG");
        }
        
        [Test]
        public void ShouldConvert3Rows()
        {
            _sut.Convert(paypal, 3).ShouldBe("PAHNAPLSIIGYIR");
        }

        [Test]
        public void ShouldConvert4Rows()
        {
            _sut.Convert(paypal, 4).ShouldBe("PINALSIGYAHRPI");
        }

        [Test]
        public void ShouldConvertLengthRows()
        {
            _sut.Convert(paypal, paypal.Length).ShouldBe(paypal);
        }

        [Test]
        public void ShouldConvertLengthPlusNRows()
        {
            _sut.Convert(paypal, paypal.Length + 2).ShouldBe(paypal);
        }

        [Test]
        public void ShouldConvertLengthMinus1Rows()
        {
            _sut.Convert(paypal, paypal.Length -1).ShouldBe("PAYPALISHIRIGN");
        }
        
        [Test]
        public void OutputThings()
        {
            var rows = 4;//paypal.Length-1;
            var cols = (int)Math.Ceiling(paypal.Length / (double) rows);
            var row1IndexWithValues = (rows - 1) % rows;
            
            Console.WriteLine($"Length: {paypal.Length}");
            Console.WriteLine($"Rows: {rows} Cols: {cols}");

            
            char[,] output = new char[cols, rows];
            
            for (var c = 0; c < cols; c++)
            {
                for (var r = 0; r < rows; r++)
                {
                    output[c, r] = ' ';
                }
            }
            
            

        }
    }
}