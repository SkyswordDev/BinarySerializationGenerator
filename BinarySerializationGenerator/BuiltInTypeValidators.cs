using Microsoft.CodeAnalysis;
using System;

namespace BinarySerializationGenerator
{
    internal static class BuiltInTypeValidators
    {
        public sealed class BoolValidator : BuiltInTypeValidator
        {
            public BoolValidator() : base(typeof(bool))
            {

            }

            public override bool ValidateBool(bool value, GeneratorExecutionContext context, Location location) { return true; }
        }
        public sealed class CharValidator : BuiltInTypeValidator
        {
            public CharValidator() : base(typeof(char))
            {

            }

            public override bool ValidateChar(char value, GeneratorExecutionContext context, Location location) { return true; }
        }
        public sealed class StringValidator : BuiltInTypeValidator
        {
            public StringValidator() : base(typeof(string))
            {

            }

            //TODO: report diagnostic warning if null is passed
            public override bool ValidateString(string value, GeneratorExecutionContext context, Location location) { return true; }
        }
        public sealed class FloatValidator : BuiltInTypeValidator
        {
            public FloatValidator() : base(typeof(float))
            {

            }

            public override bool ValidateFloat(float value, GeneratorExecutionContext context, Location location) { return true; }
        }
        public sealed class DoubleValidator : BuiltInTypeValidator
        {
            public DoubleValidator() : base(typeof(double))
            {

            }

            public override bool ValidateFloat(float value, GeneratorExecutionContext context, Location location) { return true; }
            public override bool ValidateDouble(double value, GeneratorExecutionContext context, Location location) { return true; }
        }
        public sealed class DecimalValidator : BuiltInTypeValidator
        {
            public DecimalValidator() : base(typeof(decimal))
            {
            
            }

            public override bool ValidateDecimal(decimal value, GeneratorExecutionContext context, Location location) { return true; }
        }
        public sealed class SignedIntegralValidator : BuiltInTypeValidator
        {
            private readonly long minValue;
            private readonly long maxValue;
            public SignedIntegralValidator(Type type, long minValue, long maxValue) : base(type)
            {
                this.minValue = minValue;
                this.maxValue = maxValue;
            }

            public override bool ValidateSignedIntegral(long value, GeneratorExecutionContext context, Location location, string providedType)
            {
                bool result = minValue <= value && value <= maxValue;
                if (!result)
                {
                    context.ReportDiagnostic(Diagnostic.Create(BinarySerializationGenerator.IntegralLiteralExpressionOutOfRangeDescriptor, location, value, minValue, maxValue, this.ExpectedTypeString));
                }
                return result;
            }
            public override bool ValidateUnsignedIntegral(ulong value, GeneratorExecutionContext context, Location location, string providedType)
            {
                bool result = false;
                if (value > long.MaxValue)
                {
                    result = true;
                } else
                {
                    long lValue = (long)value;
                    result = minValue <= lValue && lValue <= maxValue;
                }
                if (!result)
                {
                    context.ReportDiagnostic(Diagnostic.Create(BinarySerializationGenerator.IntegralLiteralExpressionOutOfRangeDescriptor, location, value, minValue, maxValue, this.ExpectedTypeString));
                }
                return result;
            }
        }
        public sealed class UnsignedIntegralValidator : BuiltInTypeValidator
        {
            private readonly ulong minValue;
            private readonly ulong maxValue;

            public UnsignedIntegralValidator(Type type, ulong minValue, ulong maxValue) : base(type)
            {
                this.minValue = minValue;
                this.maxValue = maxValue;
            }

            public override bool ValidateSignedIntegral(long value, GeneratorExecutionContext context, Location location, string providedType)
            {
                bool result = 0 <= value && (ulong)value <= maxValue;
                if (!result)
                {
                    context.ReportDiagnostic(Diagnostic.Create(BinarySerializationGenerator.IntegralLiteralExpressionOutOfRangeDescriptor, location, value, minValue, maxValue, this.ExpectedTypeString));
                }
                return result;
            }
            public override bool ValidateUnsignedIntegral(ulong value, GeneratorExecutionContext context, Location location, string providedType)
            {
                bool result = minValue <= value && value <= maxValue;
                if (!result)
                {
                    context.ReportDiagnostic(Diagnostic.Create(BinarySerializationGenerator.IntegralLiteralExpressionOutOfRangeDescriptor, location, value, minValue, maxValue, this.ExpectedTypeString));
                }
                return result;
            }
        }
    }
}
