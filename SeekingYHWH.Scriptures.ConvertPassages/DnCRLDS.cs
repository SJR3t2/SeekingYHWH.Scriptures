using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures;

public static class DnCRLDS
{
	public static string[] Headers = new string[4] { "LDS", "1833", "1835", "1844" };

	public static Chapters?[]?[] Chapters = new Chapters?[]?[112 + 1]
	{
		null,
		new Chapters?[4] { new SingleChapters(1), new SingleChapters(1), new SingleChapters(1), new SingleChapters(1) },//1
		new Chapters?[4] { new SingleChapters(3), new SingleChapters(2), new SingleChapters(30), new SingleChapters(30) },//2
		new Chapters?[4] { new SingleChapters(10), new SingleChapters(9), new SingleChapters(36), new SingleChapters(36) },//3
		new Chapters?[4] { new SingleChapters(4), new SingleChapters(3), new SingleChapters(31), new SingleChapters(31) },//4
		new Chapters?[4] { new SingleChapters(5), new SingleChapters(4), new SingleChapters(32), new SingleChapters(32) },//5
		new Chapters?[4] { new SingleChapters(6), new SingleChapters(5), new SingleChapters(8), new SingleChapters(8) },//6
		new Chapters?[4] { new SingleChapters(7), new SingleChapters(6), new SingleChapters(33), new SingleChapters(33) },//7
		new Chapters?[4] { new SingleChapters(8), new SingleChapters(7), new SingleChapters(34), new SingleChapters(34) },//8
		new Chapters?[4] { new SingleChapters(9), new SingleChapters(8), new SingleChapters(35), new SingleChapters(35) },//9
		new Chapters?[4] { new SingleChapters(11), new SingleChapters(10), new SingleChapters(37), new SingleChapters(37) },//10
		new Chapters?[4] { new SingleChapters(12), new SingleChapters(11), new SingleChapters(38), new SingleChapters(38) },//11
		new Chapters?[4] { new SingleChapters(14), new SingleChapters(12), new SingleChapters(39), new SingleChapters(39) },//12
		new Chapters?[4] { new SingleChapters(15), new SingleChapters(13), new SingleChapters(40), new SingleChapters(40) },//13
		new Chapters?[4] { new SingleChapters(16), new SingleChapters(14), new SingleChapters(41), new SingleChapters(41) },//14
		new Chapters?[4] { new SingleChapters(17), null, new SingleChapters(42), new SingleChapters(42) },//15
		new Chapters?[4] { new SingleChapters(18), new SingleChapters(15), new SingleChapters(43), new SingleChapters(43) },//16
		new Chapters?[4] { new SingleChapters(20), new SingleChapters(24), new SingleChapters(2), new SingleChapters(2) },//17
		new Chapters?[4] { new SingleChapters(19), new SingleChapters(16), new SingleChapters(44), new SingleChapters(44) },//18
		new Chapters?[4] { new SingleChapters(21), new SingleChapters(22), new SingleChapters(46), new SingleChapters(46) },//19
		new Chapters?[4] { new SingleChapters(22), new SingleChapters(23), new SingleChapters(47), new SingleChapters(47) },//20
		new Chapters?[4] {new SingleChapters(23), new RangeChapters(17, 21), new SingleChapters(45), new SingleChapters(45) },//21
		null,//22
		new Chapters?[4] { new SingleChapters(24), new SingleChapters(25), new SingleChapters(9), new SingleChapters(9) },//23
		new Chapters?[4] { new SingleChapters(25), new SingleChapters(26), new SingleChapters(48), new SingleChapters(48) },//24
		new Chapters?[4] { new SingleChapters(26), new SingleChapters(27), new SingleChapters(49), new SingleChapters(49) },//25
		new Chapters?[4] { new SingleChapters(27), new SingleChapters(28), new SingleChapters(50), new SingleChapters(50) },//26
		new Chapters?[4] { new SingleChapters(28), new SingleChapters(30), new SingleChapters(51), new SingleChapters(51) },//27
		new Chapters?[4] { new SingleChapters(29), new SingleChapters(29), new SingleChapters(10), new SingleChapters(10) },//28
		new Chapters?[4] {new SingleChapters(30), new RangeChapters(31, 33), new SingleChapters(52), new SingleChapters(52) },//29
		new Chapters?[4] { new SingleChapters(31), new SingleChapters(34), new SingleChapters(53), new SingleChapters(53) },//30
		new Chapters?[4] { new SingleChapters(32), null, new SingleChapters(54), new SingleChapters(54) },//31
		new Chapters?[4] { new SingleChapters(33), new SingleChapters(35), new SingleChapters(55), new SingleChapters(55) },//32
		new Chapters?[4] { new SingleChapters(34), new SingleChapters(36), new SingleChapters(56), new SingleChapters(56) },//33
		new Chapters?[4] { new SingleChapters(35), new SingleChapters(37), new SingleChapters(11), new SingleChapters(11) },//34
		new Chapters?[4] { new SingleChapters(36), new SingleChapters(38), new SingleChapters(57), new SingleChapters(57) },//35
		null,//36
		new Chapters?[4] { new SingleChapters(37), new SingleChapters(39), new SingleChapters(58), new SingleChapters(58) },//37
		new Chapters?[4] { new SingleChapters(38), new SingleChapters(40), new SingleChapters(12), new SingleChapters(12) },//38
		new Chapters?[4] { new SingleChapters(39), new SingleChapters(41), new SingleChapters(59), new SingleChapters(59) },//39
		new Chapters?[4] { new SingleChapters(40), new SingleChapters(42), new SingleChapters(60), new SingleChapters(60) },//40
		new Chapters?[4] { new SingleChapters(41), new SingleChapters(43), new SingleChapters(61), new SingleChapters(61) },//41
		new Chapters?[4] {new SingleChapters(42), new TwoChapters(44, 47), new SingleChapters(13), new SingleChapters(13) },//42
		new Chapters?[4] { new SingleChapters(43), new SingleChapters(45), new SingleChapters(14), new SingleChapters(14) },//43
		new Chapters?[4] { new SingleChapters(44), new SingleChapters(46), new SingleChapters(62), new SingleChapters(62) },//44
		new Chapters?[4] { new SingleChapters(45), new SingleChapters(48), new SingleChapters(15), new SingleChapters(15) },//45
		new Chapters?[4] { new SingleChapters(46), new SingleChapters(49), new SingleChapters(16), new SingleChapters(16) },//46
		new Chapters?[4] { new SingleChapters(47), new SingleChapters(50), new SingleChapters(63), new SingleChapters(63) },//47
		new Chapters?[4] { new SingleChapters(48), new SingleChapters(51), new SingleChapters(64), new SingleChapters(64) },//48
		new Chapters?[4] { new SingleChapters(49), new SingleChapters(52), new SingleChapters(65), new SingleChapters(65) },//49
		new Chapters?[4] { new SingleChapters(50), new SingleChapters(53), new SingleChapters(17), new SingleChapters(17) },//50
		new Chapters?[4] { new SingleChapters(51), null, new SingleChapters(23), new SingleChapters(23) },//51
		new Chapters?[4] { new SingleChapters(52), new SingleChapters(54), new SingleChapters(66), new SingleChapters(66) },//52
		new Chapters?[4] { new SingleChapters(53), new SingleChapters(55), new SingleChapters(66), new SingleChapters(67) },//53
		new Chapters?[4] { new SingleChapters(54), new SingleChapters(56), new SingleChapters(67), new SingleChapters(68) },//54
		new Chapters?[4] { new SingleChapters(55), new SingleChapters(57), new SingleChapters(68), new SingleChapters(69) },//55
		new Chapters?[4] { new SingleChapters(56), new SingleChapters(58), new SingleChapters(69), new SingleChapters(70) },//56
		new Chapters?[4] { new SingleChapters(57), null, new SingleChapters(27), new SingleChapters(27) },//57
		new Chapters?[4] { new SingleChapters(58), new SingleChapters(59), new SingleChapters(18), new SingleChapters(18) },//58
		new Chapters?[4] { new SingleChapters(59), new SingleChapters(60), new SingleChapters(19), new SingleChapters(19) },//59
		new Chapters?[4] { new SingleChapters(60), new SingleChapters(61), new SingleChapters(70), new SingleChapters(71) },//60
		new Chapters?[4] { new SingleChapters(61), new SingleChapters(62), new SingleChapters(71), new SingleChapters(72) },//61
		new Chapters?[4] { new SingleChapters(62), new SingleChapters(63), new SingleChapters(72), new SingleChapters(73) },//62
		new Chapters?[4] { new SingleChapters(63), new SingleChapters(64), new SingleChapters(20), new SingleChapters(20) },//63
		new Chapters?[4] { new SingleChapters(64), new SingleChapters(65), new SingleChapters(21), new SingleChapters(21) },//64
		new Chapters?[4] { new SingleChapters(65), null, new SingleChapters(24), new SingleChapters(24) },//65
		new Chapters?[4] { new SingleChapters(66), null, new SingleChapters(74), new SingleChapters(75) },//66
		new Chapters?[4] { new SingleChapters(67), null, new SingleChapters(25), new SingleChapters(25) },//67
		new Chapters?[4] { new SingleChapters(68), null, new SingleChapters(22), new SingleChapters(22) },//68
		new Chapters?[4] { new SingleChapters(69), null, new SingleChapters(28), new SingleChapters(28) },//69
		new Chapters?[4] { new SingleChapters(70), null, new SingleChapters(26), new SingleChapters(26) },//70
		new Chapters?[4] { new SingleChapters(71), null, new SingleChapters(90), new SingleChapters(91) },//71
		new Chapters?[4] { new SingleChapters(72), null, new SingleChapters(89), new SingleChapters(90) },//72
		new Chapters?[4] { new SingleChapters(73), null, new SingleChapters(29), new SingleChapters(29) },//73
		new Chapters?[4] { new SingleChapters(74), null, new SingleChapters(73), new SingleChapters(74) },//74
		new Chapters?[4] { new SingleChapters(75), null, new SingleChapters(87), new SingleChapters(88) },//75
		new Chapters?[4] { new SingleChapters(76), null, new SingleChapters(91), new SingleChapters(92) },//76
		new Chapters?[4] { new SingleChapters(78), null, new SingleChapters(75), new SingleChapters(76) },//77
		new Chapters?[4] { new SingleChapters(79), null, new SingleChapters(76), new SingleChapters(77) },//78
		new Chapters?[4] { new SingleChapters(80), null, new SingleChapters(77), new SingleChapters(78) },//79
		new Chapters?[4] { new SingleChapters(81), null, new SingleChapters(79), new SingleChapters(80) },//80
		new Chapters?[4] { new SingleChapters(82), null, new SingleChapters(86), new SingleChapters(87) },//81
		new Chapters?[4] { new SingleChapters(83), null, new SingleChapters(88), new SingleChapters(89) },//82
		new Chapters?[4] { new SingleChapters(84), null, new SingleChapters(4), new SingleChapters(4) },//83
		new Chapters?[4] { new SingleChapters(86), null, new SingleChapters(6), new SingleChapters(6) },//84
		new Chapters?[4] { new SingleChapters(88), null, new SingleChapters(7), new SingleChapters(7) },//85
		new Chapters?[4] { new SingleChapters(89), null, new SingleChapters(80), new SingleChapters(81) },//86
		new Chapters?[4] { new SingleChapters(90), null, new SingleChapters(84), new SingleChapters(85) },//87
		new Chapters?[4] { new SingleChapters(91), null, new SingleChapters(92), new SingleChapters(93) },//88
		new Chapters?[4] { new SingleChapters(92), null, new SingleChapters(93), new SingleChapters(94) },//89
		new Chapters?[4] { new SingleChapters(93), null, new SingleChapters(82), new SingleChapters(83) },//90
		new Chapters?[4] { new SingleChapters(94), null, new SingleChapters(83), new SingleChapters(84) },//91
		new Chapters?[4] { new SingleChapters(95), null, new SingleChapters(95), new SingleChapters(96) },//92
		new Chapters?[4] { new SingleChapters(96), null, new SingleChapters(96), new SingleChapters(97) },//93
		new Chapters?[4] { new SingleChapters(97), null, new SingleChapters(81), new SingleChapters(82) },//94
		new Chapters?[4] { new SingleChapters(98), null, new SingleChapters(85), new SingleChapters(86) },//95
		new Chapters?[4] { new SingleChapters(99), null, new SingleChapters(78), new SingleChapters(79) },//96
		new Chapters?[4] { new SingleChapters(100), null, new SingleChapters(94), new SingleChapters(95) },//97
		new Chapters?[4] { new SingleChapters(101), null, new SingleChapters(97), new SingleChapters(98) },//98
		null,//99
		new Chapters?[4] { new SingleChapters(119), null, null, new SingleChapters(101) },//100
		new Chapters?[4] { new SingleChapters(104), null, new SingleChapters(98), new SingleChapters(99) },//101
		new Chapters?[4] { new SingleChapters(119), null, null, new SingleChapters(102) },//102
		new Chapters?[4] { new SingleChapters(106), null, new SingleChapters(99), new SingleChapters(100) },//103
		new Chapters?[4] { new SingleChapters(107), null, new SingleChapters(3), new SingleChapters(3) },//104
		new Chapters?[4] { new SingleChapters(112), null, null, new SingleChapters(104) },//105
		new Chapters?[4] { new SingleChapters(119), null, null, new SingleChapters(107) },//106
		null,//107
		new Chapters?[4] { new SingleChapters(133), null, new SingleChapters(100), new SingleChapters(108) },//108
		null,//109
		null,//110
		null,//111
		new Chapters?[4] { new SingleChapters(134), null, new SingleChapters(102), new SingleChapters(110) },//112
	};

	public static AddChaptersConverter CreateAdd()
	{
		var converter = new AddChaptersConverter("(RLDS ", ")", "(", Headers, Chapters, ")");
		return converter;
	}

	public static AddChaptersConverter CreateAdd(string? sourcePre, string? sourcePost, string? othersPre, string? othersPost)
	{
		var converter = new AddChaptersConverter(sourcePre, sourcePost, othersPre, Headers, Chapters, othersPost);
		return converter;
	}

	public static void SetAdd(Dictionary<string, BookConverter> books, string[] names)
	{
		var converter = CreateAdd();
		foreach (var name in names)
		{
			books[name] = converter;
		}
	}

	public static void SetAdd(Dictionary<string, BookConverter> books)
	{
		SetAdd(books, DnC.Names);
	}

	public static AddChaptersConverter CreateAdd(bool dncLDS, bool dnc1833, bool dnc1835, bool dnc1844)
	{
		string?[] headers;
		if (dncLDS && dnc1833 && dnc1835 && dnc1844)
		{
			headers = Headers;
		}
		else
		{
			headers = new string?[4];
			if (dncLDS)
			{
				headers[0] = Headers[0];
			}
			if (dnc1833)
			{
				headers[1] = Headers[1];
			}
			if (dnc1835)
			{
				headers[2] = Headers[2];
			}
			if (dnc1844)
			{
				headers[3] = Headers[3];
			}
		}
		var converter = new AddChaptersConverter("(RLDS ", ")", "(", headers, Chapters, ")");
		return converter;
	}

	public static AddChaptersConverter CreateAdd(string? sourcePre, string? sourcePost, string? othersPre, string? othersPost, bool dncLDS, bool dnc1833, bool dnc1835, bool dnc1844)
	{
		string?[] headers;
		if (dncLDS && dnc1833 && dnc1835 && dnc1844)
		{
			headers = Headers;
		}
		else
		{
			headers = new string?[4];
			if (dncLDS)
			{
				headers[0] = Headers[0];
			}
			if (dnc1833)
			{
				headers[1] = Headers[1];
			}
			if (dnc1835)
			{
				headers[2] = Headers[2];
			}
			if (dnc1844)
			{
				headers[3] = Headers[3];
			}
		}
		var converter = new AddChaptersConverter(sourcePre, sourcePost, othersPre, headers, Chapters, othersPost);
		return converter;
	}

	public static void SetAdd(Dictionary<string, BookConverter> books, string[] names, bool dncLDS, bool dnc1833, bool dnc1835, bool dnc1844)
	{
		var converter = CreateAdd(dncLDS, dnc1833, dnc1835, dnc1844);
		foreach (var name in names)
		{
			books[name] = converter;
		}
	}

	public static void SetAdd(Dictionary<string, BookConverter> books, bool dncLDS, bool dnc1833, bool dnc1835, bool dnc1844)
	{
		SetAdd(books, DnC.Names, dncLDS, dnc1833, dnc1835, dnc1844);
	}

	public static void SetAddInitialize(PassagesConverter converter, Dictionary<string, BookConverter> books, string[] names, bool dncLDS, bool dnc1833, bool dnc1835, bool dnc1844)
	{
		var value = CreateAdd(dncLDS, dnc1833, dnc1835, dnc1844);
		converter.Initialize(value);
		foreach (var name in names)
		{
			books[name] = value;
		}
	}

	public static void SetAddInitialize(PassagesConverter converter, Dictionary<string, BookConverter> books, bool dncLDS, bool dnc1833, bool dnc1835, bool dnc1844)
	{
		SetAddInitialize(converter, books, DnC.Names, dncLDS, dnc1833, dnc1835, dnc1844);
	}
}
