using System;

namespace BinarySerializationGenerator
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class IncludeInBinarySerializationAttribute : Attribute
    {
    }
}
