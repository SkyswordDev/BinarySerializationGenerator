//using BinarySerializationGenerator;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Int32 = System.Int64;

//namespace SerializationGeneratorTest.Subnamespace
//{
//    //TODO: throw an error if one of the parent classes is not partial
//    public partial class OuterClass
//    {
//        [BinarySerializable]
//        public partial class TestClass
//        {
//            private const string a = "test";

//            //[SkipBinarySerialization($"int.Parse({a}\"12\")")]
//            [SkipBinarySerialization("int.Parse(\"12\")", true)]
//            //[SkipBinarySerialization(10)]
//            private int intField = 1;

//            [SkipBinarySerialization("int.Parse(\"12\")", true)]
//            private Int32 intField2 = 1;

//            //[SkipBinarySerialization((int)10L)]
//            private System.Int32 intField3 = 1;

//            [SkipBinarySerialization(10)]
//            private int intField4 = 1;

//            [SkipBinarySerialization("$\"{a} string\"", true)]
//            private string stringField = $"{a} string";

//            private string stringProperty { get => stringField; }



//        }
//    }

//}
