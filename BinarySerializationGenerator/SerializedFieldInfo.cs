﻿using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BinarySerializationGenerator
{
    internal class SerializedFieldInfo
    {
        public readonly FieldDeclarationSyntax FieldDeclarationSyntax;
        public readonly string BinaryReaderMethodOrNull;
        public readonly string DeserializationAssignedDefaultExpressionOrNull;

        public SerializedFieldInfo(FieldDeclarationSyntax fieldDeclarationSyntax, string binaryReaderMethodOrNull, string deserializationAssignedDefaultValueOrNull)
        {
            FieldDeclarationSyntax = fieldDeclarationSyntax;
            this.BinaryReaderMethodOrNull = binaryReaderMethodOrNull;
            this.DeserializationAssignedDefaultExpressionOrNull = deserializationAssignedDefaultValueOrNull;
        }
    }
}
