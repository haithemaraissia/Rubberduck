//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\Splinter\Documents\Visual Studio 2015\Projects\TestProj\TestProj\VBALike.g4 by ANTLR 4.3

// Unreachable code detected

using Antlr4.Runtime;
using Antlr4.Runtime.Atn;

#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591

namespace Rubberduck.Parsing.PreProcessing {
    [System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.3")]
[System.CLSCompliant(false)]
public partial class VBALikeLexer : Lexer {
	public const int
		QUESTIONMARK=1, HASH=2, STAR=3, L_SQUARE_BRACKET=4, R_SQUARE_BRACKET=5, 
		DASH=6, EXCLAMATION=7, ANYCHAR=8;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] tokenNames = {
		"'\\u0000'", "'\\u0001'", "'\\u0002'", "'\\u0003'", "'\\u0004'", "'\\u0005'", 
		"'\\u0006'", "'\\u0007'", "'\b'"
	};
	public static readonly string[] ruleNames = {
		"QUESTIONMARK", "HASH", "STAR", "L_SQUARE_BRACKET", "R_SQUARE_BRACKET", 
		"DASH", "EXCLAMATION", "ANYCHAR"
	};


	public VBALikeLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	public override string GrammarFileName { get { return "VBALike.g4"; } }

	public override string[] TokenNames { get { return tokenNames; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2\n#\b\x1\x4\x2\t"+
		"\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4\t"+
		"\t\t\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\a"+
		"\x3\a\x3\b\x3\b\x3\t\x3\t\x2\x2\x2\n\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6"+
		"\v\x2\a\r\x2\b\xF\x2\t\x11\x2\n\x3\x2\x2\"\x2\x3\x3\x2\x2\x2\x2\x5\x3"+
		"\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2"+
		"\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x3\x13\x3\x2\x2\x2\x5\x15"+
		"\x3\x2\x2\x2\a\x17\x3\x2\x2\x2\t\x19\x3\x2\x2\x2\v\x1B\x3\x2\x2\x2\r\x1D"+
		"\x3\x2\x2\x2\xF\x1F\x3\x2\x2\x2\x11!\x3\x2\x2\x2\x13\x14\a\x41\x2\x2\x14"+
		"\x4\x3\x2\x2\x2\x15\x16\a%\x2\x2\x16\x6\x3\x2\x2\x2\x17\x18\a,\x2\x2\x18"+
		"\b\x3\x2\x2\x2\x19\x1A\a]\x2\x2\x1A\n\x3\x2\x2\x2\x1B\x1C\a_\x2\x2\x1C"+
		"\f\x3\x2\x2\x2\x1D\x1E\a/\x2\x2\x1E\xE\x3\x2\x2\x2\x1F \a#\x2\x2 \x10"+
		"\x3\x2\x2\x2!\"\v\x2\x2\x2\"\x12\x3\x2\x2\x2\x3\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Rubberduck.Parsing.Like
