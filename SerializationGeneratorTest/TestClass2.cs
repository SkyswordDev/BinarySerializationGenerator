//using BinarySerializationGenerator;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace SerializationGeneratorTest
//{
//    [BinarySerializable]
//    internal partial class TestClass2
//    {
//        [SkipBinarySerialization("GetSomeString() +  \"DEF\"")]
//        //[SkipBinarySerialization(-10)]
//        protected string stringField1;
//        [IncludeInBinarySerialization]
//        private Subnamespace.OuterClass.TestClass testClassField1;

//        private string GetSomeString()
//        {
//            return "ABC";
//        }
//        //private TestClass2(SerializedConstructorParams customConstructorParams)
//        //{

//        //}
//        //private struct SerializedConstructorParams()
//        //{

//        //}

//    }

//}
