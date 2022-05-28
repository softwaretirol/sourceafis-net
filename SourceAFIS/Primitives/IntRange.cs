// Part of SourceAFIS for .NET: https://sourceafis.machinezoo.com/net

namespace SourceAFIS.Primitives
{
    readonly struct IntRange
    {
        public static readonly IntRange Zero = new IntRange();
        public readonly int Start;
        public readonly int End;

        public int Length => End - Start;

        public IntRange(int start, int end)
        {
            Start = start;
            End = end;
        }

        public override string ToString() => $"{Start}..{End}";
    }
}
