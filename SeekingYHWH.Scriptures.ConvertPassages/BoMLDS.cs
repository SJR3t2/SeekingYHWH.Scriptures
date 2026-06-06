using System;
using System.Collections.Generic;

namespace SeekingYHWH.Scriptures;

public static class BoMLDS
{
	public static readonly Dictionary<string, VerseInfo?[]?[]> Books = new Dictionary<string, VerseInfo?[]?[]>()
	{
		{ "1 Nephi", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//1 Nephi 1
					new VerseInfo(1, 1),//1 Nephi 1:1
					new VerseInfo(1, 1),//1 Nephi 1:2
					new VerseInfo(1, 2),//1 Nephi 1:3
					new VerseInfo(1, 3),//1 Nephi 1:4
					new VerseInfo(1, 4),//1 Nephi 1:5
					new VerseInfo(1, 5),//1 Nephi 1:6
					new VerseInfo(1, 6),//1 Nephi 1:7
					new VerseInfo(1, 7),//1 Nephi 1:8
					new VerseInfo(1, 8),//1 Nephi 1:9
					new VerseInfo(1, 9),//1 Nephi 1:10
					new VerseInfo(1, 9, 1, 10),//1 Nephi 1:11
					new VerseInfo(1, 11),//1 Nephi 1:12
					new VerseInfo(1, 11, 1, 12),//1 Nephi 1:13
					new VerseInfo(1, 13),//1 Nephi 1:14
					new VerseInfo(1, 14),//1 Nephi 1:15
					new VerseInfo(1, 15, 1, 16),//1 Nephi 1:16
					new VerseInfo(1, 16, 1, 17),//1 Nephi 1:17
					new VerseInfo(1, 18),//1 Nephi 1:18
					new VerseInfo(1, 19, 1, 20),//1 Nephi 1:19
					new VerseInfo(1, 21, 1, 23),//1 Nephi 1:20
				},
				new VerseInfo?[]
				{
					null,//1 Nephi 2
					new VerseInfo(1, 24, 1, 25),//1 Nephi 2:1
					new VerseInfo(1, 26),//1 Nephi 2:2
					new VerseInfo(1, 27),//1 Nephi 2:3
					new VerseInfo(1, 28, 1, 29),//1 Nephi 2:4
					new VerseInfo(1, 30, 1, 32),//1 Nephi 2:5
					new VerseInfo(1, 33),//1 Nephi 2:6
					new VerseInfo(1, 34),//1 Nephi 2:7
					new VerseInfo(1, 35),//1 Nephi 2:8
					new VerseInfo(1, 36),//1 Nephi 2:9
					new VerseInfo(1, 37),//1 Nephi 2:10
					new VerseInfo(1, 38, 1, 39),//1 Nephi 2:11
					new VerseInfo(1, 40, 1, 41),//1 Nephi 2:12
					new VerseInfo(1, 42, 1, 43),//1 Nephi 2:13
					new VerseInfo(1, 44, 1, 45),//1 Nephi 2:14
					new VerseInfo(1, 46),//1 Nephi 2:15
					new VerseInfo(1, 47, 1, 48),//1 Nephi 2:16
					new VerseInfo(1, 49, 1, 50),//1 Nephi 2:17
					new VerseInfo(1, 51, 1, 52),//1 Nephi 2:18
					new VerseInfo(1, 53),//1 Nephi 2:19
					new VerseInfo(1, 54),//1 Nephi 2:20
					new VerseInfo(1, 55),//1 Nephi 2:21
					new VerseInfo(1, 56),//1 Nephi 2:22
					new VerseInfo(1, 57),//1 Nephi 2:23
					new VerseInfo(1, 58),//1 Nephi 2:24
				},
				new VerseInfo?[]
				{
					null,//1 Nephi 3
					new VerseInfo(1, 59),//1 Nephi 3:1
					new VerseInfo(1, 60),//1 Nephi 3:2
					new VerseInfo(1, 61),//1 Nephi 3:3
					new VerseInfo(1, 62),//1 Nephi 3:4
					new VerseInfo(1, 63),//1 Nephi 3:5
					new VerseInfo(1, 64),//1 Nephi 3:6
					new VerseInfo(1, 65),//1 Nephi 3:7
					new VerseInfo(1, 66),//1 Nephi 3:8
					new VerseInfo(1, 67),//1 Nephi 3:9
					new VerseInfo(1, 68),//1 Nephi 3:10
					new VerseInfo(1, 68, 1, 69),//1 Nephi 3:11
					new VerseInfo(1, 70),//1 Nephi 3:12
					new VerseInfo(1, 71, 1, 72),//1 Nephi 3:13
					new VerseInfo(1, 73, 1, 74),//1 Nephi 3:14
					new VerseInfo(1, 75),//1 Nephi 3:15
					new VerseInfo(1, 76, 1, 78),//1 Nephi 3:16
					new VerseInfo(1, 78),//1 Nephi 3:17
					new VerseInfo(1, 79, 1, 81),//1 Nephi 3:18
					new VerseInfo(1, 82),//1 Nephi 3:19
					new VerseInfo(1, 83),//1 Nephi 3:20
					new VerseInfo(1, 84),//1 Nephi 3:21
					new VerseInfo(1, 85),//1 Nephi 3:22
					new VerseInfo(1, 86),//1 Nephi 3:23
					new VerseInfo(1, 87),//1 Nephi 3:24
					new VerseInfo(1, 88),//1 Nephi 3:25
					new VerseInfo(1, 89),//1 Nephi 3:26
					new VerseInfo(1, 90),//1 Nephi 3:27
					new VerseInfo(1, 91, 1, 92),//1 Nephi 3:28
					new VerseInfo(1, 93, 1, 95),//1 Nephi 3:29
					new VerseInfo(1, 96),//1 Nephi 3:30
					new VerseInfo(1, 97, 1, 98),//1 Nephi 3:31
				},
				new VerseInfo?[]
				{
					null,//1 Nephi 4
					new VerseInfo(1, 99),//1 Nephi 4:1
					new VerseInfo(1, 100),//1 Nephi 4:2
					new VerseInfo(1, 101, 1, 102),//1 Nephi 4:3
					new VerseInfo(1, 103),//1 Nephi 4:4
					new VerseInfo(1, 104, 1, 105),//1 Nephi 4:5
					new VerseInfo(1, 106),//1 Nephi 4:6
					new VerseInfo(1, 107),//1 Nephi 4:7
					new VerseInfo(1, 108),//1 Nephi 4:8
					new VerseInfo(1, 109),//1 Nephi 4:9
					new VerseInfo(1, 110, 1, 111),//1 Nephi 4:10
					new VerseInfo(1, 112),//1 Nephi 4:11
					new VerseInfo(1, 113),//1 Nephi 4:12
					new VerseInfo(1, 114, 1, 115),//1 Nephi 4:13
					new VerseInfo(1, 116),//1 Nephi 4:14
					new VerseInfo(1, 117),//1 Nephi 4:15
					new VerseInfo(1, 118),//1 Nephi 4:16
					new VerseInfo(1, 119),//1 Nephi 4:17
					new VerseInfo(1, 120),//1 Nephi 4:18
					new VerseInfo(1, 121),//1 Nephi 4:19
					new VerseInfo(1, 122, 1, 124),//1 Nephi 4:20
					new VerseInfo(1, 124),//1 Nephi 4:21
					new VerseInfo(1, 125),//1 Nephi 4:22
					new VerseInfo(1, 126),//1 Nephi 4:23
					new VerseInfo(1, 127),//1 Nephi 4:24
					new VerseInfo(1, 128),//1 Nephi 4:25
					new VerseInfo(1, 129),//1 Nephi 4:26
					new VerseInfo(1, 130),//1 Nephi 4:27
					new VerseInfo(1, 131, 1, 132),//1 Nephi 4:28
					new VerseInfo(1, 133),//1 Nephi 4:29
					new VerseInfo(1, 134),//1 Nephi 4:30
					new VerseInfo(1, 135),//1 Nephi 4:31
					new VerseInfo(1, 136),//1 Nephi 4:32
					new VerseInfo(1, 137),//1 Nephi 4:33
					new VerseInfo(1, 138, 1, 139),//1 Nephi 4:34
					new VerseInfo(1, 140, 1, 142),//1 Nephi 4:35
					new VerseInfo(1, 143),//1 Nephi 4:36
					new VerseInfo(1, 144),//1 Nephi 4:37
					new VerseInfo(1, 145),//1 Nephi 4:38
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//1 Nephi 5
					new VerseInfo(1, 146),//1 Nephi 5:1
					new VerseInfo(1, 146, 1, 147),//1 Nephi 5:2
					new VerseInfo(1, 148),//1 Nephi 5:3
					new VerseInfo(1, 149),//1 Nephi 5:4
					new VerseInfo(1, 150, 1, 151),//1 Nephi 5:5
					new VerseInfo(1, 152),//1 Nephi 5:6
					new VerseInfo(1, 153),//1 Nephi 5:7
					new VerseInfo(1, 154, 1, 156),//1 Nephi 5:8
					new VerseInfo(1, 157),//1 Nephi 5:9
					new VerseInfo(1, 158),//1 Nephi 5:10
					new VerseInfo(1, 159, 1, 160),//1 Nephi 5:11
					new VerseInfo(1, 161),//1 Nephi 5:12
					new VerseInfo(1, 162, 1, 163),//1 Nephi 5:13
					new VerseInfo(1, 164, 1, 165),//1 Nephi 5:14
					new VerseInfo(1, 166),//1 Nephi 5:15
					new VerseInfo(1, 167, 1, 168),//1 Nephi 5:16
					new VerseInfo(1, 169),//1 Nephi 5:17
					new VerseInfo(1, 169),//1 Nephi 5:18
					new VerseInfo(1, 170, 1, 171),//1 Nephi 5:19
					new VerseInfo(1, 172),//1 Nephi 5:20
					new VerseInfo(1, 173),//1 Nephi 5:21
					new VerseInfo(1, 174),//1 Nephi 5:22
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//1 Nephi 6
					new VerseInfo(2, 1),//1 Nephi 6:1
					new VerseInfo(2, 2),//1 Nephi 6:2
					new VerseInfo(2, 3),//1 Nephi 6:3
					new VerseInfo(2, 4),//1 Nephi 6:4
					new VerseInfo(2, 5),//1 Nephi 6:5
					new VerseInfo(2, 6),//1 Nephi 6:6
				},
				new VerseInfo?[]
				{
					null,//1 Nephi 7
					new VerseInfo(2, 7),//1 Nephi 7:1
					new VerseInfo(2, 8),//1 Nephi 7:2
					new VerseInfo(2, 9),//1 Nephi 7:3
					new VerseInfo(2, 10),//1 Nephi 7:4
					new VerseInfo(2, 11),//1 Nephi 7:5
					new VerseInfo(2, 12),//1 Nephi 7:6
					new VerseInfo(2, 13),//1 Nephi 7:7
					new VerseInfo(2, 14),//1 Nephi 7:8
					new VerseInfo(2, 15),//1 Nephi 7:9
					new VerseInfo(2, 16),//1 Nephi 7:10
					new VerseInfo(2, 17),//1 Nephi 7:11
					new VerseInfo(2, 18),//1 Nephi 7:12
					new VerseInfo(2, 19, 2, 20),//1 Nephi 7:13
					new VerseInfo(2, 21, 2, 23),//1 Nephi 7:14
					new VerseInfo(2, 24, 2, 25),//1 Nephi 7:15
					new VerseInfo(2, 26, 2, 27),//1 Nephi 7:16
					new VerseInfo(2, 28, 2, 29),//1 Nephi 7:17
					new VerseInfo(2, 30),//1 Nephi 7:18
					new VerseInfo(2, 31, 2, 32),//1 Nephi 7:19
					new VerseInfo(2, 33),//1 Nephi 7:20
					new VerseInfo(2, 34, 2, 36),//1 Nephi 7:21
					new VerseInfo(2, 37, 2, 39),//1 Nephi 7:22
				},
				new VerseInfo?[]
				{
					null,//1 Nephi 8
					new VerseInfo(2, 40),//1 Nephi 8:1
					new VerseInfo(2, 41),//1 Nephi 8:2
					new VerseInfo(2, 42),//1 Nephi 8:3
					new VerseInfo(2, 43),//1 Nephi 8:4
					new VerseInfo(2, 44),//1 Nephi 8:5
					new VerseInfo(2, 45),//1 Nephi 8:6
					new VerseInfo(2, 46),//1 Nephi 8:7
					new VerseInfo(2, 47),//1 Nephi 8:8
					new VerseInfo(2, 48),//1 Nephi 8:9
					new VerseInfo(2, 49),//1 Nephi 8:10
					new VerseInfo(2, 50, 2, 51),//1 Nephi 8:11
					new VerseInfo(2, 52, 2, 53),//1 Nephi 8:12
					new VerseInfo(2, 54),//1 Nephi 8:13
					new VerseInfo(2, 55, 2, 56),//1 Nephi 8:14
					new VerseInfo(2, 57),//1 Nephi 8:15
					new VerseInfo(2, 58),//1 Nephi 8:16
					new VerseInfo(2, 59, 2, 60),//1 Nephi 8:17
					new VerseInfo(2, 61),//1 Nephi 8:18
					new VerseInfo(2, 62),//1 Nephi 8:19
					new VerseInfo(2, 63, 2, 64),//1 Nephi 8:20
					new VerseInfo(2, 65),//1 Nephi 8:21
					new VerseInfo(2, 66),//1 Nephi 8:22
					new VerseInfo(2, 67),//1 Nephi 8:23
					new VerseInfo(2, 68, 2, 69),//1 Nephi 8:24
					new VerseInfo(2, 70),//1 Nephi 8:25
					new VerseInfo(2, 71, 2, 72),//1 Nephi 8:26
					new VerseInfo(2, 73, 2, 75),//1 Nephi 8:27
					new VerseInfo(2, 76),//1 Nephi 8:28
					new VerseInfo(2, 77),//1 Nephi 8:29
					new VerseInfo(2, 78),//1 Nephi 8:30
					new VerseInfo(2, 79),//1 Nephi 8:31
					new VerseInfo(2, 80, 2, 81),//1 Nephi 8:32
					new VerseInfo(2, 82, 2, 83),//1 Nephi 8:33
					new VerseInfo(2, 84),//1 Nephi 8:34
					new VerseInfo(2, 85),//1 Nephi 8:35
					new VerseInfo(2, 86, 2, 87),//1 Nephi 8:36
					new VerseInfo(2, 88, 2, 89),//1 Nephi 8:37
					new VerseInfo(2, 90, 2, 91),//1 Nephi 8:38
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//1 Nephi 9
					new VerseInfo(2, 92),//1 Nephi 9:1
					new VerseInfo(2, 93, 2, 95),//1 Nephi 9:2
					new VerseInfo(2, 96),//1 Nephi 9:3
					new VerseInfo(2, 97, 2, 98),//1 Nephi 9:4
					new VerseInfo(2, 99),//1 Nephi 9:5
					new VerseInfo(2, 100, 2, 102),//1 Nephi 9:6
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//1 Nephi 10
					new VerseInfo(3, 1),//1 Nephi 10:1
					new VerseInfo(3, 2),//1 Nephi 10:2
					new VerseInfo(3, 2, 3, 3),//1 Nephi 10:3
					new VerseInfo(3, 4),//1 Nephi 10:4
					new VerseInfo(3, 5),//1 Nephi 10:5
					new VerseInfo(3, 6),//1 Nephi 10:6
					new VerseInfo(3, 7),//1 Nephi 10:7
					new VerseInfo(3, 8, 3, 10),//1 Nephi 10:8
					new VerseInfo(3, 11),//1 Nephi 10:9
					new VerseInfo(3, 12),//1 Nephi 10:10
					new VerseInfo(3, 13, 3, 15),//1 Nephi 10:11
					new VerseInfo(3, 16),//1 Nephi 10:12
					new VerseInfo(3, 17),//1 Nephi 10:13
					new VerseInfo(3, 18, 3, 19),//1 Nephi 10:14
					new VerseInfo(3, 20, 3, 21),//1 Nephi 10:15
					new VerseInfo(3, 22),//1 Nephi 10:16
					new VerseInfo(3, 23, 3, 26),//1 Nephi 10:17
					new VerseInfo(3, 27, 3, 28),//1 Nephi 10:18
					new VerseInfo(3, 29, 3, 32),//1 Nephi 10:19
					new VerseInfo(3, 33),//1 Nephi 10:20
					new VerseInfo(3, 34, 3, 35),//1 Nephi 10:21
					new VerseInfo(3, 36),//1 Nephi 10:22
				},
				new VerseInfo?[]
				{
					null,//1 Nephi 11
					new VerseInfo(3, 37, 3, 38),//1 Nephi 11:1
					new VerseInfo(3, 39),//1 Nephi 11:2
					new VerseInfo(3, 40),//1 Nephi 11:3
					new VerseInfo(3, 41),//1 Nephi 11:4
					new VerseInfo(3, 42),//1 Nephi 11:5
					new VerseInfo(3, 43, 3, 44),//1 Nephi 11:6
					new VerseInfo(3, 45),//1 Nephi 11:7
					new VerseInfo(3, 46),//1 Nephi 11:8
					new VerseInfo(3, 47),//1 Nephi 11:9
					new VerseInfo(3, 48),//1 Nephi 11:10
					new VerseInfo(3, 49, 3, 50),//1 Nephi 11:11
					new VerseInfo(3, 51),//1 Nephi 11:12
					new VerseInfo(3, 52, 3, 53),//1 Nephi 11:13
					new VerseInfo(3, 54),//1 Nephi 11:14
					new VerseInfo(3, 55),//1 Nephi 11:15
					new VerseInfo(3, 56),//1 Nephi 11:16
					new VerseInfo(3, 57),//1 Nephi 11:17
					new VerseInfo(3, 58),//1 Nephi 11:18
					new VerseInfo(3, 59, 3, 60),//1 Nephi 11:19
					new VerseInfo(3, 61),//1 Nephi 11:20
					new VerseInfo(3, 62, 3, 63),//1 Nephi 11:21
					new VerseInfo(3, 64),//1 Nephi 11:22
					new VerseInfo(3, 65),//1 Nephi 11:23
					new VerseInfo(3, 66, 3, 67),//1 Nephi 11:24
					new VerseInfo(3, 68, 3, 69),//1 Nephi 11:25
					new VerseInfo(3, 70),//1 Nephi 11:26
					new VerseInfo(3, 71, 3, 74),//1 Nephi 11:27
					new VerseInfo(3, 75, 3, 77),//1 Nephi 11:28
					new VerseInfo(3, 78, 3, 79),//1 Nephi 11:29
					new VerseInfo(3, 80, 3, 81),//1 Nephi 11:30
					new VerseInfo(3, 82, 3, 85),//1 Nephi 11:31
					new VerseInfo(3, 86),//1 Nephi 11:32
					new VerseInfo(3, 87),//1 Nephi 11:33
					new VerseInfo(3, 88),//1 Nephi 11:34
					new VerseInfo(3, 89, 3, 92),//1 Nephi 11:35
					new VerseInfo(3, 93, 3, 95),//1 Nephi 11:36
				},
				new VerseInfo?[]
				{
					null,//1 Nephi 12
					new VerseInfo(3, 96, 3, 98),//1 Nephi 12:1
					new VerseInfo(3, 99),//1 Nephi 12:2
					new VerseInfo(3, 100, 3, 101),//1 Nephi 12:3
					new VerseInfo(3, 102, 3, 109),//1 Nephi 12:4
					new VerseInfo(3, 110, 3, 111),//1 Nephi 12:5
					new VerseInfo(3, 112),//1 Nephi 12:6
					new VerseInfo(3, 113),//1 Nephi 12:7
					new VerseInfo(3, 114),//1 Nephi 12:8
					new VerseInfo(3, 115, 3, 116),//1 Nephi 12:9
					new VerseInfo(3, 116, 3, 117),//1 Nephi 12:10
					new VerseInfo(3, 118, 3, 119),//1 Nephi 12:11
					new VerseInfo(3, 120),//1 Nephi 12:12
					new VerseInfo(3, 121),//1 Nephi 12:13
					new VerseInfo(3, 122),//1 Nephi 12:14
					new VerseInfo(3, 123),//1 Nephi 12:15
					new VerseInfo(3, 124),//1 Nephi 12:16
					new VerseInfo(3, 125),//1 Nephi 12:17
					new VerseInfo(3, 126, 3, 127),//1 Nephi 12:18
					new VerseInfo(3, 128, 3, 129),//1 Nephi 12:19
					new VerseInfo(3, 130),//1 Nephi 12:20
					new VerseInfo(3, 131, 3, 132),//1 Nephi 12:21
					new VerseInfo(3, 133),//1 Nephi 12:22
					new VerseInfo(3, 134),//1 Nephi 12:23
				},
				new VerseInfo?[]
				{
					null,//1 Nephi 13
					new VerseInfo(3, 135),//1 Nephi 13:1
					new VerseInfo(3, 136, 3, 137),//1 Nephi 13:2
					new VerseInfo(3, 138),//1 Nephi 13:3
					new VerseInfo(3, 139),//1 Nephi 13:4
					new VerseInfo(3, 140),//1 Nephi 13:5
					new VerseInfo(3, 141),//1 Nephi 13:6
					new VerseInfo(3, 142),//1 Nephi 13:7
					new VerseInfo(3, 143),//1 Nephi 13:8
					new VerseInfo(3, 144),//1 Nephi 13:9
					new VerseInfo(3, 145),//1 Nephi 13:10
					new VerseInfo(3, 146),//1 Nephi 13:11
					new VerseInfo(3, 147),//1 Nephi 13:12
					new VerseInfo(3, 148),//1 Nephi 13:13
					new VerseInfo(3, 149, 3, 150),//1 Nephi 13:14
					new VerseInfo(3, 151),//1 Nephi 13:15
					new VerseInfo(3, 152),//1 Nephi 13:16
					new VerseInfo(3, 153),//1 Nephi 13:17
					new VerseInfo(3, 154),//1 Nephi 13:18
					new VerseInfo(3, 155),//1 Nephi 13:19
					new VerseInfo(3, 156, 3, 157),//1 Nephi 13:20
					new VerseInfo(3, 158),//1 Nephi 13:21
					new VerseInfo(3, 159),//1 Nephi 13:22
					new VerseInfo(3, 160, 3, 164),//1 Nephi 13:23
					new VerseInfo(3, 165),//1 Nephi 13:24
					new VerseInfo(3, 166),//1 Nephi 13:25
					new VerseInfo(3, 167, 3, 169),//1 Nephi 13:26
					new VerseInfo(3, 170),//1 Nephi 13:27
					new VerseInfo(3, 171),//1 Nephi 13:28
					new VerseInfo(3, 172, 3, 175),//1 Nephi 13:29
					new VerseInfo(3, 176, 3, 177),//1 Nephi 13:30
					new VerseInfo(3, 178),//1 Nephi 13:31
					new VerseInfo(3, 179),//1 Nephi 13:32
					new VerseInfo(3, 180),//1 Nephi 13:33
					new VerseInfo(3, 181, 3, 183),//1 Nephi 13:34
					new VerseInfo(3, 184, 3, 185),//1 Nephi 13:35
					new VerseInfo(3, 186),//1 Nephi 13:36
					new VerseInfo(3, 187, 3, 189),//1 Nephi 13:37
					new VerseInfo(3, 190),//1 Nephi 13:38
					new VerseInfo(3, 191),//1 Nephi 13:39
					new VerseInfo(3, 192, 3, 193),//1 Nephi 13:40
					new VerseInfo(3, 194, 3, 197),//1 Nephi 13:41
					new VerseInfo(3, 198, 3, 200),//1 Nephi 13:42
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//1 Nephi 14
					new VerseInfo(3, 201),//1 Nephi 14:1
					new VerseInfo(3, 201, 3, 205),//1 Nephi 14:2
					new VerseInfo(3, 206, 3, 208),//1 Nephi 14:3
					new VerseInfo(3, 209),//1 Nephi 14:4
					new VerseInfo(3, 210, 3, 212),//1 Nephi 14:5
					new VerseInfo(3, 213),//1 Nephi 14:6
					new VerseInfo(3, 214, 3, 216),//1 Nephi 14:7
					new VerseInfo(3, 217, 3, 218),//1 Nephi 14:8
					new VerseInfo(3, 219),//1 Nephi 14:9
					new VerseInfo(3, 220, 3, 223),//1 Nephi 14:10
					new VerseInfo(3, 224, 3, 225),//1 Nephi 14:11
					new VerseInfo(3, 226, 3, 228),//1 Nephi 14:12
					new VerseInfo(3, 229),//1 Nephi 14:13
					new VerseInfo(3, 230, 3, 231),//1 Nephi 14:14
					new VerseInfo(3, 232),//1 Nephi 14:15
					new VerseInfo(3, 233, 3, 235),//1 Nephi 14:16
					new VerseInfo(3, 236, 3, 237),//1 Nephi 14:17
					new VerseInfo(3, 238),//1 Nephi 14:18
					new VerseInfo(3, 238),//1 Nephi 14:19
					new VerseInfo(3, 239),//1 Nephi 14:20
					new VerseInfo(3, 240, 3, 241),//1 Nephi 14:21
					new VerseInfo(3, 242),//1 Nephi 14:22
					new VerseInfo(3, 243, 3, 245),//1 Nephi 14:23
					new VerseInfo(3, 246, 3, 247),//1 Nephi 14:24
					new VerseInfo(3, 248),//1 Nephi 14:25
					new VerseInfo(3, 249, 3, 250),//1 Nephi 14:26
					new VerseInfo(3, 251),//1 Nephi 14:27
					new VerseInfo(3, 252, 3, 253),//1 Nephi 14:28
					new VerseInfo(3, 254),//1 Nephi 14:29
					new VerseInfo(3, 255, 3, 256),//1 Nephi 14:30
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//1 Nephi 15
					new VerseInfo(4, 1),//1 Nephi 15:1
					new VerseInfo(4, 2),//1 Nephi 15:2
					new VerseInfo(4, 3, 4, 4),//1 Nephi 15:3
					new VerseInfo(4, 5),//1 Nephi 15:4
					new VerseInfo(4, 6),//1 Nephi 15:5
					new VerseInfo(4, 7),//1 Nephi 15:6
					new VerseInfo(4, 8),//1 Nephi 15:7
					new VerseInfo(4, 9),//1 Nephi 15:8
					new VerseInfo(4, 10),//1 Nephi 15:9
					new VerseInfo(4, 11, 4, 12),//1 Nephi 15:10
					new VerseInfo(4, 13),//1 Nephi 15:11
					new VerseInfo(4, 14, 4, 15),//1 Nephi 15:12
					new VerseInfo(4, 16),//1 Nephi 15:13
					new VerseInfo(4, 17, 4, 19),//1 Nephi 15:14
					new VerseInfo(4, 20, 4, 22),//1 Nephi 15:15
					new VerseInfo(4, 23, 4, 24),//1 Nephi 15:16
					new VerseInfo(4, 25, 4, 27),//1 Nephi 15:17
					new VerseInfo(4, 28, 4, 29),//1 Nephi 15:18
					new VerseInfo(4, 30, 4, 31),//1 Nephi 15:19
					new VerseInfo(4, 32, 4, 34),//1 Nephi 15:20
					new VerseInfo(4, 35, 4, 36),//1 Nephi 15:21
					new VerseInfo(4, 37),//1 Nephi 15:22
					new VerseInfo(4, 38),//1 Nephi 15:23
					new VerseInfo(4, 39, 4, 40),//1 Nephi 15:24
					new VerseInfo(4, 41, 4, 42),//1 Nephi 15:25
					new VerseInfo(4, 43),//1 Nephi 15:26
					new VerseInfo(4, 44, 4, 45),//1 Nephi 15:27
					new VerseInfo(4, 46),//1 Nephi 15:28
					new VerseInfo(4, 47),//1 Nephi 15:29
					new VerseInfo(4, 48, 4, 49),//1 Nephi 15:30
					new VerseInfo(4, 50),//1 Nephi 15:31
					new VerseInfo(4, 51, 4, 52),//1 Nephi 15:32
					new VerseInfo(4, 53, 4, 57),//1 Nephi 15:33
					new VerseInfo(4, 58, 4, 59),//1 Nephi 15:34
					new VerseInfo(4, 60, 4, 61),//1 Nephi 15:35
					new VerseInfo(4, 62, 4, 64),//1 Nephi 15:36
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//1 Nephi 16
					new VerseInfo(5, 1),//1 Nephi 16:1
					new VerseInfo(5, 2),//1 Nephi 16:2
					new VerseInfo(5, 3),//1 Nephi 16:3
					new VerseInfo(5, 4),//1 Nephi 16:4
					new VerseInfo(5, 5),//1 Nephi 16:5
					new VerseInfo(5, 6),//1 Nephi 16:6
					new VerseInfo(5, 7),//1 Nephi 16:7
					new VerseInfo(5, 8, 5, 9),//1 Nephi 16:8
					new VerseInfo(5, 10),//1 Nephi 16:9
					new VerseInfo(5, 11, 5, 12),//1 Nephi 16:10
					new VerseInfo(5, 13, 5, 14),//1 Nephi 16:11
					new VerseInfo(5, 15),//1 Nephi 16:12
					new VerseInfo(5, 16),//1 Nephi 16:13
					new VerseInfo(5, 17, 5, 18),//1 Nephi 16:14
					new VerseInfo(5, 19),//1 Nephi 16:15
					new VerseInfo(5, 20),//1 Nephi 16:16
					new VerseInfo(5, 21),//1 Nephi 16:17
					new VerseInfo(5, 22),//1 Nephi 16:18
					new VerseInfo(5, 23, 5, 24),//1 Nephi 16:19
					new VerseInfo(5, 25),//1 Nephi 16:20
					new VerseInfo(5, 26),//1 Nephi 16:21
					new VerseInfo(5, 27),//1 Nephi 16:22
					new VerseInfo(5, 28, 5, 29),//1 Nephi 16:23
					new VerseInfo(5, 30),//1 Nephi 16:24
					new VerseInfo(5, 31),//1 Nephi 16:25
					new VerseInfo(5, 32),//1 Nephi 16:26
					new VerseInfo(5, 33),//1 Nephi 16:27
					new VerseInfo(5, 34),//1 Nephi 16:28
					new VerseInfo(5, 35, 5, 36),//1 Nephi 16:29
					new VerseInfo(5, 37),//1 Nephi 16:30
					new VerseInfo(5, 38),//1 Nephi 16:31
					new VerseInfo(5, 39, 5, 41),//1 Nephi 16:32
					new VerseInfo(5, 42, 5, 43),//1 Nephi 16:33
					new VerseInfo(5, 44),//1 Nephi 16:34
					new VerseInfo(5, 45, 5, 46),//1 Nephi 16:35
					new VerseInfo(5, 47),//1 Nephi 16:36
					new VerseInfo(5, 48),//1 Nephi 16:37
					new VerseInfo(5, 49, 5, 52),//1 Nephi 16:38
					new VerseInfo(5, 53, 5, 54),//1 Nephi 16:39
				},
				new VerseInfo?[]
				{
					null,//1 Nephi 17
					new VerseInfo(5, 55, 5, 56),//1 Nephi 17:1
					new VerseInfo(5, 57),//1 Nephi 17:2
					new VerseInfo(5, 58, 5, 60),//1 Nephi 17:3
					new VerseInfo(5, 61),//1 Nephi 17:4
					new VerseInfo(5, 62, 5, 64),//1 Nephi 17:5
					new VerseInfo(5, 65, 5, 67),//1 Nephi 17:6
					new VerseInfo(5, 68, 5, 69),//1 Nephi 17:7
					new VerseInfo(5, 70),//1 Nephi 17:8
					new VerseInfo(5, 71),//1 Nephi 17:9
					new VerseInfo(5, 72),//1 Nephi 17:10
					new VerseInfo(5, 73, 5, 74),//1 Nephi 17:11
					new VerseInfo(5, 75, 5, 76),//1 Nephi 17:12
					new VerseInfo(5, 77, 5, 79),//1 Nephi 17:13
					new VerseInfo(5, 80, 5, 82),//1 Nephi 17:14
					new VerseInfo(5, 83),//1 Nephi 17:15
					new VerseInfo(5, 84),//1 Nephi 17:16
					new VerseInfo(5, 85, 5, 87),//1 Nephi 17:17
					new VerseInfo(5, 88, 5, 89),//1 Nephi 17:18
					new VerseInfo(5, 90, 5, 92),//1 Nephi 17:19
					new VerseInfo(5, 93, 5, 96),//1 Nephi 17:20
					new VerseInfo(5, 97),//1 Nephi 17:21
					new VerseInfo(5, 98, 5, 102),//1 Nephi 17:22
					new VerseInfo(5, 103),//1 Nephi 17:23
					new VerseInfo(5, 104),//1 Nephi 17:24
					new VerseInfo(5, 105, 5, 106),//1 Nephi 17:25
					new VerseInfo(5, 107, 5, 108),//1 Nephi 17:26
					new VerseInfo(5, 109),//1 Nephi 17:27
					new VerseInfo(5, 110),//1 Nephi 17:28
					new VerseInfo(5, 111),//1 Nephi 17:29
					new VerseInfo(5, 112),//1 Nephi 17:30
					new VerseInfo(5, 113, 5, 116),//1 Nephi 17:31
					new VerseInfo(5, 117),//1 Nephi 17:32
					new VerseInfo(5, 118),//1 Nephi 17:33
					new VerseInfo(5, 119, 5, 120),//1 Nephi 17:34
					new VerseInfo(5, 121, 5, 125),//1 Nephi 17:35
					new VerseInfo(5, 126, 5, 127),//1 Nephi 17:36
					new VerseInfo(5, 128),//1 Nephi 17:37
					new VerseInfo(5, 129),//1 Nephi 17:38
					new VerseInfo(5, 130),//1 Nephi 17:39
					new VerseInfo(5, 131, 5, 133),//1 Nephi 17:40
					new VerseInfo(5, 133, 5, 135),//1 Nephi 17:41
					new VerseInfo(5, 136, 5, 137),//1 Nephi 17:42
					new VerseInfo(5, 138, 5, 140),//1 Nephi 17:43
					new VerseInfo(5, 141, 5, 143),//1 Nephi 17:44
					new VerseInfo(5, 144, 5, 147),//1 Nephi 17:45
					new VerseInfo(5, 148, 5, 150),//1 Nephi 17:46
					new VerseInfo(5, 151, 5, 152),//1 Nephi 17:47
					new VerseInfo(5, 153, 5, 155),//1 Nephi 17:48
					new VerseInfo(5, 156),//1 Nephi 17:49
					new VerseInfo(5, 157, 5, 158),//1 Nephi 17:50
					new VerseInfo(5, 159),//1 Nephi 17:51
					new VerseInfo(5, 160, 5, 162),//1 Nephi 17:52
					new VerseInfo(5, 163),//1 Nephi 17:53
					new VerseInfo(5, 164),//1 Nephi 17:54
					new VerseInfo(5, 165, 5, 167),//1 Nephi 17:55
				},
				new VerseInfo?[]
				{
					null,//1 Nephi 18
					new VerseInfo(5, 168, 5, 169),//1 Nephi 18:1
					new VerseInfo(5, 170, 5, 171),//1 Nephi 18:2
					new VerseInfo(5, 172),//1 Nephi 18:3
					new VerseInfo(5, 173, 5, 174),//1 Nephi 18:4
					new VerseInfo(5, 175),//1 Nephi 18:5
					new VerseInfo(5, 176, 5, 178),//1 Nephi 18:6
					new VerseInfo(5, 179),//1 Nephi 18:7
					new VerseInfo(5, 180, 5, 181),//1 Nephi 18:8
					new VerseInfo(5, 182, 5, 184),//1 Nephi 18:9
					new VerseInfo(5, 185, 5, 187),//1 Nephi 18:10
					new VerseInfo(5, 188, 5, 189),//1 Nephi 18:11
					new VerseInfo(5, 190),//1 Nephi 18:12
					new VerseInfo(5, 191, 5, 194),//1 Nephi 18:13
					new VerseInfo(5, 195),//1 Nephi 18:14
					new VerseInfo(5, 196, 5, 198),//1 Nephi 18:15
					new VerseInfo(5, 199),//1 Nephi 18:16
					new VerseInfo(5, 200, 5, 201),//1 Nephi 18:17
					new VerseInfo(5, 202, 5, 204),//1 Nephi 18:18
					new VerseInfo(5, 205, 5, 206),//1 Nephi 18:19
					new VerseInfo(5, 207, 5, 208),//1 Nephi 18:20
					new VerseInfo(5, 209, 5, 210),//1 Nephi 18:21
					new VerseInfo(5, 211),//1 Nephi 18:22
					new VerseInfo(5, 212, 5, 213),//1 Nephi 18:23
					new VerseInfo(5, 214, 5, 215),//1 Nephi 18:24
					new VerseInfo(5, 216, 5, 217),//1 Nephi 18:25
				},
				new VerseInfo?[]
				{
					null,//1 Nephi 19
					new VerseInfo(5, 218, 5, 219),//1 Nephi 19:1
					new VerseInfo(5, 220, 5, 222),//1 Nephi 19:2
					new VerseInfo(5, 223, 5, 224),//1 Nephi 19:3
					new VerseInfo(5, 225, 5, 226),//1 Nephi 19:4
					new VerseInfo(5, 227, 5, 228),//1 Nephi 19:5
					new VerseInfo(5, 229, 5, 231),//1 Nephi 19:6
					new VerseInfo(5, 232, 5, 235),//1 Nephi 19:7
					new VerseInfo(5, 236),//1 Nephi 19:8
					new VerseInfo(5, 237, 5, 238),//1 Nephi 19:9
					new VerseInfo(5, 239, 5, 244),//1 Nephi 19:10
					new VerseInfo(5, 245, 5, 247),//1 Nephi 19:11
					new VerseInfo(5, 248, 5, 250),//1 Nephi 19:12
					new VerseInfo(5, 251),//1 Nephi 19:13
					new VerseInfo(5, 252),//1 Nephi 19:14
					new VerseInfo(5, 253),//1 Nephi 19:15
					new VerseInfo(5, 254, 5, 255),//1 Nephi 19:16
					new VerseInfo(5, 256, 5, 257),//1 Nephi 19:17
					new VerseInfo(5, 258),//1 Nephi 19:18
					new VerseInfo(5, 259),//1 Nephi 19:19
					new VerseInfo(5, 260, 5, 261),//1 Nephi 19:20
					new VerseInfo(5, 262, 5, 264),//1 Nephi 19:21
					new VerseInfo(6, 1, 6, 2),//1 Nephi 19:22
					new VerseInfo(6, 3, 6, 5),//1 Nephi 19:23
					new VerseInfo(6, 6, 6, 7),//1 Nephi 19:24
				},
				new VerseInfo?[]
				{
					null,//1 Nephi 20
					new VerseInfo(6, 8),//1 Nephi 20:1
					new VerseInfo(6, 9),//1 Nephi 20:2
					new VerseInfo(6, 10),//1 Nephi 20:3
					new VerseInfo(6, 11),//1 Nephi 20:4
					new VerseInfo(6, 12),//1 Nephi 20:5
					new VerseInfo(6, 13),//1 Nephi 20:6
					new VerseInfo(6, 14),//1 Nephi 20:7
					new VerseInfo(6, 15),//1 Nephi 20:8
					new VerseInfo(6, 16),//1 Nephi 20:9
					new VerseInfo(6, 17),//1 Nephi 20:10
					new VerseInfo(6, 18),//1 Nephi 20:11
					new VerseInfo(6, 19),//1 Nephi 20:12
					new VerseInfo(6, 20),//1 Nephi 20:13
					new VerseInfo(6, 21),//1 Nephi 20:14
					new VerseInfo(6, 22),//1 Nephi 20:15
					new VerseInfo(6, 23),//1 Nephi 20:16
					new VerseInfo(6, 24),//1 Nephi 20:17
					new VerseInfo(6, 25),//1 Nephi 20:18
					new VerseInfo(6, 26),//1 Nephi 20:19
					new VerseInfo(6, 27),//1 Nephi 20:20
					new VerseInfo(6, 28),//1 Nephi 20:21
					new VerseInfo(6, 29),//1 Nephi 20:22
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//1 Nephi 21
					new VerseInfo(6, 30, 6, 31),//1 Nephi 21:1
					new VerseInfo(6, 32),//1 Nephi 21:2
					new VerseInfo(6, 33),//1 Nephi 21:3
					new VerseInfo(6, 34),//1 Nephi 21:4
					new VerseInfo(6, 35),//1 Nephi 21:5
					new VerseInfo(6, 36),//1 Nephi 21:6
					new VerseInfo(6, 37),//1 Nephi 21:7
					new VerseInfo(6, 38),//1 Nephi 21:8
					new VerseInfo(6, 39),//1 Nephi 21:9
					new VerseInfo(6, 40),//1 Nephi 21:10
					new VerseInfo(6, 41),//1 Nephi 21:11
					new VerseInfo(6, 42),//1 Nephi 21:12
					new VerseInfo(6, 43),//1 Nephi 21:13
					new VerseInfo(6, 44),//1 Nephi 21:14
					new VerseInfo(6, 45),//1 Nephi 21:15
					new VerseInfo(6, 46),//1 Nephi 21:16
					new VerseInfo(6, 47),//1 Nephi 21:17
					new VerseInfo(6, 48),//1 Nephi 21:18
					new VerseInfo(6, 49),//1 Nephi 21:19
					new VerseInfo(6, 50),//1 Nephi 21:20
					new VerseInfo(6, 51),//1 Nephi 21:21
					new VerseInfo(6, 52),//1 Nephi 21:22
					new VerseInfo(6, 53),//1 Nephi 21:23
					new VerseInfo(6, 54),//1 Nephi 21:24
					new VerseInfo(6, 55),//1 Nephi 21:25
					new VerseInfo(6, 56),//1 Nephi 21:26
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//1 Nephi 22
					new VerseInfo(7, 1, 7, 2),//1 Nephi 22:1
					new VerseInfo(7, 3, 7, 4),//1 Nephi 22:2
					new VerseInfo(7, 5, 7, 6),//1 Nephi 22:3
					new VerseInfo(7, 7, 7, 10),//1 Nephi 22:4
					new VerseInfo(7, 11, 7, 12),//1 Nephi 22:5
					new VerseInfo(7, 13, 7, 14),//1 Nephi 22:6
					new VerseInfo(7, 15, 7, 16),//1 Nephi 22:7
					new VerseInfo(7, 17, 7, 18),//1 Nephi 22:8
					new VerseInfo(7, 19, 7, 20),//1 Nephi 22:9
					new VerseInfo(7, 21),//1 Nephi 22:10
					new VerseInfo(7, 22),//1 Nephi 22:11
					new VerseInfo(7, 23, 7, 25),//1 Nephi 22:12
					new VerseInfo(7, 26, 7, 27),//1 Nephi 22:13
					new VerseInfo(7, 28, 7, 31),//1 Nephi 22:14
					new VerseInfo(7, 32, 7, 33),//1 Nephi 22:15
					new VerseInfo(7, 34, 7, 35),//1 Nephi 22:16
					new VerseInfo(7, 36, 7, 37),//1 Nephi 22:17
					new VerseInfo(7, 38, 7, 40),//1 Nephi 22:18
					new VerseInfo(7, 41, 7, 42),//1 Nephi 22:19
					new VerseInfo(7, 43, 7, 45),//1 Nephi 22:20
					new VerseInfo(7, 46, 7, 47),//1 Nephi 22:21
					new VerseInfo(7, 48, 7, 49),//1 Nephi 22:22
					new VerseInfo(7, 50, 7, 54),//1 Nephi 22:23
					new VerseInfo(7, 55),//1 Nephi 22:24
					new VerseInfo(7, 56, 7, 59),//1 Nephi 22:25
					new VerseInfo(7, 60, 7, 62),//1 Nephi 22:26
					new VerseInfo(7, 63),//1 Nephi 22:27
					new VerseInfo(7, 64),//1 Nephi 22:28
					new VerseInfo(7, 65),//1 Nephi 22:29
					new VerseInfo(7, 66, 7, 67),//1 Nephi 22:30
					new VerseInfo(7, 68, 7, 70),//1 Nephi 22:31
				},
			}
		},
		{ "2 Nephi", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//2 Nephi 1
					new VerseInfo(1, 1),//2 Nephi 1:1
					new VerseInfo(1, 2),//2 Nephi 1:2
					new VerseInfo(1, 3),//2 Nephi 1:3
					new VerseInfo(1, 4, 1, 5),//2 Nephi 1:4
					new VerseInfo(1, 6, 1, 9),//2 Nephi 1:5
					new VerseInfo(1, 10),//2 Nephi 1:6
					new VerseInfo(1, 11, 1, 15),//2 Nephi 1:7
					new VerseInfo(1, 16, 1, 17),//2 Nephi 1:8
					new VerseInfo(1, 18, 1, 21),//2 Nephi 1:9
					new VerseInfo(1, 22, 1, 23),//2 Nephi 1:10
					new VerseInfo(1, 24),//2 Nephi 1:11
					new VerseInfo(1, 25, 1, 26),//2 Nephi 1:12
					new VerseInfo(1, 27),//2 Nephi 1:13
					new VerseInfo(1, 28),//2 Nephi 1:14
					new VerseInfo(1, 29),//2 Nephi 1:15
					new VerseInfo(1, 30),//2 Nephi 1:16
					new VerseInfo(1, 31),//2 Nephi 1:17
					new VerseInfo(1, 32),//2 Nephi 1:18
					new VerseInfo(1, 33, 1, 34),//2 Nephi 1:19
					new VerseInfo(1, 34),//2 Nephi 1:20
					new VerseInfo(1, 35, 1, 36),//2 Nephi 1:21
					new VerseInfo(1, 36, 1, 37),//2 Nephi 1:22
					new VerseInfo(1, 38, 1, 39),//2 Nephi 1:23
					new VerseInfo(1, 40, 1, 42),//2 Nephi 1:24
					new VerseInfo(1, 43, 1, 45),//2 Nephi 1:25
					new VerseInfo(1, 46, 1, 49),//2 Nephi 1:26
					new VerseInfo(1, 50, 1, 51),//2 Nephi 1:27
					new VerseInfo(1, 52, 1, 53),//2 Nephi 1:28
					new VerseInfo(1, 54),//2 Nephi 1:29
					new VerseInfo(1, 55),//2 Nephi 1:30
					new VerseInfo(1, 56, 1, 57),//2 Nephi 1:31
					new VerseInfo(1, 58),//2 Nephi 1:32
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//2 Nephi 2
					new VerseInfo(1, 59, 1, 60),//2 Nephi 2:1
					new VerseInfo(1, 61),//2 Nephi 2:2
					new VerseInfo(1, 62, 1, 63),//2 Nephi 2:3
					new VerseInfo(1, 64, 1, 66),//2 Nephi 2:4
					new VerseInfo(1, 67, 1, 70),//2 Nephi 2:5
					new VerseInfo(1, 71),//2 Nephi 2:6
					new VerseInfo(1, 72),//2 Nephi 2:7
					new VerseInfo(1, 73, 1, 75),//2 Nephi 2:8
					new VerseInfo(1, 76, 1, 77),//2 Nephi 2:9
					new VerseInfo(1, 78, 1, 80),//2 Nephi 2:10
					new VerseInfo(1, 81, 1, 84),//2 Nephi 2:11
					new VerseInfo(1, 85, 1, 87),//2 Nephi 2:12
					new VerseInfo(1, 88, 1, 93),//2 Nephi 2:13
					new VerseInfo(1, 94, 1, 96),//2 Nephi 2:14
					new VerseInfo(1, 97, 1, 98),//2 Nephi 2:15
					new VerseInfo(1, 99, 1, 100),//2 Nephi 2:16
					new VerseInfo(1, 101, 1, 102),//2 Nephi 2:17
					new VerseInfo(1, 103, 1, 104),//2 Nephi 2:18
					new VerseInfo(1, 105),//2 Nephi 2:19
					new VerseInfo(1, 106),//2 Nephi 2:20
					new VerseInfo(1, 107, 1, 110),//2 Nephi 2:21
					new VerseInfo(1, 111, 1, 112),//2 Nephi 2:22
					new VerseInfo(1, 113),//2 Nephi 2:23
					new VerseInfo(1, 114),//2 Nephi 2:24
					new VerseInfo(1, 115),//2 Nephi 2:25
					new VerseInfo(1, 116, 1, 118),//2 Nephi 2:26
					new VerseInfo(1, 119, 1, 121),//2 Nephi 2:27
					new VerseInfo(1, 122, 1, 123),//2 Nephi 2:28
					new VerseInfo(1, 124, 1, 125),//2 Nephi 2:29
					new VerseInfo(1, 126, 1, 128),//2 Nephi 2:30
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 3
					new VerseInfo(2, 1, 2, 2),//2 Nephi 3:1
					new VerseInfo(2, 3),//2 Nephi 3:2
					new VerseInfo(2, 4),//2 Nephi 3:3
					new VerseInfo(2, 5, 2, 6),//2 Nephi 3:4
					new VerseInfo(2, 6, 2, 9),//2 Nephi 3:5
					new VerseInfo(2, 10),//2 Nephi 3:6
					new VerseInfo(2, 11, 2, 12),//2 Nephi 3:7
					new VerseInfo(2, 13, 2, 14),//2 Nephi 3:8
					new VerseInfo(2, 15),//2 Nephi 3:9
					new VerseInfo(2, 16),//2 Nephi 3:10
					new VerseInfo(2, 17, 2, 18),//2 Nephi 3:11
					new VerseInfo(2, 19, 2, 23),//2 Nephi 3:12
					new VerseInfo(2, 24),//2 Nephi 3:13
					new VerseInfo(2, 25, 2, 28),//2 Nephi 3:14
					new VerseInfo(2, 29, 2, 30),//2 Nephi 3:15
					new VerseInfo(2, 31),//2 Nephi 3:16
					new VerseInfo(2, 32, 2, 35),//2 Nephi 3:17
					new VerseInfo(2, 36, 2, 37),//2 Nephi 3:18
					new VerseInfo(2, 38, 2, 39),//2 Nephi 3:19
					new VerseInfo(2, 40, 2, 41),//2 Nephi 3:20
					new VerseInfo(2, 42, 2, 43),//2 Nephi 3:21
					new VerseInfo(2, 44),//2 Nephi 3:22
					new VerseInfo(2, 45),//2 Nephi 3:23
					new VerseInfo(2, 46, 2, 47),//2 Nephi 3:24
					new VerseInfo(2, 48, 2, 50),//2 Nephi 3:25
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 4
					new VerseInfo(3, 1),//2 Nephi 4:1
					new VerseInfo(3, 2, 3, 5),//2 Nephi 4:2
					new VerseInfo(3, 6, 3, 7),//2 Nephi 4:3
					new VerseInfo(3, 8, 3, 9),//2 Nephi 4:4
					new VerseInfo(3, 10, 3, 11),//2 Nephi 4:5
					new VerseInfo(3, 12),//2 Nephi 4:6
					new VerseInfo(3, 13),//2 Nephi 4:7
					new VerseInfo(3, 14),//2 Nephi 4:8
					new VerseInfo(3, 15, 3, 16),//2 Nephi 4:9
					new VerseInfo(3, 17),//2 Nephi 4:10
					new VerseInfo(3, 18, 3, 21),//2 Nephi 4:11
					new VerseInfo(3, 22, 3, 23),//2 Nephi 4:12
					new VerseInfo(3, 24),//2 Nephi 4:13
					new VerseInfo(3, 25, 3, 27),//2 Nephi 4:14
					new VerseInfo(3, 28, 3, 29),//2 Nephi 4:15
					new VerseInfo(3, 30),//2 Nephi 4:16
					new VerseInfo(3, 31, 3, 32),//2 Nephi 4:17
					new VerseInfo(3, 33),//2 Nephi 4:18
					new VerseInfo(3, 34),//2 Nephi 4:19
					new VerseInfo(3, 35),//2 Nephi 4:20
					new VerseInfo(3, 36),//2 Nephi 4:21
					new VerseInfo(3, 37),//2 Nephi 4:22
					new VerseInfo(3, 38),//2 Nephi 4:23
					new VerseInfo(3, 39),//2 Nephi 4:24
					new VerseInfo(3, 40, 3, 41),//2 Nephi 4:25
					new VerseInfo(3, 42),//2 Nephi 4:26
					new VerseInfo(3, 43, 3, 45),//2 Nephi 4:27
					new VerseInfo(3, 46, 3, 47),//2 Nephi 4:28
					new VerseInfo(3, 48, 3, 49),//2 Nephi 4:29
					new VerseInfo(3, 50),//2 Nephi 4:30
					new VerseInfo(3, 51, 3, 53),//2 Nephi 4:31
					new VerseInfo(3, 54, 3, 55),//2 Nephi 4:32
					new VerseInfo(3, 56, 3, 60),//2 Nephi 4:33
					new VerseInfo(3, 61, 3, 63),//2 Nephi 4:34
					new VerseInfo(3, 64, 3, 66),//2 Nephi 4:35
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 5
					new VerseInfo(4, 1),//2 Nephi 5:1
					new VerseInfo(4, 2),//2 Nephi 5:2
					new VerseInfo(4, 3, 4, 4),//2 Nephi 5:3
					new VerseInfo(4, 5, 4, 6),//2 Nephi 5:4
					new VerseInfo(4, 7),//2 Nephi 5:5
					new VerseInfo(4, 8, 4, 9),//2 Nephi 5:6
					new VerseInfo(4, 10, 4, 11),//2 Nephi 5:7
					new VerseInfo(4, 12),//2 Nephi 5:8
					new VerseInfo(4, 13),//2 Nephi 5:9
					new VerseInfo(4, 14),//2 Nephi 5:10
					new VerseInfo(4, 15, 4, 16),//2 Nephi 5:11
					new VerseInfo(4, 17),//2 Nephi 5:12
					new VerseInfo(4, 18),//2 Nephi 5:13
					new VerseInfo(4, 19, 4, 20),//2 Nephi 5:14
					new VerseInfo(4, 21),//2 Nephi 5:15
					new VerseInfo(4, 22, 4, 25),//2 Nephi 5:16
					new VerseInfo(4, 26),//2 Nephi 5:17
					new VerseInfo(4, 27, 4, 28),//2 Nephi 5:18
					new VerseInfo(4, 29, 4, 30),//2 Nephi 5:19
					new VerseInfo(4, 31, 4, 32),//2 Nephi 5:20
					new VerseInfo(4, 33, 4, 35),//2 Nephi 5:21
					new VerseInfo(4, 36),//2 Nephi 5:22
					new VerseInfo(4, 37, 4, 38),//2 Nephi 5:23
					new VerseInfo(4, 39),//2 Nephi 5:24
					new VerseInfo(4, 40, 4, 41),//2 Nephi 5:25
					new VerseInfo(4, 42),//2 Nephi 5:26
					new VerseInfo(4, 43),//2 Nephi 5:27
					new VerseInfo(4, 44),//2 Nephi 5:28
					new VerseInfo(4, 45),//2 Nephi 5:29
					new VerseInfo(4, 46),//2 Nephi 5:30
					new VerseInfo(4, 47),//2 Nephi 5:31
					new VerseInfo(4, 48, 4, 49),//2 Nephi 5:32
					new VerseInfo(4, 50),//2 Nephi 5:33
					new VerseInfo(4, 51),//2 Nephi 5:34
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//2 Nephi 6
					new VerseInfo(5, 1),//2 Nephi 6:1
					new VerseInfo(5, 2, 5, 4),//2 Nephi 6:2
					new VerseInfo(5, 5, 5, 8),//2 Nephi 6:3
					new VerseInfo(5, 9, 5, 12),//2 Nephi 6:4
					new VerseInfo(5, 13, 5, 15),//2 Nephi 6:5
					new VerseInfo(5, 16, 5, 18),//2 Nephi 6:6
					new VerseInfo(5, 19, 5, 21),//2 Nephi 6:7
					new VerseInfo(5, 22),//2 Nephi 6:8
					new VerseInfo(5, 23, 5, 25),//2 Nephi 6:9
					new VerseInfo(5, 26, 5, 27),//2 Nephi 6:10
					new VerseInfo(5, 28, 5, 29),//2 Nephi 6:11
					new VerseInfo(5, 30, 5, 32),//2 Nephi 6:12
					new VerseInfo(5, 33, 5, 35),//2 Nephi 6:13
					new VerseInfo(5, 36, 5, 38),//2 Nephi 6:14
					new VerseInfo(5, 39, 5, 40),//2 Nephi 6:15
					new VerseInfo(5, 41),//2 Nephi 6:16
					new VerseInfo(5, 42, 5, 43),//2 Nephi 6:17
					new VerseInfo(5, 43, 5, 45),//2 Nephi 6:18
				},
				new VerseInfo?[]
				{
					null,//2 Nephi 7
					new VerseInfo(5, 46, 5, 50),//2 Nephi 7:1
					new VerseInfo(5, 51, 5, 53),//2 Nephi 7:2
					new VerseInfo(5, 54),//2 Nephi 7:3
					new VerseInfo(5, 55, 5, 57),//2 Nephi 7:4
					new VerseInfo(5, 58),//2 Nephi 7:5
					new VerseInfo(5, 59, 5, 60),//2 Nephi 7:6
					new VerseInfo(5, 60, 5, 61),//2 Nephi 7:7
					new VerseInfo(5, 61, 5, 65),//2 Nephi 7:8
					new VerseInfo(5, 65, 5, 66),//2 Nephi 7:9
					new VerseInfo(5, 67),//2 Nephi 7:10
					new VerseInfo(5, 68, 5, 69),//2 Nephi 7:11
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//2 Nephi 8
					new VerseInfo(5, 70),//2 Nephi 8:1
					new VerseInfo(5, 71),//2 Nephi 8:2
					new VerseInfo(5, 72, 5, 74),//2 Nephi 8:3
					new VerseInfo(5, 75, 5, 76),//2 Nephi 8:4
					new VerseInfo(5, 77, 5, 78),//2 Nephi 8:5
					new VerseInfo(5, 79, 5, 81),//2 Nephi 8:6
					new VerseInfo(5, 82, 5, 83),//2 Nephi 8:7
					new VerseInfo(5, 84, 5, 85),//2 Nephi 8:8
					new VerseInfo(5, 86, 5, 87),//2 Nephi 8:9
					new VerseInfo(5, 88, 5, 89),//2 Nephi 8:10
					new VerseInfo(5, 90, 5, 91),//2 Nephi 8:11
					new VerseInfo(5, 92, 5, 93),//2 Nephi 8:12
					new VerseInfo(5, 94, 5, 96),//2 Nephi 8:13
					new VerseInfo(5, 97),//2 Nephi 8:14
					new VerseInfo(5, 98),//2 Nephi 8:15
					new VerseInfo(5, 99),//2 Nephi 8:16
					new VerseInfo(5, 100, 5, 101),//2 Nephi 8:17
					new VerseInfo(5, 102, 5, 103),//2 Nephi 8:18
					new VerseInfo(5, 104, 5, 105),//2 Nephi 8:19
					new VerseInfo(5, 106),//2 Nephi 8:20
					new VerseInfo(5, 107),//2 Nephi 8:21
					new VerseInfo(5, 108, 5, 109),//2 Nephi 8:22
					new VerseInfo(5, 110, 5, 111),//2 Nephi 8:23
					new VerseInfo(5, 112, 5, 113),//2 Nephi 8:24
					new VerseInfo(5, 114),//2 Nephi 8:25
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 9
					new VerseInfo(6, 1),//2 Nephi 9:1
					new VerseInfo(6, 2, 6, 3),//2 Nephi 9:2
					new VerseInfo(6, 4),//2 Nephi 9:3
					new VerseInfo(6, 5, 6, 7),//2 Nephi 9:4
					new VerseInfo(6, 8, 6, 10),//2 Nephi 9:5
					new VerseInfo(6, 11, 6, 14),//2 Nephi 9:6
					new VerseInfo(6, 15, 6, 18),//2 Nephi 9:7
					new VerseInfo(6, 19, 6, 20),//2 Nephi 9:8
					new VerseInfo(6, 21, 6, 23),//2 Nephi 9:9
					new VerseInfo(6, 24, 6, 25),//2 Nephi 9:10
					new VerseInfo(6, 26),//2 Nephi 9:11
					new VerseInfo(6, 27, 6, 30),//2 Nephi 9:12
					new VerseInfo(6, 31, 6, 33),//2 Nephi 9:13
					new VerseInfo(6, 34, 6, 35),//2 Nephi 9:14
					new VerseInfo(6, 36, 6, 37),//2 Nephi 9:15
					new VerseInfo(6, 38, 6, 40),//2 Nephi 9:16
					new VerseInfo(6, 41),//2 Nephi 9:17
					new VerseInfo(6, 42),//2 Nephi 9:18
					new VerseInfo(6, 43),//2 Nephi 9:19
					new VerseInfo(6, 44),//2 Nephi 9:20
					new VerseInfo(6, 45, 6, 46),//2 Nephi 9:21
					new VerseInfo(6, 47),//2 Nephi 9:22
					new VerseInfo(6, 48),//2 Nephi 9:23
					new VerseInfo(6, 49, 6, 50),//2 Nephi 9:24
					new VerseInfo(6, 51, 6, 54),//2 Nephi 9:25
					new VerseInfo(6, 54, 6, 55),//2 Nephi 9:26
					new VerseInfo(6, 56),//2 Nephi 9:27
					new VerseInfo(6, 57, 6, 60),//2 Nephi 9:28
					new VerseInfo(6, 61),//2 Nephi 9:29
					new VerseInfo(6, 62, 6, 64),//2 Nephi 9:30
					new VerseInfo(6, 65),//2 Nephi 9:31
					new VerseInfo(6, 66),//2 Nephi 9:32
					new VerseInfo(6, 67),//2 Nephi 9:33
					new VerseInfo(6, 68),//2 Nephi 9:34
					new VerseInfo(6, 69),//2 Nephi 9:35
					new VerseInfo(6, 70),//2 Nephi 9:36
					new VerseInfo(6, 71),//2 Nephi 9:37
					new VerseInfo(6, 72),//2 Nephi 9:38
					new VerseInfo(6, 73, 6, 74),//2 Nephi 9:39
					new VerseInfo(6, 75, 6, 78),//2 Nephi 9:40
					new VerseInfo(6, 79, 6, 82),//2 Nephi 9:41
					new VerseInfo(6, 83, 6, 84),//2 Nephi 9:42
					new VerseInfo(6, 85),//2 Nephi 9:43
					new VerseInfo(6, 86, 6, 88),//2 Nephi 9:44
					new VerseInfo(6, 89, 6, 90),//2 Nephi 9:45
					new VerseInfo(6, 91, 6, 93),//2 Nephi 9:46
					new VerseInfo(6, 94, 6, 96),//2 Nephi 9:47
					new VerseInfo(6, 97),//2 Nephi 9:48
					new VerseInfo(6, 98),//2 Nephi 9:49
					new VerseInfo(6, 99),//2 Nephi 9:50
					new VerseInfo(6, 100, 6, 102),//2 Nephi 9:51
					new VerseInfo(6, 103, 6, 104),//2 Nephi 9:52
					new VerseInfo(6, 104, 6, 105),//2 Nephi 9:53
					new VerseInfo(6, 106),//2 Nephi 9:54
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 10
					new VerseInfo(7, 1),//2 Nephi 10:1
					new VerseInfo(7, 2, 7, 4),//2 Nephi 10:2
					new VerseInfo(7, 5, 7, 7),//2 Nephi 10:3
					new VerseInfo(7, 8),//2 Nephi 10:4
					new VerseInfo(7, 9),//2 Nephi 10:5
					new VerseInfo(7, 10, 7, 11),//2 Nephi 10:6
					new VerseInfo(7, 12),//2 Nephi 10:7
					new VerseInfo(7, 13, 7, 14),//2 Nephi 10:8
					new VerseInfo(7, 15, 7, 16),//2 Nephi 10:9
					new VerseInfo(7, 17),//2 Nephi 10:10
					new VerseInfo(7, 18),//2 Nephi 10:11
					new VerseInfo(7, 19),//2 Nephi 10:12
					new VerseInfo(7, 20),//2 Nephi 10:13
					new VerseInfo(7, 20, 7, 21),//2 Nephi 10:14
					new VerseInfo(7, 22),//2 Nephi 10:15
					new VerseInfo(7, 23, 7, 25),//2 Nephi 10:16
					new VerseInfo(7, 26),//2 Nephi 10:17
					new VerseInfo(7, 27, 7, 29),//2 Nephi 10:18
					new VerseInfo(7, 30, 7, 32),//2 Nephi 10:19
					new VerseInfo(7, 33, 7, 35),//2 Nephi 10:20
					new VerseInfo(7, 36, 7, 37),//2 Nephi 10:21
					new VerseInfo(7, 38, 7, 39),//2 Nephi 10:22
					new VerseInfo(7, 40),//2 Nephi 10:23
					new VerseInfo(7, 41, 7, 42),//2 Nephi 10:24
					new VerseInfo(7, 43, 7, 44),//2 Nephi 10:25
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//2 Nephi 11
					new VerseInfo(8, 1),//2 Nephi 11:1
					new VerseInfo(8, 2, 8, 3),//2 Nephi 11:2
					new VerseInfo(8, 4, 8, 6),//2 Nephi 11:3
					new VerseInfo(8, 7, 8, 9),//2 Nephi 11:4
					new VerseInfo(8, 10, 8, 11),//2 Nephi 11:5
					new VerseInfo(8, 12),//2 Nephi 11:6
					new VerseInfo(8, 13, 8, 14),//2 Nephi 11:7
					new VerseInfo(8, 15, 8, 16),//2 Nephi 11:8
				},
				new VerseInfo?[]
				{
					null,//2 Nephi 12
					new VerseInfo(8, 17),//2 Nephi 12:1
					new VerseInfo(8, 18),//2 Nephi 12:2
					new VerseInfo(8, 19),//2 Nephi 12:3
					new VerseInfo(8, 20),//2 Nephi 12:4
					new VerseInfo(8, 21),//2 Nephi 12:5
					new VerseInfo(8, 22),//2 Nephi 12:6
					new VerseInfo(8, 23),//2 Nephi 12:7
					new VerseInfo(8, 24),//2 Nephi 12:8
					new VerseInfo(8, 25),//2 Nephi 12:9
					new VerseInfo(8, 26),//2 Nephi 12:10
					new VerseInfo(8, 27),//2 Nephi 12:11
					new VerseInfo(8, 28),//2 Nephi 12:12
					new VerseInfo(8, 29),//2 Nephi 12:13
					new VerseInfo(8, 30, 8, 31),//2 Nephi 12:14
					new VerseInfo(8, 31),//2 Nephi 12:15
					new VerseInfo(8, 32),//2 Nephi 12:16
					new VerseInfo(8, 33),//2 Nephi 12:17
					new VerseInfo(8, 34),//2 Nephi 12:18
					new VerseInfo(8, 35),//2 Nephi 12:19
					new VerseInfo(8, 36),//2 Nephi 12:20
					new VerseInfo(8, 37),//2 Nephi 12:21
					new VerseInfo(8, 38),//2 Nephi 12:22
				},
				new VerseInfo?[]
				{
					null,//2 Nephi 13
					new VerseInfo(8, 39),//2 Nephi 13:1
					new VerseInfo(8, 40),//2 Nephi 13:2
					new VerseInfo(8, 41),//2 Nephi 13:3
					new VerseInfo(8, 42),//2 Nephi 13:4
					new VerseInfo(8, 43),//2 Nephi 13:5
					new VerseInfo(8, 44),//2 Nephi 13:6
					new VerseInfo(8, 45),//2 Nephi 13:7
					new VerseInfo(8, 46),//2 Nephi 13:8
					new VerseInfo(8, 47),//2 Nephi 13:9
					new VerseInfo(8, 48),//2 Nephi 13:10
					new VerseInfo(8, 49),//2 Nephi 13:11
					new VerseInfo(8, 50),//2 Nephi 13:12
					new VerseInfo(8, 51),//2 Nephi 13:13
					new VerseInfo(8, 52),//2 Nephi 13:14
					new VerseInfo(8, 53),//2 Nephi 13:15
					new VerseInfo(8, 54),//2 Nephi 13:16
					new VerseInfo(8, 55),//2 Nephi 13:17
					new VerseInfo(8, 56),//2 Nephi 13:18
					new VerseInfo(8, 57),//2 Nephi 13:19
					new VerseInfo(8, 58),//2 Nephi 13:20
					new VerseInfo(8, 59),//2 Nephi 13:21
					new VerseInfo(8, 60),//2 Nephi 13:22
					new VerseInfo(8, 61),//2 Nephi 13:23
					new VerseInfo(8, 62),//2 Nephi 13:24
					new VerseInfo(8, 63),//2 Nephi 13:25
					new VerseInfo(8, 64),//2 Nephi 13:26
				},
				new VerseInfo?[]
				{
					null,//2 Nephi 14
					new VerseInfo(8, 65),//2 Nephi 14:1
					new VerseInfo(8, 66),//2 Nephi 14:2
					new VerseInfo(8, 67),//2 Nephi 14:3
					new VerseInfo(8, 68),//2 Nephi 14:4
					new VerseInfo(8, 69),//2 Nephi 14:5
					new VerseInfo(8, 70),//2 Nephi 14:6
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//2 Nephi 15
					new VerseInfo(8, 71),//2 Nephi 15:1
					new VerseInfo(8, 72),//2 Nephi 15:2
					new VerseInfo(8, 73),//2 Nephi 15:3
					new VerseInfo(8, 74),//2 Nephi 15:4
					new VerseInfo(8, 75),//2 Nephi 15:5
					new VerseInfo(8, 76),//2 Nephi 15:6
					new VerseInfo(8, 77),//2 Nephi 15:7
					new VerseInfo(8, 78),//2 Nephi 15:8
					new VerseInfo(8, 79),//2 Nephi 15:9
					new VerseInfo(8, 80),//2 Nephi 15:10
					new VerseInfo(8, 81),//2 Nephi 15:11
					new VerseInfo(8, 82),//2 Nephi 15:12
					new VerseInfo(8, 83),//2 Nephi 15:13
					new VerseInfo(8, 84),//2 Nephi 15:14
					new VerseInfo(8, 85),//2 Nephi 15:15
					new VerseInfo(8, 86),//2 Nephi 15:16
					new VerseInfo(8, 87),//2 Nephi 15:17
					new VerseInfo(8, 88),//2 Nephi 15:18
					new VerseInfo(8, 89),//2 Nephi 15:19
					new VerseInfo(8, 90),//2 Nephi 15:20
					new VerseInfo(8, 91),//2 Nephi 15:21
					new VerseInfo(8, 92),//2 Nephi 15:22
					new VerseInfo(8, 93),//2 Nephi 15:23
					new VerseInfo(8, 94),//2 Nephi 15:24
					new VerseInfo(8, 95),//2 Nephi 15:25
					new VerseInfo(8, 96, 8, 97),//2 Nephi 15:26
					new VerseInfo(8, 97),//2 Nephi 15:27
					new VerseInfo(8, 98),//2 Nephi 15:28
					new VerseInfo(8, 99),//2 Nephi 15:29
					new VerseInfo(8, 100),//2 Nephi 15:30
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//2 Nephi 16
					new VerseInfo(9, 1),//2 Nephi 16:1
					new VerseInfo(9, 2),//2 Nephi 16:2
					new VerseInfo(9, 3),//2 Nephi 16:3
					new VerseInfo(9, 4),//2 Nephi 16:4
					new VerseInfo(9, 5),//2 Nephi 16:5
					new VerseInfo(9, 6),//2 Nephi 16:6
					new VerseInfo(9, 7),//2 Nephi 16:7
					new VerseInfo(9, 8),//2 Nephi 16:8
					new VerseInfo(9, 9),//2 Nephi 16:9
					new VerseInfo(9, 10),//2 Nephi 16:10
					new VerseInfo(9, 11),//2 Nephi 16:11
					new VerseInfo(9, 12),//2 Nephi 16:12
					new VerseInfo(9, 13),//2 Nephi 16:13
				},
				new VerseInfo?[]
				{
					null,//2 Nephi 17
					new VerseInfo(9, 14),//2 Nephi 17:1
					new VerseInfo(9, 15),//2 Nephi 17:2
					new VerseInfo(9, 16),//2 Nephi 17:3
					new VerseInfo(9, 17),//2 Nephi 17:4
					new VerseInfo(9, 18),//2 Nephi 17:5
					new VerseInfo(9, 19),//2 Nephi 17:6
					new VerseInfo(9, 20),//2 Nephi 17:7
					new VerseInfo(9, 21),//2 Nephi 17:8
					new VerseInfo(9, 22),//2 Nephi 17:9
					new VerseInfo(9, 23),//2 Nephi 17:10
					new VerseInfo(9, 24),//2 Nephi 17:11
					new VerseInfo(9, 25),//2 Nephi 17:12
					new VerseInfo(9, 26),//2 Nephi 17:13
					new VerseInfo(9, 27),//2 Nephi 17:14
					new VerseInfo(9, 28),//2 Nephi 17:15
					new VerseInfo(9, 29),//2 Nephi 17:16
					new VerseInfo(9, 30),//2 Nephi 17:17
					new VerseInfo(9, 31),//2 Nephi 17:18
					new VerseInfo(9, 32),//2 Nephi 17:19
					new VerseInfo(9, 33),//2 Nephi 17:20
					new VerseInfo(9, 34),//2 Nephi 17:21
					new VerseInfo(9, 35),//2 Nephi 17:22
					new VerseInfo(9, 36),//2 Nephi 17:23
					new VerseInfo(9, 37),//2 Nephi 17:24
					new VerseInfo(9, 38),//2 Nephi 17:25
				},
				new VerseInfo?[]
				{
					null,//2 Nephi 18
					new VerseInfo(9, 39),//2 Nephi 18:1
					new VerseInfo(9, 40),//2 Nephi 18:2
					new VerseInfo(9, 41),//2 Nephi 18:3
					new VerseInfo(9, 42),//2 Nephi 18:4
					new VerseInfo(9, 43),//2 Nephi 18:5
					new VerseInfo(9, 44),//2 Nephi 18:6
					new VerseInfo(9, 45),//2 Nephi 18:7
					new VerseInfo(9, 46),//2 Nephi 18:8
					new VerseInfo(9, 47),//2 Nephi 18:9
					new VerseInfo(9, 48),//2 Nephi 18:10
					new VerseInfo(9, 49),//2 Nephi 18:11
					new VerseInfo(9, 50),//2 Nephi 18:12
					new VerseInfo(9, 51),//2 Nephi 18:13
					new VerseInfo(9, 52),//2 Nephi 18:14
					new VerseInfo(9, 53),//2 Nephi 18:15
					new VerseInfo(9, 54),//2 Nephi 18:16
					new VerseInfo(9, 55),//2 Nephi 18:17
					new VerseInfo(9, 56),//2 Nephi 18:18
					new VerseInfo(9, 57),//2 Nephi 18:19
					new VerseInfo(9, 58),//2 Nephi 18:20
					new VerseInfo(9, 59),//2 Nephi 18:21
					new VerseInfo(9, 60),//2 Nephi 18:22
				},
				new VerseInfo?[]
				{
					null,//2 Nephi 19
					new VerseInfo(9, 61),//2 Nephi 19:1
					new VerseInfo(9, 62),//2 Nephi 19:2
					new VerseInfo(9, 63),//2 Nephi 19:3
					new VerseInfo(9, 64),//2 Nephi 19:4
					new VerseInfo(9, 65),//2 Nephi 19:5
					new VerseInfo(9, 66),//2 Nephi 19:6
					new VerseInfo(9, 67),//2 Nephi 19:7
					new VerseInfo(9, 68),//2 Nephi 19:8
					new VerseInfo(9, 69),//2 Nephi 19:9
					new VerseInfo(9, 70),//2 Nephi 19:10
					new VerseInfo(9, 71),//2 Nephi 19:11
					new VerseInfo(9, 72),//2 Nephi 19:12
					new VerseInfo(9, 73),//2 Nephi 19:13
					new VerseInfo(9, 74),//2 Nephi 19:14
					new VerseInfo(9, 75),//2 Nephi 19:15
					new VerseInfo(9, 76),//2 Nephi 19:16
					new VerseInfo(9, 77),//2 Nephi 19:17
					new VerseInfo(9, 78),//2 Nephi 19:18
					new VerseInfo(9, 79),//2 Nephi 19:19
					new VerseInfo(9, 80),//2 Nephi 19:20
					new VerseInfo(9, 81),//2 Nephi 19:21
				},
				new VerseInfo?[]
				{
					null,//2 Nephi 20
					new VerseInfo(9, 82),//2 Nephi 20:1
					new VerseInfo(9, 83),//2 Nephi 20:2
					new VerseInfo(9, 84),//2 Nephi 20:3
					new VerseInfo(9, 85),//2 Nephi 20:4
					new VerseInfo(9, 86),//2 Nephi 20:5
					new VerseInfo(9, 87),//2 Nephi 20:6
					new VerseInfo(9, 88),//2 Nephi 20:7
					new VerseInfo(9, 89),//2 Nephi 20:8
					new VerseInfo(9, 90),//2 Nephi 20:9
					new VerseInfo(9, 91),//2 Nephi 20:10
					new VerseInfo(9, 92),//2 Nephi 20:11
					new VerseInfo(9, 93),//2 Nephi 20:12
					new VerseInfo(9, 94),//2 Nephi 20:13
					new VerseInfo(9, 95),//2 Nephi 20:14
					new VerseInfo(9, 96),//2 Nephi 20:15
					new VerseInfo(9, 97),//2 Nephi 20:16
					new VerseInfo(9, 98),//2 Nephi 20:17
					new VerseInfo(9, 99),//2 Nephi 20:18
					new VerseInfo(9, 100),//2 Nephi 20:19
					new VerseInfo(9, 101),//2 Nephi 20:20
					new VerseInfo(9, 102),//2 Nephi 20:21
					new VerseInfo(9, 103),//2 Nephi 20:22
					new VerseInfo(9, 104),//2 Nephi 20:23
					new VerseInfo(9, 105),//2 Nephi 20:24
					new VerseInfo(9, 106),//2 Nephi 20:25
					new VerseInfo(9, 107),//2 Nephi 20:26
					new VerseInfo(9, 108),//2 Nephi 20:27
					new VerseInfo(9, 109),//2 Nephi 20:28
					new VerseInfo(9, 110),//2 Nephi 20:29
					new VerseInfo(9, 111),//2 Nephi 20:30
					new VerseInfo(9, 112),//2 Nephi 20:31
					new VerseInfo(9, 113),//2 Nephi 20:32
					new VerseInfo(9, 114),//2 Nephi 20:33
					new VerseInfo(9, 115),//2 Nephi 20:34
				},
				new VerseInfo?[]
				{
					null,//2 Nephi 21
					new VerseInfo(9, 116),//2 Nephi 21:1
					new VerseInfo(9, 117),//2 Nephi 21:2
					new VerseInfo(9, 118),//2 Nephi 21:3
					new VerseInfo(9, 119),//2 Nephi 21:4
					new VerseInfo(9, 120),//2 Nephi 21:5
					new VerseInfo(9, 121),//2 Nephi 21:6
					new VerseInfo(9, 122),//2 Nephi 21:7
					new VerseInfo(9, 123),//2 Nephi 21:8
					new VerseInfo(9, 124),//2 Nephi 21:9
					new VerseInfo(9, 125),//2 Nephi 21:10
					new VerseInfo(9, 126),//2 Nephi 21:11
					new VerseInfo(9, 127),//2 Nephi 21:12
					new VerseInfo(9, 128),//2 Nephi 21:13
					new VerseInfo(9, 129),//2 Nephi 21:14
					new VerseInfo(9, 130),//2 Nephi 21:15
					new VerseInfo(9, 131),//2 Nephi 21:16
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//2 Nephi 22
					new VerseInfo(9, 132),//2 Nephi 22:1
					new VerseInfo(9, 133),//2 Nephi 22:2
					new VerseInfo(9, 134),//2 Nephi 22:3
					new VerseInfo(9, 135),//2 Nephi 22:4
					new VerseInfo(9, 136),//2 Nephi 22:5
					new VerseInfo(9, 137),//2 Nephi 22:6
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//2 Nephi 23
					new VerseInfo(10, 1),//2 Nephi 23:1
					new VerseInfo(10, 2),//2 Nephi 23:2
					new VerseInfo(10, 3),//2 Nephi 23:3
					new VerseInfo(10, 4),//2 Nephi 23:4
					new VerseInfo(10, 5),//2 Nephi 23:5
					new VerseInfo(10, 6),//2 Nephi 23:6
					new VerseInfo(10, 7),//2 Nephi 23:7
					new VerseInfo(10, 8),//2 Nephi 23:8
					new VerseInfo(10, 9),//2 Nephi 23:9
					new VerseInfo(10, 10),//2 Nephi 23:10
					new VerseInfo(10, 11),//2 Nephi 23:11
					new VerseInfo(10, 12),//2 Nephi 23:12
					new VerseInfo(10, 13),//2 Nephi 23:13
					new VerseInfo(10, 14),//2 Nephi 23:14
					new VerseInfo(10, 15),//2 Nephi 23:15
					new VerseInfo(10, 16),//2 Nephi 23:16
					new VerseInfo(10, 17),//2 Nephi 23:17
					new VerseInfo(10, 18),//2 Nephi 23:18
					new VerseInfo(10, 19),//2 Nephi 23:19
					new VerseInfo(10, 20),//2 Nephi 23:20
					new VerseInfo(10, 21),//2 Nephi 23:21
					new VerseInfo(10, 22),//2 Nephi 23:22
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//2 Nephi 24
					new VerseInfo(10, 23),//2 Nephi 24:1
					new VerseInfo(10, 24),//2 Nephi 24:2
					new VerseInfo(10, 25),//2 Nephi 24:3
					new VerseInfo(10, 26),//2 Nephi 24:4
					new VerseInfo(10, 27),//2 Nephi 24:5
					new VerseInfo(10, 28),//2 Nephi 24:6
					new VerseInfo(10, 29),//2 Nephi 24:7
					new VerseInfo(10, 30),//2 Nephi 24:8
					new VerseInfo(10, 31),//2 Nephi 24:9
					new VerseInfo(10, 32),//2 Nephi 24:10
					new VerseInfo(10, 33),//2 Nephi 24:11
					new VerseInfo(10, 34),//2 Nephi 24:12
					new VerseInfo(10, 35),//2 Nephi 24:13
					new VerseInfo(10, 36),//2 Nephi 24:14
					new VerseInfo(10, 37),//2 Nephi 24:15
					new VerseInfo(10, 38),//2 Nephi 24:16
					new VerseInfo(10, 39),//2 Nephi 24:17
					new VerseInfo(10, 40),//2 Nephi 24:18
					new VerseInfo(10, 41),//2 Nephi 24:19
					new VerseInfo(10, 42),//2 Nephi 24:20
					new VerseInfo(10, 43),//2 Nephi 24:21
					new VerseInfo(10, 44),//2 Nephi 24:22
					new VerseInfo(10, 45),//2 Nephi 24:23
					new VerseInfo(10, 46),//2 Nephi 24:24
					new VerseInfo(10, 47),//2 Nephi 24:25
					new VerseInfo(10, 48),//2 Nephi 24:26
					new VerseInfo(10, 49),//2 Nephi 24:27
					new VerseInfo(10, 50),//2 Nephi 24:28
					new VerseInfo(10, 51),//2 Nephi 24:29
					new VerseInfo(10, 52),//2 Nephi 24:30
					new VerseInfo(10, 53),//2 Nephi 24:31
					new VerseInfo(10, 54),//2 Nephi 24:32
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//2 Nephi 25
					new VerseInfo(11, 1, 11, 2),//2 Nephi 25:1
					new VerseInfo(11, 3),//2 Nephi 25:2
					new VerseInfo(11, 4),//2 Nephi 25:3
					new VerseInfo(11, 5, 11, 7),//2 Nephi 25:4
					new VerseInfo(11, 8),//2 Nephi 25:5
					new VerseInfo(11, 9, 11, 10),//2 Nephi 25:6
					new VerseInfo(11, 11, 11, 12),//2 Nephi 25:7
					new VerseInfo(11, 13, 11, 14),//2 Nephi 25:8
					new VerseInfo(11, 15, 11, 16),//2 Nephi 25:9
					new VerseInfo(11, 17, 11, 18),//2 Nephi 25:10
					new VerseInfo(11, 19, 11, 20),//2 Nephi 25:11
					new VerseInfo(11, 21),//2 Nephi 25:12
					new VerseInfo(11, 22, 11, 23),//2 Nephi 25:13
					new VerseInfo(11, 24),//2 Nephi 25:14
					new VerseInfo(11, 25),//2 Nephi 25:15
					new VerseInfo(11, 26, 11, 27),//2 Nephi 25:16
					new VerseInfo(11, 28, 11, 29),//2 Nephi 25:17
					new VerseInfo(11, 30, 11, 34),//2 Nephi 25:18
					new VerseInfo(11, 35, 11, 36),//2 Nephi 25:19
					new VerseInfo(11, 37, 11, 39),//2 Nephi 25:20
					new VerseInfo(11, 40),//2 Nephi 25:21
					new VerseInfo(11, 41, 11, 42),//2 Nephi 25:22
					new VerseInfo(11, 43, 11, 44),//2 Nephi 25:23
					new VerseInfo(11, 45),//2 Nephi 25:24
					new VerseInfo(11, 45, 11, 47),//2 Nephi 25:25
					new VerseInfo(11, 48),//2 Nephi 25:26
					new VerseInfo(11, 49, 11, 51),//2 Nephi 25:27
					new VerseInfo(11, 52, 11, 54),//2 Nephi 25:28
					new VerseInfo(11, 55, 11, 56),//2 Nephi 25:29
					new VerseInfo(11, 57),//2 Nephi 25:30
				},
				new VerseInfo?[]
				{
					null,//2 Nephi 26
					new VerseInfo(11, 58, 11, 59),//2 Nephi 26:1
					new VerseInfo(11, 60),//2 Nephi 26:2
					new VerseInfo(11, 61, 11, 64),//2 Nephi 26:3
					new VerseInfo(11, 65),//2 Nephi 26:4
					new VerseInfo(11, 66, 11, 67),//2 Nephi 26:5
					new VerseInfo(11, 68, 11, 69),//2 Nephi 26:6
					new VerseInfo(11, 70, 11, 71),//2 Nephi 26:7
					new VerseInfo(11, 72),//2 Nephi 26:8
					new VerseInfo(11, 73),//2 Nephi 26:9
					new VerseInfo(11, 74, 11, 76),//2 Nephi 26:10
					new VerseInfo(11, 76, 11, 77),//2 Nephi 26:11
					new VerseInfo(11, 78),//2 Nephi 26:12
					new VerseInfo(11, 78, 11, 79),//2 Nephi 26:13
					new VerseInfo(11, 80),//2 Nephi 26:14
					new VerseInfo(11, 81, 11, 83),//2 Nephi 26:15
					new VerseInfo(11, 84, 11, 85),//2 Nephi 26:16
					new VerseInfo(11, 86),//2 Nephi 26:17
					new VerseInfo(11, 87, 11, 88),//2 Nephi 26:18
					new VerseInfo(11, 89),//2 Nephi 26:19
					new VerseInfo(11, 90, 11, 91),//2 Nephi 26:20
					new VerseInfo(11, 92),//2 Nephi 26:21
					new VerseInfo(11, 93, 11, 94),//2 Nephi 26:22
					new VerseInfo(11, 95),//2 Nephi 26:23
					new VerseInfo(11, 96, 11, 97),//2 Nephi 26:24
					new VerseInfo(11, 98, 11, 99),//2 Nephi 26:25
					new VerseInfo(11, 100, 11, 101),//2 Nephi 26:26
					new VerseInfo(11, 102, 11, 103),//2 Nephi 26:27
					new VerseInfo(11, 104, 11, 105),//2 Nephi 26:28
					new VerseInfo(11, 106),//2 Nephi 26:29
					new VerseInfo(11, 107, 11, 108),//2 Nephi 26:30
					new VerseInfo(11, 109),//2 Nephi 26:31
					new VerseInfo(11, 110, 11, 111),//2 Nephi 26:32
					new VerseInfo(11, 111, 11, 115),//2 Nephi 26:33
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//2 Nephi 27
					new VerseInfo(11, 116),//2 Nephi 27:1
					new VerseInfo(11, 117),//2 Nephi 27:2
					new VerseInfo(11, 118, 11, 121),//2 Nephi 27:3
					new VerseInfo(11, 122),//2 Nephi 27:4
					new VerseInfo(11, 123, 11, 124),//2 Nephi 27:5
					new VerseInfo(11, 125),//2 Nephi 27:6
					new VerseInfo(11, 126),//2 Nephi 27:7
					new VerseInfo(11, 127, 11, 128),//2 Nephi 27:8
					new VerseInfo(11, 129),//2 Nephi 27:9
					new VerseInfo(11, 129, 11, 130),//2 Nephi 27:10
					new VerseInfo(11, 131, 11, 132),//2 Nephi 27:11
					new VerseInfo(11, 133),//2 Nephi 27:12
					new VerseInfo(11, 134),//2 Nephi 27:13
					new VerseInfo(11, 135),//2 Nephi 27:14
					new VerseInfo(11, 136, 11, 137),//2 Nephi 27:15
					new VerseInfo(11, 138),//2 Nephi 27:16
					new VerseInfo(11, 139),//2 Nephi 27:17
					new VerseInfo(11, 140),//2 Nephi 27:18
					new VerseInfo(11, 141),//2 Nephi 27:19
					new VerseInfo(11, 142),//2 Nephi 27:20
					new VerseInfo(11, 143),//2 Nephi 27:21
					new VerseInfo(11, 144),//2 Nephi 27:22
					new VerseInfo(11, 145),//2 Nephi 27:23
					new VerseInfo(11, 146),//2 Nephi 27:24
					new VerseInfo(11, 146),//2 Nephi 27:25
					new VerseInfo(11, 146, 11, 147),//2 Nephi 27:26
					new VerseInfo(11, 148, 11, 153),//2 Nephi 27:27
					new VerseInfo(11, 154),//2 Nephi 27:28
					new VerseInfo(11, 155),//2 Nephi 27:29
					new VerseInfo(11, 156),//2 Nephi 27:30
					new VerseInfo(11, 157),//2 Nephi 27:31
					new VerseInfo(11, 157),//2 Nephi 27:32
					new VerseInfo(11, 158),//2 Nephi 27:33
					new VerseInfo(11, 159),//2 Nephi 27:34
					new VerseInfo(11, 160),//2 Nephi 27:35
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//2 Nephi 28
					new VerseInfo(12, 1),//2 Nephi 28:1
					new VerseInfo(12, 2),//2 Nephi 28:2
					new VerseInfo(12, 3, 12, 4),//2 Nephi 28:3
					new VerseInfo(12, 5),//2 Nephi 28:4
					new VerseInfo(12, 6, 12, 7),//2 Nephi 28:5
					new VerseInfo(12, 8),//2 Nephi 28:6
					new VerseInfo(12, 9),//2 Nephi 28:7
					new VerseInfo(12, 10, 12, 11),//2 Nephi 28:8
					new VerseInfo(12, 12),//2 Nephi 28:9
					new VerseInfo(12, 12),//2 Nephi 28:10
					new VerseInfo(12, 13),//2 Nephi 28:11
					new VerseInfo(12, 14),//2 Nephi 28:12
					new VerseInfo(12, 15),//2 Nephi 28:13
					new VerseInfo(12, 16, 12, 17),//2 Nephi 28:14
					new VerseInfo(12, 18),//2 Nephi 28:15
					new VerseInfo(12, 19, 12, 20),//2 Nephi 28:16
					new VerseInfo(12, 21),//2 Nephi 28:17
					new VerseInfo(12, 22),//2 Nephi 28:18
					new VerseInfo(12, 23),//2 Nephi 28:19
					new VerseInfo(12, 24),//2 Nephi 28:20
					new VerseInfo(12, 25, 12, 26),//2 Nephi 28:21
					new VerseInfo(12, 27, 12, 28),//2 Nephi 28:22
					new VerseInfo(12, 29),//2 Nephi 28:23
					new VerseInfo(12, 30),//2 Nephi 28:24
					new VerseInfo(12, 31),//2 Nephi 28:25
					new VerseInfo(12, 31),//2 Nephi 28:26
					new VerseInfo(12, 32),//2 Nephi 28:27
					new VerseInfo(12, 33, 12, 34),//2 Nephi 28:28
					new VerseInfo(12, 35),//2 Nephi 28:29
					new VerseInfo(12, 36, 12, 38),//2 Nephi 28:30
					new VerseInfo(12, 39),//2 Nephi 28:31
					new VerseInfo(12, 40, 12, 41),//2 Nephi 28:32
				},
				new VerseInfo?[]
				{
					null,//2 Nephi 29
					new VerseInfo(12, 42),//2 Nephi 29:1
					new VerseInfo(12, 43, 12, 44),//2 Nephi 29:2
					new VerseInfo(12, 45),//2 Nephi 29:3
					new VerseInfo(12, 46, 12, 49),//2 Nephi 29:4
					new VerseInfo(12, 50, 12, 52),//2 Nephi 29:5
					new VerseInfo(12, 53, 12, 54),//2 Nephi 29:6
					new VerseInfo(12, 55, 12, 57),//2 Nephi 29:7
					new VerseInfo(12, 58, 12, 61),//2 Nephi 29:8
					new VerseInfo(12, 62, 12, 63),//2 Nephi 29:9
					new VerseInfo(12, 64),//2 Nephi 29:10
					new VerseInfo(12, 65, 12, 66),//2 Nephi 29:11
					new VerseInfo(12, 67, 12, 70),//2 Nephi 29:12
					new VerseInfo(12, 71, 12, 72),//2 Nephi 29:13
					new VerseInfo(12, 73, 12, 74),//2 Nephi 29:14
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//2 Nephi 30
					new VerseInfo(12, 75, 12, 76),//2 Nephi 30:1
					new VerseInfo(12, 77, 12, 78),//2 Nephi 30:2
					new VerseInfo(12, 79, 12, 80),//2 Nephi 30:3
					new VerseInfo(12, 81),//2 Nephi 30:4
					new VerseInfo(12, 82),//2 Nephi 30:5
					new VerseInfo(12, 83, 12, 84),//2 Nephi 30:6
					new VerseInfo(12, 85, 12, 86),//2 Nephi 30:7
					new VerseInfo(12, 87),//2 Nephi 30:8
					new VerseInfo(12, 88, 12, 89),//2 Nephi 30:9
					new VerseInfo(12, 90),//2 Nephi 30:10
					new VerseInfo(12, 91),//2 Nephi 30:11
					new VerseInfo(12, 92),//2 Nephi 30:12
					new VerseInfo(12, 93),//2 Nephi 30:13
					new VerseInfo(12, 94),//2 Nephi 30:14
					new VerseInfo(12, 95),//2 Nephi 30:15
					new VerseInfo(12, 96),//2 Nephi 30:16
					new VerseInfo(12, 97),//2 Nephi 30:17
					new VerseInfo(12, 98, 12, 100),//2 Nephi 30:18
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 31
					new VerseInfo(13, 1, 13, 2),//2 Nephi 31:1
					new VerseInfo(13, 3),//2 Nephi 31:2
					new VerseInfo(13, 4, 13, 5),//2 Nephi 31:3
					new VerseInfo(13, 6),//2 Nephi 31:4
					new VerseInfo(13, 7),//2 Nephi 31:5
					new VerseInfo(13, 8),//2 Nephi 31:6
					new VerseInfo(13, 8, 13, 9),//2 Nephi 31:7
					new VerseInfo(13, 10),//2 Nephi 31:8
					new VerseInfo(13, 11),//2 Nephi 31:9
					new VerseInfo(13, 12, 13, 13),//2 Nephi 31:10
					new VerseInfo(13, 14),//2 Nephi 31:11
					new VerseInfo(13, 15),//2 Nephi 31:12
					new VerseInfo(13, 16, 13, 17),//2 Nephi 31:13
					new VerseInfo(13, 18),//2 Nephi 31:14
					new VerseInfo(13, 19, 13, 20),//2 Nephi 31:15
					new VerseInfo(13, 21),//2 Nephi 31:16
					new VerseInfo(13, 22, 13, 24),//2 Nephi 31:17
					new VerseInfo(13, 25, 13, 26),//2 Nephi 31:18
					new VerseInfo(13, 27, 13, 28),//2 Nephi 31:19
					new VerseInfo(13, 29, 13, 30),//2 Nephi 31:20
					new VerseInfo(13, 31, 13, 32),//2 Nephi 31:21
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 32
					new VerseInfo(14, 1, 14, 2),//2 Nephi 32:1
					new VerseInfo(14, 2, 14, 3),//2 Nephi 32:2
					new VerseInfo(14, 3, 14, 4),//2 Nephi 32:3
					new VerseInfo(14, 5),//2 Nephi 32:4
					new VerseInfo(14, 6),//2 Nephi 32:5
					new VerseInfo(14, 7, 14, 8),//2 Nephi 32:6
					new VerseInfo(14, 9),//2 Nephi 32:7
					new VerseInfo(14, 10, 14, 11),//2 Nephi 32:8
					new VerseInfo(14, 12),//2 Nephi 32:9
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 33
					new VerseInfo(15, 1),//2 Nephi 33:1
					new VerseInfo(15, 2),//2 Nephi 33:2
					new VerseInfo(15, 3, 15, 4),//2 Nephi 33:3
					new VerseInfo(15, 4, 15, 5),//2 Nephi 33:4
					new VerseInfo(15, 6),//2 Nephi 33:5
					new VerseInfo(15, 7),//2 Nephi 33:6
					new VerseInfo(15, 8),//2 Nephi 33:7
					new VerseInfo(15, 9),//2 Nephi 33:8
					new VerseInfo(15, 9, 15, 10),//2 Nephi 33:9
					new VerseInfo(15, 11, 15, 12),//2 Nephi 33:10
					new VerseInfo(15, 13, 15, 14),//2 Nephi 33:11
					new VerseInfo(15, 15),//2 Nephi 33:12
					new VerseInfo(15, 16),//2 Nephi 33:13
					new VerseInfo(15, 17),//2 Nephi 33:14
					new VerseInfo(15, 18),//2 Nephi 33:15
				},
			}
		},
		{ "Jacob", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Jacob 1
					new VerseInfo(1, 1),//Jacob 1:1
					new VerseInfo(1, 2),//Jacob 1:2
					new VerseInfo(1, 3),//Jacob 1:3
					new VerseInfo(1, 4),//Jacob 1:4
					new VerseInfo(1, 5),//Jacob 1:5
					new VerseInfo(1, 6),//Jacob 1:6
					new VerseInfo(1, 7),//Jacob 1:7
					new VerseInfo(1, 8),//Jacob 1:8
					new VerseInfo(1, 9),//Jacob 1:9
					new VerseInfo(1, 10),//Jacob 1:10
					new VerseInfo(1, 10, 1, 11),//Jacob 1:11
					new VerseInfo(1, 12),//Jacob 1:12
					new VerseInfo(1, 13),//Jacob 1:13
					new VerseInfo(1, 14),//Jacob 1:14
					new VerseInfo(1, 15),//Jacob 1:15
					new VerseInfo(1, 16),//Jacob 1:16
					new VerseInfo(1, 17),//Jacob 1:17
					new VerseInfo(1, 18),//Jacob 1:18
					new VerseInfo(1, 19, 1, 20),//Jacob 1:19
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Jacob 2
					new VerseInfo(2, 1),//Jacob 2:1
					new VerseInfo(2, 2),//Jacob 2:2
					new VerseInfo(2, 3),//Jacob 2:3
					new VerseInfo(2, 4),//Jacob 2:4
					new VerseInfo(2, 5),//Jacob 2:5
					new VerseInfo(2, 6),//Jacob 2:6
					new VerseInfo(2, 7),//Jacob 2:7
					new VerseInfo(2, 8),//Jacob 2:8
					new VerseInfo(2, 9, 2, 10),//Jacob 2:9
					new VerseInfo(2, 11),//Jacob 2:10
					new VerseInfo(2, 12, 2, 13),//Jacob 2:11
					new VerseInfo(2, 14),//Jacob 2:12
					new VerseInfo(2, 15, 2, 16),//Jacob 2:13
					new VerseInfo(2, 17, 2, 18),//Jacob 2:14
					new VerseInfo(2, 19),//Jacob 2:15
					new VerseInfo(2, 20, 2, 21),//Jacob 2:16
					new VerseInfo(2, 22),//Jacob 2:17
					new VerseInfo(2, 23),//Jacob 2:18
					new VerseInfo(2, 24),//Jacob 2:19
					new VerseInfo(2, 25),//Jacob 2:20
					new VerseInfo(2, 26, 2, 28),//Jacob 2:21
					new VerseInfo(2, 29, 2, 30),//Jacob 2:22
					new VerseInfo(2, 31, 2, 32),//Jacob 2:23
					new VerseInfo(2, 33),//Jacob 2:24
					new VerseInfo(2, 34),//Jacob 2:25
					new VerseInfo(2, 35),//Jacob 2:26
					new VerseInfo(2, 36),//Jacob 2:27
					new VerseInfo(2, 36, 2, 37),//Jacob 2:28
					new VerseInfo(2, 38),//Jacob 2:29
					new VerseInfo(2, 39),//Jacob 2:30
					new VerseInfo(2, 40),//Jacob 2:31
					new VerseInfo(2, 41),//Jacob 2:32
					new VerseInfo(2, 42, 2, 43),//Jacob 2:33
					new VerseInfo(2, 44),//Jacob 2:34
					new VerseInfo(2, 45, 2, 47),//Jacob 2:35
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Jacob 3
					new VerseInfo(2, 48, 2, 49),//Jacob 3:1
					new VerseInfo(2, 50),//Jacob 3:2
					new VerseInfo(2, 51, 2, 52),//Jacob 3:3
					new VerseInfo(2, 53),//Jacob 3:4
					new VerseInfo(2, 54, 2, 55),//Jacob 3:5
					new VerseInfo(2, 56),//Jacob 3:6
					new VerseInfo(2, 57, 2, 58),//Jacob 3:7
					new VerseInfo(2, 59),//Jacob 3:8
					new VerseInfo(2, 60, 2, 61),//Jacob 3:9
					new VerseInfo(2, 62, 2, 63),//Jacob 3:10
					new VerseInfo(2, 64, 2, 65),//Jacob 3:11
					new VerseInfo(2, 66),//Jacob 3:12
					new VerseInfo(2, 67, 2, 68),//Jacob 3:13
					new VerseInfo(2, 69, 2, 70),//Jacob 3:14
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Jacob 4
					new VerseInfo(3, 1),//Jacob 4:1
					new VerseInfo(3, 2),//Jacob 4:2
					new VerseInfo(3, 3),//Jacob 4:3
					new VerseInfo(3, 4),//Jacob 4:4
					new VerseInfo(3, 5, 3, 6),//Jacob 4:5
					new VerseInfo(3, 7),//Jacob 4:6
					new VerseInfo(3, 8),//Jacob 4:7
					new VerseInfo(3, 9, 3, 11),//Jacob 4:8
					new VerseInfo(3, 12, 3, 13),//Jacob 4:9
					new VerseInfo(3, 14, 3, 15),//Jacob 4:10
					new VerseInfo(3, 16, 3, 17),//Jacob 4:11
					new VerseInfo(3, 18),//Jacob 4:12
					new VerseInfo(3, 18, 3, 21),//Jacob 4:13
					new VerseInfo(3, 22, 3, 25),//Jacob 4:14
					new VerseInfo(3, 26),//Jacob 4:15
					new VerseInfo(3, 27),//Jacob 4:16
					new VerseInfo(3, 28),//Jacob 4:17
					new VerseInfo(3, 29),//Jacob 4:18
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Jacob 5
					new VerseInfo(3, 30),//Jacob 5:1
					new VerseInfo(3, 30),//Jacob 5:2
					new VerseInfo(3, 31),//Jacob 5:3
					new VerseInfo(3, 32),//Jacob 5:4
					new VerseInfo(3, 33),//Jacob 5:5
					new VerseInfo(3, 34),//Jacob 5:6
					new VerseInfo(3, 35, 3, 36),//Jacob 5:7
					new VerseInfo(3, 37, 3, 39),//Jacob 5:8
					new VerseInfo(3, 40, 3, 41),//Jacob 5:9
					new VerseInfo(3, 42),//Jacob 5:10
					new VerseInfo(3, 43, 3, 44),//Jacob 5:11
					new VerseInfo(3, 45),//Jacob 5:12
					new VerseInfo(3, 46, 3, 47),//Jacob 5:13
					new VerseInfo(3, 48),//Jacob 5:14
					new VerseInfo(3, 49),//Jacob 5:15
					new VerseInfo(3, 50, 3, 51),//Jacob 5:16
					new VerseInfo(3, 52, 3, 53),//Jacob 5:17
					new VerseInfo(3, 54, 3, 57),//Jacob 5:18
					new VerseInfo(3, 58),//Jacob 5:19
					new VerseInfo(3, 59, 3, 62),//Jacob 5:20
					new VerseInfo(3, 63),//Jacob 5:21
					new VerseInfo(3, 64),//Jacob 5:22
					new VerseInfo(3, 65, 3, 66),//Jacob 5:23
					new VerseInfo(3, 67),//Jacob 5:24
					new VerseInfo(3, 68),//Jacob 5:25
					new VerseInfo(3, 69),//Jacob 5:26
					new VerseInfo(3, 70),//Jacob 5:27
					new VerseInfo(3, 71),//Jacob 5:28
					new VerseInfo(3, 72, 3, 73),//Jacob 5:29
					new VerseInfo(3, 74),//Jacob 5:30
					new VerseInfo(3, 75, 3, 76),//Jacob 5:31
					new VerseInfo(3, 77, 3, 78),//Jacob 5:32
					new VerseInfo(3, 79),//Jacob 5:33
					new VerseInfo(3, 80),//Jacob 5:34
					new VerseInfo(3, 81),//Jacob 5:35
					new VerseInfo(3, 82),//Jacob 5:36
					new VerseInfo(3, 83, 3, 84),//Jacob 5:37
					new VerseInfo(3, 85),//Jacob 5:38
					new VerseInfo(3, 86, 3, 87),//Jacob 5:39
					new VerseInfo(3, 88),//Jacob 5:40
					new VerseInfo(3, 89),//Jacob 5:41
					new VerseInfo(3, 90, 3, 92),//Jacob 5:42
					new VerseInfo(3, 93),//Jacob 5:43
					new VerseInfo(3, 94),//Jacob 5:44
					new VerseInfo(3, 95, 3, 96),//Jacob 5:45
					new VerseInfo(3, 97, 3, 99),//Jacob 5:46
					new VerseInfo(3, 100, 3, 104),//Jacob 5:47
					new VerseInfo(3, 105, 3, 108),//Jacob 5:48
					new VerseInfo(3, 109),//Jacob 5:49
					new VerseInfo(3, 110),//Jacob 5:50
					new VerseInfo(3, 111),//Jacob 5:51
					new VerseInfo(3, 112, 3, 113),//Jacob 5:52
					new VerseInfo(3, 114),//Jacob 5:53
					new VerseInfo(3, 115, 3, 117),//Jacob 5:54
					new VerseInfo(3, 118),//Jacob 5:55
					new VerseInfo(3, 119),//Jacob 5:56
					new VerseInfo(3, 120),//Jacob 5:57
					new VerseInfo(3, 121),//Jacob 5:58
					new VerseInfo(3, 122),//Jacob 5:59
					new VerseInfo(3, 123, 3, 124),//Jacob 5:60
					new VerseInfo(3, 125),//Jacob 5:61
					new VerseInfo(3, 126),//Jacob 5:62
					new VerseInfo(3, 127),//Jacob 5:63
					new VerseInfo(3, 128, 3, 129),//Jacob 5:64
					new VerseInfo(3, 130, 3, 131),//Jacob 5:65
					new VerseInfo(3, 132),//Jacob 5:66
					new VerseInfo(3, 133),//Jacob 5:67
					new VerseInfo(3, 133, 3, 134),//Jacob 5:68
					new VerseInfo(3, 135),//Jacob 5:69
					new VerseInfo(3, 136),//Jacob 5:70
					new VerseInfo(3, 137, 3, 139),//Jacob 5:71
					new VerseInfo(3, 140),//Jacob 5:72
					new VerseInfo(3, 141, 3, 142),//Jacob 5:73
					new VerseInfo(3, 143, 3, 144),//Jacob 5:74
					new VerseInfo(3, 145, 3, 147),//Jacob 5:75
					new VerseInfo(3, 148, 3, 150),//Jacob 5:76
					new VerseInfo(3, 151, 3, 153),//Jacob 5:77
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Jacob 6
					new VerseInfo(4, 1, 4, 2),//Jacob 6:1
					new VerseInfo(4, 3),//Jacob 6:2
					new VerseInfo(4, 4, 4, 5),//Jacob 6:3
					new VerseInfo(4, 6, 4, 7),//Jacob 6:4
					new VerseInfo(4, 8, 4, 9),//Jacob 6:5
					new VerseInfo(4, 10),//Jacob 6:6
					new VerseInfo(4, 11),//Jacob 6:7
					new VerseInfo(4, 12, 4, 13),//Jacob 6:8
					new VerseInfo(4, 14),//Jacob 6:9
					new VerseInfo(4, 15),//Jacob 6:10
					new VerseInfo(4, 16),//Jacob 6:11
					new VerseInfo(4, 17),//Jacob 6:12
					new VerseInfo(4, 18),//Jacob 6:13
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Jacob 7
					new VerseInfo(5, 1),//Jacob 7:1
					new VerseInfo(5, 2, 5, 3),//Jacob 7:2
					new VerseInfo(5, 4, 5, 5),//Jacob 7:3
					new VerseInfo(5, 6),//Jacob 7:4
					new VerseInfo(5, 7, 5, 8),//Jacob 7:5
					new VerseInfo(5, 9),//Jacob 7:6
					new VerseInfo(5, 10, 5, 12),//Jacob 7:7
					new VerseInfo(5, 13),//Jacob 7:8
					new VerseInfo(5, 14, 5, 15),//Jacob 7:9
					new VerseInfo(5, 16, 5, 17),//Jacob 7:10
					new VerseInfo(5, 18, 5, 19),//Jacob 7:11
					new VerseInfo(5, 20, 5, 21),//Jacob 7:12
					new VerseInfo(5, 22),//Jacob 7:13
					new VerseInfo(5, 23, 5, 26),//Jacob 7:14
					new VerseInfo(5, 27, 5, 28),//Jacob 7:15
					new VerseInfo(5, 29),//Jacob 7:16
					new VerseInfo(5, 30),//Jacob 7:17
					new VerseInfo(5, 31, 5, 32),//Jacob 7:18
					new VerseInfo(5, 33, 5, 34),//Jacob 7:19
					new VerseInfo(5, 35),//Jacob 7:20
					new VerseInfo(5, 36),//Jacob 7:21
					new VerseInfo(5, 37),//Jacob 7:22
					new VerseInfo(5, 38),//Jacob 7:23
					new VerseInfo(5, 39, 5, 40),//Jacob 7:24
					new VerseInfo(5, 41),//Jacob 7:25
					new VerseInfo(5, 42, 5, 44),//Jacob 7:26
					new VerseInfo(5, 45, 5, 48),//Jacob 7:27
				},
			}
		},
		{ "Enos", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Enos 1
					new VerseInfo(1, 1, 1, 2),//Enos 1:1
					new VerseInfo(1, 3),//Enos 1:2
					new VerseInfo(1, 4),//Enos 1:3
					new VerseInfo(1, 5, 1, 6),//Enos 1:4
					new VerseInfo(1, 7),//Enos 1:5
					new VerseInfo(1, 8),//Enos 1:6
					new VerseInfo(1, 9),//Enos 1:7
					new VerseInfo(1, 10, 1, 11),//Enos 1:8
					new VerseInfo(1, 12),//Enos 1:9
					new VerseInfo(1, 13, 1, 16),//Enos 1:10
					new VerseInfo(1, 17),//Enos 1:11
					new VerseInfo(1, 18),//Enos 1:12
					new VerseInfo(1, 19, 1, 20),//Enos 1:13
					new VerseInfo(1, 21, 1, 22),//Enos 1:14
					new VerseInfo(1, 23, 1, 24),//Enos 1:15
					new VerseInfo(1, 25, 1, 26),//Enos 1:16
					new VerseInfo(1, 27),//Enos 1:17
					new VerseInfo(1, 28),//Enos 1:18
					new VerseInfo(1, 29),//Enos 1:19
					new VerseInfo(1, 30, 1, 33),//Enos 1:20
					new VerseInfo(1, 34),//Enos 1:21
					new VerseInfo(1, 35, 1, 36),//Enos 1:22
					new VerseInfo(1, 37, 1, 40),//Enos 1:23
					new VerseInfo(1, 41),//Enos 1:24
					new VerseInfo(1, 42),//Enos 1:25
					new VerseInfo(1, 43, 1, 44),//Enos 1:26
					new VerseInfo(1, 45, 1, 46),//Enos 1:27
				},
			}
		},
		{ "Jarom", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Jarom 1
					new VerseInfo(1, 1),//Jarom 1:1
					new VerseInfo(1, 2, 1, 5),//Jarom 1:2
					new VerseInfo(1, 6, 1, 7),//Jarom 1:3
					new VerseInfo(1, 8, 1, 9),//Jarom 1:4
					new VerseInfo(1, 10, 1, 13),//Jarom 1:5
					new VerseInfo(1, 14, 1, 15),//Jarom 1:6
					new VerseInfo(1, 16, 1, 18),//Jarom 1:7
					new VerseInfo(1, 19, 1, 20),//Jarom 1:8
					new VerseInfo(1, 21, 1, 22),//Jarom 1:9
					new VerseInfo(1, 23),//Jarom 1:10
					new VerseInfo(1, 24, 1, 26),//Jarom 1:11
					new VerseInfo(1, 27, 1, 28),//Jarom 1:12
					new VerseInfo(1, 29),//Jarom 1:13
					new VerseInfo(1, 30, 1, 31),//Jarom 1:14
					new VerseInfo(1, 32),//Jarom 1:15
				},
			}
		},
		{ "Omni", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Omni 1
					new VerseInfo(1, 1),//Omni 1:1
					new VerseInfo(1, 2, 1, 3),//Omni 1:2
					new VerseInfo(1, 4, 1, 5),//Omni 1:3
					new VerseInfo(1, 6),//Omni 1:4
					new VerseInfo(1, 7),//Omni 1:5
					new VerseInfo(1, 8),//Omni 1:6
					new VerseInfo(1, 9),//Omni 1:7
					new VerseInfo(1, 10),//Omni 1:8
					new VerseInfo(1, 11, 1, 12),//Omni 1:9
					new VerseInfo(1, 13, 1, 15),//Omni 1:10
					new VerseInfo(1, 16, 1, 17),//Omni 1:11
					new VerseInfo(1, 18, 1, 20),//Omni 1:12
					new VerseInfo(1, 21, 1, 23),//Omni 1:13
					new VerseInfo(1, 24, 1, 25),//Omni 1:14
					new VerseInfo(1, 26),//Omni 1:15
					new VerseInfo(1, 27),//Omni 1:16
					new VerseInfo(1, 28, 1, 31),//Omni 1:17
					new VerseInfo(1, 32, 1, 33),//Omni 1:18
					new VerseInfo(1, 34),//Omni 1:19
					new VerseInfo(1, 35),//Omni 1:20
					new VerseInfo(1, 36, 1, 37),//Omni 1:21
					new VerseInfo(1, 38, 1, 39),//Omni 1:22
					new VerseInfo(1, 40),//Omni 1:23
					new VerseInfo(1, 41, 1, 42),//Omni 1:24
					new VerseInfo(1, 43, 1, 45),//Omni 1:25
					new VerseInfo(1, 46, 1, 47),//Omni 1:26
					new VerseInfo(1, 48, 1, 49),//Omni 1:27
					new VerseInfo(1, 49, 1, 50),//Omni 1:28
					new VerseInfo(1, 51),//Omni 1:29
					new VerseInfo(1, 52, 1, 54),//Omni 1:30
				},
			}
		},
		{ "Words of Mormon", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Words of Mormon 1
					new VerseInfo(1, 1),//Words of Mormon 1:1
					new VerseInfo(1, 2, 1, 3),//Words of Mormon 1:2
					new VerseInfo(1, 4, 1, 5),//Words of Mormon 1:3
					new VerseInfo(1, 6, 1, 7),//Words of Mormon 1:4
					new VerseInfo(1, 8),//Words of Mormon 1:5
					new VerseInfo(1, 9),//Words of Mormon 1:6
					new VerseInfo(1, 10, 1, 11),//Words of Mormon 1:7
					new VerseInfo(1, 12),//Words of Mormon 1:8
					new VerseInfo(1, 13),//Words of Mormon 1:9
					new VerseInfo(1, 14),//Words of Mormon 1:10
					new VerseInfo(1, 15, 1, 17),//Words of Mormon 1:11
					new VerseInfo(1, 18),//Words of Mormon 1:12
					new VerseInfo(1, 19, 1, 20),//Words of Mormon 1:13
					new VerseInfo(1, 21, 1, 22),//Words of Mormon 1:14
					new VerseInfo(1, 23),//Words of Mormon 1:15
					new VerseInfo(1, 24, 1, 25),//Words of Mormon 1:16
					new VerseInfo(1, 25, 1, 26),//Words of Mormon 1:17
					new VerseInfo(1, 27),//Words of Mormon 1:18
				},
			}
		},
		{ "Mosiah", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Mosiah 1
					new VerseInfo(1, 1),//Mosiah 1:1
					new VerseInfo(1, 2, 1, 3),//Mosiah 1:2
					new VerseInfo(1, 4),//Mosiah 1:3
					new VerseInfo(1, 5, 1, 6),//Mosiah 1:4
					new VerseInfo(1, 7, 1, 8),//Mosiah 1:5
					new VerseInfo(1, 9, 1, 10),//Mosiah 1:6
					new VerseInfo(1, 11, 1, 12),//Mosiah 1:7
					new VerseInfo(1, 13),//Mosiah 1:8
					new VerseInfo(1, 14),//Mosiah 1:9
					new VerseInfo(1, 15, 1, 16),//Mosiah 1:10
					new VerseInfo(1, 17),//Mosiah 1:11
					new VerseInfo(1, 18),//Mosiah 1:12
					new VerseInfo(1, 19, 1, 20),//Mosiah 1:13
					new VerseInfo(1, 21),//Mosiah 1:14
					new VerseInfo(1, 22),//Mosiah 1:15
					new VerseInfo(1, 23, 1, 24),//Mosiah 1:16
					new VerseInfo(1, 25, 1, 26),//Mosiah 1:17
					new VerseInfo(1, 27),//Mosiah 1:18
				},
				new VerseInfo?[]
				{
					null,//Mosiah 2
					new VerseInfo(1, 28),//Mosiah 2:1
					new VerseInfo(1, 29),//Mosiah 2:2
					new VerseInfo(1, 30),//Mosiah 2:3
					new VerseInfo(1, 31, 1, 32),//Mosiah 2:4
					new VerseInfo(1, 33),//Mosiah 2:5
					new VerseInfo(1, 34),//Mosiah 2:6
					new VerseInfo(1, 35),//Mosiah 2:7
					new VerseInfo(1, 36, 1, 37),//Mosiah 2:8
					new VerseInfo(1, 38, 1, 39),//Mosiah 2:9
					new VerseInfo(1, 40),//Mosiah 2:10
					new VerseInfo(1, 41, 1, 42),//Mosiah 2:11
					new VerseInfo(1, 43),//Mosiah 2:12
					new VerseInfo(1, 44, 1, 45),//Mosiah 2:13
					new VerseInfo(1, 46),//Mosiah 2:14
					new VerseInfo(1, 47),//Mosiah 2:15
					new VerseInfo(1, 48),//Mosiah 2:16
					new VerseInfo(1, 49),//Mosiah 2:17
					new VerseInfo(1, 50),//Mosiah 2:18
					new VerseInfo(1, 51),//Mosiah 2:19
					new VerseInfo(1, 52),//Mosiah 2:20
					new VerseInfo(1, 53, 1, 54),//Mosiah 2:21
					new VerseInfo(1, 55, 1, 56),//Mosiah 2:22
					new VerseInfo(1, 57),//Mosiah 2:23
					new VerseInfo(1, 58, 1, 59),//Mosiah 2:24
					new VerseInfo(1, 60, 1, 61),//Mosiah 2:25
					new VerseInfo(1, 62, 1, 63),//Mosiah 2:26
					new VerseInfo(1, 64),//Mosiah 2:27
					new VerseInfo(1, 65, 1, 66),//Mosiah 2:28
					new VerseInfo(1, 67),//Mosiah 2:29
					new VerseInfo(1, 68, 1, 69),//Mosiah 2:30
					new VerseInfo(1, 70, 1, 72),//Mosiah 2:31
					new VerseInfo(1, 73),//Mosiah 2:32
					new VerseInfo(1, 74, 1, 75),//Mosiah 2:33
					new VerseInfo(1, 76, 1, 77),//Mosiah 2:34
					new VerseInfo(1, 77, 1, 78),//Mosiah 2:35
					new VerseInfo(1, 79),//Mosiah 2:36
					new VerseInfo(1, 80, 1, 82),//Mosiah 2:37
					new VerseInfo(1, 83, 1, 84),//Mosiah 2:38
					new VerseInfo(1, 85),//Mosiah 2:39
					new VerseInfo(1, 86, 1, 87),//Mosiah 2:40
					new VerseInfo(1, 88, 1, 91),//Mosiah 2:41
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Mosiah 3
					new VerseInfo(1, 92, 1, 93),//Mosiah 3:1
					new VerseInfo(1, 93, 1, 94),//Mosiah 3:2
					new VerseInfo(1, 95),//Mosiah 3:3
					new VerseInfo(1, 96),//Mosiah 3:4
					new VerseInfo(1, 97, 1, 98),//Mosiah 3:5
					new VerseInfo(1, 99),//Mosiah 3:6
					new VerseInfo(1, 100, 1, 101),//Mosiah 3:7
					new VerseInfo(1, 102),//Mosiah 3:8
					new VerseInfo(1, 103, 1, 104),//Mosiah 3:9
					new VerseInfo(1, 105, 1, 106),//Mosiah 3:10
					new VerseInfo(1, 107),//Mosiah 3:11
					new VerseInfo(1, 108),//Mosiah 3:12
					new VerseInfo(1, 109),//Mosiah 3:13
					new VerseInfo(1, 110),//Mosiah 3:14
					new VerseInfo(1, 111, 1, 113),//Mosiah 3:15
					new VerseInfo(1, 114, 1, 115),//Mosiah 3:16
					new VerseInfo(1, 116),//Mosiah 3:17
					new VerseInfo(1, 117, 1, 118),//Mosiah 3:18
					new VerseInfo(1, 119, 1, 120),//Mosiah 3:19
					new VerseInfo(1, 121),//Mosiah 3:20
					new VerseInfo(1, 122),//Mosiah 3:21
					new VerseInfo(1, 123),//Mosiah 3:22
					new VerseInfo(1, 124),//Mosiah 3:23
					new VerseInfo(1, 125, 1, 126),//Mosiah 3:24
					new VerseInfo(1, 127),//Mosiah 3:25
					new VerseInfo(1, 128),//Mosiah 3:26
					new VerseInfo(1, 129, 1, 130),//Mosiah 3:27
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mosiah 4
					new VerseInfo(2, 1),//Mosiah 4:1
					new VerseInfo(2, 2, 2, 4),//Mosiah 4:2
					new VerseInfo(2, 5, 2, 6),//Mosiah 4:3
					new VerseInfo(2, 7),//Mosiah 4:4
					new VerseInfo(2, 8),//Mosiah 4:5
					new VerseInfo(2, 9, 2, 10),//Mosiah 4:6
					new VerseInfo(2, 11),//Mosiah 4:7
					new VerseInfo(2, 11, 2, 12),//Mosiah 4:8
					new VerseInfo(2, 13, 2, 15),//Mosiah 4:9
					new VerseInfo(2, 16, 2, 17),//Mosiah 4:10
					new VerseInfo(2, 18, 2, 21),//Mosiah 4:11
					new VerseInfo(2, 22, 2, 23),//Mosiah 4:12
					new VerseInfo(2, 24),//Mosiah 4:13
					new VerseInfo(2, 25, 2, 26),//Mosiah 4:14
					new VerseInfo(2, 27),//Mosiah 4:15
					new VerseInfo(2, 28, 2, 29),//Mosiah 4:16
					new VerseInfo(2, 30),//Mosiah 4:17
					new VerseInfo(2, 31),//Mosiah 4:18
					new VerseInfo(2, 32),//Mosiah 4:19
					new VerseInfo(2, 33, 2, 35),//Mosiah 4:20
					new VerseInfo(2, 36),//Mosiah 4:21
					new VerseInfo(2, 37, 2, 38),//Mosiah 4:22
					new VerseInfo(2, 39),//Mosiah 4:23
					new VerseInfo(2, 40),//Mosiah 4:24
					new VerseInfo(2, 41),//Mosiah 4:25
					new VerseInfo(2, 42, 2, 43),//Mosiah 4:26
					new VerseInfo(2, 44, 2, 45),//Mosiah 4:27
					new VerseInfo(2, 46, 2, 47),//Mosiah 4:28
					new VerseInfo(2, 48),//Mosiah 4:29
					new VerseInfo(2, 49, 2, 50),//Mosiah 4:30
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mosiah 5
					new VerseInfo(3, 1),//Mosiah 5:1
					new VerseInfo(3, 2, 3, 3),//Mosiah 5:2
					new VerseInfo(3, 4),//Mosiah 5:3
					new VerseInfo(3, 5),//Mosiah 5:4
					new VerseInfo(3, 6),//Mosiah 5:5
					new VerseInfo(3, 7),//Mosiah 5:6
					new VerseInfo(3, 8, 3, 9),//Mosiah 5:7
					new VerseInfo(3, 10, 3, 11),//Mosiah 5:8
					new VerseInfo(3, 12),//Mosiah 5:9
					new VerseInfo(3, 13),//Mosiah 5:10
					new VerseInfo(3, 14, 3, 15),//Mosiah 5:11
					new VerseInfo(3, 16),//Mosiah 5:12
					new VerseInfo(3, 17),//Mosiah 5:13
					new VerseInfo(3, 18, 3, 20),//Mosiah 5:14
					new VerseInfo(3, 21),//Mosiah 5:15
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mosiah 6
					new VerseInfo(4, 1),//Mosiah 6:1
					new VerseInfo(4, 2),//Mosiah 6:2
					new VerseInfo(4, 3, 4, 4),//Mosiah 6:3
					new VerseInfo(4, 5, 4, 6),//Mosiah 6:4
					new VerseInfo(4, 7),//Mosiah 6:5
					new VerseInfo(4, 8),//Mosiah 6:6
					new VerseInfo(4, 9, 4, 11),//Mosiah 6:7
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Mosiah 7
					new VerseInfo(5, 1, 5, 2),//Mosiah 7:1
					new VerseInfo(5, 3),//Mosiah 7:2
					new VerseInfo(5, 4),//Mosiah 7:3
					new VerseInfo(5, 5),//Mosiah 7:4
					new VerseInfo(5, 6),//Mosiah 7:5
					new VerseInfo(5, 7),//Mosiah 7:6
					new VerseInfo(5, 8, 5, 9),//Mosiah 7:7
					new VerseInfo(5, 10, 5, 11),//Mosiah 7:8
					new VerseInfo(5, 12),//Mosiah 7:9
					new VerseInfo(5, 13),//Mosiah 7:10
					new VerseInfo(5, 14),//Mosiah 7:11
					new VerseInfo(5, 15, 5, 16),//Mosiah 7:12
					new VerseInfo(5, 16, 5, 17),//Mosiah 7:13
					new VerseInfo(5, 18, 5, 19),//Mosiah 7:14
					new VerseInfo(5, 20, 5, 22),//Mosiah 7:15
					new VerseInfo(5, 23, 5, 24),//Mosiah 7:16
					new VerseInfo(5, 25),//Mosiah 7:17
					new VerseInfo(5, 26, 5, 27),//Mosiah 7:18
					new VerseInfo(5, 28, 5, 29),//Mosiah 7:19
					new VerseInfo(5, 30, 5, 31),//Mosiah 7:20
					new VerseInfo(5, 32, 5, 33),//Mosiah 7:21
					new VerseInfo(5, 34, 5, 36),//Mosiah 7:22
					new VerseInfo(5, 37, 5, 39),//Mosiah 7:23
					new VerseInfo(5, 40),//Mosiah 7:24
					new VerseInfo(5, 41, 5, 42),//Mosiah 7:25
					new VerseInfo(5, 43),//Mosiah 7:26
					new VerseInfo(5, 44, 5, 45),//Mosiah 7:27
					new VerseInfo(5, 46, 5, 47),//Mosiah 7:28
					new VerseInfo(5, 48),//Mosiah 7:29
					new VerseInfo(5, 49),//Mosiah 7:30
					new VerseInfo(5, 50),//Mosiah 7:31
					new VerseInfo(5, 51),//Mosiah 7:32
					new VerseInfo(5, 52),//Mosiah 7:33
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Mosiah 8
					new VerseInfo(5, 53),//Mosiah 8:1
					new VerseInfo(5, 54),//Mosiah 8:2
					new VerseInfo(5, 55),//Mosiah 8:3
					new VerseInfo(5, 56),//Mosiah 8:4
					new VerseInfo(5, 57),//Mosiah 8:5
					new VerseInfo(5, 58, 5, 59),//Mosiah 8:6
					new VerseInfo(5, 60),//Mosiah 8:7
					new VerseInfo(5, 61, 5, 63),//Mosiah 8:8
					new VerseInfo(5, 64),//Mosiah 8:9
					new VerseInfo(5, 65),//Mosiah 8:10
					new VerseInfo(5, 66, 5, 68),//Mosiah 8:11
					new VerseInfo(5, 69, 5, 71),//Mosiah 8:12
					new VerseInfo(5, 72, 5, 74),//Mosiah 8:13
					new VerseInfo(5, 75),//Mosiah 8:14
					new VerseInfo(5, 76),//Mosiah 8:15
					new VerseInfo(5, 77),//Mosiah 8:16
					new VerseInfo(5, 78, 5, 80),//Mosiah 8:17
					new VerseInfo(5, 81),//Mosiah 8:18
					new VerseInfo(5, 82, 5, 83),//Mosiah 8:19
					new VerseInfo(5, 84, 5, 85),//Mosiah 8:20
					new VerseInfo(5, 86),//Mosiah 8:21
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Mosiah 9
					new VerseInfo(6, 1, 6, 2),//Mosiah 9:1
					new VerseInfo(6, 2, 6, 5),//Mosiah 9:2
					new VerseInfo(6, 6),//Mosiah 9:3
					new VerseInfo(6, 7),//Mosiah 9:4
					new VerseInfo(6, 8),//Mosiah 9:5
					new VerseInfo(6, 9),//Mosiah 9:6
					new VerseInfo(6, 10),//Mosiah 9:7
					new VerseInfo(6, 11),//Mosiah 9:8
					new VerseInfo(6, 12),//Mosiah 9:9
					new VerseInfo(6, 13),//Mosiah 9:10
					new VerseInfo(6, 14),//Mosiah 9:11
					new VerseInfo(6, 15),//Mosiah 9:12
					new VerseInfo(6, 16),//Mosiah 9:13
					new VerseInfo(6, 17),//Mosiah 9:14
					new VerseInfo(6, 18),//Mosiah 9:15
					new VerseInfo(6, 19),//Mosiah 9:16
					new VerseInfo(6, 20, 6, 21),//Mosiah 9:17
					new VerseInfo(6, 22, 6, 23),//Mosiah 9:18
					new VerseInfo(6, 24, 6, 25),//Mosiah 9:19
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Mosiah 10
					new VerseInfo(6, 26, 6, 27),//Mosiah 10:1
					new VerseInfo(6, 28, 6, 29),//Mosiah 10:2
					new VerseInfo(6, 30),//Mosiah 10:3
					new VerseInfo(6, 31),//Mosiah 10:4
					new VerseInfo(6, 32, 6, 33),//Mosiah 10:5
					new VerseInfo(6, 34, 6, 35),//Mosiah 10:6
					new VerseInfo(6, 36),//Mosiah 10:7
					new VerseInfo(6, 37, 6, 38),//Mosiah 10:8
					new VerseInfo(6, 39, 6, 40),//Mosiah 10:9
					new VerseInfo(6, 41, 6, 43),//Mosiah 10:10
					new VerseInfo(6, 44, 6, 45),//Mosiah 10:11
					new VerseInfo(6, 45, 6, 46),//Mosiah 10:12
					new VerseInfo(6, 47, 6, 48),//Mosiah 10:13
					new VerseInfo(6, 49, 6, 50),//Mosiah 10:14
					new VerseInfo(6, 51),//Mosiah 10:15
					new VerseInfo(6, 52),//Mosiah 10:16
					new VerseInfo(6, 53),//Mosiah 10:17
					new VerseInfo(6, 54),//Mosiah 10:18
					new VerseInfo(6, 55),//Mosiah 10:19
					new VerseInfo(6, 56),//Mosiah 10:20
					new VerseInfo(6, 57),//Mosiah 10:21
					new VerseInfo(6, 58),//Mosiah 10:22
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Mosiah 11
					new VerseInfo(7, 1),//Mosiah 11:1
					new VerseInfo(7, 2, 7, 5),//Mosiah 11:2
					new VerseInfo(7, 6),//Mosiah 11:3
					new VerseInfo(7, 7),//Mosiah 11:4
					new VerseInfo(7, 8),//Mosiah 11:5
					new VerseInfo(7, 9),//Mosiah 11:6
					new VerseInfo(7, 10),//Mosiah 11:7
					new VerseInfo(7, 11),//Mosiah 11:8
					new VerseInfo(7, 12),//Mosiah 11:9
					new VerseInfo(7, 13),//Mosiah 11:10
					new VerseInfo(7, 14, 7, 15),//Mosiah 11:11
					new VerseInfo(7, 16),//Mosiah 11:12
					new VerseInfo(7, 17, 7, 19),//Mosiah 11:13
					new VerseInfo(7, 20),//Mosiah 11:14
					new VerseInfo(7, 21),//Mosiah 11:15
					new VerseInfo(7, 22),//Mosiah 11:16
					new VerseInfo(7, 23, 7, 24),//Mosiah 11:17
					new VerseInfo(7, 25),//Mosiah 11:18
					new VerseInfo(7, 26, 7, 27),//Mosiah 11:19
					new VerseInfo(7, 28, 7, 31),//Mosiah 11:20
					new VerseInfo(7, 32, 7, 33),//Mosiah 11:21
					new VerseInfo(7, 34),//Mosiah 11:22
					new VerseInfo(7, 35),//Mosiah 11:23
					new VerseInfo(7, 36),//Mosiah 11:24
					new VerseInfo(7, 37, 7, 38),//Mosiah 11:25
					new VerseInfo(7, 39),//Mosiah 11:26
					new VerseInfo(7, 40, 7, 41),//Mosiah 11:27
					new VerseInfo(7, 42),//Mosiah 11:28
					new VerseInfo(7, 43, 7, 44),//Mosiah 11:29
				},
				new VerseInfo?[]
				{
					null,//Mosiah 12
					new VerseInfo(7, 45, 7, 47),//Mosiah 12:1
					new VerseInfo(7, 47, 7, 49),//Mosiah 12:2
					new VerseInfo(7, 50),//Mosiah 12:3
					new VerseInfo(7, 51),//Mosiah 12:4
					new VerseInfo(7, 52),//Mosiah 12:5
					new VerseInfo(7, 53),//Mosiah 12:6
					new VerseInfo(7, 54),//Mosiah 12:7
					new VerseInfo(7, 55, 7, 58),//Mosiah 12:8
					new VerseInfo(7, 59, 7, 60),//Mosiah 12:9
					new VerseInfo(7, 61),//Mosiah 12:10
					new VerseInfo(7, 62),//Mosiah 12:11
					new VerseInfo(7, 63, 7, 64),//Mosiah 12:12
					new VerseInfo(7, 65),//Mosiah 12:13
					new VerseInfo(7, 66),//Mosiah 12:14
					new VerseInfo(7, 67),//Mosiah 12:15
					new VerseInfo(7, 68),//Mosiah 12:16
					new VerseInfo(7, 69, 7, 70),//Mosiah 12:17
					new VerseInfo(7, 71, 7, 72),//Mosiah 12:18
					new VerseInfo(7, 73, 7, 75),//Mosiah 12:19
					new VerseInfo(7, 76),//Mosiah 12:20
					new VerseInfo(7, 77),//Mosiah 12:21
					new VerseInfo(7, 78),//Mosiah 12:22
					new VerseInfo(7, 79),//Mosiah 12:23
					new VerseInfo(7, 80),//Mosiah 12:24
					new VerseInfo(7, 81),//Mosiah 12:25
					new VerseInfo(7, 82),//Mosiah 12:26
					new VerseInfo(7, 83),//Mosiah 12:27
					new VerseInfo(7, 84),//Mosiah 12:28
					new VerseInfo(7, 85, 7, 87),//Mosiah 12:29
					new VerseInfo(7, 88, 7, 89),//Mosiah 12:30
					new VerseInfo(7, 90, 7, 92),//Mosiah 12:31
					new VerseInfo(7, 93),//Mosiah 12:32
					new VerseInfo(7, 94, 7, 95),//Mosiah 12:33
					new VerseInfo(7, 95),//Mosiah 12:34
					new VerseInfo(7, 96),//Mosiah 12:35
					new VerseInfo(7, 97),//Mosiah 12:36
					new VerseInfo(7, 98, 7, 99),//Mosiah 12:37
				},
				new VerseInfo?[]
				{
					null,//Mosiah 13
					new VerseInfo(7, 100),//Mosiah 13:1
					new VerseInfo(7, 101),//Mosiah 13:2
					new VerseInfo(7, 101, 7, 102),//Mosiah 13:3
					new VerseInfo(7, 103, 7, 104),//Mosiah 13:4
					new VerseInfo(7, 105, 7, 106),//Mosiah 13:5
					new VerseInfo(7, 107),//Mosiah 13:6
					new VerseInfo(7, 107, 7, 108),//Mosiah 13:7
					new VerseInfo(7, 108),//Mosiah 13:8
					new VerseInfo(7, 109),//Mosiah 13:9
					new VerseInfo(7, 110),//Mosiah 13:10
					new VerseInfo(7, 111, 7, 112),//Mosiah 13:11
					new VerseInfo(7, 113),//Mosiah 13:12
					new VerseInfo(7, 114),//Mosiah 13:13
					new VerseInfo(7, 114),//Mosiah 13:14
					new VerseInfo(7, 115),//Mosiah 13:15
					new VerseInfo(7, 116),//Mosiah 13:16
					new VerseInfo(7, 117),//Mosiah 13:17
					new VerseInfo(7, 117),//Mosiah 13:18
					new VerseInfo(7, 118),//Mosiah 13:19
					new VerseInfo(7, 119),//Mosiah 13:20
					new VerseInfo(7, 120),//Mosiah 13:21
					new VerseInfo(7, 121, 7, 122),//Mosiah 13:22
					new VerseInfo(7, 123),//Mosiah 13:23
					new VerseInfo(7, 124),//Mosiah 13:24
					new VerseInfo(8, 1),//Mosiah 13:25
					new VerseInfo(8, 2),//Mosiah 13:26
					new VerseInfo(8, 3, 8, 4),//Mosiah 13:27
					new VerseInfo(8, 5),//Mosiah 13:28
					new VerseInfo(8, 6),//Mosiah 13:29
					new VerseInfo(8, 7),//Mosiah 13:30
					new VerseInfo(8, 8),//Mosiah 13:31
					new VerseInfo(8, 9, 8, 10),//Mosiah 13:32
					new VerseInfo(8, 11, 8, 12),//Mosiah 13:33
					new VerseInfo(8, 13),//Mosiah 13:34
					new VerseInfo(8, 14),//Mosiah 13:35
				},
				new VerseInfo?[]
				{
					null,//Mosiah 14
					new VerseInfo(8, 15, 8, 16),//Mosiah 14:1
					new VerseInfo(8, 17),//Mosiah 14:2
					new VerseInfo(8, 18),//Mosiah 14:3
					new VerseInfo(8, 19),//Mosiah 14:4
					new VerseInfo(8, 20),//Mosiah 14:5
					new VerseInfo(8, 21),//Mosiah 14:6
					new VerseInfo(8, 22),//Mosiah 14:7
					new VerseInfo(8, 23),//Mosiah 14:8
					new VerseInfo(8, 24),//Mosiah 14:9
					new VerseInfo(8, 25),//Mosiah 14:10
					new VerseInfo(8, 26),//Mosiah 14:11
					new VerseInfo(8, 27),//Mosiah 14:12
				},
				new VerseInfo?[]
				{
					null,//Mosiah 15
					new VerseInfo(8, 28),//Mosiah 15:1
					new VerseInfo(8, 29, 8, 30),//Mosiah 15:2
					new VerseInfo(8, 30),//Mosiah 15:3
					new VerseInfo(8, 31),//Mosiah 15:4
					new VerseInfo(8, 32),//Mosiah 15:5
					new VerseInfo(8, 33),//Mosiah 15:6
					new VerseInfo(8, 34),//Mosiah 15:7
					new VerseInfo(8, 35),//Mosiah 15:8
					new VerseInfo(8, 36, 8, 37),//Mosiah 15:9
					new VerseInfo(8, 38, 8, 40),//Mosiah 15:10
					new VerseInfo(8, 41, 8, 43),//Mosiah 15:11
					new VerseInfo(8, 44, 8, 45),//Mosiah 15:12
					new VerseInfo(8, 46, 8, 47),//Mosiah 15:13
					new VerseInfo(8, 47),//Mosiah 15:14
					new VerseInfo(8, 48),//Mosiah 15:15
					new VerseInfo(8, 49),//Mosiah 15:16
					new VerseInfo(8, 50),//Mosiah 15:17
					new VerseInfo(8, 51, 8, 52),//Mosiah 15:18
					new VerseInfo(8, 53),//Mosiah 15:19
					new VerseInfo(8, 54),//Mosiah 15:20
					new VerseInfo(8, 55),//Mosiah 15:21
					new VerseInfo(8, 56),//Mosiah 15:22
					new VerseInfo(8, 57),//Mosiah 15:23
					new VerseInfo(8, 58, 8, 59),//Mosiah 15:24
					new VerseInfo(8, 60),//Mosiah 15:25
					new VerseInfo(8, 61, 8, 62),//Mosiah 15:26
					new VerseInfo(8, 63, 8, 65),//Mosiah 15:27
					new VerseInfo(8, 66),//Mosiah 15:28
					new VerseInfo(8, 67),//Mosiah 15:29
					new VerseInfo(8, 68),//Mosiah 15:30
					new VerseInfo(8, 69),//Mosiah 15:31
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Mosiah 16
					new VerseInfo(8, 70, 8, 71),//Mosiah 16:1
					new VerseInfo(8, 72, 8, 73),//Mosiah 16:2
					new VerseInfo(8, 73, 8, 75),//Mosiah 16:3
					new VerseInfo(8, 76),//Mosiah 16:4
					new VerseInfo(8, 77, 8, 78),//Mosiah 16:5
					new VerseInfo(8, 79),//Mosiah 16:6
					new VerseInfo(8, 80),//Mosiah 16:7
					new VerseInfo(8, 81),//Mosiah 16:8
					new VerseInfo(8, 82),//Mosiah 16:9
					new VerseInfo(8, 83),//Mosiah 16:10
					new VerseInfo(8, 84, 8, 85),//Mosiah 16:11
					new VerseInfo(8, 86, 8, 88),//Mosiah 16:12
					new VerseInfo(8, 89),//Mosiah 16:13
					new VerseInfo(8, 90),//Mosiah 16:14
					new VerseInfo(8, 91),//Mosiah 16:15
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Mosiah 17
					new VerseInfo(9, 1),//Mosiah 17:1
					new VerseInfo(9, 2, 9, 4),//Mosiah 17:2
					new VerseInfo(9, 5),//Mosiah 17:3
					new VerseInfo(9, 6, 9, 7),//Mosiah 17:4
					new VerseInfo(9, 8),//Mosiah 17:5
					new VerseInfo(9, 9),//Mosiah 17:6
					new VerseInfo(9, 10),//Mosiah 17:7
					new VerseInfo(9, 11, 9, 12),//Mosiah 17:8
					new VerseInfo(9, 13, 9, 14),//Mosiah 17:9
					new VerseInfo(9, 15, 9, 16),//Mosiah 17:10
					new VerseInfo(9, 17),//Mosiah 17:11
					new VerseInfo(9, 18, 9, 19),//Mosiah 17:12
					new VerseInfo(9, 20),//Mosiah 17:13
					new VerseInfo(9, 21),//Mosiah 17:14
					new VerseInfo(9, 21),//Mosiah 17:15
					new VerseInfo(9, 22),//Mosiah 17:16
					new VerseInfo(9, 23),//Mosiah 17:17
					new VerseInfo(9, 24),//Mosiah 17:18
					new VerseInfo(9, 25, 9, 26),//Mosiah 17:19
					new VerseInfo(9, 27),//Mosiah 17:20
				},
				new VerseInfo?[]
				{
					null,//Mosiah 18
					new VerseInfo(9, 28),//Mosiah 18:1
					new VerseInfo(9, 29),//Mosiah 18:2
					new VerseInfo(9, 30, 9, 31),//Mosiah 18:3
					new VerseInfo(9, 32),//Mosiah 18:4
					new VerseInfo(9, 33),//Mosiah 18:5
					new VerseInfo(9, 34),//Mosiah 18:6
					new VerseInfo(9, 35, 9, 37),//Mosiah 18:7
					new VerseInfo(9, 38, 9, 39),//Mosiah 18:8
					new VerseInfo(9, 40),//Mosiah 18:9
					new VerseInfo(9, 41),//Mosiah 18:10
					new VerseInfo(9, 42),//Mosiah 18:11
					new VerseInfo(9, 43),//Mosiah 18:12
					new VerseInfo(9, 44),//Mosiah 18:13
					new VerseInfo(9, 45),//Mosiah 18:14
					new VerseInfo(9, 46),//Mosiah 18:15
					new VerseInfo(9, 47, 9, 48),//Mosiah 18:16
					new VerseInfo(9, 49, 9, 50),//Mosiah 18:17
					new VerseInfo(9, 51),//Mosiah 18:18
					new VerseInfo(9, 52),//Mosiah 18:19
					new VerseInfo(9, 53),//Mosiah 18:20
					new VerseInfo(9, 54),//Mosiah 18:21
					new VerseInfo(9, 55),//Mosiah 18:22
					new VerseInfo(9, 56),//Mosiah 18:23
					new VerseInfo(9, 57),//Mosiah 18:24
					new VerseInfo(9, 58),//Mosiah 18:25
					new VerseInfo(9, 59),//Mosiah 18:26
					new VerseInfo(9, 60, 9, 61),//Mosiah 18:27
					new VerseInfo(9, 62),//Mosiah 18:28
					new VerseInfo(9, 63, 9, 64),//Mosiah 18:29
					new VerseInfo(9, 65, 9, 67),//Mosiah 18:30
					new VerseInfo(9, 68),//Mosiah 18:31
					new VerseInfo(9, 69, 9, 70),//Mosiah 18:32
					new VerseInfo(9, 71),//Mosiah 18:33
					new VerseInfo(9, 72),//Mosiah 18:34
					new VerseInfo(9, 73),//Mosiah 18:35
				},
				new VerseInfo?[]
				{
					null,//Mosiah 19
					new VerseInfo(9, 74),//Mosiah 19:1
					new VerseInfo(9, 75),//Mosiah 19:2
					new VerseInfo(9, 76),//Mosiah 19:3
					new VerseInfo(9, 77),//Mosiah 19:4
					new VerseInfo(9, 78),//Mosiah 19:5
					new VerseInfo(9, 79),//Mosiah 19:6
					new VerseInfo(9, 80),//Mosiah 19:7
					new VerseInfo(9, 81),//Mosiah 19:8
					new VerseInfo(9, 82),//Mosiah 19:9
					new VerseInfo(9, 83),//Mosiah 19:10
					new VerseInfo(9, 84),//Mosiah 19:11
					new VerseInfo(9, 85, 9, 86),//Mosiah 19:12
					new VerseInfo(9, 87),//Mosiah 19:13
					new VerseInfo(9, 88),//Mosiah 19:14
					new VerseInfo(9, 89, 9, 90),//Mosiah 19:15
					new VerseInfo(9, 91),//Mosiah 19:16
					new VerseInfo(9, 92),//Mosiah 19:17
					new VerseInfo(9, 93, 9, 94),//Mosiah 19:18
					new VerseInfo(9, 95),//Mosiah 19:19
					new VerseInfo(9, 96),//Mosiah 19:20
					new VerseInfo(9, 97),//Mosiah 19:21
					new VerseInfo(9, 98, 9, 99),//Mosiah 19:22
					new VerseInfo(9, 100),//Mosiah 19:23
					new VerseInfo(9, 101),//Mosiah 19:24
					new VerseInfo(9, 102),//Mosiah 19:25
					new VerseInfo(9, 103),//Mosiah 19:26
					new VerseInfo(9, 104),//Mosiah 19:27
					new VerseInfo(9, 105, 9, 106),//Mosiah 19:28
					new VerseInfo(9, 107),//Mosiah 19:29
				},
				new VerseInfo?[]
				{
					null,//Mosiah 20
					new VerseInfo(9, 108),//Mosiah 20:1
					new VerseInfo(9, 109),//Mosiah 20:2
					new VerseInfo(9, 110),//Mosiah 20:3
					new VerseInfo(9, 111),//Mosiah 20:4
					new VerseInfo(9, 111, 9, 112),//Mosiah 20:5
					new VerseInfo(9, 113),//Mosiah 20:6
					new VerseInfo(9, 114),//Mosiah 20:7
					new VerseInfo(9, 115),//Mosiah 20:8
					new VerseInfo(9, 116),//Mosiah 20:9
					new VerseInfo(9, 117),//Mosiah 20:10
					new VerseInfo(9, 118, 9, 119),//Mosiah 20:11
					new VerseInfo(9, 120),//Mosiah 20:12
					new VerseInfo(9, 121),//Mosiah 20:13
					new VerseInfo(9, 122, 9, 124),//Mosiah 20:14
					new VerseInfo(9, 125),//Mosiah 20:15
					new VerseInfo(9, 126, 9, 127),//Mosiah 20:16
					new VerseInfo(9, 128),//Mosiah 20:17
					new VerseInfo(9, 129, 9, 130),//Mosiah 20:18
					new VerseInfo(9, 131),//Mosiah 20:19
					new VerseInfo(9, 132),//Mosiah 20:20
					new VerseInfo(9, 133),//Mosiah 20:21
					new VerseInfo(9, 134),//Mosiah 20:22
					new VerseInfo(9, 135),//Mosiah 20:23
					new VerseInfo(9, 136),//Mosiah 20:24
					new VerseInfo(9, 137, 9, 138),//Mosiah 20:25
					new VerseInfo(9, 139),//Mosiah 20:26
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Mosiah 21
					new VerseInfo(9, 140),//Mosiah 21:1
					new VerseInfo(9, 141),//Mosiah 21:2
					new VerseInfo(9, 142),//Mosiah 21:3
					new VerseInfo(9, 142),//Mosiah 21:4
					new VerseInfo(9, 143),//Mosiah 21:5
					new VerseInfo(9, 144, 9, 145),//Mosiah 21:6
					new VerseInfo(9, 146),//Mosiah 21:7
					new VerseInfo(9, 147),//Mosiah 21:8
					new VerseInfo(9, 148),//Mosiah 21:9
					new VerseInfo(9, 149),//Mosiah 21:10
					new VerseInfo(9, 150, 9, 151),//Mosiah 21:11
					new VerseInfo(9, 152),//Mosiah 21:12
					new VerseInfo(9, 153),//Mosiah 21:13
					new VerseInfo(9, 154),//Mosiah 21:14
					new VerseInfo(9, 155, 9, 156),//Mosiah 21:15
					new VerseInfo(9, 157),//Mosiah 21:16
					new VerseInfo(9, 158),//Mosiah 21:17
					new VerseInfo(9, 159),//Mosiah 21:18
					new VerseInfo(9, 160),//Mosiah 21:19
					new VerseInfo(9, 161),//Mosiah 21:20
					new VerseInfo(9, 162),//Mosiah 21:21
					new VerseInfo(9, 163),//Mosiah 21:22
					new VerseInfo(9, 164, 9, 165),//Mosiah 21:23
					new VerseInfo(9, 165),//Mosiah 21:24
					new VerseInfo(9, 166),//Mosiah 21:25
					new VerseInfo(9, 167, 9, 168),//Mosiah 21:26
					new VerseInfo(9, 169),//Mosiah 21:27
					new VerseInfo(9, 170),//Mosiah 21:28
					new VerseInfo(9, 171),//Mosiah 21:29
					new VerseInfo(9, 171, 9, 172),//Mosiah 21:30
					new VerseInfo(9, 173, 9, 174),//Mosiah 21:31
					new VerseInfo(9, 175),//Mosiah 21:32
					new VerseInfo(9, 176, 9, 177),//Mosiah 21:33
					new VerseInfo(9, 177, 9, 178),//Mosiah 21:34
					new VerseInfo(9, 179, 9, 180),//Mosiah 21:35
					new VerseInfo(9, 181),//Mosiah 21:36
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mosiah 22
					new VerseInfo(10, 1, 10, 2),//Mosiah 22:1
					new VerseInfo(10, 3, 10, 4),//Mosiah 22:2
					new VerseInfo(10, 5),//Mosiah 22:3
					new VerseInfo(10, 6),//Mosiah 22:4
					new VerseInfo(10, 7, 10, 8),//Mosiah 22:5
					new VerseInfo(10, 8, 10, 9),//Mosiah 22:6
					new VerseInfo(10, 10),//Mosiah 22:7
					new VerseInfo(10, 11),//Mosiah 22:8
					new VerseInfo(10, 12),//Mosiah 22:9
					new VerseInfo(10, 13),//Mosiah 22:10
					new VerseInfo(10, 14),//Mosiah 22:11
					new VerseInfo(10, 15),//Mosiah 22:12
					new VerseInfo(10, 16),//Mosiah 22:13
					new VerseInfo(10, 17),//Mosiah 22:14
					new VerseInfo(10, 18),//Mosiah 22:15
					new VerseInfo(10, 19),//Mosiah 22:16
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Mosiah 23
					new VerseInfo(11, 1),//Mosiah 23:1
					new VerseInfo(11, 2),//Mosiah 23:2
					new VerseInfo(11, 3),//Mosiah 23:3
					new VerseInfo(11, 4),//Mosiah 23:4
					new VerseInfo(11, 5),//Mosiah 23:5
					new VerseInfo(11, 6),//Mosiah 23:6
					new VerseInfo(11, 7),//Mosiah 23:7
					new VerseInfo(11, 8),//Mosiah 23:8
					new VerseInfo(11, 9),//Mosiah 23:9
					new VerseInfo(11, 10),//Mosiah 23:10
					new VerseInfo(11, 11),//Mosiah 23:11
					new VerseInfo(11, 12),//Mosiah 23:12
					new VerseInfo(11, 13, 11, 14),//Mosiah 23:13
					new VerseInfo(11, 15),//Mosiah 23:14
					new VerseInfo(11, 16),//Mosiah 23:15
					new VerseInfo(11, 17),//Mosiah 23:16
					new VerseInfo(11, 18, 11, 19),//Mosiah 23:17
					new VerseInfo(11, 20),//Mosiah 23:18
					new VerseInfo(11, 21),//Mosiah 23:19
					new VerseInfo(11, 22),//Mosiah 23:20
					new VerseInfo(11, 23),//Mosiah 23:21
					new VerseInfo(11, 24, 11, 25),//Mosiah 23:22
					new VerseInfo(11, 26),//Mosiah 23:23
					new VerseInfo(11, 27),//Mosiah 23:24
					new VerseInfo(11, 28),//Mosiah 23:25
					new VerseInfo(11, 29),//Mosiah 23:26
					new VerseInfo(11, 30),//Mosiah 23:27
					new VerseInfo(11, 31),//Mosiah 23:28
					new VerseInfo(11, 32, 11, 33),//Mosiah 23:29
					new VerseInfo(11, 34),//Mosiah 23:30
					new VerseInfo(11, 35),//Mosiah 23:31
					new VerseInfo(11, 36),//Mosiah 23:32
					new VerseInfo(11, 37),//Mosiah 23:33
					new VerseInfo(11, 38),//Mosiah 23:34
					new VerseInfo(11, 39),//Mosiah 23:35
					new VerseInfo(11, 40),//Mosiah 23:36
					new VerseInfo(11, 41),//Mosiah 23:37
					new VerseInfo(11, 42),//Mosiah 23:38
					new VerseInfo(11, 43),//Mosiah 23:39
				},
				new VerseInfo?[]
				{
					null,//Mosiah 24
					new VerseInfo(11, 44, 11, 45),//Mosiah 24:1
					new VerseInfo(11, 46),//Mosiah 24:2
					new VerseInfo(11, 47, 11, 48),//Mosiah 24:3
					new VerseInfo(11, 48, 11, 49),//Mosiah 24:4
					new VerseInfo(11, 50, 11, 51),//Mosiah 24:5
					new VerseInfo(11, 51),//Mosiah 24:6
					new VerseInfo(11, 52, 11, 53),//Mosiah 24:7
					new VerseInfo(11, 54),//Mosiah 24:8
					new VerseInfo(11, 55, 11, 56),//Mosiah 24:9
					new VerseInfo(11, 57),//Mosiah 24:10
					new VerseInfo(11, 58),//Mosiah 24:11
					new VerseInfo(11, 59),//Mosiah 24:12
					new VerseInfo(11, 60),//Mosiah 24:13
					new VerseInfo(11, 61, 11, 62),//Mosiah 24:14
					new VerseInfo(11, 63, 11, 64),//Mosiah 24:15
					new VerseInfo(11, 65),//Mosiah 24:16
					new VerseInfo(11, 66),//Mosiah 24:17
					new VerseInfo(11, 67),//Mosiah 24:18
					new VerseInfo(11, 68),//Mosiah 24:19
					new VerseInfo(11, 69),//Mosiah 24:20
					new VerseInfo(11, 70, 11, 71),//Mosiah 24:21
					new VerseInfo(11, 72),//Mosiah 24:22
					new VerseInfo(11, 73, 11, 74),//Mosiah 24:23
					new VerseInfo(11, 75),//Mosiah 24:24
					new VerseInfo(11, 76),//Mosiah 24:25
				},
				new VerseInfo?[]
				{
					null,//Mosiah 25
					new VerseInfo(11, 77),//Mosiah 25:1
					new VerseInfo(11, 78),//Mosiah 25:2
					new VerseInfo(11, 79),//Mosiah 25:3
					new VerseInfo(11, 80),//Mosiah 25:4
					new VerseInfo(11, 81),//Mosiah 25:5
					new VerseInfo(11, 82),//Mosiah 25:6
					new VerseInfo(11, 83),//Mosiah 25:7
					new VerseInfo(11, 83, 11, 84),//Mosiah 25:8
					new VerseInfo(11, 85),//Mosiah 25:9
					new VerseInfo(11, 86),//Mosiah 25:10
					new VerseInfo(11, 87),//Mosiah 25:11
					new VerseInfo(11, 88, 11, 89),//Mosiah 25:12
					new VerseInfo(11, 90),//Mosiah 25:13
					new VerseInfo(11, 91),//Mosiah 25:14
					new VerseInfo(11, 92),//Mosiah 25:15
					new VerseInfo(11, 93),//Mosiah 25:16
					new VerseInfo(11, 94),//Mosiah 25:17
					new VerseInfo(11, 95, 11, 96),//Mosiah 25:18
					new VerseInfo(11, 97),//Mosiah 25:19
					new VerseInfo(11, 98),//Mosiah 25:20
					new VerseInfo(11, 98, 11, 99),//Mosiah 25:21
					new VerseInfo(11, 100, 11, 101),//Mosiah 25:22
					new VerseInfo(11, 102, 11, 103),//Mosiah 25:23
					new VerseInfo(11, 103, 11, 104),//Mosiah 25:24
				},
				new VerseInfo?[]
				{
					null,//Mosiah 26
					new VerseInfo(11, 105),//Mosiah 26:1
					new VerseInfo(11, 106),//Mosiah 26:2
					new VerseInfo(11, 107),//Mosiah 26:3
					new VerseInfo(11, 108, 11, 109),//Mosiah 26:4
					new VerseInfo(11, 110),//Mosiah 26:5
					new VerseInfo(11, 111, 11, 112),//Mosiah 26:6
					new VerseInfo(11, 113),//Mosiah 26:7
					new VerseInfo(11, 114),//Mosiah 26:8
					new VerseInfo(11, 115),//Mosiah 26:9
					new VerseInfo(11, 116),//Mosiah 26:10
					new VerseInfo(11, 117, 11, 118),//Mosiah 26:11
					new VerseInfo(11, 119),//Mosiah 26:12
					new VerseInfo(11, 120),//Mosiah 26:13
					new VerseInfo(11, 121),//Mosiah 26:14
					new VerseInfo(11, 121, 11, 122),//Mosiah 26:15
					new VerseInfo(11, 123),//Mosiah 26:16
					new VerseInfo(11, 124),//Mosiah 26:17
					new VerseInfo(11, 125),//Mosiah 26:18
					new VerseInfo(11, 126),//Mosiah 26:19
					new VerseInfo(11, 127),//Mosiah 26:20
					new VerseInfo(11, 128),//Mosiah 26:21
					new VerseInfo(11, 129, 11, 130),//Mosiah 26:22
					new VerseInfo(11, 131),//Mosiah 26:23
					new VerseInfo(11, 132),//Mosiah 26:24
					new VerseInfo(11, 133),//Mosiah 26:25
					new VerseInfo(11, 134),//Mosiah 26:26
					new VerseInfo(11, 135),//Mosiah 26:27
					new VerseInfo(11, 136),//Mosiah 26:28
					new VerseInfo(11, 137, 11, 138),//Mosiah 26:29
					new VerseInfo(11, 139),//Mosiah 26:30
					new VerseInfo(11, 140),//Mosiah 26:31
					new VerseInfo(11, 141),//Mosiah 26:32
					new VerseInfo(11, 142),//Mosiah 26:33
					new VerseInfo(11, 143),//Mosiah 26:34
					new VerseInfo(11, 144),//Mosiah 26:35
					new VerseInfo(11, 145),//Mosiah 26:36
					new VerseInfo(11, 146, 11, 147),//Mosiah 26:37
					new VerseInfo(11, 148),//Mosiah 26:38
					new VerseInfo(11, 149),//Mosiah 26:39
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Mosiah 27
					new VerseInfo(11, 150, 11, 151),//Mosiah 27:1
					new VerseInfo(11, 152),//Mosiah 27:2
					new VerseInfo(11, 153),//Mosiah 27:3
					new VerseInfo(11, 153, 11, 154),//Mosiah 27:4
					new VerseInfo(11, 155),//Mosiah 27:5
					new VerseInfo(11, 156, 11, 157),//Mosiah 27:6
					new VerseInfo(11, 158),//Mosiah 27:7
					new VerseInfo(11, 159, 11, 160),//Mosiah 27:8
					new VerseInfo(11, 161),//Mosiah 27:9
					new VerseInfo(11, 162),//Mosiah 27:10
					new VerseInfo(11, 163),//Mosiah 27:11
					new VerseInfo(11, 164),//Mosiah 27:12
					new VerseInfo(11, 165, 11, 166),//Mosiah 27:13
					new VerseInfo(11, 167, 11, 169),//Mosiah 27:14
					new VerseInfo(11, 170, 11, 173),//Mosiah 27:15
					new VerseInfo(11, 174, 11, 175),//Mosiah 27:16
					new VerseInfo(11, 176),//Mosiah 27:17
					new VerseInfo(11, 177, 11, 178),//Mosiah 27:18
					new VerseInfo(11, 179, 11, 180),//Mosiah 27:19
					new VerseInfo(11, 181),//Mosiah 27:20
					new VerseInfo(11, 182),//Mosiah 27:21
					new VerseInfo(11, 183, 11, 184),//Mosiah 27:22
					new VerseInfo(11, 185),//Mosiah 27:23
					new VerseInfo(11, 186),//Mosiah 27:24
					new VerseInfo(11, 187, 11, 188),//Mosiah 27:25
					new VerseInfo(11, 188),//Mosiah 27:26
					new VerseInfo(11, 189),//Mosiah 27:27
					new VerseInfo(11, 190),//Mosiah 27:28
					new VerseInfo(11, 191, 11, 193),//Mosiah 27:29
					new VerseInfo(11, 194, 11, 196),//Mosiah 27:30
					new VerseInfo(11, 196, 11, 199),//Mosiah 27:31
					new VerseInfo(11, 200, 11, 201),//Mosiah 27:32
					new VerseInfo(11, 202),//Mosiah 27:33
					new VerseInfo(11, 203),//Mosiah 27:34
					new VerseInfo(11, 204, 11, 205),//Mosiah 27:35
					new VerseInfo(11, 206),//Mosiah 27:36
					new VerseInfo(11, 207),//Mosiah 27:37
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Mosiah 28
					new VerseInfo(12, 1, 12, 2),//Mosiah 28:1
					new VerseInfo(12, 2, 12, 4),//Mosiah 28:2
					new VerseInfo(12, 5, 12, 6),//Mosiah 28:3
					new VerseInfo(12, 7, 12, 8),//Mosiah 28:4
					new VerseInfo(12, 9),//Mosiah 28:5
					new VerseInfo(12, 10),//Mosiah 28:6
					new VerseInfo(12, 11),//Mosiah 28:7
					new VerseInfo(12, 12),//Mosiah 28:8
					new VerseInfo(12, 13),//Mosiah 28:9
					new VerseInfo(12, 14),//Mosiah 28:10
					new VerseInfo(12, 15, 12, 16),//Mosiah 28:11
					new VerseInfo(12, 17),//Mosiah 28:12
					new VerseInfo(12, 18),//Mosiah 28:13
					new VerseInfo(12, 19),//Mosiah 28:14
					new VerseInfo(12, 20),//Mosiah 28:15
					new VerseInfo(12, 21),//Mosiah 28:16
					new VerseInfo(12, 22, 12, 23),//Mosiah 28:17
					new VerseInfo(12, 24, 12, 25),//Mosiah 28:18
					new VerseInfo(12, 26),//Mosiah 28:19
					new VerseInfo(13, 1, 13, 2),//Mosiah 28:20
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Mosiah 29
					new VerseInfo(13, 3),//Mosiah 29:1
					new VerseInfo(13, 4),//Mosiah 29:2
					new VerseInfo(13, 5, 13, 6),//Mosiah 29:3
					new VerseInfo(13, 6, 13, 7),//Mosiah 29:4
					new VerseInfo(13, 7),//Mosiah 29:5
					new VerseInfo(13, 8),//Mosiah 29:6
					new VerseInfo(13, 9, 13, 10),//Mosiah 29:7
					new VerseInfo(13, 11),//Mosiah 29:8
					new VerseInfo(13, 12),//Mosiah 29:9
					new VerseInfo(13, 13),//Mosiah 29:10
					new VerseInfo(13, 14, 13, 15),//Mosiah 29:11
					new VerseInfo(13, 16),//Mosiah 29:12
					new VerseInfo(13, 17),//Mosiah 29:13
					new VerseInfo(13, 18, 13, 19),//Mosiah 29:14
					new VerseInfo(13, 20),//Mosiah 29:15
					new VerseInfo(13, 21),//Mosiah 29:16
					new VerseInfo(13, 22),//Mosiah 29:17
					new VerseInfo(13, 23, 13, 24),//Mosiah 29:18
					new VerseInfo(13, 25),//Mosiah 29:19
					new VerseInfo(13, 26, 13, 27),//Mosiah 29:20
					new VerseInfo(13, 28),//Mosiah 29:21
					new VerseInfo(13, 29),//Mosiah 29:22
					new VerseInfo(13, 30, 13, 32),//Mosiah 29:23
					new VerseInfo(13, 33),//Mosiah 29:24
					new VerseInfo(13, 34),//Mosiah 29:25
					new VerseInfo(13, 35, 13, 36),//Mosiah 29:26
					new VerseInfo(13, 37, 13, 38),//Mosiah 29:27
					new VerseInfo(13, 39),//Mosiah 29:28
					new VerseInfo(13, 40),//Mosiah 29:29
					new VerseInfo(13, 41, 13, 42),//Mosiah 29:30
					new VerseInfo(13, 43),//Mosiah 29:31
					new VerseInfo(13, 44, 13, 46),//Mosiah 29:32
					new VerseInfo(13, 47, 13, 48),//Mosiah 29:33
					new VerseInfo(13, 49),//Mosiah 29:34
					new VerseInfo(13, 50),//Mosiah 29:35
					new VerseInfo(13, 51, 13, 52),//Mosiah 29:36
					new VerseInfo(13, 53),//Mosiah 29:37
					new VerseInfo(13, 54, 13, 55),//Mosiah 29:38
					new VerseInfo(13, 56, 13, 57),//Mosiah 29:39
					new VerseInfo(13, 58, 13, 61),//Mosiah 29:40
					new VerseInfo(13, 62),//Mosiah 29:41
					new VerseInfo(13, 63),//Mosiah 29:42
					new VerseInfo(13, 64),//Mosiah 29:43
					new VerseInfo(13, 65),//Mosiah 29:44
					new VerseInfo(13, 66),//Mosiah 29:45
					new VerseInfo(13, 67),//Mosiah 29:46
					new VerseInfo(13, 68),//Mosiah 29:47
				},
			}
		},
		{ "Alma", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 1
					new VerseInfo(1, 1, 1, 2),//Alma 1:1
					new VerseInfo(1, 3),//Alma 1:2
					new VerseInfo(1, 4, 1, 5),//Alma 1:3
					new VerseInfo(1, 6, 1, 7),//Alma 1:4
					new VerseInfo(1, 8),//Alma 1:5
					new VerseInfo(1, 9),//Alma 1:6
					new VerseInfo(1, 10, 1, 11),//Alma 1:7
					new VerseInfo(1, 12),//Alma 1:8
					new VerseInfo(1, 13, 1, 14),//Alma 1:9
					new VerseInfo(1, 15),//Alma 1:10
					new VerseInfo(1, 16),//Alma 1:11
					new VerseInfo(1, 17, 1, 18),//Alma 1:12
					new VerseInfo(1, 19),//Alma 1:13
					new VerseInfo(1, 20, 1, 21),//Alma 1:14
					new VerseInfo(1, 22, 1, 23),//Alma 1:15
					new VerseInfo(1, 24),//Alma 1:16
					new VerseInfo(1, 25, 1, 26),//Alma 1:17
					new VerseInfo(1, 27),//Alma 1:18
					new VerseInfo(1, 28),//Alma 1:19
					new VerseInfo(1, 29, 1, 30),//Alma 1:20
					new VerseInfo(1, 31),//Alma 1:21
					new VerseInfo(1, 32),//Alma 1:22
					new VerseInfo(1, 33),//Alma 1:23
					new VerseInfo(1, 34, 1, 35),//Alma 1:24
					new VerseInfo(1, 36),//Alma 1:25
					new VerseInfo(1, 37, 1, 39),//Alma 1:26
					new VerseInfo(1, 40, 1, 41),//Alma 1:27
					new VerseInfo(1, 42),//Alma 1:28
					new VerseInfo(1, 43, 1, 44),//Alma 1:29
					new VerseInfo(1, 45, 1, 46),//Alma 1:30
					new VerseInfo(1, 47),//Alma 1:31
					new VerseInfo(1, 48, 1, 50),//Alma 1:32
					new VerseInfo(1, 51, 1, 52),//Alma 1:33
				},
				new VerseInfo?[]
				{
					null,//Alma 2
					new VerseInfo(1, 53),//Alma 2:1
					new VerseInfo(1, 54),//Alma 2:2
					new VerseInfo(1, 55, 1, 56),//Alma 2:3
					new VerseInfo(1, 57),//Alma 2:4
					new VerseInfo(1, 58),//Alma 2:5
					new VerseInfo(1, 59),//Alma 2:6
					new VerseInfo(1, 60),//Alma 2:7
					new VerseInfo(1, 61),//Alma 2:8
					new VerseInfo(1, 62),//Alma 2:9
					new VerseInfo(1, 63),//Alma 2:10
					new VerseInfo(1, 64),//Alma 2:11
					new VerseInfo(1, 65, 1, 66),//Alma 2:12
					new VerseInfo(1, 67, 1, 68),//Alma 2:13
					new VerseInfo(1, 69),//Alma 2:14
					new VerseInfo(1, 70),//Alma 2:15
					new VerseInfo(1, 71),//Alma 2:16
					new VerseInfo(1, 71, 1, 72),//Alma 2:17
					new VerseInfo(1, 73),//Alma 2:18
					new VerseInfo(1, 74, 1, 75),//Alma 2:19
					new VerseInfo(1, 76),//Alma 2:20
					new VerseInfo(1, 77),//Alma 2:21
					new VerseInfo(1, 78),//Alma 2:22
					new VerseInfo(1, 79),//Alma 2:23
					new VerseInfo(1, 80, 1, 81),//Alma 2:24
					new VerseInfo(1, 81, 1, 82),//Alma 2:25
					new VerseInfo(1, 83),//Alma 2:26
					new VerseInfo(1, 84),//Alma 2:27
					new VerseInfo(1, 85, 1, 86),//Alma 2:28
					new VerseInfo(1, 87),//Alma 2:29
					new VerseInfo(1, 88),//Alma 2:30
					new VerseInfo(1, 89),//Alma 2:31
					new VerseInfo(1, 90),//Alma 2:32
					new VerseInfo(1, 91),//Alma 2:33
					new VerseInfo(1, 92),//Alma 2:34
					new VerseInfo(1, 93),//Alma 2:35
					new VerseInfo(1, 94, 1, 95),//Alma 2:36
					new VerseInfo(1, 95, 1, 96),//Alma 2:37
					new VerseInfo(1, 97),//Alma 2:38
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 3
					new VerseInfo(1, 98),//Alma 3:1
					new VerseInfo(1, 99, 1, 100),//Alma 3:2
					new VerseInfo(1, 101),//Alma 3:3
					new VerseInfo(1, 102),//Alma 3:4
					new VerseInfo(1, 103),//Alma 3:5
					new VerseInfo(1, 104),//Alma 3:6
					new VerseInfo(1, 105),//Alma 3:7
					new VerseInfo(1, 106),//Alma 3:8
					new VerseInfo(1, 107),//Alma 3:9
					new VerseInfo(1, 108),//Alma 3:10
					new VerseInfo(1, 109),//Alma 3:11
					new VerseInfo(1, 110),//Alma 3:12
					new VerseInfo(1, 111),//Alma 3:13
					new VerseInfo(1, 112, 1, 113),//Alma 3:14
					new VerseInfo(1, 114),//Alma 3:15
					new VerseInfo(1, 115),//Alma 3:16
					new VerseInfo(1, 116),//Alma 3:17
					new VerseInfo(1, 117, 1, 118),//Alma 3:18
					new VerseInfo(1, 119, 1, 120),//Alma 3:19
					new VerseInfo(1, 121),//Alma 3:20
					new VerseInfo(1, 122),//Alma 3:21
					new VerseInfo(1, 123),//Alma 3:22
					new VerseInfo(1, 123, 1, 124),//Alma 3:23
					new VerseInfo(1, 125),//Alma 3:24
					new VerseInfo(1, 126),//Alma 3:25
					new VerseInfo(1, 127, 1, 128),//Alma 3:26
					new VerseInfo(1, 129, 1, 130),//Alma 3:27
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 4
					new VerseInfo(2, 1),//Alma 4:1
					new VerseInfo(2, 2),//Alma 4:2
					new VerseInfo(2, 3),//Alma 4:3
					new VerseInfo(2, 4, 2, 5),//Alma 4:4
					new VerseInfo(2, 6, 2, 7),//Alma 4:5
					new VerseInfo(2, 8, 2, 10),//Alma 4:6
					new VerseInfo(2, 11, 2, 12),//Alma 4:7
					new VerseInfo(2, 13, 2, 14),//Alma 4:8
					new VerseInfo(2, 15, 2, 16),//Alma 4:9
					new VerseInfo(2, 17),//Alma 4:10
					new VerseInfo(2, 18),//Alma 4:11
					new VerseInfo(2, 19),//Alma 4:12
					new VerseInfo(2, 20),//Alma 4:13
					new VerseInfo(2, 20, 2, 21),//Alma 4:14
					new VerseInfo(2, 22),//Alma 4:15
					new VerseInfo(2, 23),//Alma 4:16
					new VerseInfo(2, 24),//Alma 4:17
					new VerseInfo(2, 25),//Alma 4:18
					new VerseInfo(2, 26, 2, 27),//Alma 4:19
					new VerseInfo(2, 28),//Alma 4:20
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 5
					new VerseInfo(3, 1),//Alma 5:1
					new VerseInfo(3, 2),//Alma 5:2
					new VerseInfo(3, 3, 3, 4),//Alma 5:3
					new VerseInfo(3, 5),//Alma 5:4
					new VerseInfo(3, 6, 3, 7),//Alma 5:5
					new VerseInfo(3, 8, 3, 10),//Alma 5:6
					new VerseInfo(3, 11, 3, 13),//Alma 5:7
					new VerseInfo(3, 14, 3, 15),//Alma 5:8
					new VerseInfo(3, 16, 3, 18),//Alma 5:9
					new VerseInfo(3, 19, 3, 20),//Alma 5:10
					new VerseInfo(3, 21, 3, 22),//Alma 5:11
					new VerseInfo(3, 23, 3, 24),//Alma 5:12
					new VerseInfo(3, 25, 3, 26),//Alma 5:13
					new VerseInfo(3, 27, 3, 29),//Alma 5:14
					new VerseInfo(3, 30, 3, 31),//Alma 5:15
					new VerseInfo(3, 32),//Alma 5:16
					new VerseInfo(3, 33),//Alma 5:17
					new VerseInfo(3, 34, 3, 35),//Alma 5:18
					new VerseInfo(3, 36, 3, 37),//Alma 5:19
					new VerseInfo(3, 38),//Alma 5:20
					new VerseInfo(3, 39, 3, 40),//Alma 5:21
					new VerseInfo(3, 41, 3, 42),//Alma 5:22
					new VerseInfo(3, 43),//Alma 5:23
					new VerseInfo(3, 44),//Alma 5:24
					new VerseInfo(3, 45),//Alma 5:25
					new VerseInfo(3, 46),//Alma 5:26
					new VerseInfo(3, 47, 3, 49),//Alma 5:27
					new VerseInfo(3, 50, 3, 51),//Alma 5:28
					new VerseInfo(3, 52, 3, 53),//Alma 5:29
					new VerseInfo(3, 54),//Alma 5:30
					new VerseInfo(3, 55),//Alma 5:31
					new VerseInfo(3, 56),//Alma 5:32
					new VerseInfo(3, 57),//Alma 5:33
					new VerseInfo(3, 58),//Alma 5:34
					new VerseInfo(3, 59),//Alma 5:35
					new VerseInfo(3, 60),//Alma 5:36
					new VerseInfo(3, 61),//Alma 5:37
					new VerseInfo(3, 62, 3, 63),//Alma 5:38
					new VerseInfo(3, 64, 3, 66),//Alma 5:39
					new VerseInfo(3, 67),//Alma 5:40
					new VerseInfo(3, 68, 3, 69),//Alma 5:41
					new VerseInfo(3, 70),//Alma 5:42
					new VerseInfo(3, 71, 3, 72),//Alma 5:43
					new VerseInfo(3, 73, 3, 74),//Alma 5:44
					new VerseInfo(3, 75, 3, 77),//Alma 5:45
					new VerseInfo(3, 78, 3, 80),//Alma 5:46
					new VerseInfo(3, 81, 3, 82),//Alma 5:47
					new VerseInfo(3, 82, 3, 84),//Alma 5:48
					new VerseInfo(3, 85, 3, 86),//Alma 5:49
					new VerseInfo(3, 87, 3, 88),//Alma 5:50
					new VerseInfo(3, 89),//Alma 5:51
					new VerseInfo(3, 90, 3, 91),//Alma 5:52
					new VerseInfo(3, 92, 3, 93),//Alma 5:53
					new VerseInfo(3, 94, 3, 95),//Alma 5:54
					new VerseInfo(3, 96),//Alma 5:55
					new VerseInfo(3, 97),//Alma 5:56
					new VerseInfo(3, 98, 3, 99),//Alma 5:57
					new VerseInfo(3, 100, 3, 102),//Alma 5:58
					new VerseInfo(3, 103, 3, 104),//Alma 5:59
					new VerseInfo(3, 105, 3, 106),//Alma 5:60
					new VerseInfo(3, 107),//Alma 5:61
					new VerseInfo(3, 108),//Alma 5:62
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 6
					new VerseInfo(4, 1),//Alma 6:1
					new VerseInfo(4, 2),//Alma 6:2
					new VerseInfo(4, 3, 4, 4),//Alma 6:3
					new VerseInfo(4, 4),//Alma 6:4
					new VerseInfo(4, 5),//Alma 6:5
					new VerseInfo(4, 6),//Alma 6:6
					new VerseInfo(4, 7, 4, 8),//Alma 6:7
					new VerseInfo(4, 9, 4, 10),//Alma 6:8
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 7
					new VerseInfo(5, 1, 5, 2),//Alma 7:1
					new VerseInfo(5, 3),//Alma 7:2
					new VerseInfo(5, 4, 5, 5),//Alma 7:3
					new VerseInfo(5, 6),//Alma 7:4
					new VerseInfo(5, 7, 5, 9),//Alma 7:5
					new VerseInfo(5, 10, 5, 12),//Alma 7:6
					new VerseInfo(5, 13, 5, 14),//Alma 7:7
					new VerseInfo(5, 15, 5, 16),//Alma 7:8
					new VerseInfo(5, 17, 5, 18),//Alma 7:9
					new VerseInfo(5, 19),//Alma 7:10
					new VerseInfo(5, 20, 5, 21),//Alma 7:11
					new VerseInfo(5, 21, 5, 22),//Alma 7:12
					new VerseInfo(5, 23),//Alma 7:13
					new VerseInfo(5, 24, 5, 25),//Alma 7:14
					new VerseInfo(5, 26, 5, 27),//Alma 7:15
					new VerseInfo(5, 28),//Alma 7:16
					new VerseInfo(5, 29, 5, 31),//Alma 7:17
					new VerseInfo(5, 32),//Alma 7:18
					new VerseInfo(5, 33, 5, 34),//Alma 7:19
					new VerseInfo(5, 34, 5, 35),//Alma 7:20
					new VerseInfo(5, 36, 5, 37),//Alma 7:21
					new VerseInfo(5, 38),//Alma 7:22
					new VerseInfo(5, 39, 5, 40),//Alma 7:23
					new VerseInfo(5, 41),//Alma 7:24
					new VerseInfo(5, 42),//Alma 7:25
					new VerseInfo(5, 43),//Alma 7:26
					new VerseInfo(5, 44),//Alma 7:27
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 8
					new VerseInfo(6, 1, 6, 2),//Alma 8:1
					new VerseInfo(6, 3),//Alma 8:2
					new VerseInfo(6, 4),//Alma 8:3
					new VerseInfo(6, 5),//Alma 8:4
					new VerseInfo(6, 6, 6, 7),//Alma 8:5
					new VerseInfo(6, 7),//Alma 8:6
					new VerseInfo(6, 8),//Alma 8:7
					new VerseInfo(6, 9),//Alma 8:8
					new VerseInfo(6, 10),//Alma 8:9
					new VerseInfo(6, 11),//Alma 8:10
					new VerseInfo(6, 12, 6, 13),//Alma 8:11
					new VerseInfo(6, 14, 6, 15),//Alma 8:12
					new VerseInfo(6, 16),//Alma 8:13
					new VerseInfo(6, 17, 6, 18),//Alma 8:14
					new VerseInfo(6, 18, 6, 20),//Alma 8:15
					new VerseInfo(6, 20, 6, 21),//Alma 8:16
					new VerseInfo(6, 22),//Alma 8:17
					new VerseInfo(6, 23, 6, 24),//Alma 8:18
					new VerseInfo(6, 25),//Alma 8:19
					new VerseInfo(6, 26, 6, 27),//Alma 8:20
					new VerseInfo(6, 28),//Alma 8:21
					new VerseInfo(6, 29),//Alma 8:22
					new VerseInfo(6, 30),//Alma 8:23
					new VerseInfo(6, 31, 6, 32),//Alma 8:24
					new VerseInfo(6, 33),//Alma 8:25
					new VerseInfo(6, 34),//Alma 8:26
					new VerseInfo(6, 35),//Alma 8:27
					new VerseInfo(6, 36),//Alma 8:28
					new VerseInfo(6, 37),//Alma 8:29
					new VerseInfo(6, 38),//Alma 8:30
					new VerseInfo(6, 39, 6, 41),//Alma 8:31
					new VerseInfo(6, 42),//Alma 8:32
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 9
					new VerseInfo(7, 1),//Alma 9:1
					new VerseInfo(7, 1, 7, 2),//Alma 9:2
					new VerseInfo(7, 3),//Alma 9:3
					new VerseInfo(7, 4),//Alma 9:4
					new VerseInfo(7, 5),//Alma 9:5
					new VerseInfo(7, 6),//Alma 9:6
					new VerseInfo(7, 7, 7, 8),//Alma 9:7
					new VerseInfo(7, 8),//Alma 9:8
					new VerseInfo(7, 9, 7, 10),//Alma 9:9
					new VerseInfo(7, 11),//Alma 9:10
					new VerseInfo(7, 12),//Alma 9:11
					new VerseInfo(7, 13, 7, 14),//Alma 9:12
					new VerseInfo(7, 15, 7, 16),//Alma 9:13
					new VerseInfo(7, 17, 7, 18),//Alma 9:14
					new VerseInfo(7, 19, 7, 20),//Alma 9:15
					new VerseInfo(7, 20, 7, 21),//Alma 9:16
					new VerseInfo(7, 22, 7, 23),//Alma 9:17
					new VerseInfo(7, 24, 7, 26),//Alma 9:18
					new VerseInfo(7, 26, 7, 27),//Alma 9:19
					new VerseInfo(7, 28, 7, 29),//Alma 9:20
					new VerseInfo(7, 30, 7, 31),//Alma 9:21
					new VerseInfo(7, 32, 7, 34),//Alma 9:22
					new VerseInfo(7, 35, 7, 36),//Alma 9:23
					new VerseInfo(7, 37, 7, 38),//Alma 9:24
					new VerseInfo(7, 39),//Alma 9:25
					new VerseInfo(7, 40),//Alma 9:26
					new VerseInfo(7, 41),//Alma 9:27
					new VerseInfo(7, 42, 7, 44),//Alma 9:28
					new VerseInfo(7, 45),//Alma 9:29
					new VerseInfo(7, 46),//Alma 9:30
					new VerseInfo(7, 47),//Alma 9:31
					new VerseInfo(7, 48),//Alma 9:32
					new VerseInfo(7, 49),//Alma 9:33
					new VerseInfo(7, 50, 7, 51),//Alma 9:34
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 10
					new VerseInfo(8, 1),//Alma 10:1
					new VerseInfo(8, 1, 8, 2),//Alma 10:2
					new VerseInfo(8, 3),//Alma 10:3
					new VerseInfo(8, 4, 8, 5),//Alma 10:4
					new VerseInfo(8, 6, 8, 7),//Alma 10:5
					new VerseInfo(8, 8, 8, 9),//Alma 10:6
					new VerseInfo(8, 10, 8, 11),//Alma 10:7
					new VerseInfo(8, 12, 8, 13),//Alma 10:8
					new VerseInfo(8, 14),//Alma 10:9
					new VerseInfo(8, 15),//Alma 10:10
					new VerseInfo(8, 16, 8, 17),//Alma 10:11
					new VerseInfo(8, 18),//Alma 10:12
					new VerseInfo(8, 19, 8, 20),//Alma 10:13
					new VerseInfo(8, 21),//Alma 10:14
					new VerseInfo(8, 22),//Alma 10:15
					new VerseInfo(8, 23),//Alma 10:16
					new VerseInfo(8, 24, 8, 26),//Alma 10:17
					new VerseInfo(8, 26),//Alma 10:18
					new VerseInfo(8, 27, 8, 28),//Alma 10:19
					new VerseInfo(8, 29),//Alma 10:20
					new VerseInfo(8, 30),//Alma 10:21
					new VerseInfo(8, 31, 8, 32),//Alma 10:22
					new VerseInfo(8, 33, 8, 34),//Alma 10:23
					new VerseInfo(8, 35),//Alma 10:24
					new VerseInfo(8, 36, 8, 37),//Alma 10:25
					new VerseInfo(8, 38, 8, 39),//Alma 10:26
					new VerseInfo(8, 40),//Alma 10:27
					new VerseInfo(8, 41, 8, 42),//Alma 10:28
					new VerseInfo(8, 43),//Alma 10:29
					new VerseInfo(8, 44),//Alma 10:30
					new VerseInfo(8, 45, 8, 46),//Alma 10:31
					new VerseInfo(8, 47),//Alma 10:32
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 11
					new VerseInfo(8, 48),//Alma 11:1
					new VerseInfo(8, 49, 8, 51),//Alma 11:2
					new VerseInfo(8, 52),//Alma 11:3
					new VerseInfo(8, 53, 8, 55),//Alma 11:4
					new VerseInfo(8, 56),//Alma 11:5
					new VerseInfo(8, 57),//Alma 11:6
					new VerseInfo(8, 58),//Alma 11:7
					new VerseInfo(8, 59),//Alma 11:8
					new VerseInfo(8, 59),//Alma 11:9
					new VerseInfo(8, 59),//Alma 11:10
					new VerseInfo(8, 60),//Alma 11:11
					new VerseInfo(8, 60),//Alma 11:12
					new VerseInfo(8, 60),//Alma 11:13
					new VerseInfo(8, 61),//Alma 11:14
					new VerseInfo(8, 61),//Alma 11:15
					new VerseInfo(8, 61),//Alma 11:16
					new VerseInfo(8, 61),//Alma 11:17
					new VerseInfo(8, 62),//Alma 11:18
					new VerseInfo(8, 63),//Alma 11:19
					new VerseInfo(8, 64, 8, 66),//Alma 11:20
					new VerseInfo(8, 67, 8, 68),//Alma 11:21
					new VerseInfo(8, 69, 8, 70),//Alma 11:22
					new VerseInfo(8, 71, 8, 72),//Alma 11:23
					new VerseInfo(8, 73, 8, 74),//Alma 11:24
					new VerseInfo(8, 75, 8, 78),//Alma 11:25
					new VerseInfo(8, 79),//Alma 11:26
					new VerseInfo(8, 80),//Alma 11:27
					new VerseInfo(8, 81),//Alma 11:28
					new VerseInfo(8, 82),//Alma 11:29
					new VerseInfo(8, 83),//Alma 11:30
					new VerseInfo(8, 84),//Alma 11:31
					new VerseInfo(8, 85),//Alma 11:32
					new VerseInfo(8, 86),//Alma 11:33
					new VerseInfo(8, 87, 8, 88),//Alma 11:34
					new VerseInfo(8, 89),//Alma 11:35
					new VerseInfo(8, 90),//Alma 11:36
					new VerseInfo(8, 91, 8, 92),//Alma 11:37
					new VerseInfo(8, 93),//Alma 11:38
					new VerseInfo(8, 94, 8, 95),//Alma 11:39
					new VerseInfo(8, 96),//Alma 11:40
					new VerseInfo(8, 97, 8, 98),//Alma 11:41
					new VerseInfo(8, 99),//Alma 11:42
					new VerseInfo(8, 100, 8, 101),//Alma 11:43
					new VerseInfo(8, 102, 8, 104),//Alma 11:44
					new VerseInfo(8, 105, 8, 107),//Alma 11:45
					new VerseInfo(8, 108, 8, 109),//Alma 11:46
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 12
					new VerseInfo(9, 1),//Alma 12:1
					new VerseInfo(9, 2),//Alma 12:2
					new VerseInfo(9, 3, 9, 4),//Alma 12:3
					new VerseInfo(9, 5),//Alma 12:4
					new VerseInfo(9, 6, 9, 7),//Alma 12:5
					new VerseInfo(9, 8, 9, 9),//Alma 12:6
					new VerseInfo(9, 10, 9, 12),//Alma 12:7
					new VerseInfo(9, 13, 9, 14),//Alma 12:8
					new VerseInfo(9, 15, 9, 16),//Alma 12:9
					new VerseInfo(9, 17, 9, 18),//Alma 12:10
					new VerseInfo(9, 19, 9, 21),//Alma 12:11
					new VerseInfo(9, 21),//Alma 12:12
					new VerseInfo(9, 22),//Alma 12:13
					new VerseInfo(9, 23, 9, 25),//Alma 12:14
					new VerseInfo(9, 26, 9, 27),//Alma 12:15
					new VerseInfo(9, 28, 9, 29),//Alma 12:16
					new VerseInfo(9, 30, 9, 31),//Alma 12:17
					new VerseInfo(9, 32),//Alma 12:18
					new VerseInfo(9, 33),//Alma 12:19
					new VerseInfo(9, 34),//Alma 12:20
					new VerseInfo(9, 35, 9, 36),//Alma 12:21
					new VerseInfo(9, 37, 9, 38),//Alma 12:22
					new VerseInfo(9, 39),//Alma 12:23
					new VerseInfo(9, 40, 9, 41),//Alma 12:24
					new VerseInfo(9, 42, 9, 43),//Alma 12:25
					new VerseInfo(9, 44, 9, 45),//Alma 12:26
					new VerseInfo(9, 46),//Alma 12:27
					new VerseInfo(9, 47),//Alma 12:28
					new VerseInfo(9, 48),//Alma 12:29
					new VerseInfo(9, 49, 9, 50),//Alma 12:30
					new VerseInfo(9, 51),//Alma 12:31
					new VerseInfo(9, 52, 9, 53),//Alma 12:32
					new VerseInfo(9, 54),//Alma 12:33
					new VerseInfo(9, 55),//Alma 12:34
					new VerseInfo(9, 56),//Alma 12:35
					new VerseInfo(9, 57, 9, 59),//Alma 12:36
					new VerseInfo(9, 60, 9, 61),//Alma 12:37
				},
				new VerseInfo?[]
				{
					null,//Alma 13
					new VerseInfo(9, 62, 9, 63),//Alma 13:1
					new VerseInfo(9, 64),//Alma 13:2
					new VerseInfo(9, 65, 9, 66),//Alma 13:3
					new VerseInfo(9, 67),//Alma 13:4
					new VerseInfo(9, 68),//Alma 13:5
					new VerseInfo(9, 69),//Alma 13:6
					new VerseInfo(9, 70, 9, 71),//Alma 13:7
					new VerseInfo(9, 72),//Alma 13:8
					new VerseInfo(9, 73),//Alma 13:9
					new VerseInfo(10, 1, 10, 2),//Alma 13:10
					new VerseInfo(10, 3),//Alma 13:11
					new VerseInfo(10, 4, 10, 5),//Alma 13:12
					new VerseInfo(10, 6),//Alma 13:13
					new VerseInfo(10, 7),//Alma 13:14
					new VerseInfo(10, 8),//Alma 13:15
					new VerseInfo(10, 9, 10, 10),//Alma 13:16
					new VerseInfo(10, 11),//Alma 13:17
					new VerseInfo(10, 12, 10, 14),//Alma 13:18
					new VerseInfo(10, 15),//Alma 13:19
					new VerseInfo(10, 16, 10, 17),//Alma 13:20
					new VerseInfo(10, 18),//Alma 13:21
					new VerseInfo(10, 19, 10, 20),//Alma 13:22
					new VerseInfo(10, 21, 10, 22),//Alma 13:23
					new VerseInfo(10, 23),//Alma 13:24
					new VerseInfo(10, 24, 10, 25),//Alma 13:25
					new VerseInfo(10, 26),//Alma 13:26
					new VerseInfo(10, 27),//Alma 13:27
					new VerseInfo(10, 28),//Alma 13:28
					new VerseInfo(10, 28, 10, 29),//Alma 13:29
					new VerseInfo(10, 30),//Alma 13:30
					new VerseInfo(10, 31),//Alma 13:31
				},
				new VerseInfo?[]
				{
					null,//Alma 14
					new VerseInfo(10, 32),//Alma 14:1
					new VerseInfo(10, 33, 10, 34),//Alma 14:2
					new VerseInfo(10, 35),//Alma 14:3
					new VerseInfo(10, 36),//Alma 14:4
					new VerseInfo(10, 37, 10, 39),//Alma 14:5
					new VerseInfo(10, 40, 10, 41),//Alma 14:6
					new VerseInfo(10, 42, 10, 44),//Alma 14:7
					new VerseInfo(10, 45, 10, 46),//Alma 14:8
					new VerseInfo(10, 47),//Alma 14:9
					new VerseInfo(10, 48, 10, 49),//Alma 14:10
					new VerseInfo(10, 50, 10, 52),//Alma 14:11
					new VerseInfo(10, 53),//Alma 14:12
					new VerseInfo(10, 54),//Alma 14:13
					new VerseInfo(10, 55, 10, 56),//Alma 14:14
					new VerseInfo(10, 57, 10, 58),//Alma 14:15
					new VerseInfo(10, 59),//Alma 14:16
					new VerseInfo(10, 60),//Alma 14:17
					new VerseInfo(10, 61, 10, 62),//Alma 14:18
					new VerseInfo(10, 63, 10, 65),//Alma 14:19
					new VerseInfo(10, 66, 10, 68),//Alma 14:20
					new VerseInfo(10, 69),//Alma 14:21
					new VerseInfo(10, 70, 10, 72),//Alma 14:22
					new VerseInfo(10, 73),//Alma 14:23
					new VerseInfo(10, 74),//Alma 14:24
					new VerseInfo(10, 75, 10, 76),//Alma 14:25
					new VerseInfo(10, 76, 10, 77),//Alma 14:26
					new VerseInfo(10, 78, 10, 80),//Alma 14:27
					new VerseInfo(10, 81, 10, 83),//Alma 14:28
					new VerseInfo(10, 84, 10, 85),//Alma 14:29
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 15
					new VerseInfo(10, 86, 10, 87),//Alma 15:1
					new VerseInfo(10, 88),//Alma 15:2
					new VerseInfo(10, 89, 10, 90),//Alma 15:3
					new VerseInfo(10, 91),//Alma 15:4
					new VerseInfo(10, 92, 10, 94),//Alma 15:5
					new VerseInfo(10, 95),//Alma 15:6
					new VerseInfo(10, 96),//Alma 15:7
					new VerseInfo(10, 97),//Alma 15:8
					new VerseInfo(10, 98),//Alma 15:9
					new VerseInfo(10, 99),//Alma 15:10
					new VerseInfo(10, 100, 10, 101),//Alma 15:11
					new VerseInfo(10, 102),//Alma 15:12
					new VerseInfo(10, 103),//Alma 15:13
					new VerseInfo(10, 104),//Alma 15:14
					new VerseInfo(10, 105, 10, 106),//Alma 15:15
					new VerseInfo(10, 107),//Alma 15:16
					new VerseInfo(10, 108, 10, 109),//Alma 15:17
					new VerseInfo(10, 110),//Alma 15:18
					new VerseInfo(10, 111),//Alma 15:19
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 16
					new VerseInfo(11, 1),//Alma 16:1
					new VerseInfo(11, 2),//Alma 16:2
					new VerseInfo(11, 3),//Alma 16:3
					new VerseInfo(11, 4),//Alma 16:4
					new VerseInfo(11, 5, 11, 7),//Alma 16:5
					new VerseInfo(11, 8, 11, 10),//Alma 16:6
					new VerseInfo(11, 11),//Alma 16:7
					new VerseInfo(11, 12, 11, 13),//Alma 16:8
					new VerseInfo(11, 14, 11, 15),//Alma 16:9
					new VerseInfo(11, 16),//Alma 16:10
					new VerseInfo(11, 17, 11, 19),//Alma 16:11
					new VerseInfo(11, 20, 11, 21),//Alma 16:12
					new VerseInfo(11, 22),//Alma 16:13
					new VerseInfo(11, 23),//Alma 16:14
					new VerseInfo(11, 24, 11, 25),//Alma 16:15
					new VerseInfo(11, 26),//Alma 16:16
					new VerseInfo(11, 27, 11, 28),//Alma 16:17
					new VerseInfo(11, 29),//Alma 16:18
					new VerseInfo(11, 30),//Alma 16:19
					new VerseInfo(11, 31),//Alma 16:20
					new VerseInfo(11, 32, 11, 33),//Alma 16:21
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 17
					new VerseInfo(12, 1),//Alma 17:1
					new VerseInfo(12, 2, 12, 4),//Alma 17:2
					new VerseInfo(12, 5),//Alma 17:3
					new VerseInfo(12, 6, 12, 7),//Alma 17:4
					new VerseInfo(12, 8, 12, 9),//Alma 17:5
					new VerseInfo(12, 10),//Alma 17:6
					new VerseInfo(12, 11, 12, 12),//Alma 17:7
					new VerseInfo(12, 13),//Alma 17:8
					new VerseInfo(12, 14, 12, 16),//Alma 17:9
					new VerseInfo(12, 17),//Alma 17:10
					new VerseInfo(12, 18, 12, 19),//Alma 17:11
					new VerseInfo(12, 20),//Alma 17:12
					new VerseInfo(12, 21),//Alma 17:13
					new VerseInfo(12, 22, 12, 24),//Alma 17:14
					new VerseInfo(12, 25),//Alma 17:15
					new VerseInfo(12, 26),//Alma 17:16
					new VerseInfo(12, 27),//Alma 17:17
					new VerseInfo(12, 28),//Alma 17:18
					new VerseInfo(12, 29),//Alma 17:19
					new VerseInfo(12, 30, 12, 31),//Alma 17:20
					new VerseInfo(12, 32),//Alma 17:21
					new VerseInfo(12, 33),//Alma 17:22
					new VerseInfo(12, 34),//Alma 17:23
					new VerseInfo(12, 35),//Alma 17:24
					new VerseInfo(12, 36, 12, 37),//Alma 17:25
					new VerseInfo(12, 38),//Alma 17:26
					new VerseInfo(12, 39),//Alma 17:27
					new VerseInfo(12, 40, 12, 41),//Alma 17:28
					new VerseInfo(12, 42, 12, 43),//Alma 17:29
					new VerseInfo(12, 44),//Alma 17:30
					new VerseInfo(12, 45, 12, 46),//Alma 17:31
					new VerseInfo(12, 47),//Alma 17:32
					new VerseInfo(12, 48),//Alma 17:33
					new VerseInfo(12, 49, 12, 50),//Alma 17:34
					new VerseInfo(12, 50, 12, 51),//Alma 17:35
					new VerseInfo(12, 52, 12, 55),//Alma 17:36
					new VerseInfo(12, 56, 12, 58),//Alma 17:37
					new VerseInfo(12, 59),//Alma 17:38
					new VerseInfo(12, 60, 12, 61),//Alma 17:39
				},
				new VerseInfo?[]
				{
					null,//Alma 18
					new VerseInfo(12, 62),//Alma 18:1
					new VerseInfo(12, 63, 12, 64),//Alma 18:2
					new VerseInfo(12, 65, 12, 67),//Alma 18:3
					new VerseInfo(12, 68, 12, 69),//Alma 18:4
					new VerseInfo(12, 70, 12, 72),//Alma 18:5
					new VerseInfo(12, 73),//Alma 18:6
					new VerseInfo(12, 74),//Alma 18:7
					new VerseInfo(12, 75),//Alma 18:8
					new VerseInfo(12, 76, 12, 78),//Alma 18:9
					new VerseInfo(12, 79, 12, 80),//Alma 18:10
					new VerseInfo(12, 81),//Alma 18:11
					new VerseInfo(12, 82),//Alma 18:12
					new VerseInfo(12, 83, 12, 84),//Alma 18:13
					new VerseInfo(12, 85, 12, 86),//Alma 18:14
					new VerseInfo(12, 87),//Alma 18:15
					new VerseInfo(12, 88, 12, 89),//Alma 18:16
					new VerseInfo(12, 90, 12, 91),//Alma 18:17
					new VerseInfo(12, 92, 12, 93),//Alma 18:18
					new VerseInfo(12, 94),//Alma 18:19
					new VerseInfo(12, 95, 12, 96),//Alma 18:20
					new VerseInfo(12, 97, 12, 98),//Alma 18:21
					new VerseInfo(12, 99),//Alma 18:22
					new VerseInfo(12, 100),//Alma 18:23
					new VerseInfo(12, 101),//Alma 18:24
					new VerseInfo(12, 102),//Alma 18:25
					new VerseInfo(12, 103),//Alma 18:26
					new VerseInfo(12, 104),//Alma 18:27
					new VerseInfo(12, 105, 12, 106),//Alma 18:28
					new VerseInfo(12, 107),//Alma 18:29
					new VerseInfo(12, 108),//Alma 18:30
					new VerseInfo(12, 109),//Alma 18:31
					new VerseInfo(12, 110),//Alma 18:32
					new VerseInfo(12, 111),//Alma 18:33
					new VerseInfo(12, 112),//Alma 18:34
					new VerseInfo(12, 113),//Alma 18:35
					new VerseInfo(12, 114, 12, 115),//Alma 18:36
					new VerseInfo(12, 116),//Alma 18:37
					new VerseInfo(12, 117, 12, 118),//Alma 18:38
					new VerseInfo(12, 119, 12, 120),//Alma 18:39
					new VerseInfo(12, 121),//Alma 18:40
					new VerseInfo(12, 122),//Alma 18:41
					new VerseInfo(12, 123),//Alma 18:42
					new VerseInfo(12, 124, 12, 125),//Alma 18:43
				},
				new VerseInfo?[]
				{
					null,//Alma 19
					new VerseInfo(12, 126),//Alma 19:1
					new VerseInfo(12, 127),//Alma 19:2
					new VerseInfo(12, 128),//Alma 19:3
					new VerseInfo(12, 129),//Alma 19:4
					new VerseInfo(12, 130, 12, 131),//Alma 19:5
					new VerseInfo(12, 132, 12, 135),//Alma 19:6
					new VerseInfo(12, 135, 12, 136),//Alma 19:7
					new VerseInfo(12, 137),//Alma 19:8
					new VerseInfo(12, 138, 12, 139),//Alma 19:9
					new VerseInfo(12, 140),//Alma 19:10
					new VerseInfo(12, 141),//Alma 19:11
					new VerseInfo(12, 142),//Alma 19:12
					new VerseInfo(12, 143, 12, 144),//Alma 19:13
					new VerseInfo(12, 145, 12, 147),//Alma 19:14
					new VerseInfo(12, 148, 12, 149),//Alma 19:15
					new VerseInfo(12, 150),//Alma 19:16
					new VerseInfo(12, 150, 12, 153),//Alma 19:17
					new VerseInfo(12, 153, 12, 155),//Alma 19:18
					new VerseInfo(12, 156),//Alma 19:19
					new VerseInfo(12, 157),//Alma 19:20
					new VerseInfo(12, 158, 12, 159),//Alma 19:21
					new VerseInfo(12, 160),//Alma 19:22
					new VerseInfo(12, 161),//Alma 19:23
					new VerseInfo(12, 162, 12, 163),//Alma 19:24
					new VerseInfo(12, 164),//Alma 19:25
					new VerseInfo(12, 165),//Alma 19:26
					new VerseInfo(12, 166, 12, 167),//Alma 19:27
					new VerseInfo(12, 167, 12, 168),//Alma 19:28
					new VerseInfo(12, 169, 12, 170),//Alma 19:29
					new VerseInfo(12, 171, 12, 172),//Alma 19:30
					new VerseInfo(12, 173),//Alma 19:31
					new VerseInfo(12, 174),//Alma 19:32
					new VerseInfo(12, 175, 12, 176),//Alma 19:33
					new VerseInfo(12, 177),//Alma 19:34
					new VerseInfo(12, 178),//Alma 19:35
					new VerseInfo(12, 179, 12, 180),//Alma 19:36
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 20
					new VerseInfo(12, 181),//Alma 20:1
					new VerseInfo(12, 182),//Alma 20:2
					new VerseInfo(12, 183),//Alma 20:3
					new VerseInfo(12, 184, 12, 186),//Alma 20:4
					new VerseInfo(12, 187),//Alma 20:5
					new VerseInfo(12, 188),//Alma 20:6
					new VerseInfo(12, 189),//Alma 20:7
					new VerseInfo(12, 190),//Alma 20:8
					new VerseInfo(12, 191),//Alma 20:9
					new VerseInfo(12, 192),//Alma 20:10
					new VerseInfo(12, 193),//Alma 20:11
					new VerseInfo(12, 194),//Alma 20:12
					new VerseInfo(12, 195, 12, 196),//Alma 20:13
					new VerseInfo(12, 197, 12, 198),//Alma 20:14
					new VerseInfo(12, 199),//Alma 20:15
					new VerseInfo(12, 200),//Alma 20:16
					new VerseInfo(12, 201, 12, 202),//Alma 20:17
					new VerseInfo(12, 203),//Alma 20:18
					new VerseInfo(12, 204),//Alma 20:19
					new VerseInfo(12, 204, 12, 205),//Alma 20:20
					new VerseInfo(12, 206),//Alma 20:21
					new VerseInfo(12, 207),//Alma 20:22
					new VerseInfo(12, 208),//Alma 20:23
					new VerseInfo(12, 209),//Alma 20:24
					new VerseInfo(12, 210),//Alma 20:25
					new VerseInfo(12, 211, 12, 212),//Alma 20:26
					new VerseInfo(12, 213, 12, 214),//Alma 20:27
					new VerseInfo(12, 215, 12, 216),//Alma 20:28
					new VerseInfo(12, 217, 12, 218),//Alma 20:29
					new VerseInfo(12, 219, 12, 221),//Alma 20:30
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 21
					new VerseInfo(13, 1),//Alma 21:1
					new VerseInfo(13, 2),//Alma 21:2
					new VerseInfo(13, 3),//Alma 21:3
					new VerseInfo(13, 4, 13, 5),//Alma 21:4
					new VerseInfo(13, 6, 13, 7),//Alma 21:5
					new VerseInfo(13, 7, 13, 9),//Alma 21:6
					new VerseInfo(13, 10),//Alma 21:7
					new VerseInfo(13, 11, 13, 12),//Alma 21:8
					new VerseInfo(13, 13),//Alma 21:9
					new VerseInfo(13, 14),//Alma 21:10
					new VerseInfo(13, 15),//Alma 21:11
					new VerseInfo(13, 16, 13, 17),//Alma 21:12
					new VerseInfo(13, 18),//Alma 21:13
					new VerseInfo(13, 19),//Alma 21:14
					new VerseInfo(13, 20),//Alma 21:15
					new VerseInfo(13, 21),//Alma 21:16
					new VerseInfo(13, 22),//Alma 21:17
					new VerseInfo(13, 23),//Alma 21:18
					new VerseInfo(13, 24),//Alma 21:19
					new VerseInfo(13, 24),//Alma 21:20
					new VerseInfo(13, 25, 13, 26),//Alma 21:21
					new VerseInfo(13, 27),//Alma 21:22
					new VerseInfo(13, 28, 13, 29),//Alma 21:23
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 22
					new VerseInfo(13, 30, 13, 31),//Alma 22:1
					new VerseInfo(13, 32),//Alma 22:2
					new VerseInfo(13, 32, 13, 34),//Alma 22:3
					new VerseInfo(13, 35),//Alma 22:4
					new VerseInfo(13, 36),//Alma 22:5
					new VerseInfo(13, 37),//Alma 22:6
					new VerseInfo(13, 38, 13, 39),//Alma 22:7
					new VerseInfo(13, 40),//Alma 22:8
					new VerseInfo(13, 41),//Alma 22:9
					new VerseInfo(13, 42),//Alma 22:10
					new VerseInfo(13, 43),//Alma 22:11
					new VerseInfo(13, 44),//Alma 22:12
					new VerseInfo(13, 45),//Alma 22:13
					new VerseInfo(13, 46, 13, 47),//Alma 22:14
					new VerseInfo(13, 48, 13, 50),//Alma 22:15
					new VerseInfo(13, 51),//Alma 22:16
					new VerseInfo(13, 52),//Alma 22:17
					new VerseInfo(13, 52, 13, 54),//Alma 22:18
					new VerseInfo(13, 55, 13, 56),//Alma 22:19
					new VerseInfo(13, 57, 13, 58),//Alma 22:20
					new VerseInfo(13, 59, 13, 60),//Alma 22:21
					new VerseInfo(13, 61, 13, 62),//Alma 22:22
					new VerseInfo(13, 63, 13, 64),//Alma 22:23
					new VerseInfo(13, 65),//Alma 22:24
					new VerseInfo(13, 66),//Alma 22:25
					new VerseInfo(13, 67),//Alma 22:26
					new VerseInfo(13, 68, 13, 69),//Alma 22:27
					new VerseInfo(13, 70, 13, 71),//Alma 22:28
					new VerseInfo(13, 72, 13, 73),//Alma 22:29
					new VerseInfo(13, 74),//Alma 22:30
					new VerseInfo(13, 74, 13, 75),//Alma 22:31
					new VerseInfo(13, 76, 13, 77),//Alma 22:32
					new VerseInfo(13, 78, 13, 79),//Alma 22:33
					new VerseInfo(13, 80, 13, 81),//Alma 22:34
					new VerseInfo(13, 82),//Alma 22:35
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 23
					new VerseInfo(14, 1),//Alma 23:1
					new VerseInfo(14, 2, 14, 3),//Alma 23:2
					new VerseInfo(14, 4, 14, 6),//Alma 23:3
					new VerseInfo(14, 7, 14, 8),//Alma 23:4
					new VerseInfo(14, 9),//Alma 23:5
					new VerseInfo(14, 10, 14, 11),//Alma 23:6
					new VerseInfo(14, 11, 14, 12),//Alma 23:7
					new VerseInfo(14, 13),//Alma 23:8
					new VerseInfo(14, 13),//Alma 23:9
					new VerseInfo(14, 13),//Alma 23:10
					new VerseInfo(14, 13),//Alma 23:11
					new VerseInfo(14, 13),//Alma 23:12
					new VerseInfo(14, 14),//Alma 23:13
					new VerseInfo(14, 15),//Alma 23:14
					new VerseInfo(14, 16),//Alma 23:15
					new VerseInfo(14, 17, 14, 18),//Alma 23:16
					new VerseInfo(14, 19),//Alma 23:17
					new VerseInfo(14, 20),//Alma 23:18
				},
				new VerseInfo?[]
				{
					null,//Alma 24
					new VerseInfo(14, 21),//Alma 24:1
					new VerseInfo(14, 22),//Alma 24:2
					new VerseInfo(14, 23),//Alma 24:3
					new VerseInfo(14, 24),//Alma 24:4
					new VerseInfo(14, 25, 14, 26),//Alma 24:5
					new VerseInfo(14, 27, 14, 28),//Alma 24:6
					new VerseInfo(14, 29),//Alma 24:7
					new VerseInfo(14, 30),//Alma 24:8
					new VerseInfo(14, 31),//Alma 24:9
					new VerseInfo(14, 32),//Alma 24:10
					new VerseInfo(14, 33),//Alma 24:11
					new VerseInfo(14, 34),//Alma 24:12
					new VerseInfo(14, 35, 14, 36),//Alma 24:13
					new VerseInfo(14, 37, 14, 38),//Alma 24:14
					new VerseInfo(14, 38, 14, 40),//Alma 24:15
					new VerseInfo(14, 41),//Alma 24:16
					new VerseInfo(14, 42),//Alma 24:17
					new VerseInfo(14, 43, 14, 45),//Alma 24:18
					new VerseInfo(14, 46, 14, 47),//Alma 24:19
					new VerseInfo(14, 48),//Alma 24:20
					new VerseInfo(14, 49, 14, 50),//Alma 24:21
					new VerseInfo(14, 50),//Alma 24:22
					new VerseInfo(14, 51),//Alma 24:23
					new VerseInfo(14, 51, 14, 52),//Alma 24:24
					new VerseInfo(14, 53),//Alma 24:25
					new VerseInfo(14, 54),//Alma 24:26
					new VerseInfo(14, 55),//Alma 24:27
					new VerseInfo(14, 56),//Alma 24:28
					new VerseInfo(14, 57),//Alma 24:29
					new VerseInfo(14, 58),//Alma 24:30
				},
				new VerseInfo?[]
				{
					null,//Alma 25
					new VerseInfo(14, 59, 14, 60),//Alma 25:1
					new VerseInfo(14, 60),//Alma 25:2
					new VerseInfo(14, 61),//Alma 25:3
					new VerseInfo(14, 62),//Alma 25:4
					new VerseInfo(14, 63),//Alma 25:5
					new VerseInfo(14, 64, 14, 65),//Alma 25:6
					new VerseInfo(14, 66),//Alma 25:7
					new VerseInfo(14, 67),//Alma 25:8
					new VerseInfo(14, 68),//Alma 25:9
					new VerseInfo(14, 69),//Alma 25:10
					new VerseInfo(14, 70),//Alma 25:11
					new VerseInfo(14, 71, 14, 72),//Alma 25:12
					new VerseInfo(14, 73),//Alma 25:13
					new VerseInfo(14, 74),//Alma 25:14
					new VerseInfo(14, 74, 14, 75),//Alma 25:15
					new VerseInfo(14, 76, 14, 77),//Alma 25:16
					new VerseInfo(14, 78),//Alma 25:17
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 26
					new VerseInfo(14, 79),//Alma 26:1
					new VerseInfo(14, 80),//Alma 26:2
					new VerseInfo(14, 81, 14, 82),//Alma 26:3
					new VerseInfo(14, 83),//Alma 26:4
					new VerseInfo(14, 84, 14, 85),//Alma 26:5
					new VerseInfo(14, 85, 14, 86),//Alma 26:6
					new VerseInfo(14, 87),//Alma 26:7
					new VerseInfo(14, 88),//Alma 26:8
					new VerseInfo(14, 89),//Alma 26:9
					new VerseInfo(14, 90),//Alma 26:10
					new VerseInfo(14, 91),//Alma 26:11
					new VerseInfo(14, 92),//Alma 26:12
					new VerseInfo(14, 93),//Alma 26:13
					new VerseInfo(14, 94),//Alma 26:14
					new VerseInfo(14, 95, 14, 96),//Alma 26:15
					new VerseInfo(14, 96, 14, 97),//Alma 26:16
					new VerseInfo(14, 98),//Alma 26:17
					new VerseInfo(14, 99),//Alma 26:18
					new VerseInfo(14, 99),//Alma 26:19
					new VerseInfo(14, 100, 14, 101),//Alma 26:20
					new VerseInfo(14, 102),//Alma 26:21
					new VerseInfo(14, 103, 14, 104),//Alma 26:22
					new VerseInfo(14, 105),//Alma 26:23
					new VerseInfo(14, 106, 14, 108),//Alma 26:24
					new VerseInfo(14, 109),//Alma 26:25
					new VerseInfo(14, 110),//Alma 26:26
					new VerseInfo(14, 111),//Alma 26:27
					new VerseInfo(14, 112),//Alma 26:28
					new VerseInfo(14, 113, 14, 114),//Alma 26:29
					new VerseInfo(14, 115),//Alma 26:30
					new VerseInfo(14, 116, 14, 117),//Alma 26:31
					new VerseInfo(14, 118),//Alma 26:32
					new VerseInfo(14, 119, 14, 120),//Alma 26:33
					new VerseInfo(14, 121, 14, 122),//Alma 26:34
					new VerseInfo(14, 123, 14, 124),//Alma 26:35
					new VerseInfo(14, 125, 14, 126),//Alma 26:36
					new VerseInfo(14, 127, 14, 128),//Alma 26:37
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 27
					new VerseInfo(15, 1),//Alma 27:1
					new VerseInfo(15, 2, 15, 3),//Alma 27:2
					new VerseInfo(15, 4),//Alma 27:3
					new VerseInfo(15, 5, 15, 6),//Alma 27:4
					new VerseInfo(15, 6),//Alma 27:5
					new VerseInfo(15, 7),//Alma 27:6
					new VerseInfo(15, 8),//Alma 27:7
					new VerseInfo(15, 9),//Alma 27:8
					new VerseInfo(15, 10),//Alma 27:9
					new VerseInfo(15, 11),//Alma 27:10
					new VerseInfo(15, 12),//Alma 27:11
					new VerseInfo(15, 12),//Alma 27:12
					new VerseInfo(15, 13),//Alma 27:13
					new VerseInfo(15, 14),//Alma 27:14
					new VerseInfo(15, 15),//Alma 27:15
					new VerseInfo(15, 16),//Alma 27:16
					new VerseInfo(15, 17),//Alma 27:17
					new VerseInfo(15, 18),//Alma 27:18
					new VerseInfo(15, 19),//Alma 27:19
					new VerseInfo(15, 20, 15, 21),//Alma 27:20
					new VerseInfo(15, 22),//Alma 27:21
					new VerseInfo(15, 23),//Alma 27:22
					new VerseInfo(15, 24, 15, 25),//Alma 27:23
					new VerseInfo(15, 26),//Alma 27:24
					new VerseInfo(15, 27, 15, 28),//Alma 27:25
					new VerseInfo(15, 28, 15, 30),//Alma 27:26
					new VerseInfo(15, 30, 15, 31),//Alma 27:27
					new VerseInfo(15, 32, 15, 33),//Alma 27:28
					new VerseInfo(15, 34),//Alma 27:29
					new VerseInfo(15, 35),//Alma 27:30
				},
				new VerseInfo?[]
				{
					null,//Alma 28
					new VerseInfo(15, 36),//Alma 28:1
					new VerseInfo(15, 37),//Alma 28:2
					new VerseInfo(15, 38),//Alma 28:3
					new VerseInfo(15, 39),//Alma 28:4
					new VerseInfo(15, 40, 15, 41),//Alma 28:5
					new VerseInfo(15, 42),//Alma 28:6
					new VerseInfo(15, 42),//Alma 28:7
					new VerseInfo(15, 43, 15, 44),//Alma 28:8
					new VerseInfo(15, 45),//Alma 28:9
					new VerseInfo(15, 46),//Alma 28:10
					new VerseInfo(15, 47, 15, 48),//Alma 28:11
					new VerseInfo(15, 49),//Alma 28:12
					new VerseInfo(15, 50),//Alma 28:13
					new VerseInfo(15, 51),//Alma 28:14
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 29
					new VerseInfo(15, 52),//Alma 29:1
					new VerseInfo(15, 53),//Alma 29:2
					new VerseInfo(15, 54),//Alma 29:3
					new VerseInfo(15, 55),//Alma 29:4
					new VerseInfo(15, 56),//Alma 29:5
					new VerseInfo(15, 57),//Alma 29:6
					new VerseInfo(15, 58),//Alma 29:7
					new VerseInfo(15, 59),//Alma 29:8
					new VerseInfo(15, 60, 15, 61),//Alma 29:9
					new VerseInfo(15, 62),//Alma 29:10
					new VerseInfo(15, 63),//Alma 29:11
					new VerseInfo(15, 64),//Alma 29:12
					new VerseInfo(15, 65),//Alma 29:13
					new VerseInfo(15, 65),//Alma 29:14
					new VerseInfo(15, 66),//Alma 29:15
					new VerseInfo(15, 67),//Alma 29:16
					new VerseInfo(15, 68, 15, 69),//Alma 29:17
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 30
					new VerseInfo(16, 1),//Alma 30:1
					new VerseInfo(16, 2, 16, 3),//Alma 30:2
					new VerseInfo(16, 3, 16, 4),//Alma 30:3
					new VerseInfo(16, 5),//Alma 30:4
					new VerseInfo(16, 6),//Alma 30:5
					new VerseInfo(16, 7),//Alma 30:6
					new VerseInfo(16, 8),//Alma 30:7
					new VerseInfo(16, 9),//Alma 30:8
					new VerseInfo(16, 10),//Alma 30:9
					new VerseInfo(16, 11),//Alma 30:10
					new VerseInfo(16, 11, 16, 12),//Alma 30:11
					new VerseInfo(16, 13, 16, 14),//Alma 30:12
					new VerseInfo(16, 14),//Alma 30:13
					new VerseInfo(16, 15),//Alma 30:14
					new VerseInfo(16, 15, 16, 16),//Alma 30:15
					new VerseInfo(16, 17),//Alma 30:16
					new VerseInfo(16, 18),//Alma 30:17
					new VerseInfo(16, 19),//Alma 30:18
					new VerseInfo(16, 20),//Alma 30:19
					new VerseInfo(16, 21),//Alma 30:20
					new VerseInfo(16, 22, 16, 23),//Alma 30:21
					new VerseInfo(16, 24, 16, 26),//Alma 30:22
					new VerseInfo(16, 27, 16, 28),//Alma 30:23
					new VerseInfo(16, 29, 16, 30),//Alma 30:24
					new VerseInfo(16, 31),//Alma 30:25
					new VerseInfo(16, 32, 16, 33),//Alma 30:26
					new VerseInfo(16, 33, 16, 34),//Alma 30:27
					new VerseInfo(16, 35),//Alma 30:28
					new VerseInfo(16, 36, 16, 37),//Alma 30:29
					new VerseInfo(16, 38),//Alma 30:30
					new VerseInfo(16, 39),//Alma 30:31
					new VerseInfo(16, 40),//Alma 30:32
					new VerseInfo(16, 41),//Alma 30:33
					new VerseInfo(16, 42),//Alma 30:34
					new VerseInfo(16, 43, 16, 44),//Alma 30:35
					new VerseInfo(16, 45),//Alma 30:36
					new VerseInfo(16, 46),//Alma 30:37
					new VerseInfo(16, 46),//Alma 30:38
					new VerseInfo(16, 47),//Alma 30:39
					new VerseInfo(16, 48),//Alma 30:40
					new VerseInfo(16, 49, 16, 50),//Alma 30:41
					new VerseInfo(16, 51),//Alma 30:42
					new VerseInfo(16, 52),//Alma 30:43
					new VerseInfo(16, 53, 16, 55),//Alma 30:44
					new VerseInfo(16, 55, 16, 56),//Alma 30:45
					new VerseInfo(16, 57),//Alma 30:46
					new VerseInfo(16, 58, 16, 59),//Alma 30:47
					new VerseInfo(16, 60),//Alma 30:48
					new VerseInfo(16, 61),//Alma 30:49
					new VerseInfo(16, 62),//Alma 30:50
					new VerseInfo(16, 63, 16, 65),//Alma 30:51
					new VerseInfo(16, 66),//Alma 30:52
					new VerseInfo(16, 67, 16, 69),//Alma 30:53
					new VerseInfo(16, 70),//Alma 30:54
					new VerseInfo(16, 71),//Alma 30:55
					new VerseInfo(16, 72),//Alma 30:56
					new VerseInfo(16, 73),//Alma 30:57
					new VerseInfo(16, 74, 16, 75),//Alma 30:58
					new VerseInfo(16, 76),//Alma 30:59
					new VerseInfo(16, 77),//Alma 30:60
				},
				new VerseInfo?[]
				{
					null,//Alma 31
					new VerseInfo(16, 78),//Alma 31:1
					new VerseInfo(16, 79),//Alma 31:2
					new VerseInfo(16, 80),//Alma 31:3
					new VerseInfo(16, 81),//Alma 31:4
					new VerseInfo(16, 82),//Alma 31:5
					new VerseInfo(16, 83),//Alma 31:6
					new VerseInfo(16, 84),//Alma 31:7
					new VerseInfo(16, 85),//Alma 31:8
					new VerseInfo(16, 86),//Alma 31:9
					new VerseInfo(16, 87),//Alma 31:10
					new VerseInfo(16, 87),//Alma 31:11
					new VerseInfo(16, 88, 16, 89),//Alma 31:12
					new VerseInfo(16, 89),//Alma 31:13
					new VerseInfo(16, 90),//Alma 31:14
					new VerseInfo(16, 90),//Alma 31:15
					new VerseInfo(16, 91, 16, 92),//Alma 31:16
					new VerseInfo(16, 92, 16, 93),//Alma 31:17
					new VerseInfo(16, 94),//Alma 31:18
					new VerseInfo(16, 95),//Alma 31:19
					new VerseInfo(16, 96),//Alma 31:20
					new VerseInfo(16, 97),//Alma 31:21
					new VerseInfo(16, 98),//Alma 31:22
					new VerseInfo(16, 99),//Alma 31:23
					new VerseInfo(16, 100),//Alma 31:24
					new VerseInfo(16, 101),//Alma 31:25
					new VerseInfo(16, 102),//Alma 31:26
					new VerseInfo(16, 103, 16, 104),//Alma 31:27
					new VerseInfo(16, 105, 16, 106),//Alma 31:28
					new VerseInfo(16, 107),//Alma 31:29
					new VerseInfo(16, 108, 16, 109),//Alma 31:30
					new VerseInfo(16, 110, 16, 111),//Alma 31:31
					new VerseInfo(16, 112),//Alma 31:32
					new VerseInfo(16, 113),//Alma 31:33
					new VerseInfo(16, 114),//Alma 31:34
					new VerseInfo(16, 115),//Alma 31:35
					new VerseInfo(16, 116, 16, 117),//Alma 31:36
					new VerseInfo(16, 118),//Alma 31:37
					new VerseInfo(16, 119, 16, 120),//Alma 31:38
				},
				new VerseInfo?[]
				{
					null,//Alma 32
					new VerseInfo(16, 121),//Alma 32:1
					new VerseInfo(16, 122),//Alma 32:2
					new VerseInfo(16, 123),//Alma 32:3
					new VerseInfo(16, 124),//Alma 32:4
					new VerseInfo(16, 125, 16, 126),//Alma 32:5
					new VerseInfo(16, 127),//Alma 32:6
					new VerseInfo(16, 128),//Alma 32:7
					new VerseInfo(16, 128),//Alma 32:8
					new VerseInfo(16, 129),//Alma 32:9
					new VerseInfo(16, 130),//Alma 32:10
					new VerseInfo(16, 131),//Alma 32:11
					new VerseInfo(16, 132, 16, 133),//Alma 32:12
					new VerseInfo(16, 134, 16, 135),//Alma 32:13
					new VerseInfo(16, 136),//Alma 32:14
					new VerseInfo(16, 137),//Alma 32:15
					new VerseInfo(16, 137, 16, 138),//Alma 32:16
					new VerseInfo(16, 139),//Alma 32:17
					new VerseInfo(16, 140),//Alma 32:18
					new VerseInfo(16, 141),//Alma 32:19
					new VerseInfo(16, 141, 16, 142),//Alma 32:20
					new VerseInfo(16, 143),//Alma 32:21
					new VerseInfo(16, 144),//Alma 32:22
					new VerseInfo(16, 145, 16, 146),//Alma 32:23
					new VerseInfo(16, 147),//Alma 32:24
					new VerseInfo(16, 148),//Alma 32:25
					new VerseInfo(16, 149, 16, 150),//Alma 32:26
					new VerseInfo(16, 151),//Alma 32:27
					new VerseInfo(16, 152, 16, 154),//Alma 32:28
					new VerseInfo(16, 155),//Alma 32:29
					new VerseInfo(16, 156, 16, 157),//Alma 32:30
					new VerseInfo(16, 158),//Alma 32:31
					new VerseInfo(16, 158),//Alma 32:32
					new VerseInfo(16, 159),//Alma 32:33
					new VerseInfo(16, 160, 16, 161),//Alma 32:34
					new VerseInfo(16, 162, 16, 163),//Alma 32:35
					new VerseInfo(16, 163),//Alma 32:36
					new VerseInfo(16, 164, 16, 165),//Alma 32:37
					new VerseInfo(16, 166),//Alma 32:38
					new VerseInfo(16, 167, 16, 168),//Alma 32:39
					new VerseInfo(16, 169),//Alma 32:40
					new VerseInfo(16, 170),//Alma 32:41
					new VerseInfo(16, 171, 16, 172),//Alma 32:42
					new VerseInfo(16, 173),//Alma 32:43
				},
				new VerseInfo?[]
				{
					null,//Alma 33
					new VerseInfo(16, 174),//Alma 33:1
					new VerseInfo(16, 175, 16, 176),//Alma 33:2
					new VerseInfo(16, 177),//Alma 33:3
					new VerseInfo(16, 178),//Alma 33:4
					new VerseInfo(16, 179),//Alma 33:5
					new VerseInfo(16, 180),//Alma 33:6
					new VerseInfo(16, 181),//Alma 33:7
					new VerseInfo(16, 181),//Alma 33:8
					new VerseInfo(16, 182),//Alma 33:9
					new VerseInfo(16, 182, 16, 183),//Alma 33:10
					new VerseInfo(16, 183, 16, 184),//Alma 33:11
					new VerseInfo(16, 185),//Alma 33:12
					new VerseInfo(16, 186),//Alma 33:13
					new VerseInfo(16, 187),//Alma 33:14
					new VerseInfo(16, 188),//Alma 33:15
					new VerseInfo(16, 188),//Alma 33:16
					new VerseInfo(16, 189),//Alma 33:17
					new VerseInfo(16, 190),//Alma 33:18
					new VerseInfo(16, 191),//Alma 33:19
					new VerseInfo(16, 192, 16, 194),//Alma 33:20
					new VerseInfo(16, 195),//Alma 33:21
					new VerseInfo(16, 196, 16, 197),//Alma 33:22
					new VerseInfo(16, 198, 16, 200),//Alma 33:23
				},
				new VerseInfo?[]
				{
					null,//Alma 34
					new VerseInfo(16, 201),//Alma 34:1
					new VerseInfo(16, 201, 16, 202),//Alma 34:2
					new VerseInfo(16, 202),//Alma 34:3
					new VerseInfo(16, 203),//Alma 34:4
					new VerseInfo(16, 203),//Alma 34:5
					new VerseInfo(16, 204),//Alma 34:6
					new VerseInfo(16, 205),//Alma 34:7
					new VerseInfo(16, 206, 16, 207),//Alma 34:8
					new VerseInfo(16, 208, 16, 209),//Alma 34:9
					new VerseInfo(16, 210),//Alma 34:10
					new VerseInfo(16, 211, 16, 212),//Alma 34:11
					new VerseInfo(16, 213),//Alma 34:12
					new VerseInfo(16, 213, 16, 214),//Alma 34:13
					new VerseInfo(16, 215),//Alma 34:14
					new VerseInfo(16, 215, 16, 216),//Alma 34:15
					new VerseInfo(16, 217),//Alma 34:16
					new VerseInfo(16, 218),//Alma 34:17
					new VerseInfo(16, 218),//Alma 34:18
					new VerseInfo(16, 219),//Alma 34:19
					new VerseInfo(16, 219),//Alma 34:20
					new VerseInfo(16, 219),//Alma 34:21
					new VerseInfo(16, 219),//Alma 34:22
					new VerseInfo(16, 219),//Alma 34:23
					new VerseInfo(16, 220),//Alma 34:24
					new VerseInfo(16, 220),//Alma 34:25
					new VerseInfo(16, 221),//Alma 34:26
					new VerseInfo(16, 222),//Alma 34:27
					new VerseInfo(16, 223, 16, 224),//Alma 34:28
					new VerseInfo(16, 225),//Alma 34:29
					new VerseInfo(16, 226),//Alma 34:30
					new VerseInfo(16, 227),//Alma 34:31
					new VerseInfo(16, 228),//Alma 34:32
					new VerseInfo(16, 229, 16, 230),//Alma 34:33
					new VerseInfo(16, 231, 16, 232),//Alma 34:34
					new VerseInfo(16, 233, 16, 234),//Alma 34:35
					new VerseInfo(16, 235, 16, 236),//Alma 34:36
					new VerseInfo(16, 237),//Alma 34:37
					new VerseInfo(16, 237, 16, 238),//Alma 34:38
					new VerseInfo(16, 238),//Alma 34:39
					new VerseInfo(16, 239),//Alma 34:40
					new VerseInfo(16, 239),//Alma 34:41
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 35
					new VerseInfo(16, 240),//Alma 35:1
					new VerseInfo(16, 241),//Alma 35:2
					new VerseInfo(16, 242),//Alma 35:3
					new VerseInfo(16, 243),//Alma 35:4
					new VerseInfo(16, 244),//Alma 35:5
					new VerseInfo(16, 245),//Alma 35:6
					new VerseInfo(16, 246),//Alma 35:7
					new VerseInfo(16, 247),//Alma 35:8
					new VerseInfo(16, 248, 16, 250),//Alma 35:9
					new VerseInfo(16, 251),//Alma 35:10
					new VerseInfo(16, 252),//Alma 35:11
					new VerseInfo(16, 253),//Alma 35:12
					new VerseInfo(16, 254, 16, 255),//Alma 35:13
					new VerseInfo(16, 256, 16, 257),//Alma 35:14
					new VerseInfo(16, 258, 16, 259),//Alma 35:15
					new VerseInfo(16, 260, 16, 261),//Alma 35:16
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 36
					new VerseInfo(17, 1),//Alma 36:1
					new VerseInfo(17, 2),//Alma 36:2
					new VerseInfo(17, 3),//Alma 36:3
					new VerseInfo(17, 4),//Alma 36:4
					new VerseInfo(17, 5),//Alma 36:5
					new VerseInfo(17, 5),//Alma 36:6
					new VerseInfo(17, 6),//Alma 36:7
					new VerseInfo(17, 7),//Alma 36:8
					new VerseInfo(17, 7),//Alma 36:9
					new VerseInfo(17, 8),//Alma 36:10
					new VerseInfo(17, 9),//Alma 36:11
					new VerseInfo(17, 10),//Alma 36:12
					new VerseInfo(17, 10, 17, 11),//Alma 36:13
					new VerseInfo(17, 11, 17, 12),//Alma 36:14
					new VerseInfo(17, 13),//Alma 36:15
					new VerseInfo(17, 14),//Alma 36:16
					new VerseInfo(17, 15),//Alma 36:17
					new VerseInfo(17, 16),//Alma 36:18
					new VerseInfo(17, 17),//Alma 36:19
					new VerseInfo(17, 18),//Alma 36:20
					new VerseInfo(17, 18, 17, 19),//Alma 36:21
					new VerseInfo(17, 20),//Alma 36:22
					new VerseInfo(17, 21),//Alma 36:23
					new VerseInfo(17, 22),//Alma 36:24
					new VerseInfo(17, 23),//Alma 36:25
					new VerseInfo(17, 23, 17, 24),//Alma 36:26
					new VerseInfo(17, 25),//Alma 36:27
					new VerseInfo(17, 26, 17, 27),//Alma 36:28
					new VerseInfo(17, 27, 17, 28),//Alma 36:29
					new VerseInfo(17, 29, 17, 30),//Alma 36:30
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 37
					new VerseInfo(17, 31),//Alma 37:1
					new VerseInfo(17, 31),//Alma 37:2
					new VerseInfo(17, 32),//Alma 37:3
					new VerseInfo(17, 33),//Alma 37:4
					new VerseInfo(17, 34),//Alma 37:5
					new VerseInfo(17, 35),//Alma 37:6
					new VerseInfo(17, 36),//Alma 37:7
					new VerseInfo(17, 37),//Alma 37:8
					new VerseInfo(17, 38, 17, 39),//Alma 37:9
					new VerseInfo(17, 40),//Alma 37:10
					new VerseInfo(17, 41),//Alma 37:11
					new VerseInfo(17, 42),//Alma 37:12
					new VerseInfo(17, 43, 17, 44),//Alma 37:13
					new VerseInfo(17, 45),//Alma 37:14
					new VerseInfo(17, 46),//Alma 37:15
					new VerseInfo(17, 47),//Alma 37:16
					new VerseInfo(17, 48),//Alma 37:17
					new VerseInfo(17, 49),//Alma 37:18
					new VerseInfo(17, 50),//Alma 37:19
					new VerseInfo(17, 51),//Alma 37:20
					new VerseInfo(17, 52, 17, 53),//Alma 37:21
					new VerseInfo(17, 54),//Alma 37:22
					new VerseInfo(17, 55),//Alma 37:23
					new VerseInfo(17, 56),//Alma 37:24
					new VerseInfo(17, 56, 17, 57),//Alma 37:25
					new VerseInfo(17, 58),//Alma 37:26
					new VerseInfo(17, 59),//Alma 37:27
					new VerseInfo(17, 60),//Alma 37:28
					new VerseInfo(17, 61, 17, 62),//Alma 37:29
					new VerseInfo(17, 63, 17, 64),//Alma 37:30
					new VerseInfo(17, 64),//Alma 37:31
					new VerseInfo(17, 65),//Alma 37:32
					new VerseInfo(17, 66),//Alma 37:33
					new VerseInfo(17, 67),//Alma 37:34
					new VerseInfo(17, 68),//Alma 37:35
					new VerseInfo(17, 68, 17, 69),//Alma 37:36
					new VerseInfo(17, 69, 17, 70),//Alma 37:37
					new VerseInfo(17, 71),//Alma 37:38
					new VerseInfo(17, 72, 17, 73),//Alma 37:39
					new VerseInfo(17, 73, 17, 74),//Alma 37:40
					new VerseInfo(17, 75, 17, 76),//Alma 37:41
					new VerseInfo(17, 77),//Alma 37:42
					new VerseInfo(17, 78),//Alma 37:43
					new VerseInfo(17, 79),//Alma 37:44
					new VerseInfo(17, 80),//Alma 37:45
					new VerseInfo(17, 81, 17, 82),//Alma 37:46
					new VerseInfo(17, 83, 17, 84),//Alma 37:47
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 38
					new VerseInfo(18, 1),//Alma 38:1
					new VerseInfo(18, 2),//Alma 38:2
					new VerseInfo(18, 3),//Alma 38:3
					new VerseInfo(18, 4),//Alma 38:4
					new VerseInfo(18, 5),//Alma 38:5
					new VerseInfo(18, 6),//Alma 38:6
					new VerseInfo(18, 7, 18, 8),//Alma 38:7
					new VerseInfo(18, 9, 18, 10),//Alma 38:8
					new VerseInfo(18, 11, 18, 12),//Alma 38:9
					new VerseInfo(18, 13),//Alma 38:10
					new VerseInfo(18, 14),//Alma 38:11
					new VerseInfo(18, 14, 18, 15),//Alma 38:12
					new VerseInfo(18, 15),//Alma 38:13
					new VerseInfo(18, 16),//Alma 38:14
					new VerseInfo(18, 17, 18, 18),//Alma 38:15
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 39
					new VerseInfo(19, 1, 19, 2),//Alma 39:1
					new VerseInfo(19, 3, 19, 4),//Alma 39:2
					new VerseInfo(19, 5),//Alma 39:3
					new VerseInfo(19, 5, 19, 6),//Alma 39:4
					new VerseInfo(19, 7),//Alma 39:5
					new VerseInfo(19, 8, 19, 9),//Alma 39:6
					new VerseInfo(19, 10, 19, 11),//Alma 39:7
					new VerseInfo(19, 12),//Alma 39:8
					new VerseInfo(19, 13, 19, 14),//Alma 39:9
					new VerseInfo(19, 15, 19, 16),//Alma 39:10
					new VerseInfo(19, 16, 19, 17),//Alma 39:11
					new VerseInfo(19, 18, 19, 19),//Alma 39:12
					new VerseInfo(19, 19, 19, 20),//Alma 39:13
					new VerseInfo(19, 20),//Alma 39:14
					new VerseInfo(19, 21, 19, 22),//Alma 39:15
					new VerseInfo(19, 23),//Alma 39:16
					new VerseInfo(19, 24, 19, 25),//Alma 39:17
					new VerseInfo(19, 26),//Alma 39:18
					new VerseInfo(19, 27),//Alma 39:19
				},
				new VerseInfo?[]
				{
					null,//Alma 40
					new VerseInfo(19, 28),//Alma 40:1
					new VerseInfo(19, 29),//Alma 40:2
					new VerseInfo(19, 30, 19, 32),//Alma 40:3
					new VerseInfo(19, 33, 19, 34),//Alma 40:4
					new VerseInfo(19, 35),//Alma 40:5
					new VerseInfo(19, 36),//Alma 40:6
					new VerseInfo(19, 37),//Alma 40:7
					new VerseInfo(19, 38),//Alma 40:8
					new VerseInfo(19, 39, 19, 40),//Alma 40:9
					new VerseInfo(19, 41),//Alma 40:10
					new VerseInfo(19, 42, 19, 43),//Alma 40:11
					new VerseInfo(19, 44),//Alma 40:12
					new VerseInfo(19, 45, 19, 46),//Alma 40:13
					new VerseInfo(19, 47),//Alma 40:14
					new VerseInfo(19, 48, 19, 49),//Alma 40:15
					new VerseInfo(19, 50),//Alma 40:16
					new VerseInfo(19, 51),//Alma 40:17
					new VerseInfo(19, 52),//Alma 40:18
					new VerseInfo(19, 53, 19, 54),//Alma 40:19
					new VerseInfo(19, 55),//Alma 40:20
					new VerseInfo(19, 56),//Alma 40:21
					new VerseInfo(19, 57),//Alma 40:22
					new VerseInfo(19, 58),//Alma 40:23
					new VerseInfo(19, 59),//Alma 40:24
					new VerseInfo(19, 59),//Alma 40:25
					new VerseInfo(19, 60, 19, 61),//Alma 40:26
				},
				new VerseInfo?[]
				{
					null,//Alma 41
					new VerseInfo(19, 62, 19, 63),//Alma 41:1
					new VerseInfo(19, 64, 19, 65),//Alma 41:2
					new VerseInfo(19, 66),//Alma 41:3
					new VerseInfo(19, 67, 19, 68),//Alma 41:4
					new VerseInfo(19, 68),//Alma 41:5
					new VerseInfo(19, 69),//Alma 41:6
					new VerseInfo(19, 70),//Alma 41:7
					new VerseInfo(19, 71),//Alma 41:8
					new VerseInfo(19, 72),//Alma 41:9
					new VerseInfo(19, 73, 19, 74),//Alma 41:10
					new VerseInfo(19, 75),//Alma 41:11
					new VerseInfo(19, 76),//Alma 41:12
					new VerseInfo(19, 77),//Alma 41:13
					new VerseInfo(19, 78, 19, 80),//Alma 41:14
					new VerseInfo(19, 80),//Alma 41:15
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 42
					new VerseInfo(19, 81),//Alma 42:1
					new VerseInfo(19, 82),//Alma 42:2
					new VerseInfo(19, 83),//Alma 42:3
					new VerseInfo(19, 84),//Alma 42:4
					new VerseInfo(19, 85, 19, 86),//Alma 42:5
					new VerseInfo(19, 87),//Alma 42:6
					new VerseInfo(19, 88),//Alma 42:7
					new VerseInfo(19, 89),//Alma 42:8
					new VerseInfo(19, 90),//Alma 42:9
					new VerseInfo(19, 91),//Alma 42:10
					new VerseInfo(19, 92),//Alma 42:11
					new VerseInfo(19, 93),//Alma 42:12
					new VerseInfo(19, 94, 19, 95),//Alma 42:13
					new VerseInfo(19, 96),//Alma 42:14
					new VerseInfo(19, 97),//Alma 42:15
					new VerseInfo(19, 98),//Alma 42:16
					new VerseInfo(19, 99),//Alma 42:17
					new VerseInfo(19, 100),//Alma 42:18
					new VerseInfo(19, 101),//Alma 42:19
					new VerseInfo(19, 102),//Alma 42:20
					new VerseInfo(19, 103),//Alma 42:21
					new VerseInfo(19, 104),//Alma 42:22
					new VerseInfo(19, 105, 19, 106),//Alma 42:23
					new VerseInfo(19, 106),//Alma 42:24
					new VerseInfo(19, 107),//Alma 42:25
					new VerseInfo(19, 108, 19, 109),//Alma 42:26
					new VerseInfo(19, 109, 19, 110),//Alma 42:27
					new VerseInfo(19, 111),//Alma 42:28
					new VerseInfo(19, 112),//Alma 42:29
					new VerseInfo(19, 113, 19, 114),//Alma 42:30
					new VerseInfo(19, 115, 19, 117),//Alma 42:31
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 43
					new VerseInfo(20, 1),//Alma 43:1
					new VerseInfo(20, 2),//Alma 43:2
					new VerseInfo(20, 3),//Alma 43:3
					new VerseInfo(20, 4),//Alma 43:4
					new VerseInfo(20, 5),//Alma 43:5
					new VerseInfo(20, 6),//Alma 43:6
					new VerseInfo(20, 7),//Alma 43:7
					new VerseInfo(20, 8),//Alma 43:8
					new VerseInfo(20, 9, 20, 10),//Alma 43:9
					new VerseInfo(20, 10),//Alma 43:10
					new VerseInfo(20, 11, 20, 12),//Alma 43:11
					new VerseInfo(20, 13),//Alma 43:12
					new VerseInfo(20, 14, 20, 15),//Alma 43:13
					new VerseInfo(20, 16),//Alma 43:14
					new VerseInfo(20, 17),//Alma 43:15
					new VerseInfo(20, 18),//Alma 43:16
					new VerseInfo(20, 19),//Alma 43:17
					new VerseInfo(20, 20),//Alma 43:18
					new VerseInfo(20, 21),//Alma 43:19
					new VerseInfo(20, 22, 20, 23),//Alma 43:20
					new VerseInfo(20, 24),//Alma 43:21
					new VerseInfo(20, 25),//Alma 43:22
					new VerseInfo(20, 26),//Alma 43:23
					new VerseInfo(20, 27, 20, 28),//Alma 43:24
					new VerseInfo(20, 29),//Alma 43:25
					new VerseInfo(20, 30),//Alma 43:26
					new VerseInfo(20, 31),//Alma 43:27
					new VerseInfo(20, 32),//Alma 43:28
					new VerseInfo(20, 33),//Alma 43:29
					new VerseInfo(20, 34),//Alma 43:30
					new VerseInfo(20, 35),//Alma 43:31
					new VerseInfo(20, 35),//Alma 43:32
					new VerseInfo(20, 36),//Alma 43:33
					new VerseInfo(20, 37),//Alma 43:34
					new VerseInfo(20, 38),//Alma 43:35
					new VerseInfo(20, 39),//Alma 43:36
					new VerseInfo(20, 39, 20, 40),//Alma 43:37
					new VerseInfo(20, 40, 20, 41),//Alma 43:38
					new VerseInfo(20, 42),//Alma 43:39
					new VerseInfo(20, 43, 20, 44),//Alma 43:40
					new VerseInfo(20, 45),//Alma 43:41
					new VerseInfo(20, 46),//Alma 43:42
					new VerseInfo(20, 47),//Alma 43:43
					new VerseInfo(20, 48, 20, 49),//Alma 43:44
					new VerseInfo(20, 50),//Alma 43:45
					new VerseInfo(20, 51),//Alma 43:46
					new VerseInfo(20, 52),//Alma 43:47
					new VerseInfo(20, 53, 20, 54),//Alma 43:48
					new VerseInfo(20, 55),//Alma 43:49
					new VerseInfo(20, 56),//Alma 43:50
					new VerseInfo(20, 57),//Alma 43:51
					new VerseInfo(20, 58),//Alma 43:52
					new VerseInfo(20, 59),//Alma 43:53
					new VerseInfo(20, 60),//Alma 43:54
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 44
					new VerseInfo(20, 61, 20, 63),//Alma 44:1
					new VerseInfo(20, 64, 20, 65),//Alma 44:2
					new VerseInfo(20, 66, 20, 67),//Alma 44:3
					new VerseInfo(20, 68, 20, 69),//Alma 44:4
					new VerseInfo(20, 70, 20, 71),//Alma 44:5
					new VerseInfo(20, 71),//Alma 44:6
					new VerseInfo(20, 72, 20, 73),//Alma 44:7
					new VerseInfo(20, 74, 20, 75),//Alma 44:8
					new VerseInfo(20, 76, 20, 77),//Alma 44:9
					new VerseInfo(20, 78),//Alma 44:10
					new VerseInfo(20, 79, 20, 80),//Alma 44:11
					new VerseInfo(20, 81, 20, 83),//Alma 44:12
					new VerseInfo(20, 84),//Alma 44:13
					new VerseInfo(20, 85),//Alma 44:14
					new VerseInfo(20, 86, 20, 87),//Alma 44:15
					new VerseInfo(20, 88),//Alma 44:16
					new VerseInfo(20, 89, 20, 90),//Alma 44:17
					new VerseInfo(20, 91, 20, 92),//Alma 44:18
					new VerseInfo(20, 93),//Alma 44:19
					new VerseInfo(20, 94, 20, 95),//Alma 44:20
					new VerseInfo(20, 96),//Alma 44:21
					new VerseInfo(20, 97),//Alma 44:22
					new VerseInfo(20, 98),//Alma 44:23
					new VerseInfo(20, 99, 20, 100),//Alma 44:24
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 45
					new VerseInfo(21, 1, 21, 2),//Alma 45:1
					new VerseInfo(21, 3),//Alma 45:2
					new VerseInfo(21, 4),//Alma 45:3
					new VerseInfo(21, 5),//Alma 45:4
					new VerseInfo(21, 5),//Alma 45:5
					new VerseInfo(21, 6),//Alma 45:6
					new VerseInfo(21, 6),//Alma 45:7
					new VerseInfo(21, 7),//Alma 45:8
					new VerseInfo(21, 8),//Alma 45:9
					new VerseInfo(21, 9),//Alma 45:10
					new VerseInfo(21, 10),//Alma 45:11
					new VerseInfo(21, 11, 21, 12),//Alma 45:12
					new VerseInfo(21, 13),//Alma 45:13
					new VerseInfo(21, 14, 21, 15),//Alma 45:14
					new VerseInfo(21, 16),//Alma 45:15
					new VerseInfo(21, 17, 21, 18),//Alma 45:16
					new VerseInfo(21, 19),//Alma 45:17
					new VerseInfo(21, 20),//Alma 45:18
					new VerseInfo(21, 21, 21, 22),//Alma 45:19
					new VerseInfo(21, 23),//Alma 45:20
					new VerseInfo(21, 24),//Alma 45:21
					new VerseInfo(21, 25, 21, 26),//Alma 45:22
					new VerseInfo(21, 27),//Alma 45:23
					new VerseInfo(21, 28),//Alma 45:24
				},
				new VerseInfo?[]
				{
					null,//Alma 46
					new VerseInfo(21, 29),//Alma 46:1
					new VerseInfo(21, 30),//Alma 46:2
					new VerseInfo(21, 31),//Alma 46:3
					new VerseInfo(21, 32),//Alma 46:4
					new VerseInfo(21, 33),//Alma 46:5
					new VerseInfo(21, 34),//Alma 46:6
					new VerseInfo(21, 35, 21, 36),//Alma 46:7
					new VerseInfo(21, 37),//Alma 46:8
					new VerseInfo(21, 37),//Alma 46:9
					new VerseInfo(21, 38, 21, 39),//Alma 46:10
					new VerseInfo(21, 40),//Alma 46:11
					new VerseInfo(21, 41),//Alma 46:12
					new VerseInfo(21, 42, 21, 43),//Alma 46:13
					new VerseInfo(21, 44),//Alma 46:14
					new VerseInfo(21, 44, 21, 45),//Alma 46:15
					new VerseInfo(21, 45),//Alma 46:16
					new VerseInfo(21, 46),//Alma 46:17
					new VerseInfo(21, 47),//Alma 46:18
					new VerseInfo(21, 48),//Alma 46:19
					new VerseInfo(21, 49),//Alma 46:20
					new VerseInfo(21, 50, 21, 51),//Alma 46:21
					new VerseInfo(21, 52, 21, 53),//Alma 46:22
					new VerseInfo(21, 54, 21, 55),//Alma 46:23
					new VerseInfo(21, 55, 21, 57),//Alma 46:24
					new VerseInfo(21, 58),//Alma 46:25
					new VerseInfo(21, 59),//Alma 46:26
					new VerseInfo(21, 60),//Alma 46:27
					new VerseInfo(21, 61),//Alma 46:28
					new VerseInfo(21, 62),//Alma 46:29
					new VerseInfo(21, 63, 21, 64),//Alma 46:30
					new VerseInfo(21, 65, 21, 66),//Alma 46:31
					new VerseInfo(21, 67),//Alma 46:32
					new VerseInfo(21, 68),//Alma 46:33
					new VerseInfo(21, 69),//Alma 46:34
					new VerseInfo(21, 70),//Alma 46:35
					new VerseInfo(21, 71),//Alma 46:36
					new VerseInfo(21, 72),//Alma 46:37
					new VerseInfo(21, 73),//Alma 46:38
					new VerseInfo(21, 74),//Alma 46:39
					new VerseInfo(21, 75, 21, 76),//Alma 46:40
					new VerseInfo(21, 77),//Alma 46:41
				},
				new VerseInfo?[]
				{
					null,//Alma 47
					new VerseInfo(21, 78),//Alma 47:1
					new VerseInfo(21, 79, 21, 80),//Alma 47:2
					new VerseInfo(21, 81),//Alma 47:3
					new VerseInfo(21, 82),//Alma 47:4
					new VerseInfo(21, 83, 21, 84),//Alma 47:5
					new VerseInfo(21, 85),//Alma 47:6
					new VerseInfo(21, 86),//Alma 47:7
					new VerseInfo(21, 87),//Alma 47:8
					new VerseInfo(21, 88),//Alma 47:9
					new VerseInfo(21, 89),//Alma 47:10
					new VerseInfo(21, 90, 21, 91),//Alma 47:11
					new VerseInfo(21, 92),//Alma 47:12
					new VerseInfo(21, 93),//Alma 47:13
					new VerseInfo(21, 94),//Alma 47:14
					new VerseInfo(21, 95, 21, 96),//Alma 47:15
					new VerseInfo(21, 96, 21, 97),//Alma 47:16
					new VerseInfo(21, 98),//Alma 47:17
					new VerseInfo(21, 99),//Alma 47:18
					new VerseInfo(21, 100),//Alma 47:19
					new VerseInfo(21, 101),//Alma 47:20
					new VerseInfo(21, 102),//Alma 47:21
					new VerseInfo(21, 103, 21, 104),//Alma 47:22
					new VerseInfo(21, 105),//Alma 47:23
					new VerseInfo(21, 106),//Alma 47:24
					new VerseInfo(21, 107),//Alma 47:25
					new VerseInfo(21, 107),//Alma 47:26
					new VerseInfo(21, 108, 21, 109),//Alma 47:27
					new VerseInfo(21, 110),//Alma 47:28
					new VerseInfo(21, 111),//Alma 47:29
					new VerseInfo(21, 112),//Alma 47:30
					new VerseInfo(21, 113),//Alma 47:31
					new VerseInfo(21, 114),//Alma 47:32
					new VerseInfo(21, 115),//Alma 47:33
					new VerseInfo(21, 116, 21, 118),//Alma 47:34
					new VerseInfo(21, 119, 21, 120),//Alma 47:35
					new VerseInfo(21, 121, 21, 122),//Alma 47:36
				},
				new VerseInfo?[]
				{
					null,//Alma 48
					new VerseInfo(21, 123),//Alma 48:1
					new VerseInfo(21, 124, 21, 125),//Alma 48:2
					new VerseInfo(21, 125),//Alma 48:3
					new VerseInfo(21, 125),//Alma 48:4
					new VerseInfo(21, 126),//Alma 48:5
					new VerseInfo(21, 127),//Alma 48:6
					new VerseInfo(21, 128),//Alma 48:7
					new VerseInfo(21, 129),//Alma 48:8
					new VerseInfo(21, 130),//Alma 48:9
					new VerseInfo(21, 131),//Alma 48:10
					new VerseInfo(21, 132),//Alma 48:11
					new VerseInfo(21, 133),//Alma 48:12
					new VerseInfo(21, 134),//Alma 48:13
					new VerseInfo(21, 135, 21, 136),//Alma 48:14
					new VerseInfo(21, 137),//Alma 48:15
					new VerseInfo(21, 138, 21, 139),//Alma 48:16
					new VerseInfo(21, 140),//Alma 48:17
					new VerseInfo(21, 141),//Alma 48:18
					new VerseInfo(21, 142),//Alma 48:19
					new VerseInfo(21, 143),//Alma 48:20
					new VerseInfo(21, 144),//Alma 48:21
					new VerseInfo(21, 145),//Alma 48:22
					new VerseInfo(21, 146),//Alma 48:23
					new VerseInfo(21, 147),//Alma 48:24
					new VerseInfo(21, 148),//Alma 48:25
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 49
					new VerseInfo(21, 149),//Alma 49:1
					new VerseInfo(21, 150),//Alma 49:2
					new VerseInfo(21, 151),//Alma 49:3
					new VerseInfo(21, 152),//Alma 49:4
					new VerseInfo(21, 153),//Alma 49:5
					new VerseInfo(21, 154, 21, 155),//Alma 49:6
					new VerseInfo(21, 156),//Alma 49:7
					new VerseInfo(21, 157, 21, 158),//Alma 49:8
					new VerseInfo(21, 159),//Alma 49:9
					new VerseInfo(21, 160),//Alma 49:10
					new VerseInfo(21, 161, 21, 162),//Alma 49:11
					new VerseInfo(21, 163),//Alma 49:12
					new VerseInfo(21, 164, 21, 165),//Alma 49:13
					new VerseInfo(21, 166),//Alma 49:14
					new VerseInfo(21, 167),//Alma 49:15
					new VerseInfo(21, 168),//Alma 49:16
					new VerseInfo(21, 169),//Alma 49:17
					new VerseInfo(21, 170),//Alma 49:18
					new VerseInfo(21, 171),//Alma 49:19
					new VerseInfo(21, 172),//Alma 49:20
					new VerseInfo(21, 173, 21, 174),//Alma 49:21
					new VerseInfo(21, 175, 21, 176),//Alma 49:22
					new VerseInfo(21, 177, 21, 178),//Alma 49:23
					new VerseInfo(21, 179),//Alma 49:24
					new VerseInfo(21, 180, 21, 181),//Alma 49:25
					new VerseInfo(21, 182),//Alma 49:26
					new VerseInfo(21, 183),//Alma 49:27
					new VerseInfo(21, 184),//Alma 49:28
					new VerseInfo(21, 185),//Alma 49:29
					new VerseInfo(21, 185, 21, 186),//Alma 49:30
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 50
					new VerseInfo(22, 1),//Alma 50:1
					new VerseInfo(22, 2),//Alma 50:2
					new VerseInfo(22, 3),//Alma 50:3
					new VerseInfo(22, 3, 22, 4),//Alma 50:4
					new VerseInfo(22, 5),//Alma 50:5
					new VerseInfo(22, 6),//Alma 50:6
					new VerseInfo(22, 7),//Alma 50:7
					new VerseInfo(22, 8),//Alma 50:8
					new VerseInfo(22, 9),//Alma 50:9
					new VerseInfo(22, 10),//Alma 50:10
					new VerseInfo(22, 11, 22, 12),//Alma 50:11
					new VerseInfo(22, 13),//Alma 50:12
					new VerseInfo(22, 14),//Alma 50:13
					new VerseInfo(22, 15),//Alma 50:14
					new VerseInfo(22, 16),//Alma 50:15
					new VerseInfo(22, 16),//Alma 50:16
					new VerseInfo(22, 17),//Alma 50:17
					new VerseInfo(22, 18),//Alma 50:18
					new VerseInfo(22, 19, 22, 20),//Alma 50:19
					new VerseInfo(22, 20, 22, 21),//Alma 50:20
					new VerseInfo(22, 22),//Alma 50:21
					new VerseInfo(22, 23),//Alma 50:22
					new VerseInfo(22, 24),//Alma 50:23
					new VerseInfo(22, 25),//Alma 50:24
					new VerseInfo(22, 26),//Alma 50:25
					new VerseInfo(22, 27),//Alma 50:26
					new VerseInfo(22, 28),//Alma 50:27
					new VerseInfo(22, 29),//Alma 50:28
					new VerseInfo(22, 30),//Alma 50:29
					new VerseInfo(22, 31),//Alma 50:30
					new VerseInfo(22, 32),//Alma 50:31
					new VerseInfo(22, 33),//Alma 50:32
					new VerseInfo(22, 34),//Alma 50:33
					new VerseInfo(22, 35),//Alma 50:34
					new VerseInfo(22, 36, 22, 38),//Alma 50:35
					new VerseInfo(22, 38, 22, 39),//Alma 50:36
					new VerseInfo(22, 40),//Alma 50:37
					new VerseInfo(22, 41),//Alma 50:38
					new VerseInfo(22, 42, 22, 43),//Alma 50:39
					new VerseInfo(22, 43, 22, 44),//Alma 50:40
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 51
					new VerseInfo(23, 1),//Alma 51:1
					new VerseInfo(23, 2),//Alma 51:2
					new VerseInfo(23, 3),//Alma 51:3
					new VerseInfo(23, 4),//Alma 51:4
					new VerseInfo(23, 5),//Alma 51:5
					new VerseInfo(23, 6),//Alma 51:6
					new VerseInfo(23, 7, 23, 8),//Alma 51:7
					new VerseInfo(23, 9),//Alma 51:8
					new VerseInfo(23, 10),//Alma 51:9
					new VerseInfo(23, 11),//Alma 51:10
					new VerseInfo(23, 12, 23, 13),//Alma 51:11
					new VerseInfo(23, 14, 23, 15),//Alma 51:12
					new VerseInfo(23, 16),//Alma 51:13
					new VerseInfo(23, 17),//Alma 51:14
					new VerseInfo(23, 18),//Alma 51:15
					new VerseInfo(23, 19, 23, 20),//Alma 51:16
					new VerseInfo(23, 21),//Alma 51:17
					new VerseInfo(23, 22),//Alma 51:18
					new VerseInfo(23, 23),//Alma 51:19
					new VerseInfo(23, 24),//Alma 51:20
					new VerseInfo(23, 25, 23, 26),//Alma 51:21
					new VerseInfo(23, 27),//Alma 51:22
					new VerseInfo(23, 28, 23, 29),//Alma 51:23
					new VerseInfo(23, 30),//Alma 51:24
					new VerseInfo(23, 31),//Alma 51:25
					new VerseInfo(23, 32),//Alma 51:26
					new VerseInfo(23, 33),//Alma 51:27
					new VerseInfo(23, 34),//Alma 51:28
					new VerseInfo(23, 35),//Alma 51:29
					new VerseInfo(23, 36),//Alma 51:30
					new VerseInfo(23, 37),//Alma 51:31
					new VerseInfo(23, 38, 23, 39),//Alma 51:32
					new VerseInfo(23, 40),//Alma 51:33
					new VerseInfo(23, 41),//Alma 51:34
					new VerseInfo(23, 42),//Alma 51:35
					new VerseInfo(23, 43),//Alma 51:36
					new VerseInfo(23, 44),//Alma 51:37
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 52
					new VerseInfo(24, 1),//Alma 52:1
					new VerseInfo(24, 2),//Alma 52:2
					new VerseInfo(24, 3),//Alma 52:3
					new VerseInfo(24, 4),//Alma 52:4
					new VerseInfo(24, 5, 24, 6),//Alma 52:5
					new VerseInfo(24, 6, 24, 7),//Alma 52:6
					new VerseInfo(24, 8),//Alma 52:7
					new VerseInfo(24, 9),//Alma 52:8
					new VerseInfo(24, 10),//Alma 52:9
					new VerseInfo(24, 11, 24, 12),//Alma 52:10
					new VerseInfo(24, 13),//Alma 52:11
					new VerseInfo(24, 14),//Alma 52:12
					new VerseInfo(24, 15),//Alma 52:13
					new VerseInfo(24, 16),//Alma 52:14
					new VerseInfo(24, 17),//Alma 52:15
					new VerseInfo(24, 18),//Alma 52:16
					new VerseInfo(24, 19, 24, 20),//Alma 52:17
					new VerseInfo(24, 21),//Alma 52:18
					new VerseInfo(24, 22, 24, 23),//Alma 52:19
					new VerseInfo(24, 24, 24, 25),//Alma 52:20
					new VerseInfo(24, 26),//Alma 52:21
					new VerseInfo(24, 27, 24, 28),//Alma 52:22
					new VerseInfo(24, 29, 24, 30),//Alma 52:23
					new VerseInfo(24, 31, 24, 32),//Alma 52:24
					new VerseInfo(24, 33),//Alma 52:25
					new VerseInfo(24, 34),//Alma 52:26
					new VerseInfo(24, 35),//Alma 52:27
					new VerseInfo(24, 36),//Alma 52:28
					new VerseInfo(24, 37),//Alma 52:29
					new VerseInfo(24, 38),//Alma 52:30
					new VerseInfo(24, 39),//Alma 52:31
					new VerseInfo(24, 40),//Alma 52:32
					new VerseInfo(24, 41),//Alma 52:33
					new VerseInfo(24, 42, 24, 43),//Alma 52:34
					new VerseInfo(24, 44),//Alma 52:35
					new VerseInfo(24, 45),//Alma 52:36
					new VerseInfo(24, 46),//Alma 52:37
					new VerseInfo(24, 47),//Alma 52:38
					new VerseInfo(24, 48),//Alma 52:39
					new VerseInfo(24, 49),//Alma 52:40
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 53
					new VerseInfo(24, 50),//Alma 53:1
					new VerseInfo(24, 51, 24, 52),//Alma 53:2
					new VerseInfo(24, 53, 24, 54),//Alma 53:3
					new VerseInfo(24, 55, 24, 56),//Alma 53:4
					new VerseInfo(24, 57, 24, 58),//Alma 53:5
					new VerseInfo(24, 59),//Alma 53:6
					new VerseInfo(24, 60),//Alma 53:7
					new VerseInfo(24, 61),//Alma 53:8
					new VerseInfo(24, 62),//Alma 53:9
					new VerseInfo(24, 63, 24, 64),//Alma 53:10
					new VerseInfo(24, 64, 24, 65),//Alma 53:11
					new VerseInfo(24, 66),//Alma 53:12
					new VerseInfo(24, 67),//Alma 53:13
					new VerseInfo(24, 68),//Alma 53:14
					new VerseInfo(24, 69),//Alma 53:15
					new VerseInfo(24, 70, 24, 71),//Alma 53:16
					new VerseInfo(24, 72, 24, 73),//Alma 53:17
					new VerseInfo(24, 74),//Alma 53:18
					new VerseInfo(24, 75),//Alma 53:19
					new VerseInfo(24, 76),//Alma 53:20
					new VerseInfo(24, 77),//Alma 53:21
					new VerseInfo(24, 78),//Alma 53:22
					new VerseInfo(24, 79),//Alma 53:23
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 54
					new VerseInfo(25, 1),//Alma 54:1
					new VerseInfo(25, 2),//Alma 54:2
					new VerseInfo(25, 3, 25, 4),//Alma 54:3
					new VerseInfo(25, 4, 25, 5),//Alma 54:4
					new VerseInfo(25, 5),//Alma 54:5
					new VerseInfo(25, 6),//Alma 54:6
					new VerseInfo(25, 6, 25, 7),//Alma 54:7
					new VerseInfo(25, 8),//Alma 54:8
					new VerseInfo(25, 9),//Alma 54:9
					new VerseInfo(25, 10),//Alma 54:10
					new VerseInfo(25, 11),//Alma 54:11
					new VerseInfo(25, 12),//Alma 54:12
					new VerseInfo(25, 13, 25, 14),//Alma 54:13
					new VerseInfo(25, 15),//Alma 54:14
					new VerseInfo(25, 16),//Alma 54:15
					new VerseInfo(25, 16, 25, 17),//Alma 54:16
					new VerseInfo(25, 18),//Alma 54:17
					new VerseInfo(25, 19),//Alma 54:18
					new VerseInfo(25, 20),//Alma 54:19
					new VerseInfo(25, 21, 25, 22),//Alma 54:20
					new VerseInfo(25, 23),//Alma 54:21
					new VerseInfo(25, 24),//Alma 54:22
					new VerseInfo(25, 25),//Alma 54:23
					new VerseInfo(25, 25, 25, 26),//Alma 54:24
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 55
					new VerseInfo(25, 27),//Alma 55:1
					new VerseInfo(25, 28),//Alma 55:2
					new VerseInfo(25, 29),//Alma 55:3
					new VerseInfo(25, 30),//Alma 55:4
					new VerseInfo(25, 31),//Alma 55:5
					new VerseInfo(25, 32),//Alma 55:6
					new VerseInfo(25, 33),//Alma 55:7
					new VerseInfo(25, 34, 25, 35),//Alma 55:8
					new VerseInfo(25, 36),//Alma 55:9
					new VerseInfo(25, 37),//Alma 55:10
					new VerseInfo(25, 38),//Alma 55:11
					new VerseInfo(25, 38),//Alma 55:12
					new VerseInfo(25, 39),//Alma 55:13
					new VerseInfo(25, 40),//Alma 55:14
					new VerseInfo(25, 41),//Alma 55:15
					new VerseInfo(25, 41, 25, 42),//Alma 55:16
					new VerseInfo(25, 42, 25, 43),//Alma 55:17
					new VerseInfo(25, 43),//Alma 55:18
					new VerseInfo(25, 44),//Alma 55:19
					new VerseInfo(25, 45),//Alma 55:20
					new VerseInfo(25, 46),//Alma 55:21
					new VerseInfo(25, 47),//Alma 55:22
					new VerseInfo(25, 48, 25, 49),//Alma 55:23
					new VerseInfo(25, 49, 25, 50),//Alma 55:24
					new VerseInfo(25, 51),//Alma 55:25
					new VerseInfo(25, 52, 25, 53),//Alma 55:26
					new VerseInfo(25, 54),//Alma 55:27
					new VerseInfo(25, 55),//Alma 55:28
					new VerseInfo(25, 56),//Alma 55:29
					new VerseInfo(25, 57),//Alma 55:30
					new VerseInfo(25, 58, 25, 59),//Alma 55:31
					new VerseInfo(25, 60),//Alma 55:32
					new VerseInfo(25, 61, 25, 62),//Alma 55:33
					new VerseInfo(25, 62),//Alma 55:34
					new VerseInfo(25, 63),//Alma 55:35
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 56
					new VerseInfo(26, 1),//Alma 56:1
					new VerseInfo(26, 2),//Alma 56:2
					new VerseInfo(26, 3, 26, 4),//Alma 56:3
					new VerseInfo(26, 5),//Alma 56:4
					new VerseInfo(26, 5),//Alma 56:5
					new VerseInfo(26, 6),//Alma 56:6
					new VerseInfo(26, 7),//Alma 56:7
					new VerseInfo(26, 8),//Alma 56:8
					new VerseInfo(26, 9, 26, 10),//Alma 56:9
					new VerseInfo(26, 11),//Alma 56:10
					new VerseInfo(26, 12),//Alma 56:11
					new VerseInfo(26, 13, 26, 14),//Alma 56:12
					new VerseInfo(26, 15),//Alma 56:13
					new VerseInfo(26, 15),//Alma 56:14
					new VerseInfo(26, 16),//Alma 56:15
					new VerseInfo(26, 17),//Alma 56:16
					new VerseInfo(26, 18),//Alma 56:17
					new VerseInfo(26, 19),//Alma 56:18
					new VerseInfo(26, 20),//Alma 56:19
					new VerseInfo(26, 21, 26, 22),//Alma 56:20
					new VerseInfo(26, 23),//Alma 56:21
					new VerseInfo(26, 24),//Alma 56:22
					new VerseInfo(26, 25, 26, 26),//Alma 56:23
					new VerseInfo(26, 27),//Alma 56:24
					new VerseInfo(26, 28),//Alma 56:25
					new VerseInfo(26, 29),//Alma 56:26
					new VerseInfo(26, 30),//Alma 56:27
					new VerseInfo(26, 31, 26, 32),//Alma 56:28
					new VerseInfo(26, 33),//Alma 56:29
					new VerseInfo(26, 34, 26, 35),//Alma 56:30
					new VerseInfo(26, 36),//Alma 56:31
					new VerseInfo(26, 37),//Alma 56:32
					new VerseInfo(26, 38, 26, 39),//Alma 56:33
					new VerseInfo(26, 40),//Alma 56:34
					new VerseInfo(26, 41),//Alma 56:35
					new VerseInfo(26, 42, 26, 43),//Alma 56:36
					new VerseInfo(26, 43, 26, 44),//Alma 56:37
					new VerseInfo(26, 45, 26, 46),//Alma 56:38
					new VerseInfo(26, 47, 26, 48),//Alma 56:39
					new VerseInfo(26, 49),//Alma 56:40
					new VerseInfo(26, 50),//Alma 56:41
					new VerseInfo(26, 51),//Alma 56:42
					new VerseInfo(26, 52),//Alma 56:43
					new VerseInfo(26, 52),//Alma 56:44
					new VerseInfo(26, 53),//Alma 56:45
					new VerseInfo(26, 54, 26, 55),//Alma 56:46
					new VerseInfo(26, 56),//Alma 56:47
					new VerseInfo(26, 57),//Alma 56:48
					new VerseInfo(26, 58, 26, 59),//Alma 56:49
					new VerseInfo(26, 60),//Alma 56:50
					new VerseInfo(26, 61),//Alma 56:51
					new VerseInfo(26, 62),//Alma 56:52
					new VerseInfo(26, 63),//Alma 56:53
					new VerseInfo(26, 64),//Alma 56:54
					new VerseInfo(26, 65),//Alma 56:55
					new VerseInfo(26, 66, 26, 67),//Alma 56:56
					new VerseInfo(26, 68, 26, 69),//Alma 56:57
				},
				new VerseInfo?[]
				{
					null,//Alma 57
					new VerseInfo(26, 70),//Alma 57:1
					new VerseInfo(26, 71),//Alma 57:2
					new VerseInfo(26, 72),//Alma 57:3
					new VerseInfo(26, 73),//Alma 57:4
					new VerseInfo(26, 74),//Alma 57:5
					new VerseInfo(26, 75, 26, 76),//Alma 57:6
					new VerseInfo(26, 77),//Alma 57:7
					new VerseInfo(26, 78),//Alma 57:8
					new VerseInfo(26, 79),//Alma 57:9
					new VerseInfo(26, 80, 26, 81),//Alma 57:10
					new VerseInfo(26, 82, 26, 83),//Alma 57:11
					new VerseInfo(26, 84),//Alma 57:12
					new VerseInfo(26, 85),//Alma 57:13
					new VerseInfo(26, 86),//Alma 57:14
					new VerseInfo(26, 87, 26, 88),//Alma 57:15
					new VerseInfo(26, 89, 26, 90),//Alma 57:16
					new VerseInfo(26, 90, 26, 92),//Alma 57:17
					new VerseInfo(26, 93),//Alma 57:18
					new VerseInfo(26, 94),//Alma 57:19
					new VerseInfo(26, 95),//Alma 57:20
					new VerseInfo(26, 95, 26, 96),//Alma 57:21
					new VerseInfo(26, 97),//Alma 57:22
					new VerseInfo(26, 98),//Alma 57:23
					new VerseInfo(26, 99),//Alma 57:24
					new VerseInfo(26, 100, 26, 101),//Alma 57:25
					new VerseInfo(26, 102, 26, 103),//Alma 57:26
					new VerseInfo(26, 104),//Alma 57:27
					new VerseInfo(26, 105),//Alma 57:28
					new VerseInfo(26, 106),//Alma 57:29
					new VerseInfo(26, 107, 26, 108),//Alma 57:30
					new VerseInfo(26, 109),//Alma 57:31
					new VerseInfo(26, 110),//Alma 57:32
					new VerseInfo(26, 111, 26, 112),//Alma 57:33
					new VerseInfo(26, 113),//Alma 57:34
					new VerseInfo(26, 114, 26, 115),//Alma 57:35
					new VerseInfo(26, 116, 26, 117),//Alma 57:36
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 58
					new VerseInfo(26, 118, 26, 119),//Alma 58:1
					new VerseInfo(26, 120),//Alma 58:2
					new VerseInfo(26, 121, 26, 122),//Alma 58:3
					new VerseInfo(26, 123, 26, 124),//Alma 58:4
					new VerseInfo(26, 125),//Alma 58:5
					new VerseInfo(26, 126),//Alma 58:6
					new VerseInfo(26, 127),//Alma 58:7
					new VerseInfo(26, 128, 26, 129),//Alma 58:8
					new VerseInfo(26, 130),//Alma 58:9
					new VerseInfo(26, 131),//Alma 58:10
					new VerseInfo(26, 132),//Alma 58:11
					new VerseInfo(26, 133),//Alma 58:12
					new VerseInfo(26, 134),//Alma 58:13
					new VerseInfo(26, 135),//Alma 58:14
					new VerseInfo(26, 136, 26, 137),//Alma 58:15
					new VerseInfo(26, 138),//Alma 58:16
					new VerseInfo(26, 139),//Alma 58:17
					new VerseInfo(26, 140, 26, 141),//Alma 58:18
					new VerseInfo(26, 142, 26, 143),//Alma 58:19
					new VerseInfo(26, 144),//Alma 58:20
					new VerseInfo(26, 145),//Alma 58:21
					new VerseInfo(26, 146),//Alma 58:22
					new VerseInfo(26, 147, 26, 148),//Alma 58:23
					new VerseInfo(26, 149),//Alma 58:24
					new VerseInfo(26, 150),//Alma 58:25
					new VerseInfo(26, 151),//Alma 58:26
					new VerseInfo(26, 152),//Alma 58:27
					new VerseInfo(26, 153),//Alma 58:28
					new VerseInfo(26, 154),//Alma 58:29
					new VerseInfo(26, 155, 26, 156),//Alma 58:30
					new VerseInfo(26, 157),//Alma 58:31
					new VerseInfo(26, 158),//Alma 58:32
					new VerseInfo(26, 159),//Alma 58:33
					new VerseInfo(26, 160),//Alma 58:34
					new VerseInfo(26, 161),//Alma 58:35
					new VerseInfo(26, 162),//Alma 58:36
					new VerseInfo(26, 163),//Alma 58:37
					new VerseInfo(26, 164),//Alma 58:38
					new VerseInfo(26, 165),//Alma 58:39
					new VerseInfo(26, 166, 26, 167),//Alma 58:40
					new VerseInfo(26, 168, 26, 170),//Alma 58:41
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 59
					new VerseInfo(27, 1),//Alma 59:1
					new VerseInfo(27, 2),//Alma 59:2
					new VerseInfo(27, 3),//Alma 59:3
					new VerseInfo(27, 4),//Alma 59:4
					new VerseInfo(27, 5),//Alma 59:5
					new VerseInfo(27, 6),//Alma 59:6
					new VerseInfo(27, 7),//Alma 59:7
					new VerseInfo(27, 8),//Alma 59:8
					new VerseInfo(27, 9),//Alma 59:9
					new VerseInfo(27, 10),//Alma 59:10
					new VerseInfo(27, 11),//Alma 59:11
					new VerseInfo(27, 12),//Alma 59:12
					new VerseInfo(27, 13),//Alma 59:13
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 60
					new VerseInfo(27, 14),//Alma 60:1
					new VerseInfo(27, 15),//Alma 60:2
					new VerseInfo(27, 16),//Alma 60:3
					new VerseInfo(27, 17),//Alma 60:4
					new VerseInfo(27, 17, 27, 19),//Alma 60:5
					new VerseInfo(27, 19),//Alma 60:6
					new VerseInfo(27, 20, 27, 21),//Alma 60:7
					new VerseInfo(27, 21, 27, 22),//Alma 60:8
					new VerseInfo(27, 23, 27, 24),//Alma 60:9
					new VerseInfo(27, 25, 27, 26),//Alma 60:10
					new VerseInfo(27, 27),//Alma 60:11
					new VerseInfo(27, 28, 27, 29),//Alma 60:12
					new VerseInfo(27, 29),//Alma 60:13
					new VerseInfo(27, 30),//Alma 60:14
					new VerseInfo(27, 31),//Alma 60:15
					new VerseInfo(27, 31, 27, 34),//Alma 60:16
					new VerseInfo(27, 35),//Alma 60:17
					new VerseInfo(27, 36),//Alma 60:18
					new VerseInfo(27, 37),//Alma 60:19
					new VerseInfo(27, 38, 27, 39),//Alma 60:20
					new VerseInfo(27, 40),//Alma 60:21
					new VerseInfo(27, 41),//Alma 60:22
					new VerseInfo(27, 42, 27, 43),//Alma 60:23
					new VerseInfo(27, 44),//Alma 60:24
					new VerseInfo(27, 45),//Alma 60:25
					new VerseInfo(27, 45),//Alma 60:26
					new VerseInfo(27, 46),//Alma 60:27
					new VerseInfo(27, 47),//Alma 60:28
					new VerseInfo(27, 48),//Alma 60:29
					new VerseInfo(27, 49),//Alma 60:30
					new VerseInfo(27, 50),//Alma 60:31
					new VerseInfo(27, 51, 27, 52),//Alma 60:32
					new VerseInfo(27, 53, 27, 54),//Alma 60:33
					new VerseInfo(27, 55),//Alma 60:34
					new VerseInfo(27, 56, 27, 57),//Alma 60:35
					new VerseInfo(27, 58, 27, 59),//Alma 60:36
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 61
					new VerseInfo(28, 1, 28, 2),//Alma 61:1
					new VerseInfo(28, 2),//Alma 61:2
					new VerseInfo(28, 3),//Alma 61:3
					new VerseInfo(28, 4, 28, 5),//Alma 61:4
					new VerseInfo(28, 6),//Alma 61:5
					new VerseInfo(28, 7),//Alma 61:6
					new VerseInfo(28, 8),//Alma 61:7
					new VerseInfo(28, 9, 28, 10),//Alma 61:8
					new VerseInfo(28, 11, 28, 13),//Alma 61:9
					new VerseInfo(28, 14, 28, 15),//Alma 61:10
					new VerseInfo(28, 16),//Alma 61:11
					new VerseInfo(28, 17),//Alma 61:12
					new VerseInfo(28, 18),//Alma 61:13
					new VerseInfo(28, 19),//Alma 61:14
					new VerseInfo(28, 20),//Alma 61:15
					new VerseInfo(28, 21),//Alma 61:16
					new VerseInfo(28, 22),//Alma 61:17
					new VerseInfo(28, 23),//Alma 61:18
					new VerseInfo(28, 24),//Alma 61:19
					new VerseInfo(28, 25),//Alma 61:20
					new VerseInfo(28, 26, 28, 27),//Alma 61:21
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 62
					new VerseInfo(29, 1),//Alma 62:1
					new VerseInfo(29, 2),//Alma 62:2
					new VerseInfo(29, 3),//Alma 62:3
					new VerseInfo(29, 4),//Alma 62:4
					new VerseInfo(29, 5),//Alma 62:5
					new VerseInfo(29, 6),//Alma 62:6
					new VerseInfo(29, 7),//Alma 62:7
					new VerseInfo(29, 8),//Alma 62:8
					new VerseInfo(29, 9, 29, 10),//Alma 62:9
					new VerseInfo(29, 11),//Alma 62:10
					new VerseInfo(29, 12),//Alma 62:11
					new VerseInfo(29, 13),//Alma 62:12
					new VerseInfo(29, 14, 29, 15),//Alma 62:13
					new VerseInfo(29, 16),//Alma 62:14
					new VerseInfo(29, 17),//Alma 62:15
					new VerseInfo(29, 18),//Alma 62:16
					new VerseInfo(29, 19),//Alma 62:17
					new VerseInfo(29, 20, 29, 21),//Alma 62:18
					new VerseInfo(29, 22),//Alma 62:19
					new VerseInfo(29, 23),//Alma 62:20
					new VerseInfo(29, 24, 29, 25),//Alma 62:21
					new VerseInfo(29, 26),//Alma 62:22
					new VerseInfo(29, 27),//Alma 62:23
					new VerseInfo(29, 28),//Alma 62:24
					new VerseInfo(29, 29),//Alma 62:25
					new VerseInfo(29, 30),//Alma 62:26
					new VerseInfo(29, 31),//Alma 62:27
					new VerseInfo(29, 32),//Alma 62:28
					new VerseInfo(29, 32, 29, 33),//Alma 62:29
					new VerseInfo(29, 34),//Alma 62:30
					new VerseInfo(29, 35),//Alma 62:31
					new VerseInfo(29, 36),//Alma 62:32
					new VerseInfo(29, 37, 29, 38),//Alma 62:33
					new VerseInfo(29, 39),//Alma 62:34
					new VerseInfo(29, 39, 29, 41),//Alma 62:35
					new VerseInfo(29, 42, 29, 44),//Alma 62:36
					new VerseInfo(29, 45, 29, 46),//Alma 62:37
					new VerseInfo(29, 47),//Alma 62:38
					new VerseInfo(29, 48),//Alma 62:39
					new VerseInfo(29, 49),//Alma 62:40
					new VerseInfo(29, 50, 29, 51),//Alma 62:41
					new VerseInfo(29, 52),//Alma 62:42
					new VerseInfo(29, 53),//Alma 62:43
					new VerseInfo(29, 54),//Alma 62:44
					new VerseInfo(29, 55),//Alma 62:45
					new VerseInfo(29, 56),//Alma 62:46
					new VerseInfo(29, 56, 29, 57),//Alma 62:47
					new VerseInfo(29, 58, 29, 59),//Alma 62:48
					new VerseInfo(29, 59),//Alma 62:49
					new VerseInfo(29, 60),//Alma 62:50
					new VerseInfo(29, 61),//Alma 62:51
					new VerseInfo(29, 62, 29, 63),//Alma 62:52
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 63
					new VerseInfo(30, 1),//Alma 63:1
					new VerseInfo(30, 2),//Alma 63:2
					new VerseInfo(30, 3, 30, 4),//Alma 63:3
					new VerseInfo(30, 5),//Alma 63:4
					new VerseInfo(30, 6),//Alma 63:5
					new VerseInfo(30, 7, 30, 8),//Alma 63:6
					new VerseInfo(30, 9, 30, 10),//Alma 63:7
					new VerseInfo(30, 11, 30, 12),//Alma 63:8
					new VerseInfo(30, 13),//Alma 63:9
					new VerseInfo(30, 14),//Alma 63:10
					new VerseInfo(30, 15),//Alma 63:11
					new VerseInfo(30, 16),//Alma 63:12
					new VerseInfo(30, 17),//Alma 63:13
					new VerseInfo(30, 18),//Alma 63:14
					new VerseInfo(30, 19),//Alma 63:15
					new VerseInfo(30, 20),//Alma 63:16
					new VerseInfo(30, 21),//Alma 63:17
				},
			}
		},
		{ "Helaman", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Helaman 1
					new VerseInfo(1, 1),//Helaman 1:1
					new VerseInfo(1, 2),//Helaman 1:2
					new VerseInfo(1, 3),//Helaman 1:3
					new VerseInfo(1, 4),//Helaman 1:4
					new VerseInfo(1, 5),//Helaman 1:5
					new VerseInfo(1, 6),//Helaman 1:6
					new VerseInfo(1, 7),//Helaman 1:7
					new VerseInfo(1, 8),//Helaman 1:8
					new VerseInfo(1, 9),//Helaman 1:9
					new VerseInfo(1, 10),//Helaman 1:10
					new VerseInfo(1, 11),//Helaman 1:11
					new VerseInfo(1, 11, 1, 12),//Helaman 1:12
					new VerseInfo(1, 13, 1, 14),//Helaman 1:13
					new VerseInfo(1, 15),//Helaman 1:14
					new VerseInfo(1, 15, 1, 16),//Helaman 1:15
					new VerseInfo(1, 17),//Helaman 1:16
					new VerseInfo(1, 18),//Helaman 1:17
					new VerseInfo(1, 19),//Helaman 1:18
					new VerseInfo(1, 20),//Helaman 1:19
					new VerseInfo(1, 21),//Helaman 1:20
					new VerseInfo(1, 22, 1, 23),//Helaman 1:21
					new VerseInfo(1, 24),//Helaman 1:22
					new VerseInfo(1, 25),//Helaman 1:23
					new VerseInfo(1, 26),//Helaman 1:24
					new VerseInfo(1, 27),//Helaman 1:25
					new VerseInfo(1, 28),//Helaman 1:26
					new VerseInfo(1, 29),//Helaman 1:27
					new VerseInfo(1, 30),//Helaman 1:28
					new VerseInfo(1, 31),//Helaman 1:29
					new VerseInfo(1, 32),//Helaman 1:30
					new VerseInfo(1, 33),//Helaman 1:31
					new VerseInfo(1, 34),//Helaman 1:32
					new VerseInfo(1, 35),//Helaman 1:33
					new VerseInfo(1, 36),//Helaman 1:34
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Helaman 2
					new VerseInfo(1, 37),//Helaman 2:1
					new VerseInfo(1, 38),//Helaman 2:2
					new VerseInfo(1, 39),//Helaman 2:3
					new VerseInfo(1, 40),//Helaman 2:4
					new VerseInfo(1, 41),//Helaman 2:5
					new VerseInfo(1, 42),//Helaman 2:6
					new VerseInfo(1, 43),//Helaman 2:7
					new VerseInfo(1, 44),//Helaman 2:8
					new VerseInfo(1, 45, 1, 46),//Helaman 2:9
					new VerseInfo(1, 47),//Helaman 2:10
					new VerseInfo(1, 48, 1, 49),//Helaman 2:11
					new VerseInfo(1, 49, 1, 50),//Helaman 2:12
					new VerseInfo(1, 51),//Helaman 2:13
					new VerseInfo(1, 52),//Helaman 2:14
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Helaman 3
					new VerseInfo(2, 1),//Helaman 3:1
					new VerseInfo(2, 2),//Helaman 3:2
					new VerseInfo(2, 3),//Helaman 3:3
					new VerseInfo(2, 4),//Helaman 3:4
					new VerseInfo(2, 5),//Helaman 3:5
					new VerseInfo(2, 6),//Helaman 3:6
					new VerseInfo(2, 7),//Helaman 3:7
					new VerseInfo(2, 8),//Helaman 3:8
					new VerseInfo(2, 9),//Helaman 3:9
					new VerseInfo(2, 10),//Helaman 3:10
					new VerseInfo(2, 10),//Helaman 3:11
					new VerseInfo(2, 11),//Helaman 3:12
					new VerseInfo(2, 12),//Helaman 3:13
					new VerseInfo(2, 13),//Helaman 3:14
					new VerseInfo(2, 14),//Helaman 3:15
					new VerseInfo(2, 14),//Helaman 3:16
					new VerseInfo(2, 15),//Helaman 3:17
					new VerseInfo(2, 16),//Helaman 3:18
					new VerseInfo(2, 17),//Helaman 3:19
					new VerseInfo(2, 18),//Helaman 3:20
					new VerseInfo(2, 19),//Helaman 3:21
					new VerseInfo(2, 20),//Helaman 3:22
					new VerseInfo(2, 21),//Helaman 3:23
					new VerseInfo(2, 22),//Helaman 3:24
					new VerseInfo(2, 23),//Helaman 3:25
					new VerseInfo(2, 24),//Helaman 3:26
					new VerseInfo(2, 25),//Helaman 3:27
					new VerseInfo(2, 25),//Helaman 3:28
					new VerseInfo(2, 26),//Helaman 3:29
					new VerseInfo(2, 26),//Helaman 3:30
					new VerseInfo(2, 27),//Helaman 3:31
					new VerseInfo(2, 28),//Helaman 3:32
					new VerseInfo(2, 29),//Helaman 3:33
					new VerseInfo(2, 29, 2, 30),//Helaman 3:34
					new VerseInfo(2, 31),//Helaman 3:35
					new VerseInfo(2, 32),//Helaman 3:36
					new VerseInfo(2, 33, 2, 34),//Helaman 3:37
				},
				new VerseInfo?[]
				{
					null,//Helaman 4
					new VerseInfo(2, 35),//Helaman 4:1
					new VerseInfo(2, 35),//Helaman 4:2
					new VerseInfo(2, 36),//Helaman 4:3
					new VerseInfo(2, 37),//Helaman 4:4
					new VerseInfo(2, 38),//Helaman 4:5
					new VerseInfo(2, 39),//Helaman 4:6
					new VerseInfo(2, 39),//Helaman 4:7
					new VerseInfo(2, 40, 2, 41),//Helaman 4:8
					new VerseInfo(2, 42),//Helaman 4:9
					new VerseInfo(2, 43),//Helaman 4:10
					new VerseInfo(2, 44),//Helaman 4:11
					new VerseInfo(2, 45),//Helaman 4:12
					new VerseInfo(2, 46),//Helaman 4:13
					new VerseInfo(2, 47, 2, 48),//Helaman 4:14
					new VerseInfo(2, 49),//Helaman 4:15
					new VerseInfo(2, 50),//Helaman 4:16
					new VerseInfo(2, 51),//Helaman 4:17
					new VerseInfo(2, 52),//Helaman 4:18
					new VerseInfo(2, 53),//Helaman 4:19
					new VerseInfo(2, 54),//Helaman 4:20
					new VerseInfo(2, 55),//Helaman 4:21
					new VerseInfo(2, 56, 2, 57),//Helaman 4:22
					new VerseInfo(2, 58),//Helaman 4:23
					new VerseInfo(2, 59),//Helaman 4:24
					new VerseInfo(2, 60),//Helaman 4:25
					new VerseInfo(2, 61, 2, 62),//Helaman 4:26
				},
				new VerseInfo?[]
				{
					null,//Helaman 5
					new VerseInfo(2, 63),//Helaman 5:1
					new VerseInfo(2, 64),//Helaman 5:2
					new VerseInfo(2, 65),//Helaman 5:3
					new VerseInfo(2, 66),//Helaman 5:4
					new VerseInfo(2, 66, 2, 67),//Helaman 5:5
					new VerseInfo(2, 67, 2, 68),//Helaman 5:6
					new VerseInfo(2, 69),//Helaman 5:7
					new VerseInfo(2, 70),//Helaman 5:8
					new VerseInfo(2, 71),//Helaman 5:9
					new VerseInfo(2, 72),//Helaman 5:10
					new VerseInfo(2, 73),//Helaman 5:11
					new VerseInfo(2, 74, 2, 75),//Helaman 5:12
					new VerseInfo(2, 76),//Helaman 5:13
					new VerseInfo(2, 77),//Helaman 5:14
					new VerseInfo(2, 77),//Helaman 5:15
					new VerseInfo(2, 78),//Helaman 5:16
					new VerseInfo(2, 79),//Helaman 5:17
					new VerseInfo(2, 80),//Helaman 5:18
					new VerseInfo(2, 81),//Helaman 5:19
					new VerseInfo(2, 82),//Helaman 5:20
					new VerseInfo(2, 83),//Helaman 5:21
					new VerseInfo(2, 84),//Helaman 5:22
					new VerseInfo(2, 85, 2, 86),//Helaman 5:23
					new VerseInfo(2, 87),//Helaman 5:24
					new VerseInfo(2, 88),//Helaman 5:25
					new VerseInfo(2, 89),//Helaman 5:26
					new VerseInfo(2, 90, 2, 91),//Helaman 5:27
					new VerseInfo(2, 92),//Helaman 5:28
					new VerseInfo(2, 93),//Helaman 5:29
					new VerseInfo(2, 94),//Helaman 5:30
					new VerseInfo(2, 95),//Helaman 5:31
					new VerseInfo(2, 96, 2, 97),//Helaman 5:32
					new VerseInfo(2, 97),//Helaman 5:33
					new VerseInfo(2, 98),//Helaman 5:34
					new VerseInfo(2, 99),//Helaman 5:35
					new VerseInfo(2, 100, 2, 101),//Helaman 5:36
					new VerseInfo(2, 102, 2, 103),//Helaman 5:37
					new VerseInfo(2, 104),//Helaman 5:38
					new VerseInfo(2, 105),//Helaman 5:39
					new VerseInfo(2, 106),//Helaman 5:40
					new VerseInfo(2, 107),//Helaman 5:41
					new VerseInfo(2, 108),//Helaman 5:42
					new VerseInfo(2, 109),//Helaman 5:43
					new VerseInfo(2, 110),//Helaman 5:44
					new VerseInfo(2, 111),//Helaman 5:45
					new VerseInfo(2, 112),//Helaman 5:46
					new VerseInfo(2, 112),//Helaman 5:47
					new VerseInfo(2, 113),//Helaman 5:48
					new VerseInfo(2, 114),//Helaman 5:49
					new VerseInfo(2, 115),//Helaman 5:50
					new VerseInfo(2, 116),//Helaman 5:51
					new VerseInfo(2, 117),//Helaman 5:52
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Helaman 6
					new VerseInfo(2, 118),//Helaman 6:1
					new VerseInfo(2, 119),//Helaman 6:2
					new VerseInfo(2, 120, 2, 121),//Helaman 6:3
					new VerseInfo(2, 122),//Helaman 6:4
					new VerseInfo(2, 123),//Helaman 6:5
					new VerseInfo(2, 124, 2, 125),//Helaman 6:6
					new VerseInfo(2, 126),//Helaman 6:7
					new VerseInfo(2, 127),//Helaman 6:8
					new VerseInfo(2, 128),//Helaman 6:9
					new VerseInfo(2, 129),//Helaman 6:10
					new VerseInfo(2, 130),//Helaman 6:11
					new VerseInfo(2, 131, 2, 132),//Helaman 6:12
					new VerseInfo(2, 133, 2, 134),//Helaman 6:13
					new VerseInfo(2, 135),//Helaman 6:14
					new VerseInfo(2, 136, 2, 137),//Helaman 6:15
					new VerseInfo(2, 138),//Helaman 6:16
					new VerseInfo(2, 139, 2, 140),//Helaman 6:17
					new VerseInfo(2, 141, 2, 143),//Helaman 6:18
					new VerseInfo(2, 143),//Helaman 6:19
					new VerseInfo(2, 144),//Helaman 6:20
					new VerseInfo(2, 145),//Helaman 6:21
					new VerseInfo(2, 146),//Helaman 6:22
					new VerseInfo(2, 147),//Helaman 6:23
					new VerseInfo(2, 148),//Helaman 6:24
					new VerseInfo(2, 149),//Helaman 6:25
					new VerseInfo(2, 150, 2, 151),//Helaman 6:26
					new VerseInfo(2, 151, 2, 152),//Helaman 6:27
					new VerseInfo(2, 153, 2, 154),//Helaman 6:28
					new VerseInfo(2, 155),//Helaman 6:29
					new VerseInfo(2, 156),//Helaman 6:30
					new VerseInfo(2, 157, 2, 158),//Helaman 6:31
					new VerseInfo(2, 159),//Helaman 6:32
					new VerseInfo(2, 160),//Helaman 6:33
					new VerseInfo(2, 161),//Helaman 6:34
					new VerseInfo(2, 162),//Helaman 6:35
					new VerseInfo(2, 163),//Helaman 6:36
					new VerseInfo(2, 164),//Helaman 6:37
					new VerseInfo(2, 165),//Helaman 6:38
					new VerseInfo(2, 166),//Helaman 6:39
					new VerseInfo(2, 167),//Helaman 6:40
					new VerseInfo(2, 168),//Helaman 6:41
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Helaman 7
					new VerseInfo(3, 1),//Helaman 7:1
					new VerseInfo(3, 1),//Helaman 7:2
					new VerseInfo(3, 2),//Helaman 7:3
					new VerseInfo(3, 3),//Helaman 7:4
					new VerseInfo(3, 3, 3, 4),//Helaman 7:5
					new VerseInfo(3, 5, 3, 6),//Helaman 7:6
					new VerseInfo(3, 6, 3, 7),//Helaman 7:7
					new VerseInfo(3, 8),//Helaman 7:8
					new VerseInfo(3, 9),//Helaman 7:9
					new VerseInfo(3, 10, 3, 11),//Helaman 7:10
					new VerseInfo(3, 12),//Helaman 7:11
					new VerseInfo(3, 13),//Helaman 7:12
					new VerseInfo(3, 14),//Helaman 7:13
					new VerseInfo(3, 15),//Helaman 7:14
					new VerseInfo(3, 16, 3, 17),//Helaman 7:15
					new VerseInfo(3, 17),//Helaman 7:16
					new VerseInfo(3, 18),//Helaman 7:17
					new VerseInfo(3, 19),//Helaman 7:18
					new VerseInfo(3, 20),//Helaman 7:19
					new VerseInfo(3, 21),//Helaman 7:20
					new VerseInfo(3, 22, 3, 23),//Helaman 7:21
					new VerseInfo(3, 23, 3, 24),//Helaman 7:22
					new VerseInfo(3, 25, 3, 26),//Helaman 7:23
					new VerseInfo(3, 26, 3, 27),//Helaman 7:24
					new VerseInfo(3, 28),//Helaman 7:25
					new VerseInfo(3, 29),//Helaman 7:26
					new VerseInfo(3, 29),//Helaman 7:27
					new VerseInfo(3, 30),//Helaman 7:28
					new VerseInfo(3, 31),//Helaman 7:29
				},
				new VerseInfo?[]
				{
					null,//Helaman 8
					new VerseInfo(3, 32, 3, 33),//Helaman 8:1
					new VerseInfo(3, 34),//Helaman 8:2
					new VerseInfo(3, 35),//Helaman 8:3
					new VerseInfo(3, 36),//Helaman 8:4
					new VerseInfo(3, 36, 3, 37),//Helaman 8:5
					new VerseInfo(3, 38),//Helaman 8:6
					new VerseInfo(3, 39),//Helaman 8:7
					new VerseInfo(3, 40, 3, 41),//Helaman 8:8
					new VerseInfo(3, 41),//Helaman 8:9
					new VerseInfo(3, 42, 3, 43),//Helaman 8:10
					new VerseInfo(3, 44),//Helaman 8:11
					new VerseInfo(3, 45),//Helaman 8:12
					new VerseInfo(3, 46),//Helaman 8:13
					new VerseInfo(3, 47),//Helaman 8:14
					new VerseInfo(3, 48),//Helaman 8:15
					new VerseInfo(3, 49),//Helaman 8:16
					new VerseInfo(3, 50),//Helaman 8:17
					new VerseInfo(3, 51, 3, 52),//Helaman 8:18
					new VerseInfo(3, 53),//Helaman 8:19
					new VerseInfo(3, 53, 3, 55),//Helaman 8:20
					new VerseInfo(3, 56, 3, 58),//Helaman 8:21
					new VerseInfo(3, 58, 3, 59),//Helaman 8:22
					new VerseInfo(3, 60),//Helaman 8:23
					new VerseInfo(3, 61, 3, 62),//Helaman 8:24
					new VerseInfo(3, 63),//Helaman 8:25
					new VerseInfo(3, 64),//Helaman 8:26
					new VerseInfo(3, 65),//Helaman 8:27
					new VerseInfo(3, 66),//Helaman 8:28
				},
				new VerseInfo?[]
				{
					null,//Helaman 9
					new VerseInfo(3, 67, 3, 68),//Helaman 9:1
					new VerseInfo(3, 68, 3, 69),//Helaman 9:2
					new VerseInfo(3, 70),//Helaman 9:3
					new VerseInfo(3, 71),//Helaman 9:4
					new VerseInfo(3, 72),//Helaman 9:5
					new VerseInfo(3, 73),//Helaman 9:6
					new VerseInfo(3, 74),//Helaman 9:7
					new VerseInfo(3, 75),//Helaman 9:8
					new VerseInfo(3, 76, 3, 77),//Helaman 9:9
					new VerseInfo(3, 78),//Helaman 9:10
					new VerseInfo(3, 79),//Helaman 9:11
					new VerseInfo(3, 80, 3, 81),//Helaman 9:12
					new VerseInfo(3, 82, 3, 83),//Helaman 9:13
					new VerseInfo(3, 83),//Helaman 9:14
					new VerseInfo(3, 84),//Helaman 9:15
					new VerseInfo(3, 85),//Helaman 9:16
					new VerseInfo(3, 86),//Helaman 9:17
					new VerseInfo(3, 87, 3, 88),//Helaman 9:18
					new VerseInfo(3, 89),//Helaman 9:19
					new VerseInfo(3, 90),//Helaman 9:20
					new VerseInfo(3, 91),//Helaman 9:21
					new VerseInfo(3, 92),//Helaman 9:22
					new VerseInfo(3, 93, 3, 94),//Helaman 9:23
					new VerseInfo(3, 95),//Helaman 9:24
					new VerseInfo(3, 96),//Helaman 9:25
					new VerseInfo(3, 97),//Helaman 9:26
					new VerseInfo(3, 97),//Helaman 9:27
					new VerseInfo(3, 97),//Helaman 9:28
					new VerseInfo(3, 98),//Helaman 9:29
					new VerseInfo(3, 98, 3, 99),//Helaman 9:30
					new VerseInfo(3, 100),//Helaman 9:31
					new VerseInfo(3, 101),//Helaman 9:32
					new VerseInfo(3, 101),//Helaman 9:33
					new VerseInfo(3, 102),//Helaman 9:34
					new VerseInfo(3, 103),//Helaman 9:35
					new VerseInfo(3, 104, 3, 105),//Helaman 9:36
					new VerseInfo(3, 106, 3, 107),//Helaman 9:37
					new VerseInfo(3, 108),//Helaman 9:38
					new VerseInfo(3, 109),//Helaman 9:39
					new VerseInfo(3, 110),//Helaman 9:40
					new VerseInfo(3, 110, 3, 111),//Helaman 9:41
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Helaman 10
					new VerseInfo(3, 112),//Helaman 10:1
					new VerseInfo(3, 113),//Helaman 10:2
					new VerseInfo(3, 114),//Helaman 10:3
					new VerseInfo(3, 115, 3, 116),//Helaman 10:4
					new VerseInfo(3, 117),//Helaman 10:5
					new VerseInfo(3, 118, 3, 119),//Helaman 10:6
					new VerseInfo(3, 120),//Helaman 10:7
					new VerseInfo(3, 121),//Helaman 10:8
					new VerseInfo(3, 122),//Helaman 10:9
					new VerseInfo(3, 123),//Helaman 10:10
					new VerseInfo(3, 124),//Helaman 10:11
					new VerseInfo(3, 125),//Helaman 10:12
					new VerseInfo(3, 126),//Helaman 10:13
					new VerseInfo(3, 127),//Helaman 10:14
					new VerseInfo(3, 128),//Helaman 10:15
					new VerseInfo(3, 129),//Helaman 10:16
					new VerseInfo(3, 130),//Helaman 10:17
					new VerseInfo(3, 131),//Helaman 10:18
					new VerseInfo(3, 132),//Helaman 10:19
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Helaman 11
					new VerseInfo(4, 1),//Helaman 11:1
					new VerseInfo(4, 2, 4, 3),//Helaman 11:2
					new VerseInfo(4, 4),//Helaman 11:3
					new VerseInfo(4, 4),//Helaman 11:4
					new VerseInfo(4, 5, 4, 6),//Helaman 11:5
					new VerseInfo(4, 7, 4, 8),//Helaman 11:6
					new VerseInfo(4, 9),//Helaman 11:7
					new VerseInfo(4, 10),//Helaman 11:8
					new VerseInfo(4, 11, 4, 12),//Helaman 11:9
					new VerseInfo(4, 12, 4, 13),//Helaman 11:10
					new VerseInfo(4, 14),//Helaman 11:11
					new VerseInfo(4, 15),//Helaman 11:12
					new VerseInfo(4, 16),//Helaman 11:13
					new VerseInfo(4, 17),//Helaman 11:14
					new VerseInfo(4, 18),//Helaman 11:15
					new VerseInfo(4, 19),//Helaman 11:16
					new VerseInfo(4, 20, 4, 21),//Helaman 11:17
					new VerseInfo(4, 22),//Helaman 11:18
					new VerseInfo(4, 23),//Helaman 11:19
					new VerseInfo(4, 24),//Helaman 11:20
					new VerseInfo(4, 25, 4, 26),//Helaman 11:21
					new VerseInfo(4, 27),//Helaman 11:22
					new VerseInfo(4, 28, 4, 29),//Helaman 11:23
					new VerseInfo(4, 30, 4, 31),//Helaman 11:24
					new VerseInfo(4, 32),//Helaman 11:25
					new VerseInfo(4, 33),//Helaman 11:26
					new VerseInfo(4, 34),//Helaman 11:27
					new VerseInfo(4, 35),//Helaman 11:28
					new VerseInfo(4, 36, 4, 37),//Helaman 11:29
					new VerseInfo(4, 38, 4, 39),//Helaman 11:30
					new VerseInfo(4, 39),//Helaman 11:31
					new VerseInfo(4, 40),//Helaman 11:32
					new VerseInfo(4, 41),//Helaman 11:33
					new VerseInfo(4, 42),//Helaman 11:34
					new VerseInfo(4, 43),//Helaman 11:35
					new VerseInfo(4, 44, 4, 46),//Helaman 11:36
					new VerseInfo(4, 47),//Helaman 11:37
					new VerseInfo(4, 47),//Helaman 11:38
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Helaman 12
					new VerseInfo(4, 48),//Helaman 12:1
					new VerseInfo(4, 49, 4, 51),//Helaman 12:2
					new VerseInfo(4, 52),//Helaman 12:3
					new VerseInfo(4, 53, 4, 54),//Helaman 12:4
					new VerseInfo(4, 54, 4, 55),//Helaman 12:5
					new VerseInfo(4, 56),//Helaman 12:6
					new VerseInfo(4, 57),//Helaman 12:7
					new VerseInfo(4, 58),//Helaman 12:8
					new VerseInfo(4, 59),//Helaman 12:9
					new VerseInfo(4, 59),//Helaman 12:10
					new VerseInfo(4, 60),//Helaman 12:11
					new VerseInfo(4, 60),//Helaman 12:12
					new VerseInfo(4, 61),//Helaman 12:13
					new VerseInfo(4, 61),//Helaman 12:14
					new VerseInfo(4, 62),//Helaman 12:15
					new VerseInfo(4, 63),//Helaman 12:16
					new VerseInfo(4, 64),//Helaman 12:17
					new VerseInfo(4, 65),//Helaman 12:18
					new VerseInfo(4, 66),//Helaman 12:19
					new VerseInfo(4, 67),//Helaman 12:20
					new VerseInfo(4, 68),//Helaman 12:21
					new VerseInfo(4, 69),//Helaman 12:22
					new VerseInfo(4, 70),//Helaman 12:23
					new VerseInfo(4, 71),//Helaman 12:24
					new VerseInfo(4, 72),//Helaman 12:25
					new VerseInfo(4, 73),//Helaman 12:26
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Helaman 13
					new VerseInfo(5, 1),//Helaman 13:1
					new VerseInfo(5, 2, 5, 3),//Helaman 13:2
					new VerseInfo(5, 4),//Helaman 13:3
					new VerseInfo(5, 5),//Helaman 13:4
					new VerseInfo(5, 6),//Helaman 13:5
					new VerseInfo(5, 7),//Helaman 13:6
					new VerseInfo(5, 8, 5, 9),//Helaman 13:7
					new VerseInfo(5, 10),//Helaman 13:8
					new VerseInfo(5, 11),//Helaman 13:9
					new VerseInfo(5, 12, 5, 13),//Helaman 13:10
					new VerseInfo(5, 14),//Helaman 13:11
					new VerseInfo(5, 15, 5, 16),//Helaman 13:12
					new VerseInfo(5, 16, 5, 17),//Helaman 13:13
					new VerseInfo(5, 17, 5, 19),//Helaman 13:14
					new VerseInfo(5, 20),//Helaman 13:15
					new VerseInfo(5, 21),//Helaman 13:16
					new VerseInfo(5, 22),//Helaman 13:17
					new VerseInfo(5, 23),//Helaman 13:18
					new VerseInfo(5, 24, 5, 25),//Helaman 13:19
					new VerseInfo(5, 26, 5, 27),//Helaman 13:20
					new VerseInfo(5, 28, 5, 29),//Helaman 13:21
					new VerseInfo(5, 30, 5, 31),//Helaman 13:22
					new VerseInfo(5, 32),//Helaman 13:23
					new VerseInfo(5, 33),//Helaman 13:24
					new VerseInfo(5, 34),//Helaman 13:25
					new VerseInfo(5, 35, 5, 36),//Helaman 13:26
					new VerseInfo(5, 37),//Helaman 13:27
					new VerseInfo(5, 38, 5, 39),//Helaman 13:28
					new VerseInfo(5, 40),//Helaman 13:29
					new VerseInfo(5, 41),//Helaman 13:30
					new VerseInfo(5, 41, 5, 42),//Helaman 13:31
					new VerseInfo(5, 42, 5, 44),//Helaman 13:32
					new VerseInfo(5, 44, 5, 45),//Helaman 13:33
					new VerseInfo(5, 46),//Helaman 13:34
					new VerseInfo(5, 47),//Helaman 13:35
					new VerseInfo(5, 48),//Helaman 13:36
					new VerseInfo(5, 49, 5, 50),//Helaman 13:37
					new VerseInfo(5, 51, 5, 52),//Helaman 13:38
					new VerseInfo(5, 53),//Helaman 13:39
				},
				new VerseInfo?[]
				{
					null,//Helaman 14
					new VerseInfo(5, 54),//Helaman 14:1
					new VerseInfo(5, 55),//Helaman 14:2
					new VerseInfo(5, 56),//Helaman 14:3
					new VerseInfo(5, 57, 5, 58),//Helaman 14:4
					new VerseInfo(5, 59),//Helaman 14:5
					new VerseInfo(5, 60),//Helaman 14:6
					new VerseInfo(5, 61),//Helaman 14:7
					new VerseInfo(5, 62),//Helaman 14:8
					new VerseInfo(5, 63),//Helaman 14:9
					new VerseInfo(5, 64),//Helaman 14:10
					new VerseInfo(5, 65),//Helaman 14:11
					new VerseInfo(5, 66),//Helaman 14:12
					new VerseInfo(5, 67),//Helaman 14:13
					new VerseInfo(5, 68),//Helaman 14:14
					new VerseInfo(5, 68, 5, 69),//Helaman 14:15
					new VerseInfo(5, 70),//Helaman 14:16
					new VerseInfo(5, 71),//Helaman 14:17
					new VerseInfo(5, 72, 5, 73),//Helaman 14:18
					new VerseInfo(5, 74),//Helaman 14:19
					new VerseInfo(5, 75, 5, 76),//Helaman 14:20
					new VerseInfo(5, 77),//Helaman 14:21
					new VerseInfo(5, 78),//Helaman 14:22
					new VerseInfo(5, 79),//Helaman 14:23
					new VerseInfo(5, 80),//Helaman 14:24
					new VerseInfo(5, 80),//Helaman 14:25
					new VerseInfo(5, 81),//Helaman 14:26
					new VerseInfo(5, 82),//Helaman 14:27
					new VerseInfo(5, 83),//Helaman 14:28
					new VerseInfo(5, 84),//Helaman 14:29
					new VerseInfo(5, 85),//Helaman 14:30
					new VerseInfo(5, 86),//Helaman 14:31
				},
				new VerseInfo?[]
				{
					null,//Helaman 15
					new VerseInfo(5, 87),//Helaman 15:1
					new VerseInfo(5, 87, 5, 88),//Helaman 15:2
					new VerseInfo(5, 89, 5, 90),//Helaman 15:3
					new VerseInfo(5, 91, 5, 92),//Helaman 15:4
					new VerseInfo(5, 93),//Helaman 15:5
					new VerseInfo(5, 94),//Helaman 15:6
					new VerseInfo(5, 95, 5, 96),//Helaman 15:7
					new VerseInfo(5, 97),//Helaman 15:8
					new VerseInfo(5, 98, 5, 99),//Helaman 15:9
					new VerseInfo(5, 100),//Helaman 15:10
					new VerseInfo(5, 101),//Helaman 15:11
					new VerseInfo(5, 102, 5, 103),//Helaman 15:12
					new VerseInfo(5, 104),//Helaman 15:13
					new VerseInfo(5, 105),//Helaman 15:14
					new VerseInfo(5, 106),//Helaman 15:15
					new VerseInfo(5, 107),//Helaman 15:16
					new VerseInfo(5, 108),//Helaman 15:17
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Helaman 16
					new VerseInfo(5, 109, 5, 110),//Helaman 16:1
					new VerseInfo(5, 111, 5, 112),//Helaman 16:2
					new VerseInfo(5, 113),//Helaman 16:3
					new VerseInfo(5, 114),//Helaman 16:4
					new VerseInfo(5, 115, 5, 116),//Helaman 16:5
					new VerseInfo(5, 117, 5, 118),//Helaman 16:6
					new VerseInfo(5, 119),//Helaman 16:7
					new VerseInfo(5, 120),//Helaman 16:8
					new VerseInfo(5, 121),//Helaman 16:9
					new VerseInfo(5, 122),//Helaman 16:10
					new VerseInfo(5, 123),//Helaman 16:11
					new VerseInfo(5, 124),//Helaman 16:12
					new VerseInfo(5, 125),//Helaman 16:13
					new VerseInfo(5, 126),//Helaman 16:14
					new VerseInfo(5, 127),//Helaman 16:15
					new VerseInfo(5, 128),//Helaman 16:16
					new VerseInfo(5, 129),//Helaman 16:17
					new VerseInfo(5, 129, 5, 130),//Helaman 16:18
					new VerseInfo(5, 131),//Helaman 16:19
					new VerseInfo(5, 132, 5, 133),//Helaman 16:20
					new VerseInfo(5, 134, 5, 135),//Helaman 16:21
					new VerseInfo(5, 136, 5, 137),//Helaman 16:22
					new VerseInfo(5, 138),//Helaman 16:23
					new VerseInfo(5, 139),//Helaman 16:24
					new VerseInfo(5, 140),//Helaman 16:25
				},
			}
		},
		{ "3 Nephi", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//3 Nephi 1
					new VerseInfo(1, 1),//3 Nephi 1:1
					new VerseInfo(1, 2),//3 Nephi 1:2
					new VerseInfo(1, 3),//3 Nephi 1:3
					new VerseInfo(1, 4),//3 Nephi 1:4
					new VerseInfo(1, 5),//3 Nephi 1:5
					new VerseInfo(1, 6),//3 Nephi 1:6
					new VerseInfo(1, 7),//3 Nephi 1:7
					new VerseInfo(1, 8),//3 Nephi 1:8
					new VerseInfo(1, 9),//3 Nephi 1:9
					new VerseInfo(1, 10),//3 Nephi 1:10
					new VerseInfo(1, 11),//3 Nephi 1:11
					new VerseInfo(1, 12),//3 Nephi 1:12
					new VerseInfo(1, 12, 1, 13),//3 Nephi 1:13
					new VerseInfo(1, 14, 1, 15),//3 Nephi 1:14
					new VerseInfo(1, 16, 1, 17),//3 Nephi 1:15
					new VerseInfo(1, 18),//3 Nephi 1:16
					new VerseInfo(1, 18, 1, 19),//3 Nephi 1:17
					new VerseInfo(1, 20),//3 Nephi 1:18
					new VerseInfo(1, 21, 1, 22),//3 Nephi 1:19
					new VerseInfo(1, 23),//3 Nephi 1:20
					new VerseInfo(1, 24),//3 Nephi 1:21
					new VerseInfo(1, 25, 1, 26),//3 Nephi 1:22
					new VerseInfo(1, 27, 1, 28),//3 Nephi 1:23
					new VerseInfo(1, 28, 1, 29),//3 Nephi 1:24
					new VerseInfo(1, 30, 1, 31),//3 Nephi 1:25
					new VerseInfo(1, 32),//3 Nephi 1:26
					new VerseInfo(1, 33, 1, 34),//3 Nephi 1:27
					new VerseInfo(1, 35),//3 Nephi 1:28
					new VerseInfo(1, 36),//3 Nephi 1:29
					new VerseInfo(1, 37),//3 Nephi 1:30
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//3 Nephi 2
					new VerseInfo(1, 38, 1, 39),//3 Nephi 2:1
					new VerseInfo(1, 39, 1, 40),//3 Nephi 2:2
					new VerseInfo(1, 41, 1, 42),//3 Nephi 2:3
					new VerseInfo(1, 43),//3 Nephi 2:4
					new VerseInfo(1, 43),//3 Nephi 2:5
					new VerseInfo(1, 44),//3 Nephi 2:6
					new VerseInfo(1, 44),//3 Nephi 2:7
					new VerseInfo(1, 45, 1, 46),//3 Nephi 2:8
					new VerseInfo(1, 46),//3 Nephi 2:9
					new VerseInfo(1, 47),//3 Nephi 2:10
					new VerseInfo(1, 48),//3 Nephi 2:11
					new VerseInfo(1, 49, 1, 50),//3 Nephi 2:12
					new VerseInfo(1, 51),//3 Nephi 2:13
					new VerseInfo(1, 52),//3 Nephi 2:14
					new VerseInfo(1, 52),//3 Nephi 2:15
					new VerseInfo(1, 53),//3 Nephi 2:16
					new VerseInfo(1, 54, 1, 55),//3 Nephi 2:17
					new VerseInfo(1, 55, 1, 56),//3 Nephi 2:18
					new VerseInfo(1, 57),//3 Nephi 2:19
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//3 Nephi 3
					new VerseInfo(2, 1, 2, 2),//3 Nephi 3:1
					new VerseInfo(2, 2, 2, 3),//3 Nephi 3:2
					new VerseInfo(2, 4),//3 Nephi 3:3
					new VerseInfo(2, 5),//3 Nephi 3:4
					new VerseInfo(2, 6),//3 Nephi 3:5
					new VerseInfo(2, 7),//3 Nephi 3:6
					new VerseInfo(2, 8),//3 Nephi 3:7
					new VerseInfo(2, 9, 2, 10),//3 Nephi 3:8
					new VerseInfo(2, 11),//3 Nephi 3:9
					new VerseInfo(2, 12),//3 Nephi 3:10
					new VerseInfo(2, 13, 2, 14),//3 Nephi 3:11
					new VerseInfo(2, 15, 2, 16),//3 Nephi 3:12
					new VerseInfo(2, 17),//3 Nephi 3:13
					new VerseInfo(2, 18, 2, 19),//3 Nephi 3:14
					new VerseInfo(2, 20),//3 Nephi 3:15
					new VerseInfo(2, 21),//3 Nephi 3:16
					new VerseInfo(2, 22),//3 Nephi 3:17
					new VerseInfo(2, 23),//3 Nephi 3:18
					new VerseInfo(2, 24),//3 Nephi 3:19
					new VerseInfo(2, 25),//3 Nephi 3:20
					new VerseInfo(2, 26, 2, 28),//3 Nephi 3:21
					new VerseInfo(2, 29, 2, 31),//3 Nephi 3:22
					new VerseInfo(2, 32),//3 Nephi 3:23
					new VerseInfo(2, 33, 2, 34),//3 Nephi 3:24
					new VerseInfo(2, 34, 2, 36),//3 Nephi 3:25
					new VerseInfo(2, 37, 2, 38),//3 Nephi 3:26
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 4
					new VerseInfo(2, 39, 2, 40),//3 Nephi 4:1
					new VerseInfo(2, 41),//3 Nephi 4:2
					new VerseInfo(2, 42),//3 Nephi 4:3
					new VerseInfo(2, 43, 2, 45),//3 Nephi 4:4
					new VerseInfo(2, 46),//3 Nephi 4:5
					new VerseInfo(2, 47, 2, 48),//3 Nephi 4:6
					new VerseInfo(2, 49, 2, 51),//3 Nephi 4:7
					new VerseInfo(2, 52),//3 Nephi 4:8
					new VerseInfo(2, 53),//3 Nephi 4:9
					new VerseInfo(2, 54, 2, 55),//3 Nephi 4:10
					new VerseInfo(2, 55, 2, 56),//3 Nephi 4:11
					new VerseInfo(2, 57),//3 Nephi 4:12
					new VerseInfo(2, 58, 2, 59),//3 Nephi 4:13
					new VerseInfo(2, 60),//3 Nephi 4:14
					new VerseInfo(2, 61, 2, 62),//3 Nephi 4:15
					new VerseInfo(2, 63, 2, 64),//3 Nephi 4:16
					new VerseInfo(2, 65),//3 Nephi 4:17
					new VerseInfo(2, 66),//3 Nephi 4:18
					new VerseInfo(2, 66, 2, 67),//3 Nephi 4:19
					new VerseInfo(2, 68),//3 Nephi 4:20
					new VerseInfo(2, 69),//3 Nephi 4:21
					new VerseInfo(2, 70),//3 Nephi 4:22
					new VerseInfo(2, 71),//3 Nephi 4:23
					new VerseInfo(2, 72),//3 Nephi 4:24
					new VerseInfo(2, 73),//3 Nephi 4:25
					new VerseInfo(2, 74),//3 Nephi 4:26
					new VerseInfo(2, 75),//3 Nephi 4:27
					new VerseInfo(2, 75, 2, 76),//3 Nephi 4:28
					new VerseInfo(2, 76),//3 Nephi 4:29
					new VerseInfo(2, 77),//3 Nephi 4:30
					new VerseInfo(2, 78),//3 Nephi 4:31
					new VerseInfo(2, 79),//3 Nephi 4:32
					new VerseInfo(2, 80, 2, 81),//3 Nephi 4:33
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//3 Nephi 5
					new VerseInfo(2, 82, 2, 83),//3 Nephi 5:1
					new VerseInfo(2, 83, 2, 84),//3 Nephi 5:2
					new VerseInfo(2, 85),//3 Nephi 5:3
					new VerseInfo(2, 86, 2, 87),//3 Nephi 5:4
					new VerseInfo(2, 88),//3 Nephi 5:5
					new VerseInfo(2, 89),//3 Nephi 5:6
					new VerseInfo(2, 90, 2, 91),//3 Nephi 5:7
					new VerseInfo(2, 91, 2, 92),//3 Nephi 5:8
					new VerseInfo(2, 93),//3 Nephi 5:9
					new VerseInfo(2, 94),//3 Nephi 5:10
					new VerseInfo(2, 95),//3 Nephi 5:11
					new VerseInfo(2, 96),//3 Nephi 5:12
					new VerseInfo(2, 97),//3 Nephi 5:13
					new VerseInfo(2, 98),//3 Nephi 5:14
					new VerseInfo(2, 99),//3 Nephi 5:15
					new VerseInfo(2, 100),//3 Nephi 5:16
					new VerseInfo(2, 100),//3 Nephi 5:17
					new VerseInfo(2, 101),//3 Nephi 5:18
					new VerseInfo(2, 102),//3 Nephi 5:19
					new VerseInfo(2, 102, 2, 103),//3 Nephi 5:20
					new VerseInfo(2, 104),//3 Nephi 5:21
					new VerseInfo(2, 105),//3 Nephi 5:22
					new VerseInfo(2, 106),//3 Nephi 5:23
					new VerseInfo(2, 107),//3 Nephi 5:24
					new VerseInfo(2, 108),//3 Nephi 5:25
					new VerseInfo(2, 109),//3 Nephi 5:26
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//3 Nephi 6
					new VerseInfo(3, 1),//3 Nephi 6:1
					new VerseInfo(3, 2, 3, 3),//3 Nephi 6:2
					new VerseInfo(3, 4),//3 Nephi 6:3
					new VerseInfo(3, 5),//3 Nephi 6:4
					new VerseInfo(3, 6),//3 Nephi 6:5
					new VerseInfo(3, 7),//3 Nephi 6:6
					new VerseInfo(3, 8),//3 Nephi 6:7
					new VerseInfo(3, 8),//3 Nephi 6:8
					new VerseInfo(3, 9),//3 Nephi 6:9
					new VerseInfo(3, 10, 3, 11),//3 Nephi 6:10
					new VerseInfo(3, 11),//3 Nephi 6:11
					new VerseInfo(3, 12, 3, 13),//3 Nephi 6:12
					new VerseInfo(3, 14),//3 Nephi 6:13
					new VerseInfo(3, 15, 3, 16),//3 Nephi 6:14
					new VerseInfo(3, 17),//3 Nephi 6:15
					new VerseInfo(3, 18),//3 Nephi 6:16
					new VerseInfo(3, 19),//3 Nephi 6:17
					new VerseInfo(3, 20),//3 Nephi 6:18
					new VerseInfo(3, 21),//3 Nephi 6:19
					new VerseInfo(3, 22, 3, 23),//3 Nephi 6:20
					new VerseInfo(3, 24, 3, 26),//3 Nephi 6:21
					new VerseInfo(3, 27),//3 Nephi 6:22
					new VerseInfo(3, 28),//3 Nephi 6:23
					new VerseInfo(3, 29),//3 Nephi 6:24
					new VerseInfo(3, 30),//3 Nephi 6:25
					new VerseInfo(3, 31),//3 Nephi 6:26
					new VerseInfo(3, 32),//3 Nephi 6:27
					new VerseInfo(3, 33),//3 Nephi 6:28
					new VerseInfo(3, 34),//3 Nephi 6:29
					new VerseInfo(3, 35),//3 Nephi 6:30
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//3 Nephi 7
					new VerseInfo(3, 36),//3 Nephi 7:1
					new VerseInfo(3, 37),//3 Nephi 7:2
					new VerseInfo(3, 38),//3 Nephi 7:3
					new VerseInfo(3, 39),//3 Nephi 7:4
					new VerseInfo(3, 40),//3 Nephi 7:5
					new VerseInfo(3, 41),//3 Nephi 7:6
					new VerseInfo(3, 42),//3 Nephi 7:7
					new VerseInfo(3, 43),//3 Nephi 7:8
					new VerseInfo(3, 44),//3 Nephi 7:9
					new VerseInfo(3, 44, 3, 45),//3 Nephi 7:10
					new VerseInfo(3, 46, 3, 47),//3 Nephi 7:11
					new VerseInfo(3, 48, 3, 50),//3 Nephi 7:12
					new VerseInfo(3, 50, 3, 51),//3 Nephi 7:13
					new VerseInfo(3, 52, 3, 55),//3 Nephi 7:14
					new VerseInfo(3, 56),//3 Nephi 7:15
					new VerseInfo(3, 57),//3 Nephi 7:16
					new VerseInfo(3, 58),//3 Nephi 7:17
					new VerseInfo(3, 59),//3 Nephi 7:18
					new VerseInfo(3, 60),//3 Nephi 7:19
					new VerseInfo(3, 61),//3 Nephi 7:20
					new VerseInfo(3, 62, 3, 63),//3 Nephi 7:21
					new VerseInfo(3, 64, 3, 65),//3 Nephi 7:22
					new VerseInfo(3, 66, 3, 67),//3 Nephi 7:23
					new VerseInfo(3, 68),//3 Nephi 7:24
					new VerseInfo(3, 69),//3 Nephi 7:25
					new VerseInfo(3, 70),//3 Nephi 7:26
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//3 Nephi 8
					new VerseInfo(4, 1, 4, 2),//3 Nephi 8:1
					new VerseInfo(4, 3),//3 Nephi 8:2
					new VerseInfo(4, 3, 4, 4),//3 Nephi 8:3
					new VerseInfo(4, 5),//3 Nephi 8:4
					new VerseInfo(4, 6),//3 Nephi 8:5
					new VerseInfo(4, 7),//3 Nephi 8:6
					new VerseInfo(4, 7),//3 Nephi 8:7
					new VerseInfo(4, 8),//3 Nephi 8:8
					new VerseInfo(4, 8),//3 Nephi 8:9
					new VerseInfo(4, 9),//3 Nephi 8:10
					new VerseInfo(4, 9),//3 Nephi 8:11
					new VerseInfo(4, 10),//3 Nephi 8:12
					new VerseInfo(4, 11),//3 Nephi 8:13
					new VerseInfo(4, 11),//3 Nephi 8:14
					new VerseInfo(4, 12),//3 Nephi 8:15
					new VerseInfo(4, 13),//3 Nephi 8:16
					new VerseInfo(4, 14),//3 Nephi 8:17
					new VerseInfo(4, 15),//3 Nephi 8:18
					new VerseInfo(4, 16, 4, 17),//3 Nephi 8:19
					new VerseInfo(4, 18),//3 Nephi 8:20
					new VerseInfo(4, 19),//3 Nephi 8:21
					new VerseInfo(4, 20),//3 Nephi 8:22
					new VerseInfo(4, 21, 4, 22),//3 Nephi 8:23
					new VerseInfo(4, 23),//3 Nephi 8:24
					new VerseInfo(4, 24, 4, 25),//3 Nephi 8:25
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 9
					new VerseInfo(4, 26),//3 Nephi 9:1
					new VerseInfo(4, 26, 4, 27),//3 Nephi 9:2
					new VerseInfo(4, 28),//3 Nephi 9:3
					new VerseInfo(4, 29),//3 Nephi 9:4
					new VerseInfo(4, 30),//3 Nephi 9:5
					new VerseInfo(4, 31),//3 Nephi 9:6
					new VerseInfo(4, 32, 4, 33),//3 Nephi 9:7
					new VerseInfo(4, 34, 4, 35),//3 Nephi 9:8
					new VerseInfo(4, 36, 4, 37),//3 Nephi 9:9
					new VerseInfo(4, 38),//3 Nephi 9:10
					new VerseInfo(4, 39),//3 Nephi 9:11
					new VerseInfo(4, 40),//3 Nephi 9:12
					new VerseInfo(4, 41),//3 Nephi 9:13
					new VerseInfo(4, 42, 4, 43),//3 Nephi 9:14
					new VerseInfo(4, 44, 4, 45),//3 Nephi 9:15
					new VerseInfo(4, 46),//3 Nephi 9:16
					new VerseInfo(4, 47),//3 Nephi 9:17
					new VerseInfo(4, 48),//3 Nephi 9:18
					new VerseInfo(4, 49),//3 Nephi 9:19
					new VerseInfo(4, 49, 4, 50),//3 Nephi 9:20
					new VerseInfo(4, 51),//3 Nephi 9:21
					new VerseInfo(4, 51, 4, 52),//3 Nephi 9:22
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//3 Nephi 10
					new VerseInfo(4, 53, 4, 54),//3 Nephi 10:1
					new VerseInfo(4, 54),//3 Nephi 10:2
					new VerseInfo(4, 55),//3 Nephi 10:3
					new VerseInfo(4, 55),//3 Nephi 10:4
					new VerseInfo(4, 56, 4, 57),//3 Nephi 10:5
					new VerseInfo(4, 58),//3 Nephi 10:6
					new VerseInfo(4, 59),//3 Nephi 10:7
					new VerseInfo(4, 60),//3 Nephi 10:8
					new VerseInfo(4, 61, 4, 62),//3 Nephi 10:9
					new VerseInfo(4, 63, 4, 64),//3 Nephi 10:10
					new VerseInfo(4, 65),//3 Nephi 10:11
					new VerseInfo(4, 66),//3 Nephi 10:12
					new VerseInfo(4, 67, 4, 68),//3 Nephi 10:13
					new VerseInfo(4, 69),//3 Nephi 10:14
					new VerseInfo(4, 70),//3 Nephi 10:15
					new VerseInfo(4, 71),//3 Nephi 10:16
					new VerseInfo(4, 72, 4, 73),//3 Nephi 10:17
					new VerseInfo(4, 74),//3 Nephi 10:18
					new VerseInfo(4, 74, 4, 75),//3 Nephi 10:19
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//3 Nephi 11
					new VerseInfo(5, 1, 5, 2),//3 Nephi 11:1
					new VerseInfo(5, 3),//3 Nephi 11:2
					new VerseInfo(5, 4, 5, 5),//3 Nephi 11:3
					new VerseInfo(5, 6),//3 Nephi 11:4
					new VerseInfo(5, 6, 5, 7),//3 Nephi 11:5
					new VerseInfo(5, 7, 5, 8),//3 Nephi 11:6
					new VerseInfo(5, 8),//3 Nephi 11:7
					new VerseInfo(5, 9, 5, 10),//3 Nephi 11:8
					new VerseInfo(5, 11),//3 Nephi 11:9
					new VerseInfo(5, 11),//3 Nephi 11:10
					new VerseInfo(5, 12),//3 Nephi 11:11
					new VerseInfo(5, 13),//3 Nephi 11:12
					new VerseInfo(5, 14),//3 Nephi 11:13
					new VerseInfo(5, 14),//3 Nephi 11:14
					new VerseInfo(5, 15, 5, 16),//3 Nephi 11:15
					new VerseInfo(5, 17),//3 Nephi 11:16
					new VerseInfo(5, 17),//3 Nephi 11:17
					new VerseInfo(5, 18),//3 Nephi 11:18
					new VerseInfo(5, 19),//3 Nephi 11:19
					new VerseInfo(5, 20),//3 Nephi 11:20
					new VerseInfo(5, 21),//3 Nephi 11:21
					new VerseInfo(5, 22, 5, 23),//3 Nephi 11:22
					new VerseInfo(5, 24),//3 Nephi 11:23
					new VerseInfo(5, 25),//3 Nephi 11:24
					new VerseInfo(5, 25),//3 Nephi 11:25
					new VerseInfo(5, 26),//3 Nephi 11:26
					new VerseInfo(5, 27),//3 Nephi 11:27
					new VerseInfo(5, 28, 5, 29),//3 Nephi 11:28
					new VerseInfo(5, 30),//3 Nephi 11:29
					new VerseInfo(5, 31),//3 Nephi 11:30
					new VerseInfo(5, 32),//3 Nephi 11:31
					new VerseInfo(5, 32, 5, 33),//3 Nephi 11:32
					new VerseInfo(5, 34),//3 Nephi 11:33
					new VerseInfo(5, 35),//3 Nephi 11:34
					new VerseInfo(5, 36, 5, 37),//3 Nephi 11:35
					new VerseInfo(5, 38),//3 Nephi 11:36
					new VerseInfo(5, 39),//3 Nephi 11:37
					new VerseInfo(5, 40),//3 Nephi 11:38
					new VerseInfo(5, 41),//3 Nephi 11:39
					new VerseInfo(5, 42),//3 Nephi 11:40
					new VerseInfo(5, 43),//3 Nephi 11:41
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 12
					new VerseInfo(5, 44, 5, 47),//3 Nephi 12:1
					new VerseInfo(5, 48, 5, 49),//3 Nephi 12:2
					new VerseInfo(5, 50),//3 Nephi 12:3
					new VerseInfo(5, 51),//3 Nephi 12:4
					new VerseInfo(5, 52),//3 Nephi 12:5
					new VerseInfo(5, 53),//3 Nephi 12:6
					new VerseInfo(5, 54),//3 Nephi 12:7
					new VerseInfo(5, 55),//3 Nephi 12:8
					new VerseInfo(5, 56),//3 Nephi 12:9
					new VerseInfo(5, 57),//3 Nephi 12:10
					new VerseInfo(5, 58),//3 Nephi 12:11
					new VerseInfo(5, 59),//3 Nephi 12:12
					new VerseInfo(5, 60),//3 Nephi 12:13
					new VerseInfo(5, 61),//3 Nephi 12:14
					new VerseInfo(5, 62),//3 Nephi 12:15
					new VerseInfo(5, 63),//3 Nephi 12:16
					new VerseInfo(5, 64),//3 Nephi 12:17
					new VerseInfo(5, 65),//3 Nephi 12:18
					new VerseInfo(5, 66, 5, 67),//3 Nephi 12:19
					new VerseInfo(5, 67, 5, 68),//3 Nephi 12:20
					new VerseInfo(5, 69),//3 Nephi 12:21
					new VerseInfo(5, 70),//3 Nephi 12:22
					new VerseInfo(5, 71),//3 Nephi 12:23
					new VerseInfo(5, 72),//3 Nephi 12:24
					new VerseInfo(5, 73),//3 Nephi 12:25
					new VerseInfo(5, 74, 5, 75),//3 Nephi 12:26
					new VerseInfo(5, 76),//3 Nephi 12:27
					new VerseInfo(5, 77),//3 Nephi 12:28
					new VerseInfo(5, 78),//3 Nephi 12:29
					new VerseInfo(5, 78),//3 Nephi 12:30
					new VerseInfo(5, 79),//3 Nephi 12:31
					new VerseInfo(5, 80),//3 Nephi 12:32
					new VerseInfo(5, 81),//3 Nephi 12:33
					new VerseInfo(5, 82),//3 Nephi 12:34
					new VerseInfo(5, 82),//3 Nephi 12:35
					new VerseInfo(5, 82),//3 Nephi 12:36
					new VerseInfo(5, 83),//3 Nephi 12:37
					new VerseInfo(5, 84),//3 Nephi 12:38
					new VerseInfo(5, 85),//3 Nephi 12:39
					new VerseInfo(5, 86),//3 Nephi 12:40
					new VerseInfo(5, 87),//3 Nephi 12:41
					new VerseInfo(5, 88),//3 Nephi 12:42
					new VerseInfo(5, 89),//3 Nephi 12:43
					new VerseInfo(5, 90),//3 Nephi 12:44
					new VerseInfo(5, 91),//3 Nephi 12:45
					new VerseInfo(5, 91),//3 Nephi 12:46
					new VerseInfo(5, 92),//3 Nephi 12:47
					new VerseInfo(5, 92),//3 Nephi 12:48
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 13
					new VerseInfo(5, 93),//3 Nephi 13:1
					new VerseInfo(5, 94),//3 Nephi 13:2
					new VerseInfo(5, 95),//3 Nephi 13:3
					new VerseInfo(5, 96),//3 Nephi 13:4
					new VerseInfo(5, 97),//3 Nephi 13:5
					new VerseInfo(5, 98),//3 Nephi 13:6
					new VerseInfo(5, 99),//3 Nephi 13:7
					new VerseInfo(5, 100),//3 Nephi 13:8
					new VerseInfo(5, 101, 5, 102),//3 Nephi 13:9
					new VerseInfo(5, 103),//3 Nephi 13:10
					new VerseInfo(5, 104),//3 Nephi 13:11
					new VerseInfo(5, 105),//3 Nephi 13:12
					new VerseInfo(5, 106),//3 Nephi 13:13
					new VerseInfo(5, 107),//3 Nephi 13:14
					new VerseInfo(5, 107),//3 Nephi 13:15
					new VerseInfo(5, 108),//3 Nephi 13:16
					new VerseInfo(5, 109),//3 Nephi 13:17
					new VerseInfo(5, 109),//3 Nephi 13:18
					new VerseInfo(5, 110),//3 Nephi 13:19
					new VerseInfo(5, 111),//3 Nephi 13:20
					new VerseInfo(5, 112),//3 Nephi 13:21
					new VerseInfo(5, 113),//3 Nephi 13:22
					new VerseInfo(5, 114),//3 Nephi 13:23
					new VerseInfo(5, 115),//3 Nephi 13:24
					new VerseInfo(6, 1, 6, 3),//3 Nephi 13:25
					new VerseInfo(6, 4),//3 Nephi 13:26
					new VerseInfo(6, 5),//3 Nephi 13:27
					new VerseInfo(6, 6),//3 Nephi 13:28
					new VerseInfo(6, 7),//3 Nephi 13:29
					new VerseInfo(6, 8),//3 Nephi 13:30
					new VerseInfo(6, 9),//3 Nephi 13:31
					new VerseInfo(6, 10),//3 Nephi 13:32
					new VerseInfo(6, 11),//3 Nephi 13:33
					new VerseInfo(6, 12),//3 Nephi 13:34
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//3 Nephi 14
					new VerseInfo(6, 13),//3 Nephi 14:1
					new VerseInfo(6, 14),//3 Nephi 14:2
					new VerseInfo(6, 15),//3 Nephi 14:3
					new VerseInfo(6, 16),//3 Nephi 14:4
					new VerseInfo(6, 17),//3 Nephi 14:5
					new VerseInfo(6, 18),//3 Nephi 14:6
					new VerseInfo(6, 19),//3 Nephi 14:7
					new VerseInfo(6, 20),//3 Nephi 14:8
					new VerseInfo(6, 21),//3 Nephi 14:9
					new VerseInfo(6, 22),//3 Nephi 14:10
					new VerseInfo(6, 23),//3 Nephi 14:11
					new VerseInfo(6, 24),//3 Nephi 14:12
					new VerseInfo(6, 25),//3 Nephi 14:13
					new VerseInfo(6, 26),//3 Nephi 14:14
					new VerseInfo(6, 27),//3 Nephi 14:15
					new VerseInfo(6, 28),//3 Nephi 14:16
					new VerseInfo(6, 29),//3 Nephi 14:17
					new VerseInfo(6, 30),//3 Nephi 14:18
					new VerseInfo(6, 31),//3 Nephi 14:19
					new VerseInfo(6, 32),//3 Nephi 14:20
					new VerseInfo(6, 33),//3 Nephi 14:21
					new VerseInfo(6, 34),//3 Nephi 14:22
					new VerseInfo(6, 35),//3 Nephi 14:23
					new VerseInfo(6, 36),//3 Nephi 14:24
					new VerseInfo(6, 36),//3 Nephi 14:25
					new VerseInfo(6, 37),//3 Nephi 14:26
					new VerseInfo(6, 37),//3 Nephi 14:27
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//3 Nephi 15
					new VerseInfo(7, 1, 7, 2),//3 Nephi 15:1
					new VerseInfo(7, 3),//3 Nephi 15:2
					new VerseInfo(7, 4),//3 Nephi 15:3
					new VerseInfo(7, 5),//3 Nephi 15:4
					new VerseInfo(7, 6),//3 Nephi 15:5
					new VerseInfo(7, 7),//3 Nephi 15:6
					new VerseInfo(7, 8),//3 Nephi 15:7
					new VerseInfo(7, 9),//3 Nephi 15:8
					new VerseInfo(7, 10),//3 Nephi 15:9
					new VerseInfo(7, 11, 7, 12),//3 Nephi 15:10
					new VerseInfo(7, 13),//3 Nephi 15:11
					new VerseInfo(7, 13),//3 Nephi 15:12
					new VerseInfo(7, 14),//3 Nephi 15:13
					new VerseInfo(7, 15),//3 Nephi 15:14
					new VerseInfo(7, 15),//3 Nephi 15:15
					new VerseInfo(7, 16),//3 Nephi 15:16
					new VerseInfo(7, 16),//3 Nephi 15:17
					new VerseInfo(7, 17),//3 Nephi 15:18
					new VerseInfo(7, 18),//3 Nephi 15:19
					new VerseInfo(7, 19),//3 Nephi 15:20
					new VerseInfo(7, 20),//3 Nephi 15:21
					new VerseInfo(7, 21),//3 Nephi 15:22
					new VerseInfo(7, 22),//3 Nephi 15:23
					new VerseInfo(7, 23),//3 Nephi 15:24
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//3 Nephi 16
					new VerseInfo(7, 24),//3 Nephi 16:1
					new VerseInfo(7, 25),//3 Nephi 16:2
					new VerseInfo(7, 26),//3 Nephi 16:3
					new VerseInfo(7, 27, 7, 28),//3 Nephi 16:4
					new VerseInfo(7, 29),//3 Nephi 16:5
					new VerseInfo(7, 30),//3 Nephi 16:6
					new VerseInfo(7, 31),//3 Nephi 16:7
					new VerseInfo(7, 32),//3 Nephi 16:8
					new VerseInfo(7, 33),//3 Nephi 16:9
					new VerseInfo(7, 34, 7, 35),//3 Nephi 16:10
					new VerseInfo(7, 36),//3 Nephi 16:11
					new VerseInfo(7, 37),//3 Nephi 16:12
					new VerseInfo(7, 38),//3 Nephi 16:13
					new VerseInfo(7, 39),//3 Nephi 16:14
					new VerseInfo(7, 40, 7, 41),//3 Nephi 16:15
					new VerseInfo(7, 42),//3 Nephi 16:16
					new VerseInfo(7, 43),//3 Nephi 16:17
					new VerseInfo(7, 43),//3 Nephi 16:18
					new VerseInfo(7, 44),//3 Nephi 16:19
					new VerseInfo(7, 45),//3 Nephi 16:20
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//3 Nephi 17
					new VerseInfo(8, 1),//3 Nephi 17:1
					new VerseInfo(8, 2),//3 Nephi 17:2
					new VerseInfo(8, 3),//3 Nephi 17:3
					new VerseInfo(8, 4),//3 Nephi 17:4
					new VerseInfo(8, 5),//3 Nephi 17:5
					new VerseInfo(8, 6),//3 Nephi 17:6
					new VerseInfo(8, 6, 8, 8),//3 Nephi 17:7
					new VerseInfo(8, 8),//3 Nephi 17:8
					new VerseInfo(8, 9),//3 Nephi 17:9
					new VerseInfo(8, 10, 8, 11),//3 Nephi 17:10
					new VerseInfo(8, 12),//3 Nephi 17:11
					new VerseInfo(8, 13),//3 Nephi 17:12
					new VerseInfo(8, 14),//3 Nephi 17:13
					new VerseInfo(8, 15),//3 Nephi 17:14
					new VerseInfo(8, 16),//3 Nephi 17:15
					new VerseInfo(8, 17),//3 Nephi 17:16
					new VerseInfo(8, 18, 8, 19),//3 Nephi 17:17
					new VerseInfo(8, 20),//3 Nephi 17:18
					new VerseInfo(8, 21),//3 Nephi 17:19
					new VerseInfo(8, 22),//3 Nephi 17:20
					new VerseInfo(8, 23),//3 Nephi 17:21
					new VerseInfo(8, 24),//3 Nephi 17:22
					new VerseInfo(8, 24),//3 Nephi 17:23
					new VerseInfo(8, 25, 8, 26),//3 Nephi 17:24
					new VerseInfo(8, 26, 8, 27),//3 Nephi 17:25
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//3 Nephi 18
					new VerseInfo(8, 28),//3 Nephi 18:1
					new VerseInfo(8, 29),//3 Nephi 18:2
					new VerseInfo(8, 30),//3 Nephi 18:3
					new VerseInfo(8, 31),//3 Nephi 18:4
					new VerseInfo(8, 32),//3 Nephi 18:5
					new VerseInfo(8, 33),//3 Nephi 18:6
					new VerseInfo(8, 34, 8, 36),//3 Nephi 18:7
					new VerseInfo(8, 37),//3 Nephi 18:8
					new VerseInfo(8, 38),//3 Nephi 18:9
					new VerseInfo(8, 39),//3 Nephi 18:10
					new VerseInfo(8, 40, 8, 41),//3 Nephi 18:11
					new VerseInfo(8, 42, 8, 43),//3 Nephi 18:12
					new VerseInfo(8, 44, 8, 45),//3 Nephi 18:13
					new VerseInfo(8, 46),//3 Nephi 18:14
					new VerseInfo(8, 47),//3 Nephi 18:15
					new VerseInfo(8, 48, 8, 49),//3 Nephi 18:16
					new VerseInfo(8, 50),//3 Nephi 18:17
					new VerseInfo(8, 50, 8, 51),//3 Nephi 18:18
					new VerseInfo(8, 51),//3 Nephi 18:19
					new VerseInfo(8, 51),//3 Nephi 18:20
					new VerseInfo(8, 52),//3 Nephi 18:21
					new VerseInfo(8, 53),//3 Nephi 18:22
					new VerseInfo(8, 54),//3 Nephi 18:23
					new VerseInfo(8, 54, 8, 56),//3 Nephi 18:24
					new VerseInfo(8, 56, 8, 57),//3 Nephi 18:25
					new VerseInfo(8, 58),//3 Nephi 18:26
					new VerseInfo(8, 59),//3 Nephi 18:27
					new VerseInfo(8, 60),//3 Nephi 18:28
					new VerseInfo(8, 60, 8, 61),//3 Nephi 18:29
					new VerseInfo(8, 61, 8, 62),//3 Nephi 18:30
					new VerseInfo(8, 63),//3 Nephi 18:31
					new VerseInfo(8, 64, 8, 65),//3 Nephi 18:32
					new VerseInfo(8, 66),//3 Nephi 18:33
					new VerseInfo(8, 67, 8, 68),//3 Nephi 18:34
					new VerseInfo(8, 69),//3 Nephi 18:35
					new VerseInfo(8, 70),//3 Nephi 18:36
					new VerseInfo(8, 71, 8, 72),//3 Nephi 18:37
					new VerseInfo(8, 73),//3 Nephi 18:38
					new VerseInfo(8, 74, 8, 75),//3 Nephi 18:39
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//3 Nephi 19
					new VerseInfo(9, 1),//3 Nephi 19:1
					new VerseInfo(9, 2),//3 Nephi 19:2
					new VerseInfo(9, 3),//3 Nephi 19:3
					new VerseInfo(9, 4, 9, 5),//3 Nephi 19:4
					new VerseInfo(9, 6),//3 Nephi 19:5
					new VerseInfo(9, 7),//3 Nephi 19:6
					new VerseInfo(9, 8, 9, 9),//3 Nephi 19:7
					new VerseInfo(9, 10),//3 Nephi 19:8
					new VerseInfo(9, 10),//3 Nephi 19:9
					new VerseInfo(9, 11),//3 Nephi 19:10
					new VerseInfo(9, 12),//3 Nephi 19:11
					new VerseInfo(9, 13),//3 Nephi 19:12
					new VerseInfo(9, 14),//3 Nephi 19:13
					new VerseInfo(9, 15),//3 Nephi 19:14
					new VerseInfo(9, 16),//3 Nephi 19:15
					new VerseInfo(9, 17),//3 Nephi 19:16
					new VerseInfo(9, 18),//3 Nephi 19:17
					new VerseInfo(9, 19),//3 Nephi 19:18
					new VerseInfo(9, 20),//3 Nephi 19:19
					new VerseInfo(9, 20),//3 Nephi 19:20
					new VerseInfo(9, 21),//3 Nephi 19:21
					new VerseInfo(9, 22),//3 Nephi 19:22
					new VerseInfo(9, 23),//3 Nephi 19:23
					new VerseInfo(9, 24),//3 Nephi 19:24
					new VerseInfo(9, 25, 9, 26),//3 Nephi 19:25
					new VerseInfo(9, 27),//3 Nephi 19:26
					new VerseInfo(9, 28),//3 Nephi 19:27
					new VerseInfo(9, 28, 9, 29),//3 Nephi 19:28
					new VerseInfo(9, 30),//3 Nephi 19:29
					new VerseInfo(9, 31),//3 Nephi 19:30
					new VerseInfo(9, 32),//3 Nephi 19:31
					new VerseInfo(9, 32),//3 Nephi 19:32
					new VerseInfo(9, 33),//3 Nephi 19:33
					new VerseInfo(9, 34),//3 Nephi 19:34
					new VerseInfo(9, 35),//3 Nephi 19:35
					new VerseInfo(9, 36),//3 Nephi 19:36
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 20
					new VerseInfo(9, 37, 9, 38),//3 Nephi 20:1
					new VerseInfo(9, 39),//3 Nephi 20:2
					new VerseInfo(9, 40),//3 Nephi 20:3
					new VerseInfo(9, 41),//3 Nephi 20:4
					new VerseInfo(9, 42),//3 Nephi 20:5
					new VerseInfo(9, 43),//3 Nephi 20:6
					new VerseInfo(9, 43),//3 Nephi 20:7
					new VerseInfo(9, 44),//3 Nephi 20:8
					new VerseInfo(9, 45),//3 Nephi 20:9
					new VerseInfo(9, 46),//3 Nephi 20:10
					new VerseInfo(9, 47),//3 Nephi 20:11
					new VerseInfo(9, 48, 9, 49),//3 Nephi 20:12
					new VerseInfo(9, 49),//3 Nephi 20:13
					new VerseInfo(9, 50),//3 Nephi 20:14
					new VerseInfo(9, 51),//3 Nephi 20:15
					new VerseInfo(9, 51, 9, 52),//3 Nephi 20:16
					new VerseInfo(9, 53),//3 Nephi 20:17
					new VerseInfo(9, 54),//3 Nephi 20:18
					new VerseInfo(9, 54, 9, 55),//3 Nephi 20:19
					new VerseInfo(9, 56),//3 Nephi 20:20
					new VerseInfo(9, 57),//3 Nephi 20:21
					new VerseInfo(9, 58, 9, 59),//3 Nephi 20:22
					new VerseInfo(9, 60, 9, 61),//3 Nephi 20:23
					new VerseInfo(9, 62),//3 Nephi 20:24
					new VerseInfo(9, 63),//3 Nephi 20:25
					new VerseInfo(9, 64),//3 Nephi 20:26
					new VerseInfo(9, 65),//3 Nephi 20:27
					new VerseInfo(9, 65, 9, 66),//3 Nephi 20:28
					new VerseInfo(9, 67, 9, 68),//3 Nephi 20:29
					new VerseInfo(9, 69),//3 Nephi 20:30
					new VerseInfo(9, 69),//3 Nephi 20:31
					new VerseInfo(9, 70),//3 Nephi 20:32
					new VerseInfo(9, 71),//3 Nephi 20:33
					new VerseInfo(9, 72),//3 Nephi 20:34
					new VerseInfo(9, 73),//3 Nephi 20:35
					new VerseInfo(9, 74),//3 Nephi 20:36
					new VerseInfo(9, 75),//3 Nephi 20:37
					new VerseInfo(9, 76),//3 Nephi 20:38
					new VerseInfo(9, 77),//3 Nephi 20:39
					new VerseInfo(9, 78),//3 Nephi 20:40
					new VerseInfo(9, 79),//3 Nephi 20:41
					new VerseInfo(9, 80),//3 Nephi 20:42
					new VerseInfo(9, 81),//3 Nephi 20:43
					new VerseInfo(9, 82),//3 Nephi 20:44
					new VerseInfo(9, 83),//3 Nephi 20:45
					new VerseInfo(9, 84, 9, 85),//3 Nephi 20:46
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 21
					new VerseInfo(9, 86),//3 Nephi 21:1
					new VerseInfo(9, 87, 9, 88),//3 Nephi 21:2
					new VerseInfo(9, 89),//3 Nephi 21:3
					new VerseInfo(9, 89, 9, 90),//3 Nephi 21:4
					new VerseInfo(9, 91),//3 Nephi 21:5
					new VerseInfo(9, 92),//3 Nephi 21:6
					new VerseInfo(9, 93),//3 Nephi 21:7
					new VerseInfo(9, 94),//3 Nephi 21:8
					new VerseInfo(9, 95),//3 Nephi 21:9
					new VerseInfo(9, 96, 9, 97),//3 Nephi 21:10
					new VerseInfo(9, 98),//3 Nephi 21:11
					new VerseInfo(9, 99),//3 Nephi 21:12
					new VerseInfo(9, 100),//3 Nephi 21:13
					new VerseInfo(9, 101),//3 Nephi 21:14
					new VerseInfo(9, 101),//3 Nephi 21:15
					new VerseInfo(9, 102),//3 Nephi 21:16
					new VerseInfo(9, 103),//3 Nephi 21:17
					new VerseInfo(9, 104),//3 Nephi 21:18
					new VerseInfo(9, 105),//3 Nephi 21:19
					new VerseInfo(9, 106),//3 Nephi 21:20
					new VerseInfo(9, 106),//3 Nephi 21:21
					new VerseInfo(10, 1),//3 Nephi 21:22
					new VerseInfo(10, 1, 10, 2),//3 Nephi 21:23
					new VerseInfo(10, 3),//3 Nephi 21:24
					new VerseInfo(10, 4),//3 Nephi 21:25
					new VerseInfo(10, 4, 10, 5),//3 Nephi 21:26
					new VerseInfo(10, 6),//3 Nephi 21:27
					new VerseInfo(10, 7),//3 Nephi 21:28
					new VerseInfo(10, 8),//3 Nephi 21:29
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 22
					new VerseInfo(10, 8, 10, 9),//3 Nephi 22:1
					new VerseInfo(10, 10),//3 Nephi 22:2
					new VerseInfo(10, 11),//3 Nephi 22:3
					new VerseInfo(10, 12),//3 Nephi 22:4
					new VerseInfo(10, 13),//3 Nephi 22:5
					new VerseInfo(10, 14),//3 Nephi 22:6
					new VerseInfo(10, 15),//3 Nephi 22:7
					new VerseInfo(10, 16),//3 Nephi 22:8
					new VerseInfo(10, 17),//3 Nephi 22:9
					new VerseInfo(10, 18),//3 Nephi 22:10
					new VerseInfo(10, 19),//3 Nephi 22:11
					new VerseInfo(10, 20),//3 Nephi 22:12
					new VerseInfo(10, 21),//3 Nephi 22:13
					new VerseInfo(10, 22),//3 Nephi 22:14
					new VerseInfo(10, 23),//3 Nephi 22:15
					new VerseInfo(10, 24),//3 Nephi 22:16
					new VerseInfo(10, 25),//3 Nephi 22:17
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 23
					new VerseInfo(10, 26, 10, 27),//3 Nephi 23:1
					new VerseInfo(10, 28),//3 Nephi 23:2
					new VerseInfo(10, 29),//3 Nephi 23:3
					new VerseInfo(10, 30),//3 Nephi 23:4
					new VerseInfo(10, 31, 10, 32),//3 Nephi 23:5
					new VerseInfo(10, 33),//3 Nephi 23:6
					new VerseInfo(10, 34),//3 Nephi 23:7
					new VerseInfo(10, 35),//3 Nephi 23:8
					new VerseInfo(10, 36, 10, 37),//3 Nephi 23:9
					new VerseInfo(10, 38),//3 Nephi 23:10
					new VerseInfo(10, 39),//3 Nephi 23:11
					new VerseInfo(10, 40),//3 Nephi 23:12
					new VerseInfo(10, 41),//3 Nephi 23:13
					new VerseInfo(11, 1),//3 Nephi 23:14
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 24
					new VerseInfo(11, 2, 11, 4),//3 Nephi 24:1
					new VerseInfo(11, 5),//3 Nephi 24:2
					new VerseInfo(11, 6),//3 Nephi 24:3
					new VerseInfo(11, 7),//3 Nephi 24:4
					new VerseInfo(11, 8),//3 Nephi 24:5
					new VerseInfo(11, 9),//3 Nephi 24:6
					new VerseInfo(11, 10),//3 Nephi 24:7
					new VerseInfo(11, 11),//3 Nephi 24:8
					new VerseInfo(11, 12),//3 Nephi 24:9
					new VerseInfo(11, 13),//3 Nephi 24:10
					new VerseInfo(11, 14),//3 Nephi 24:11
					new VerseInfo(11, 15),//3 Nephi 24:12
					new VerseInfo(11, 16),//3 Nephi 24:13
					new VerseInfo(11, 17),//3 Nephi 24:14
					new VerseInfo(11, 18),//3 Nephi 24:15
					new VerseInfo(11, 19),//3 Nephi 24:16
					new VerseInfo(11, 20),//3 Nephi 24:17
					new VerseInfo(11, 21),//3 Nephi 24:18
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 25
					new VerseInfo(11, 22),//3 Nephi 25:1
					new VerseInfo(11, 23),//3 Nephi 25:2
					new VerseInfo(11, 24),//3 Nephi 25:3
					new VerseInfo(11, 25),//3 Nephi 25:4
					new VerseInfo(11, 26),//3 Nephi 25:5
					new VerseInfo(11, 27),//3 Nephi 25:6
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 26
					new VerseInfo(11, 28),//3 Nephi 26:1
					new VerseInfo(11, 29),//3 Nephi 26:2
					new VerseInfo(11, 30, 11, 31),//3 Nephi 26:3
					new VerseInfo(11, 32),//3 Nephi 26:4
					new VerseInfo(11, 33),//3 Nephi 26:5
					new VerseInfo(12, 1),//3 Nephi 26:6
					new VerseInfo(12, 1),//3 Nephi 26:7
					new VerseInfo(12, 2),//3 Nephi 26:8
					new VerseInfo(12, 3),//3 Nephi 26:9
					new VerseInfo(12, 4),//3 Nephi 26:10
					new VerseInfo(12, 5),//3 Nephi 26:11
					new VerseInfo(12, 5, 12, 6),//3 Nephi 26:12
					new VerseInfo(12, 6),//3 Nephi 26:13
					new VerseInfo(12, 7),//3 Nephi 26:14
					new VerseInfo(12, 8),//3 Nephi 26:15
					new VerseInfo(12, 9),//3 Nephi 26:16
					new VerseInfo(12, 10),//3 Nephi 26:17
					new VerseInfo(12, 11),//3 Nephi 26:18
					new VerseInfo(12, 11),//3 Nephi 26:19
					new VerseInfo(12, 12),//3 Nephi 26:20
					new VerseInfo(12, 13),//3 Nephi 26:21
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 27
					new VerseInfo(12, 14),//3 Nephi 27:1
					new VerseInfo(12, 15),//3 Nephi 27:2
					new VerseInfo(12, 16),//3 Nephi 27:3
					new VerseInfo(12, 17),//3 Nephi 27:4
					new VerseInfo(12, 18),//3 Nephi 27:5
					new VerseInfo(12, 18),//3 Nephi 27:6
					new VerseInfo(12, 19),//3 Nephi 27:7
					new VerseInfo(12, 19, 12, 20),//3 Nephi 27:8
					new VerseInfo(12, 21),//3 Nephi 27:9
					new VerseInfo(12, 22),//3 Nephi 27:10
					new VerseInfo(12, 23),//3 Nephi 27:11
					new VerseInfo(12, 24),//3 Nephi 27:12
					new VerseInfo(12, 25),//3 Nephi 27:13
					new VerseInfo(12, 26, 12, 27),//3 Nephi 27:14
					new VerseInfo(12, 28),//3 Nephi 27:15
					new VerseInfo(12, 29),//3 Nephi 27:16
					new VerseInfo(12, 30),//3 Nephi 27:17
					new VerseInfo(12, 30, 12, 31),//3 Nephi 27:18
					new VerseInfo(12, 31, 12, 32),//3 Nephi 27:19
					new VerseInfo(12, 33),//3 Nephi 27:20
					new VerseInfo(12, 34, 12, 35),//3 Nephi 27:21
					new VerseInfo(12, 35),//3 Nephi 27:22
					new VerseInfo(13, 1),//3 Nephi 27:23
					new VerseInfo(13, 1),//3 Nephi 27:24
					new VerseInfo(13, 2),//3 Nephi 27:25
					new VerseInfo(13, 3),//3 Nephi 27:26
					new VerseInfo(13, 4, 13, 5),//3 Nephi 27:27
					new VerseInfo(13, 5, 13, 6),//3 Nephi 27:28
					new VerseInfo(13, 6),//3 Nephi 27:29
					new VerseInfo(13, 7),//3 Nephi 27:30
					new VerseInfo(13, 8),//3 Nephi 27:31
					new VerseInfo(13, 9, 13, 10),//3 Nephi 27:32
					new VerseInfo(13, 11),//3 Nephi 27:33
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 28
					new VerseInfo(13, 12),//3 Nephi 28:1
					new VerseInfo(13, 13),//3 Nephi 28:2
					new VerseInfo(13, 14),//3 Nephi 28:3
					new VerseInfo(13, 15),//3 Nephi 28:4
					new VerseInfo(13, 16),//3 Nephi 28:5
					new VerseInfo(13, 17),//3 Nephi 28:6
					new VerseInfo(13, 18),//3 Nephi 28:7
					new VerseInfo(13, 19),//3 Nephi 28:8
					new VerseInfo(13, 20, 13, 21),//3 Nephi 28:9
					new VerseInfo(13, 21, 13, 22),//3 Nephi 28:10
					new VerseInfo(13, 23),//3 Nephi 28:11
					new VerseInfo(13, 24),//3 Nephi 28:12
					new VerseInfo(13, 25),//3 Nephi 28:13
					new VerseInfo(13, 26),//3 Nephi 28:14
					new VerseInfo(13, 27),//3 Nephi 28:15
					new VerseInfo(13, 28),//3 Nephi 28:16
					new VerseInfo(13, 29),//3 Nephi 28:17
					new VerseInfo(13, 29, 13, 30),//3 Nephi 28:18
					new VerseInfo(13, 30, 13, 31),//3 Nephi 28:19
					new VerseInfo(13, 31, 13, 32),//3 Nephi 28:20
					new VerseInfo(13, 33),//3 Nephi 28:21
					new VerseInfo(13, 34),//3 Nephi 28:22
					new VerseInfo(13, 35, 13, 36),//3 Nephi 28:23
					new VerseInfo(13, 37),//3 Nephi 28:24
					new VerseInfo(13, 38),//3 Nephi 28:25
					new VerseInfo(13, 39),//3 Nephi 28:26
					new VerseInfo(13, 39),//3 Nephi 28:27
					new VerseInfo(13, 40),//3 Nephi 28:28
					new VerseInfo(13, 41),//3 Nephi 28:29
					new VerseInfo(13, 42),//3 Nephi 28:30
					new VerseInfo(13, 43),//3 Nephi 28:31
					new VerseInfo(13, 44),//3 Nephi 28:32
					new VerseInfo(13, 45),//3 Nephi 28:33
					new VerseInfo(13, 46, 13, 47),//3 Nephi 28:34
					new VerseInfo(13, 47, 13, 48),//3 Nephi 28:35
					new VerseInfo(13, 49),//3 Nephi 28:36
					new VerseInfo(13, 50),//3 Nephi 28:37
					new VerseInfo(13, 51),//3 Nephi 28:38
					new VerseInfo(13, 52),//3 Nephi 28:39
					new VerseInfo(13, 53),//3 Nephi 28:40
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//3 Nephi 29
					new VerseInfo(13, 54),//3 Nephi 29:1
					new VerseInfo(13, 55),//3 Nephi 29:2
					new VerseInfo(13, 56),//3 Nephi 29:3
					new VerseInfo(13, 57),//3 Nephi 29:4
					new VerseInfo(13, 58),//3 Nephi 29:5
					new VerseInfo(13, 59),//3 Nephi 29:6
					new VerseInfo(13, 60),//3 Nephi 29:7
					new VerseInfo(13, 61),//3 Nephi 29:8
					new VerseInfo(13, 62),//3 Nephi 29:9
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//3 Nephi 30
					new VerseInfo(14, 1),//3 Nephi 30:1
					new VerseInfo(14, 2, 14, 3),//3 Nephi 30:2
				},
			}
		},
		{ "4 Nephi", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//4 Nephi 1
					new VerseInfo(1, 1, 1, 2),//4 Nephi 1:1
					new VerseInfo(1, 3),//4 Nephi 1:2
					new VerseInfo(1, 4),//4 Nephi 1:3
					new VerseInfo(1, 5),//4 Nephi 1:4
					new VerseInfo(1, 6, 1, 7),//4 Nephi 1:5
					new VerseInfo(1, 8),//4 Nephi 1:6
					new VerseInfo(1, 9),//4 Nephi 1:7
					new VerseInfo(1, 9),//4 Nephi 1:8
					new VerseInfo(1, 10),//4 Nephi 1:9
					new VerseInfo(1, 11),//4 Nephi 1:10
					new VerseInfo(1, 12),//4 Nephi 1:11
					new VerseInfo(1, 13),//4 Nephi 1:12
					new VerseInfo(1, 14),//4 Nephi 1:13
					new VerseInfo(1, 15, 1, 16),//4 Nephi 1:14
					new VerseInfo(1, 17),//4 Nephi 1:15
					new VerseInfo(1, 18, 1, 19),//4 Nephi 1:16
					new VerseInfo(1, 20),//4 Nephi 1:17
					new VerseInfo(1, 21),//4 Nephi 1:18
					new VerseInfo(1, 22),//4 Nephi 1:19
					new VerseInfo(1, 23),//4 Nephi 1:20
					new VerseInfo(1, 24),//4 Nephi 1:21
					new VerseInfo(1, 25),//4 Nephi 1:22
					new VerseInfo(1, 26),//4 Nephi 1:23
					new VerseInfo(1, 27),//4 Nephi 1:24
					new VerseInfo(1, 28),//4 Nephi 1:25
					new VerseInfo(1, 28),//4 Nephi 1:26
					new VerseInfo(1, 29),//4 Nephi 1:27
					new VerseInfo(1, 30),//4 Nephi 1:28
					new VerseInfo(1, 31),//4 Nephi 1:29
					new VerseInfo(1, 32, 1, 33),//4 Nephi 1:30
					new VerseInfo(1, 34),//4 Nephi 1:31
					new VerseInfo(1, 35),//4 Nephi 1:32
					new VerseInfo(1, 35),//4 Nephi 1:33
					new VerseInfo(1, 36, 1, 38),//4 Nephi 1:34
					new VerseInfo(1, 39),//4 Nephi 1:35
					new VerseInfo(1, 40),//4 Nephi 1:36
					new VerseInfo(1, 41),//4 Nephi 1:37
					new VerseInfo(1, 42, 1, 43),//4 Nephi 1:38
					new VerseInfo(1, 44, 1, 45),//4 Nephi 1:39
					new VerseInfo(1, 46, 1, 47),//4 Nephi 1:40
					new VerseInfo(1, 48, 1, 49),//4 Nephi 1:41
					new VerseInfo(1, 50),//4 Nephi 1:42
					new VerseInfo(1, 51),//4 Nephi 1:43
					new VerseInfo(1, 52),//4 Nephi 1:44
					new VerseInfo(1, 53),//4 Nephi 1:45
					new VerseInfo(1, 54, 1, 55),//4 Nephi 1:46
					new VerseInfo(1, 56),//4 Nephi 1:47
					new VerseInfo(1, 57, 1, 58),//4 Nephi 1:48
					new VerseInfo(1, 59),//4 Nephi 1:49
				},
			}
		},
		{ "Mormon", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Mormon 1
					new VerseInfo(1, 1),//Mormon 1:1
					new VerseInfo(1, 2),//Mormon 1:2
					new VerseInfo(1, 3, 1, 4),//Mormon 1:3
					new VerseInfo(1, 5),//Mormon 1:4
					new VerseInfo(1, 6),//Mormon 1:5
					new VerseInfo(1, 7),//Mormon 1:6
					new VerseInfo(1, 7),//Mormon 1:7
					new VerseInfo(1, 8),//Mormon 1:8
					new VerseInfo(1, 9),//Mormon 1:9
					new VerseInfo(1, 10),//Mormon 1:10
					new VerseInfo(1, 11, 1, 12),//Mormon 1:11
					new VerseInfo(1, 13),//Mormon 1:12
					new VerseInfo(1, 14),//Mormon 1:13
					new VerseInfo(1, 15),//Mormon 1:14
					new VerseInfo(1, 16),//Mormon 1:15
					new VerseInfo(1, 17),//Mormon 1:16
					new VerseInfo(1, 18),//Mormon 1:17
					new VerseInfo(1, 19),//Mormon 1:18
					new VerseInfo(1, 20),//Mormon 1:19
				},
				new VerseInfo?[]
				{
					null,//Mormon 2
					new VerseInfo(1, 21, 1, 22),//Mormon 2:1
					new VerseInfo(1, 23),//Mormon 2:2
					new VerseInfo(1, 24),//Mormon 2:3
					new VerseInfo(1, 25, 1, 26),//Mormon 2:4
					new VerseInfo(1, 27),//Mormon 2:5
					new VerseInfo(1, 27),//Mormon 2:6
					new VerseInfo(1, 28),//Mormon 2:7
					new VerseInfo(1, 29, 1, 30),//Mormon 2:8
					new VerseInfo(1, 31, 1, 33),//Mormon 2:9
					new VerseInfo(1, 34),//Mormon 2:10
					new VerseInfo(1, 35),//Mormon 2:11
					new VerseInfo(1, 36),//Mormon 2:12
					new VerseInfo(1, 37),//Mormon 2:13
					new VerseInfo(1, 38, 1, 39),//Mormon 2:14
					new VerseInfo(1, 40, 1, 41),//Mormon 2:15
					new VerseInfo(1, 42),//Mormon 2:16
					new VerseInfo(1, 43, 1, 44),//Mormon 2:17
					new VerseInfo(1, 45),//Mormon 2:18
					new VerseInfo(1, 46),//Mormon 2:19
					new VerseInfo(1, 47, 1, 48),//Mormon 2:20
					new VerseInfo(1, 49),//Mormon 2:21
					new VerseInfo(1, 50),//Mormon 2:22
					new VerseInfo(1, 51),//Mormon 2:23
					new VerseInfo(1, 52),//Mormon 2:24
					new VerseInfo(1, 53, 1, 54),//Mormon 2:25
					new VerseInfo(1, 55, 1, 56),//Mormon 2:26
					new VerseInfo(1, 57, 1, 58),//Mormon 2:27
					new VerseInfo(1, 59, 1, 60),//Mormon 2:28
					new VerseInfo(1, 61, 1, 62),//Mormon 2:29
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Mormon 3
					new VerseInfo(1, 63, 1, 64),//Mormon 3:1
					new VerseInfo(1, 65),//Mormon 3:2
					new VerseInfo(1, 66, 1, 67),//Mormon 3:3
					new VerseInfo(1, 68),//Mormon 3:4
					new VerseInfo(1, 69),//Mormon 3:5
					new VerseInfo(1, 70),//Mormon 3:6
					new VerseInfo(1, 71),//Mormon 3:7
					new VerseInfo(1, 72, 1, 73),//Mormon 3:8
					new VerseInfo(1, 74),//Mormon 3:9
					new VerseInfo(1, 75),//Mormon 3:10
					new VerseInfo(1, 76),//Mormon 3:11
					new VerseInfo(1, 77, 1, 78),//Mormon 3:12
					new VerseInfo(1, 79),//Mormon 3:13
					new VerseInfo(1, 80),//Mormon 3:14
					new VerseInfo(1, 80),//Mormon 3:15
					new VerseInfo(1, 81),//Mormon 3:16
					new VerseInfo(1, 82),//Mormon 3:17
					new VerseInfo(1, 83),//Mormon 3:18
					new VerseInfo(1, 84),//Mormon 3:19
					new VerseInfo(1, 85, 1, 87),//Mormon 3:20
					new VerseInfo(1, 87, 1, 88),//Mormon 3:21
					new VerseInfo(1, 89),//Mormon 3:22
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Mormon 4
					new VerseInfo(2, 1),//Mormon 4:1
					new VerseInfo(2, 2, 2, 3),//Mormon 4:2
					new VerseInfo(2, 3, 2, 4),//Mormon 4:3
					new VerseInfo(2, 5),//Mormon 4:4
					new VerseInfo(2, 6),//Mormon 4:5
					new VerseInfo(2, 7),//Mormon 4:6
					new VerseInfo(2, 8),//Mormon 4:7
					new VerseInfo(2, 9, 2, 10),//Mormon 4:8
					new VerseInfo(2, 11),//Mormon 4:9
					new VerseInfo(2, 12),//Mormon 4:10
					new VerseInfo(2, 13),//Mormon 4:11
					new VerseInfo(2, 14),//Mormon 4:12
					new VerseInfo(2, 15),//Mormon 4:13
					new VerseInfo(2, 16),//Mormon 4:14
					new VerseInfo(2, 17),//Mormon 4:15
					new VerseInfo(2, 18),//Mormon 4:16
					new VerseInfo(2, 19),//Mormon 4:17
					new VerseInfo(2, 20),//Mormon 4:18
					new VerseInfo(2, 21),//Mormon 4:19
					new VerseInfo(2, 22),//Mormon 4:20
					new VerseInfo(2, 23),//Mormon 4:21
					new VerseInfo(2, 24),//Mormon 4:22
					new VerseInfo(2, 25),//Mormon 4:23
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Mormon 5
					new VerseInfo(2, 26),//Mormon 5:1
					new VerseInfo(2, 27),//Mormon 5:2
					new VerseInfo(2, 28),//Mormon 5:3
					new VerseInfo(2, 29, 2, 30),//Mormon 5:4
					new VerseInfo(2, 31),//Mormon 5:5
					new VerseInfo(2, 32),//Mormon 5:6
					new VerseInfo(2, 33),//Mormon 5:7
					new VerseInfo(2, 34, 2, 35),//Mormon 5:8
					new VerseInfo(2, 35, 2, 36),//Mormon 5:9
					new VerseInfo(2, 37),//Mormon 5:10
					new VerseInfo(2, 38),//Mormon 5:11
					new VerseInfo(2, 39),//Mormon 5:12
					new VerseInfo(2, 40),//Mormon 5:13
					new VerseInfo(2, 41, 2, 42),//Mormon 5:14
					new VerseInfo(2, 43, 2, 44),//Mormon 5:15
					new VerseInfo(2, 45),//Mormon 5:16
					new VerseInfo(2, 46),//Mormon 5:17
					new VerseInfo(2, 47),//Mormon 5:18
					new VerseInfo(2, 48),//Mormon 5:19
					new VerseInfo(2, 49),//Mormon 5:20
					new VerseInfo(2, 50),//Mormon 5:21
					new VerseInfo(2, 51),//Mormon 5:22
					new VerseInfo(2, 52, 2, 53),//Mormon 5:23
					new VerseInfo(2, 54),//Mormon 5:24
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Mormon 6
					new VerseInfo(3, 1, 3, 2),//Mormon 6:1
					new VerseInfo(3, 3),//Mormon 6:2
					new VerseInfo(3, 4),//Mormon 6:3
					new VerseInfo(3, 5),//Mormon 6:4
					new VerseInfo(3, 6),//Mormon 6:5
					new VerseInfo(3, 7, 3, 8),//Mormon 6:6
					new VerseInfo(3, 9),//Mormon 6:7
					new VerseInfo(3, 10),//Mormon 6:8
					new VerseInfo(3, 11),//Mormon 6:9
					new VerseInfo(3, 12),//Mormon 6:10
					new VerseInfo(3, 13, 3, 14),//Mormon 6:11
					new VerseInfo(3, 14),//Mormon 6:12
					new VerseInfo(3, 15),//Mormon 6:13
					new VerseInfo(3, 15),//Mormon 6:14
					new VerseInfo(3, 16, 3, 17),//Mormon 6:15
					new VerseInfo(3, 18),//Mormon 6:16
					new VerseInfo(3, 18),//Mormon 6:17
					new VerseInfo(3, 19),//Mormon 6:18
					new VerseInfo(3, 20),//Mormon 6:19
					new VerseInfo(3, 21),//Mormon 6:20
					new VerseInfo(3, 21, 3, 22),//Mormon 6:21
					new VerseInfo(3, 23),//Mormon 6:22
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Mormon 7
					new VerseInfo(3, 24),//Mormon 7:1
					new VerseInfo(3, 24),//Mormon 7:2
					new VerseInfo(3, 25),//Mormon 7:3
					new VerseInfo(3, 26),//Mormon 7:4
					new VerseInfo(3, 27),//Mormon 7:5
					new VerseInfo(3, 28),//Mormon 7:6
					new VerseInfo(3, 29),//Mormon 7:7
					new VerseInfo(3, 30),//Mormon 7:8
					new VerseInfo(3, 31),//Mormon 7:9
					new VerseInfo(3, 32, 3, 33),//Mormon 7:10
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Mormon 8
					new VerseInfo(4, 1),//Mormon 8:1
					new VerseInfo(4, 2),//Mormon 8:2
					new VerseInfo(4, 2, 4, 4),//Mormon 8:3
					new VerseInfo(4, 4),//Mormon 8:4
					new VerseInfo(4, 5, 4, 6),//Mormon 8:5
					new VerseInfo(4, 7),//Mormon 8:6
					new VerseInfo(4, 8),//Mormon 8:7
					new VerseInfo(4, 9, 4, 10),//Mormon 8:8
					new VerseInfo(4, 11),//Mormon 8:9
					new VerseInfo(4, 12),//Mormon 8:10
					new VerseInfo(4, 13),//Mormon 8:11
					new VerseInfo(4, 14, 4, 15),//Mormon 8:12
					new VerseInfo(4, 16, 4, 17),//Mormon 8:13
					new VerseInfo(4, 17, 4, 18),//Mormon 8:14
					new VerseInfo(4, 19),//Mormon 8:15
					new VerseInfo(4, 20, 4, 21),//Mormon 8:16
					new VerseInfo(4, 21, 4, 22),//Mormon 8:17
					new VerseInfo(4, 23),//Mormon 8:18
					new VerseInfo(4, 24),//Mormon 8:19
					new VerseInfo(4, 25),//Mormon 8:20
					new VerseInfo(4, 26),//Mormon 8:21
					new VerseInfo(4, 26),//Mormon 8:22
					new VerseInfo(4, 27, 4, 28),//Mormon 8:23
					new VerseInfo(4, 29, 4, 31),//Mormon 8:24
					new VerseInfo(4, 32),//Mormon 8:25
					new VerseInfo(4, 33, 4, 34),//Mormon 8:26
					new VerseInfo(4, 35),//Mormon 8:27
					new VerseInfo(4, 36),//Mormon 8:28
					new VerseInfo(4, 37),//Mormon 8:29
					new VerseInfo(4, 37),//Mormon 8:30
					new VerseInfo(4, 38, 4, 40),//Mormon 8:31
					new VerseInfo(4, 41),//Mormon 8:32
					new VerseInfo(4, 42, 4, 44),//Mormon 8:33
					new VerseInfo(4, 45),//Mormon 8:34
					new VerseInfo(4, 46, 4, 47),//Mormon 8:35
					new VerseInfo(4, 47, 4, 49),//Mormon 8:36
					new VerseInfo(4, 50),//Mormon 8:37
					new VerseInfo(4, 51, 4, 53),//Mormon 8:38
					new VerseInfo(4, 54),//Mormon 8:39
					new VerseInfo(4, 55),//Mormon 8:40
					new VerseInfo(4, 56),//Mormon 8:41
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Mormon 9
					new VerseInfo(4, 57),//Mormon 9:1
					new VerseInfo(4, 58, 4, 59),//Mormon 9:2
					new VerseInfo(4, 60, 4, 62),//Mormon 9:3
					new VerseInfo(4, 63),//Mormon 9:4
					new VerseInfo(4, 64),//Mormon 9:5
					new VerseInfo(4, 65),//Mormon 9:6
					new VerseInfo(4, 66),//Mormon 9:7
					new VerseInfo(4, 67),//Mormon 9:8
					new VerseInfo(4, 68),//Mormon 9:9
					new VerseInfo(4, 69),//Mormon 9:10
					new VerseInfo(4, 70),//Mormon 9:11
					new VerseInfo(4, 71),//Mormon 9:12
					new VerseInfo(4, 72, 4, 73),//Mormon 9:13
					new VerseInfo(4, 74),//Mormon 9:14
					new VerseInfo(4, 75, 4, 76),//Mormon 9:15
					new VerseInfo(4, 77),//Mormon 9:16
					new VerseInfo(4, 78),//Mormon 9:17
					new VerseInfo(4, 79, 4, 80),//Mormon 9:18
					new VerseInfo(4, 81, 4, 82),//Mormon 9:19
					new VerseInfo(4, 83),//Mormon 9:20
					new VerseInfo(4, 84),//Mormon 9:21
					new VerseInfo(4, 85, 4, 86),//Mormon 9:22
					new VerseInfo(4, 86),//Mormon 9:23
					new VerseInfo(4, 87),//Mormon 9:24
					new VerseInfo(4, 88),//Mormon 9:25
					new VerseInfo(4, 89, 4, 91),//Mormon 9:26
					new VerseInfo(4, 92, 4, 93),//Mormon 9:27
					new VerseInfo(4, 94),//Mormon 9:28
					new VerseInfo(4, 95),//Mormon 9:29
					new VerseInfo(4, 96),//Mormon 9:30
					new VerseInfo(4, 97),//Mormon 9:31
					new VerseInfo(4, 98),//Mormon 9:32
					new VerseInfo(4, 99),//Mormon 9:33
					new VerseInfo(4, 100),//Mormon 9:34
					new VerseInfo(4, 101),//Mormon 9:35
					new VerseInfo(4, 102),//Mormon 9:36
					new VerseInfo(4, 103),//Mormon 9:37
				},
			}
		},
		{ "Ether", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Ether 1
					new VerseInfo(1, 1),//Ether 1:1
					new VerseInfo(1, 2),//Ether 1:2
					new VerseInfo(1, 3),//Ether 1:3
					new VerseInfo(1, 4),//Ether 1:4
					new VerseInfo(1, 5),//Ether 1:5
					new VerseInfo(1, 5, 1, 6),//Ether 1:6
					new VerseInfo(1, 6),//Ether 1:7
					new VerseInfo(1, 6),//Ether 1:8
					new VerseInfo(1, 6),//Ether 1:9
					new VerseInfo(1, 6),//Ether 1:10
					new VerseInfo(1, 6),//Ether 1:11
					new VerseInfo(1, 6),//Ether 1:12
					new VerseInfo(1, 6),//Ether 1:13
					new VerseInfo(1, 6),//Ether 1:14
					new VerseInfo(1, 6),//Ether 1:15
					new VerseInfo(1, 6),//Ether 1:16
					new VerseInfo(1, 6),//Ether 1:17
					new VerseInfo(1, 6),//Ether 1:18
					new VerseInfo(1, 6),//Ether 1:19
					new VerseInfo(1, 6),//Ether 1:20
					new VerseInfo(1, 6),//Ether 1:21
					new VerseInfo(1, 6),//Ether 1:22
					new VerseInfo(1, 6),//Ether 1:23
					new VerseInfo(1, 6),//Ether 1:24
					new VerseInfo(1, 6),//Ether 1:25
					new VerseInfo(1, 6),//Ether 1:26
					new VerseInfo(1, 6),//Ether 1:27
					new VerseInfo(1, 6),//Ether 1:28
					new VerseInfo(1, 6),//Ether 1:29
					new VerseInfo(1, 6),//Ether 1:30
					new VerseInfo(1, 6),//Ether 1:31
					new VerseInfo(1, 6),//Ether 1:32
					new VerseInfo(1, 7),//Ether 1:33
					new VerseInfo(1, 8),//Ether 1:34
					new VerseInfo(1, 9),//Ether 1:35
					new VerseInfo(1, 10),//Ether 1:36
					new VerseInfo(1, 11),//Ether 1:37
					new VerseInfo(1, 12, 1, 14),//Ether 1:38
					new VerseInfo(1, 15),//Ether 1:39
					new VerseInfo(1, 16),//Ether 1:40
					new VerseInfo(1, 16),//Ether 1:41
					new VerseInfo(1, 17, 1, 18),//Ether 1:42
					new VerseInfo(1, 19, 1, 21),//Ether 1:43
				},
				new VerseInfo?[]
				{
					null,//Ether 2
					new VerseInfo(1, 22),//Ether 2:1
					new VerseInfo(1, 23),//Ether 2:2
					new VerseInfo(1, 24),//Ether 2:3
					new VerseInfo(1, 25),//Ether 2:4
					new VerseInfo(1, 26, 1, 27),//Ether 2:5
					new VerseInfo(1, 28),//Ether 2:6
					new VerseInfo(1, 29),//Ether 2:7
					new VerseInfo(1, 30),//Ether 2:8
					new VerseInfo(1, 31, 1, 32),//Ether 2:9
					new VerseInfo(1, 32, 1, 33),//Ether 2:10
					new VerseInfo(1, 34),//Ether 2:11
					new VerseInfo(1, 35),//Ether 2:12
					new VerseInfo(1, 36, 1, 37),//Ether 2:13
					new VerseInfo(1, 38, 1, 39),//Ether 2:14
					new VerseInfo(1, 40, 1, 42),//Ether 2:15
					new VerseInfo(1, 43, 1, 45),//Ether 2:16
					new VerseInfo(1, 45, 1, 46),//Ether 2:17
					new VerseInfo(1, 47),//Ether 2:18
					new VerseInfo(1, 48, 1, 49),//Ether 2:19
					new VerseInfo(1, 50, 1, 51),//Ether 2:20
					new VerseInfo(1, 52),//Ether 2:21
					new VerseInfo(1, 53, 1, 54),//Ether 2:22
					new VerseInfo(1, 55, 1, 56),//Ether 2:23
					new VerseInfo(1, 56, 1, 57),//Ether 2:24
					new VerseInfo(1, 58, 1, 59),//Ether 2:25
				},
				new VerseInfo?[]
				{
					null,//Ether 3
					new VerseInfo(1, 60, 1, 61),//Ether 3:1
					new VerseInfo(1, 61, 1, 63),//Ether 3:2
					new VerseInfo(1, 64, 1, 65),//Ether 3:3
					new VerseInfo(1, 66),//Ether 3:4
					new VerseInfo(1, 67),//Ether 3:5
					new VerseInfo(1, 68, 1, 69),//Ether 3:6
					new VerseInfo(1, 70),//Ether 3:7
					new VerseInfo(1, 71),//Ether 3:8
					new VerseInfo(1, 72),//Ether 3:9
					new VerseInfo(1, 73),//Ether 3:10
					new VerseInfo(1, 74),//Ether 3:11
					new VerseInfo(1, 75),//Ether 3:12
					new VerseInfo(1, 76),//Ether 3:13
					new VerseInfo(1, 77, 1, 78),//Ether 3:14
					new VerseInfo(1, 79, 1, 80),//Ether 3:15
					new VerseInfo(1, 81),//Ether 3:16
					new VerseInfo(1, 82),//Ether 3:17
					new VerseInfo(1, 83),//Ether 3:18
					new VerseInfo(1, 84, 1, 85),//Ether 3:19
					new VerseInfo(1, 85),//Ether 3:20
					new VerseInfo(1, 86),//Ether 3:21
					new VerseInfo(1, 87),//Ether 3:22
					new VerseInfo(1, 88),//Ether 3:23
					new VerseInfo(1, 89),//Ether 3:24
					new VerseInfo(1, 90),//Ether 3:25
					new VerseInfo(1, 91),//Ether 3:26
					new VerseInfo(1, 92),//Ether 3:27
					new VerseInfo(1, 93),//Ether 3:28
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Ether 4
					new VerseInfo(1, 94, 1, 95),//Ether 4:1
					new VerseInfo(1, 96),//Ether 4:2
					new VerseInfo(1, 97),//Ether 4:3
					new VerseInfo(1, 98),//Ether 4:4
					new VerseInfo(1, 98, 1, 99),//Ether 4:5
					new VerseInfo(1, 100),//Ether 4:6
					new VerseInfo(1, 101),//Ether 4:7
					new VerseInfo(1, 102),//Ether 4:8
					new VerseInfo(1, 103),//Ether 4:9
					new VerseInfo(1, 104),//Ether 4:10
					new VerseInfo(1, 105, 1, 106),//Ether 4:11
					new VerseInfo(1, 106, 1, 108),//Ether 4:12
					new VerseInfo(1, 109),//Ether 4:13
					new VerseInfo(1, 110),//Ether 4:14
					new VerseInfo(1, 111, 1, 112),//Ether 4:15
					new VerseInfo(1, 113, 1, 114),//Ether 4:16
					new VerseInfo(1, 114),//Ether 4:17
					new VerseInfo(1, 115),//Ether 4:18
					new VerseInfo(1, 116, 1, 117),//Ether 4:19
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Ether 5
					new VerseInfo(2, 1),//Ether 5:1
					new VerseInfo(2, 2),//Ether 5:2
					new VerseInfo(2, 2),//Ether 5:3
					new VerseInfo(2, 3),//Ether 5:4
					new VerseInfo(2, 4),//Ether 5:5
					new VerseInfo(2, 5),//Ether 5:6
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Ether 6
					new VerseInfo(3, 1),//Ether 6:1
					new VerseInfo(3, 2),//Ether 6:2
					new VerseInfo(3, 3),//Ether 6:3
					new VerseInfo(3, 4, 3, 5),//Ether 6:4
					new VerseInfo(3, 6),//Ether 6:5
					new VerseInfo(3, 7),//Ether 6:6
					new VerseInfo(3, 8, 3, 9),//Ether 6:7
					new VerseInfo(3, 10),//Ether 6:8
					new VerseInfo(3, 11),//Ether 6:9
					new VerseInfo(3, 12),//Ether 6:10
					new VerseInfo(3, 13),//Ether 6:11
					new VerseInfo(3, 13, 3, 14),//Ether 6:12
					new VerseInfo(3, 15),//Ether 6:13
					new VerseInfo(3, 16),//Ether 6:14
					new VerseInfo(3, 17),//Ether 6:15
					new VerseInfo(3, 18),//Ether 6:16
					new VerseInfo(3, 19),//Ether 6:17
					new VerseInfo(3, 20),//Ether 6:18
					new VerseInfo(3, 21),//Ether 6:19
					new VerseInfo(3, 22, 3, 23),//Ether 6:20
					new VerseInfo(3, 24),//Ether 6:21
					new VerseInfo(3, 25),//Ether 6:22
					new VerseInfo(3, 26, 3, 27),//Ether 6:23
					new VerseInfo(3, 28),//Ether 6:24
					new VerseInfo(3, 29, 3, 31),//Ether 6:25
					new VerseInfo(3, 32),//Ether 6:26
					new VerseInfo(3, 33),//Ether 6:27
					new VerseInfo(3, 34),//Ether 6:28
					new VerseInfo(3, 35),//Ether 6:29
					new VerseInfo(3, 36),//Ether 6:30
				},
				new VerseInfo?[]
				{
					null,//Ether 7
					new VerseInfo(3, 37),//Ether 7:1
					new VerseInfo(3, 38),//Ether 7:2
					new VerseInfo(3, 39, 3, 40),//Ether 7:3
					new VerseInfo(3, 41),//Ether 7:4
					new VerseInfo(3, 42),//Ether 7:5
					new VerseInfo(3, 43),//Ether 7:6
					new VerseInfo(3, 44),//Ether 7:7
					new VerseInfo(3, 45),//Ether 7:8
					new VerseInfo(3, 46),//Ether 7:9
					new VerseInfo(3, 47),//Ether 7:10
					new VerseInfo(3, 48),//Ether 7:11
					new VerseInfo(3, 49),//Ether 7:12
					new VerseInfo(3, 50),//Ether 7:13
					new VerseInfo(3, 51, 3, 52),//Ether 7:14
					new VerseInfo(3, 53),//Ether 7:15
					new VerseInfo(3, 54),//Ether 7:16
					new VerseInfo(3, 55),//Ether 7:17
					new VerseInfo(3, 56),//Ether 7:18
					new VerseInfo(3, 56, 3, 57),//Ether 7:19
					new VerseInfo(3, 58),//Ether 7:20
					new VerseInfo(3, 59),//Ether 7:21
					new VerseInfo(3, 60),//Ether 7:22
					new VerseInfo(3, 61),//Ether 7:23
					new VerseInfo(3, 62, 3, 63),//Ether 7:24
					new VerseInfo(3, 63),//Ether 7:25
					new VerseInfo(3, 64, 3, 65),//Ether 7:26
					new VerseInfo(3, 66),//Ether 7:27
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Ether 8
					new VerseInfo(3, 67, 3, 68),//Ether 8:1
					new VerseInfo(3, 69, 3, 70),//Ether 8:2
					new VerseInfo(3, 71),//Ether 8:3
					new VerseInfo(3, 72, 3, 73),//Ether 8:4
					new VerseInfo(3, 73, 3, 74),//Ether 8:5
					new VerseInfo(3, 75, 3, 76),//Ether 8:6
					new VerseInfo(3, 77),//Ether 8:7
					new VerseInfo(3, 78),//Ether 8:8
					new VerseInfo(3, 79, 3, 81),//Ether 8:9
					new VerseInfo(3, 82),//Ether 8:10
					new VerseInfo(3, 83, 3, 84),//Ether 8:11
					new VerseInfo(3, 85),//Ether 8:12
					new VerseInfo(3, 86),//Ether 8:13
					new VerseInfo(3, 87, 3, 88),//Ether 8:14
					new VerseInfo(3, 88, 3, 89),//Ether 8:15
					new VerseInfo(3, 90),//Ether 8:16
					new VerseInfo(3, 91),//Ether 8:17
					new VerseInfo(3, 92),//Ether 8:18
					new VerseInfo(3, 93),//Ether 8:19
					new VerseInfo(3, 94),//Ether 8:20
					new VerseInfo(3, 94),//Ether 8:21
					new VerseInfo(3, 95),//Ether 8:22
					new VerseInfo(3, 96, 3, 97),//Ether 8:23
					new VerseInfo(3, 98),//Ether 8:24
					new VerseInfo(3, 99, 3, 101),//Ether 8:25
					new VerseInfo(3, 102),//Ether 8:26
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Ether 9
					new VerseInfo(4, 1, 4, 2),//Ether 9:1
					new VerseInfo(4, 2),//Ether 9:2
					new VerseInfo(4, 3, 4, 4),//Ether 9:3
					new VerseInfo(4, 5),//Ether 9:4
					new VerseInfo(4, 6),//Ether 9:5
					new VerseInfo(4, 7),//Ether 9:6
					new VerseInfo(4, 8),//Ether 9:7
					new VerseInfo(4, 9),//Ether 9:8
					new VerseInfo(4, 10),//Ether 9:9
					new VerseInfo(4, 11),//Ether 9:10
					new VerseInfo(4, 12),//Ether 9:11
					new VerseInfo(4, 13, 4, 14),//Ether 9:12
					new VerseInfo(4, 14),//Ether 9:13
					new VerseInfo(4, 15),//Ether 9:14
					new VerseInfo(4, 16, 4, 17),//Ether 9:15
					new VerseInfo(4, 18, 4, 19),//Ether 9:16
					new VerseInfo(4, 19),//Ether 9:17
					new VerseInfo(4, 20),//Ether 9:18
					new VerseInfo(4, 21),//Ether 9:19
					new VerseInfo(4, 22),//Ether 9:20
					new VerseInfo(4, 23),//Ether 9:21
					new VerseInfo(4, 24),//Ether 9:22
					new VerseInfo(4, 25, 4, 26),//Ether 9:23
					new VerseInfo(4, 27, 4, 28),//Ether 9:24
					new VerseInfo(4, 29),//Ether 9:25
					new VerseInfo(4, 30),//Ether 9:26
					new VerseInfo(4, 31),//Ether 9:27
					new VerseInfo(4, 32),//Ether 9:28
					new VerseInfo(4, 33, 4, 34),//Ether 9:29
					new VerseInfo(4, 35),//Ether 9:30
					new VerseInfo(4, 35, 4, 36),//Ether 9:31
					new VerseInfo(4, 37),//Ether 9:32
					new VerseInfo(4, 38),//Ether 9:33
					new VerseInfo(4, 39, 4, 40),//Ether 9:34
					new VerseInfo(4, 41, 4, 42),//Ether 9:35
				},
				new VerseInfo?[]
				{
					null,//Ether 10
					new VerseInfo(4, 43),//Ether 10:1
					new VerseInfo(4, 44),//Ether 10:2
					new VerseInfo(4, 45),//Ether 10:3
					new VerseInfo(4, 46, 4, 47),//Ether 10:4
					new VerseInfo(4, 48),//Ether 10:5
					new VerseInfo(4, 49, 4, 50),//Ether 10:6
					new VerseInfo(4, 50, 4, 51),//Ether 10:7
					new VerseInfo(4, 51),//Ether 10:8
					new VerseInfo(4, 52, 4, 53),//Ether 10:9
					new VerseInfo(4, 54),//Ether 10:10
					new VerseInfo(4, 55),//Ether 10:11
					new VerseInfo(4, 56),//Ether 10:12
					new VerseInfo(4, 57, 4, 58),//Ether 10:13
					new VerseInfo(4, 59),//Ether 10:14
					new VerseInfo(4, 60, 4, 61),//Ether 10:15
					new VerseInfo(4, 62),//Ether 10:16
					new VerseInfo(4, 63),//Ether 10:17
					new VerseInfo(4, 64),//Ether 10:18
					new VerseInfo(4, 65, 4, 67),//Ether 10:19
					new VerseInfo(4, 68),//Ether 10:20
					new VerseInfo(4, 69, 4, 70),//Ether 10:21
					new VerseInfo(4, 70),//Ether 10:22
					new VerseInfo(4, 71, 4, 72),//Ether 10:23
					new VerseInfo(4, 73),//Ether 10:24
					new VerseInfo(4, 74),//Ether 10:25
					new VerseInfo(4, 75),//Ether 10:26
					new VerseInfo(4, 76, 4, 77),//Ether 10:27
					new VerseInfo(4, 78, 4, 79),//Ether 10:28
					new VerseInfo(4, 80),//Ether 10:29
					new VerseInfo(4, 81, 4, 83),//Ether 10:30
					new VerseInfo(4, 84, 4, 85),//Ether 10:31
					new VerseInfo(4, 86, 4, 87),//Ether 10:32
					new VerseInfo(4, 88),//Ether 10:33
					new VerseInfo(4, 89),//Ether 10:34
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Ether 11
					new VerseInfo(4, 90),//Ether 11:1
					new VerseInfo(4, 91),//Ether 11:2
					new VerseInfo(4, 91),//Ether 11:3
					new VerseInfo(4, 92, 4, 93),//Ether 11:4
					new VerseInfo(4, 94),//Ether 11:5
					new VerseInfo(4, 95, 4, 96),//Ether 11:6
					new VerseInfo(4, 97),//Ether 11:7
					new VerseInfo(4, 98),//Ether 11:8
					new VerseInfo(4, 99),//Ether 11:9
					new VerseInfo(4, 100, 4, 101),//Ether 11:10
					new VerseInfo(4, 102),//Ether 11:11
					new VerseInfo(4, 103),//Ether 11:12
					new VerseInfo(4, 104),//Ether 11:13
					new VerseInfo(4, 105, 4, 106),//Ether 11:14
					new VerseInfo(4, 107),//Ether 11:15
					new VerseInfo(4, 108),//Ether 11:16
					new VerseInfo(4, 109),//Ether 11:17
					new VerseInfo(4, 110),//Ether 11:18
					new VerseInfo(4, 111),//Ether 11:19
					new VerseInfo(4, 112),//Ether 11:20
					new VerseInfo(4, 113),//Ether 11:21
					new VerseInfo(4, 114),//Ether 11:22
					new VerseInfo(4, 115),//Ether 11:23
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Ether 12
					new VerseInfo(5, 1),//Ether 12:1
					new VerseInfo(5, 2),//Ether 12:2
					new VerseInfo(5, 3),//Ether 12:3
					new VerseInfo(5, 4),//Ether 12:4
					new VerseInfo(5, 5),//Ether 12:5
					new VerseInfo(5, 6, 5, 7),//Ether 12:6
					new VerseInfo(5, 7, 5, 8),//Ether 12:7
					new VerseInfo(5, 9),//Ether 12:8
					new VerseInfo(5, 10),//Ether 12:9
					new VerseInfo(5, 11),//Ether 12:10
					new VerseInfo(5, 11, 5, 12),//Ether 12:11
					new VerseInfo(5, 13),//Ether 12:12
					new VerseInfo(5, 14),//Ether 12:13
					new VerseInfo(5, 15),//Ether 12:14
					new VerseInfo(5, 16),//Ether 12:15
					new VerseInfo(5, 16),//Ether 12:16
					new VerseInfo(5, 17),//Ether 12:17
					new VerseInfo(5, 18),//Ether 12:18
					new VerseInfo(5, 19),//Ether 12:19
					new VerseInfo(5, 20),//Ether 12:20
					new VerseInfo(5, 21),//Ether 12:21
					new VerseInfo(5, 22),//Ether 12:22
					new VerseInfo(5, 23, 5, 24),//Ether 12:23
					new VerseInfo(5, 24, 5, 25),//Ether 12:24
					new VerseInfo(5, 26),//Ether 12:25
					new VerseInfo(5, 27),//Ether 12:26
					new VerseInfo(5, 28),//Ether 12:27
					new VerseInfo(5, 29),//Ether 12:28
					new VerseInfo(5, 30),//Ether 12:29
					new VerseInfo(5, 30, 5, 31),//Ether 12:30
					new VerseInfo(5, 31, 5, 32),//Ether 12:31
					new VerseInfo(5, 32),//Ether 12:32
					new VerseInfo(5, 33),//Ether 12:33
					new VerseInfo(5, 34),//Ether 12:34
					new VerseInfo(5, 35),//Ether 12:35
					new VerseInfo(5, 36),//Ether 12:36
					new VerseInfo(5, 37, 5, 38),//Ether 12:37
					new VerseInfo(5, 39),//Ether 12:38
					new VerseInfo(5, 40),//Ether 12:39
					new VerseInfo(5, 40),//Ether 12:40
					new VerseInfo(5, 41),//Ether 12:41
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Ether 13
					new VerseInfo(6, 1),//Ether 13:1
					new VerseInfo(6, 2, 6, 3),//Ether 13:2
					new VerseInfo(6, 3),//Ether 13:3
					new VerseInfo(6, 4),//Ether 13:4
					new VerseInfo(6, 4, 6, 5),//Ether 13:5
					new VerseInfo(6, 6),//Ether 13:6
					new VerseInfo(6, 6, 6, 7),//Ether 13:7
					new VerseInfo(6, 8),//Ether 13:8
					new VerseInfo(6, 9),//Ether 13:9
					new VerseInfo(6, 10),//Ether 13:10
					new VerseInfo(6, 11, 6, 12),//Ether 13:11
					new VerseInfo(6, 13),//Ether 13:12
					new VerseInfo(6, 14),//Ether 13:13
					new VerseInfo(6, 15),//Ether 13:14
					new VerseInfo(6, 16),//Ether 13:15
					new VerseInfo(6, 17),//Ether 13:16
					new VerseInfo(6, 18),//Ether 13:17
					new VerseInfo(6, 19),//Ether 13:18
					new VerseInfo(6, 20),//Ether 13:19
					new VerseInfo(6, 21),//Ether 13:20
					new VerseInfo(6, 22, 6, 23),//Ether 13:21
					new VerseInfo(6, 24),//Ether 13:22
					new VerseInfo(6, 25),//Ether 13:23
					new VerseInfo(6, 26),//Ether 13:24
					new VerseInfo(6, 27),//Ether 13:25
					new VerseInfo(6, 28),//Ether 13:26
					new VerseInfo(6, 29),//Ether 13:27
					new VerseInfo(6, 30, 6, 31),//Ether 13:28
					new VerseInfo(6, 32),//Ether 13:29
					new VerseInfo(6, 33),//Ether 13:30
					new VerseInfo(6, 34),//Ether 13:31
				},
				new VerseInfo?[]
				{
					null,//Ether 14
					new VerseInfo(6, 35),//Ether 14:1
					new VerseInfo(6, 36),//Ether 14:2
					new VerseInfo(6, 37),//Ether 14:3
					new VerseInfo(6, 38),//Ether 14:4
					new VerseInfo(6, 39),//Ether 14:5
					new VerseInfo(6, 40),//Ether 14:6
					new VerseInfo(6, 41),//Ether 14:7
					new VerseInfo(6, 42),//Ether 14:8
					new VerseInfo(6, 43),//Ether 14:9
					new VerseInfo(6, 44),//Ether 14:10
					new VerseInfo(6, 45),//Ether 14:11
					new VerseInfo(6, 46),//Ether 14:12
					new VerseInfo(6, 47),//Ether 14:13
					new VerseInfo(6, 48),//Ether 14:14
					new VerseInfo(6, 49, 6, 50),//Ether 14:15
					new VerseInfo(6, 51),//Ether 14:16
					new VerseInfo(6, 52, 6, 53),//Ether 14:17
					new VerseInfo(6, 54),//Ether 14:18
					new VerseInfo(6, 55),//Ether 14:19
					new VerseInfo(6, 56),//Ether 14:20
					new VerseInfo(6, 57),//Ether 14:21
					new VerseInfo(6, 58),//Ether 14:22
					new VerseInfo(6, 59),//Ether 14:23
					new VerseInfo(6, 60),//Ether 14:24
					new VerseInfo(6, 61),//Ether 14:25
					new VerseInfo(6, 62),//Ether 14:26
					new VerseInfo(6, 63, 6, 64),//Ether 14:27
					new VerseInfo(6, 64, 6, 66),//Ether 14:28
					new VerseInfo(6, 67, 6, 68),//Ether 14:29
					new VerseInfo(6, 69, 6, 70),//Ether 14:30
					new VerseInfo(6, 71),//Ether 14:31
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Ether 15
					new VerseInfo(6, 72),//Ether 15:1
					new VerseInfo(6, 73),//Ether 15:2
					new VerseInfo(6, 74),//Ether 15:3
					new VerseInfo(6, 75),//Ether 15:4
					new VerseInfo(6, 76),//Ether 15:5
					new VerseInfo(6, 77, 6, 78),//Ether 15:6
					new VerseInfo(6, 79),//Ether 15:7
					new VerseInfo(6, 80),//Ether 15:8
					new VerseInfo(6, 81),//Ether 15:9
					new VerseInfo(6, 82),//Ether 15:10
					new VerseInfo(6, 83),//Ether 15:11
					new VerseInfo(6, 84),//Ether 15:12
					new VerseInfo(6, 85),//Ether 15:13
					new VerseInfo(6, 86),//Ether 15:14
					new VerseInfo(6, 87),//Ether 15:15
					new VerseInfo(6, 88),//Ether 15:16
					new VerseInfo(6, 89, 6, 90),//Ether 15:17
					new VerseInfo(6, 91),//Ether 15:18
					new VerseInfo(6, 92),//Ether 15:19
					new VerseInfo(6, 93),//Ether 15:20
					new VerseInfo(6, 93),//Ether 15:21
					new VerseInfo(6, 94),//Ether 15:22
					new VerseInfo(6, 94, 6, 95),//Ether 15:23
					new VerseInfo(6, 96),//Ether 15:24
					new VerseInfo(6, 97),//Ether 15:25
					new VerseInfo(6, 98, 6, 99),//Ether 15:26
					new VerseInfo(6, 100),//Ether 15:27
					new VerseInfo(6, 101),//Ether 15:28
					new VerseInfo(6, 102, 6, 103),//Ether 15:29
					new VerseInfo(6, 104),//Ether 15:30
					new VerseInfo(6, 105),//Ether 15:31
					new VerseInfo(6, 106),//Ether 15:32
					new VerseInfo(6, 107, 6, 108),//Ether 15:33
					new VerseInfo(6, 109),//Ether 15:34
				},
			}
		},
		{ "Moroni", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 1
					new VerseInfo(1, 1),//Moroni 1:1
					new VerseInfo(1, 2),//Moroni 1:2
					new VerseInfo(1, 3),//Moroni 1:3
					new VerseInfo(1, 4),//Moroni 1:4
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 2
					new VerseInfo(2, 1),//Moroni 2:1
					new VerseInfo(2, 2),//Moroni 2:2
					new VerseInfo(2, 3),//Moroni 2:3
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 3
					new VerseInfo(3, 1),//Moroni 3:1
					new VerseInfo(3, 2),//Moroni 3:2
					new VerseInfo(3, 2),//Moroni 3:3
					new VerseInfo(3, 3),//Moroni 3:4
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 4
					new VerseInfo(4, 1, 4, 2),//Moroni 4:1
					new VerseInfo(4, 3),//Moroni 4:2
					new VerseInfo(4, 4),//Moroni 4:3
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 5
					new VerseInfo(5, 1, 5, 2),//Moroni 5:1
					new VerseInfo(5, 3),//Moroni 5:2
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 6
					new VerseInfo(6, 1, 6, 2),//Moroni 6:1
					new VerseInfo(6, 2),//Moroni 6:2
					new VerseInfo(6, 3),//Moroni 6:3
					new VerseInfo(6, 4, 6, 5),//Moroni 6:4
					new VerseInfo(6, 6),//Moroni 6:5
					new VerseInfo(6, 6),//Moroni 6:6
					new VerseInfo(6, 7, 6, 8),//Moroni 6:7
					new VerseInfo(6, 8),//Moroni 6:8
					new VerseInfo(6, 9),//Moroni 6:9
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 7
					new VerseInfo(7, 1),//Moroni 7:1
					new VerseInfo(7, 2),//Moroni 7:2
					new VerseInfo(7, 3),//Moroni 7:3
					new VerseInfo(7, 4),//Moroni 7:4
					new VerseInfo(7, 4),//Moroni 7:5
					new VerseInfo(7, 5),//Moroni 7:6
					new VerseInfo(7, 6),//Moroni 7:7
					new VerseInfo(7, 7),//Moroni 7:8
					new VerseInfo(7, 8),//Moroni 7:9
					new VerseInfo(7, 8),//Moroni 7:10
					new VerseInfo(7, 9),//Moroni 7:11
					new VerseInfo(7, 10),//Moroni 7:12
					new VerseInfo(7, 11),//Moroni 7:13
					new VerseInfo(7, 12),//Moroni 7:14
					new VerseInfo(7, 13),//Moroni 7:15
					new VerseInfo(7, 14, 7, 15),//Moroni 7:16
					new VerseInfo(7, 15, 7, 16),//Moroni 7:17
					new VerseInfo(7, 17),//Moroni 7:18
					new VerseInfo(7, 18),//Moroni 7:19
					new VerseInfo(7, 19),//Moroni 7:20
					new VerseInfo(7, 20),//Moroni 7:21
					new VerseInfo(7, 21),//Moroni 7:22
					new VerseInfo(7, 22),//Moroni 7:23
					new VerseInfo(7, 23),//Moroni 7:24
					new VerseInfo(7, 24),//Moroni 7:25
					new VerseInfo(7, 25, 7, 26),//Moroni 7:26
					new VerseInfo(7, 27),//Moroni 7:27
					new VerseInfo(7, 28),//Moroni 7:28
					new VerseInfo(7, 28, 7, 30),//Moroni 7:29
					new VerseInfo(7, 31),//Moroni 7:30
					new VerseInfo(7, 32),//Moroni 7:31
					new VerseInfo(7, 33, 7, 34),//Moroni 7:32
					new VerseInfo(7, 35),//Moroni 7:33
					new VerseInfo(7, 36),//Moroni 7:34
					new VerseInfo(7, 37),//Moroni 7:35
					new VerseInfo(7, 38, 7, 40),//Moroni 7:36
					new VerseInfo(7, 41, 7, 42),//Moroni 7:37
					new VerseInfo(7, 42, 7, 43),//Moroni 7:38
					new VerseInfo(7, 44),//Moroni 7:39
					new VerseInfo(7, 45, 7, 46),//Moroni 7:40
					new VerseInfo(7, 46, 7, 47),//Moroni 7:41
					new VerseInfo(7, 48),//Moroni 7:42
					new VerseInfo(7, 49),//Moroni 7:43
					new VerseInfo(7, 49, 7, 50),//Moroni 7:44
					new VerseInfo(7, 51),//Moroni 7:45
					new VerseInfo(7, 51, 7, 52),//Moroni 7:46
					new VerseInfo(7, 52),//Moroni 7:47
					new VerseInfo(7, 53),//Moroni 7:48
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 8
					new VerseInfo(8, 1, 8, 2),//Moroni 8:1
					new VerseInfo(8, 2),//Moroni 8:2
					new VerseInfo(8, 3),//Moroni 8:3
					new VerseInfo(8, 4),//Moroni 8:4
					new VerseInfo(8, 5),//Moroni 8:5
					new VerseInfo(8, 6),//Moroni 8:6
					new VerseInfo(8, 7, 8, 8),//Moroni 8:7
					new VerseInfo(8, 8, 8, 9),//Moroni 8:8
					new VerseInfo(8, 10),//Moroni 8:9
					new VerseInfo(8, 11),//Moroni 8:10
					new VerseInfo(8, 11, 8, 12),//Moroni 8:11
					new VerseInfo(8, 13),//Moroni 8:12
					new VerseInfo(8, 14),//Moroni 8:13
					new VerseInfo(8, 15),//Moroni 8:14
					new VerseInfo(8, 16),//Moroni 8:15
					new VerseInfo(8, 17, 8, 18),//Moroni 8:16
					new VerseInfo(8, 18),//Moroni 8:17
					new VerseInfo(8, 19),//Moroni 8:18
					new VerseInfo(8, 20),//Moroni 8:19
					new VerseInfo(8, 21),//Moroni 8:20
					new VerseInfo(8, 22, 8, 24),//Moroni 8:21
					new VerseInfo(8, 25, 8, 26),//Moroni 8:22
					new VerseInfo(8, 27),//Moroni 8:23
					new VerseInfo(8, 28),//Moroni 8:24
					new VerseInfo(8, 29),//Moroni 8:25
					new VerseInfo(8, 29),//Moroni 8:26
					new VerseInfo(8, 30, 8, 31),//Moroni 8:27
					new VerseInfo(8, 32, 8, 33),//Moroni 8:28
					new VerseInfo(8, 34),//Moroni 8:29
					new VerseInfo(8, 35),//Moroni 8:30
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 9
					new VerseInfo(9, 1),//Moroni 9:1
					new VerseInfo(9, 2),//Moroni 9:2
					new VerseInfo(9, 3),//Moroni 9:3
					new VerseInfo(9, 4),//Moroni 9:4
					new VerseInfo(9, 5),//Moroni 9:5
					new VerseInfo(9, 6),//Moroni 9:6
					new VerseInfo(9, 7, 9, 8),//Moroni 9:7
					new VerseInfo(9, 9),//Moroni 9:8
					new VerseInfo(9, 10, 9, 11),//Moroni 9:9
					new VerseInfo(9, 11),//Moroni 9:10
					new VerseInfo(9, 12),//Moroni 9:11
					new VerseInfo(9, 12),//Moroni 9:12
					new VerseInfo(9, 12),//Moroni 9:13
					new VerseInfo(9, 12),//Moroni 9:14
					new VerseInfo(9, 13, 9, 14),//Moroni 9:15
					new VerseInfo(9, 15),//Moroni 9:16
					new VerseInfo(9, 16),//Moroni 9:17
					new VerseInfo(9, 17, 9, 18),//Moroni 9:18
					new VerseInfo(9, 18, 9, 19),//Moroni 9:19
					new VerseInfo(9, 20, 9, 21),//Moroni 9:20
					new VerseInfo(9, 22),//Moroni 9:21
					new VerseInfo(9, 23, 9, 24),//Moroni 9:22
					new VerseInfo(9, 24),//Moroni 9:23
					new VerseInfo(9, 25, 9, 26),//Moroni 9:24
					new VerseInfo(9, 27),//Moroni 9:25
					new VerseInfo(9, 28),//Moroni 9:26
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 10
					new VerseInfo(10, 1),//Moroni 10:1
					new VerseInfo(10, 2),//Moroni 10:2
					new VerseInfo(10, 3),//Moroni 10:3
					new VerseInfo(10, 4, 10, 5),//Moroni 10:4
					new VerseInfo(10, 5),//Moroni 10:5
					new VerseInfo(10, 6),//Moroni 10:6
					new VerseInfo(10, 7),//Moroni 10:7
					new VerseInfo(10, 8, 10, 9),//Moroni 10:8
					new VerseInfo(10, 10),//Moroni 10:9
					new VerseInfo(10, 10),//Moroni 10:10
					new VerseInfo(10, 10),//Moroni 10:11
					new VerseInfo(10, 11),//Moroni 10:12
					new VerseInfo(10, 11),//Moroni 10:13
					new VerseInfo(10, 11),//Moroni 10:14
					new VerseInfo(10, 11),//Moroni 10:15
					new VerseInfo(10, 11),//Moroni 10:16
					new VerseInfo(10, 12),//Moroni 10:17
					new VerseInfo(10, 13),//Moroni 10:18
					new VerseInfo(10, 14),//Moroni 10:19
					new VerseInfo(10, 15),//Moroni 10:20
					new VerseInfo(10, 15, 10, 16),//Moroni 10:21
					new VerseInfo(10, 16),//Moroni 10:22
					new VerseInfo(10, 17),//Moroni 10:23
					new VerseInfo(10, 18),//Moroni 10:24
					new VerseInfo(10, 19, 10, 20),//Moroni 10:25
					new VerseInfo(10, 21),//Moroni 10:26
					new VerseInfo(10, 22, 10, 23),//Moroni 10:27
					new VerseInfo(10, 24, 10, 25),//Moroni 10:28
					new VerseInfo(10, 26),//Moroni 10:29
					new VerseInfo(10, 27),//Moroni 10:30
					new VerseInfo(10, 28),//Moroni 10:31
					new VerseInfo(10, 29),//Moroni 10:32
					new VerseInfo(10, 30),//Moroni 10:33
					new VerseInfo(10, 31),//Moroni 10:34
				},
			}
		},
	};
}
