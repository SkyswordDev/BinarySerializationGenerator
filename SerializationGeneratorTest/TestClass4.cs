using BinarySerializationGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationGeneratorTest
{
    [BinarySerializable]
    internal partial class TestClass4
    {
        public int intField;

        public int intField2;

        public string numericString;

        [IncludeInBinarySerialization]
        public TestClass3 t3;

        public TestClass4(int intField, int intField2, string numericString, TestClass3 t3)
        {
            this.intField = intField;
            this.intField2 = intField2;
            this.numericString = numericString;
            this.t3 = t3;
        }

        public string ToCustomString()
        {
            return $"{intField};{intField2};{numericString};{t3.ToCustomString()}";
        }
    }
}
