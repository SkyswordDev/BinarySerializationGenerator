using BinarySerializationGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationGeneratorTest
{
    [BinarySerializable]
    internal partial class TestClass3
    {
        public int int1 = 10;

        [SkipBinarySerialization(10)]
        public int int2;

        public TestClass3()
        {

        }

        public string ToCustomString()
        {
            return $"TestClass3:{int1};{int2}";
        }
    }
}
