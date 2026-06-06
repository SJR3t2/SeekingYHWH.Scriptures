using System;
using System.Collections.Generic;

namespace SeekingYHWH.Scriptures;

public static class BoMRLDS
{
	public static readonly Dictionary<string, VerseInfo?[]?[]> Books = new Dictionary<string, VerseInfo?[]?[]>()
	{
		{ "1 Nephi", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//1 Nephi 1
					new VerseInfo(1, 1, 1, 2),//1 Nephi 1:1
					new VerseInfo(1, 3),//1 Nephi 1:2
					new VerseInfo(1, 4),//1 Nephi 1:3
					new VerseInfo(1, 5),//1 Nephi 1:4
					new VerseInfo(1, 6),//1 Nephi 1:5
					new VerseInfo(1, 7),//1 Nephi 1:6
					new VerseInfo(1, 8),//1 Nephi 1:7
					new VerseInfo(1, 9),//1 Nephi 1:8
					new VerseInfo(1, 10, 1, 11),//1 Nephi 1:9
					new VerseInfo(1, 11),//1 Nephi 1:10
					new VerseInfo(1, 12, 1, 13),//1 Nephi 1:11
					new VerseInfo(1, 13),//1 Nephi 1:12
					new VerseInfo(1, 14),//1 Nephi 1:13
					new VerseInfo(1, 15),//1 Nephi 1:14
					new VerseInfo(1, 16),//1 Nephi 1:15
					new VerseInfo(1, 16, 1, 17),//1 Nephi 1:16
					new VerseInfo(1, 17),//1 Nephi 1:17
					new VerseInfo(1, 18),//1 Nephi 1:18
					new VerseInfo(1, 19),//1 Nephi 1:19
					new VerseInfo(1, 19),//1 Nephi 1:20
					new VerseInfo(1, 20),//1 Nephi 1:21
					new VerseInfo(1, 20),//1 Nephi 1:22
					new VerseInfo(1, 20),//1 Nephi 1:23
					new VerseInfo(2, 1),//1 Nephi 1:24
					new VerseInfo(2, 1),//1 Nephi 1:25
					new VerseInfo(2, 2),//1 Nephi 1:26
					new VerseInfo(2, 3),//1 Nephi 1:27
					new VerseInfo(2, 4),//1 Nephi 1:28
					new VerseInfo(2, 4),//1 Nephi 1:29
					new VerseInfo(2, 5),//1 Nephi 1:30
					new VerseInfo(2, 5),//1 Nephi 1:31
					new VerseInfo(2, 5),//1 Nephi 1:32
					new VerseInfo(2, 6),//1 Nephi 1:33
					new VerseInfo(2, 7),//1 Nephi 1:34
					new VerseInfo(2, 8),//1 Nephi 1:35
					new VerseInfo(2, 9),//1 Nephi 1:36
					new VerseInfo(2, 10),//1 Nephi 1:37
					new VerseInfo(2, 11),//1 Nephi 1:38
					new VerseInfo(2, 11),//1 Nephi 1:39
					new VerseInfo(2, 12),//1 Nephi 1:40
					new VerseInfo(2, 12),//1 Nephi 1:41
					new VerseInfo(2, 13),//1 Nephi 1:42
					new VerseInfo(2, 13),//1 Nephi 1:43
					new VerseInfo(2, 14),//1 Nephi 1:44
					new VerseInfo(2, 14),//1 Nephi 1:45
					new VerseInfo(2, 15),//1 Nephi 1:46
					new VerseInfo(2, 16),//1 Nephi 1:47
					new VerseInfo(2, 16),//1 Nephi 1:48
					new VerseInfo(2, 17),//1 Nephi 1:49
					new VerseInfo(2, 17),//1 Nephi 1:50
					new VerseInfo(2, 18),//1 Nephi 1:51
					new VerseInfo(2, 18),//1 Nephi 1:52
					new VerseInfo(2, 19),//1 Nephi 1:53
					new VerseInfo(2, 20),//1 Nephi 1:54
					new VerseInfo(2, 21),//1 Nephi 1:55
					new VerseInfo(2, 22),//1 Nephi 1:56
					new VerseInfo(2, 23),//1 Nephi 1:57
					new VerseInfo(2, 24),//1 Nephi 1:58
					new VerseInfo(3, 1),//1 Nephi 1:59
					new VerseInfo(3, 2),//1 Nephi 1:60
					new VerseInfo(3, 3),//1 Nephi 1:61
					new VerseInfo(3, 4),//1 Nephi 1:62
					new VerseInfo(3, 5),//1 Nephi 1:63
					new VerseInfo(3, 6),//1 Nephi 1:64
					new VerseInfo(3, 7),//1 Nephi 1:65
					new VerseInfo(3, 8),//1 Nephi 1:66
					new VerseInfo(3, 9),//1 Nephi 1:67
					new VerseInfo(3, 10, 3, 11),//1 Nephi 1:68
					new VerseInfo(3, 11),//1 Nephi 1:69
					new VerseInfo(3, 12),//1 Nephi 1:70
					new VerseInfo(3, 13),//1 Nephi 1:71
					new VerseInfo(3, 13),//1 Nephi 1:72
					new VerseInfo(3, 14),//1 Nephi 1:73
					new VerseInfo(3, 14),//1 Nephi 1:74
					new VerseInfo(3, 15),//1 Nephi 1:75
					new VerseInfo(3, 16),//1 Nephi 1:76
					new VerseInfo(3, 16),//1 Nephi 1:77
					new VerseInfo(3, 16, 3, 17),//1 Nephi 1:78
					new VerseInfo(3, 18),//1 Nephi 1:79
					new VerseInfo(3, 18),//1 Nephi 1:80
					new VerseInfo(3, 18),//1 Nephi 1:81
					new VerseInfo(3, 19),//1 Nephi 1:82
					new VerseInfo(3, 20),//1 Nephi 1:83
					new VerseInfo(3, 21),//1 Nephi 1:84
					new VerseInfo(3, 22),//1 Nephi 1:85
					new VerseInfo(3, 23),//1 Nephi 1:86
					new VerseInfo(3, 24),//1 Nephi 1:87
					new VerseInfo(3, 25),//1 Nephi 1:88
					new VerseInfo(3, 26),//1 Nephi 1:89
					new VerseInfo(3, 27),//1 Nephi 1:90
					new VerseInfo(3, 28),//1 Nephi 1:91
					new VerseInfo(3, 28),//1 Nephi 1:92
					new VerseInfo(3, 29),//1 Nephi 1:93
					new VerseInfo(3, 29),//1 Nephi 1:94
					new VerseInfo(3, 29),//1 Nephi 1:95
					new VerseInfo(3, 30),//1 Nephi 1:96
					new VerseInfo(3, 31),//1 Nephi 1:97
					new VerseInfo(3, 31),//1 Nephi 1:98
					new VerseInfo(4, 1),//1 Nephi 1:99
					new VerseInfo(4, 2),//1 Nephi 1:100
					new VerseInfo(4, 3),//1 Nephi 1:101
					new VerseInfo(4, 3),//1 Nephi 1:102
					new VerseInfo(4, 4),//1 Nephi 1:103
					new VerseInfo(4, 5),//1 Nephi 1:104
					new VerseInfo(4, 5),//1 Nephi 1:105
					new VerseInfo(4, 6),//1 Nephi 1:106
					new VerseInfo(4, 7),//1 Nephi 1:107
					new VerseInfo(4, 8),//1 Nephi 1:108
					new VerseInfo(4, 9),//1 Nephi 1:109
					new VerseInfo(4, 10),//1 Nephi 1:110
					new VerseInfo(4, 10),//1 Nephi 1:111
					new VerseInfo(4, 11),//1 Nephi 1:112
					new VerseInfo(4, 12),//1 Nephi 1:113
					new VerseInfo(4, 13),//1 Nephi 1:114
					new VerseInfo(4, 13),//1 Nephi 1:115
					new VerseInfo(4, 14),//1 Nephi 1:116
					new VerseInfo(4, 15),//1 Nephi 1:117
					new VerseInfo(4, 16),//1 Nephi 1:118
					new VerseInfo(4, 17),//1 Nephi 1:119
					new VerseInfo(4, 18),//1 Nephi 1:120
					new VerseInfo(4, 19),//1 Nephi 1:121
					new VerseInfo(4, 20),//1 Nephi 1:122
					new VerseInfo(4, 20),//1 Nephi 1:123
					new VerseInfo(4, 20, 4, 21),//1 Nephi 1:124
					new VerseInfo(4, 22),//1 Nephi 1:125
					new VerseInfo(4, 23),//1 Nephi 1:126
					new VerseInfo(4, 24),//1 Nephi 1:127
					new VerseInfo(4, 25),//1 Nephi 1:128
					new VerseInfo(4, 26),//1 Nephi 1:129
					new VerseInfo(4, 27),//1 Nephi 1:130
					new VerseInfo(4, 28),//1 Nephi 1:131
					new VerseInfo(4, 28),//1 Nephi 1:132
					new VerseInfo(4, 29),//1 Nephi 1:133
					new VerseInfo(4, 30),//1 Nephi 1:134
					new VerseInfo(4, 31),//1 Nephi 1:135
					new VerseInfo(4, 32),//1 Nephi 1:136
					new VerseInfo(4, 33),//1 Nephi 1:137
					new VerseInfo(4, 34),//1 Nephi 1:138
					new VerseInfo(4, 34),//1 Nephi 1:139
					new VerseInfo(4, 35),//1 Nephi 1:140
					new VerseInfo(4, 35),//1 Nephi 1:141
					new VerseInfo(4, 35),//1 Nephi 1:142
					new VerseInfo(4, 36),//1 Nephi 1:143
					new VerseInfo(4, 37),//1 Nephi 1:144
					new VerseInfo(4, 38),//1 Nephi 1:145
					new VerseInfo(5, 1, 5, 2),//1 Nephi 1:146
					new VerseInfo(5, 2),//1 Nephi 1:147
					new VerseInfo(5, 3),//1 Nephi 1:148
					new VerseInfo(5, 4),//1 Nephi 1:149
					new VerseInfo(5, 5),//1 Nephi 1:150
					new VerseInfo(5, 5),//1 Nephi 1:151
					new VerseInfo(5, 6),//1 Nephi 1:152
					new VerseInfo(5, 7),//1 Nephi 1:153
					new VerseInfo(5, 8),//1 Nephi 1:154
					new VerseInfo(5, 8),//1 Nephi 1:155
					new VerseInfo(5, 8),//1 Nephi 1:156
					new VerseInfo(5, 9),//1 Nephi 1:157
					new VerseInfo(5, 10),//1 Nephi 1:158
					new VerseInfo(5, 11),//1 Nephi 1:159
					new VerseInfo(5, 11),//1 Nephi 1:160
					new VerseInfo(5, 12),//1 Nephi 1:161
					new VerseInfo(5, 13),//1 Nephi 1:162
					new VerseInfo(5, 13),//1 Nephi 1:163
					new VerseInfo(5, 14),//1 Nephi 1:164
					new VerseInfo(5, 14),//1 Nephi 1:165
					new VerseInfo(5, 15),//1 Nephi 1:166
					new VerseInfo(5, 16),//1 Nephi 1:167
					new VerseInfo(5, 16),//1 Nephi 1:168
					new VerseInfo(5, 17, 5, 18),//1 Nephi 1:169
					new VerseInfo(5, 19),//1 Nephi 1:170
					new VerseInfo(5, 19),//1 Nephi 1:171
					new VerseInfo(5, 20),//1 Nephi 1:172
					new VerseInfo(5, 21),//1 Nephi 1:173
					new VerseInfo(5, 22),//1 Nephi 1:174
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//1 Nephi 2
					new VerseInfo(6, 1),//1 Nephi 2:1
					new VerseInfo(6, 2),//1 Nephi 2:2
					new VerseInfo(6, 3),//1 Nephi 2:3
					new VerseInfo(6, 4),//1 Nephi 2:4
					new VerseInfo(6, 5),//1 Nephi 2:5
					new VerseInfo(6, 6),//1 Nephi 2:6
					new VerseInfo(7, 1),//1 Nephi 2:7
					new VerseInfo(7, 2),//1 Nephi 2:8
					new VerseInfo(7, 3),//1 Nephi 2:9
					new VerseInfo(7, 4),//1 Nephi 2:10
					new VerseInfo(7, 5),//1 Nephi 2:11
					new VerseInfo(7, 6),//1 Nephi 2:12
					new VerseInfo(7, 7),//1 Nephi 2:13
					new VerseInfo(7, 8),//1 Nephi 2:14
					new VerseInfo(7, 9),//1 Nephi 2:15
					new VerseInfo(7, 10),//1 Nephi 2:16
					new VerseInfo(7, 11),//1 Nephi 2:17
					new VerseInfo(7, 12),//1 Nephi 2:18
					new VerseInfo(7, 13),//1 Nephi 2:19
					new VerseInfo(7, 13),//1 Nephi 2:20
					new VerseInfo(7, 14),//1 Nephi 2:21
					new VerseInfo(7, 14),//1 Nephi 2:22
					new VerseInfo(7, 14),//1 Nephi 2:23
					new VerseInfo(7, 15),//1 Nephi 2:24
					new VerseInfo(7, 15),//1 Nephi 2:25
					new VerseInfo(7, 16),//1 Nephi 2:26
					new VerseInfo(7, 16),//1 Nephi 2:27
					new VerseInfo(7, 17),//1 Nephi 2:28
					new VerseInfo(7, 17),//1 Nephi 2:29
					new VerseInfo(7, 18),//1 Nephi 2:30
					new VerseInfo(7, 19),//1 Nephi 2:31
					new VerseInfo(7, 19),//1 Nephi 2:32
					new VerseInfo(7, 20),//1 Nephi 2:33
					new VerseInfo(7, 21),//1 Nephi 2:34
					new VerseInfo(7, 21),//1 Nephi 2:35
					new VerseInfo(7, 21),//1 Nephi 2:36
					new VerseInfo(7, 22),//1 Nephi 2:37
					new VerseInfo(7, 22),//1 Nephi 2:38
					new VerseInfo(7, 22),//1 Nephi 2:39
					new VerseInfo(8, 1),//1 Nephi 2:40
					new VerseInfo(8, 2),//1 Nephi 2:41
					new VerseInfo(8, 3),//1 Nephi 2:42
					new VerseInfo(8, 4),//1 Nephi 2:43
					new VerseInfo(8, 5),//1 Nephi 2:44
					new VerseInfo(8, 6),//1 Nephi 2:45
					new VerseInfo(8, 7),//1 Nephi 2:46
					new VerseInfo(8, 8),//1 Nephi 2:47
					new VerseInfo(8, 9),//1 Nephi 2:48
					new VerseInfo(8, 10),//1 Nephi 2:49
					new VerseInfo(8, 11),//1 Nephi 2:50
					new VerseInfo(8, 11),//1 Nephi 2:51
					new VerseInfo(8, 12),//1 Nephi 2:52
					new VerseInfo(8, 12),//1 Nephi 2:53
					new VerseInfo(8, 13),//1 Nephi 2:54
					new VerseInfo(8, 14),//1 Nephi 2:55
					new VerseInfo(8, 14),//1 Nephi 2:56
					new VerseInfo(8, 15),//1 Nephi 2:57
					new VerseInfo(8, 16),//1 Nephi 2:58
					new VerseInfo(8, 17),//1 Nephi 2:59
					new VerseInfo(8, 17),//1 Nephi 2:60
					new VerseInfo(8, 18),//1 Nephi 2:61
					new VerseInfo(8, 19),//1 Nephi 2:62
					new VerseInfo(8, 20),//1 Nephi 2:63
					new VerseInfo(8, 20),//1 Nephi 2:64
					new VerseInfo(8, 21),//1 Nephi 2:65
					new VerseInfo(8, 22),//1 Nephi 2:66
					new VerseInfo(8, 23),//1 Nephi 2:67
					new VerseInfo(8, 24),//1 Nephi 2:68
					new VerseInfo(8, 24),//1 Nephi 2:69
					new VerseInfo(8, 25),//1 Nephi 2:70
					new VerseInfo(8, 26),//1 Nephi 2:71
					new VerseInfo(8, 26),//1 Nephi 2:72
					new VerseInfo(8, 27),//1 Nephi 2:73
					new VerseInfo(8, 27),//1 Nephi 2:74
					new VerseInfo(8, 27),//1 Nephi 2:75
					new VerseInfo(8, 28),//1 Nephi 2:76
					new VerseInfo(8, 29),//1 Nephi 2:77
					new VerseInfo(8, 30),//1 Nephi 2:78
					new VerseInfo(8, 31),//1 Nephi 2:79
					new VerseInfo(8, 32),//1 Nephi 2:80
					new VerseInfo(8, 32),//1 Nephi 2:81
					new VerseInfo(8, 33),//1 Nephi 2:82
					new VerseInfo(8, 33),//1 Nephi 2:83
					new VerseInfo(8, 34),//1 Nephi 2:84
					new VerseInfo(8, 35),//1 Nephi 2:85
					new VerseInfo(8, 36),//1 Nephi 2:86
					new VerseInfo(8, 36),//1 Nephi 2:87
					new VerseInfo(8, 37),//1 Nephi 2:88
					new VerseInfo(8, 37),//1 Nephi 2:89
					new VerseInfo(8, 38),//1 Nephi 2:90
					new VerseInfo(8, 38),//1 Nephi 2:91
					new VerseInfo(9, 1),//1 Nephi 2:92
					new VerseInfo(9, 2),//1 Nephi 2:93
					new VerseInfo(9, 2),//1 Nephi 2:94
					new VerseInfo(9, 2),//1 Nephi 2:95
					new VerseInfo(9, 3),//1 Nephi 2:96
					new VerseInfo(9, 4),//1 Nephi 2:97
					new VerseInfo(9, 4),//1 Nephi 2:98
					new VerseInfo(9, 5),//1 Nephi 2:99
					new VerseInfo(9, 6),//1 Nephi 2:100
					new VerseInfo(9, 6),//1 Nephi 2:101
					new VerseInfo(9, 6),//1 Nephi 2:102
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//1 Nephi 3
					new VerseInfo(10, 1),//1 Nephi 3:1
					new VerseInfo(10, 2, 10, 3),//1 Nephi 3:2
					new VerseInfo(10, 3),//1 Nephi 3:3
					new VerseInfo(10, 4),//1 Nephi 3:4
					new VerseInfo(10, 5),//1 Nephi 3:5
					new VerseInfo(10, 6),//1 Nephi 3:6
					new VerseInfo(10, 7),//1 Nephi 3:7
					new VerseInfo(10, 8),//1 Nephi 3:8
					new VerseInfo(10, 8),//1 Nephi 3:9
					new VerseInfo(10, 8),//1 Nephi 3:10
					new VerseInfo(10, 9),//1 Nephi 3:11
					new VerseInfo(10, 10),//1 Nephi 3:12
					new VerseInfo(10, 11),//1 Nephi 3:13
					new VerseInfo(10, 11),//1 Nephi 3:14
					new VerseInfo(10, 11),//1 Nephi 3:15
					new VerseInfo(10, 12),//1 Nephi 3:16
					new VerseInfo(10, 13),//1 Nephi 3:17
					new VerseInfo(10, 14),//1 Nephi 3:18
					new VerseInfo(10, 14),//1 Nephi 3:19
					new VerseInfo(10, 15),//1 Nephi 3:20
					new VerseInfo(10, 15),//1 Nephi 3:21
					new VerseInfo(10, 16),//1 Nephi 3:22
					new VerseInfo(10, 17),//1 Nephi 3:23
					new VerseInfo(10, 17),//1 Nephi 3:24
					new VerseInfo(10, 17),//1 Nephi 3:25
					new VerseInfo(10, 17),//1 Nephi 3:26
					new VerseInfo(10, 18),//1 Nephi 3:27
					new VerseInfo(10, 18),//1 Nephi 3:28
					new VerseInfo(10, 19),//1 Nephi 3:29
					new VerseInfo(10, 19),//1 Nephi 3:30
					new VerseInfo(10, 19),//1 Nephi 3:31
					new VerseInfo(10, 19),//1 Nephi 3:32
					new VerseInfo(10, 20),//1 Nephi 3:33
					new VerseInfo(10, 21),//1 Nephi 3:34
					new VerseInfo(10, 21),//1 Nephi 3:35
					new VerseInfo(10, 22),//1 Nephi 3:36
					new VerseInfo(11, 1),//1 Nephi 3:37
					new VerseInfo(11, 1),//1 Nephi 3:38
					new VerseInfo(11, 2),//1 Nephi 3:39
					new VerseInfo(11, 3),//1 Nephi 3:40
					new VerseInfo(11, 4),//1 Nephi 3:41
					new VerseInfo(11, 5),//1 Nephi 3:42
					new VerseInfo(11, 6),//1 Nephi 3:43
					new VerseInfo(11, 6),//1 Nephi 3:44
					new VerseInfo(11, 7),//1 Nephi 3:45
					new VerseInfo(11, 8),//1 Nephi 3:46
					new VerseInfo(11, 9),//1 Nephi 3:47
					new VerseInfo(11, 10),//1 Nephi 3:48
					new VerseInfo(11, 11),//1 Nephi 3:49
					new VerseInfo(11, 11),//1 Nephi 3:50
					new VerseInfo(11, 12),//1 Nephi 3:51
					new VerseInfo(11, 13),//1 Nephi 3:52
					new VerseInfo(11, 13),//1 Nephi 3:53
					new VerseInfo(11, 14),//1 Nephi 3:54
					new VerseInfo(11, 15),//1 Nephi 3:55
					new VerseInfo(11, 16),//1 Nephi 3:56
					new VerseInfo(11, 17),//1 Nephi 3:57
					new VerseInfo(11, 18),//1 Nephi 3:58
					new VerseInfo(11, 19),//1 Nephi 3:59
					new VerseInfo(11, 19),//1 Nephi 3:60
					new VerseInfo(11, 20),//1 Nephi 3:61
					new VerseInfo(11, 21),//1 Nephi 3:62
					new VerseInfo(11, 21),//1 Nephi 3:63
					new VerseInfo(11, 22),//1 Nephi 3:64
					new VerseInfo(11, 23),//1 Nephi 3:65
					new VerseInfo(11, 24),//1 Nephi 3:66
					new VerseInfo(11, 24),//1 Nephi 3:67
					new VerseInfo(11, 25),//1 Nephi 3:68
					new VerseInfo(11, 25),//1 Nephi 3:69
					new VerseInfo(11, 26),//1 Nephi 3:70
					new VerseInfo(11, 27),//1 Nephi 3:71
					new VerseInfo(11, 27),//1 Nephi 3:72
					new VerseInfo(11, 27),//1 Nephi 3:73
					new VerseInfo(11, 27),//1 Nephi 3:74
					new VerseInfo(11, 28),//1 Nephi 3:75
					new VerseInfo(11, 28),//1 Nephi 3:76
					new VerseInfo(11, 28),//1 Nephi 3:77
					new VerseInfo(11, 29),//1 Nephi 3:78
					new VerseInfo(11, 29),//1 Nephi 3:79
					new VerseInfo(11, 30),//1 Nephi 3:80
					new VerseInfo(11, 30),//1 Nephi 3:81
					new VerseInfo(11, 31),//1 Nephi 3:82
					new VerseInfo(11, 31),//1 Nephi 3:83
					new VerseInfo(11, 31),//1 Nephi 3:84
					new VerseInfo(11, 31),//1 Nephi 3:85
					new VerseInfo(11, 32),//1 Nephi 3:86
					new VerseInfo(11, 33),//1 Nephi 3:87
					new VerseInfo(11, 34),//1 Nephi 3:88
					new VerseInfo(11, 35),//1 Nephi 3:89
					new VerseInfo(11, 35),//1 Nephi 3:90
					new VerseInfo(11, 35),//1 Nephi 3:91
					new VerseInfo(11, 35),//1 Nephi 3:92
					new VerseInfo(11, 36),//1 Nephi 3:93
					new VerseInfo(11, 36),//1 Nephi 3:94
					new VerseInfo(11, 36),//1 Nephi 3:95
					new VerseInfo(12, 1),//1 Nephi 3:96
					new VerseInfo(12, 1),//1 Nephi 3:97
					new VerseInfo(12, 1),//1 Nephi 3:98
					new VerseInfo(12, 2),//1 Nephi 3:99
					new VerseInfo(12, 3),//1 Nephi 3:100
					new VerseInfo(12, 3),//1 Nephi 3:101
					new VerseInfo(12, 4),//1 Nephi 3:102
					new VerseInfo(12, 4),//1 Nephi 3:103
					new VerseInfo(12, 4),//1 Nephi 3:104
					new VerseInfo(12, 4),//1 Nephi 3:105
					new VerseInfo(12, 4),//1 Nephi 3:106
					new VerseInfo(12, 4),//1 Nephi 3:107
					new VerseInfo(12, 4),//1 Nephi 3:108
					new VerseInfo(12, 4),//1 Nephi 3:109
					new VerseInfo(12, 5),//1 Nephi 3:110
					new VerseInfo(12, 5),//1 Nephi 3:111
					new VerseInfo(12, 6),//1 Nephi 3:112
					new VerseInfo(12, 7),//1 Nephi 3:113
					new VerseInfo(12, 8),//1 Nephi 3:114
					new VerseInfo(12, 9),//1 Nephi 3:115
					new VerseInfo(12, 9, 12, 10),//1 Nephi 3:116
					new VerseInfo(12, 10),//1 Nephi 3:117
					new VerseInfo(12, 11),//1 Nephi 3:118
					new VerseInfo(12, 11),//1 Nephi 3:119
					new VerseInfo(12, 12),//1 Nephi 3:120
					new VerseInfo(12, 13),//1 Nephi 3:121
					new VerseInfo(12, 14),//1 Nephi 3:122
					new VerseInfo(12, 15),//1 Nephi 3:123
					new VerseInfo(12, 16),//1 Nephi 3:124
					new VerseInfo(12, 17),//1 Nephi 3:125
					new VerseInfo(12, 18),//1 Nephi 3:126
					new VerseInfo(12, 18),//1 Nephi 3:127
					new VerseInfo(12, 19),//1 Nephi 3:128
					new VerseInfo(12, 19),//1 Nephi 3:129
					new VerseInfo(12, 20),//1 Nephi 3:130
					new VerseInfo(12, 21),//1 Nephi 3:131
					new VerseInfo(12, 21),//1 Nephi 3:132
					new VerseInfo(12, 22),//1 Nephi 3:133
					new VerseInfo(12, 23),//1 Nephi 3:134
					new VerseInfo(13, 1),//1 Nephi 3:135
					new VerseInfo(13, 2),//1 Nephi 3:136
					new VerseInfo(13, 2),//1 Nephi 3:137
					new VerseInfo(13, 3),//1 Nephi 3:138
					new VerseInfo(13, 4),//1 Nephi 3:139
					new VerseInfo(13, 5),//1 Nephi 3:140
					new VerseInfo(13, 6),//1 Nephi 3:141
					new VerseInfo(13, 7),//1 Nephi 3:142
					new VerseInfo(13, 8),//1 Nephi 3:143
					new VerseInfo(13, 9),//1 Nephi 3:144
					new VerseInfo(13, 10),//1 Nephi 3:145
					new VerseInfo(13, 11),//1 Nephi 3:146
					new VerseInfo(13, 12),//1 Nephi 3:147
					new VerseInfo(13, 13),//1 Nephi 3:148
					new VerseInfo(13, 14),//1 Nephi 3:149
					new VerseInfo(13, 14),//1 Nephi 3:150
					new VerseInfo(13, 15),//1 Nephi 3:151
					new VerseInfo(13, 16),//1 Nephi 3:152
					new VerseInfo(13, 17),//1 Nephi 3:153
					new VerseInfo(13, 18),//1 Nephi 3:154
					new VerseInfo(13, 19),//1 Nephi 3:155
					new VerseInfo(13, 20),//1 Nephi 3:156
					new VerseInfo(13, 20),//1 Nephi 3:157
					new VerseInfo(13, 21),//1 Nephi 3:158
					new VerseInfo(13, 22),//1 Nephi 3:159
					new VerseInfo(13, 23),//1 Nephi 3:160
					new VerseInfo(13, 23),//1 Nephi 3:161
					new VerseInfo(13, 23),//1 Nephi 3:162
					new VerseInfo(13, 23),//1 Nephi 3:163
					new VerseInfo(13, 23),//1 Nephi 3:164
					new VerseInfo(13, 24),//1 Nephi 3:165
					new VerseInfo(13, 25),//1 Nephi 3:166
					new VerseInfo(13, 26),//1 Nephi 3:167
					new VerseInfo(13, 26),//1 Nephi 3:168
					new VerseInfo(13, 26),//1 Nephi 3:169
					new VerseInfo(13, 27),//1 Nephi 3:170
					new VerseInfo(13, 28),//1 Nephi 3:171
					new VerseInfo(13, 29),//1 Nephi 3:172
					new VerseInfo(13, 29),//1 Nephi 3:173
					new VerseInfo(13, 29),//1 Nephi 3:174
					new VerseInfo(13, 29),//1 Nephi 3:175
					new VerseInfo(13, 30),//1 Nephi 3:176
					new VerseInfo(13, 30),//1 Nephi 3:177
					new VerseInfo(13, 31),//1 Nephi 3:178
					new VerseInfo(13, 32),//1 Nephi 3:179
					new VerseInfo(13, 33),//1 Nephi 3:180
					new VerseInfo(13, 34),//1 Nephi 3:181
					new VerseInfo(13, 34),//1 Nephi 3:182
					new VerseInfo(13, 34),//1 Nephi 3:183
					new VerseInfo(13, 35),//1 Nephi 3:184
					new VerseInfo(13, 35),//1 Nephi 3:185
					new VerseInfo(13, 36),//1 Nephi 3:186
					new VerseInfo(13, 37),//1 Nephi 3:187
					new VerseInfo(13, 37),//1 Nephi 3:188
					new VerseInfo(13, 37),//1 Nephi 3:189
					new VerseInfo(13, 38),//1 Nephi 3:190
					new VerseInfo(13, 39),//1 Nephi 3:191
					new VerseInfo(13, 40),//1 Nephi 3:192
					new VerseInfo(13, 40),//1 Nephi 3:193
					new VerseInfo(13, 41),//1 Nephi 3:194
					new VerseInfo(13, 41),//1 Nephi 3:195
					new VerseInfo(13, 41),//1 Nephi 3:196
					new VerseInfo(13, 41),//1 Nephi 3:197
					new VerseInfo(13, 42),//1 Nephi 3:198
					new VerseInfo(13, 42),//1 Nephi 3:199
					new VerseInfo(13, 42),//1 Nephi 3:200
					new VerseInfo(14, 1, 14, 2),//1 Nephi 3:201
					new VerseInfo(14, 2),//1 Nephi 3:202
					new VerseInfo(14, 2),//1 Nephi 3:203
					new VerseInfo(14, 2),//1 Nephi 3:204
					new VerseInfo(14, 2),//1 Nephi 3:205
					new VerseInfo(14, 3),//1 Nephi 3:206
					new VerseInfo(14, 3),//1 Nephi 3:207
					new VerseInfo(14, 3),//1 Nephi 3:208
					new VerseInfo(14, 4),//1 Nephi 3:209
					new VerseInfo(14, 5),//1 Nephi 3:210
					new VerseInfo(14, 5),//1 Nephi 3:211
					new VerseInfo(14, 5),//1 Nephi 3:212
					new VerseInfo(14, 6),//1 Nephi 3:213
					new VerseInfo(14, 7),//1 Nephi 3:214
					new VerseInfo(14, 7),//1 Nephi 3:215
					new VerseInfo(14, 7),//1 Nephi 3:216
					new VerseInfo(14, 8),//1 Nephi 3:217
					new VerseInfo(14, 8),//1 Nephi 3:218
					new VerseInfo(14, 9),//1 Nephi 3:219
					new VerseInfo(14, 10),//1 Nephi 3:220
					new VerseInfo(14, 10),//1 Nephi 3:221
					new VerseInfo(14, 10),//1 Nephi 3:222
					new VerseInfo(14, 10),//1 Nephi 3:223
					new VerseInfo(14, 11),//1 Nephi 3:224
					new VerseInfo(14, 11),//1 Nephi 3:225
					new VerseInfo(14, 12),//1 Nephi 3:226
					new VerseInfo(14, 12),//1 Nephi 3:227
					new VerseInfo(14, 12),//1 Nephi 3:228
					new VerseInfo(14, 13),//1 Nephi 3:229
					new VerseInfo(14, 14),//1 Nephi 3:230
					new VerseInfo(14, 14),//1 Nephi 3:231
					new VerseInfo(14, 15),//1 Nephi 3:232
					new VerseInfo(14, 16),//1 Nephi 3:233
					new VerseInfo(14, 16),//1 Nephi 3:234
					new VerseInfo(14, 16),//1 Nephi 3:235
					new VerseInfo(14, 17),//1 Nephi 3:236
					new VerseInfo(14, 17),//1 Nephi 3:237
					new VerseInfo(14, 18, 14, 19),//1 Nephi 3:238
					new VerseInfo(14, 20),//1 Nephi 3:239
					new VerseInfo(14, 21),//1 Nephi 3:240
					new VerseInfo(14, 21),//1 Nephi 3:241
					new VerseInfo(14, 22),//1 Nephi 3:242
					new VerseInfo(14, 23),//1 Nephi 3:243
					new VerseInfo(14, 23),//1 Nephi 3:244
					new VerseInfo(14, 23),//1 Nephi 3:245
					new VerseInfo(14, 24),//1 Nephi 3:246
					new VerseInfo(14, 24),//1 Nephi 3:247
					new VerseInfo(14, 25),//1 Nephi 3:248
					new VerseInfo(14, 26),//1 Nephi 3:249
					new VerseInfo(14, 26),//1 Nephi 3:250
					new VerseInfo(14, 27),//1 Nephi 3:251
					new VerseInfo(14, 28),//1 Nephi 3:252
					new VerseInfo(14, 28),//1 Nephi 3:253
					new VerseInfo(14, 29),//1 Nephi 3:254
					new VerseInfo(14, 30),//1 Nephi 3:255
					new VerseInfo(14, 30),//1 Nephi 3:256
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//1 Nephi 4
					new VerseInfo(15, 1),//1 Nephi 4:1
					new VerseInfo(15, 2),//1 Nephi 4:2
					new VerseInfo(15, 3),//1 Nephi 4:3
					new VerseInfo(15, 3),//1 Nephi 4:4
					new VerseInfo(15, 4),//1 Nephi 4:5
					new VerseInfo(15, 5),//1 Nephi 4:6
					new VerseInfo(15, 6),//1 Nephi 4:7
					new VerseInfo(15, 7),//1 Nephi 4:8
					new VerseInfo(15, 8),//1 Nephi 4:9
					new VerseInfo(15, 9),//1 Nephi 4:10
					new VerseInfo(15, 10),//1 Nephi 4:11
					new VerseInfo(15, 10),//1 Nephi 4:12
					new VerseInfo(15, 11),//1 Nephi 4:13
					new VerseInfo(15, 12),//1 Nephi 4:14
					new VerseInfo(15, 12),//1 Nephi 4:15
					new VerseInfo(15, 13),//1 Nephi 4:16
					new VerseInfo(15, 14),//1 Nephi 4:17
					new VerseInfo(15, 14),//1 Nephi 4:18
					new VerseInfo(15, 14),//1 Nephi 4:19
					new VerseInfo(15, 15),//1 Nephi 4:20
					new VerseInfo(15, 15),//1 Nephi 4:21
					new VerseInfo(15, 15),//1 Nephi 4:22
					new VerseInfo(15, 16),//1 Nephi 4:23
					new VerseInfo(15, 16),//1 Nephi 4:24
					new VerseInfo(15, 17),//1 Nephi 4:25
					new VerseInfo(15, 17),//1 Nephi 4:26
					new VerseInfo(15, 17),//1 Nephi 4:27
					new VerseInfo(15, 18),//1 Nephi 4:28
					new VerseInfo(15, 18),//1 Nephi 4:29
					new VerseInfo(15, 19),//1 Nephi 4:30
					new VerseInfo(15, 19),//1 Nephi 4:31
					new VerseInfo(15, 20),//1 Nephi 4:32
					new VerseInfo(15, 20),//1 Nephi 4:33
					new VerseInfo(15, 20),//1 Nephi 4:34
					new VerseInfo(15, 21),//1 Nephi 4:35
					new VerseInfo(15, 21),//1 Nephi 4:36
					new VerseInfo(15, 22),//1 Nephi 4:37
					new VerseInfo(15, 23),//1 Nephi 4:38
					new VerseInfo(15, 24),//1 Nephi 4:39
					new VerseInfo(15, 24),//1 Nephi 4:40
					new VerseInfo(15, 25),//1 Nephi 4:41
					new VerseInfo(15, 25),//1 Nephi 4:42
					new VerseInfo(15, 26),//1 Nephi 4:43
					new VerseInfo(15, 27),//1 Nephi 4:44
					new VerseInfo(15, 27),//1 Nephi 4:45
					new VerseInfo(15, 28),//1 Nephi 4:46
					new VerseInfo(15, 29),//1 Nephi 4:47
					new VerseInfo(15, 30),//1 Nephi 4:48
					new VerseInfo(15, 30),//1 Nephi 4:49
					new VerseInfo(15, 31),//1 Nephi 4:50
					new VerseInfo(15, 32),//1 Nephi 4:51
					new VerseInfo(15, 32),//1 Nephi 4:52
					new VerseInfo(15, 33),//1 Nephi 4:53
					new VerseInfo(15, 33),//1 Nephi 4:54
					new VerseInfo(15, 33),//1 Nephi 4:55
					new VerseInfo(15, 33),//1 Nephi 4:56
					new VerseInfo(15, 33),//1 Nephi 4:57
					new VerseInfo(15, 34),//1 Nephi 4:58
					new VerseInfo(15, 34),//1 Nephi 4:59
					new VerseInfo(15, 35),//1 Nephi 4:60
					new VerseInfo(15, 35),//1 Nephi 4:61
					new VerseInfo(15, 36),//1 Nephi 4:62
					new VerseInfo(15, 36),//1 Nephi 4:63
					new VerseInfo(15, 36),//1 Nephi 4:64
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//1 Nephi 5
					new VerseInfo(16, 1),//1 Nephi 5:1
					new VerseInfo(16, 2),//1 Nephi 5:2
					new VerseInfo(16, 3),//1 Nephi 5:3
					new VerseInfo(16, 4),//1 Nephi 5:4
					new VerseInfo(16, 5),//1 Nephi 5:5
					new VerseInfo(16, 6),//1 Nephi 5:6
					new VerseInfo(16, 7),//1 Nephi 5:7
					new VerseInfo(16, 8),//1 Nephi 5:8
					new VerseInfo(16, 8),//1 Nephi 5:9
					new VerseInfo(16, 9),//1 Nephi 5:10
					new VerseInfo(16, 10),//1 Nephi 5:11
					new VerseInfo(16, 10),//1 Nephi 5:12
					new VerseInfo(16, 11),//1 Nephi 5:13
					new VerseInfo(16, 11),//1 Nephi 5:14
					new VerseInfo(16, 12),//1 Nephi 5:15
					new VerseInfo(16, 13),//1 Nephi 5:16
					new VerseInfo(16, 14),//1 Nephi 5:17
					new VerseInfo(16, 14),//1 Nephi 5:18
					new VerseInfo(16, 15),//1 Nephi 5:19
					new VerseInfo(16, 16),//1 Nephi 5:20
					new VerseInfo(16, 17),//1 Nephi 5:21
					new VerseInfo(16, 18),//1 Nephi 5:22
					new VerseInfo(16, 19),//1 Nephi 5:23
					new VerseInfo(16, 19),//1 Nephi 5:24
					new VerseInfo(16, 20),//1 Nephi 5:25
					new VerseInfo(16, 21),//1 Nephi 5:26
					new VerseInfo(16, 22),//1 Nephi 5:27
					new VerseInfo(16, 23),//1 Nephi 5:28
					new VerseInfo(16, 23),//1 Nephi 5:29
					new VerseInfo(16, 24),//1 Nephi 5:30
					new VerseInfo(16, 25),//1 Nephi 5:31
					new VerseInfo(16, 26),//1 Nephi 5:32
					new VerseInfo(16, 27),//1 Nephi 5:33
					new VerseInfo(16, 28),//1 Nephi 5:34
					new VerseInfo(16, 29),//1 Nephi 5:35
					new VerseInfo(16, 29),//1 Nephi 5:36
					new VerseInfo(16, 30),//1 Nephi 5:37
					new VerseInfo(16, 31),//1 Nephi 5:38
					new VerseInfo(16, 32),//1 Nephi 5:39
					new VerseInfo(16, 32),//1 Nephi 5:40
					new VerseInfo(16, 32),//1 Nephi 5:41
					new VerseInfo(16, 33),//1 Nephi 5:42
					new VerseInfo(16, 33),//1 Nephi 5:43
					new VerseInfo(16, 34),//1 Nephi 5:44
					new VerseInfo(16, 35),//1 Nephi 5:45
					new VerseInfo(16, 35),//1 Nephi 5:46
					new VerseInfo(16, 36),//1 Nephi 5:47
					new VerseInfo(16, 37),//1 Nephi 5:48
					new VerseInfo(16, 38),//1 Nephi 5:49
					new VerseInfo(16, 38),//1 Nephi 5:50
					new VerseInfo(16, 38),//1 Nephi 5:51
					new VerseInfo(16, 38),//1 Nephi 5:52
					new VerseInfo(16, 39),//1 Nephi 5:53
					new VerseInfo(16, 39),//1 Nephi 5:54
					new VerseInfo(17, 1),//1 Nephi 5:55
					new VerseInfo(17, 1),//1 Nephi 5:56
					new VerseInfo(17, 2),//1 Nephi 5:57
					new VerseInfo(17, 3),//1 Nephi 5:58
					new VerseInfo(17, 3),//1 Nephi 5:59
					new VerseInfo(17, 3),//1 Nephi 5:60
					new VerseInfo(17, 4),//1 Nephi 5:61
					new VerseInfo(17, 5),//1 Nephi 5:62
					new VerseInfo(17, 5),//1 Nephi 5:63
					new VerseInfo(17, 5),//1 Nephi 5:64
					new VerseInfo(17, 6),//1 Nephi 5:65
					new VerseInfo(17, 6),//1 Nephi 5:66
					new VerseInfo(17, 6),//1 Nephi 5:67
					new VerseInfo(17, 7),//1 Nephi 5:68
					new VerseInfo(17, 7),//1 Nephi 5:69
					new VerseInfo(17, 8),//1 Nephi 5:70
					new VerseInfo(17, 9),//1 Nephi 5:71
					new VerseInfo(17, 10),//1 Nephi 5:72
					new VerseInfo(17, 11),//1 Nephi 5:73
					new VerseInfo(17, 11),//1 Nephi 5:74
					new VerseInfo(17, 12),//1 Nephi 5:75
					new VerseInfo(17, 12),//1 Nephi 5:76
					new VerseInfo(17, 13),//1 Nephi 5:77
					new VerseInfo(17, 13),//1 Nephi 5:78
					new VerseInfo(17, 13),//1 Nephi 5:79
					new VerseInfo(17, 14),//1 Nephi 5:80
					new VerseInfo(17, 14),//1 Nephi 5:81
					new VerseInfo(17, 14),//1 Nephi 5:82
					new VerseInfo(17, 15),//1 Nephi 5:83
					new VerseInfo(17, 16),//1 Nephi 5:84
					new VerseInfo(17, 17),//1 Nephi 5:85
					new VerseInfo(17, 17),//1 Nephi 5:86
					new VerseInfo(17, 17),//1 Nephi 5:87
					new VerseInfo(17, 18),//1 Nephi 5:88
					new VerseInfo(17, 18),//1 Nephi 5:89
					new VerseInfo(17, 19),//1 Nephi 5:90
					new VerseInfo(17, 19),//1 Nephi 5:91
					new VerseInfo(17, 19),//1 Nephi 5:92
					new VerseInfo(17, 20),//1 Nephi 5:93
					new VerseInfo(17, 20),//1 Nephi 5:94
					new VerseInfo(17, 20),//1 Nephi 5:95
					new VerseInfo(17, 20),//1 Nephi 5:96
					new VerseInfo(17, 21),//1 Nephi 5:97
					new VerseInfo(17, 22),//1 Nephi 5:98
					new VerseInfo(17, 22),//1 Nephi 5:99
					new VerseInfo(17, 22),//1 Nephi 5:100
					new VerseInfo(17, 22),//1 Nephi 5:101
					new VerseInfo(17, 22),//1 Nephi 5:102
					new VerseInfo(17, 23),//1 Nephi 5:103
					new VerseInfo(17, 24),//1 Nephi 5:104
					new VerseInfo(17, 25),//1 Nephi 5:105
					new VerseInfo(17, 25),//1 Nephi 5:106
					new VerseInfo(17, 26),//1 Nephi 5:107
					new VerseInfo(17, 26),//1 Nephi 5:108
					new VerseInfo(17, 27),//1 Nephi 5:109
					new VerseInfo(17, 28),//1 Nephi 5:110
					new VerseInfo(17, 29),//1 Nephi 5:111
					new VerseInfo(17, 30),//1 Nephi 5:112
					new VerseInfo(17, 31),//1 Nephi 5:113
					new VerseInfo(17, 31),//1 Nephi 5:114
					new VerseInfo(17, 31),//1 Nephi 5:115
					new VerseInfo(17, 31),//1 Nephi 5:116
					new VerseInfo(17, 32),//1 Nephi 5:117
					new VerseInfo(17, 33),//1 Nephi 5:118
					new VerseInfo(17, 34),//1 Nephi 5:119
					new VerseInfo(17, 34),//1 Nephi 5:120
					new VerseInfo(17, 35),//1 Nephi 5:121
					new VerseInfo(17, 35),//1 Nephi 5:122
					new VerseInfo(17, 35),//1 Nephi 5:123
					new VerseInfo(17, 35),//1 Nephi 5:124
					new VerseInfo(17, 35),//1 Nephi 5:125
					new VerseInfo(17, 36),//1 Nephi 5:126
					new VerseInfo(17, 36),//1 Nephi 5:127
					new VerseInfo(17, 37),//1 Nephi 5:128
					new VerseInfo(17, 38),//1 Nephi 5:129
					new VerseInfo(17, 39),//1 Nephi 5:130
					new VerseInfo(17, 40),//1 Nephi 5:131
					new VerseInfo(17, 40),//1 Nephi 5:132
					new VerseInfo(17, 40, 17, 41),//1 Nephi 5:133
					new VerseInfo(17, 41),//1 Nephi 5:134
					new VerseInfo(17, 41),//1 Nephi 5:135
					new VerseInfo(17, 42),//1 Nephi 5:136
					new VerseInfo(17, 42),//1 Nephi 5:137
					new VerseInfo(17, 43),//1 Nephi 5:138
					new VerseInfo(17, 43),//1 Nephi 5:139
					new VerseInfo(17, 43),//1 Nephi 5:140
					new VerseInfo(17, 44),//1 Nephi 5:141
					new VerseInfo(17, 44),//1 Nephi 5:142
					new VerseInfo(17, 44),//1 Nephi 5:143
					new VerseInfo(17, 45),//1 Nephi 5:144
					new VerseInfo(17, 45),//1 Nephi 5:145
					new VerseInfo(17, 45),//1 Nephi 5:146
					new VerseInfo(17, 45),//1 Nephi 5:147
					new VerseInfo(17, 46),//1 Nephi 5:148
					new VerseInfo(17, 46),//1 Nephi 5:149
					new VerseInfo(17, 46),//1 Nephi 5:150
					new VerseInfo(17, 47),//1 Nephi 5:151
					new VerseInfo(17, 47),//1 Nephi 5:152
					new VerseInfo(17, 48),//1 Nephi 5:153
					new VerseInfo(17, 48),//1 Nephi 5:154
					new VerseInfo(17, 48),//1 Nephi 5:155
					new VerseInfo(17, 49),//1 Nephi 5:156
					new VerseInfo(17, 50),//1 Nephi 5:157
					new VerseInfo(17, 50),//1 Nephi 5:158
					new VerseInfo(17, 51),//1 Nephi 5:159
					new VerseInfo(17, 52),//1 Nephi 5:160
					new VerseInfo(17, 52),//1 Nephi 5:161
					new VerseInfo(17, 52),//1 Nephi 5:162
					new VerseInfo(17, 53),//1 Nephi 5:163
					new VerseInfo(17, 54),//1 Nephi 5:164
					new VerseInfo(17, 55),//1 Nephi 5:165
					new VerseInfo(17, 55),//1 Nephi 5:166
					new VerseInfo(17, 55),//1 Nephi 5:167
					new VerseInfo(18, 1),//1 Nephi 5:168
					new VerseInfo(18, 1),//1 Nephi 5:169
					new VerseInfo(18, 2),//1 Nephi 5:170
					new VerseInfo(18, 2),//1 Nephi 5:171
					new VerseInfo(18, 3),//1 Nephi 5:172
					new VerseInfo(18, 4),//1 Nephi 5:173
					new VerseInfo(18, 4),//1 Nephi 5:174
					new VerseInfo(18, 5),//1 Nephi 5:175
					new VerseInfo(18, 6),//1 Nephi 5:176
					new VerseInfo(18, 6),//1 Nephi 5:177
					new VerseInfo(18, 6),//1 Nephi 5:178
					new VerseInfo(18, 7),//1 Nephi 5:179
					new VerseInfo(18, 8),//1 Nephi 5:180
					new VerseInfo(18, 8),//1 Nephi 5:181
					new VerseInfo(18, 9),//1 Nephi 5:182
					new VerseInfo(18, 9),//1 Nephi 5:183
					new VerseInfo(18, 9),//1 Nephi 5:184
					new VerseInfo(18, 10),//1 Nephi 5:185
					new VerseInfo(18, 10),//1 Nephi 5:186
					new VerseInfo(18, 10),//1 Nephi 5:187
					new VerseInfo(18, 11),//1 Nephi 5:188
					new VerseInfo(18, 11),//1 Nephi 5:189
					new VerseInfo(18, 12),//1 Nephi 5:190
					new VerseInfo(18, 13),//1 Nephi 5:191
					new VerseInfo(18, 13),//1 Nephi 5:192
					new VerseInfo(18, 13),//1 Nephi 5:193
					new VerseInfo(18, 13),//1 Nephi 5:194
					new VerseInfo(18, 14),//1 Nephi 5:195
					new VerseInfo(18, 15),//1 Nephi 5:196
					new VerseInfo(18, 15),//1 Nephi 5:197
					new VerseInfo(18, 15),//1 Nephi 5:198
					new VerseInfo(18, 16),//1 Nephi 5:199
					new VerseInfo(18, 17),//1 Nephi 5:200
					new VerseInfo(18, 17),//1 Nephi 5:201
					new VerseInfo(18, 18),//1 Nephi 5:202
					new VerseInfo(18, 18),//1 Nephi 5:203
					new VerseInfo(18, 18),//1 Nephi 5:204
					new VerseInfo(18, 19),//1 Nephi 5:205
					new VerseInfo(18, 19),//1 Nephi 5:206
					new VerseInfo(18, 20),//1 Nephi 5:207
					new VerseInfo(18, 20),//1 Nephi 5:208
					new VerseInfo(18, 21),//1 Nephi 5:209
					new VerseInfo(18, 21),//1 Nephi 5:210
					new VerseInfo(18, 22),//1 Nephi 5:211
					new VerseInfo(18, 23),//1 Nephi 5:212
					new VerseInfo(18, 23),//1 Nephi 5:213
					new VerseInfo(18, 24),//1 Nephi 5:214
					new VerseInfo(18, 24),//1 Nephi 5:215
					new VerseInfo(18, 25),//1 Nephi 5:216
					new VerseInfo(18, 25),//1 Nephi 5:217
					new VerseInfo(19, 1),//1 Nephi 5:218
					new VerseInfo(19, 1),//1 Nephi 5:219
					new VerseInfo(19, 2),//1 Nephi 5:220
					new VerseInfo(19, 2),//1 Nephi 5:221
					new VerseInfo(19, 2),//1 Nephi 5:222
					new VerseInfo(19, 3),//1 Nephi 5:223
					new VerseInfo(19, 3),//1 Nephi 5:224
					new VerseInfo(19, 4),//1 Nephi 5:225
					new VerseInfo(19, 4),//1 Nephi 5:226
					new VerseInfo(19, 5),//1 Nephi 5:227
					new VerseInfo(19, 5),//1 Nephi 5:228
					new VerseInfo(19, 6),//1 Nephi 5:229
					new VerseInfo(19, 6),//1 Nephi 5:230
					new VerseInfo(19, 6),//1 Nephi 5:231
					new VerseInfo(19, 7),//1 Nephi 5:232
					new VerseInfo(19, 7),//1 Nephi 5:233
					new VerseInfo(19, 7),//1 Nephi 5:234
					new VerseInfo(19, 7),//1 Nephi 5:235
					new VerseInfo(19, 8),//1 Nephi 5:236
					new VerseInfo(19, 9),//1 Nephi 5:237
					new VerseInfo(19, 9),//1 Nephi 5:238
					new VerseInfo(19, 10),//1 Nephi 5:239
					new VerseInfo(19, 10),//1 Nephi 5:240
					new VerseInfo(19, 10),//1 Nephi 5:241
					new VerseInfo(19, 10),//1 Nephi 5:242
					new VerseInfo(19, 10),//1 Nephi 5:243
					new VerseInfo(19, 10),//1 Nephi 5:244
					new VerseInfo(19, 11),//1 Nephi 5:245
					new VerseInfo(19, 11),//1 Nephi 5:246
					new VerseInfo(19, 11),//1 Nephi 5:247
					new VerseInfo(19, 12),//1 Nephi 5:248
					new VerseInfo(19, 12),//1 Nephi 5:249
					new VerseInfo(19, 12),//1 Nephi 5:250
					new VerseInfo(19, 13),//1 Nephi 5:251
					new VerseInfo(19, 14),//1 Nephi 5:252
					new VerseInfo(19, 15),//1 Nephi 5:253
					new VerseInfo(19, 16),//1 Nephi 5:254
					new VerseInfo(19, 16),//1 Nephi 5:255
					new VerseInfo(19, 17),//1 Nephi 5:256
					new VerseInfo(19, 17),//1 Nephi 5:257
					new VerseInfo(19, 18),//1 Nephi 5:258
					new VerseInfo(19, 19),//1 Nephi 5:259
					new VerseInfo(19, 20),//1 Nephi 5:260
					new VerseInfo(19, 20),//1 Nephi 5:261
					new VerseInfo(19, 21),//1 Nephi 5:262
					new VerseInfo(19, 21),//1 Nephi 5:263
					new VerseInfo(19, 21),//1 Nephi 5:264
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//1 Nephi 6
					new VerseInfo(19, 22),//1 Nephi 6:1
					new VerseInfo(19, 22),//1 Nephi 6:2
					new VerseInfo(19, 23),//1 Nephi 6:3
					new VerseInfo(19, 23),//1 Nephi 6:4
					new VerseInfo(19, 23),//1 Nephi 6:5
					new VerseInfo(19, 24),//1 Nephi 6:6
					new VerseInfo(19, 24),//1 Nephi 6:7
					new VerseInfo(20, 1),//1 Nephi 6:8
					new VerseInfo(20, 2),//1 Nephi 6:9
					new VerseInfo(20, 3),//1 Nephi 6:10
					new VerseInfo(20, 4),//1 Nephi 6:11
					new VerseInfo(20, 5),//1 Nephi 6:12
					new VerseInfo(20, 6),//1 Nephi 6:13
					new VerseInfo(20, 7),//1 Nephi 6:14
					new VerseInfo(20, 8),//1 Nephi 6:15
					new VerseInfo(20, 9),//1 Nephi 6:16
					new VerseInfo(20, 10),//1 Nephi 6:17
					new VerseInfo(20, 11),//1 Nephi 6:18
					new VerseInfo(20, 12),//1 Nephi 6:19
					new VerseInfo(20, 13),//1 Nephi 6:20
					new VerseInfo(20, 14),//1 Nephi 6:21
					new VerseInfo(20, 15),//1 Nephi 6:22
					new VerseInfo(20, 16),//1 Nephi 6:23
					new VerseInfo(20, 17),//1 Nephi 6:24
					new VerseInfo(20, 18),//1 Nephi 6:25
					new VerseInfo(20, 19),//1 Nephi 6:26
					new VerseInfo(20, 20),//1 Nephi 6:27
					new VerseInfo(20, 21),//1 Nephi 6:28
					new VerseInfo(20, 22),//1 Nephi 6:29
					new VerseInfo(21, 1),//1 Nephi 6:30
					new VerseInfo(21, 1),//1 Nephi 6:31
					new VerseInfo(21, 2),//1 Nephi 6:32
					new VerseInfo(21, 3),//1 Nephi 6:33
					new VerseInfo(21, 4),//1 Nephi 6:34
					new VerseInfo(21, 5),//1 Nephi 6:35
					new VerseInfo(21, 6),//1 Nephi 6:36
					new VerseInfo(21, 7),//1 Nephi 6:37
					new VerseInfo(21, 8),//1 Nephi 6:38
					new VerseInfo(21, 9),//1 Nephi 6:39
					new VerseInfo(21, 10),//1 Nephi 6:40
					new VerseInfo(21, 11),//1 Nephi 6:41
					new VerseInfo(21, 12),//1 Nephi 6:42
					new VerseInfo(21, 13),//1 Nephi 6:43
					new VerseInfo(21, 14),//1 Nephi 6:44
					new VerseInfo(21, 15),//1 Nephi 6:45
					new VerseInfo(21, 16),//1 Nephi 6:46
					new VerseInfo(21, 17),//1 Nephi 6:47
					new VerseInfo(21, 18),//1 Nephi 6:48
					new VerseInfo(21, 19),//1 Nephi 6:49
					new VerseInfo(21, 20),//1 Nephi 6:50
					new VerseInfo(21, 21),//1 Nephi 6:51
					new VerseInfo(21, 22),//1 Nephi 6:52
					new VerseInfo(21, 23),//1 Nephi 6:53
					new VerseInfo(21, 24),//1 Nephi 6:54
					new VerseInfo(21, 25),//1 Nephi 6:55
					new VerseInfo(21, 26),//1 Nephi 6:56
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//1 Nephi 7
					new VerseInfo(22, 1),//1 Nephi 7:1
					new VerseInfo(22, 1),//1 Nephi 7:2
					new VerseInfo(22, 2),//1 Nephi 7:3
					new VerseInfo(22, 2),//1 Nephi 7:4
					new VerseInfo(22, 3),//1 Nephi 7:5
					new VerseInfo(22, 3),//1 Nephi 7:6
					new VerseInfo(22, 4),//1 Nephi 7:7
					new VerseInfo(22, 4),//1 Nephi 7:8
					new VerseInfo(22, 4),//1 Nephi 7:9
					new VerseInfo(22, 4),//1 Nephi 7:10
					new VerseInfo(22, 5),//1 Nephi 7:11
					new VerseInfo(22, 5),//1 Nephi 7:12
					new VerseInfo(22, 6),//1 Nephi 7:13
					new VerseInfo(22, 6),//1 Nephi 7:14
					new VerseInfo(22, 7),//1 Nephi 7:15
					new VerseInfo(22, 7),//1 Nephi 7:16
					new VerseInfo(22, 8),//1 Nephi 7:17
					new VerseInfo(22, 8),//1 Nephi 7:18
					new VerseInfo(22, 9),//1 Nephi 7:19
					new VerseInfo(22, 9),//1 Nephi 7:20
					new VerseInfo(22, 10),//1 Nephi 7:21
					new VerseInfo(22, 11),//1 Nephi 7:22
					new VerseInfo(22, 12),//1 Nephi 7:23
					new VerseInfo(22, 12),//1 Nephi 7:24
					new VerseInfo(22, 12),//1 Nephi 7:25
					new VerseInfo(22, 13),//1 Nephi 7:26
					new VerseInfo(22, 13),//1 Nephi 7:27
					new VerseInfo(22, 14),//1 Nephi 7:28
					new VerseInfo(22, 14),//1 Nephi 7:29
					new VerseInfo(22, 14),//1 Nephi 7:30
					new VerseInfo(22, 14),//1 Nephi 7:31
					new VerseInfo(22, 15),//1 Nephi 7:32
					new VerseInfo(22, 15),//1 Nephi 7:33
					new VerseInfo(22, 16),//1 Nephi 7:34
					new VerseInfo(22, 16),//1 Nephi 7:35
					new VerseInfo(22, 17),//1 Nephi 7:36
					new VerseInfo(22, 17),//1 Nephi 7:37
					new VerseInfo(22, 18),//1 Nephi 7:38
					new VerseInfo(22, 18),//1 Nephi 7:39
					new VerseInfo(22, 18),//1 Nephi 7:40
					new VerseInfo(22, 19),//1 Nephi 7:41
					new VerseInfo(22, 19),//1 Nephi 7:42
					new VerseInfo(22, 20),//1 Nephi 7:43
					new VerseInfo(22, 20),//1 Nephi 7:44
					new VerseInfo(22, 20),//1 Nephi 7:45
					new VerseInfo(22, 21),//1 Nephi 7:46
					new VerseInfo(22, 21),//1 Nephi 7:47
					new VerseInfo(22, 22),//1 Nephi 7:48
					new VerseInfo(22, 22),//1 Nephi 7:49
					new VerseInfo(22, 23),//1 Nephi 7:50
					new VerseInfo(22, 23),//1 Nephi 7:51
					new VerseInfo(22, 23),//1 Nephi 7:52
					new VerseInfo(22, 23),//1 Nephi 7:53
					new VerseInfo(22, 23),//1 Nephi 7:54
					new VerseInfo(22, 24),//1 Nephi 7:55
					new VerseInfo(22, 25),//1 Nephi 7:56
					new VerseInfo(22, 25),//1 Nephi 7:57
					new VerseInfo(22, 25),//1 Nephi 7:58
					new VerseInfo(22, 25),//1 Nephi 7:59
					new VerseInfo(22, 26),//1 Nephi 7:60
					new VerseInfo(22, 26),//1 Nephi 7:61
					new VerseInfo(22, 26),//1 Nephi 7:62
					new VerseInfo(22, 27),//1 Nephi 7:63
					new VerseInfo(22, 28),//1 Nephi 7:64
					new VerseInfo(22, 29),//1 Nephi 7:65
					new VerseInfo(22, 30),//1 Nephi 7:66
					new VerseInfo(22, 30),//1 Nephi 7:67
					new VerseInfo(22, 31),//1 Nephi 7:68
					new VerseInfo(22, 31),//1 Nephi 7:69
					new VerseInfo(22, 31),//1 Nephi 7:70
				},
			}
		},
		{ "2 Nephi", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 1
					new VerseInfo(1, 1),//2 Nephi 1:1
					new VerseInfo(1, 2),//2 Nephi 1:2
					new VerseInfo(1, 3),//2 Nephi 1:3
					new VerseInfo(1, 4),//2 Nephi 1:4
					new VerseInfo(1, 4),//2 Nephi 1:5
					new VerseInfo(1, 5),//2 Nephi 1:6
					new VerseInfo(1, 5),//2 Nephi 1:7
					new VerseInfo(1, 5),//2 Nephi 1:8
					new VerseInfo(1, 5),//2 Nephi 1:9
					new VerseInfo(1, 6),//2 Nephi 1:10
					new VerseInfo(1, 7),//2 Nephi 1:11
					new VerseInfo(1, 7),//2 Nephi 1:12
					new VerseInfo(1, 7),//2 Nephi 1:13
					new VerseInfo(1, 7),//2 Nephi 1:14
					new VerseInfo(1, 7),//2 Nephi 1:15
					new VerseInfo(1, 8),//2 Nephi 1:16
					new VerseInfo(1, 8),//2 Nephi 1:17
					new VerseInfo(1, 9),//2 Nephi 1:18
					new VerseInfo(1, 9),//2 Nephi 1:19
					new VerseInfo(1, 9),//2 Nephi 1:20
					new VerseInfo(1, 9),//2 Nephi 1:21
					new VerseInfo(1, 10),//2 Nephi 1:22
					new VerseInfo(1, 10),//2 Nephi 1:23
					new VerseInfo(1, 11),//2 Nephi 1:24
					new VerseInfo(1, 12),//2 Nephi 1:25
					new VerseInfo(1, 12),//2 Nephi 1:26
					new VerseInfo(1, 13),//2 Nephi 1:27
					new VerseInfo(1, 14),//2 Nephi 1:28
					new VerseInfo(1, 15),//2 Nephi 1:29
					new VerseInfo(1, 16),//2 Nephi 1:30
					new VerseInfo(1, 17),//2 Nephi 1:31
					new VerseInfo(1, 18),//2 Nephi 1:32
					new VerseInfo(1, 19),//2 Nephi 1:33
					new VerseInfo(1, 19, 1, 20),//2 Nephi 1:34
					new VerseInfo(1, 21),//2 Nephi 1:35
					new VerseInfo(1, 21, 1, 22),//2 Nephi 1:36
					new VerseInfo(1, 22),//2 Nephi 1:37
					new VerseInfo(1, 23),//2 Nephi 1:38
					new VerseInfo(1, 23),//2 Nephi 1:39
					new VerseInfo(1, 24),//2 Nephi 1:40
					new VerseInfo(1, 24),//2 Nephi 1:41
					new VerseInfo(1, 24),//2 Nephi 1:42
					new VerseInfo(1, 25),//2 Nephi 1:43
					new VerseInfo(1, 25),//2 Nephi 1:44
					new VerseInfo(1, 25),//2 Nephi 1:45
					new VerseInfo(1, 26),//2 Nephi 1:46
					new VerseInfo(1, 26),//2 Nephi 1:47
					new VerseInfo(1, 26),//2 Nephi 1:48
					new VerseInfo(1, 26),//2 Nephi 1:49
					new VerseInfo(1, 27),//2 Nephi 1:50
					new VerseInfo(1, 27),//2 Nephi 1:51
					new VerseInfo(1, 28),//2 Nephi 1:52
					new VerseInfo(1, 28),//2 Nephi 1:53
					new VerseInfo(1, 29),//2 Nephi 1:54
					new VerseInfo(1, 30),//2 Nephi 1:55
					new VerseInfo(1, 31),//2 Nephi 1:56
					new VerseInfo(1, 31),//2 Nephi 1:57
					new VerseInfo(1, 32),//2 Nephi 1:58
					new VerseInfo(2, 1),//2 Nephi 1:59
					new VerseInfo(2, 1),//2 Nephi 1:60
					new VerseInfo(2, 2),//2 Nephi 1:61
					new VerseInfo(2, 3),//2 Nephi 1:62
					new VerseInfo(2, 3),//2 Nephi 1:63
					new VerseInfo(2, 4),//2 Nephi 1:64
					new VerseInfo(2, 4),//2 Nephi 1:65
					new VerseInfo(2, 4),//2 Nephi 1:66
					new VerseInfo(2, 5),//2 Nephi 1:67
					new VerseInfo(2, 5),//2 Nephi 1:68
					new VerseInfo(2, 5),//2 Nephi 1:69
					new VerseInfo(2, 5),//2 Nephi 1:70
					new VerseInfo(2, 6),//2 Nephi 1:71
					new VerseInfo(2, 7),//2 Nephi 1:72
					new VerseInfo(2, 8),//2 Nephi 1:73
					new VerseInfo(2, 8),//2 Nephi 1:74
					new VerseInfo(2, 8),//2 Nephi 1:75
					new VerseInfo(2, 9),//2 Nephi 1:76
					new VerseInfo(2, 9),//2 Nephi 1:77
					new VerseInfo(2, 10),//2 Nephi 1:78
					new VerseInfo(2, 10),//2 Nephi 1:79
					new VerseInfo(2, 10),//2 Nephi 1:80
					new VerseInfo(2, 11),//2 Nephi 1:81
					new VerseInfo(2, 11),//2 Nephi 1:82
					new VerseInfo(2, 11),//2 Nephi 1:83
					new VerseInfo(2, 11),//2 Nephi 1:84
					new VerseInfo(2, 12),//2 Nephi 1:85
					new VerseInfo(2, 12),//2 Nephi 1:86
					new VerseInfo(2, 12),//2 Nephi 1:87
					new VerseInfo(2, 13),//2 Nephi 1:88
					new VerseInfo(2, 13),//2 Nephi 1:89
					new VerseInfo(2, 13),//2 Nephi 1:90
					new VerseInfo(2, 13),//2 Nephi 1:91
					new VerseInfo(2, 13),//2 Nephi 1:92
					new VerseInfo(2, 13),//2 Nephi 1:93
					new VerseInfo(2, 14),//2 Nephi 1:94
					new VerseInfo(2, 14),//2 Nephi 1:95
					new VerseInfo(2, 14),//2 Nephi 1:96
					new VerseInfo(2, 15),//2 Nephi 1:97
					new VerseInfo(2, 15),//2 Nephi 1:98
					new VerseInfo(2, 16),//2 Nephi 1:99
					new VerseInfo(2, 16),//2 Nephi 1:100
					new VerseInfo(2, 17),//2 Nephi 1:101
					new VerseInfo(2, 17),//2 Nephi 1:102
					new VerseInfo(2, 18),//2 Nephi 1:103
					new VerseInfo(2, 18),//2 Nephi 1:104
					new VerseInfo(2, 19),//2 Nephi 1:105
					new VerseInfo(2, 20),//2 Nephi 1:106
					new VerseInfo(2, 21),//2 Nephi 1:107
					new VerseInfo(2, 21),//2 Nephi 1:108
					new VerseInfo(2, 21),//2 Nephi 1:109
					new VerseInfo(2, 21),//2 Nephi 1:110
					new VerseInfo(2, 22),//2 Nephi 1:111
					new VerseInfo(2, 22),//2 Nephi 1:112
					new VerseInfo(2, 23),//2 Nephi 1:113
					new VerseInfo(2, 24),//2 Nephi 1:114
					new VerseInfo(2, 25),//2 Nephi 1:115
					new VerseInfo(2, 26),//2 Nephi 1:116
					new VerseInfo(2, 26),//2 Nephi 1:117
					new VerseInfo(2, 26),//2 Nephi 1:118
					new VerseInfo(2, 27),//2 Nephi 1:119
					new VerseInfo(2, 27),//2 Nephi 1:120
					new VerseInfo(2, 27),//2 Nephi 1:121
					new VerseInfo(2, 28),//2 Nephi 1:122
					new VerseInfo(2, 28),//2 Nephi 1:123
					new VerseInfo(2, 29),//2 Nephi 1:124
					new VerseInfo(2, 29),//2 Nephi 1:125
					new VerseInfo(2, 30),//2 Nephi 1:126
					new VerseInfo(2, 30),//2 Nephi 1:127
					new VerseInfo(2, 30),//2 Nephi 1:128
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 2
					new VerseInfo(3, 1),//2 Nephi 2:1
					new VerseInfo(3, 1),//2 Nephi 2:2
					new VerseInfo(3, 2),//2 Nephi 2:3
					new VerseInfo(3, 3),//2 Nephi 2:4
					new VerseInfo(3, 4),//2 Nephi 2:5
					new VerseInfo(3, 4, 3, 5),//2 Nephi 2:6
					new VerseInfo(3, 5),//2 Nephi 2:7
					new VerseInfo(3, 5),//2 Nephi 2:8
					new VerseInfo(3, 5),//2 Nephi 2:9
					new VerseInfo(3, 6),//2 Nephi 2:10
					new VerseInfo(3, 7),//2 Nephi 2:11
					new VerseInfo(3, 7),//2 Nephi 2:12
					new VerseInfo(3, 8),//2 Nephi 2:13
					new VerseInfo(3, 8),//2 Nephi 2:14
					new VerseInfo(3, 9),//2 Nephi 2:15
					new VerseInfo(3, 10),//2 Nephi 2:16
					new VerseInfo(3, 11),//2 Nephi 2:17
					new VerseInfo(3, 11),//2 Nephi 2:18
					new VerseInfo(3, 12),//2 Nephi 2:19
					new VerseInfo(3, 12),//2 Nephi 2:20
					new VerseInfo(3, 12),//2 Nephi 2:21
					new VerseInfo(3, 12),//2 Nephi 2:22
					new VerseInfo(3, 12),//2 Nephi 2:23
					new VerseInfo(3, 13),//2 Nephi 2:24
					new VerseInfo(3, 14),//2 Nephi 2:25
					new VerseInfo(3, 14),//2 Nephi 2:26
					new VerseInfo(3, 14),//2 Nephi 2:27
					new VerseInfo(3, 14),//2 Nephi 2:28
					new VerseInfo(3, 15),//2 Nephi 2:29
					new VerseInfo(3, 15),//2 Nephi 2:30
					new VerseInfo(3, 16),//2 Nephi 2:31
					new VerseInfo(3, 17),//2 Nephi 2:32
					new VerseInfo(3, 17),//2 Nephi 2:33
					new VerseInfo(3, 17),//2 Nephi 2:34
					new VerseInfo(3, 17),//2 Nephi 2:35
					new VerseInfo(3, 18),//2 Nephi 2:36
					new VerseInfo(3, 18),//2 Nephi 2:37
					new VerseInfo(3, 19),//2 Nephi 2:38
					new VerseInfo(3, 19),//2 Nephi 2:39
					new VerseInfo(3, 20),//2 Nephi 2:40
					new VerseInfo(3, 20),//2 Nephi 2:41
					new VerseInfo(3, 21),//2 Nephi 2:42
					new VerseInfo(3, 21),//2 Nephi 2:43
					new VerseInfo(3, 22),//2 Nephi 2:44
					new VerseInfo(3, 23),//2 Nephi 2:45
					new VerseInfo(3, 24),//2 Nephi 2:46
					new VerseInfo(3, 24),//2 Nephi 2:47
					new VerseInfo(3, 25),//2 Nephi 2:48
					new VerseInfo(3, 25),//2 Nephi 2:49
					new VerseInfo(3, 25),//2 Nephi 2:50
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 3
					new VerseInfo(4, 1),//2 Nephi 3:1
					new VerseInfo(4, 2),//2 Nephi 3:2
					new VerseInfo(4, 2),//2 Nephi 3:3
					new VerseInfo(4, 2),//2 Nephi 3:4
					new VerseInfo(4, 2),//2 Nephi 3:5
					new VerseInfo(4, 3),//2 Nephi 3:6
					new VerseInfo(4, 3),//2 Nephi 3:7
					new VerseInfo(4, 4),//2 Nephi 3:8
					new VerseInfo(4, 4),//2 Nephi 3:9
					new VerseInfo(4, 5),//2 Nephi 3:10
					new VerseInfo(4, 5),//2 Nephi 3:11
					new VerseInfo(4, 6),//2 Nephi 3:12
					new VerseInfo(4, 7),//2 Nephi 3:13
					new VerseInfo(4, 8),//2 Nephi 3:14
					new VerseInfo(4, 9),//2 Nephi 3:15
					new VerseInfo(4, 9),//2 Nephi 3:16
					new VerseInfo(4, 10),//2 Nephi 3:17
					new VerseInfo(4, 11),//2 Nephi 3:18
					new VerseInfo(4, 11),//2 Nephi 3:19
					new VerseInfo(4, 11),//2 Nephi 3:20
					new VerseInfo(4, 11),//2 Nephi 3:21
					new VerseInfo(4, 12),//2 Nephi 3:22
					new VerseInfo(4, 12),//2 Nephi 3:23
					new VerseInfo(4, 13),//2 Nephi 3:24
					new VerseInfo(4, 14),//2 Nephi 3:25
					new VerseInfo(4, 14),//2 Nephi 3:26
					new VerseInfo(4, 14),//2 Nephi 3:27
					new VerseInfo(4, 15),//2 Nephi 3:28
					new VerseInfo(4, 15),//2 Nephi 3:29
					new VerseInfo(4, 16),//2 Nephi 3:30
					new VerseInfo(4, 17),//2 Nephi 3:31
					new VerseInfo(4, 17),//2 Nephi 3:32
					new VerseInfo(4, 18),//2 Nephi 3:33
					new VerseInfo(4, 19),//2 Nephi 3:34
					new VerseInfo(4, 20),//2 Nephi 3:35
					new VerseInfo(4, 21),//2 Nephi 3:36
					new VerseInfo(4, 22),//2 Nephi 3:37
					new VerseInfo(4, 23),//2 Nephi 3:38
					new VerseInfo(4, 24),//2 Nephi 3:39
					new VerseInfo(4, 25),//2 Nephi 3:40
					new VerseInfo(4, 25),//2 Nephi 3:41
					new VerseInfo(4, 26),//2 Nephi 3:42
					new VerseInfo(4, 27),//2 Nephi 3:43
					new VerseInfo(4, 27),//2 Nephi 3:44
					new VerseInfo(4, 27),//2 Nephi 3:45
					new VerseInfo(4, 28),//2 Nephi 3:46
					new VerseInfo(4, 28),//2 Nephi 3:47
					new VerseInfo(4, 29),//2 Nephi 3:48
					new VerseInfo(4, 29),//2 Nephi 3:49
					new VerseInfo(4, 30),//2 Nephi 3:50
					new VerseInfo(4, 31),//2 Nephi 3:51
					new VerseInfo(4, 31),//2 Nephi 3:52
					new VerseInfo(4, 31),//2 Nephi 3:53
					new VerseInfo(4, 32),//2 Nephi 3:54
					new VerseInfo(4, 32),//2 Nephi 3:55
					new VerseInfo(4, 33),//2 Nephi 3:56
					new VerseInfo(4, 33),//2 Nephi 3:57
					new VerseInfo(4, 33),//2 Nephi 3:58
					new VerseInfo(4, 33),//2 Nephi 3:59
					new VerseInfo(4, 33),//2 Nephi 3:60
					new VerseInfo(4, 34),//2 Nephi 3:61
					new VerseInfo(4, 34),//2 Nephi 3:62
					new VerseInfo(4, 34),//2 Nephi 3:63
					new VerseInfo(4, 35),//2 Nephi 3:64
					new VerseInfo(4, 35),//2 Nephi 3:65
					new VerseInfo(4, 35),//2 Nephi 3:66
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 4
					new VerseInfo(5, 1),//2 Nephi 4:1
					new VerseInfo(5, 2),//2 Nephi 4:2
					new VerseInfo(5, 3),//2 Nephi 4:3
					new VerseInfo(5, 3),//2 Nephi 4:4
					new VerseInfo(5, 4),//2 Nephi 4:5
					new VerseInfo(5, 4),//2 Nephi 4:6
					new VerseInfo(5, 5),//2 Nephi 4:7
					new VerseInfo(5, 6),//2 Nephi 4:8
					new VerseInfo(5, 6),//2 Nephi 4:9
					new VerseInfo(5, 7),//2 Nephi 4:10
					new VerseInfo(5, 7),//2 Nephi 4:11
					new VerseInfo(5, 8),//2 Nephi 4:12
					new VerseInfo(5, 9),//2 Nephi 4:13
					new VerseInfo(5, 10),//2 Nephi 4:14
					new VerseInfo(5, 11),//2 Nephi 4:15
					new VerseInfo(5, 11),//2 Nephi 4:16
					new VerseInfo(5, 12),//2 Nephi 4:17
					new VerseInfo(5, 13),//2 Nephi 4:18
					new VerseInfo(5, 14),//2 Nephi 4:19
					new VerseInfo(5, 14),//2 Nephi 4:20
					new VerseInfo(5, 15),//2 Nephi 4:21
					new VerseInfo(5, 16),//2 Nephi 4:22
					new VerseInfo(5, 16),//2 Nephi 4:23
					new VerseInfo(5, 16),//2 Nephi 4:24
					new VerseInfo(5, 16),//2 Nephi 4:25
					new VerseInfo(5, 17),//2 Nephi 4:26
					new VerseInfo(5, 18),//2 Nephi 4:27
					new VerseInfo(5, 18),//2 Nephi 4:28
					new VerseInfo(5, 19),//2 Nephi 4:29
					new VerseInfo(5, 19),//2 Nephi 4:30
					new VerseInfo(5, 20),//2 Nephi 4:31
					new VerseInfo(5, 20),//2 Nephi 4:32
					new VerseInfo(5, 21),//2 Nephi 4:33
					new VerseInfo(5, 21),//2 Nephi 4:34
					new VerseInfo(5, 21),//2 Nephi 4:35
					new VerseInfo(5, 22),//2 Nephi 4:36
					new VerseInfo(5, 23),//2 Nephi 4:37
					new VerseInfo(5, 23),//2 Nephi 4:38
					new VerseInfo(5, 24),//2 Nephi 4:39
					new VerseInfo(5, 25),//2 Nephi 4:40
					new VerseInfo(5, 25),//2 Nephi 4:41
					new VerseInfo(5, 26),//2 Nephi 4:42
					new VerseInfo(5, 27),//2 Nephi 4:43
					new VerseInfo(5, 28),//2 Nephi 4:44
					new VerseInfo(5, 29),//2 Nephi 4:45
					new VerseInfo(5, 30),//2 Nephi 4:46
					new VerseInfo(5, 31),//2 Nephi 4:47
					new VerseInfo(5, 32),//2 Nephi 4:48
					new VerseInfo(5, 32),//2 Nephi 4:49
					new VerseInfo(5, 33),//2 Nephi 4:50
					new VerseInfo(5, 34),//2 Nephi 4:51
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 5
					new VerseInfo(6, 1),//2 Nephi 5:1
					new VerseInfo(6, 2),//2 Nephi 5:2
					new VerseInfo(6, 2),//2 Nephi 5:3
					new VerseInfo(6, 2),//2 Nephi 5:4
					new VerseInfo(6, 3),//2 Nephi 5:5
					new VerseInfo(6, 3),//2 Nephi 5:6
					new VerseInfo(6, 3),//2 Nephi 5:7
					new VerseInfo(6, 3),//2 Nephi 5:8
					new VerseInfo(6, 4),//2 Nephi 5:9
					new VerseInfo(6, 4),//2 Nephi 5:10
					new VerseInfo(6, 4),//2 Nephi 5:11
					new VerseInfo(6, 4),//2 Nephi 5:12
					new VerseInfo(6, 5),//2 Nephi 5:13
					new VerseInfo(6, 5),//2 Nephi 5:14
					new VerseInfo(6, 5),//2 Nephi 5:15
					new VerseInfo(6, 6),//2 Nephi 5:16
					new VerseInfo(6, 6),//2 Nephi 5:17
					new VerseInfo(6, 6),//2 Nephi 5:18
					new VerseInfo(6, 7),//2 Nephi 5:19
					new VerseInfo(6, 7),//2 Nephi 5:20
					new VerseInfo(6, 7),//2 Nephi 5:21
					new VerseInfo(6, 8),//2 Nephi 5:22
					new VerseInfo(6, 9),//2 Nephi 5:23
					new VerseInfo(6, 9),//2 Nephi 5:24
					new VerseInfo(6, 9),//2 Nephi 5:25
					new VerseInfo(6, 10),//2 Nephi 5:26
					new VerseInfo(6, 10),//2 Nephi 5:27
					new VerseInfo(6, 11),//2 Nephi 5:28
					new VerseInfo(6, 11),//2 Nephi 5:29
					new VerseInfo(6, 12),//2 Nephi 5:30
					new VerseInfo(6, 12),//2 Nephi 5:31
					new VerseInfo(6, 12),//2 Nephi 5:32
					new VerseInfo(6, 13),//2 Nephi 5:33
					new VerseInfo(6, 13),//2 Nephi 5:34
					new VerseInfo(6, 13),//2 Nephi 5:35
					new VerseInfo(6, 14),//2 Nephi 5:36
					new VerseInfo(6, 14),//2 Nephi 5:37
					new VerseInfo(6, 14),//2 Nephi 5:38
					new VerseInfo(6, 15),//2 Nephi 5:39
					new VerseInfo(6, 15),//2 Nephi 5:40
					new VerseInfo(6, 16),//2 Nephi 5:41
					new VerseInfo(6, 17),//2 Nephi 5:42
					new VerseInfo(6, 17, 6, 18),//2 Nephi 5:43
					new VerseInfo(6, 18),//2 Nephi 5:44
					new VerseInfo(6, 18),//2 Nephi 5:45
					new VerseInfo(7, 1),//2 Nephi 5:46
					new VerseInfo(7, 1),//2 Nephi 5:47
					new VerseInfo(7, 1),//2 Nephi 5:48
					new VerseInfo(7, 1),//2 Nephi 5:49
					new VerseInfo(7, 1),//2 Nephi 5:50
					new VerseInfo(7, 2),//2 Nephi 5:51
					new VerseInfo(7, 2),//2 Nephi 5:52
					new VerseInfo(7, 2),//2 Nephi 5:53
					new VerseInfo(7, 3),//2 Nephi 5:54
					new VerseInfo(7, 4),//2 Nephi 5:55
					new VerseInfo(7, 4),//2 Nephi 5:56
					new VerseInfo(7, 4),//2 Nephi 5:57
					new VerseInfo(7, 5),//2 Nephi 5:58
					new VerseInfo(7, 6),//2 Nephi 5:59
					new VerseInfo(7, 6, 7, 7),//2 Nephi 5:60
					new VerseInfo(7, 7, 7, 8),//2 Nephi 5:61
					new VerseInfo(7, 8),//2 Nephi 5:62
					new VerseInfo(7, 8),//2 Nephi 5:63
					new VerseInfo(7, 8),//2 Nephi 5:64
					new VerseInfo(7, 8, 7, 9),//2 Nephi 5:65
					new VerseInfo(7, 9),//2 Nephi 5:66
					new VerseInfo(7, 10),//2 Nephi 5:67
					new VerseInfo(7, 11),//2 Nephi 5:68
					new VerseInfo(7, 11),//2 Nephi 5:69
					new VerseInfo(8, 1),//2 Nephi 5:70
					new VerseInfo(8, 2),//2 Nephi 5:71
					new VerseInfo(8, 3),//2 Nephi 5:72
					new VerseInfo(8, 3),//2 Nephi 5:73
					new VerseInfo(8, 3),//2 Nephi 5:74
					new VerseInfo(8, 4),//2 Nephi 5:75
					new VerseInfo(8, 4),//2 Nephi 5:76
					new VerseInfo(8, 5),//2 Nephi 5:77
					new VerseInfo(8, 5),//2 Nephi 5:78
					new VerseInfo(8, 6),//2 Nephi 5:79
					new VerseInfo(8, 6),//2 Nephi 5:80
					new VerseInfo(8, 6),//2 Nephi 5:81
					new VerseInfo(8, 7),//2 Nephi 5:82
					new VerseInfo(8, 7),//2 Nephi 5:83
					new VerseInfo(8, 8),//2 Nephi 5:84
					new VerseInfo(8, 8),//2 Nephi 5:85
					new VerseInfo(8, 9),//2 Nephi 5:86
					new VerseInfo(8, 9),//2 Nephi 5:87
					new VerseInfo(8, 10),//2 Nephi 5:88
					new VerseInfo(8, 10),//2 Nephi 5:89
					new VerseInfo(8, 11),//2 Nephi 5:90
					new VerseInfo(8, 11),//2 Nephi 5:91
					new VerseInfo(8, 12),//2 Nephi 5:92
					new VerseInfo(8, 12),//2 Nephi 5:93
					new VerseInfo(8, 13),//2 Nephi 5:94
					new VerseInfo(8, 13),//2 Nephi 5:95
					new VerseInfo(8, 13),//2 Nephi 5:96
					new VerseInfo(8, 14),//2 Nephi 5:97
					new VerseInfo(8, 15),//2 Nephi 5:98
					new VerseInfo(8, 16),//2 Nephi 5:99
					new VerseInfo(8, 17),//2 Nephi 5:100
					new VerseInfo(8, 17),//2 Nephi 5:101
					new VerseInfo(8, 18),//2 Nephi 5:102
					new VerseInfo(8, 18),//2 Nephi 5:103
					new VerseInfo(8, 19),//2 Nephi 5:104
					new VerseInfo(8, 19),//2 Nephi 5:105
					new VerseInfo(8, 20),//2 Nephi 5:106
					new VerseInfo(8, 21),//2 Nephi 5:107
					new VerseInfo(8, 22),//2 Nephi 5:108
					new VerseInfo(8, 22),//2 Nephi 5:109
					new VerseInfo(8, 23),//2 Nephi 5:110
					new VerseInfo(8, 23),//2 Nephi 5:111
					new VerseInfo(8, 24),//2 Nephi 5:112
					new VerseInfo(8, 24),//2 Nephi 5:113
					new VerseInfo(8, 25),//2 Nephi 5:114
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 6
					new VerseInfo(9, 1),//2 Nephi 6:1
					new VerseInfo(9, 2),//2 Nephi 6:2
					new VerseInfo(9, 2),//2 Nephi 6:3
					new VerseInfo(9, 3),//2 Nephi 6:4
					new VerseInfo(9, 4),//2 Nephi 6:5
					new VerseInfo(9, 4),//2 Nephi 6:6
					new VerseInfo(9, 4),//2 Nephi 6:7
					new VerseInfo(9, 5),//2 Nephi 6:8
					new VerseInfo(9, 5),//2 Nephi 6:9
					new VerseInfo(9, 5),//2 Nephi 6:10
					new VerseInfo(9, 6),//2 Nephi 6:11
					new VerseInfo(9, 6),//2 Nephi 6:12
					new VerseInfo(9, 6),//2 Nephi 6:13
					new VerseInfo(9, 6),//2 Nephi 6:14
					new VerseInfo(9, 7),//2 Nephi 6:15
					new VerseInfo(9, 7),//2 Nephi 6:16
					new VerseInfo(9, 7),//2 Nephi 6:17
					new VerseInfo(9, 7),//2 Nephi 6:18
					new VerseInfo(9, 8),//2 Nephi 6:19
					new VerseInfo(9, 8),//2 Nephi 6:20
					new VerseInfo(9, 9),//2 Nephi 6:21
					new VerseInfo(9, 9),//2 Nephi 6:22
					new VerseInfo(9, 9),//2 Nephi 6:23
					new VerseInfo(9, 10),//2 Nephi 6:24
					new VerseInfo(9, 10),//2 Nephi 6:25
					new VerseInfo(9, 11),//2 Nephi 6:26
					new VerseInfo(9, 12),//2 Nephi 6:27
					new VerseInfo(9, 12),//2 Nephi 6:28
					new VerseInfo(9, 12),//2 Nephi 6:29
					new VerseInfo(9, 12),//2 Nephi 6:30
					new VerseInfo(9, 13),//2 Nephi 6:31
					new VerseInfo(9, 13),//2 Nephi 6:32
					new VerseInfo(9, 13),//2 Nephi 6:33
					new VerseInfo(9, 14),//2 Nephi 6:34
					new VerseInfo(9, 14),//2 Nephi 6:35
					new VerseInfo(9, 15),//2 Nephi 6:36
					new VerseInfo(9, 15),//2 Nephi 6:37
					new VerseInfo(9, 16),//2 Nephi 6:38
					new VerseInfo(9, 16),//2 Nephi 6:39
					new VerseInfo(9, 16),//2 Nephi 6:40
					new VerseInfo(9, 17),//2 Nephi 6:41
					new VerseInfo(9, 18),//2 Nephi 6:42
					new VerseInfo(9, 19),//2 Nephi 6:43
					new VerseInfo(9, 20),//2 Nephi 6:44
					new VerseInfo(9, 21),//2 Nephi 6:45
					new VerseInfo(9, 21),//2 Nephi 6:46
					new VerseInfo(9, 22),//2 Nephi 6:47
					new VerseInfo(9, 23),//2 Nephi 6:48
					new VerseInfo(9, 24),//2 Nephi 6:49
					new VerseInfo(9, 24),//2 Nephi 6:50
					new VerseInfo(9, 25),//2 Nephi 6:51
					new VerseInfo(9, 25),//2 Nephi 6:52
					new VerseInfo(9, 25),//2 Nephi 6:53
					new VerseInfo(9, 25, 9, 26),//2 Nephi 6:54
					new VerseInfo(9, 26),//2 Nephi 6:55
					new VerseInfo(9, 27),//2 Nephi 6:56
					new VerseInfo(9, 28),//2 Nephi 6:57
					new VerseInfo(9, 28),//2 Nephi 6:58
					new VerseInfo(9, 28),//2 Nephi 6:59
					new VerseInfo(9, 28),//2 Nephi 6:60
					new VerseInfo(9, 29),//2 Nephi 6:61
					new VerseInfo(9, 30),//2 Nephi 6:62
					new VerseInfo(9, 30),//2 Nephi 6:63
					new VerseInfo(9, 30),//2 Nephi 6:64
					new VerseInfo(9, 31),//2 Nephi 6:65
					new VerseInfo(9, 32),//2 Nephi 6:66
					new VerseInfo(9, 33),//2 Nephi 6:67
					new VerseInfo(9, 34),//2 Nephi 6:68
					new VerseInfo(9, 35),//2 Nephi 6:69
					new VerseInfo(9, 36),//2 Nephi 6:70
					new VerseInfo(9, 37),//2 Nephi 6:71
					new VerseInfo(9, 38),//2 Nephi 6:72
					new VerseInfo(9, 39),//2 Nephi 6:73
					new VerseInfo(9, 39),//2 Nephi 6:74
					new VerseInfo(9, 40),//2 Nephi 6:75
					new VerseInfo(9, 40),//2 Nephi 6:76
					new VerseInfo(9, 40),//2 Nephi 6:77
					new VerseInfo(9, 40),//2 Nephi 6:78
					new VerseInfo(9, 41),//2 Nephi 6:79
					new VerseInfo(9, 41),//2 Nephi 6:80
					new VerseInfo(9, 41),//2 Nephi 6:81
					new VerseInfo(9, 41),//2 Nephi 6:82
					new VerseInfo(9, 42),//2 Nephi 6:83
					new VerseInfo(9, 42),//2 Nephi 6:84
					new VerseInfo(9, 43),//2 Nephi 6:85
					new VerseInfo(9, 44),//2 Nephi 6:86
					new VerseInfo(9, 44),//2 Nephi 6:87
					new VerseInfo(9, 44),//2 Nephi 6:88
					new VerseInfo(9, 45),//2 Nephi 6:89
					new VerseInfo(9, 45),//2 Nephi 6:90
					new VerseInfo(9, 46),//2 Nephi 6:91
					new VerseInfo(9, 46),//2 Nephi 6:92
					new VerseInfo(9, 46),//2 Nephi 6:93
					new VerseInfo(9, 47),//2 Nephi 6:94
					new VerseInfo(9, 47),//2 Nephi 6:95
					new VerseInfo(9, 47),//2 Nephi 6:96
					new VerseInfo(9, 48),//2 Nephi 6:97
					new VerseInfo(9, 49),//2 Nephi 6:98
					new VerseInfo(9, 50),//2 Nephi 6:99
					new VerseInfo(9, 51),//2 Nephi 6:100
					new VerseInfo(9, 51),//2 Nephi 6:101
					new VerseInfo(9, 51),//2 Nephi 6:102
					new VerseInfo(9, 52),//2 Nephi 6:103
					new VerseInfo(9, 52, 9, 53),//2 Nephi 6:104
					new VerseInfo(9, 53),//2 Nephi 6:105
					new VerseInfo(9, 54),//2 Nephi 6:106
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 7
					new VerseInfo(10, 1),//2 Nephi 7:1
					new VerseInfo(10, 2),//2 Nephi 7:2
					new VerseInfo(10, 2),//2 Nephi 7:3
					new VerseInfo(10, 2),//2 Nephi 7:4
					new VerseInfo(10, 3),//2 Nephi 7:5
					new VerseInfo(10, 3),//2 Nephi 7:6
					new VerseInfo(10, 3),//2 Nephi 7:7
					new VerseInfo(10, 4),//2 Nephi 7:8
					new VerseInfo(10, 5),//2 Nephi 7:9
					new VerseInfo(10, 6),//2 Nephi 7:10
					new VerseInfo(10, 6),//2 Nephi 7:11
					new VerseInfo(10, 7),//2 Nephi 7:12
					new VerseInfo(10, 8),//2 Nephi 7:13
					new VerseInfo(10, 8),//2 Nephi 7:14
					new VerseInfo(10, 9),//2 Nephi 7:15
					new VerseInfo(10, 9),//2 Nephi 7:16
					new VerseInfo(10, 10),//2 Nephi 7:17
					new VerseInfo(10, 11),//2 Nephi 7:18
					new VerseInfo(10, 12),//2 Nephi 7:19
					new VerseInfo(10, 13, 10, 14),//2 Nephi 7:20
					new VerseInfo(10, 14),//2 Nephi 7:21
					new VerseInfo(10, 15),//2 Nephi 7:22
					new VerseInfo(10, 16),//2 Nephi 7:23
					new VerseInfo(10, 16),//2 Nephi 7:24
					new VerseInfo(10, 16),//2 Nephi 7:25
					new VerseInfo(10, 17),//2 Nephi 7:26
					new VerseInfo(10, 18),//2 Nephi 7:27
					new VerseInfo(10, 18),//2 Nephi 7:28
					new VerseInfo(10, 18),//2 Nephi 7:29
					new VerseInfo(10, 19),//2 Nephi 7:30
					new VerseInfo(10, 19),//2 Nephi 7:31
					new VerseInfo(10, 19),//2 Nephi 7:32
					new VerseInfo(10, 20),//2 Nephi 7:33
					new VerseInfo(10, 20),//2 Nephi 7:34
					new VerseInfo(10, 20),//2 Nephi 7:35
					new VerseInfo(10, 21),//2 Nephi 7:36
					new VerseInfo(10, 21),//2 Nephi 7:37
					new VerseInfo(10, 22),//2 Nephi 7:38
					new VerseInfo(10, 22),//2 Nephi 7:39
					new VerseInfo(10, 23),//2 Nephi 7:40
					new VerseInfo(10, 24),//2 Nephi 7:41
					new VerseInfo(10, 24),//2 Nephi 7:42
					new VerseInfo(10, 25),//2 Nephi 7:43
					new VerseInfo(10, 25),//2 Nephi 7:44
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 8
					new VerseInfo(11, 1),//2 Nephi 8:1
					new VerseInfo(11, 2),//2 Nephi 8:2
					new VerseInfo(11, 2),//2 Nephi 8:3
					new VerseInfo(11, 3),//2 Nephi 8:4
					new VerseInfo(11, 3),//2 Nephi 8:5
					new VerseInfo(11, 3),//2 Nephi 8:6
					new VerseInfo(11, 4),//2 Nephi 8:7
					new VerseInfo(11, 4),//2 Nephi 8:8
					new VerseInfo(11, 4),//2 Nephi 8:9
					new VerseInfo(11, 5),//2 Nephi 8:10
					new VerseInfo(11, 5),//2 Nephi 8:11
					new VerseInfo(11, 6),//2 Nephi 8:12
					new VerseInfo(11, 7),//2 Nephi 8:13
					new VerseInfo(11, 7),//2 Nephi 8:14
					new VerseInfo(11, 8),//2 Nephi 8:15
					new VerseInfo(11, 8),//2 Nephi 8:16
					new VerseInfo(12, 1),//2 Nephi 8:17
					new VerseInfo(12, 2),//2 Nephi 8:18
					new VerseInfo(12, 3),//2 Nephi 8:19
					new VerseInfo(12, 4),//2 Nephi 8:20
					new VerseInfo(12, 5),//2 Nephi 8:21
					new VerseInfo(12, 6),//2 Nephi 8:22
					new VerseInfo(12, 7),//2 Nephi 8:23
					new VerseInfo(12, 8),//2 Nephi 8:24
					new VerseInfo(12, 9),//2 Nephi 8:25
					new VerseInfo(12, 10),//2 Nephi 8:26
					new VerseInfo(12, 11),//2 Nephi 8:27
					new VerseInfo(12, 12),//2 Nephi 8:28
					new VerseInfo(12, 13),//2 Nephi 8:29
					new VerseInfo(12, 14),//2 Nephi 8:30
					new VerseInfo(12, 14, 12, 15),//2 Nephi 8:31
					new VerseInfo(12, 16),//2 Nephi 8:32
					new VerseInfo(12, 17),//2 Nephi 8:33
					new VerseInfo(12, 18),//2 Nephi 8:34
					new VerseInfo(12, 19),//2 Nephi 8:35
					new VerseInfo(12, 20),//2 Nephi 8:36
					new VerseInfo(12, 21),//2 Nephi 8:37
					new VerseInfo(12, 22),//2 Nephi 8:38
					new VerseInfo(13, 1),//2 Nephi 8:39
					new VerseInfo(13, 2),//2 Nephi 8:40
					new VerseInfo(13, 3),//2 Nephi 8:41
					new VerseInfo(13, 4),//2 Nephi 8:42
					new VerseInfo(13, 5),//2 Nephi 8:43
					new VerseInfo(13, 6),//2 Nephi 8:44
					new VerseInfo(13, 7),//2 Nephi 8:45
					new VerseInfo(13, 8),//2 Nephi 8:46
					new VerseInfo(13, 9),//2 Nephi 8:47
					new VerseInfo(13, 10),//2 Nephi 8:48
					new VerseInfo(13, 11),//2 Nephi 8:49
					new VerseInfo(13, 12),//2 Nephi 8:50
					new VerseInfo(13, 13),//2 Nephi 8:51
					new VerseInfo(13, 14),//2 Nephi 8:52
					new VerseInfo(13, 15),//2 Nephi 8:53
					new VerseInfo(13, 16),//2 Nephi 8:54
					new VerseInfo(13, 17),//2 Nephi 8:55
					new VerseInfo(13, 18),//2 Nephi 8:56
					new VerseInfo(13, 19),//2 Nephi 8:57
					new VerseInfo(13, 20),//2 Nephi 8:58
					new VerseInfo(13, 21),//2 Nephi 8:59
					new VerseInfo(13, 22),//2 Nephi 8:60
					new VerseInfo(13, 23),//2 Nephi 8:61
					new VerseInfo(13, 24),//2 Nephi 8:62
					new VerseInfo(13, 25),//2 Nephi 8:63
					new VerseInfo(13, 26),//2 Nephi 8:64
					new VerseInfo(14, 1),//2 Nephi 8:65
					new VerseInfo(14, 2),//2 Nephi 8:66
					new VerseInfo(14, 3),//2 Nephi 8:67
					new VerseInfo(14, 4),//2 Nephi 8:68
					new VerseInfo(14, 5),//2 Nephi 8:69
					new VerseInfo(14, 6),//2 Nephi 8:70
					new VerseInfo(15, 1),//2 Nephi 8:71
					new VerseInfo(15, 2),//2 Nephi 8:72
					new VerseInfo(15, 3),//2 Nephi 8:73
					new VerseInfo(15, 4),//2 Nephi 8:74
					new VerseInfo(15, 5),//2 Nephi 8:75
					new VerseInfo(15, 6),//2 Nephi 8:76
					new VerseInfo(15, 7),//2 Nephi 8:77
					new VerseInfo(15, 8),//2 Nephi 8:78
					new VerseInfo(15, 9),//2 Nephi 8:79
					new VerseInfo(15, 10),//2 Nephi 8:80
					new VerseInfo(15, 11),//2 Nephi 8:81
					new VerseInfo(15, 12),//2 Nephi 8:82
					new VerseInfo(15, 13),//2 Nephi 8:83
					new VerseInfo(15, 14),//2 Nephi 8:84
					new VerseInfo(15, 15),//2 Nephi 8:85
					new VerseInfo(15, 16),//2 Nephi 8:86
					new VerseInfo(15, 17),//2 Nephi 8:87
					new VerseInfo(15, 18),//2 Nephi 8:88
					new VerseInfo(15, 19),//2 Nephi 8:89
					new VerseInfo(15, 20),//2 Nephi 8:90
					new VerseInfo(15, 21),//2 Nephi 8:91
					new VerseInfo(15, 22),//2 Nephi 8:92
					new VerseInfo(15, 23),//2 Nephi 8:93
					new VerseInfo(15, 24),//2 Nephi 8:94
					new VerseInfo(15, 25),//2 Nephi 8:95
					new VerseInfo(15, 26),//2 Nephi 8:96
					new VerseInfo(15, 26, 15, 27),//2 Nephi 8:97
					new VerseInfo(15, 28),//2 Nephi 8:98
					new VerseInfo(15, 29),//2 Nephi 8:99
					new VerseInfo(15, 30),//2 Nephi 8:100
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 9
					new VerseInfo(16, 1),//2 Nephi 9:1
					new VerseInfo(16, 2),//2 Nephi 9:2
					new VerseInfo(16, 3),//2 Nephi 9:3
					new VerseInfo(16, 4),//2 Nephi 9:4
					new VerseInfo(16, 5),//2 Nephi 9:5
					new VerseInfo(16, 6),//2 Nephi 9:6
					new VerseInfo(16, 7),//2 Nephi 9:7
					new VerseInfo(16, 8),//2 Nephi 9:8
					new VerseInfo(16, 9),//2 Nephi 9:9
					new VerseInfo(16, 10),//2 Nephi 9:10
					new VerseInfo(16, 11),//2 Nephi 9:11
					new VerseInfo(16, 12),//2 Nephi 9:12
					new VerseInfo(16, 13),//2 Nephi 9:13
					new VerseInfo(17, 1),//2 Nephi 9:14
					new VerseInfo(17, 2),//2 Nephi 9:15
					new VerseInfo(17, 3),//2 Nephi 9:16
					new VerseInfo(17, 4),//2 Nephi 9:17
					new VerseInfo(17, 5),//2 Nephi 9:18
					new VerseInfo(17, 6),//2 Nephi 9:19
					new VerseInfo(17, 7),//2 Nephi 9:20
					new VerseInfo(17, 8),//2 Nephi 9:21
					new VerseInfo(17, 9),//2 Nephi 9:22
					new VerseInfo(17, 10),//2 Nephi 9:23
					new VerseInfo(17, 11),//2 Nephi 9:24
					new VerseInfo(17, 12),//2 Nephi 9:25
					new VerseInfo(17, 13),//2 Nephi 9:26
					new VerseInfo(17, 14),//2 Nephi 9:27
					new VerseInfo(17, 15),//2 Nephi 9:28
					new VerseInfo(17, 16),//2 Nephi 9:29
					new VerseInfo(17, 17),//2 Nephi 9:30
					new VerseInfo(17, 18),//2 Nephi 9:31
					new VerseInfo(17, 19),//2 Nephi 9:32
					new VerseInfo(17, 20),//2 Nephi 9:33
					new VerseInfo(17, 21),//2 Nephi 9:34
					new VerseInfo(17, 22),//2 Nephi 9:35
					new VerseInfo(17, 23),//2 Nephi 9:36
					new VerseInfo(17, 24),//2 Nephi 9:37
					new VerseInfo(17, 25),//2 Nephi 9:38
					new VerseInfo(18, 1),//2 Nephi 9:39
					new VerseInfo(18, 2),//2 Nephi 9:40
					new VerseInfo(18, 3),//2 Nephi 9:41
					new VerseInfo(18, 4),//2 Nephi 9:42
					new VerseInfo(18, 5),//2 Nephi 9:43
					new VerseInfo(18, 6),//2 Nephi 9:44
					new VerseInfo(18, 7),//2 Nephi 9:45
					new VerseInfo(18, 8),//2 Nephi 9:46
					new VerseInfo(18, 9),//2 Nephi 9:47
					new VerseInfo(18, 10),//2 Nephi 9:48
					new VerseInfo(18, 11),//2 Nephi 9:49
					new VerseInfo(18, 12),//2 Nephi 9:50
					new VerseInfo(18, 13),//2 Nephi 9:51
					new VerseInfo(18, 14),//2 Nephi 9:52
					new VerseInfo(18, 15),//2 Nephi 9:53
					new VerseInfo(18, 16),//2 Nephi 9:54
					new VerseInfo(18, 17),//2 Nephi 9:55
					new VerseInfo(18, 18),//2 Nephi 9:56
					new VerseInfo(18, 19),//2 Nephi 9:57
					new VerseInfo(18, 20),//2 Nephi 9:58
					new VerseInfo(18, 21),//2 Nephi 9:59
					new VerseInfo(18, 22),//2 Nephi 9:60
					new VerseInfo(19, 1),//2 Nephi 9:61
					new VerseInfo(19, 2),//2 Nephi 9:62
					new VerseInfo(19, 3),//2 Nephi 9:63
					new VerseInfo(19, 4),//2 Nephi 9:64
					new VerseInfo(19, 5),//2 Nephi 9:65
					new VerseInfo(19, 6),//2 Nephi 9:66
					new VerseInfo(19, 7),//2 Nephi 9:67
					new VerseInfo(19, 8),//2 Nephi 9:68
					new VerseInfo(19, 9),//2 Nephi 9:69
					new VerseInfo(19, 10),//2 Nephi 9:70
					new VerseInfo(19, 11),//2 Nephi 9:71
					new VerseInfo(19, 12),//2 Nephi 9:72
					new VerseInfo(19, 13),//2 Nephi 9:73
					new VerseInfo(19, 14),//2 Nephi 9:74
					new VerseInfo(19, 15),//2 Nephi 9:75
					new VerseInfo(19, 16),//2 Nephi 9:76
					new VerseInfo(19, 17),//2 Nephi 9:77
					new VerseInfo(19, 18),//2 Nephi 9:78
					new VerseInfo(19, 19),//2 Nephi 9:79
					new VerseInfo(19, 20),//2 Nephi 9:80
					new VerseInfo(19, 21),//2 Nephi 9:81
					new VerseInfo(20, 1),//2 Nephi 9:82
					new VerseInfo(20, 2),//2 Nephi 9:83
					new VerseInfo(20, 3),//2 Nephi 9:84
					new VerseInfo(20, 4),//2 Nephi 9:85
					new VerseInfo(20, 5),//2 Nephi 9:86
					new VerseInfo(20, 6),//2 Nephi 9:87
					new VerseInfo(20, 7),//2 Nephi 9:88
					new VerseInfo(20, 8),//2 Nephi 9:89
					new VerseInfo(20, 9),//2 Nephi 9:90
					new VerseInfo(20, 10),//2 Nephi 9:91
					new VerseInfo(20, 11),//2 Nephi 9:92
					new VerseInfo(20, 12),//2 Nephi 9:93
					new VerseInfo(20, 13),//2 Nephi 9:94
					new VerseInfo(20, 14),//2 Nephi 9:95
					new VerseInfo(20, 15),//2 Nephi 9:96
					new VerseInfo(20, 16),//2 Nephi 9:97
					new VerseInfo(20, 17),//2 Nephi 9:98
					new VerseInfo(20, 18),//2 Nephi 9:99
					new VerseInfo(20, 19),//2 Nephi 9:100
					new VerseInfo(20, 20),//2 Nephi 9:101
					new VerseInfo(20, 21),//2 Nephi 9:102
					new VerseInfo(20, 22),//2 Nephi 9:103
					new VerseInfo(20, 23),//2 Nephi 9:104
					new VerseInfo(20, 24),//2 Nephi 9:105
					new VerseInfo(20, 25),//2 Nephi 9:106
					new VerseInfo(20, 26),//2 Nephi 9:107
					new VerseInfo(20, 27),//2 Nephi 9:108
					new VerseInfo(20, 28),//2 Nephi 9:109
					new VerseInfo(20, 29),//2 Nephi 9:110
					new VerseInfo(20, 30),//2 Nephi 9:111
					new VerseInfo(20, 31),//2 Nephi 9:112
					new VerseInfo(20, 32),//2 Nephi 9:113
					new VerseInfo(20, 33),//2 Nephi 9:114
					new VerseInfo(20, 34),//2 Nephi 9:115
					new VerseInfo(21, 1),//2 Nephi 9:116
					new VerseInfo(21, 2),//2 Nephi 9:117
					new VerseInfo(21, 3),//2 Nephi 9:118
					new VerseInfo(21, 4),//2 Nephi 9:119
					new VerseInfo(21, 5),//2 Nephi 9:120
					new VerseInfo(21, 6),//2 Nephi 9:121
					new VerseInfo(21, 7),//2 Nephi 9:122
					new VerseInfo(21, 8),//2 Nephi 9:123
					new VerseInfo(21, 9),//2 Nephi 9:124
					new VerseInfo(21, 10),//2 Nephi 9:125
					new VerseInfo(21, 11),//2 Nephi 9:126
					new VerseInfo(21, 12),//2 Nephi 9:127
					new VerseInfo(21, 13),//2 Nephi 9:128
					new VerseInfo(21, 14),//2 Nephi 9:129
					new VerseInfo(21, 15),//2 Nephi 9:130
					new VerseInfo(21, 16),//2 Nephi 9:131
					new VerseInfo(22, 1),//2 Nephi 9:132
					new VerseInfo(22, 2),//2 Nephi 9:133
					new VerseInfo(22, 3),//2 Nephi 9:134
					new VerseInfo(22, 4),//2 Nephi 9:135
					new VerseInfo(22, 5),//2 Nephi 9:136
					new VerseInfo(22, 6),//2 Nephi 9:137
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 10
					new VerseInfo(23, 1),//2 Nephi 10:1
					new VerseInfo(23, 2),//2 Nephi 10:2
					new VerseInfo(23, 3),//2 Nephi 10:3
					new VerseInfo(23, 4),//2 Nephi 10:4
					new VerseInfo(23, 5),//2 Nephi 10:5
					new VerseInfo(23, 6),//2 Nephi 10:6
					new VerseInfo(23, 7),//2 Nephi 10:7
					new VerseInfo(23, 8),//2 Nephi 10:8
					new VerseInfo(23, 9),//2 Nephi 10:9
					new VerseInfo(23, 10),//2 Nephi 10:10
					new VerseInfo(23, 11),//2 Nephi 10:11
					new VerseInfo(23, 12),//2 Nephi 10:12
					new VerseInfo(23, 13),//2 Nephi 10:13
					new VerseInfo(23, 14),//2 Nephi 10:14
					new VerseInfo(23, 15),//2 Nephi 10:15
					new VerseInfo(23, 16),//2 Nephi 10:16
					new VerseInfo(23, 17),//2 Nephi 10:17
					new VerseInfo(23, 18),//2 Nephi 10:18
					new VerseInfo(23, 19),//2 Nephi 10:19
					new VerseInfo(23, 20),//2 Nephi 10:20
					new VerseInfo(23, 21),//2 Nephi 10:21
					new VerseInfo(23, 22),//2 Nephi 10:22
					new VerseInfo(24, 1),//2 Nephi 10:23
					new VerseInfo(24, 2),//2 Nephi 10:24
					new VerseInfo(24, 3),//2 Nephi 10:25
					new VerseInfo(24, 4),//2 Nephi 10:26
					new VerseInfo(24, 5),//2 Nephi 10:27
					new VerseInfo(24, 6),//2 Nephi 10:28
					new VerseInfo(24, 7),//2 Nephi 10:29
					new VerseInfo(24, 8),//2 Nephi 10:30
					new VerseInfo(24, 9),//2 Nephi 10:31
					new VerseInfo(24, 10),//2 Nephi 10:32
					new VerseInfo(24, 11),//2 Nephi 10:33
					new VerseInfo(24, 12),//2 Nephi 10:34
					new VerseInfo(24, 13),//2 Nephi 10:35
					new VerseInfo(24, 14),//2 Nephi 10:36
					new VerseInfo(24, 15),//2 Nephi 10:37
					new VerseInfo(24, 16),//2 Nephi 10:38
					new VerseInfo(24, 17),//2 Nephi 10:39
					new VerseInfo(24, 18),//2 Nephi 10:40
					new VerseInfo(24, 19),//2 Nephi 10:41
					new VerseInfo(24, 20),//2 Nephi 10:42
					new VerseInfo(24, 21),//2 Nephi 10:43
					new VerseInfo(24, 22),//2 Nephi 10:44
					new VerseInfo(24, 23),//2 Nephi 10:45
					new VerseInfo(24, 24),//2 Nephi 10:46
					new VerseInfo(24, 25),//2 Nephi 10:47
					new VerseInfo(24, 26),//2 Nephi 10:48
					new VerseInfo(24, 27),//2 Nephi 10:49
					new VerseInfo(24, 28),//2 Nephi 10:50
					new VerseInfo(24, 29),//2 Nephi 10:51
					new VerseInfo(24, 30),//2 Nephi 10:52
					new VerseInfo(24, 31),//2 Nephi 10:53
					new VerseInfo(24, 32),//2 Nephi 10:54
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 11
					new VerseInfo(25, 1),//2 Nephi 11:1
					new VerseInfo(25, 1),//2 Nephi 11:2
					new VerseInfo(25, 2),//2 Nephi 11:3
					new VerseInfo(25, 3),//2 Nephi 11:4
					new VerseInfo(25, 4),//2 Nephi 11:5
					new VerseInfo(25, 4),//2 Nephi 11:6
					new VerseInfo(25, 4),//2 Nephi 11:7
					new VerseInfo(25, 5),//2 Nephi 11:8
					new VerseInfo(25, 6),//2 Nephi 11:9
					new VerseInfo(25, 6),//2 Nephi 11:10
					new VerseInfo(25, 7),//2 Nephi 11:11
					new VerseInfo(25, 7),//2 Nephi 11:12
					new VerseInfo(25, 8),//2 Nephi 11:13
					new VerseInfo(25, 8),//2 Nephi 11:14
					new VerseInfo(25, 9),//2 Nephi 11:15
					new VerseInfo(25, 9),//2 Nephi 11:16
					new VerseInfo(25, 10),//2 Nephi 11:17
					new VerseInfo(25, 10),//2 Nephi 11:18
					new VerseInfo(25, 11),//2 Nephi 11:19
					new VerseInfo(25, 11),//2 Nephi 11:20
					new VerseInfo(25, 12),//2 Nephi 11:21
					new VerseInfo(25, 13),//2 Nephi 11:22
					new VerseInfo(25, 13),//2 Nephi 11:23
					new VerseInfo(25, 14),//2 Nephi 11:24
					new VerseInfo(25, 15),//2 Nephi 11:25
					new VerseInfo(25, 16),//2 Nephi 11:26
					new VerseInfo(25, 16),//2 Nephi 11:27
					new VerseInfo(25, 17),//2 Nephi 11:28
					new VerseInfo(25, 17),//2 Nephi 11:29
					new VerseInfo(25, 18),//2 Nephi 11:30
					new VerseInfo(25, 18),//2 Nephi 11:31
					new VerseInfo(25, 18),//2 Nephi 11:32
					new VerseInfo(25, 18),//2 Nephi 11:33
					new VerseInfo(25, 18),//2 Nephi 11:34
					new VerseInfo(25, 19),//2 Nephi 11:35
					new VerseInfo(25, 19),//2 Nephi 11:36
					new VerseInfo(25, 20),//2 Nephi 11:37
					new VerseInfo(25, 20),//2 Nephi 11:38
					new VerseInfo(25, 20),//2 Nephi 11:39
					new VerseInfo(25, 21),//2 Nephi 11:40
					new VerseInfo(25, 22),//2 Nephi 11:41
					new VerseInfo(25, 22),//2 Nephi 11:42
					new VerseInfo(25, 23),//2 Nephi 11:43
					new VerseInfo(25, 23),//2 Nephi 11:44
					new VerseInfo(25, 24, 25, 25),//2 Nephi 11:45
					new VerseInfo(25, 25),//2 Nephi 11:46
					new VerseInfo(25, 25),//2 Nephi 11:47
					new VerseInfo(25, 26),//2 Nephi 11:48
					new VerseInfo(25, 27),//2 Nephi 11:49
					new VerseInfo(25, 27),//2 Nephi 11:50
					new VerseInfo(25, 27),//2 Nephi 11:51
					new VerseInfo(25, 28),//2 Nephi 11:52
					new VerseInfo(25, 28),//2 Nephi 11:53
					new VerseInfo(25, 28),//2 Nephi 11:54
					new VerseInfo(25, 29),//2 Nephi 11:55
					new VerseInfo(25, 29),//2 Nephi 11:56
					new VerseInfo(25, 30),//2 Nephi 11:57
					new VerseInfo(26, 1),//2 Nephi 11:58
					new VerseInfo(26, 1),//2 Nephi 11:59
					new VerseInfo(26, 2),//2 Nephi 11:60
					new VerseInfo(26, 3),//2 Nephi 11:61
					new VerseInfo(26, 3),//2 Nephi 11:62
					new VerseInfo(26, 3),//2 Nephi 11:63
					new VerseInfo(26, 3),//2 Nephi 11:64
					new VerseInfo(26, 4),//2 Nephi 11:65
					new VerseInfo(26, 5),//2 Nephi 11:66
					new VerseInfo(26, 5),//2 Nephi 11:67
					new VerseInfo(26, 6),//2 Nephi 11:68
					new VerseInfo(26, 6),//2 Nephi 11:69
					new VerseInfo(26, 7),//2 Nephi 11:70
					new VerseInfo(26, 7),//2 Nephi 11:71
					new VerseInfo(26, 8),//2 Nephi 11:72
					new VerseInfo(26, 9),//2 Nephi 11:73
					new VerseInfo(26, 10),//2 Nephi 11:74
					new VerseInfo(26, 10),//2 Nephi 11:75
					new VerseInfo(26, 10, 26, 11),//2 Nephi 11:76
					new VerseInfo(26, 11),//2 Nephi 11:77
					new VerseInfo(26, 12, 26, 13),//2 Nephi 11:78
					new VerseInfo(26, 13),//2 Nephi 11:79
					new VerseInfo(26, 14),//2 Nephi 11:80
					new VerseInfo(26, 15),//2 Nephi 11:81
					new VerseInfo(26, 15),//2 Nephi 11:82
					new VerseInfo(26, 15),//2 Nephi 11:83
					new VerseInfo(26, 16),//2 Nephi 11:84
					new VerseInfo(26, 16),//2 Nephi 11:85
					new VerseInfo(26, 17),//2 Nephi 11:86
					new VerseInfo(26, 18),//2 Nephi 11:87
					new VerseInfo(26, 18),//2 Nephi 11:88
					new VerseInfo(26, 19),//2 Nephi 11:89
					new VerseInfo(26, 20),//2 Nephi 11:90
					new VerseInfo(26, 20),//2 Nephi 11:91
					new VerseInfo(26, 21),//2 Nephi 11:92
					new VerseInfo(26, 22),//2 Nephi 11:93
					new VerseInfo(26, 22),//2 Nephi 11:94
					new VerseInfo(26, 23),//2 Nephi 11:95
					new VerseInfo(26, 24),//2 Nephi 11:96
					new VerseInfo(26, 24),//2 Nephi 11:97
					new VerseInfo(26, 25),//2 Nephi 11:98
					new VerseInfo(26, 25),//2 Nephi 11:99
					new VerseInfo(26, 26),//2 Nephi 11:100
					new VerseInfo(26, 26),//2 Nephi 11:101
					new VerseInfo(26, 27),//2 Nephi 11:102
					new VerseInfo(26, 27),//2 Nephi 11:103
					new VerseInfo(26, 28),//2 Nephi 11:104
					new VerseInfo(26, 28),//2 Nephi 11:105
					new VerseInfo(26, 29),//2 Nephi 11:106
					new VerseInfo(26, 30),//2 Nephi 11:107
					new VerseInfo(26, 30),//2 Nephi 11:108
					new VerseInfo(26, 31),//2 Nephi 11:109
					new VerseInfo(26, 32),//2 Nephi 11:110
					new VerseInfo(26, 32, 26, 33),//2 Nephi 11:111
					new VerseInfo(26, 33),//2 Nephi 11:112
					new VerseInfo(26, 33),//2 Nephi 11:113
					new VerseInfo(26, 33),//2 Nephi 11:114
					new VerseInfo(26, 33),//2 Nephi 11:115
					new VerseInfo(27, 1),//2 Nephi 11:116
					new VerseInfo(27, 2),//2 Nephi 11:117
					new VerseInfo(27, 3),//2 Nephi 11:118
					new VerseInfo(27, 3),//2 Nephi 11:119
					new VerseInfo(27, 3),//2 Nephi 11:120
					new VerseInfo(27, 3),//2 Nephi 11:121
					new VerseInfo(27, 4),//2 Nephi 11:122
					new VerseInfo(27, 5),//2 Nephi 11:123
					new VerseInfo(27, 5),//2 Nephi 11:124
					new VerseInfo(27, 6),//2 Nephi 11:125
					new VerseInfo(27, 7),//2 Nephi 11:126
					new VerseInfo(27, 8),//2 Nephi 11:127
					new VerseInfo(27, 8),//2 Nephi 11:128
					new VerseInfo(27, 9, 27, 10),//2 Nephi 11:129
					new VerseInfo(27, 10),//2 Nephi 11:130
					new VerseInfo(27, 11),//2 Nephi 11:131
					new VerseInfo(27, 11),//2 Nephi 11:132
					new VerseInfo(27, 12),//2 Nephi 11:133
					new VerseInfo(27, 13),//2 Nephi 11:134
					new VerseInfo(27, 14),//2 Nephi 11:135
					new VerseInfo(27, 15),//2 Nephi 11:136
					new VerseInfo(27, 15),//2 Nephi 11:137
					new VerseInfo(27, 16),//2 Nephi 11:138
					new VerseInfo(27, 17),//2 Nephi 11:139
					new VerseInfo(27, 18),//2 Nephi 11:140
					new VerseInfo(27, 19),//2 Nephi 11:141
					new VerseInfo(27, 20),//2 Nephi 11:142
					new VerseInfo(27, 21),//2 Nephi 11:143
					new VerseInfo(27, 22),//2 Nephi 11:144
					new VerseInfo(27, 23),//2 Nephi 11:145
					new VerseInfo(27, 24, 27, 26),//2 Nephi 11:146
					new VerseInfo(27, 26),//2 Nephi 11:147
					new VerseInfo(27, 27),//2 Nephi 11:148
					new VerseInfo(27, 27),//2 Nephi 11:149
					new VerseInfo(27, 27),//2 Nephi 11:150
					new VerseInfo(27, 27),//2 Nephi 11:151
					new VerseInfo(27, 27),//2 Nephi 11:152
					new VerseInfo(27, 27),//2 Nephi 11:153
					new VerseInfo(27, 28),//2 Nephi 11:154
					new VerseInfo(27, 29),//2 Nephi 11:155
					new VerseInfo(27, 30),//2 Nephi 11:156
					new VerseInfo(27, 31, 27, 32),//2 Nephi 11:157
					new VerseInfo(27, 33),//2 Nephi 11:158
					new VerseInfo(27, 34),//2 Nephi 11:159
					new VerseInfo(27, 35),//2 Nephi 11:160
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 12
					new VerseInfo(28, 1),//2 Nephi 12:1
					new VerseInfo(28, 2),//2 Nephi 12:2
					new VerseInfo(28, 3),//2 Nephi 12:3
					new VerseInfo(28, 3),//2 Nephi 12:4
					new VerseInfo(28, 4),//2 Nephi 12:5
					new VerseInfo(28, 5),//2 Nephi 12:6
					new VerseInfo(28, 5),//2 Nephi 12:7
					new VerseInfo(28, 6),//2 Nephi 12:8
					new VerseInfo(28, 7),//2 Nephi 12:9
					new VerseInfo(28, 8),//2 Nephi 12:10
					new VerseInfo(28, 8),//2 Nephi 12:11
					new VerseInfo(28, 9, 28, 10),//2 Nephi 12:12
					new VerseInfo(28, 11),//2 Nephi 12:13
					new VerseInfo(28, 12),//2 Nephi 12:14
					new VerseInfo(28, 13),//2 Nephi 12:15
					new VerseInfo(28, 14),//2 Nephi 12:16
					new VerseInfo(28, 14),//2 Nephi 12:17
					new VerseInfo(28, 15),//2 Nephi 12:18
					new VerseInfo(28, 16),//2 Nephi 12:19
					new VerseInfo(28, 16),//2 Nephi 12:20
					new VerseInfo(28, 17),//2 Nephi 12:21
					new VerseInfo(28, 18),//2 Nephi 12:22
					new VerseInfo(28, 19),//2 Nephi 12:23
					new VerseInfo(28, 20),//2 Nephi 12:24
					new VerseInfo(28, 21),//2 Nephi 12:25
					new VerseInfo(28, 21),//2 Nephi 12:26
					new VerseInfo(28, 22),//2 Nephi 12:27
					new VerseInfo(28, 22),//2 Nephi 12:28
					new VerseInfo(28, 23),//2 Nephi 12:29
					new VerseInfo(28, 24),//2 Nephi 12:30
					new VerseInfo(28, 25, 28, 26),//2 Nephi 12:31
					new VerseInfo(28, 27),//2 Nephi 12:32
					new VerseInfo(28, 28),//2 Nephi 12:33
					new VerseInfo(28, 28),//2 Nephi 12:34
					new VerseInfo(28, 29),//2 Nephi 12:35
					new VerseInfo(28, 30),//2 Nephi 12:36
					new VerseInfo(28, 30),//2 Nephi 12:37
					new VerseInfo(28, 30),//2 Nephi 12:38
					new VerseInfo(28, 31),//2 Nephi 12:39
					new VerseInfo(28, 32),//2 Nephi 12:40
					new VerseInfo(28, 32),//2 Nephi 12:41
					new VerseInfo(29, 1),//2 Nephi 12:42
					new VerseInfo(29, 2),//2 Nephi 12:43
					new VerseInfo(29, 2),//2 Nephi 12:44
					new VerseInfo(29, 3),//2 Nephi 12:45
					new VerseInfo(29, 4),//2 Nephi 12:46
					new VerseInfo(29, 4),//2 Nephi 12:47
					new VerseInfo(29, 4),//2 Nephi 12:48
					new VerseInfo(29, 4),//2 Nephi 12:49
					new VerseInfo(29, 5),//2 Nephi 12:50
					new VerseInfo(29, 5),//2 Nephi 12:51
					new VerseInfo(29, 5),//2 Nephi 12:52
					new VerseInfo(29, 6),//2 Nephi 12:53
					new VerseInfo(29, 6),//2 Nephi 12:54
					new VerseInfo(29, 7),//2 Nephi 12:55
					new VerseInfo(29, 7),//2 Nephi 12:56
					new VerseInfo(29, 7),//2 Nephi 12:57
					new VerseInfo(29, 8),//2 Nephi 12:58
					new VerseInfo(29, 8),//2 Nephi 12:59
					new VerseInfo(29, 8),//2 Nephi 12:60
					new VerseInfo(29, 8),//2 Nephi 12:61
					new VerseInfo(29, 9),//2 Nephi 12:62
					new VerseInfo(29, 9),//2 Nephi 12:63
					new VerseInfo(29, 10),//2 Nephi 12:64
					new VerseInfo(29, 11),//2 Nephi 12:65
					new VerseInfo(29, 11),//2 Nephi 12:66
					new VerseInfo(29, 12),//2 Nephi 12:67
					new VerseInfo(29, 12),//2 Nephi 12:68
					new VerseInfo(29, 12),//2 Nephi 12:69
					new VerseInfo(29, 12),//2 Nephi 12:70
					new VerseInfo(29, 13),//2 Nephi 12:71
					new VerseInfo(29, 13),//2 Nephi 12:72
					new VerseInfo(29, 14),//2 Nephi 12:73
					new VerseInfo(29, 14),//2 Nephi 12:74
					new VerseInfo(30, 1),//2 Nephi 12:75
					new VerseInfo(30, 1),//2 Nephi 12:76
					new VerseInfo(30, 2),//2 Nephi 12:77
					new VerseInfo(30, 2),//2 Nephi 12:78
					new VerseInfo(30, 3),//2 Nephi 12:79
					new VerseInfo(30, 3),//2 Nephi 12:80
					new VerseInfo(30, 4),//2 Nephi 12:81
					new VerseInfo(30, 5),//2 Nephi 12:82
					new VerseInfo(30, 6),//2 Nephi 12:83
					new VerseInfo(30, 6),//2 Nephi 12:84
					new VerseInfo(30, 7),//2 Nephi 12:85
					new VerseInfo(30, 7),//2 Nephi 12:86
					new VerseInfo(30, 8),//2 Nephi 12:87
					new VerseInfo(30, 9),//2 Nephi 12:88
					new VerseInfo(30, 9),//2 Nephi 12:89
					new VerseInfo(30, 10),//2 Nephi 12:90
					new VerseInfo(30, 11),//2 Nephi 12:91
					new VerseInfo(30, 12),//2 Nephi 12:92
					new VerseInfo(30, 13),//2 Nephi 12:93
					new VerseInfo(30, 14),//2 Nephi 12:94
					new VerseInfo(30, 15),//2 Nephi 12:95
					new VerseInfo(30, 16),//2 Nephi 12:96
					new VerseInfo(30, 17),//2 Nephi 12:97
					new VerseInfo(30, 18),//2 Nephi 12:98
					new VerseInfo(30, 18),//2 Nephi 12:99
					new VerseInfo(30, 18),//2 Nephi 12:100
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 13
					new VerseInfo(31, 1),//2 Nephi 13:1
					new VerseInfo(31, 1),//2 Nephi 13:2
					new VerseInfo(31, 2),//2 Nephi 13:3
					new VerseInfo(31, 3),//2 Nephi 13:4
					new VerseInfo(31, 3),//2 Nephi 13:5
					new VerseInfo(31, 4),//2 Nephi 13:6
					new VerseInfo(31, 5),//2 Nephi 13:7
					new VerseInfo(31, 6, 31, 7),//2 Nephi 13:8
					new VerseInfo(31, 7),//2 Nephi 13:9
					new VerseInfo(31, 8),//2 Nephi 13:10
					new VerseInfo(31, 9),//2 Nephi 13:11
					new VerseInfo(31, 10),//2 Nephi 13:12
					new VerseInfo(31, 10),//2 Nephi 13:13
					new VerseInfo(31, 11),//2 Nephi 13:14
					new VerseInfo(31, 12),//2 Nephi 13:15
					new VerseInfo(31, 13),//2 Nephi 13:16
					new VerseInfo(31, 13),//2 Nephi 13:17
					new VerseInfo(31, 14),//2 Nephi 13:18
					new VerseInfo(31, 15),//2 Nephi 13:19
					new VerseInfo(31, 15),//2 Nephi 13:20
					new VerseInfo(31, 16),//2 Nephi 13:21
					new VerseInfo(31, 17),//2 Nephi 13:22
					new VerseInfo(31, 17),//2 Nephi 13:23
					new VerseInfo(31, 17),//2 Nephi 13:24
					new VerseInfo(31, 18),//2 Nephi 13:25
					new VerseInfo(31, 18),//2 Nephi 13:26
					new VerseInfo(31, 19),//2 Nephi 13:27
					new VerseInfo(31, 19),//2 Nephi 13:28
					new VerseInfo(31, 20),//2 Nephi 13:29
					new VerseInfo(31, 20),//2 Nephi 13:30
					new VerseInfo(31, 21),//2 Nephi 13:31
					new VerseInfo(31, 21),//2 Nephi 13:32
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 14
					new VerseInfo(32, 1),//2 Nephi 14:1
					new VerseInfo(32, 1, 32, 2),//2 Nephi 14:2
					new VerseInfo(32, 2, 32, 3),//2 Nephi 14:3
					new VerseInfo(32, 3),//2 Nephi 14:4
					new VerseInfo(32, 4),//2 Nephi 14:5
					new VerseInfo(32, 5),//2 Nephi 14:6
					new VerseInfo(32, 6),//2 Nephi 14:7
					new VerseInfo(32, 6),//2 Nephi 14:8
					new VerseInfo(32, 7),//2 Nephi 14:9
					new VerseInfo(32, 8),//2 Nephi 14:10
					new VerseInfo(32, 8),//2 Nephi 14:11
					new VerseInfo(32, 9),//2 Nephi 14:12
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//2 Nephi 15
					new VerseInfo(33, 1),//2 Nephi 15:1
					new VerseInfo(33, 2),//2 Nephi 15:2
					new VerseInfo(33, 3),//2 Nephi 15:3
					new VerseInfo(33, 3, 33, 4),//2 Nephi 15:4
					new VerseInfo(33, 4),//2 Nephi 15:5
					new VerseInfo(33, 5),//2 Nephi 15:6
					new VerseInfo(33, 6),//2 Nephi 15:7
					new VerseInfo(33, 7),//2 Nephi 15:8
					new VerseInfo(33, 8, 33, 9),//2 Nephi 15:9
					new VerseInfo(33, 9),//2 Nephi 15:10
					new VerseInfo(33, 10),//2 Nephi 15:11
					new VerseInfo(33, 10),//2 Nephi 15:12
					new VerseInfo(33, 11),//2 Nephi 15:13
					new VerseInfo(33, 11),//2 Nephi 15:14
					new VerseInfo(33, 12),//2 Nephi 15:15
					new VerseInfo(33, 13),//2 Nephi 15:16
					new VerseInfo(33, 14),//2 Nephi 15:17
					new VerseInfo(33, 15),//2 Nephi 15:18
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
					new VerseInfo(1, 10, 1, 11),//Jacob 1:10
					new VerseInfo(1, 11),//Jacob 1:11
					new VerseInfo(1, 12),//Jacob 1:12
					new VerseInfo(1, 13),//Jacob 1:13
					new VerseInfo(1, 14),//Jacob 1:14
					new VerseInfo(1, 15),//Jacob 1:15
					new VerseInfo(1, 16),//Jacob 1:16
					new VerseInfo(1, 17),//Jacob 1:17
					new VerseInfo(1, 18),//Jacob 1:18
					new VerseInfo(1, 19),//Jacob 1:19
					new VerseInfo(1, 19),//Jacob 1:20
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Jacob 2
					new VerseInfo(2, 1),//Jacob 2:1
					new VerseInfo(2, 2),//Jacob 2:2
					new VerseInfo(2, 3),//Jacob 2:3
					new VerseInfo(2, 4),//Jacob 2:4
					new VerseInfo(2, 5),//Jacob 2:5
					new VerseInfo(2, 6),//Jacob 2:6
					new VerseInfo(2, 7),//Jacob 2:7
					new VerseInfo(2, 8),//Jacob 2:8
					new VerseInfo(2, 9),//Jacob 2:9
					new VerseInfo(2, 9),//Jacob 2:10
					new VerseInfo(2, 10),//Jacob 2:11
					new VerseInfo(2, 11),//Jacob 2:12
					new VerseInfo(2, 11),//Jacob 2:13
					new VerseInfo(2, 12),//Jacob 2:14
					new VerseInfo(2, 13),//Jacob 2:15
					new VerseInfo(2, 13),//Jacob 2:16
					new VerseInfo(2, 14),//Jacob 2:17
					new VerseInfo(2, 14),//Jacob 2:18
					new VerseInfo(2, 15),//Jacob 2:19
					new VerseInfo(2, 16),//Jacob 2:20
					new VerseInfo(2, 16),//Jacob 2:21
					new VerseInfo(2, 17),//Jacob 2:22
					new VerseInfo(2, 18),//Jacob 2:23
					new VerseInfo(2, 19),//Jacob 2:24
					new VerseInfo(2, 20),//Jacob 2:25
					new VerseInfo(2, 21),//Jacob 2:26
					new VerseInfo(2, 21),//Jacob 2:27
					new VerseInfo(2, 21),//Jacob 2:28
					new VerseInfo(2, 22),//Jacob 2:29
					new VerseInfo(2, 22),//Jacob 2:30
					new VerseInfo(2, 23),//Jacob 2:31
					new VerseInfo(2, 23),//Jacob 2:32
					new VerseInfo(2, 24),//Jacob 2:33
					new VerseInfo(2, 25),//Jacob 2:34
					new VerseInfo(2, 26),//Jacob 2:35
					new VerseInfo(2, 27, 2, 28),//Jacob 2:36
					new VerseInfo(2, 28),//Jacob 2:37
					new VerseInfo(2, 29),//Jacob 2:38
					new VerseInfo(2, 30),//Jacob 2:39
					new VerseInfo(2, 31),//Jacob 2:40
					new VerseInfo(2, 32),//Jacob 2:41
					new VerseInfo(2, 33),//Jacob 2:42
					new VerseInfo(2, 33),//Jacob 2:43
					new VerseInfo(2, 34),//Jacob 2:44
					new VerseInfo(2, 35),//Jacob 2:45
					new VerseInfo(2, 35),//Jacob 2:46
					new VerseInfo(2, 35),//Jacob 2:47
					new VerseInfo(3, 1),//Jacob 2:48
					new VerseInfo(3, 1),//Jacob 2:49
					new VerseInfo(3, 2),//Jacob 2:50
					new VerseInfo(3, 3),//Jacob 2:51
					new VerseInfo(3, 3),//Jacob 2:52
					new VerseInfo(3, 4),//Jacob 2:53
					new VerseInfo(3, 5),//Jacob 2:54
					new VerseInfo(3, 5),//Jacob 2:55
					new VerseInfo(3, 6),//Jacob 2:56
					new VerseInfo(3, 7),//Jacob 2:57
					new VerseInfo(3, 7),//Jacob 2:58
					new VerseInfo(3, 8),//Jacob 2:59
					new VerseInfo(3, 9),//Jacob 2:60
					new VerseInfo(3, 9),//Jacob 2:61
					new VerseInfo(3, 10),//Jacob 2:62
					new VerseInfo(3, 10),//Jacob 2:63
					new VerseInfo(3, 11),//Jacob 2:64
					new VerseInfo(3, 11),//Jacob 2:65
					new VerseInfo(3, 12),//Jacob 2:66
					new VerseInfo(3, 13),//Jacob 2:67
					new VerseInfo(3, 13),//Jacob 2:68
					new VerseInfo(3, 14),//Jacob 2:69
					new VerseInfo(3, 14),//Jacob 2:70
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Jacob 3
					new VerseInfo(4, 1),//Jacob 3:1
					new VerseInfo(4, 2),//Jacob 3:2
					new VerseInfo(4, 3),//Jacob 3:3
					new VerseInfo(4, 4),//Jacob 3:4
					new VerseInfo(4, 5),//Jacob 3:5
					new VerseInfo(4, 5),//Jacob 3:6
					new VerseInfo(4, 6),//Jacob 3:7
					new VerseInfo(4, 7),//Jacob 3:8
					new VerseInfo(4, 8),//Jacob 3:9
					new VerseInfo(4, 8),//Jacob 3:10
					new VerseInfo(4, 8),//Jacob 3:11
					new VerseInfo(4, 9),//Jacob 3:12
					new VerseInfo(4, 9),//Jacob 3:13
					new VerseInfo(4, 10),//Jacob 3:14
					new VerseInfo(4, 10),//Jacob 3:15
					new VerseInfo(4, 11),//Jacob 3:16
					new VerseInfo(4, 11),//Jacob 3:17
					new VerseInfo(4, 12, 4, 13),//Jacob 3:18
					new VerseInfo(4, 13),//Jacob 3:19
					new VerseInfo(4, 13),//Jacob 3:20
					new VerseInfo(4, 13),//Jacob 3:21
					new VerseInfo(4, 14),//Jacob 3:22
					new VerseInfo(4, 14),//Jacob 3:23
					new VerseInfo(4, 14),//Jacob 3:24
					new VerseInfo(4, 14),//Jacob 3:25
					new VerseInfo(4, 15),//Jacob 3:26
					new VerseInfo(4, 16),//Jacob 3:27
					new VerseInfo(4, 17),//Jacob 3:28
					new VerseInfo(4, 18),//Jacob 3:29
					new VerseInfo(5, 1, 5, 2),//Jacob 3:30
					new VerseInfo(5, 3),//Jacob 3:31
					new VerseInfo(5, 4),//Jacob 3:32
					new VerseInfo(5, 5),//Jacob 3:33
					new VerseInfo(5, 6),//Jacob 3:34
					new VerseInfo(5, 7),//Jacob 3:35
					new VerseInfo(5, 7),//Jacob 3:36
					new VerseInfo(5, 8),//Jacob 3:37
					new VerseInfo(5, 8),//Jacob 3:38
					new VerseInfo(5, 8),//Jacob 3:39
					new VerseInfo(5, 9),//Jacob 3:40
					new VerseInfo(5, 9),//Jacob 3:41
					new VerseInfo(5, 10),//Jacob 3:42
					new VerseInfo(5, 11),//Jacob 3:43
					new VerseInfo(5, 11),//Jacob 3:44
					new VerseInfo(5, 12),//Jacob 3:45
					new VerseInfo(5, 13),//Jacob 3:46
					new VerseInfo(5, 13),//Jacob 3:47
					new VerseInfo(5, 14),//Jacob 3:48
					new VerseInfo(5, 15),//Jacob 3:49
					new VerseInfo(5, 16),//Jacob 3:50
					new VerseInfo(5, 16),//Jacob 3:51
					new VerseInfo(5, 17),//Jacob 3:52
					new VerseInfo(5, 17),//Jacob 3:53
					new VerseInfo(5, 18),//Jacob 3:54
					new VerseInfo(5, 18),//Jacob 3:55
					new VerseInfo(5, 18),//Jacob 3:56
					new VerseInfo(5, 18),//Jacob 3:57
					new VerseInfo(5, 19),//Jacob 3:58
					new VerseInfo(5, 20),//Jacob 3:59
					new VerseInfo(5, 20),//Jacob 3:60
					new VerseInfo(5, 20),//Jacob 3:61
					new VerseInfo(5, 20),//Jacob 3:62
					new VerseInfo(5, 21),//Jacob 3:63
					new VerseInfo(5, 22),//Jacob 3:64
					new VerseInfo(5, 23),//Jacob 3:65
					new VerseInfo(5, 23),//Jacob 3:66
					new VerseInfo(5, 24),//Jacob 3:67
					new VerseInfo(5, 25),//Jacob 3:68
					new VerseInfo(5, 26),//Jacob 3:69
					new VerseInfo(5, 27),//Jacob 3:70
					new VerseInfo(5, 28),//Jacob 3:71
					new VerseInfo(5, 29),//Jacob 3:72
					new VerseInfo(5, 29),//Jacob 3:73
					new VerseInfo(5, 30),//Jacob 3:74
					new VerseInfo(5, 31),//Jacob 3:75
					new VerseInfo(5, 31),//Jacob 3:76
					new VerseInfo(5, 32),//Jacob 3:77
					new VerseInfo(5, 32),//Jacob 3:78
					new VerseInfo(5, 33),//Jacob 3:79
					new VerseInfo(5, 34),//Jacob 3:80
					new VerseInfo(5, 35),//Jacob 3:81
					new VerseInfo(5, 36),//Jacob 3:82
					new VerseInfo(5, 37),//Jacob 3:83
					new VerseInfo(5, 37),//Jacob 3:84
					new VerseInfo(5, 38),//Jacob 3:85
					new VerseInfo(5, 39),//Jacob 3:86
					new VerseInfo(5, 39),//Jacob 3:87
					new VerseInfo(5, 40),//Jacob 3:88
					new VerseInfo(5, 41),//Jacob 3:89
					new VerseInfo(5, 42),//Jacob 3:90
					new VerseInfo(5, 42),//Jacob 3:91
					new VerseInfo(5, 42),//Jacob 3:92
					new VerseInfo(5, 43),//Jacob 3:93
					new VerseInfo(5, 44),//Jacob 3:94
					new VerseInfo(5, 45),//Jacob 3:95
					new VerseInfo(5, 45),//Jacob 3:96
					new VerseInfo(5, 46),//Jacob 3:97
					new VerseInfo(5, 46),//Jacob 3:98
					new VerseInfo(5, 46),//Jacob 3:99
					new VerseInfo(5, 47),//Jacob 3:100
					new VerseInfo(5, 47),//Jacob 3:101
					new VerseInfo(5, 47),//Jacob 3:102
					new VerseInfo(5, 47),//Jacob 3:103
					new VerseInfo(5, 47),//Jacob 3:104
					new VerseInfo(5, 48),//Jacob 3:105
					new VerseInfo(5, 48),//Jacob 3:106
					new VerseInfo(5, 48),//Jacob 3:107
					new VerseInfo(5, 48),//Jacob 3:108
					new VerseInfo(5, 49),//Jacob 3:109
					new VerseInfo(5, 50),//Jacob 3:110
					new VerseInfo(5, 51),//Jacob 3:111
					new VerseInfo(5, 52),//Jacob 3:112
					new VerseInfo(5, 52),//Jacob 3:113
					new VerseInfo(5, 53),//Jacob 3:114
					new VerseInfo(5, 54),//Jacob 3:115
					new VerseInfo(5, 54),//Jacob 3:116
					new VerseInfo(5, 54),//Jacob 3:117
					new VerseInfo(5, 55),//Jacob 3:118
					new VerseInfo(5, 56),//Jacob 3:119
					new VerseInfo(5, 57),//Jacob 3:120
					new VerseInfo(5, 58),//Jacob 3:121
					new VerseInfo(5, 59),//Jacob 3:122
					new VerseInfo(5, 60),//Jacob 3:123
					new VerseInfo(5, 60),//Jacob 3:124
					new VerseInfo(5, 61),//Jacob 3:125
					new VerseInfo(5, 62),//Jacob 3:126
					new VerseInfo(5, 63),//Jacob 3:127
					new VerseInfo(5, 64),//Jacob 3:128
					new VerseInfo(5, 64),//Jacob 3:129
					new VerseInfo(5, 65),//Jacob 3:130
					new VerseInfo(5, 65),//Jacob 3:131
					new VerseInfo(5, 66),//Jacob 3:132
					new VerseInfo(5, 67, 5, 68),//Jacob 3:133
					new VerseInfo(5, 68),//Jacob 3:134
					new VerseInfo(5, 69),//Jacob 3:135
					new VerseInfo(5, 70),//Jacob 3:136
					new VerseInfo(5, 71),//Jacob 3:137
					new VerseInfo(5, 71),//Jacob 3:138
					new VerseInfo(5, 71),//Jacob 3:139
					new VerseInfo(5, 72),//Jacob 3:140
					new VerseInfo(5, 73),//Jacob 3:141
					new VerseInfo(5, 73),//Jacob 3:142
					new VerseInfo(5, 74),//Jacob 3:143
					new VerseInfo(5, 74),//Jacob 3:144
					new VerseInfo(5, 75),//Jacob 3:145
					new VerseInfo(5, 75),//Jacob 3:146
					new VerseInfo(5, 75),//Jacob 3:147
					new VerseInfo(5, 76),//Jacob 3:148
					new VerseInfo(5, 76),//Jacob 3:149
					new VerseInfo(5, 76),//Jacob 3:150
					new VerseInfo(5, 77),//Jacob 3:151
					new VerseInfo(5, 77),//Jacob 3:152
					new VerseInfo(5, 77),//Jacob 3:153
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Jacob 4
					new VerseInfo(6, 1),//Jacob 4:1
					new VerseInfo(6, 1),//Jacob 4:2
					new VerseInfo(6, 2),//Jacob 4:3
					new VerseInfo(6, 3),//Jacob 4:4
					new VerseInfo(6, 3),//Jacob 4:5
					new VerseInfo(6, 4),//Jacob 4:6
					new VerseInfo(6, 4),//Jacob 4:7
					new VerseInfo(6, 5),//Jacob 4:8
					new VerseInfo(6, 5),//Jacob 4:9
					new VerseInfo(6, 6),//Jacob 4:10
					new VerseInfo(6, 7),//Jacob 4:11
					new VerseInfo(6, 8),//Jacob 4:12
					new VerseInfo(6, 8),//Jacob 4:13
					new VerseInfo(6, 9),//Jacob 4:14
					new VerseInfo(6, 10),//Jacob 4:15
					new VerseInfo(6, 11),//Jacob 4:16
					new VerseInfo(6, 12),//Jacob 4:17
					new VerseInfo(6, 13),//Jacob 4:18
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Jacob 5
					new VerseInfo(7, 1),//Jacob 5:1
					new VerseInfo(7, 2),//Jacob 5:2
					new VerseInfo(7, 2),//Jacob 5:3
					new VerseInfo(7, 3),//Jacob 5:4
					new VerseInfo(7, 3),//Jacob 5:5
					new VerseInfo(7, 4),//Jacob 5:6
					new VerseInfo(7, 5),//Jacob 5:7
					new VerseInfo(7, 5),//Jacob 5:8
					new VerseInfo(7, 6),//Jacob 5:9
					new VerseInfo(7, 7),//Jacob 5:10
					new VerseInfo(7, 7),//Jacob 5:11
					new VerseInfo(7, 7),//Jacob 5:12
					new VerseInfo(7, 8),//Jacob 5:13
					new VerseInfo(7, 9),//Jacob 5:14
					new VerseInfo(7, 9),//Jacob 5:15
					new VerseInfo(7, 10),//Jacob 5:16
					new VerseInfo(7, 10),//Jacob 5:17
					new VerseInfo(7, 11),//Jacob 5:18
					new VerseInfo(7, 11),//Jacob 5:19
					new VerseInfo(7, 12),//Jacob 5:20
					new VerseInfo(7, 12),//Jacob 5:21
					new VerseInfo(7, 13),//Jacob 5:22
					new VerseInfo(7, 14),//Jacob 5:23
					new VerseInfo(7, 14),//Jacob 5:24
					new VerseInfo(7, 14),//Jacob 5:25
					new VerseInfo(7, 14),//Jacob 5:26
					new VerseInfo(7, 15),//Jacob 5:27
					new VerseInfo(7, 15),//Jacob 5:28
					new VerseInfo(7, 16),//Jacob 5:29
					new VerseInfo(7, 17),//Jacob 5:30
					new VerseInfo(7, 18),//Jacob 5:31
					new VerseInfo(7, 18),//Jacob 5:32
					new VerseInfo(7, 19),//Jacob 5:33
					new VerseInfo(7, 19),//Jacob 5:34
					new VerseInfo(7, 20),//Jacob 5:35
					new VerseInfo(7, 21),//Jacob 5:36
					new VerseInfo(7, 22),//Jacob 5:37
					new VerseInfo(7, 23),//Jacob 5:38
					new VerseInfo(7, 24),//Jacob 5:39
					new VerseInfo(7, 24),//Jacob 5:40
					new VerseInfo(7, 25),//Jacob 5:41
					new VerseInfo(7, 26),//Jacob 5:42
					new VerseInfo(7, 26),//Jacob 5:43
					new VerseInfo(7, 26),//Jacob 5:44
					new VerseInfo(7, 27),//Jacob 5:45
					new VerseInfo(7, 27),//Jacob 5:46
					new VerseInfo(7, 27),//Jacob 5:47
					new VerseInfo(7, 27),//Jacob 5:48
				},
			}
		},
		{ "Enos", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Enos 1
					new VerseInfo(1, 1),//Enos 1:1
					new VerseInfo(1, 1),//Enos 1:2
					new VerseInfo(1, 2),//Enos 1:3
					new VerseInfo(1, 3),//Enos 1:4
					new VerseInfo(1, 4),//Enos 1:5
					new VerseInfo(1, 4),//Enos 1:6
					new VerseInfo(1, 5),//Enos 1:7
					new VerseInfo(1, 6),//Enos 1:8
					new VerseInfo(1, 7),//Enos 1:9
					new VerseInfo(1, 8),//Enos 1:10
					new VerseInfo(1, 8),//Enos 1:11
					new VerseInfo(1, 9),//Enos 1:12
					new VerseInfo(1, 10),//Enos 1:13
					new VerseInfo(1, 10),//Enos 1:14
					new VerseInfo(1, 10),//Enos 1:15
					new VerseInfo(1, 10),//Enos 1:16
					new VerseInfo(1, 11),//Enos 1:17
					new VerseInfo(1, 12),//Enos 1:18
					new VerseInfo(1, 13),//Enos 1:19
					new VerseInfo(1, 13),//Enos 1:20
					new VerseInfo(1, 14),//Enos 1:21
					new VerseInfo(1, 14),//Enos 1:22
					new VerseInfo(1, 15),//Enos 1:23
					new VerseInfo(1, 15),//Enos 1:24
					new VerseInfo(1, 16),//Enos 1:25
					new VerseInfo(1, 16),//Enos 1:26
					new VerseInfo(1, 17),//Enos 1:27
					new VerseInfo(1, 18),//Enos 1:28
					new VerseInfo(1, 19),//Enos 1:29
					new VerseInfo(1, 20),//Enos 1:30
					new VerseInfo(1, 20),//Enos 1:31
					new VerseInfo(1, 20),//Enos 1:32
					new VerseInfo(1, 20),//Enos 1:33
					new VerseInfo(1, 21),//Enos 1:34
					new VerseInfo(1, 22),//Enos 1:35
					new VerseInfo(1, 22),//Enos 1:36
					new VerseInfo(1, 23),//Enos 1:37
					new VerseInfo(1, 23),//Enos 1:38
					new VerseInfo(1, 23),//Enos 1:39
					new VerseInfo(1, 23),//Enos 1:40
					new VerseInfo(1, 24),//Enos 1:41
					new VerseInfo(1, 25),//Enos 1:42
					new VerseInfo(1, 26),//Enos 1:43
					new VerseInfo(1, 26),//Enos 1:44
					new VerseInfo(1, 27),//Enos 1:45
					new VerseInfo(1, 27),//Enos 1:46
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
					new VerseInfo(1, 2),//Jarom 1:2
					new VerseInfo(1, 2),//Jarom 1:3
					new VerseInfo(1, 2),//Jarom 1:4
					new VerseInfo(1, 2),//Jarom 1:5
					new VerseInfo(1, 3),//Jarom 1:6
					new VerseInfo(1, 3),//Jarom 1:7
					new VerseInfo(1, 4),//Jarom 1:8
					new VerseInfo(1, 4),//Jarom 1:9
					new VerseInfo(1, 5),//Jarom 1:10
					new VerseInfo(1, 5),//Jarom 1:11
					new VerseInfo(1, 5),//Jarom 1:12
					new VerseInfo(1, 5),//Jarom 1:13
					new VerseInfo(1, 6),//Jarom 1:14
					new VerseInfo(1, 6),//Jarom 1:15
					new VerseInfo(1, 7),//Jarom 1:16
					new VerseInfo(1, 7),//Jarom 1:17
					new VerseInfo(1, 7),//Jarom 1:18
					new VerseInfo(1, 8),//Jarom 1:19
					new VerseInfo(1, 8),//Jarom 1:20
					new VerseInfo(1, 9),//Jarom 1:21
					new VerseInfo(1, 9),//Jarom 1:22
					new VerseInfo(1, 10),//Jarom 1:23
					new VerseInfo(1, 11),//Jarom 1:24
					new VerseInfo(1, 11),//Jarom 1:25
					new VerseInfo(1, 11),//Jarom 1:26
					new VerseInfo(1, 12),//Jarom 1:27
					new VerseInfo(1, 12),//Jarom 1:28
					new VerseInfo(1, 13),//Jarom 1:29
					new VerseInfo(1, 14),//Jarom 1:30
					new VerseInfo(1, 14),//Jarom 1:31
					new VerseInfo(1, 15),//Jarom 1:32
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
					new VerseInfo(1, 2),//Omni 1:2
					new VerseInfo(1, 2),//Omni 1:3
					new VerseInfo(1, 3),//Omni 1:4
					new VerseInfo(1, 3),//Omni 1:5
					new VerseInfo(1, 4),//Omni 1:6
					new VerseInfo(1, 5),//Omni 1:7
					new VerseInfo(1, 6),//Omni 1:8
					new VerseInfo(1, 7),//Omni 1:9
					new VerseInfo(1, 8),//Omni 1:10
					new VerseInfo(1, 9),//Omni 1:11
					new VerseInfo(1, 9),//Omni 1:12
					new VerseInfo(1, 10),//Omni 1:13
					new VerseInfo(1, 10),//Omni 1:14
					new VerseInfo(1, 10),//Omni 1:15
					new VerseInfo(1, 11),//Omni 1:16
					new VerseInfo(1, 11),//Omni 1:17
					new VerseInfo(1, 12),//Omni 1:18
					new VerseInfo(1, 12),//Omni 1:19
					new VerseInfo(1, 12),//Omni 1:20
					new VerseInfo(1, 13),//Omni 1:21
					new VerseInfo(1, 13),//Omni 1:22
					new VerseInfo(1, 13),//Omni 1:23
					new VerseInfo(1, 14),//Omni 1:24
					new VerseInfo(1, 14),//Omni 1:25
					new VerseInfo(1, 15),//Omni 1:26
					new VerseInfo(1, 16),//Omni 1:27
					new VerseInfo(1, 17),//Omni 1:28
					new VerseInfo(1, 17),//Omni 1:29
					new VerseInfo(1, 17),//Omni 1:30
					new VerseInfo(1, 17),//Omni 1:31
					new VerseInfo(1, 18),//Omni 1:32
					new VerseInfo(1, 18),//Omni 1:33
					new VerseInfo(1, 19),//Omni 1:34
					new VerseInfo(1, 20),//Omni 1:35
					new VerseInfo(1, 21),//Omni 1:36
					new VerseInfo(1, 21),//Omni 1:37
					new VerseInfo(1, 22),//Omni 1:38
					new VerseInfo(1, 22),//Omni 1:39
					new VerseInfo(1, 23),//Omni 1:40
					new VerseInfo(1, 24),//Omni 1:41
					new VerseInfo(1, 24),//Omni 1:42
					new VerseInfo(1, 25),//Omni 1:43
					new VerseInfo(1, 25),//Omni 1:44
					new VerseInfo(1, 25),//Omni 1:45
					new VerseInfo(1, 26),//Omni 1:46
					new VerseInfo(1, 26),//Omni 1:47
					new VerseInfo(1, 27),//Omni 1:48
					new VerseInfo(1, 27, 1, 28),//Omni 1:49
					new VerseInfo(1, 28),//Omni 1:50
					new VerseInfo(1, 29),//Omni 1:51
					new VerseInfo(1, 30),//Omni 1:52
					new VerseInfo(1, 30),//Omni 1:53
					new VerseInfo(1, 30),//Omni 1:54
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
					new VerseInfo(1, 2),//Words of Mormon 1:2
					new VerseInfo(1, 2),//Words of Mormon 1:3
					new VerseInfo(1, 3),//Words of Mormon 1:4
					new VerseInfo(1, 3),//Words of Mormon 1:5
					new VerseInfo(1, 4),//Words of Mormon 1:6
					new VerseInfo(1, 4),//Words of Mormon 1:7
					new VerseInfo(1, 5),//Words of Mormon 1:8
					new VerseInfo(1, 6),//Words of Mormon 1:9
					new VerseInfo(1, 7),//Words of Mormon 1:10
					new VerseInfo(1, 7),//Words of Mormon 1:11
					new VerseInfo(1, 8),//Words of Mormon 1:12
					new VerseInfo(1, 9),//Words of Mormon 1:13
					new VerseInfo(1, 10),//Words of Mormon 1:14
					new VerseInfo(1, 11),//Words of Mormon 1:15
					new VerseInfo(1, 11),//Words of Mormon 1:16
					new VerseInfo(1, 11),//Words of Mormon 1:17
					new VerseInfo(1, 12),//Words of Mormon 1:18
					new VerseInfo(1, 13),//Words of Mormon 1:19
					new VerseInfo(1, 13),//Words of Mormon 1:20
					new VerseInfo(1, 14),//Words of Mormon 1:21
					new VerseInfo(1, 14),//Words of Mormon 1:22
					new VerseInfo(1, 15),//Words of Mormon 1:23
					new VerseInfo(1, 16),//Words of Mormon 1:24
					new VerseInfo(1, 16, 1, 17),//Words of Mormon 1:25
					new VerseInfo(1, 17),//Words of Mormon 1:26
					new VerseInfo(1, 18),//Words of Mormon 1:27
				},
			}
		},
		{ "Mosiah", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mosiah 1
					new VerseInfo(1, 1),//Mosiah 1:1
					new VerseInfo(1, 2),//Mosiah 1:2
					new VerseInfo(1, 2),//Mosiah 1:3
					new VerseInfo(1, 3),//Mosiah 1:4
					new VerseInfo(1, 4),//Mosiah 1:5
					new VerseInfo(1, 4),//Mosiah 1:6
					new VerseInfo(1, 5),//Mosiah 1:7
					new VerseInfo(1, 5),//Mosiah 1:8
					new VerseInfo(1, 6),//Mosiah 1:9
					new VerseInfo(1, 6),//Mosiah 1:10
					new VerseInfo(1, 7),//Mosiah 1:11
					new VerseInfo(1, 7),//Mosiah 1:12
					new VerseInfo(1, 8),//Mosiah 1:13
					new VerseInfo(1, 9),//Mosiah 1:14
					new VerseInfo(1, 10),//Mosiah 1:15
					new VerseInfo(1, 10),//Mosiah 1:16
					new VerseInfo(1, 11),//Mosiah 1:17
					new VerseInfo(1, 12),//Mosiah 1:18
					new VerseInfo(1, 13),//Mosiah 1:19
					new VerseInfo(1, 13),//Mosiah 1:20
					new VerseInfo(1, 14),//Mosiah 1:21
					new VerseInfo(1, 15),//Mosiah 1:22
					new VerseInfo(1, 16),//Mosiah 1:23
					new VerseInfo(1, 16),//Mosiah 1:24
					new VerseInfo(1, 17),//Mosiah 1:25
					new VerseInfo(1, 17),//Mosiah 1:26
					new VerseInfo(1, 18),//Mosiah 1:27
					new VerseInfo(2, 1),//Mosiah 1:28
					new VerseInfo(2, 2),//Mosiah 1:29
					new VerseInfo(2, 3),//Mosiah 1:30
					new VerseInfo(2, 4),//Mosiah 1:31
					new VerseInfo(2, 4),//Mosiah 1:32
					new VerseInfo(2, 5),//Mosiah 1:33
					new VerseInfo(2, 6),//Mosiah 1:34
					new VerseInfo(2, 7),//Mosiah 1:35
					new VerseInfo(2, 8),//Mosiah 1:36
					new VerseInfo(2, 8),//Mosiah 1:37
					new VerseInfo(2, 9),//Mosiah 1:38
					new VerseInfo(2, 9),//Mosiah 1:39
					new VerseInfo(2, 10),//Mosiah 1:40
					new VerseInfo(2, 11),//Mosiah 1:41
					new VerseInfo(2, 11),//Mosiah 1:42
					new VerseInfo(2, 12),//Mosiah 1:43
					new VerseInfo(2, 13),//Mosiah 1:44
					new VerseInfo(2, 13),//Mosiah 1:45
					new VerseInfo(2, 14),//Mosiah 1:46
					new VerseInfo(2, 15),//Mosiah 1:47
					new VerseInfo(2, 16),//Mosiah 1:48
					new VerseInfo(2, 17),//Mosiah 1:49
					new VerseInfo(2, 18),//Mosiah 1:50
					new VerseInfo(2, 19),//Mosiah 1:51
					new VerseInfo(2, 20),//Mosiah 1:52
					new VerseInfo(2, 21),//Mosiah 1:53
					new VerseInfo(2, 21),//Mosiah 1:54
					new VerseInfo(2, 22),//Mosiah 1:55
					new VerseInfo(2, 22),//Mosiah 1:56
					new VerseInfo(2, 23),//Mosiah 1:57
					new VerseInfo(2, 24),//Mosiah 1:58
					new VerseInfo(2, 24),//Mosiah 1:59
					new VerseInfo(2, 25),//Mosiah 1:60
					new VerseInfo(2, 25),//Mosiah 1:61
					new VerseInfo(2, 26),//Mosiah 1:62
					new VerseInfo(2, 26),//Mosiah 1:63
					new VerseInfo(2, 27),//Mosiah 1:64
					new VerseInfo(2, 28),//Mosiah 1:65
					new VerseInfo(2, 28),//Mosiah 1:66
					new VerseInfo(2, 29),//Mosiah 1:67
					new VerseInfo(2, 30),//Mosiah 1:68
					new VerseInfo(2, 30),//Mosiah 1:69
					new VerseInfo(2, 31),//Mosiah 1:70
					new VerseInfo(2, 31),//Mosiah 1:71
					new VerseInfo(2, 31),//Mosiah 1:72
					new VerseInfo(2, 32),//Mosiah 1:73
					new VerseInfo(2, 33),//Mosiah 1:74
					new VerseInfo(2, 33),//Mosiah 1:75
					new VerseInfo(2, 34),//Mosiah 1:76
					new VerseInfo(2, 34, 2, 35),//Mosiah 1:77
					new VerseInfo(2, 35),//Mosiah 1:78
					new VerseInfo(2, 36),//Mosiah 1:79
					new VerseInfo(2, 37),//Mosiah 1:80
					new VerseInfo(2, 37),//Mosiah 1:81
					new VerseInfo(2, 37),//Mosiah 1:82
					new VerseInfo(2, 38),//Mosiah 1:83
					new VerseInfo(2, 38),//Mosiah 1:84
					new VerseInfo(2, 39),//Mosiah 1:85
					new VerseInfo(2, 40),//Mosiah 1:86
					new VerseInfo(2, 40),//Mosiah 1:87
					new VerseInfo(2, 41),//Mosiah 1:88
					new VerseInfo(2, 41),//Mosiah 1:89
					new VerseInfo(2, 41),//Mosiah 1:90
					new VerseInfo(2, 41),//Mosiah 1:91
					new VerseInfo(3, 1),//Mosiah 1:92
					new VerseInfo(3, 1, 3, 2),//Mosiah 1:93
					new VerseInfo(3, 2),//Mosiah 1:94
					new VerseInfo(3, 3),//Mosiah 1:95
					new VerseInfo(3, 4),//Mosiah 1:96
					new VerseInfo(3, 5),//Mosiah 1:97
					new VerseInfo(3, 5),//Mosiah 1:98
					new VerseInfo(3, 6),//Mosiah 1:99
					new VerseInfo(3, 7),//Mosiah 1:100
					new VerseInfo(3, 7),//Mosiah 1:101
					new VerseInfo(3, 8),//Mosiah 1:102
					new VerseInfo(3, 9),//Mosiah 1:103
					new VerseInfo(3, 9),//Mosiah 1:104
					new VerseInfo(3, 10),//Mosiah 1:105
					new VerseInfo(3, 10),//Mosiah 1:106
					new VerseInfo(3, 11),//Mosiah 1:107
					new VerseInfo(3, 12),//Mosiah 1:108
					new VerseInfo(3, 13),//Mosiah 1:109
					new VerseInfo(3, 14),//Mosiah 1:110
					new VerseInfo(3, 15),//Mosiah 1:111
					new VerseInfo(3, 15),//Mosiah 1:112
					new VerseInfo(3, 15),//Mosiah 1:113
					new VerseInfo(3, 16),//Mosiah 1:114
					new VerseInfo(3, 16),//Mosiah 1:115
					new VerseInfo(3, 17),//Mosiah 1:116
					new VerseInfo(3, 18),//Mosiah 1:117
					new VerseInfo(3, 18),//Mosiah 1:118
					new VerseInfo(3, 19),//Mosiah 1:119
					new VerseInfo(3, 19),//Mosiah 1:120
					new VerseInfo(3, 20),//Mosiah 1:121
					new VerseInfo(3, 21),//Mosiah 1:122
					new VerseInfo(3, 22),//Mosiah 1:123
					new VerseInfo(3, 23),//Mosiah 1:124
					new VerseInfo(3, 24),//Mosiah 1:125
					new VerseInfo(3, 24),//Mosiah 1:126
					new VerseInfo(3, 25),//Mosiah 1:127
					new VerseInfo(3, 26),//Mosiah 1:128
					new VerseInfo(3, 27),//Mosiah 1:129
					new VerseInfo(3, 27),//Mosiah 1:130
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mosiah 2
					new VerseInfo(4, 1),//Mosiah 2:1
					new VerseInfo(4, 2),//Mosiah 2:2
					new VerseInfo(4, 2),//Mosiah 2:3
					new VerseInfo(4, 2),//Mosiah 2:4
					new VerseInfo(4, 3),//Mosiah 2:5
					new VerseInfo(4, 3),//Mosiah 2:6
					new VerseInfo(4, 4),//Mosiah 2:7
					new VerseInfo(4, 5),//Mosiah 2:8
					new VerseInfo(4, 6),//Mosiah 2:9
					new VerseInfo(4, 6),//Mosiah 2:10
					new VerseInfo(4, 7, 4, 8),//Mosiah 2:11
					new VerseInfo(4, 8),//Mosiah 2:12
					new VerseInfo(4, 9),//Mosiah 2:13
					new VerseInfo(4, 9),//Mosiah 2:14
					new VerseInfo(4, 9),//Mosiah 2:15
					new VerseInfo(4, 10),//Mosiah 2:16
					new VerseInfo(4, 10),//Mosiah 2:17
					new VerseInfo(4, 11),//Mosiah 2:18
					new VerseInfo(4, 11),//Mosiah 2:19
					new VerseInfo(4, 11),//Mosiah 2:20
					new VerseInfo(4, 11),//Mosiah 2:21
					new VerseInfo(4, 12),//Mosiah 2:22
					new VerseInfo(4, 12),//Mosiah 2:23
					new VerseInfo(4, 13),//Mosiah 2:24
					new VerseInfo(4, 14),//Mosiah 2:25
					new VerseInfo(4, 14),//Mosiah 2:26
					new VerseInfo(4, 15),//Mosiah 2:27
					new VerseInfo(4, 16),//Mosiah 2:28
					new VerseInfo(4, 16),//Mosiah 2:29
					new VerseInfo(4, 17),//Mosiah 2:30
					new VerseInfo(4, 18),//Mosiah 2:31
					new VerseInfo(4, 19),//Mosiah 2:32
					new VerseInfo(4, 20),//Mosiah 2:33
					new VerseInfo(4, 20),//Mosiah 2:34
					new VerseInfo(4, 20),//Mosiah 2:35
					new VerseInfo(4, 21),//Mosiah 2:36
					new VerseInfo(4, 22),//Mosiah 2:37
					new VerseInfo(4, 22),//Mosiah 2:38
					new VerseInfo(4, 23),//Mosiah 2:39
					new VerseInfo(4, 24),//Mosiah 2:40
					new VerseInfo(4, 25),//Mosiah 2:41
					new VerseInfo(4, 26),//Mosiah 2:42
					new VerseInfo(4, 26),//Mosiah 2:43
					new VerseInfo(4, 27),//Mosiah 2:44
					new VerseInfo(4, 27),//Mosiah 2:45
					new VerseInfo(4, 28),//Mosiah 2:46
					new VerseInfo(4, 28),//Mosiah 2:47
					new VerseInfo(4, 29),//Mosiah 2:48
					new VerseInfo(4, 30),//Mosiah 2:49
					new VerseInfo(4, 30),//Mosiah 2:50
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mosiah 3
					new VerseInfo(5, 1),//Mosiah 3:1
					new VerseInfo(5, 2),//Mosiah 3:2
					new VerseInfo(5, 2),//Mosiah 3:3
					new VerseInfo(5, 3),//Mosiah 3:4
					new VerseInfo(5, 4),//Mosiah 3:5
					new VerseInfo(5, 5),//Mosiah 3:6
					new VerseInfo(5, 6),//Mosiah 3:7
					new VerseInfo(5, 7),//Mosiah 3:8
					new VerseInfo(5, 7),//Mosiah 3:9
					new VerseInfo(5, 8),//Mosiah 3:10
					new VerseInfo(5, 8),//Mosiah 3:11
					new VerseInfo(5, 9),//Mosiah 3:12
					new VerseInfo(5, 10),//Mosiah 3:13
					new VerseInfo(5, 11),//Mosiah 3:14
					new VerseInfo(5, 11),//Mosiah 3:15
					new VerseInfo(5, 12),//Mosiah 3:16
					new VerseInfo(5, 13),//Mosiah 3:17
					new VerseInfo(5, 14),//Mosiah 3:18
					new VerseInfo(5, 14),//Mosiah 3:19
					new VerseInfo(5, 14),//Mosiah 3:20
					new VerseInfo(5, 15),//Mosiah 3:21
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mosiah 4
					new VerseInfo(6, 1),//Mosiah 4:1
					new VerseInfo(6, 2),//Mosiah 4:2
					new VerseInfo(6, 3),//Mosiah 4:3
					new VerseInfo(6, 3),//Mosiah 4:4
					new VerseInfo(6, 4),//Mosiah 4:5
					new VerseInfo(6, 4),//Mosiah 4:6
					new VerseInfo(6, 5),//Mosiah 4:7
					new VerseInfo(6, 6),//Mosiah 4:8
					new VerseInfo(6, 7),//Mosiah 4:9
					new VerseInfo(6, 7),//Mosiah 4:10
					new VerseInfo(6, 7),//Mosiah 4:11
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mosiah 5
					new VerseInfo(7, 1),//Mosiah 5:1
					new VerseInfo(7, 1),//Mosiah 5:2
					new VerseInfo(7, 2),//Mosiah 5:3
					new VerseInfo(7, 3),//Mosiah 5:4
					new VerseInfo(7, 4),//Mosiah 5:5
					new VerseInfo(7, 5),//Mosiah 5:6
					new VerseInfo(7, 6),//Mosiah 5:7
					new VerseInfo(7, 7),//Mosiah 5:8
					new VerseInfo(7, 7),//Mosiah 5:9
					new VerseInfo(7, 8),//Mosiah 5:10
					new VerseInfo(7, 8),//Mosiah 5:11
					new VerseInfo(7, 9),//Mosiah 5:12
					new VerseInfo(7, 10),//Mosiah 5:13
					new VerseInfo(7, 11),//Mosiah 5:14
					new VerseInfo(7, 12),//Mosiah 5:15
					new VerseInfo(7, 12, 7, 13),//Mosiah 5:16
					new VerseInfo(7, 13),//Mosiah 5:17
					new VerseInfo(7, 14),//Mosiah 5:18
					new VerseInfo(7, 14),//Mosiah 5:19
					new VerseInfo(7, 15),//Mosiah 5:20
					new VerseInfo(7, 15),//Mosiah 5:21
					new VerseInfo(7, 15),//Mosiah 5:22
					new VerseInfo(7, 16),//Mosiah 5:23
					new VerseInfo(7, 16),//Mosiah 5:24
					new VerseInfo(7, 17),//Mosiah 5:25
					new VerseInfo(7, 18),//Mosiah 5:26
					new VerseInfo(7, 18),//Mosiah 5:27
					new VerseInfo(7, 19),//Mosiah 5:28
					new VerseInfo(7, 19),//Mosiah 5:29
					new VerseInfo(7, 20),//Mosiah 5:30
					new VerseInfo(7, 20),//Mosiah 5:31
					new VerseInfo(7, 21),//Mosiah 5:32
					new VerseInfo(7, 21),//Mosiah 5:33
					new VerseInfo(7, 22),//Mosiah 5:34
					new VerseInfo(7, 22),//Mosiah 5:35
					new VerseInfo(7, 22),//Mosiah 5:36
					new VerseInfo(7, 23),//Mosiah 5:37
					new VerseInfo(7, 23),//Mosiah 5:38
					new VerseInfo(7, 23),//Mosiah 5:39
					new VerseInfo(7, 24),//Mosiah 5:40
					new VerseInfo(7, 25),//Mosiah 5:41
					new VerseInfo(7, 25),//Mosiah 5:42
					new VerseInfo(7, 26),//Mosiah 5:43
					new VerseInfo(7, 27),//Mosiah 5:44
					new VerseInfo(7, 27),//Mosiah 5:45
					new VerseInfo(7, 28),//Mosiah 5:46
					new VerseInfo(7, 28),//Mosiah 5:47
					new VerseInfo(7, 29),//Mosiah 5:48
					new VerseInfo(7, 30),//Mosiah 5:49
					new VerseInfo(7, 31),//Mosiah 5:50
					new VerseInfo(7, 32),//Mosiah 5:51
					new VerseInfo(7, 33),//Mosiah 5:52
					new VerseInfo(8, 1),//Mosiah 5:53
					new VerseInfo(8, 2),//Mosiah 5:54
					new VerseInfo(8, 3),//Mosiah 5:55
					new VerseInfo(8, 4),//Mosiah 5:56
					new VerseInfo(8, 5),//Mosiah 5:57
					new VerseInfo(8, 6),//Mosiah 5:58
					new VerseInfo(8, 6),//Mosiah 5:59
					new VerseInfo(8, 7),//Mosiah 5:60
					new VerseInfo(8, 8),//Mosiah 5:61
					new VerseInfo(8, 8),//Mosiah 5:62
					new VerseInfo(8, 8),//Mosiah 5:63
					new VerseInfo(8, 9),//Mosiah 5:64
					new VerseInfo(8, 10),//Mosiah 5:65
					new VerseInfo(8, 11),//Mosiah 5:66
					new VerseInfo(8, 11),//Mosiah 5:67
					new VerseInfo(8, 11),//Mosiah 5:68
					new VerseInfo(8, 12),//Mosiah 5:69
					new VerseInfo(8, 12),//Mosiah 5:70
					new VerseInfo(8, 12),//Mosiah 5:71
					new VerseInfo(8, 13),//Mosiah 5:72
					new VerseInfo(8, 13),//Mosiah 5:73
					new VerseInfo(8, 13),//Mosiah 5:74
					new VerseInfo(8, 14),//Mosiah 5:75
					new VerseInfo(8, 15),//Mosiah 5:76
					new VerseInfo(8, 16),//Mosiah 5:77
					new VerseInfo(8, 17),//Mosiah 5:78
					new VerseInfo(8, 17),//Mosiah 5:79
					new VerseInfo(8, 17),//Mosiah 5:80
					new VerseInfo(8, 18),//Mosiah 5:81
					new VerseInfo(8, 19),//Mosiah 5:82
					new VerseInfo(8, 19),//Mosiah 5:83
					new VerseInfo(8, 20),//Mosiah 5:84
					new VerseInfo(8, 20),//Mosiah 5:85
					new VerseInfo(8, 21),//Mosiah 5:86
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mosiah 6
					new VerseInfo(9, 1),//Mosiah 6:1
					new VerseInfo(9, 1, 9, 2),//Mosiah 6:2
					new VerseInfo(9, 2),//Mosiah 6:3
					new VerseInfo(9, 2),//Mosiah 6:4
					new VerseInfo(9, 2),//Mosiah 6:5
					new VerseInfo(9, 3),//Mosiah 6:6
					new VerseInfo(9, 4),//Mosiah 6:7
					new VerseInfo(9, 5),//Mosiah 6:8
					new VerseInfo(9, 6),//Mosiah 6:9
					new VerseInfo(9, 7),//Mosiah 6:10
					new VerseInfo(9, 8),//Mosiah 6:11
					new VerseInfo(9, 9),//Mosiah 6:12
					new VerseInfo(9, 10),//Mosiah 6:13
					new VerseInfo(9, 11),//Mosiah 6:14
					new VerseInfo(9, 12),//Mosiah 6:15
					new VerseInfo(9, 13),//Mosiah 6:16
					new VerseInfo(9, 14),//Mosiah 6:17
					new VerseInfo(9, 15),//Mosiah 6:18
					new VerseInfo(9, 16),//Mosiah 6:19
					new VerseInfo(9, 17),//Mosiah 6:20
					new VerseInfo(9, 17),//Mosiah 6:21
					new VerseInfo(9, 18),//Mosiah 6:22
					new VerseInfo(9, 18),//Mosiah 6:23
					new VerseInfo(9, 19),//Mosiah 6:24
					new VerseInfo(9, 19),//Mosiah 6:25
					new VerseInfo(10, 1),//Mosiah 6:26
					new VerseInfo(10, 1),//Mosiah 6:27
					new VerseInfo(10, 2),//Mosiah 6:28
					new VerseInfo(10, 2),//Mosiah 6:29
					new VerseInfo(10, 3),//Mosiah 6:30
					new VerseInfo(10, 4),//Mosiah 6:31
					new VerseInfo(10, 5),//Mosiah 6:32
					new VerseInfo(10, 5),//Mosiah 6:33
					new VerseInfo(10, 6),//Mosiah 6:34
					new VerseInfo(10, 6),//Mosiah 6:35
					new VerseInfo(10, 7),//Mosiah 6:36
					new VerseInfo(10, 8),//Mosiah 6:37
					new VerseInfo(10, 8),//Mosiah 6:38
					new VerseInfo(10, 9),//Mosiah 6:39
					new VerseInfo(10, 9),//Mosiah 6:40
					new VerseInfo(10, 10),//Mosiah 6:41
					new VerseInfo(10, 10),//Mosiah 6:42
					new VerseInfo(10, 10),//Mosiah 6:43
					new VerseInfo(10, 11),//Mosiah 6:44
					new VerseInfo(10, 11, 10, 12),//Mosiah 6:45
					new VerseInfo(10, 12),//Mosiah 6:46
					new VerseInfo(10, 13),//Mosiah 6:47
					new VerseInfo(10, 13),//Mosiah 6:48
					new VerseInfo(10, 14),//Mosiah 6:49
					new VerseInfo(10, 14),//Mosiah 6:50
					new VerseInfo(10, 15),//Mosiah 6:51
					new VerseInfo(10, 16),//Mosiah 6:52
					new VerseInfo(10, 17),//Mosiah 6:53
					new VerseInfo(10, 18),//Mosiah 6:54
					new VerseInfo(10, 19),//Mosiah 6:55
					new VerseInfo(10, 20),//Mosiah 6:56
					new VerseInfo(10, 21),//Mosiah 6:57
					new VerseInfo(10, 22),//Mosiah 6:58
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Mosiah 7
					new VerseInfo(11, 1),//Mosiah 7:1
					new VerseInfo(11, 2),//Mosiah 7:2
					new VerseInfo(11, 2),//Mosiah 7:3
					new VerseInfo(11, 2),//Mosiah 7:4
					new VerseInfo(11, 2),//Mosiah 7:5
					new VerseInfo(11, 3),//Mosiah 7:6
					new VerseInfo(11, 4),//Mosiah 7:7
					new VerseInfo(11, 5),//Mosiah 7:8
					new VerseInfo(11, 6),//Mosiah 7:9
					new VerseInfo(11, 7),//Mosiah 7:10
					new VerseInfo(11, 8),//Mosiah 7:11
					new VerseInfo(11, 9),//Mosiah 7:12
					new VerseInfo(11, 10),//Mosiah 7:13
					new VerseInfo(11, 11),//Mosiah 7:14
					new VerseInfo(11, 11),//Mosiah 7:15
					new VerseInfo(11, 12),//Mosiah 7:16
					new VerseInfo(11, 13),//Mosiah 7:17
					new VerseInfo(11, 13),//Mosiah 7:18
					new VerseInfo(11, 13),//Mosiah 7:19
					new VerseInfo(11, 14),//Mosiah 7:20
					new VerseInfo(11, 15),//Mosiah 7:21
					new VerseInfo(11, 16),//Mosiah 7:22
					new VerseInfo(11, 17),//Mosiah 7:23
					new VerseInfo(11, 17),//Mosiah 7:24
					new VerseInfo(11, 18),//Mosiah 7:25
					new VerseInfo(11, 19),//Mosiah 7:26
					new VerseInfo(11, 19),//Mosiah 7:27
					new VerseInfo(11, 20),//Mosiah 7:28
					new VerseInfo(11, 20),//Mosiah 7:29
					new VerseInfo(11, 20),//Mosiah 7:30
					new VerseInfo(11, 20),//Mosiah 7:31
					new VerseInfo(11, 21),//Mosiah 7:32
					new VerseInfo(11, 21),//Mosiah 7:33
					new VerseInfo(11, 22),//Mosiah 7:34
					new VerseInfo(11, 23),//Mosiah 7:35
					new VerseInfo(11, 24),//Mosiah 7:36
					new VerseInfo(11, 25),//Mosiah 7:37
					new VerseInfo(11, 25),//Mosiah 7:38
					new VerseInfo(11, 26),//Mosiah 7:39
					new VerseInfo(11, 27),//Mosiah 7:40
					new VerseInfo(11, 27),//Mosiah 7:41
					new VerseInfo(11, 28),//Mosiah 7:42
					new VerseInfo(11, 29),//Mosiah 7:43
					new VerseInfo(11, 29),//Mosiah 7:44
					new VerseInfo(12, 1),//Mosiah 7:45
					new VerseInfo(12, 1),//Mosiah 7:46
					new VerseInfo(12, 1, 12, 2),//Mosiah 7:47
					new VerseInfo(12, 2),//Mosiah 7:48
					new VerseInfo(12, 2),//Mosiah 7:49
					new VerseInfo(12, 3),//Mosiah 7:50
					new VerseInfo(12, 4),//Mosiah 7:51
					new VerseInfo(12, 5),//Mosiah 7:52
					new VerseInfo(12, 6),//Mosiah 7:53
					new VerseInfo(12, 7),//Mosiah 7:54
					new VerseInfo(12, 8),//Mosiah 7:55
					new VerseInfo(12, 8),//Mosiah 7:56
					new VerseInfo(12, 8),//Mosiah 7:57
					new VerseInfo(12, 8),//Mosiah 7:58
					new VerseInfo(12, 9),//Mosiah 7:59
					new VerseInfo(12, 9),//Mosiah 7:60
					new VerseInfo(12, 10),//Mosiah 7:61
					new VerseInfo(12, 11),//Mosiah 7:62
					new VerseInfo(12, 12),//Mosiah 7:63
					new VerseInfo(12, 12),//Mosiah 7:64
					new VerseInfo(12, 13),//Mosiah 7:65
					new VerseInfo(12, 14),//Mosiah 7:66
					new VerseInfo(12, 15),//Mosiah 7:67
					new VerseInfo(12, 16),//Mosiah 7:68
					new VerseInfo(12, 17),//Mosiah 7:69
					new VerseInfo(12, 17),//Mosiah 7:70
					new VerseInfo(12, 18),//Mosiah 7:71
					new VerseInfo(12, 18),//Mosiah 7:72
					new VerseInfo(12, 19),//Mosiah 7:73
					new VerseInfo(12, 19),//Mosiah 7:74
					new VerseInfo(12, 19),//Mosiah 7:75
					new VerseInfo(12, 20),//Mosiah 7:76
					new VerseInfo(12, 21),//Mosiah 7:77
					new VerseInfo(12, 22),//Mosiah 7:78
					new VerseInfo(12, 23),//Mosiah 7:79
					new VerseInfo(12, 24),//Mosiah 7:80
					new VerseInfo(12, 25),//Mosiah 7:81
					new VerseInfo(12, 26),//Mosiah 7:82
					new VerseInfo(12, 27),//Mosiah 7:83
					new VerseInfo(12, 28),//Mosiah 7:84
					new VerseInfo(12, 29),//Mosiah 7:85
					new VerseInfo(12, 29),//Mosiah 7:86
					new VerseInfo(12, 29),//Mosiah 7:87
					new VerseInfo(12, 30),//Mosiah 7:88
					new VerseInfo(12, 30),//Mosiah 7:89
					new VerseInfo(12, 31),//Mosiah 7:90
					new VerseInfo(12, 31),//Mosiah 7:91
					new VerseInfo(12, 31),//Mosiah 7:92
					new VerseInfo(12, 32),//Mosiah 7:93
					new VerseInfo(12, 33),//Mosiah 7:94
					new VerseInfo(12, 33, 12, 34),//Mosiah 7:95
					new VerseInfo(12, 35),//Mosiah 7:96
					new VerseInfo(12, 36),//Mosiah 7:97
					new VerseInfo(12, 37),//Mosiah 7:98
					new VerseInfo(12, 37),//Mosiah 7:99
					new VerseInfo(13, 1),//Mosiah 7:100
					new VerseInfo(13, 2, 13, 3),//Mosiah 7:101
					new VerseInfo(13, 3),//Mosiah 7:102
					new VerseInfo(13, 4),//Mosiah 7:103
					new VerseInfo(13, 4),//Mosiah 7:104
					new VerseInfo(13, 5),//Mosiah 7:105
					new VerseInfo(13, 5),//Mosiah 7:106
					new VerseInfo(13, 6, 13, 7),//Mosiah 7:107
					new VerseInfo(13, 7, 13, 8),//Mosiah 7:108
					new VerseInfo(13, 9),//Mosiah 7:109
					new VerseInfo(13, 10),//Mosiah 7:110
					new VerseInfo(13, 11),//Mosiah 7:111
					new VerseInfo(13, 11),//Mosiah 7:112
					new VerseInfo(13, 12),//Mosiah 7:113
					new VerseInfo(13, 13, 13, 14),//Mosiah 7:114
					new VerseInfo(13, 15),//Mosiah 7:115
					new VerseInfo(13, 16),//Mosiah 7:116
					new VerseInfo(13, 17, 13, 18),//Mosiah 7:117
					new VerseInfo(13, 19),//Mosiah 7:118
					new VerseInfo(13, 20),//Mosiah 7:119
					new VerseInfo(13, 21),//Mosiah 7:120
					new VerseInfo(13, 22),//Mosiah 7:121
					new VerseInfo(13, 22),//Mosiah 7:122
					new VerseInfo(13, 23),//Mosiah 7:123
					new VerseInfo(13, 24),//Mosiah 7:124
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Mosiah 8
					new VerseInfo(13, 25),//Mosiah 8:1
					new VerseInfo(13, 26),//Mosiah 8:2
					new VerseInfo(13, 27),//Mosiah 8:3
					new VerseInfo(13, 27),//Mosiah 8:4
					new VerseInfo(13, 28),//Mosiah 8:5
					new VerseInfo(13, 29),//Mosiah 8:6
					new VerseInfo(13, 30),//Mosiah 8:7
					new VerseInfo(13, 31),//Mosiah 8:8
					new VerseInfo(13, 32),//Mosiah 8:9
					new VerseInfo(13, 32),//Mosiah 8:10
					new VerseInfo(13, 33),//Mosiah 8:11
					new VerseInfo(13, 33),//Mosiah 8:12
					new VerseInfo(13, 34),//Mosiah 8:13
					new VerseInfo(13, 35),//Mosiah 8:14
					new VerseInfo(14, 1),//Mosiah 8:15
					new VerseInfo(14, 1),//Mosiah 8:16
					new VerseInfo(14, 2),//Mosiah 8:17
					new VerseInfo(14, 3),//Mosiah 8:18
					new VerseInfo(14, 4),//Mosiah 8:19
					new VerseInfo(14, 5),//Mosiah 8:20
					new VerseInfo(14, 6),//Mosiah 8:21
					new VerseInfo(14, 7),//Mosiah 8:22
					new VerseInfo(14, 8),//Mosiah 8:23
					new VerseInfo(14, 9),//Mosiah 8:24
					new VerseInfo(14, 10),//Mosiah 8:25
					new VerseInfo(14, 11),//Mosiah 8:26
					new VerseInfo(14, 12),//Mosiah 8:27
					new VerseInfo(15, 1),//Mosiah 8:28
					new VerseInfo(15, 2),//Mosiah 8:29
					new VerseInfo(15, 2, 15, 3),//Mosiah 8:30
					new VerseInfo(15, 4),//Mosiah 8:31
					new VerseInfo(15, 5),//Mosiah 8:32
					new VerseInfo(15, 6),//Mosiah 8:33
					new VerseInfo(15, 7),//Mosiah 8:34
					new VerseInfo(15, 8),//Mosiah 8:35
					new VerseInfo(15, 9),//Mosiah 8:36
					new VerseInfo(15, 9),//Mosiah 8:37
					new VerseInfo(15, 10),//Mosiah 8:38
					new VerseInfo(15, 10),//Mosiah 8:39
					new VerseInfo(15, 10),//Mosiah 8:40
					new VerseInfo(15, 11),//Mosiah 8:41
					new VerseInfo(15, 11),//Mosiah 8:42
					new VerseInfo(15, 11),//Mosiah 8:43
					new VerseInfo(15, 12),//Mosiah 8:44
					new VerseInfo(15, 12),//Mosiah 8:45
					new VerseInfo(15, 13),//Mosiah 8:46
					new VerseInfo(15, 13, 15, 14),//Mosiah 8:47
					new VerseInfo(15, 15),//Mosiah 8:48
					new VerseInfo(15, 16),//Mosiah 8:49
					new VerseInfo(15, 17),//Mosiah 8:50
					new VerseInfo(15, 18),//Mosiah 8:51
					new VerseInfo(15, 18),//Mosiah 8:52
					new VerseInfo(15, 19),//Mosiah 8:53
					new VerseInfo(15, 20),//Mosiah 8:54
					new VerseInfo(15, 21),//Mosiah 8:55
					new VerseInfo(15, 22),//Mosiah 8:56
					new VerseInfo(15, 23),//Mosiah 8:57
					new VerseInfo(15, 24),//Mosiah 8:58
					new VerseInfo(15, 24),//Mosiah 8:59
					new VerseInfo(15, 25),//Mosiah 8:60
					new VerseInfo(15, 26),//Mosiah 8:61
					new VerseInfo(15, 26),//Mosiah 8:62
					new VerseInfo(15, 27),//Mosiah 8:63
					new VerseInfo(15, 27),//Mosiah 8:64
					new VerseInfo(15, 27),//Mosiah 8:65
					new VerseInfo(15, 28),//Mosiah 8:66
					new VerseInfo(15, 29),//Mosiah 8:67
					new VerseInfo(15, 30),//Mosiah 8:68
					new VerseInfo(15, 31),//Mosiah 8:69
					new VerseInfo(16, 1),//Mosiah 8:70
					new VerseInfo(16, 1),//Mosiah 8:71
					new VerseInfo(16, 2),//Mosiah 8:72
					new VerseInfo(16, 2, 16, 3),//Mosiah 8:73
					new VerseInfo(16, 3),//Mosiah 8:74
					new VerseInfo(16, 3),//Mosiah 8:75
					new VerseInfo(16, 4),//Mosiah 8:76
					new VerseInfo(16, 5),//Mosiah 8:77
					new VerseInfo(16, 5),//Mosiah 8:78
					new VerseInfo(16, 6),//Mosiah 8:79
					new VerseInfo(16, 7),//Mosiah 8:80
					new VerseInfo(16, 8),//Mosiah 8:81
					new VerseInfo(16, 9),//Mosiah 8:82
					new VerseInfo(16, 10),//Mosiah 8:83
					new VerseInfo(16, 11),//Mosiah 8:84
					new VerseInfo(16, 11),//Mosiah 8:85
					new VerseInfo(16, 12),//Mosiah 8:86
					new VerseInfo(16, 12),//Mosiah 8:87
					new VerseInfo(16, 12),//Mosiah 8:88
					new VerseInfo(16, 13),//Mosiah 8:89
					new VerseInfo(16, 14),//Mosiah 8:90
					new VerseInfo(16, 15),//Mosiah 8:91
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mosiah 9
					new VerseInfo(17, 1),//Mosiah 9:1
					new VerseInfo(17, 2),//Mosiah 9:2
					new VerseInfo(17, 2),//Mosiah 9:3
					new VerseInfo(17, 2),//Mosiah 9:4
					new VerseInfo(17, 3),//Mosiah 9:5
					new VerseInfo(17, 4),//Mosiah 9:6
					new VerseInfo(17, 4),//Mosiah 9:7
					new VerseInfo(17, 5),//Mosiah 9:8
					new VerseInfo(17, 6),//Mosiah 9:9
					new VerseInfo(17, 7),//Mosiah 9:10
					new VerseInfo(17, 8),//Mosiah 9:11
					new VerseInfo(17, 8),//Mosiah 9:12
					new VerseInfo(17, 9),//Mosiah 9:13
					new VerseInfo(17, 9),//Mosiah 9:14
					new VerseInfo(17, 10),//Mosiah 9:15
					new VerseInfo(17, 10),//Mosiah 9:16
					new VerseInfo(17, 11),//Mosiah 9:17
					new VerseInfo(17, 12),//Mosiah 9:18
					new VerseInfo(17, 12),//Mosiah 9:19
					new VerseInfo(17, 13),//Mosiah 9:20
					new VerseInfo(17, 14, 17, 15),//Mosiah 9:21
					new VerseInfo(17, 16),//Mosiah 9:22
					new VerseInfo(17, 17),//Mosiah 9:23
					new VerseInfo(17, 18),//Mosiah 9:24
					new VerseInfo(17, 19),//Mosiah 9:25
					new VerseInfo(17, 19),//Mosiah 9:26
					new VerseInfo(17, 20),//Mosiah 9:27
					new VerseInfo(18, 1),//Mosiah 9:28
					new VerseInfo(18, 2),//Mosiah 9:29
					new VerseInfo(18, 3),//Mosiah 9:30
					new VerseInfo(18, 3),//Mosiah 9:31
					new VerseInfo(18, 4),//Mosiah 9:32
					new VerseInfo(18, 5),//Mosiah 9:33
					new VerseInfo(18, 6),//Mosiah 9:34
					new VerseInfo(18, 7),//Mosiah 9:35
					new VerseInfo(18, 7),//Mosiah 9:36
					new VerseInfo(18, 7),//Mosiah 9:37
					new VerseInfo(18, 8),//Mosiah 9:38
					new VerseInfo(18, 8),//Mosiah 9:39
					new VerseInfo(18, 9),//Mosiah 9:40
					new VerseInfo(18, 10),//Mosiah 9:41
					new VerseInfo(18, 11),//Mosiah 9:42
					new VerseInfo(18, 12),//Mosiah 9:43
					new VerseInfo(18, 13),//Mosiah 9:44
					new VerseInfo(18, 14),//Mosiah 9:45
					new VerseInfo(18, 15),//Mosiah 9:46
					new VerseInfo(18, 16),//Mosiah 9:47
					new VerseInfo(18, 16),//Mosiah 9:48
					new VerseInfo(18, 17),//Mosiah 9:49
					new VerseInfo(18, 17),//Mosiah 9:50
					new VerseInfo(18, 18),//Mosiah 9:51
					new VerseInfo(18, 19),//Mosiah 9:52
					new VerseInfo(18, 20),//Mosiah 9:53
					new VerseInfo(18, 21),//Mosiah 9:54
					new VerseInfo(18, 22),//Mosiah 9:55
					new VerseInfo(18, 23),//Mosiah 9:56
					new VerseInfo(18, 24),//Mosiah 9:57
					new VerseInfo(18, 25),//Mosiah 9:58
					new VerseInfo(18, 26),//Mosiah 9:59
					new VerseInfo(18, 27),//Mosiah 9:60
					new VerseInfo(18, 27),//Mosiah 9:61
					new VerseInfo(18, 28),//Mosiah 9:62
					new VerseInfo(18, 29),//Mosiah 9:63
					new VerseInfo(18, 29),//Mosiah 9:64
					new VerseInfo(18, 30),//Mosiah 9:65
					new VerseInfo(18, 30),//Mosiah 9:66
					new VerseInfo(18, 30),//Mosiah 9:67
					new VerseInfo(18, 31),//Mosiah 9:68
					new VerseInfo(18, 32),//Mosiah 9:69
					new VerseInfo(18, 32),//Mosiah 9:70
					new VerseInfo(18, 33),//Mosiah 9:71
					new VerseInfo(18, 34),//Mosiah 9:72
					new VerseInfo(18, 35),//Mosiah 9:73
					new VerseInfo(19, 1),//Mosiah 9:74
					new VerseInfo(19, 2),//Mosiah 9:75
					new VerseInfo(19, 3),//Mosiah 9:76
					new VerseInfo(19, 4),//Mosiah 9:77
					new VerseInfo(19, 5),//Mosiah 9:78
					new VerseInfo(19, 6),//Mosiah 9:79
					new VerseInfo(19, 7),//Mosiah 9:80
					new VerseInfo(19, 8),//Mosiah 9:81
					new VerseInfo(19, 9),//Mosiah 9:82
					new VerseInfo(19, 10),//Mosiah 9:83
					new VerseInfo(19, 11),//Mosiah 9:84
					new VerseInfo(19, 12),//Mosiah 9:85
					new VerseInfo(19, 12),//Mosiah 9:86
					new VerseInfo(19, 13),//Mosiah 9:87
					new VerseInfo(19, 14),//Mosiah 9:88
					new VerseInfo(19, 15),//Mosiah 9:89
					new VerseInfo(19, 15),//Mosiah 9:90
					new VerseInfo(19, 16),//Mosiah 9:91
					new VerseInfo(19, 17),//Mosiah 9:92
					new VerseInfo(19, 18),//Mosiah 9:93
					new VerseInfo(19, 18),//Mosiah 9:94
					new VerseInfo(19, 19),//Mosiah 9:95
					new VerseInfo(19, 20),//Mosiah 9:96
					new VerseInfo(19, 21),//Mosiah 9:97
					new VerseInfo(19, 22),//Mosiah 9:98
					new VerseInfo(19, 22),//Mosiah 9:99
					new VerseInfo(19, 23),//Mosiah 9:100
					new VerseInfo(19, 24),//Mosiah 9:101
					new VerseInfo(19, 25),//Mosiah 9:102
					new VerseInfo(19, 26),//Mosiah 9:103
					new VerseInfo(19, 27),//Mosiah 9:104
					new VerseInfo(19, 28),//Mosiah 9:105
					new VerseInfo(19, 28),//Mosiah 9:106
					new VerseInfo(19, 29),//Mosiah 9:107
					new VerseInfo(20, 1),//Mosiah 9:108
					new VerseInfo(20, 2),//Mosiah 9:109
					new VerseInfo(20, 3),//Mosiah 9:110
					new VerseInfo(20, 4, 20, 5),//Mosiah 9:111
					new VerseInfo(20, 5),//Mosiah 9:112
					new VerseInfo(20, 6),//Mosiah 9:113
					new VerseInfo(20, 7),//Mosiah 9:114
					new VerseInfo(20, 8),//Mosiah 9:115
					new VerseInfo(20, 9),//Mosiah 9:116
					new VerseInfo(20, 10),//Mosiah 9:117
					new VerseInfo(20, 11),//Mosiah 9:118
					new VerseInfo(20, 11),//Mosiah 9:119
					new VerseInfo(20, 12),//Mosiah 9:120
					new VerseInfo(20, 13),//Mosiah 9:121
					new VerseInfo(20, 14),//Mosiah 9:122
					new VerseInfo(20, 14),//Mosiah 9:123
					new VerseInfo(20, 14),//Mosiah 9:124
					new VerseInfo(20, 15),//Mosiah 9:125
					new VerseInfo(20, 16),//Mosiah 9:126
					new VerseInfo(20, 16),//Mosiah 9:127
					new VerseInfo(20, 17),//Mosiah 9:128
					new VerseInfo(20, 18),//Mosiah 9:129
					new VerseInfo(20, 18),//Mosiah 9:130
					new VerseInfo(20, 19),//Mosiah 9:131
					new VerseInfo(20, 20),//Mosiah 9:132
					new VerseInfo(20, 21),//Mosiah 9:133
					new VerseInfo(20, 22),//Mosiah 9:134
					new VerseInfo(20, 23),//Mosiah 9:135
					new VerseInfo(20, 24),//Mosiah 9:136
					new VerseInfo(20, 25),//Mosiah 9:137
					new VerseInfo(20, 25),//Mosiah 9:138
					new VerseInfo(20, 26),//Mosiah 9:139
					new VerseInfo(21, 1),//Mosiah 9:140
					new VerseInfo(21, 2),//Mosiah 9:141
					new VerseInfo(21, 3, 21, 4),//Mosiah 9:142
					new VerseInfo(21, 5),//Mosiah 9:143
					new VerseInfo(21, 6),//Mosiah 9:144
					new VerseInfo(21, 6),//Mosiah 9:145
					new VerseInfo(21, 7),//Mosiah 9:146
					new VerseInfo(21, 8),//Mosiah 9:147
					new VerseInfo(21, 9),//Mosiah 9:148
					new VerseInfo(21, 10),//Mosiah 9:149
					new VerseInfo(21, 11),//Mosiah 9:150
					new VerseInfo(21, 11),//Mosiah 9:151
					new VerseInfo(21, 12),//Mosiah 9:152
					new VerseInfo(21, 13),//Mosiah 9:153
					new VerseInfo(21, 14),//Mosiah 9:154
					new VerseInfo(21, 15),//Mosiah 9:155
					new VerseInfo(21, 15),//Mosiah 9:156
					new VerseInfo(21, 16),//Mosiah 9:157
					new VerseInfo(21, 17),//Mosiah 9:158
					new VerseInfo(21, 18),//Mosiah 9:159
					new VerseInfo(21, 19),//Mosiah 9:160
					new VerseInfo(21, 20),//Mosiah 9:161
					new VerseInfo(21, 21),//Mosiah 9:162
					new VerseInfo(21, 22),//Mosiah 9:163
					new VerseInfo(21, 23),//Mosiah 9:164
					new VerseInfo(21, 23, 21, 24),//Mosiah 9:165
					new VerseInfo(21, 25),//Mosiah 9:166
					new VerseInfo(21, 26),//Mosiah 9:167
					new VerseInfo(21, 26),//Mosiah 9:168
					new VerseInfo(21, 27),//Mosiah 9:169
					new VerseInfo(21, 28),//Mosiah 9:170
					new VerseInfo(21, 29, 21, 30),//Mosiah 9:171
					new VerseInfo(21, 30),//Mosiah 9:172
					new VerseInfo(21, 31),//Mosiah 9:173
					new VerseInfo(21, 31),//Mosiah 9:174
					new VerseInfo(21, 32),//Mosiah 9:175
					new VerseInfo(21, 33),//Mosiah 9:176
					new VerseInfo(21, 33, 21, 34),//Mosiah 9:177
					new VerseInfo(21, 34),//Mosiah 9:178
					new VerseInfo(21, 35),//Mosiah 9:179
					new VerseInfo(21, 35),//Mosiah 9:180
					new VerseInfo(21, 36),//Mosiah 9:181
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mosiah 10
					new VerseInfo(22, 1),//Mosiah 10:1
					new VerseInfo(22, 1),//Mosiah 10:2
					new VerseInfo(22, 2),//Mosiah 10:3
					new VerseInfo(22, 2),//Mosiah 10:4
					new VerseInfo(22, 3),//Mosiah 10:5
					new VerseInfo(22, 4),//Mosiah 10:6
					new VerseInfo(22, 5),//Mosiah 10:7
					new VerseInfo(22, 5, 22, 6),//Mosiah 10:8
					new VerseInfo(22, 6),//Mosiah 10:9
					new VerseInfo(22, 7),//Mosiah 10:10
					new VerseInfo(22, 8),//Mosiah 10:11
					new VerseInfo(22, 9),//Mosiah 10:12
					new VerseInfo(22, 10),//Mosiah 10:13
					new VerseInfo(22, 11),//Mosiah 10:14
					new VerseInfo(22, 12),//Mosiah 10:15
					new VerseInfo(22, 13),//Mosiah 10:16
					new VerseInfo(22, 14),//Mosiah 10:17
					new VerseInfo(22, 15),//Mosiah 10:18
					new VerseInfo(22, 16),//Mosiah 10:19
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mosiah 11
					new VerseInfo(23, 1),//Mosiah 11:1
					new VerseInfo(23, 2),//Mosiah 11:2
					new VerseInfo(23, 3),//Mosiah 11:3
					new VerseInfo(23, 4),//Mosiah 11:4
					new VerseInfo(23, 5),//Mosiah 11:5
					new VerseInfo(23, 6),//Mosiah 11:6
					new VerseInfo(23, 7),//Mosiah 11:7
					new VerseInfo(23, 8),//Mosiah 11:8
					new VerseInfo(23, 9),//Mosiah 11:9
					new VerseInfo(23, 10),//Mosiah 11:10
					new VerseInfo(23, 11),//Mosiah 11:11
					new VerseInfo(23, 12),//Mosiah 11:12
					new VerseInfo(23, 13),//Mosiah 11:13
					new VerseInfo(23, 13),//Mosiah 11:14
					new VerseInfo(23, 14),//Mosiah 11:15
					new VerseInfo(23, 15),//Mosiah 11:16
					new VerseInfo(23, 16),//Mosiah 11:17
					new VerseInfo(23, 17),//Mosiah 11:18
					new VerseInfo(23, 17),//Mosiah 11:19
					new VerseInfo(23, 18),//Mosiah 11:20
					new VerseInfo(23, 19),//Mosiah 11:21
					new VerseInfo(23, 20),//Mosiah 11:22
					new VerseInfo(23, 21),//Mosiah 11:23
					new VerseInfo(23, 22),//Mosiah 11:24
					new VerseInfo(23, 22),//Mosiah 11:25
					new VerseInfo(23, 23),//Mosiah 11:26
					new VerseInfo(23, 24),//Mosiah 11:27
					new VerseInfo(23, 25),//Mosiah 11:28
					new VerseInfo(23, 26),//Mosiah 11:29
					new VerseInfo(23, 27),//Mosiah 11:30
					new VerseInfo(23, 28),//Mosiah 11:31
					new VerseInfo(23, 29),//Mosiah 11:32
					new VerseInfo(23, 29),//Mosiah 11:33
					new VerseInfo(23, 30),//Mosiah 11:34
					new VerseInfo(23, 31),//Mosiah 11:35
					new VerseInfo(23, 32),//Mosiah 11:36
					new VerseInfo(23, 33),//Mosiah 11:37
					new VerseInfo(23, 34),//Mosiah 11:38
					new VerseInfo(23, 35),//Mosiah 11:39
					new VerseInfo(23, 36),//Mosiah 11:40
					new VerseInfo(23, 37),//Mosiah 11:41
					new VerseInfo(23, 38),//Mosiah 11:42
					new VerseInfo(23, 39),//Mosiah 11:43
					new VerseInfo(24, 1),//Mosiah 11:44
					new VerseInfo(24, 1),//Mosiah 11:45
					new VerseInfo(24, 2),//Mosiah 11:46
					new VerseInfo(24, 3),//Mosiah 11:47
					new VerseInfo(24, 3, 24, 4),//Mosiah 11:48
					new VerseInfo(24, 4),//Mosiah 11:49
					new VerseInfo(24, 5),//Mosiah 11:50
					new VerseInfo(24, 5, 24, 6),//Mosiah 11:51
					new VerseInfo(24, 7),//Mosiah 11:52
					new VerseInfo(24, 7),//Mosiah 11:53
					new VerseInfo(24, 8),//Mosiah 11:54
					new VerseInfo(24, 9),//Mosiah 11:55
					new VerseInfo(24, 9),//Mosiah 11:56
					new VerseInfo(24, 10),//Mosiah 11:57
					new VerseInfo(24, 11),//Mosiah 11:58
					new VerseInfo(24, 12),//Mosiah 11:59
					new VerseInfo(24, 13),//Mosiah 11:60
					new VerseInfo(24, 14),//Mosiah 11:61
					new VerseInfo(24, 14),//Mosiah 11:62
					new VerseInfo(24, 15),//Mosiah 11:63
					new VerseInfo(24, 15),//Mosiah 11:64
					new VerseInfo(24, 16),//Mosiah 11:65
					new VerseInfo(24, 17),//Mosiah 11:66
					new VerseInfo(24, 18),//Mosiah 11:67
					new VerseInfo(24, 19),//Mosiah 11:68
					new VerseInfo(24, 20),//Mosiah 11:69
					new VerseInfo(24, 21),//Mosiah 11:70
					new VerseInfo(24, 21),//Mosiah 11:71
					new VerseInfo(24, 22),//Mosiah 11:72
					new VerseInfo(24, 23),//Mosiah 11:73
					new VerseInfo(24, 23),//Mosiah 11:74
					new VerseInfo(24, 24),//Mosiah 11:75
					new VerseInfo(24, 25),//Mosiah 11:76
					new VerseInfo(25, 1),//Mosiah 11:77
					new VerseInfo(25, 2),//Mosiah 11:78
					new VerseInfo(25, 3),//Mosiah 11:79
					new VerseInfo(25, 4),//Mosiah 11:80
					new VerseInfo(25, 5),//Mosiah 11:81
					new VerseInfo(25, 6),//Mosiah 11:82
					new VerseInfo(25, 7, 25, 8),//Mosiah 11:83
					new VerseInfo(25, 8),//Mosiah 11:84
					new VerseInfo(25, 9),//Mosiah 11:85
					new VerseInfo(25, 10),//Mosiah 11:86
					new VerseInfo(25, 11),//Mosiah 11:87
					new VerseInfo(25, 12),//Mosiah 11:88
					new VerseInfo(25, 12),//Mosiah 11:89
					new VerseInfo(25, 13),//Mosiah 11:90
					new VerseInfo(25, 14),//Mosiah 11:91
					new VerseInfo(25, 15),//Mosiah 11:92
					new VerseInfo(25, 16),//Mosiah 11:93
					new VerseInfo(25, 17),//Mosiah 11:94
					new VerseInfo(25, 18),//Mosiah 11:95
					new VerseInfo(25, 18),//Mosiah 11:96
					new VerseInfo(25, 19),//Mosiah 11:97
					new VerseInfo(25, 20, 25, 21),//Mosiah 11:98
					new VerseInfo(25, 21),//Mosiah 11:99
					new VerseInfo(25, 22),//Mosiah 11:100
					new VerseInfo(25, 22),//Mosiah 11:101
					new VerseInfo(25, 23),//Mosiah 11:102
					new VerseInfo(25, 23, 25, 24),//Mosiah 11:103
					new VerseInfo(25, 24),//Mosiah 11:104
					new VerseInfo(26, 1),//Mosiah 11:105
					new VerseInfo(26, 2),//Mosiah 11:106
					new VerseInfo(26, 3),//Mosiah 11:107
					new VerseInfo(26, 4),//Mosiah 11:108
					new VerseInfo(26, 4),//Mosiah 11:109
					new VerseInfo(26, 5),//Mosiah 11:110
					new VerseInfo(26, 6),//Mosiah 11:111
					new VerseInfo(26, 6),//Mosiah 11:112
					new VerseInfo(26, 7),//Mosiah 11:113
					new VerseInfo(26, 8),//Mosiah 11:114
					new VerseInfo(26, 9),//Mosiah 11:115
					new VerseInfo(26, 10),//Mosiah 11:116
					new VerseInfo(26, 11),//Mosiah 11:117
					new VerseInfo(26, 11),//Mosiah 11:118
					new VerseInfo(26, 12),//Mosiah 11:119
					new VerseInfo(26, 13),//Mosiah 11:120
					new VerseInfo(26, 14, 26, 15),//Mosiah 11:121
					new VerseInfo(26, 15),//Mosiah 11:122
					new VerseInfo(26, 16),//Mosiah 11:123
					new VerseInfo(26, 17),//Mosiah 11:124
					new VerseInfo(26, 18),//Mosiah 11:125
					new VerseInfo(26, 19),//Mosiah 11:126
					new VerseInfo(26, 20),//Mosiah 11:127
					new VerseInfo(26, 21),//Mosiah 11:128
					new VerseInfo(26, 22),//Mosiah 11:129
					new VerseInfo(26, 22),//Mosiah 11:130
					new VerseInfo(26, 23),//Mosiah 11:131
					new VerseInfo(26, 24),//Mosiah 11:132
					new VerseInfo(26, 25),//Mosiah 11:133
					new VerseInfo(26, 26),//Mosiah 11:134
					new VerseInfo(26, 27),//Mosiah 11:135
					new VerseInfo(26, 28),//Mosiah 11:136
					new VerseInfo(26, 29),//Mosiah 11:137
					new VerseInfo(26, 29),//Mosiah 11:138
					new VerseInfo(26, 30),//Mosiah 11:139
					new VerseInfo(26, 31),//Mosiah 11:140
					new VerseInfo(26, 32),//Mosiah 11:141
					new VerseInfo(26, 33),//Mosiah 11:142
					new VerseInfo(26, 34),//Mosiah 11:143
					new VerseInfo(26, 35),//Mosiah 11:144
					new VerseInfo(26, 36),//Mosiah 11:145
					new VerseInfo(26, 37),//Mosiah 11:146
					new VerseInfo(26, 37),//Mosiah 11:147
					new VerseInfo(26, 38),//Mosiah 11:148
					new VerseInfo(26, 39),//Mosiah 11:149
					new VerseInfo(27, 1),//Mosiah 11:150
					new VerseInfo(27, 1),//Mosiah 11:151
					new VerseInfo(27, 2),//Mosiah 11:152
					new VerseInfo(27, 3, 27, 4),//Mosiah 11:153
					new VerseInfo(27, 4),//Mosiah 11:154
					new VerseInfo(27, 5),//Mosiah 11:155
					new VerseInfo(27, 6),//Mosiah 11:156
					new VerseInfo(27, 6),//Mosiah 11:157
					new VerseInfo(27, 7),//Mosiah 11:158
					new VerseInfo(27, 8),//Mosiah 11:159
					new VerseInfo(27, 8),//Mosiah 11:160
					new VerseInfo(27, 9),//Mosiah 11:161
					new VerseInfo(27, 10),//Mosiah 11:162
					new VerseInfo(27, 11),//Mosiah 11:163
					new VerseInfo(27, 12),//Mosiah 11:164
					new VerseInfo(27, 13),//Mosiah 11:165
					new VerseInfo(27, 13),//Mosiah 11:166
					new VerseInfo(27, 14),//Mosiah 11:167
					new VerseInfo(27, 14),//Mosiah 11:168
					new VerseInfo(27, 14),//Mosiah 11:169
					new VerseInfo(27, 15),//Mosiah 11:170
					new VerseInfo(27, 15),//Mosiah 11:171
					new VerseInfo(27, 15),//Mosiah 11:172
					new VerseInfo(27, 15),//Mosiah 11:173
					new VerseInfo(27, 16),//Mosiah 11:174
					new VerseInfo(27, 16),//Mosiah 11:175
					new VerseInfo(27, 17),//Mosiah 11:176
					new VerseInfo(27, 18),//Mosiah 11:177
					new VerseInfo(27, 18),//Mosiah 11:178
					new VerseInfo(27, 19),//Mosiah 11:179
					new VerseInfo(27, 19),//Mosiah 11:180
					new VerseInfo(27, 20),//Mosiah 11:181
					new VerseInfo(27, 21),//Mosiah 11:182
					new VerseInfo(27, 22),//Mosiah 11:183
					new VerseInfo(27, 22),//Mosiah 11:184
					new VerseInfo(27, 23),//Mosiah 11:185
					new VerseInfo(27, 24),//Mosiah 11:186
					new VerseInfo(27, 25),//Mosiah 11:187
					new VerseInfo(27, 25, 27, 26),//Mosiah 11:188
					new VerseInfo(27, 27),//Mosiah 11:189
					new VerseInfo(27, 28),//Mosiah 11:190
					new VerseInfo(27, 29),//Mosiah 11:191
					new VerseInfo(27, 29),//Mosiah 11:192
					new VerseInfo(27, 29),//Mosiah 11:193
					new VerseInfo(27, 30),//Mosiah 11:194
					new VerseInfo(27, 30),//Mosiah 11:195
					new VerseInfo(27, 30, 27, 31),//Mosiah 11:196
					new VerseInfo(27, 31),//Mosiah 11:197
					new VerseInfo(27, 31),//Mosiah 11:198
					new VerseInfo(27, 31),//Mosiah 11:199
					new VerseInfo(27, 32),//Mosiah 11:200
					new VerseInfo(27, 32),//Mosiah 11:201
					new VerseInfo(27, 33),//Mosiah 11:202
					new VerseInfo(27, 34),//Mosiah 11:203
					new VerseInfo(27, 35),//Mosiah 11:204
					new VerseInfo(27, 35),//Mosiah 11:205
					new VerseInfo(27, 36),//Mosiah 11:206
					new VerseInfo(27, 37),//Mosiah 11:207
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Mosiah 12
					new VerseInfo(28, 1),//Mosiah 12:1
					new VerseInfo(28, 1, 28, 2),//Mosiah 12:2
					new VerseInfo(28, 2),//Mosiah 12:3
					new VerseInfo(28, 2),//Mosiah 12:4
					new VerseInfo(28, 3),//Mosiah 12:5
					new VerseInfo(28, 3),//Mosiah 12:6
					new VerseInfo(28, 4),//Mosiah 12:7
					new VerseInfo(28, 4),//Mosiah 12:8
					new VerseInfo(28, 5),//Mosiah 12:9
					new VerseInfo(28, 6),//Mosiah 12:10
					new VerseInfo(28, 7),//Mosiah 12:11
					new VerseInfo(28, 8),//Mosiah 12:12
					new VerseInfo(28, 9),//Mosiah 12:13
					new VerseInfo(28, 10),//Mosiah 12:14
					new VerseInfo(28, 11),//Mosiah 12:15
					new VerseInfo(28, 11),//Mosiah 12:16
					new VerseInfo(28, 12),//Mosiah 12:17
					new VerseInfo(28, 13),//Mosiah 12:18
					new VerseInfo(28, 14),//Mosiah 12:19
					new VerseInfo(28, 15),//Mosiah 12:20
					new VerseInfo(28, 16),//Mosiah 12:21
					new VerseInfo(28, 17),//Mosiah 12:22
					new VerseInfo(28, 17),//Mosiah 12:23
					new VerseInfo(28, 18),//Mosiah 12:24
					new VerseInfo(28, 18),//Mosiah 12:25
					new VerseInfo(28, 19),//Mosiah 12:26
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Mosiah 13
					new VerseInfo(28, 20),//Mosiah 13:1
					new VerseInfo(28, 20),//Mosiah 13:2
					new VerseInfo(29, 1),//Mosiah 13:3
					new VerseInfo(29, 2),//Mosiah 13:4
					new VerseInfo(29, 3),//Mosiah 13:5
					new VerseInfo(29, 3, 29, 4),//Mosiah 13:6
					new VerseInfo(29, 4, 29, 5),//Mosiah 13:7
					new VerseInfo(29, 6),//Mosiah 13:8
					new VerseInfo(29, 7),//Mosiah 13:9
					new VerseInfo(29, 7),//Mosiah 13:10
					new VerseInfo(29, 8),//Mosiah 13:11
					new VerseInfo(29, 9),//Mosiah 13:12
					new VerseInfo(29, 10),//Mosiah 13:13
					new VerseInfo(29, 11),//Mosiah 13:14
					new VerseInfo(29, 11),//Mosiah 13:15
					new VerseInfo(29, 12),//Mosiah 13:16
					new VerseInfo(29, 13),//Mosiah 13:17
					new VerseInfo(29, 14),//Mosiah 13:18
					new VerseInfo(29, 14),//Mosiah 13:19
					new VerseInfo(29, 15),//Mosiah 13:20
					new VerseInfo(29, 16),//Mosiah 13:21
					new VerseInfo(29, 17),//Mosiah 13:22
					new VerseInfo(29, 18),//Mosiah 13:23
					new VerseInfo(29, 18),//Mosiah 13:24
					new VerseInfo(29, 19),//Mosiah 13:25
					new VerseInfo(29, 20),//Mosiah 13:26
					new VerseInfo(29, 20),//Mosiah 13:27
					new VerseInfo(29, 21),//Mosiah 13:28
					new VerseInfo(29, 22),//Mosiah 13:29
					new VerseInfo(29, 23),//Mosiah 13:30
					new VerseInfo(29, 23),//Mosiah 13:31
					new VerseInfo(29, 23),//Mosiah 13:32
					new VerseInfo(29, 24),//Mosiah 13:33
					new VerseInfo(29, 25),//Mosiah 13:34
					new VerseInfo(29, 26),//Mosiah 13:35
					new VerseInfo(29, 26),//Mosiah 13:36
					new VerseInfo(29, 27),//Mosiah 13:37
					new VerseInfo(29, 27),//Mosiah 13:38
					new VerseInfo(29, 28),//Mosiah 13:39
					new VerseInfo(29, 29),//Mosiah 13:40
					new VerseInfo(29, 30),//Mosiah 13:41
					new VerseInfo(29, 30),//Mosiah 13:42
					new VerseInfo(29, 31),//Mosiah 13:43
					new VerseInfo(29, 32),//Mosiah 13:44
					new VerseInfo(29, 32),//Mosiah 13:45
					new VerseInfo(29, 32),//Mosiah 13:46
					new VerseInfo(29, 33),//Mosiah 13:47
					new VerseInfo(29, 33),//Mosiah 13:48
					new VerseInfo(29, 34),//Mosiah 13:49
					new VerseInfo(29, 35),//Mosiah 13:50
					new VerseInfo(29, 36),//Mosiah 13:51
					new VerseInfo(29, 36),//Mosiah 13:52
					new VerseInfo(29, 37),//Mosiah 13:53
					new VerseInfo(29, 38),//Mosiah 13:54
					new VerseInfo(29, 38),//Mosiah 13:55
					new VerseInfo(29, 39),//Mosiah 13:56
					new VerseInfo(29, 39),//Mosiah 13:57
					new VerseInfo(29, 40),//Mosiah 13:58
					new VerseInfo(29, 40),//Mosiah 13:59
					new VerseInfo(29, 40),//Mosiah 13:60
					new VerseInfo(29, 40),//Mosiah 13:61
					new VerseInfo(29, 41),//Mosiah 13:62
					new VerseInfo(29, 42),//Mosiah 13:63
					new VerseInfo(29, 43),//Mosiah 13:64
					new VerseInfo(29, 44),//Mosiah 13:65
					new VerseInfo(29, 45),//Mosiah 13:66
					new VerseInfo(29, 46),//Mosiah 13:67
					new VerseInfo(29, 47),//Mosiah 13:68
				},
			}
		},
		{ "Alma", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 1
					new VerseInfo(1, 1),//Alma 1:1
					new VerseInfo(1, 1),//Alma 1:2
					new VerseInfo(1, 2),//Alma 1:3
					new VerseInfo(1, 3),//Alma 1:4
					new VerseInfo(1, 3),//Alma 1:5
					new VerseInfo(1, 4),//Alma 1:6
					new VerseInfo(1, 4),//Alma 1:7
					new VerseInfo(1, 5),//Alma 1:8
					new VerseInfo(1, 6),//Alma 1:9
					new VerseInfo(1, 7),//Alma 1:10
					new VerseInfo(1, 7),//Alma 1:11
					new VerseInfo(1, 8),//Alma 1:12
					new VerseInfo(1, 9),//Alma 1:13
					new VerseInfo(1, 9),//Alma 1:14
					new VerseInfo(1, 10),//Alma 1:15
					new VerseInfo(1, 11),//Alma 1:16
					new VerseInfo(1, 12),//Alma 1:17
					new VerseInfo(1, 12),//Alma 1:18
					new VerseInfo(1, 13),//Alma 1:19
					new VerseInfo(1, 14),//Alma 1:20
					new VerseInfo(1, 14),//Alma 1:21
					new VerseInfo(1, 15),//Alma 1:22
					new VerseInfo(1, 15),//Alma 1:23
					new VerseInfo(1, 16),//Alma 1:24
					new VerseInfo(1, 17),//Alma 1:25
					new VerseInfo(1, 17),//Alma 1:26
					new VerseInfo(1, 18),//Alma 1:27
					new VerseInfo(1, 19),//Alma 1:28
					new VerseInfo(1, 20),//Alma 1:29
					new VerseInfo(1, 20),//Alma 1:30
					new VerseInfo(1, 21),//Alma 1:31
					new VerseInfo(1, 22),//Alma 1:32
					new VerseInfo(1, 23),//Alma 1:33
					new VerseInfo(1, 24),//Alma 1:34
					new VerseInfo(1, 24),//Alma 1:35
					new VerseInfo(1, 25),//Alma 1:36
					new VerseInfo(1, 26),//Alma 1:37
					new VerseInfo(1, 26),//Alma 1:38
					new VerseInfo(1, 26),//Alma 1:39
					new VerseInfo(1, 27),//Alma 1:40
					new VerseInfo(1, 27),//Alma 1:41
					new VerseInfo(1, 28),//Alma 1:42
					new VerseInfo(1, 29),//Alma 1:43
					new VerseInfo(1, 29),//Alma 1:44
					new VerseInfo(1, 30),//Alma 1:45
					new VerseInfo(1, 30),//Alma 1:46
					new VerseInfo(1, 31),//Alma 1:47
					new VerseInfo(1, 32),//Alma 1:48
					new VerseInfo(1, 32),//Alma 1:49
					new VerseInfo(1, 32),//Alma 1:50
					new VerseInfo(1, 33),//Alma 1:51
					new VerseInfo(1, 33),//Alma 1:52
					new VerseInfo(2, 1),//Alma 1:53
					new VerseInfo(2, 2),//Alma 1:54
					new VerseInfo(2, 3),//Alma 1:55
					new VerseInfo(2, 3),//Alma 1:56
					new VerseInfo(2, 4),//Alma 1:57
					new VerseInfo(2, 5),//Alma 1:58
					new VerseInfo(2, 6),//Alma 1:59
					new VerseInfo(2, 7),//Alma 1:60
					new VerseInfo(2, 8),//Alma 1:61
					new VerseInfo(2, 9),//Alma 1:62
					new VerseInfo(2, 10),//Alma 1:63
					new VerseInfo(2, 11),//Alma 1:64
					new VerseInfo(2, 12),//Alma 1:65
					new VerseInfo(2, 12),//Alma 1:66
					new VerseInfo(2, 13),//Alma 1:67
					new VerseInfo(2, 13),//Alma 1:68
					new VerseInfo(2, 14),//Alma 1:69
					new VerseInfo(2, 15),//Alma 1:70
					new VerseInfo(2, 16, 2, 17),//Alma 1:71
					new VerseInfo(2, 17),//Alma 1:72
					new VerseInfo(2, 18),//Alma 1:73
					new VerseInfo(2, 19),//Alma 1:74
					new VerseInfo(2, 19),//Alma 1:75
					new VerseInfo(2, 20),//Alma 1:76
					new VerseInfo(2, 21),//Alma 1:77
					new VerseInfo(2, 22),//Alma 1:78
					new VerseInfo(2, 23),//Alma 1:79
					new VerseInfo(2, 24),//Alma 1:80
					new VerseInfo(2, 24, 2, 25),//Alma 1:81
					new VerseInfo(2, 25),//Alma 1:82
					new VerseInfo(2, 26),//Alma 1:83
					new VerseInfo(2, 27),//Alma 1:84
					new VerseInfo(2, 28),//Alma 1:85
					new VerseInfo(2, 28),//Alma 1:86
					new VerseInfo(2, 29),//Alma 1:87
					new VerseInfo(2, 30),//Alma 1:88
					new VerseInfo(2, 31),//Alma 1:89
					new VerseInfo(2, 32),//Alma 1:90
					new VerseInfo(2, 33),//Alma 1:91
					new VerseInfo(2, 34),//Alma 1:92
					new VerseInfo(2, 35),//Alma 1:93
					new VerseInfo(2, 36),//Alma 1:94
					new VerseInfo(2, 36, 2, 37),//Alma 1:95
					new VerseInfo(2, 37),//Alma 1:96
					new VerseInfo(2, 38),//Alma 1:97
					new VerseInfo(3, 1),//Alma 1:98
					new VerseInfo(3, 2),//Alma 1:99
					new VerseInfo(3, 2),//Alma 1:100
					new VerseInfo(3, 3),//Alma 1:101
					new VerseInfo(3, 4),//Alma 1:102
					new VerseInfo(3, 5),//Alma 1:103
					new VerseInfo(3, 6),//Alma 1:104
					new VerseInfo(3, 7),//Alma 1:105
					new VerseInfo(3, 8),//Alma 1:106
					new VerseInfo(3, 9),//Alma 1:107
					new VerseInfo(3, 10),//Alma 1:108
					new VerseInfo(3, 11),//Alma 1:109
					new VerseInfo(3, 12),//Alma 1:110
					new VerseInfo(3, 13),//Alma 1:111
					new VerseInfo(3, 14),//Alma 1:112
					new VerseInfo(3, 14),//Alma 1:113
					new VerseInfo(3, 15),//Alma 1:114
					new VerseInfo(3, 16),//Alma 1:115
					new VerseInfo(3, 17),//Alma 1:116
					new VerseInfo(3, 18),//Alma 1:117
					new VerseInfo(3, 18),//Alma 1:118
					new VerseInfo(3, 19),//Alma 1:119
					new VerseInfo(3, 19),//Alma 1:120
					new VerseInfo(3, 20),//Alma 1:121
					new VerseInfo(3, 21),//Alma 1:122
					new VerseInfo(3, 22, 3, 23),//Alma 1:123
					new VerseInfo(3, 23),//Alma 1:124
					new VerseInfo(3, 24),//Alma 1:125
					new VerseInfo(3, 25),//Alma 1:126
					new VerseInfo(3, 26),//Alma 1:127
					new VerseInfo(3, 26),//Alma 1:128
					new VerseInfo(3, 27),//Alma 1:129
					new VerseInfo(3, 27),//Alma 1:130
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 2
					new VerseInfo(4, 1),//Alma 2:1
					new VerseInfo(4, 2),//Alma 2:2
					new VerseInfo(4, 3),//Alma 2:3
					new VerseInfo(4, 4),//Alma 2:4
					new VerseInfo(4, 4),//Alma 2:5
					new VerseInfo(4, 5),//Alma 2:6
					new VerseInfo(4, 5),//Alma 2:7
					new VerseInfo(4, 6),//Alma 2:8
					new VerseInfo(4, 6),//Alma 2:9
					new VerseInfo(4, 6),//Alma 2:10
					new VerseInfo(4, 7),//Alma 2:11
					new VerseInfo(4, 7),//Alma 2:12
					new VerseInfo(4, 8),//Alma 2:13
					new VerseInfo(4, 8),//Alma 2:14
					new VerseInfo(4, 9),//Alma 2:15
					new VerseInfo(4, 9),//Alma 2:16
					new VerseInfo(4, 10),//Alma 2:17
					new VerseInfo(4, 11),//Alma 2:18
					new VerseInfo(4, 12),//Alma 2:19
					new VerseInfo(4, 13, 4, 14),//Alma 2:20
					new VerseInfo(4, 14),//Alma 2:21
					new VerseInfo(4, 15),//Alma 2:22
					new VerseInfo(4, 16),//Alma 2:23
					new VerseInfo(4, 17),//Alma 2:24
					new VerseInfo(4, 18),//Alma 2:25
					new VerseInfo(4, 19),//Alma 2:26
					new VerseInfo(4, 19),//Alma 2:27
					new VerseInfo(4, 20),//Alma 2:28
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 3
					new VerseInfo(5, 1),//Alma 3:1
					new VerseInfo(5, 2),//Alma 3:2
					new VerseInfo(5, 3),//Alma 3:3
					new VerseInfo(5, 3),//Alma 3:4
					new VerseInfo(5, 4),//Alma 3:5
					new VerseInfo(5, 5),//Alma 3:6
					new VerseInfo(5, 5),//Alma 3:7
					new VerseInfo(5, 6),//Alma 3:8
					new VerseInfo(5, 6),//Alma 3:9
					new VerseInfo(5, 6),//Alma 3:10
					new VerseInfo(5, 7),//Alma 3:11
					new VerseInfo(5, 7),//Alma 3:12
					new VerseInfo(5, 7),//Alma 3:13
					new VerseInfo(5, 8),//Alma 3:14
					new VerseInfo(5, 8),//Alma 3:15
					new VerseInfo(5, 9),//Alma 3:16
					new VerseInfo(5, 9),//Alma 3:17
					new VerseInfo(5, 9),//Alma 3:18
					new VerseInfo(5, 10),//Alma 3:19
					new VerseInfo(5, 10),//Alma 3:20
					new VerseInfo(5, 11),//Alma 3:21
					new VerseInfo(5, 11),//Alma 3:22
					new VerseInfo(5, 12),//Alma 3:23
					new VerseInfo(5, 12),//Alma 3:24
					new VerseInfo(5, 13),//Alma 3:25
					new VerseInfo(5, 13),//Alma 3:26
					new VerseInfo(5, 14),//Alma 3:27
					new VerseInfo(5, 14),//Alma 3:28
					new VerseInfo(5, 14),//Alma 3:29
					new VerseInfo(5, 15),//Alma 3:30
					new VerseInfo(5, 15),//Alma 3:31
					new VerseInfo(5, 16),//Alma 3:32
					new VerseInfo(5, 17),//Alma 3:33
					new VerseInfo(5, 18),//Alma 3:34
					new VerseInfo(5, 18),//Alma 3:35
					new VerseInfo(5, 19),//Alma 3:36
					new VerseInfo(5, 19),//Alma 3:37
					new VerseInfo(5, 20),//Alma 3:38
					new VerseInfo(5, 21),//Alma 3:39
					new VerseInfo(5, 21),//Alma 3:40
					new VerseInfo(5, 22),//Alma 3:41
					new VerseInfo(5, 22),//Alma 3:42
					new VerseInfo(5, 23),//Alma 3:43
					new VerseInfo(5, 24),//Alma 3:44
					new VerseInfo(5, 25),//Alma 3:45
					new VerseInfo(5, 26),//Alma 3:46
					new VerseInfo(5, 27),//Alma 3:47
					new VerseInfo(5, 27),//Alma 3:48
					new VerseInfo(5, 27),//Alma 3:49
					new VerseInfo(5, 28),//Alma 3:50
					new VerseInfo(5, 28),//Alma 3:51
					new VerseInfo(5, 29),//Alma 3:52
					new VerseInfo(5, 29),//Alma 3:53
					new VerseInfo(5, 30),//Alma 3:54
					new VerseInfo(5, 31),//Alma 3:55
					new VerseInfo(5, 32),//Alma 3:56
					new VerseInfo(5, 33),//Alma 3:57
					new VerseInfo(5, 34),//Alma 3:58
					new VerseInfo(5, 35),//Alma 3:59
					new VerseInfo(5, 36),//Alma 3:60
					new VerseInfo(5, 37),//Alma 3:61
					new VerseInfo(5, 38),//Alma 3:62
					new VerseInfo(5, 38),//Alma 3:63
					new VerseInfo(5, 39),//Alma 3:64
					new VerseInfo(5, 39),//Alma 3:65
					new VerseInfo(5, 39),//Alma 3:66
					new VerseInfo(5, 40),//Alma 3:67
					new VerseInfo(5, 41),//Alma 3:68
					new VerseInfo(5, 41),//Alma 3:69
					new VerseInfo(5, 42),//Alma 3:70
					new VerseInfo(5, 43),//Alma 3:71
					new VerseInfo(5, 43),//Alma 3:72
					new VerseInfo(5, 44),//Alma 3:73
					new VerseInfo(5, 44),//Alma 3:74
					new VerseInfo(5, 45),//Alma 3:75
					new VerseInfo(5, 45),//Alma 3:76
					new VerseInfo(5, 45),//Alma 3:77
					new VerseInfo(5, 46),//Alma 3:78
					new VerseInfo(5, 46),//Alma 3:79
					new VerseInfo(5, 46),//Alma 3:80
					new VerseInfo(5, 47),//Alma 3:81
					new VerseInfo(5, 47, 5, 48),//Alma 3:82
					new VerseInfo(5, 48),//Alma 3:83
					new VerseInfo(5, 48),//Alma 3:84
					new VerseInfo(5, 49),//Alma 3:85
					new VerseInfo(5, 49),//Alma 3:86
					new VerseInfo(5, 50),//Alma 3:87
					new VerseInfo(5, 50),//Alma 3:88
					new VerseInfo(5, 51),//Alma 3:89
					new VerseInfo(5, 52),//Alma 3:90
					new VerseInfo(5, 52),//Alma 3:91
					new VerseInfo(5, 53),//Alma 3:92
					new VerseInfo(5, 53),//Alma 3:93
					new VerseInfo(5, 54),//Alma 3:94
					new VerseInfo(5, 54),//Alma 3:95
					new VerseInfo(5, 55),//Alma 3:96
					new VerseInfo(5, 56),//Alma 3:97
					new VerseInfo(5, 57),//Alma 3:98
					new VerseInfo(5, 57),//Alma 3:99
					new VerseInfo(5, 58),//Alma 3:100
					new VerseInfo(5, 58),//Alma 3:101
					new VerseInfo(5, 58),//Alma 3:102
					new VerseInfo(5, 59),//Alma 3:103
					new VerseInfo(5, 59),//Alma 3:104
					new VerseInfo(5, 60),//Alma 3:105
					new VerseInfo(5, 60),//Alma 3:106
					new VerseInfo(5, 61),//Alma 3:107
					new VerseInfo(5, 62),//Alma 3:108
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 4
					new VerseInfo(6, 1),//Alma 4:1
					new VerseInfo(6, 2),//Alma 4:2
					new VerseInfo(6, 3),//Alma 4:3
					new VerseInfo(6, 3, 6, 4),//Alma 4:4
					new VerseInfo(6, 5),//Alma 4:5
					new VerseInfo(6, 6),//Alma 4:6
					new VerseInfo(6, 7),//Alma 4:7
					new VerseInfo(6, 7),//Alma 4:8
					new VerseInfo(6, 8),//Alma 4:9
					new VerseInfo(6, 8),//Alma 4:10
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 5
					new VerseInfo(7, 1),//Alma 5:1
					new VerseInfo(7, 1),//Alma 5:2
					new VerseInfo(7, 2),//Alma 5:3
					new VerseInfo(7, 3),//Alma 5:4
					new VerseInfo(7, 3),//Alma 5:5
					new VerseInfo(7, 4),//Alma 5:6
					new VerseInfo(7, 5),//Alma 5:7
					new VerseInfo(7, 5),//Alma 5:8
					new VerseInfo(7, 5),//Alma 5:9
					new VerseInfo(7, 6),//Alma 5:10
					new VerseInfo(7, 6),//Alma 5:11
					new VerseInfo(7, 6),//Alma 5:12
					new VerseInfo(7, 7),//Alma 5:13
					new VerseInfo(7, 7),//Alma 5:14
					new VerseInfo(7, 8),//Alma 5:15
					new VerseInfo(7, 8),//Alma 5:16
					new VerseInfo(7, 9),//Alma 5:17
					new VerseInfo(7, 9),//Alma 5:18
					new VerseInfo(7, 10),//Alma 5:19
					new VerseInfo(7, 11),//Alma 5:20
					new VerseInfo(7, 11, 7, 12),//Alma 5:21
					new VerseInfo(7, 12),//Alma 5:22
					new VerseInfo(7, 13),//Alma 5:23
					new VerseInfo(7, 14),//Alma 5:24
					new VerseInfo(7, 14),//Alma 5:25
					new VerseInfo(7, 15),//Alma 5:26
					new VerseInfo(7, 15),//Alma 5:27
					new VerseInfo(7, 16),//Alma 5:28
					new VerseInfo(7, 17),//Alma 5:29
					new VerseInfo(7, 17),//Alma 5:30
					new VerseInfo(7, 17),//Alma 5:31
					new VerseInfo(7, 18),//Alma 5:32
					new VerseInfo(7, 19),//Alma 5:33
					new VerseInfo(7, 19, 7, 20),//Alma 5:34
					new VerseInfo(7, 20),//Alma 5:35
					new VerseInfo(7, 21),//Alma 5:36
					new VerseInfo(7, 21),//Alma 5:37
					new VerseInfo(7, 22),//Alma 5:38
					new VerseInfo(7, 23),//Alma 5:39
					new VerseInfo(7, 23),//Alma 5:40
					new VerseInfo(7, 24),//Alma 5:41
					new VerseInfo(7, 25),//Alma 5:42
					new VerseInfo(7, 26),//Alma 5:43
					new VerseInfo(7, 27),//Alma 5:44
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 6
					new VerseInfo(8, 1),//Alma 6:1
					new VerseInfo(8, 1),//Alma 6:2
					new VerseInfo(8, 2),//Alma 6:3
					new VerseInfo(8, 3),//Alma 6:4
					new VerseInfo(8, 4),//Alma 6:5
					new VerseInfo(8, 5),//Alma 6:6
					new VerseInfo(8, 5, 8, 6),//Alma 6:7
					new VerseInfo(8, 7),//Alma 6:8
					new VerseInfo(8, 8),//Alma 6:9
					new VerseInfo(8, 9),//Alma 6:10
					new VerseInfo(8, 10),//Alma 6:11
					new VerseInfo(8, 11),//Alma 6:12
					new VerseInfo(8, 11),//Alma 6:13
					new VerseInfo(8, 12),//Alma 6:14
					new VerseInfo(8, 12),//Alma 6:15
					new VerseInfo(8, 13),//Alma 6:16
					new VerseInfo(8, 14),//Alma 6:17
					new VerseInfo(8, 14, 8, 15),//Alma 6:18
					new VerseInfo(8, 15),//Alma 6:19
					new VerseInfo(8, 15, 8, 16),//Alma 6:20
					new VerseInfo(8, 16),//Alma 6:21
					new VerseInfo(8, 17),//Alma 6:22
					new VerseInfo(8, 18),//Alma 6:23
					new VerseInfo(8, 18),//Alma 6:24
					new VerseInfo(8, 19),//Alma 6:25
					new VerseInfo(8, 20),//Alma 6:26
					new VerseInfo(8, 20),//Alma 6:27
					new VerseInfo(8, 21),//Alma 6:28
					new VerseInfo(8, 22),//Alma 6:29
					new VerseInfo(8, 23),//Alma 6:30
					new VerseInfo(8, 24),//Alma 6:31
					new VerseInfo(8, 24),//Alma 6:32
					new VerseInfo(8, 25),//Alma 6:33
					new VerseInfo(8, 26),//Alma 6:34
					new VerseInfo(8, 27),//Alma 6:35
					new VerseInfo(8, 28),//Alma 6:36
					new VerseInfo(8, 29),//Alma 6:37
					new VerseInfo(8, 30),//Alma 6:38
					new VerseInfo(8, 31),//Alma 6:39
					new VerseInfo(8, 31),//Alma 6:40
					new VerseInfo(8, 31),//Alma 6:41
					new VerseInfo(8, 32),//Alma 6:42
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 7
					new VerseInfo(9, 1, 9, 2),//Alma 7:1
					new VerseInfo(9, 2),//Alma 7:2
					new VerseInfo(9, 3),//Alma 7:3
					new VerseInfo(9, 4),//Alma 7:4
					new VerseInfo(9, 5),//Alma 7:5
					new VerseInfo(9, 6),//Alma 7:6
					new VerseInfo(9, 7),//Alma 7:7
					new VerseInfo(9, 7, 9, 8),//Alma 7:8
					new VerseInfo(9, 9),//Alma 7:9
					new VerseInfo(9, 9),//Alma 7:10
					new VerseInfo(9, 10),//Alma 7:11
					new VerseInfo(9, 11),//Alma 7:12
					new VerseInfo(9, 12),//Alma 7:13
					new VerseInfo(9, 12),//Alma 7:14
					new VerseInfo(9, 13),//Alma 7:15
					new VerseInfo(9, 13),//Alma 7:16
					new VerseInfo(9, 14),//Alma 7:17
					new VerseInfo(9, 14),//Alma 7:18
					new VerseInfo(9, 15),//Alma 7:19
					new VerseInfo(9, 15, 9, 16),//Alma 7:20
					new VerseInfo(9, 16),//Alma 7:21
					new VerseInfo(9, 17),//Alma 7:22
					new VerseInfo(9, 17),//Alma 7:23
					new VerseInfo(9, 18),//Alma 7:24
					new VerseInfo(9, 18),//Alma 7:25
					new VerseInfo(9, 18, 9, 19),//Alma 7:26
					new VerseInfo(9, 19),//Alma 7:27
					new VerseInfo(9, 20),//Alma 7:28
					new VerseInfo(9, 20),//Alma 7:29
					new VerseInfo(9, 21),//Alma 7:30
					new VerseInfo(9, 21),//Alma 7:31
					new VerseInfo(9, 22),//Alma 7:32
					new VerseInfo(9, 22),//Alma 7:33
					new VerseInfo(9, 22),//Alma 7:34
					new VerseInfo(9, 23),//Alma 7:35
					new VerseInfo(9, 23),//Alma 7:36
					new VerseInfo(9, 24),//Alma 7:37
					new VerseInfo(9, 24),//Alma 7:38
					new VerseInfo(9, 25),//Alma 7:39
					new VerseInfo(9, 26),//Alma 7:40
					new VerseInfo(9, 27),//Alma 7:41
					new VerseInfo(9, 28),//Alma 7:42
					new VerseInfo(9, 28),//Alma 7:43
					new VerseInfo(9, 28),//Alma 7:44
					new VerseInfo(9, 29),//Alma 7:45
					new VerseInfo(9, 30),//Alma 7:46
					new VerseInfo(9, 31),//Alma 7:47
					new VerseInfo(9, 32),//Alma 7:48
					new VerseInfo(9, 33),//Alma 7:49
					new VerseInfo(9, 34),//Alma 7:50
					new VerseInfo(9, 34),//Alma 7:51
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 8
					new VerseInfo(10, 1, 10, 2),//Alma 8:1
					new VerseInfo(10, 2),//Alma 8:2
					new VerseInfo(10, 3),//Alma 8:3
					new VerseInfo(10, 4),//Alma 8:4
					new VerseInfo(10, 4),//Alma 8:5
					new VerseInfo(10, 5),//Alma 8:6
					new VerseInfo(10, 5),//Alma 8:7
					new VerseInfo(10, 6),//Alma 8:8
					new VerseInfo(10, 6),//Alma 8:9
					new VerseInfo(10, 7),//Alma 8:10
					new VerseInfo(10, 7),//Alma 8:11
					new VerseInfo(10, 8),//Alma 8:12
					new VerseInfo(10, 8),//Alma 8:13
					new VerseInfo(10, 9),//Alma 8:14
					new VerseInfo(10, 10),//Alma 8:15
					new VerseInfo(10, 11),//Alma 8:16
					new VerseInfo(10, 11),//Alma 8:17
					new VerseInfo(10, 12),//Alma 8:18
					new VerseInfo(10, 13),//Alma 8:19
					new VerseInfo(10, 13),//Alma 8:20
					new VerseInfo(10, 14),//Alma 8:21
					new VerseInfo(10, 15),//Alma 8:22
					new VerseInfo(10, 16),//Alma 8:23
					new VerseInfo(10, 17),//Alma 8:24
					new VerseInfo(10, 17),//Alma 8:25
					new VerseInfo(10, 17, 10, 18),//Alma 8:26
					new VerseInfo(10, 19),//Alma 8:27
					new VerseInfo(10, 19),//Alma 8:28
					new VerseInfo(10, 20),//Alma 8:29
					new VerseInfo(10, 21),//Alma 8:30
					new VerseInfo(10, 22),//Alma 8:31
					new VerseInfo(10, 22),//Alma 8:32
					new VerseInfo(10, 23),//Alma 8:33
					new VerseInfo(10, 23),//Alma 8:34
					new VerseInfo(10, 24),//Alma 8:35
					new VerseInfo(10, 25),//Alma 8:36
					new VerseInfo(10, 25),//Alma 8:37
					new VerseInfo(10, 26),//Alma 8:38
					new VerseInfo(10, 26),//Alma 8:39
					new VerseInfo(10, 27),//Alma 8:40
					new VerseInfo(10, 28),//Alma 8:41
					new VerseInfo(10, 28),//Alma 8:42
					new VerseInfo(10, 29),//Alma 8:43
					new VerseInfo(10, 30),//Alma 8:44
					new VerseInfo(10, 31),//Alma 8:45
					new VerseInfo(10, 31),//Alma 8:46
					new VerseInfo(10, 32),//Alma 8:47
					new VerseInfo(11, 1),//Alma 8:48
					new VerseInfo(11, 2),//Alma 8:49
					new VerseInfo(11, 2),//Alma 8:50
					new VerseInfo(11, 2),//Alma 8:51
					new VerseInfo(11, 3),//Alma 8:52
					new VerseInfo(11, 4),//Alma 8:53
					new VerseInfo(11, 4),//Alma 8:54
					new VerseInfo(11, 4),//Alma 8:55
					new VerseInfo(11, 5),//Alma 8:56
					new VerseInfo(11, 6),//Alma 8:57
					new VerseInfo(11, 7),//Alma 8:58
					new VerseInfo(11, 8, 11, 10),//Alma 8:59
					new VerseInfo(11, 11, 11, 13),//Alma 8:60
					new VerseInfo(11, 14, 11, 17),//Alma 8:61
					new VerseInfo(11, 18),//Alma 8:62
					new VerseInfo(11, 19),//Alma 8:63
					new VerseInfo(11, 20),//Alma 8:64
					new VerseInfo(11, 20),//Alma 8:65
					new VerseInfo(11, 20),//Alma 8:66
					new VerseInfo(11, 21),//Alma 8:67
					new VerseInfo(11, 21),//Alma 8:68
					new VerseInfo(11, 22),//Alma 8:69
					new VerseInfo(11, 22),//Alma 8:70
					new VerseInfo(11, 23),//Alma 8:71
					new VerseInfo(11, 23),//Alma 8:72
					new VerseInfo(11, 24),//Alma 8:73
					new VerseInfo(11, 24),//Alma 8:74
					new VerseInfo(11, 25),//Alma 8:75
					new VerseInfo(11, 25),//Alma 8:76
					new VerseInfo(11, 25),//Alma 8:77
					new VerseInfo(11, 25),//Alma 8:78
					new VerseInfo(11, 26),//Alma 8:79
					new VerseInfo(11, 27),//Alma 8:80
					new VerseInfo(11, 28),//Alma 8:81
					new VerseInfo(11, 29),//Alma 8:82
					new VerseInfo(11, 30),//Alma 8:83
					new VerseInfo(11, 31),//Alma 8:84
					new VerseInfo(11, 32),//Alma 8:85
					new VerseInfo(11, 33),//Alma 8:86
					new VerseInfo(11, 34),//Alma 8:87
					new VerseInfo(11, 34),//Alma 8:88
					new VerseInfo(11, 35),//Alma 8:89
					new VerseInfo(11, 36),//Alma 8:90
					new VerseInfo(11, 37),//Alma 8:91
					new VerseInfo(11, 37),//Alma 8:92
					new VerseInfo(11, 38),//Alma 8:93
					new VerseInfo(11, 39),//Alma 8:94
					new VerseInfo(11, 39),//Alma 8:95
					new VerseInfo(11, 40),//Alma 8:96
					new VerseInfo(11, 41),//Alma 8:97
					new VerseInfo(11, 41),//Alma 8:98
					new VerseInfo(11, 42),//Alma 8:99
					new VerseInfo(11, 43),//Alma 8:100
					new VerseInfo(11, 43),//Alma 8:101
					new VerseInfo(11, 44),//Alma 8:102
					new VerseInfo(11, 44),//Alma 8:103
					new VerseInfo(11, 44),//Alma 8:104
					new VerseInfo(11, 45),//Alma 8:105
					new VerseInfo(11, 45),//Alma 8:106
					new VerseInfo(11, 45),//Alma 8:107
					new VerseInfo(11, 46),//Alma 8:108
					new VerseInfo(11, 46),//Alma 8:109
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//Alma 9
					new VerseInfo(12, 1),//Alma 9:1
					new VerseInfo(12, 2),//Alma 9:2
					new VerseInfo(12, 3),//Alma 9:3
					new VerseInfo(12, 3),//Alma 9:4
					new VerseInfo(12, 4),//Alma 9:5
					new VerseInfo(12, 5),//Alma 9:6
					new VerseInfo(12, 5),//Alma 9:7
					new VerseInfo(12, 6),//Alma 9:8
					new VerseInfo(12, 6),//Alma 9:9
					new VerseInfo(12, 7),//Alma 9:10
					new VerseInfo(12, 7),//Alma 9:11
					new VerseInfo(12, 7),//Alma 9:12
					new VerseInfo(12, 8),//Alma 9:13
					new VerseInfo(12, 8),//Alma 9:14
					new VerseInfo(12, 9),//Alma 9:15
					new VerseInfo(12, 9),//Alma 9:16
					new VerseInfo(12, 10),//Alma 9:17
					new VerseInfo(12, 10),//Alma 9:18
					new VerseInfo(12, 11),//Alma 9:19
					new VerseInfo(12, 11),//Alma 9:20
					new VerseInfo(12, 11, 12, 12),//Alma 9:21
					new VerseInfo(12, 13),//Alma 9:22
					new VerseInfo(12, 14),//Alma 9:23
					new VerseInfo(12, 14),//Alma 9:24
					new VerseInfo(12, 14),//Alma 9:25
					new VerseInfo(12, 15),//Alma 9:26
					new VerseInfo(12, 15),//Alma 9:27
					new VerseInfo(12, 16),//Alma 9:28
					new VerseInfo(12, 16),//Alma 9:29
					new VerseInfo(12, 17),//Alma 9:30
					new VerseInfo(12, 17),//Alma 9:31
					new VerseInfo(12, 18),//Alma 9:32
					new VerseInfo(12, 19),//Alma 9:33
					new VerseInfo(12, 20),//Alma 9:34
					new VerseInfo(12, 21),//Alma 9:35
					new VerseInfo(12, 21),//Alma 9:36
					new VerseInfo(12, 22),//Alma 9:37
					new VerseInfo(12, 22),//Alma 9:38
					new VerseInfo(12, 23),//Alma 9:39
					new VerseInfo(12, 24),//Alma 9:40
					new VerseInfo(12, 24),//Alma 9:41
					new VerseInfo(12, 25),//Alma 9:42
					new VerseInfo(12, 25),//Alma 9:43
					new VerseInfo(12, 26),//Alma 9:44
					new VerseInfo(12, 26),//Alma 9:45
					new VerseInfo(12, 27),//Alma 9:46
					new VerseInfo(12, 28),//Alma 9:47
					new VerseInfo(12, 29),//Alma 9:48
					new VerseInfo(12, 30),//Alma 9:49
					new VerseInfo(12, 30),//Alma 9:50
					new VerseInfo(12, 31),//Alma 9:51
					new VerseInfo(12, 32),//Alma 9:52
					new VerseInfo(12, 32),//Alma 9:53
					new VerseInfo(12, 33),//Alma 9:54
					new VerseInfo(12, 34),//Alma 9:55
					new VerseInfo(12, 35),//Alma 9:56
					new VerseInfo(12, 36),//Alma 9:57
					new VerseInfo(12, 36),//Alma 9:58
					new VerseInfo(12, 36),//Alma 9:59
					new VerseInfo(12, 37),//Alma 9:60
					new VerseInfo(12, 37),//Alma 9:61
					new VerseInfo(13, 1),//Alma 9:62
					new VerseInfo(13, 1),//Alma 9:63
					new VerseInfo(13, 2),//Alma 9:64
					new VerseInfo(13, 3),//Alma 9:65
					new VerseInfo(13, 3),//Alma 9:66
					new VerseInfo(13, 4),//Alma 9:67
					new VerseInfo(13, 5),//Alma 9:68
					new VerseInfo(13, 6),//Alma 9:69
					new VerseInfo(13, 7),//Alma 9:70
					new VerseInfo(13, 7),//Alma 9:71
					new VerseInfo(13, 8),//Alma 9:72
					new VerseInfo(13, 9),//Alma 9:73
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//Alma 10
					new VerseInfo(13, 10),//Alma 10:1
					new VerseInfo(13, 10),//Alma 10:2
					new VerseInfo(13, 11),//Alma 10:3
					new VerseInfo(13, 12),//Alma 10:4
					new VerseInfo(13, 12),//Alma 10:5
					new VerseInfo(13, 13),//Alma 10:6
					new VerseInfo(13, 14),//Alma 10:7
					new VerseInfo(13, 15),//Alma 10:8
					new VerseInfo(13, 16),//Alma 10:9
					new VerseInfo(13, 16),//Alma 10:10
					new VerseInfo(13, 17),//Alma 10:11
					new VerseInfo(13, 18),//Alma 10:12
					new VerseInfo(13, 18),//Alma 10:13
					new VerseInfo(13, 18),//Alma 10:14
					new VerseInfo(13, 19),//Alma 10:15
					new VerseInfo(13, 20),//Alma 10:16
					new VerseInfo(13, 20),//Alma 10:17
					new VerseInfo(13, 21),//Alma 10:18
					new VerseInfo(13, 22),//Alma 10:19
					new VerseInfo(13, 22),//Alma 10:20
					new VerseInfo(13, 23),//Alma 10:21
					new VerseInfo(13, 23),//Alma 10:22
					new VerseInfo(13, 24),//Alma 10:23
					new VerseInfo(13, 25),//Alma 10:24
					new VerseInfo(13, 25),//Alma 10:25
					new VerseInfo(13, 26),//Alma 10:26
					new VerseInfo(13, 27),//Alma 10:27
					new VerseInfo(13, 28, 13, 29),//Alma 10:28
					new VerseInfo(13, 29),//Alma 10:29
					new VerseInfo(13, 30),//Alma 10:30
					new VerseInfo(13, 31),//Alma 10:31
					new VerseInfo(14, 1),//Alma 10:32
					new VerseInfo(14, 2),//Alma 10:33
					new VerseInfo(14, 2),//Alma 10:34
					new VerseInfo(14, 3),//Alma 10:35
					new VerseInfo(14, 4),//Alma 10:36
					new VerseInfo(14, 5),//Alma 10:37
					new VerseInfo(14, 5),//Alma 10:38
					new VerseInfo(14, 5),//Alma 10:39
					new VerseInfo(14, 6),//Alma 10:40
					new VerseInfo(14, 6),//Alma 10:41
					new VerseInfo(14, 7),//Alma 10:42
					new VerseInfo(14, 7),//Alma 10:43
					new VerseInfo(14, 7),//Alma 10:44
					new VerseInfo(14, 8),//Alma 10:45
					new VerseInfo(14, 8),//Alma 10:46
					new VerseInfo(14, 9),//Alma 10:47
					new VerseInfo(14, 10),//Alma 10:48
					new VerseInfo(14, 10),//Alma 10:49
					new VerseInfo(14, 11),//Alma 10:50
					new VerseInfo(14, 11),//Alma 10:51
					new VerseInfo(14, 11),//Alma 10:52
					new VerseInfo(14, 12),//Alma 10:53
					new VerseInfo(14, 13),//Alma 10:54
					new VerseInfo(14, 14),//Alma 10:55
					new VerseInfo(14, 14),//Alma 10:56
					new VerseInfo(14, 15),//Alma 10:57
					new VerseInfo(14, 15),//Alma 10:58
					new VerseInfo(14, 16),//Alma 10:59
					new VerseInfo(14, 17),//Alma 10:60
					new VerseInfo(14, 18),//Alma 10:61
					new VerseInfo(14, 18),//Alma 10:62
					new VerseInfo(14, 19),//Alma 10:63
					new VerseInfo(14, 19),//Alma 10:64
					new VerseInfo(14, 19),//Alma 10:65
					new VerseInfo(14, 20),//Alma 10:66
					new VerseInfo(14, 20),//Alma 10:67
					new VerseInfo(14, 20),//Alma 10:68
					new VerseInfo(14, 21),//Alma 10:69
					new VerseInfo(14, 22),//Alma 10:70
					new VerseInfo(14, 22),//Alma 10:71
					new VerseInfo(14, 22),//Alma 10:72
					new VerseInfo(14, 23),//Alma 10:73
					new VerseInfo(14, 24),//Alma 10:74
					new VerseInfo(14, 25),//Alma 10:75
					new VerseInfo(14, 25, 14, 26),//Alma 10:76
					new VerseInfo(14, 26),//Alma 10:77
					new VerseInfo(14, 27),//Alma 10:78
					new VerseInfo(14, 27),//Alma 10:79
					new VerseInfo(14, 27),//Alma 10:80
					new VerseInfo(14, 28),//Alma 10:81
					new VerseInfo(14, 28),//Alma 10:82
					new VerseInfo(14, 28),//Alma 10:83
					new VerseInfo(14, 29),//Alma 10:84
					new VerseInfo(14, 29),//Alma 10:85
					new VerseInfo(15, 1),//Alma 10:86
					new VerseInfo(15, 1),//Alma 10:87
					new VerseInfo(15, 2),//Alma 10:88
					new VerseInfo(15, 3),//Alma 10:89
					new VerseInfo(15, 3),//Alma 10:90
					new VerseInfo(15, 4),//Alma 10:91
					new VerseInfo(15, 5),//Alma 10:92
					new VerseInfo(15, 5),//Alma 10:93
					new VerseInfo(15, 5),//Alma 10:94
					new VerseInfo(15, 6),//Alma 10:95
					new VerseInfo(15, 7),//Alma 10:96
					new VerseInfo(15, 8),//Alma 10:97
					new VerseInfo(15, 9),//Alma 10:98
					new VerseInfo(15, 10),//Alma 10:99
					new VerseInfo(15, 11),//Alma 10:100
					new VerseInfo(15, 11),//Alma 10:101
					new VerseInfo(15, 12),//Alma 10:102
					new VerseInfo(15, 13),//Alma 10:103
					new VerseInfo(15, 14),//Alma 10:104
					new VerseInfo(15, 15),//Alma 10:105
					new VerseInfo(15, 15),//Alma 10:106
					new VerseInfo(15, 16),//Alma 10:107
					new VerseInfo(15, 17),//Alma 10:108
					new VerseInfo(15, 17),//Alma 10:109
					new VerseInfo(15, 18),//Alma 10:110
					new VerseInfo(15, 19),//Alma 10:111
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 11
					new VerseInfo(16, 1),//Alma 11:1
					new VerseInfo(16, 2),//Alma 11:2
					new VerseInfo(16, 3),//Alma 11:3
					new VerseInfo(16, 4),//Alma 11:4
					new VerseInfo(16, 5),//Alma 11:5
					new VerseInfo(16, 5),//Alma 11:6
					new VerseInfo(16, 5),//Alma 11:7
					new VerseInfo(16, 6),//Alma 11:8
					new VerseInfo(16, 6),//Alma 11:9
					new VerseInfo(16, 6),//Alma 11:10
					new VerseInfo(16, 7),//Alma 11:11
					new VerseInfo(16, 8),//Alma 11:12
					new VerseInfo(16, 8),//Alma 11:13
					new VerseInfo(16, 9),//Alma 11:14
					new VerseInfo(16, 9),//Alma 11:15
					new VerseInfo(16, 10),//Alma 11:16
					new VerseInfo(16, 11),//Alma 11:17
					new VerseInfo(16, 11),//Alma 11:18
					new VerseInfo(16, 11),//Alma 11:19
					new VerseInfo(16, 12),//Alma 11:20
					new VerseInfo(16, 12),//Alma 11:21
					new VerseInfo(16, 13),//Alma 11:22
					new VerseInfo(16, 14),//Alma 11:23
					new VerseInfo(16, 15),//Alma 11:24
					new VerseInfo(16, 15),//Alma 11:25
					new VerseInfo(16, 16),//Alma 11:26
					new VerseInfo(16, 17),//Alma 11:27
					new VerseInfo(16, 17),//Alma 11:28
					new VerseInfo(16, 18),//Alma 11:29
					new VerseInfo(16, 19),//Alma 11:30
					new VerseInfo(16, 20),//Alma 11:31
					new VerseInfo(16, 21),//Alma 11:32
					new VerseInfo(16, 21),//Alma 11:33
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 12
					new VerseInfo(17, 1),//Alma 12:1
					new VerseInfo(17, 2),//Alma 12:2
					new VerseInfo(17, 2),//Alma 12:3
					new VerseInfo(17, 2),//Alma 12:4
					new VerseInfo(17, 3),//Alma 12:5
					new VerseInfo(17, 4),//Alma 12:6
					new VerseInfo(17, 4),//Alma 12:7
					new VerseInfo(17, 5),//Alma 12:8
					new VerseInfo(17, 5),//Alma 12:9
					new VerseInfo(17, 6),//Alma 12:10
					new VerseInfo(17, 7),//Alma 12:11
					new VerseInfo(17, 7),//Alma 12:12
					new VerseInfo(17, 8),//Alma 12:13
					new VerseInfo(17, 9),//Alma 12:14
					new VerseInfo(17, 9),//Alma 12:15
					new VerseInfo(17, 9),//Alma 12:16
					new VerseInfo(17, 10),//Alma 12:17
					new VerseInfo(17, 11),//Alma 12:18
					new VerseInfo(17, 11),//Alma 12:19
					new VerseInfo(17, 12),//Alma 12:20
					new VerseInfo(17, 13),//Alma 12:21
					new VerseInfo(17, 14),//Alma 12:22
					new VerseInfo(17, 14),//Alma 12:23
					new VerseInfo(17, 14),//Alma 12:24
					new VerseInfo(17, 15),//Alma 12:25
					new VerseInfo(17, 16),//Alma 12:26
					new VerseInfo(17, 17),//Alma 12:27
					new VerseInfo(17, 18),//Alma 12:28
					new VerseInfo(17, 19),//Alma 12:29
					new VerseInfo(17, 20),//Alma 12:30
					new VerseInfo(17, 20),//Alma 12:31
					new VerseInfo(17, 21),//Alma 12:32
					new VerseInfo(17, 22),//Alma 12:33
					new VerseInfo(17, 23),//Alma 12:34
					new VerseInfo(17, 24),//Alma 12:35
					new VerseInfo(17, 25),//Alma 12:36
					new VerseInfo(17, 25),//Alma 12:37
					new VerseInfo(17, 26),//Alma 12:38
					new VerseInfo(17, 27),//Alma 12:39
					new VerseInfo(17, 28),//Alma 12:40
					new VerseInfo(17, 28),//Alma 12:41
					new VerseInfo(17, 29),//Alma 12:42
					new VerseInfo(17, 29),//Alma 12:43
					new VerseInfo(17, 30),//Alma 12:44
					new VerseInfo(17, 31),//Alma 12:45
					new VerseInfo(17, 31),//Alma 12:46
					new VerseInfo(17, 32),//Alma 12:47
					new VerseInfo(17, 33),//Alma 12:48
					new VerseInfo(17, 34),//Alma 12:49
					new VerseInfo(17, 34, 17, 35),//Alma 12:50
					new VerseInfo(17, 35),//Alma 12:51
					new VerseInfo(17, 36),//Alma 12:52
					new VerseInfo(17, 36),//Alma 12:53
					new VerseInfo(17, 36),//Alma 12:54
					new VerseInfo(17, 36),//Alma 12:55
					new VerseInfo(17, 37),//Alma 12:56
					new VerseInfo(17, 37),//Alma 12:57
					new VerseInfo(17, 37),//Alma 12:58
					new VerseInfo(17, 38),//Alma 12:59
					new VerseInfo(17, 39),//Alma 12:60
					new VerseInfo(17, 39),//Alma 12:61
					new VerseInfo(18, 1),//Alma 12:62
					new VerseInfo(18, 2),//Alma 12:63
					new VerseInfo(18, 2),//Alma 12:64
					new VerseInfo(18, 3),//Alma 12:65
					new VerseInfo(18, 3),//Alma 12:66
					new VerseInfo(18, 3),//Alma 12:67
					new VerseInfo(18, 4),//Alma 12:68
					new VerseInfo(18, 4),//Alma 12:69
					new VerseInfo(18, 5),//Alma 12:70
					new VerseInfo(18, 5),//Alma 12:71
					new VerseInfo(18, 5),//Alma 12:72
					new VerseInfo(18, 6),//Alma 12:73
					new VerseInfo(18, 7),//Alma 12:74
					new VerseInfo(18, 8),//Alma 12:75
					new VerseInfo(18, 9),//Alma 12:76
					new VerseInfo(18, 9),//Alma 12:77
					new VerseInfo(18, 9),//Alma 12:78
					new VerseInfo(18, 10),//Alma 12:79
					new VerseInfo(18, 10),//Alma 12:80
					new VerseInfo(18, 11),//Alma 12:81
					new VerseInfo(18, 12),//Alma 12:82
					new VerseInfo(18, 13),//Alma 12:83
					new VerseInfo(18, 13),//Alma 12:84
					new VerseInfo(18, 14),//Alma 12:85
					new VerseInfo(18, 14),//Alma 12:86
					new VerseInfo(18, 15),//Alma 12:87
					new VerseInfo(18, 16),//Alma 12:88
					new VerseInfo(18, 16),//Alma 12:89
					new VerseInfo(18, 17),//Alma 12:90
					new VerseInfo(18, 17),//Alma 12:91
					new VerseInfo(18, 18),//Alma 12:92
					new VerseInfo(18, 18),//Alma 12:93
					new VerseInfo(18, 19),//Alma 12:94
					new VerseInfo(18, 20),//Alma 12:95
					new VerseInfo(18, 20),//Alma 12:96
					new VerseInfo(18, 21),//Alma 12:97
					new VerseInfo(18, 21),//Alma 12:98
					new VerseInfo(18, 22),//Alma 12:99
					new VerseInfo(18, 23),//Alma 12:100
					new VerseInfo(18, 24),//Alma 12:101
					new VerseInfo(18, 25),//Alma 12:102
					new VerseInfo(18, 26),//Alma 12:103
					new VerseInfo(18, 27),//Alma 12:104
					new VerseInfo(18, 28),//Alma 12:105
					new VerseInfo(18, 28),//Alma 12:106
					new VerseInfo(18, 29),//Alma 12:107
					new VerseInfo(18, 30),//Alma 12:108
					new VerseInfo(18, 31),//Alma 12:109
					new VerseInfo(18, 32),//Alma 12:110
					new VerseInfo(18, 33),//Alma 12:111
					new VerseInfo(18, 34),//Alma 12:112
					new VerseInfo(18, 35),//Alma 12:113
					new VerseInfo(18, 36),//Alma 12:114
					new VerseInfo(18, 36),//Alma 12:115
					new VerseInfo(18, 37),//Alma 12:116
					new VerseInfo(18, 38),//Alma 12:117
					new VerseInfo(18, 38),//Alma 12:118
					new VerseInfo(18, 39),//Alma 12:119
					new VerseInfo(18, 39),//Alma 12:120
					new VerseInfo(18, 40),//Alma 12:121
					new VerseInfo(18, 41),//Alma 12:122
					new VerseInfo(18, 42),//Alma 12:123
					new VerseInfo(18, 43),//Alma 12:124
					new VerseInfo(18, 43),//Alma 12:125
					new VerseInfo(19, 1),//Alma 12:126
					new VerseInfo(19, 2),//Alma 12:127
					new VerseInfo(19, 3),//Alma 12:128
					new VerseInfo(19, 4),//Alma 12:129
					new VerseInfo(19, 5),//Alma 12:130
					new VerseInfo(19, 5),//Alma 12:131
					new VerseInfo(19, 6),//Alma 12:132
					new VerseInfo(19, 6),//Alma 12:133
					new VerseInfo(19, 6),//Alma 12:134
					new VerseInfo(19, 6, 19, 7),//Alma 12:135
					new VerseInfo(19, 7),//Alma 12:136
					new VerseInfo(19, 8),//Alma 12:137
					new VerseInfo(19, 9),//Alma 12:138
					new VerseInfo(19, 9),//Alma 12:139
					new VerseInfo(19, 10),//Alma 12:140
					new VerseInfo(19, 11),//Alma 12:141
					new VerseInfo(19, 12),//Alma 12:142
					new VerseInfo(19, 13),//Alma 12:143
					new VerseInfo(19, 13),//Alma 12:144
					new VerseInfo(19, 14),//Alma 12:145
					new VerseInfo(19, 14),//Alma 12:146
					new VerseInfo(19, 14),//Alma 12:147
					new VerseInfo(19, 15),//Alma 12:148
					new VerseInfo(19, 15),//Alma 12:149
					new VerseInfo(19, 16, 19, 17),//Alma 12:150
					new VerseInfo(19, 17),//Alma 12:151
					new VerseInfo(19, 17),//Alma 12:152
					new VerseInfo(19, 17, 19, 18),//Alma 12:153
					new VerseInfo(19, 18),//Alma 12:154
					new VerseInfo(19, 18),//Alma 12:155
					new VerseInfo(19, 19),//Alma 12:156
					new VerseInfo(19, 20),//Alma 12:157
					new VerseInfo(19, 21),//Alma 12:158
					new VerseInfo(19, 21),//Alma 12:159
					new VerseInfo(19, 22),//Alma 12:160
					new VerseInfo(19, 23),//Alma 12:161
					new VerseInfo(19, 24),//Alma 12:162
					new VerseInfo(19, 24),//Alma 12:163
					new VerseInfo(19, 25),//Alma 12:164
					new VerseInfo(19, 26),//Alma 12:165
					new VerseInfo(19, 27),//Alma 12:166
					new VerseInfo(19, 27, 19, 28),//Alma 12:167
					new VerseInfo(19, 28),//Alma 12:168
					new VerseInfo(19, 29),//Alma 12:169
					new VerseInfo(19, 29),//Alma 12:170
					new VerseInfo(19, 30),//Alma 12:171
					new VerseInfo(19, 30),//Alma 12:172
					new VerseInfo(19, 31),//Alma 12:173
					new VerseInfo(19, 32),//Alma 12:174
					new VerseInfo(19, 33),//Alma 12:175
					new VerseInfo(19, 33),//Alma 12:176
					new VerseInfo(19, 34),//Alma 12:177
					new VerseInfo(19, 35),//Alma 12:178
					new VerseInfo(19, 36),//Alma 12:179
					new VerseInfo(19, 36),//Alma 12:180
					new VerseInfo(20, 1),//Alma 12:181
					new VerseInfo(20, 2),//Alma 12:182
					new VerseInfo(20, 3),//Alma 12:183
					new VerseInfo(20, 4),//Alma 12:184
					new VerseInfo(20, 4),//Alma 12:185
					new VerseInfo(20, 4),//Alma 12:186
					new VerseInfo(20, 5),//Alma 12:187
					new VerseInfo(20, 6),//Alma 12:188
					new VerseInfo(20, 7),//Alma 12:189
					new VerseInfo(20, 8),//Alma 12:190
					new VerseInfo(20, 9),//Alma 12:191
					new VerseInfo(20, 10),//Alma 12:192
					new VerseInfo(20, 11),//Alma 12:193
					new VerseInfo(20, 12),//Alma 12:194
					new VerseInfo(20, 13),//Alma 12:195
					new VerseInfo(20, 13),//Alma 12:196
					new VerseInfo(20, 14),//Alma 12:197
					new VerseInfo(20, 14),//Alma 12:198
					new VerseInfo(20, 15),//Alma 12:199
					new VerseInfo(20, 16),//Alma 12:200
					new VerseInfo(20, 17),//Alma 12:201
					new VerseInfo(20, 17),//Alma 12:202
					new VerseInfo(20, 18),//Alma 12:203
					new VerseInfo(20, 19, 20, 20),//Alma 12:204
					new VerseInfo(20, 20),//Alma 12:205
					new VerseInfo(20, 21),//Alma 12:206
					new VerseInfo(20, 22),//Alma 12:207
					new VerseInfo(20, 23),//Alma 12:208
					new VerseInfo(20, 24),//Alma 12:209
					new VerseInfo(20, 25),//Alma 12:210
					new VerseInfo(20, 26),//Alma 12:211
					new VerseInfo(20, 26),//Alma 12:212
					new VerseInfo(20, 27),//Alma 12:213
					new VerseInfo(20, 27),//Alma 12:214
					new VerseInfo(20, 28),//Alma 12:215
					new VerseInfo(20, 28),//Alma 12:216
					new VerseInfo(20, 29),//Alma 12:217
					new VerseInfo(20, 29),//Alma 12:218
					new VerseInfo(20, 30),//Alma 12:219
					new VerseInfo(20, 30),//Alma 12:220
					new VerseInfo(20, 30),//Alma 12:221
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 13
					new VerseInfo(21, 1),//Alma 13:1
					new VerseInfo(21, 2),//Alma 13:2
					new VerseInfo(21, 3),//Alma 13:3
					new VerseInfo(21, 4),//Alma 13:4
					new VerseInfo(21, 4),//Alma 13:5
					new VerseInfo(21, 5),//Alma 13:6
					new VerseInfo(21, 5, 21, 6),//Alma 13:7
					new VerseInfo(21, 6),//Alma 13:8
					new VerseInfo(21, 6),//Alma 13:9
					new VerseInfo(21, 7),//Alma 13:10
					new VerseInfo(21, 8),//Alma 13:11
					new VerseInfo(21, 8),//Alma 13:12
					new VerseInfo(21, 9),//Alma 13:13
					new VerseInfo(21, 10),//Alma 13:14
					new VerseInfo(21, 11),//Alma 13:15
					new VerseInfo(21, 12),//Alma 13:16
					new VerseInfo(21, 12),//Alma 13:17
					new VerseInfo(21, 13),//Alma 13:18
					new VerseInfo(21, 14),//Alma 13:19
					new VerseInfo(21, 15),//Alma 13:20
					new VerseInfo(21, 16),//Alma 13:21
					new VerseInfo(21, 17),//Alma 13:22
					new VerseInfo(21, 18),//Alma 13:23
					new VerseInfo(21, 19, 21, 20),//Alma 13:24
					new VerseInfo(21, 21),//Alma 13:25
					new VerseInfo(21, 21),//Alma 13:26
					new VerseInfo(21, 22),//Alma 13:27
					new VerseInfo(21, 23),//Alma 13:28
					new VerseInfo(21, 23),//Alma 13:29
					new VerseInfo(22, 1),//Alma 13:30
					new VerseInfo(22, 1),//Alma 13:31
					new VerseInfo(22, 2, 22, 3),//Alma 13:32
					new VerseInfo(22, 3),//Alma 13:33
					new VerseInfo(22, 3),//Alma 13:34
					new VerseInfo(22, 4),//Alma 13:35
					new VerseInfo(22, 5),//Alma 13:36
					new VerseInfo(22, 6),//Alma 13:37
					new VerseInfo(22, 7),//Alma 13:38
					new VerseInfo(22, 7),//Alma 13:39
					new VerseInfo(22, 8),//Alma 13:40
					new VerseInfo(22, 9),//Alma 13:41
					new VerseInfo(22, 10),//Alma 13:42
					new VerseInfo(22, 11),//Alma 13:43
					new VerseInfo(22, 12),//Alma 13:44
					new VerseInfo(22, 13),//Alma 13:45
					new VerseInfo(22, 14),//Alma 13:46
					new VerseInfo(22, 14),//Alma 13:47
					new VerseInfo(22, 15),//Alma 13:48
					new VerseInfo(22, 15),//Alma 13:49
					new VerseInfo(22, 15),//Alma 13:50
					new VerseInfo(22, 16),//Alma 13:51
					new VerseInfo(22, 17, 22, 18),//Alma 13:52
					new VerseInfo(22, 18),//Alma 13:53
					new VerseInfo(22, 18),//Alma 13:54
					new VerseInfo(22, 19),//Alma 13:55
					new VerseInfo(22, 19),//Alma 13:56
					new VerseInfo(22, 20),//Alma 13:57
					new VerseInfo(22, 20),//Alma 13:58
					new VerseInfo(22, 21),//Alma 13:59
					new VerseInfo(22, 21),//Alma 13:60
					new VerseInfo(22, 22),//Alma 13:61
					new VerseInfo(22, 22),//Alma 13:62
					new VerseInfo(22, 23),//Alma 13:63
					new VerseInfo(22, 23),//Alma 13:64
					new VerseInfo(22, 24),//Alma 13:65
					new VerseInfo(22, 25),//Alma 13:66
					new VerseInfo(22, 26),//Alma 13:67
					new VerseInfo(22, 27),//Alma 13:68
					new VerseInfo(22, 27),//Alma 13:69
					new VerseInfo(22, 28),//Alma 13:70
					new VerseInfo(22, 28),//Alma 13:71
					new VerseInfo(22, 29),//Alma 13:72
					new VerseInfo(22, 29),//Alma 13:73
					new VerseInfo(22, 30, 22, 31),//Alma 13:74
					new VerseInfo(22, 31),//Alma 13:75
					new VerseInfo(22, 32),//Alma 13:76
					new VerseInfo(22, 32),//Alma 13:77
					new VerseInfo(22, 33),//Alma 13:78
					new VerseInfo(22, 33),//Alma 13:79
					new VerseInfo(22, 34),//Alma 13:80
					new VerseInfo(22, 34),//Alma 13:81
					new VerseInfo(22, 35),//Alma 13:82
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 14
					new VerseInfo(23, 1),//Alma 14:1
					new VerseInfo(23, 2),//Alma 14:2
					new VerseInfo(23, 2),//Alma 14:3
					new VerseInfo(23, 3),//Alma 14:4
					new VerseInfo(23, 3),//Alma 14:5
					new VerseInfo(23, 3),//Alma 14:6
					new VerseInfo(23, 4),//Alma 14:7
					new VerseInfo(23, 4),//Alma 14:8
					new VerseInfo(23, 5),//Alma 14:9
					new VerseInfo(23, 6),//Alma 14:10
					new VerseInfo(23, 6, 23, 7),//Alma 14:11
					new VerseInfo(23, 7),//Alma 14:12
					new VerseInfo(23, 8, 23, 12),//Alma 14:13
					new VerseInfo(23, 13),//Alma 14:14
					new VerseInfo(23, 14),//Alma 14:15
					new VerseInfo(23, 15),//Alma 14:16
					new VerseInfo(23, 16),//Alma 14:17
					new VerseInfo(23, 16),//Alma 14:18
					new VerseInfo(23, 17),//Alma 14:19
					new VerseInfo(23, 18),//Alma 14:20
					new VerseInfo(24, 1),//Alma 14:21
					new VerseInfo(24, 2),//Alma 14:22
					new VerseInfo(24, 3),//Alma 14:23
					new VerseInfo(24, 4),//Alma 14:24
					new VerseInfo(24, 5),//Alma 14:25
					new VerseInfo(24, 5),//Alma 14:26
					new VerseInfo(24, 6),//Alma 14:27
					new VerseInfo(24, 6),//Alma 14:28
					new VerseInfo(24, 7),//Alma 14:29
					new VerseInfo(24, 8),//Alma 14:30
					new VerseInfo(24, 9),//Alma 14:31
					new VerseInfo(24, 10),//Alma 14:32
					new VerseInfo(24, 11),//Alma 14:33
					new VerseInfo(24, 12),//Alma 14:34
					new VerseInfo(24, 13),//Alma 14:35
					new VerseInfo(24, 13),//Alma 14:36
					new VerseInfo(24, 14),//Alma 14:37
					new VerseInfo(24, 14, 24, 15),//Alma 14:38
					new VerseInfo(24, 15),//Alma 14:39
					new VerseInfo(24, 15),//Alma 14:40
					new VerseInfo(24, 16),//Alma 14:41
					new VerseInfo(24, 17),//Alma 14:42
					new VerseInfo(24, 18),//Alma 14:43
					new VerseInfo(24, 18),//Alma 14:44
					new VerseInfo(24, 18),//Alma 14:45
					new VerseInfo(24, 19),//Alma 14:46
					new VerseInfo(24, 19),//Alma 14:47
					new VerseInfo(24, 20),//Alma 14:48
					new VerseInfo(24, 21),//Alma 14:49
					new VerseInfo(24, 21, 24, 22),//Alma 14:50
					new VerseInfo(24, 23, 24, 24),//Alma 14:51
					new VerseInfo(24, 24),//Alma 14:52
					new VerseInfo(24, 25),//Alma 14:53
					new VerseInfo(24, 26),//Alma 14:54
					new VerseInfo(24, 27),//Alma 14:55
					new VerseInfo(24, 28),//Alma 14:56
					new VerseInfo(24, 29),//Alma 14:57
					new VerseInfo(24, 30),//Alma 14:58
					new VerseInfo(25, 1),//Alma 14:59
					new VerseInfo(25, 1, 25, 2),//Alma 14:60
					new VerseInfo(25, 3),//Alma 14:61
					new VerseInfo(25, 4),//Alma 14:62
					new VerseInfo(25, 5),//Alma 14:63
					new VerseInfo(25, 6),//Alma 14:64
					new VerseInfo(25, 6),//Alma 14:65
					new VerseInfo(25, 7),//Alma 14:66
					new VerseInfo(25, 8),//Alma 14:67
					new VerseInfo(25, 9),//Alma 14:68
					new VerseInfo(25, 10),//Alma 14:69
					new VerseInfo(25, 11),//Alma 14:70
					new VerseInfo(25, 12),//Alma 14:71
					new VerseInfo(25, 12),//Alma 14:72
					new VerseInfo(25, 13),//Alma 14:73
					new VerseInfo(25, 14, 25, 15),//Alma 14:74
					new VerseInfo(25, 15),//Alma 14:75
					new VerseInfo(25, 16),//Alma 14:76
					new VerseInfo(25, 16),//Alma 14:77
					new VerseInfo(25, 17),//Alma 14:78
					new VerseInfo(26, 1),//Alma 14:79
					new VerseInfo(26, 2),//Alma 14:80
					new VerseInfo(26, 3),//Alma 14:81
					new VerseInfo(26, 3),//Alma 14:82
					new VerseInfo(26, 4),//Alma 14:83
					new VerseInfo(26, 5),//Alma 14:84
					new VerseInfo(26, 5, 26, 6),//Alma 14:85
					new VerseInfo(26, 6),//Alma 14:86
					new VerseInfo(26, 7),//Alma 14:87
					new VerseInfo(26, 8),//Alma 14:88
					new VerseInfo(26, 9),//Alma 14:89
					new VerseInfo(26, 10),//Alma 14:90
					new VerseInfo(26, 11),//Alma 14:91
					new VerseInfo(26, 12),//Alma 14:92
					new VerseInfo(26, 13),//Alma 14:93
					new VerseInfo(26, 14),//Alma 14:94
					new VerseInfo(26, 15),//Alma 14:95
					new VerseInfo(26, 15, 26, 16),//Alma 14:96
					new VerseInfo(26, 16),//Alma 14:97
					new VerseInfo(26, 17),//Alma 14:98
					new VerseInfo(26, 18, 26, 19),//Alma 14:99
					new VerseInfo(26, 20),//Alma 14:100
					new VerseInfo(26, 20),//Alma 14:101
					new VerseInfo(26, 21),//Alma 14:102
					new VerseInfo(26, 22),//Alma 14:103
					new VerseInfo(26, 22),//Alma 14:104
					new VerseInfo(26, 23),//Alma 14:105
					new VerseInfo(26, 24),//Alma 14:106
					new VerseInfo(26, 24),//Alma 14:107
					new VerseInfo(26, 24),//Alma 14:108
					new VerseInfo(26, 25),//Alma 14:109
					new VerseInfo(26, 26),//Alma 14:110
					new VerseInfo(26, 27),//Alma 14:111
					new VerseInfo(26, 28),//Alma 14:112
					new VerseInfo(26, 29),//Alma 14:113
					new VerseInfo(26, 29),//Alma 14:114
					new VerseInfo(26, 30),//Alma 14:115
					new VerseInfo(26, 31),//Alma 14:116
					new VerseInfo(26, 31),//Alma 14:117
					new VerseInfo(26, 32),//Alma 14:118
					new VerseInfo(26, 33),//Alma 14:119
					new VerseInfo(26, 33),//Alma 14:120
					new VerseInfo(26, 34),//Alma 14:121
					new VerseInfo(26, 34),//Alma 14:122
					new VerseInfo(26, 35),//Alma 14:123
					new VerseInfo(26, 35),//Alma 14:124
					new VerseInfo(26, 36),//Alma 14:125
					new VerseInfo(26, 36),//Alma 14:126
					new VerseInfo(26, 37),//Alma 14:127
					new VerseInfo(26, 37),//Alma 14:128
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 15
					new VerseInfo(27, 1),//Alma 15:1
					new VerseInfo(27, 2),//Alma 15:2
					new VerseInfo(27, 2),//Alma 15:3
					new VerseInfo(27, 3),//Alma 15:4
					new VerseInfo(27, 4),//Alma 15:5
					new VerseInfo(27, 4, 27, 5),//Alma 15:6
					new VerseInfo(27, 6),//Alma 15:7
					new VerseInfo(27, 7),//Alma 15:8
					new VerseInfo(27, 8),//Alma 15:9
					new VerseInfo(27, 9),//Alma 15:10
					new VerseInfo(27, 10),//Alma 15:11
					new VerseInfo(27, 11, 27, 12),//Alma 15:12
					new VerseInfo(27, 13),//Alma 15:13
					new VerseInfo(27, 14),//Alma 15:14
					new VerseInfo(27, 15),//Alma 15:15
					new VerseInfo(27, 16),//Alma 15:16
					new VerseInfo(27, 17),//Alma 15:17
					new VerseInfo(27, 18),//Alma 15:18
					new VerseInfo(27, 19),//Alma 15:19
					new VerseInfo(27, 20),//Alma 15:20
					new VerseInfo(27, 20),//Alma 15:21
					new VerseInfo(27, 21),//Alma 15:22
					new VerseInfo(27, 22),//Alma 15:23
					new VerseInfo(27, 23),//Alma 15:24
					new VerseInfo(27, 23),//Alma 15:25
					new VerseInfo(27, 24),//Alma 15:26
					new VerseInfo(27, 25),//Alma 15:27
					new VerseInfo(27, 25, 27, 26),//Alma 15:28
					new VerseInfo(27, 26),//Alma 15:29
					new VerseInfo(27, 26, 27, 27),//Alma 15:30
					new VerseInfo(27, 27),//Alma 15:31
					new VerseInfo(27, 28),//Alma 15:32
					new VerseInfo(27, 28),//Alma 15:33
					new VerseInfo(27, 29),//Alma 15:34
					new VerseInfo(27, 30),//Alma 15:35
					new VerseInfo(28, 1),//Alma 15:36
					new VerseInfo(28, 2),//Alma 15:37
					new VerseInfo(28, 3),//Alma 15:38
					new VerseInfo(28, 4),//Alma 15:39
					new VerseInfo(28, 5),//Alma 15:40
					new VerseInfo(28, 5),//Alma 15:41
					new VerseInfo(28, 6, 28, 7),//Alma 15:42
					new VerseInfo(28, 8),//Alma 15:43
					new VerseInfo(28, 8),//Alma 15:44
					new VerseInfo(28, 9),//Alma 15:45
					new VerseInfo(28, 10),//Alma 15:46
					new VerseInfo(28, 11),//Alma 15:47
					new VerseInfo(28, 11),//Alma 15:48
					new VerseInfo(28, 12),//Alma 15:49
					new VerseInfo(28, 13),//Alma 15:50
					new VerseInfo(28, 14),//Alma 15:51
					new VerseInfo(29, 1),//Alma 15:52
					new VerseInfo(29, 2),//Alma 15:53
					new VerseInfo(29, 3),//Alma 15:54
					new VerseInfo(29, 4),//Alma 15:55
					new VerseInfo(29, 5),//Alma 15:56
					new VerseInfo(29, 6),//Alma 15:57
					new VerseInfo(29, 7),//Alma 15:58
					new VerseInfo(29, 8),//Alma 15:59
					new VerseInfo(29, 9),//Alma 15:60
					new VerseInfo(29, 9),//Alma 15:61
					new VerseInfo(29, 10),//Alma 15:62
					new VerseInfo(29, 11),//Alma 15:63
					new VerseInfo(29, 12),//Alma 15:64
					new VerseInfo(29, 13, 29, 14),//Alma 15:65
					new VerseInfo(29, 15),//Alma 15:66
					new VerseInfo(29, 16),//Alma 15:67
					new VerseInfo(29, 17),//Alma 15:68
					new VerseInfo(29, 17),//Alma 15:69
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 16
					new VerseInfo(30, 1),//Alma 16:1
					new VerseInfo(30, 2),//Alma 16:2
					new VerseInfo(30, 2, 30, 3),//Alma 16:3
					new VerseInfo(30, 3),//Alma 16:4
					new VerseInfo(30, 4),//Alma 16:5
					new VerseInfo(30, 5),//Alma 16:6
					new VerseInfo(30, 6),//Alma 16:7
					new VerseInfo(30, 7),//Alma 16:8
					new VerseInfo(30, 8),//Alma 16:9
					new VerseInfo(30, 9),//Alma 16:10
					new VerseInfo(30, 10, 30, 11),//Alma 16:11
					new VerseInfo(30, 11),//Alma 16:12
					new VerseInfo(30, 12),//Alma 16:13
					new VerseInfo(30, 12, 30, 13),//Alma 16:14
					new VerseInfo(30, 14, 30, 15),//Alma 16:15
					new VerseInfo(30, 15),//Alma 16:16
					new VerseInfo(30, 16),//Alma 16:17
					new VerseInfo(30, 17),//Alma 16:18
					new VerseInfo(30, 18),//Alma 16:19
					new VerseInfo(30, 19),//Alma 16:20
					new VerseInfo(30, 20),//Alma 16:21
					new VerseInfo(30, 21),//Alma 16:22
					new VerseInfo(30, 21),//Alma 16:23
					new VerseInfo(30, 22),//Alma 16:24
					new VerseInfo(30, 22),//Alma 16:25
					new VerseInfo(30, 22),//Alma 16:26
					new VerseInfo(30, 23),//Alma 16:27
					new VerseInfo(30, 23),//Alma 16:28
					new VerseInfo(30, 24),//Alma 16:29
					new VerseInfo(30, 24),//Alma 16:30
					new VerseInfo(30, 25),//Alma 16:31
					new VerseInfo(30, 26),//Alma 16:32
					new VerseInfo(30, 26, 30, 27),//Alma 16:33
					new VerseInfo(30, 27),//Alma 16:34
					new VerseInfo(30, 28),//Alma 16:35
					new VerseInfo(30, 29),//Alma 16:36
					new VerseInfo(30, 29),//Alma 16:37
					new VerseInfo(30, 30),//Alma 16:38
					new VerseInfo(30, 31),//Alma 16:39
					new VerseInfo(30, 32),//Alma 16:40
					new VerseInfo(30, 33),//Alma 16:41
					new VerseInfo(30, 34),//Alma 16:42
					new VerseInfo(30, 35),//Alma 16:43
					new VerseInfo(30, 35),//Alma 16:44
					new VerseInfo(30, 36),//Alma 16:45
					new VerseInfo(30, 37, 30, 38),//Alma 16:46
					new VerseInfo(30, 39),//Alma 16:47
					new VerseInfo(30, 40),//Alma 16:48
					new VerseInfo(30, 41),//Alma 16:49
					new VerseInfo(30, 41),//Alma 16:50
					new VerseInfo(30, 42),//Alma 16:51
					new VerseInfo(30, 43),//Alma 16:52
					new VerseInfo(30, 44),//Alma 16:53
					new VerseInfo(30, 44),//Alma 16:54
					new VerseInfo(30, 44, 30, 45),//Alma 16:55
					new VerseInfo(30, 45),//Alma 16:56
					new VerseInfo(30, 46),//Alma 16:57
					new VerseInfo(30, 47),//Alma 16:58
					new VerseInfo(30, 47),//Alma 16:59
					new VerseInfo(30, 48),//Alma 16:60
					new VerseInfo(30, 49),//Alma 16:61
					new VerseInfo(30, 50),//Alma 16:62
					new VerseInfo(30, 51),//Alma 16:63
					new VerseInfo(30, 51),//Alma 16:64
					new VerseInfo(30, 51),//Alma 16:65
					new VerseInfo(30, 52),//Alma 16:66
					new VerseInfo(30, 53),//Alma 16:67
					new VerseInfo(30, 53),//Alma 16:68
					new VerseInfo(30, 53),//Alma 16:69
					new VerseInfo(30, 54),//Alma 16:70
					new VerseInfo(30, 55),//Alma 16:71
					new VerseInfo(30, 56),//Alma 16:72
					new VerseInfo(30, 57),//Alma 16:73
					new VerseInfo(30, 58),//Alma 16:74
					new VerseInfo(30, 58),//Alma 16:75
					new VerseInfo(30, 59),//Alma 16:76
					new VerseInfo(30, 60),//Alma 16:77
					new VerseInfo(31, 1),//Alma 16:78
					new VerseInfo(31, 2),//Alma 16:79
					new VerseInfo(31, 3),//Alma 16:80
					new VerseInfo(31, 4),//Alma 16:81
					new VerseInfo(31, 5),//Alma 16:82
					new VerseInfo(31, 6),//Alma 16:83
					new VerseInfo(31, 7),//Alma 16:84
					new VerseInfo(31, 8),//Alma 16:85
					new VerseInfo(31, 9),//Alma 16:86
					new VerseInfo(31, 10, 31, 11),//Alma 16:87
					new VerseInfo(31, 12),//Alma 16:88
					new VerseInfo(31, 12, 31, 13),//Alma 16:89
					new VerseInfo(31, 14, 31, 15),//Alma 16:90
					new VerseInfo(31, 16),//Alma 16:91
					new VerseInfo(31, 16, 31, 17),//Alma 16:92
					new VerseInfo(31, 17),//Alma 16:93
					new VerseInfo(31, 18),//Alma 16:94
					new VerseInfo(31, 19),//Alma 16:95
					new VerseInfo(31, 20),//Alma 16:96
					new VerseInfo(31, 21),//Alma 16:97
					new VerseInfo(31, 22),//Alma 16:98
					new VerseInfo(31, 23),//Alma 16:99
					new VerseInfo(31, 24),//Alma 16:100
					new VerseInfo(31, 25),//Alma 16:101
					new VerseInfo(31, 26),//Alma 16:102
					new VerseInfo(31, 27),//Alma 16:103
					new VerseInfo(31, 27),//Alma 16:104
					new VerseInfo(31, 28),//Alma 16:105
					new VerseInfo(31, 28),//Alma 16:106
					new VerseInfo(31, 29),//Alma 16:107
					new VerseInfo(31, 30),//Alma 16:108
					new VerseInfo(31, 30),//Alma 16:109
					new VerseInfo(31, 31),//Alma 16:110
					new VerseInfo(31, 31),//Alma 16:111
					new VerseInfo(31, 32),//Alma 16:112
					new VerseInfo(31, 33),//Alma 16:113
					new VerseInfo(31, 34),//Alma 16:114
					new VerseInfo(31, 35),//Alma 16:115
					new VerseInfo(31, 36),//Alma 16:116
					new VerseInfo(31, 36),//Alma 16:117
					new VerseInfo(31, 37),//Alma 16:118
					new VerseInfo(31, 38),//Alma 16:119
					new VerseInfo(31, 38),//Alma 16:120
					new VerseInfo(32, 1),//Alma 16:121
					new VerseInfo(32, 2),//Alma 16:122
					new VerseInfo(32, 3),//Alma 16:123
					new VerseInfo(32, 4),//Alma 16:124
					new VerseInfo(32, 5),//Alma 16:125
					new VerseInfo(32, 5),//Alma 16:126
					new VerseInfo(32, 6),//Alma 16:127
					new VerseInfo(32, 7, 32, 8),//Alma 16:128
					new VerseInfo(32, 9),//Alma 16:129
					new VerseInfo(32, 10),//Alma 16:130
					new VerseInfo(32, 11),//Alma 16:131
					new VerseInfo(32, 12),//Alma 16:132
					new VerseInfo(32, 12),//Alma 16:133
					new VerseInfo(32, 13),//Alma 16:134
					new VerseInfo(32, 13),//Alma 16:135
					new VerseInfo(32, 14),//Alma 16:136
					new VerseInfo(32, 15, 32, 16),//Alma 16:137
					new VerseInfo(32, 16),//Alma 16:138
					new VerseInfo(32, 17),//Alma 16:139
					new VerseInfo(32, 18),//Alma 16:140
					new VerseInfo(32, 19, 32, 20),//Alma 16:141
					new VerseInfo(32, 20),//Alma 16:142
					new VerseInfo(32, 21),//Alma 16:143
					new VerseInfo(32, 22),//Alma 16:144
					new VerseInfo(32, 23),//Alma 16:145
					new VerseInfo(32, 23),//Alma 16:146
					new VerseInfo(32, 24),//Alma 16:147
					new VerseInfo(32, 25),//Alma 16:148
					new VerseInfo(32, 26),//Alma 16:149
					new VerseInfo(32, 26),//Alma 16:150
					new VerseInfo(32, 27),//Alma 16:151
					new VerseInfo(32, 28),//Alma 16:152
					new VerseInfo(32, 28),//Alma 16:153
					new VerseInfo(32, 28),//Alma 16:154
					new VerseInfo(32, 29),//Alma 16:155
					new VerseInfo(32, 30),//Alma 16:156
					new VerseInfo(32, 30),//Alma 16:157
					new VerseInfo(32, 31, 32, 32),//Alma 16:158
					new VerseInfo(32, 33),//Alma 16:159
					new VerseInfo(32, 34),//Alma 16:160
					new VerseInfo(32, 34),//Alma 16:161
					new VerseInfo(32, 35),//Alma 16:162
					new VerseInfo(32, 35, 32, 36),//Alma 16:163
					new VerseInfo(32, 37),//Alma 16:164
					new VerseInfo(32, 37),//Alma 16:165
					new VerseInfo(32, 38),//Alma 16:166
					new VerseInfo(32, 39),//Alma 16:167
					new VerseInfo(32, 39),//Alma 16:168
					new VerseInfo(32, 40),//Alma 16:169
					new VerseInfo(32, 41),//Alma 16:170
					new VerseInfo(32, 42),//Alma 16:171
					new VerseInfo(32, 42),//Alma 16:172
					new VerseInfo(32, 43),//Alma 16:173
					new VerseInfo(33, 1),//Alma 16:174
					new VerseInfo(33, 2),//Alma 16:175
					new VerseInfo(33, 2),//Alma 16:176
					new VerseInfo(33, 3),//Alma 16:177
					new VerseInfo(33, 4),//Alma 16:178
					new VerseInfo(33, 5),//Alma 16:179
					new VerseInfo(33, 6),//Alma 16:180
					new VerseInfo(33, 7, 33, 8),//Alma 16:181
					new VerseInfo(33, 9, 33, 10),//Alma 16:182
					new VerseInfo(33, 10, 33, 11),//Alma 16:183
					new VerseInfo(33, 11),//Alma 16:184
					new VerseInfo(33, 12),//Alma 16:185
					new VerseInfo(33, 13),//Alma 16:186
					new VerseInfo(33, 14),//Alma 16:187
					new VerseInfo(33, 15, 33, 16),//Alma 16:188
					new VerseInfo(33, 17),//Alma 16:189
					new VerseInfo(33, 18),//Alma 16:190
					new VerseInfo(33, 19),//Alma 16:191
					new VerseInfo(33, 20),//Alma 16:192
					new VerseInfo(33, 20),//Alma 16:193
					new VerseInfo(33, 20),//Alma 16:194
					new VerseInfo(33, 21),//Alma 16:195
					new VerseInfo(33, 22),//Alma 16:196
					new VerseInfo(33, 22),//Alma 16:197
					new VerseInfo(33, 23),//Alma 16:198
					new VerseInfo(33, 23),//Alma 16:199
					new VerseInfo(33, 23),//Alma 16:200
					new VerseInfo(34, 1, 34, 2),//Alma 16:201
					new VerseInfo(34, 2, 34, 3),//Alma 16:202
					new VerseInfo(34, 4, 34, 5),//Alma 16:203
					new VerseInfo(34, 6),//Alma 16:204
					new VerseInfo(34, 7),//Alma 16:205
					new VerseInfo(34, 8),//Alma 16:206
					new VerseInfo(34, 8),//Alma 16:207
					new VerseInfo(34, 9),//Alma 16:208
					new VerseInfo(34, 9),//Alma 16:209
					new VerseInfo(34, 10),//Alma 16:210
					new VerseInfo(34, 11),//Alma 16:211
					new VerseInfo(34, 11),//Alma 16:212
					new VerseInfo(34, 12, 34, 13),//Alma 16:213
					new VerseInfo(34, 13),//Alma 16:214
					new VerseInfo(34, 14, 34, 15),//Alma 16:215
					new VerseInfo(34, 15),//Alma 16:216
					new VerseInfo(34, 16),//Alma 16:217
					new VerseInfo(34, 17, 34, 18),//Alma 16:218
					new VerseInfo(34, 19, 34, 23),//Alma 16:219
					new VerseInfo(34, 24, 34, 25),//Alma 16:220
					new VerseInfo(34, 26),//Alma 16:221
					new VerseInfo(34, 27),//Alma 16:222
					new VerseInfo(34, 28),//Alma 16:223
					new VerseInfo(34, 28),//Alma 16:224
					new VerseInfo(34, 29),//Alma 16:225
					new VerseInfo(34, 30),//Alma 16:226
					new VerseInfo(34, 31),//Alma 16:227
					new VerseInfo(34, 32),//Alma 16:228
					new VerseInfo(34, 33),//Alma 16:229
					new VerseInfo(34, 33),//Alma 16:230
					new VerseInfo(34, 34),//Alma 16:231
					new VerseInfo(34, 34),//Alma 16:232
					new VerseInfo(34, 35),//Alma 16:233
					new VerseInfo(34, 35),//Alma 16:234
					new VerseInfo(34, 36),//Alma 16:235
					new VerseInfo(34, 36),//Alma 16:236
					new VerseInfo(34, 37, 34, 38),//Alma 16:237
					new VerseInfo(34, 38, 34, 39),//Alma 16:238
					new VerseInfo(34, 40, 34, 41),//Alma 16:239
					new VerseInfo(35, 1),//Alma 16:240
					new VerseInfo(35, 2),//Alma 16:241
					new VerseInfo(35, 3),//Alma 16:242
					new VerseInfo(35, 4),//Alma 16:243
					new VerseInfo(35, 5),//Alma 16:244
					new VerseInfo(35, 6),//Alma 16:245
					new VerseInfo(35, 7),//Alma 16:246
					new VerseInfo(35, 8),//Alma 16:247
					new VerseInfo(35, 9),//Alma 16:248
					new VerseInfo(35, 9),//Alma 16:249
					new VerseInfo(35, 9),//Alma 16:250
					new VerseInfo(35, 10),//Alma 16:251
					new VerseInfo(35, 11),//Alma 16:252
					new VerseInfo(35, 12),//Alma 16:253
					new VerseInfo(35, 13),//Alma 16:254
					new VerseInfo(35, 13),//Alma 16:255
					new VerseInfo(35, 14),//Alma 16:256
					new VerseInfo(35, 14),//Alma 16:257
					new VerseInfo(35, 15),//Alma 16:258
					new VerseInfo(35, 15),//Alma 16:259
					new VerseInfo(35, 16),//Alma 16:260
					new VerseInfo(35, 16),//Alma 16:261
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 17
					new VerseInfo(36, 1),//Alma 17:1
					new VerseInfo(36, 2),//Alma 17:2
					new VerseInfo(36, 3),//Alma 17:3
					new VerseInfo(36, 4),//Alma 17:4
					new VerseInfo(36, 5, 36, 6),//Alma 17:5
					new VerseInfo(36, 7),//Alma 17:6
					new VerseInfo(36, 8, 36, 9),//Alma 17:7
					new VerseInfo(36, 10),//Alma 17:8
					new VerseInfo(36, 11),//Alma 17:9
					new VerseInfo(36, 12, 36, 13),//Alma 17:10
					new VerseInfo(36, 13, 36, 14),//Alma 17:11
					new VerseInfo(36, 14),//Alma 17:12
					new VerseInfo(36, 15),//Alma 17:13
					new VerseInfo(36, 16),//Alma 17:14
					new VerseInfo(36, 17),//Alma 17:15
					new VerseInfo(36, 18),//Alma 17:16
					new VerseInfo(36, 19),//Alma 17:17
					new VerseInfo(36, 20, 36, 21),//Alma 17:18
					new VerseInfo(36, 21),//Alma 17:19
					new VerseInfo(36, 22),//Alma 17:20
					new VerseInfo(36, 23),//Alma 17:21
					new VerseInfo(36, 24),//Alma 17:22
					new VerseInfo(36, 25, 36, 26),//Alma 17:23
					new VerseInfo(36, 26),//Alma 17:24
					new VerseInfo(36, 27),//Alma 17:25
					new VerseInfo(36, 28),//Alma 17:26
					new VerseInfo(36, 28, 36, 29),//Alma 17:27
					new VerseInfo(36, 29),//Alma 17:28
					new VerseInfo(36, 30),//Alma 17:29
					new VerseInfo(36, 30),//Alma 17:30
					new VerseInfo(37, 1, 37, 2),//Alma 17:31
					new VerseInfo(37, 3),//Alma 17:32
					new VerseInfo(37, 4),//Alma 17:33
					new VerseInfo(37, 5),//Alma 17:34
					new VerseInfo(37, 6),//Alma 17:35
					new VerseInfo(37, 7),//Alma 17:36
					new VerseInfo(37, 8),//Alma 17:37
					new VerseInfo(37, 9),//Alma 17:38
					new VerseInfo(37, 9),//Alma 17:39
					new VerseInfo(37, 10),//Alma 17:40
					new VerseInfo(37, 11),//Alma 17:41
					new VerseInfo(37, 12),//Alma 17:42
					new VerseInfo(37, 13),//Alma 17:43
					new VerseInfo(37, 13),//Alma 17:44
					new VerseInfo(37, 14),//Alma 17:45
					new VerseInfo(37, 15),//Alma 17:46
					new VerseInfo(37, 16),//Alma 17:47
					new VerseInfo(37, 17),//Alma 17:48
					new VerseInfo(37, 18),//Alma 17:49
					new VerseInfo(37, 19),//Alma 17:50
					new VerseInfo(37, 20),//Alma 17:51
					new VerseInfo(37, 21),//Alma 17:52
					new VerseInfo(37, 21),//Alma 17:53
					new VerseInfo(37, 22),//Alma 17:54
					new VerseInfo(37, 23),//Alma 17:55
					new VerseInfo(37, 24, 37, 25),//Alma 17:56
					new VerseInfo(37, 25),//Alma 17:57
					new VerseInfo(37, 26),//Alma 17:58
					new VerseInfo(37, 27),//Alma 17:59
					new VerseInfo(37, 28),//Alma 17:60
					new VerseInfo(37, 29),//Alma 17:61
					new VerseInfo(37, 29),//Alma 17:62
					new VerseInfo(37, 30),//Alma 17:63
					new VerseInfo(37, 30, 37, 31),//Alma 17:64
					new VerseInfo(37, 32),//Alma 17:65
					new VerseInfo(37, 33),//Alma 17:66
					new VerseInfo(37, 34),//Alma 17:67
					new VerseInfo(37, 35, 37, 36),//Alma 17:68
					new VerseInfo(37, 36, 37, 37),//Alma 17:69
					new VerseInfo(37, 37),//Alma 17:70
					new VerseInfo(37, 38),//Alma 17:71
					new VerseInfo(37, 39),//Alma 17:72
					new VerseInfo(37, 39, 37, 40),//Alma 17:73
					new VerseInfo(37, 40),//Alma 17:74
					new VerseInfo(37, 41),//Alma 17:75
					new VerseInfo(37, 41),//Alma 17:76
					new VerseInfo(37, 42),//Alma 17:77
					new VerseInfo(37, 43),//Alma 17:78
					new VerseInfo(37, 44),//Alma 17:79
					new VerseInfo(37, 45),//Alma 17:80
					new VerseInfo(37, 46),//Alma 17:81
					new VerseInfo(37, 46),//Alma 17:82
					new VerseInfo(37, 47),//Alma 17:83
					new VerseInfo(37, 47),//Alma 17:84
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 18
					new VerseInfo(38, 1),//Alma 18:1
					new VerseInfo(38, 2),//Alma 18:2
					new VerseInfo(38, 3),//Alma 18:3
					new VerseInfo(38, 4),//Alma 18:4
					new VerseInfo(38, 5),//Alma 18:5
					new VerseInfo(38, 6),//Alma 18:6
					new VerseInfo(38, 7),//Alma 18:7
					new VerseInfo(38, 7),//Alma 18:8
					new VerseInfo(38, 8),//Alma 18:9
					new VerseInfo(38, 8),//Alma 18:10
					new VerseInfo(38, 9),//Alma 18:11
					new VerseInfo(38, 9),//Alma 18:12
					new VerseInfo(38, 10),//Alma 18:13
					new VerseInfo(38, 11, 38, 12),//Alma 18:14
					new VerseInfo(38, 12, 38, 13),//Alma 18:15
					new VerseInfo(38, 14),//Alma 18:16
					new VerseInfo(38, 15),//Alma 18:17
					new VerseInfo(38, 15),//Alma 18:18
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 19
					new VerseInfo(39, 1),//Alma 19:1
					new VerseInfo(39, 1),//Alma 19:2
					new VerseInfo(39, 2),//Alma 19:3
					new VerseInfo(39, 2),//Alma 19:4
					new VerseInfo(39, 3, 39, 4),//Alma 19:5
					new VerseInfo(39, 4),//Alma 19:6
					new VerseInfo(39, 5),//Alma 19:7
					new VerseInfo(39, 6),//Alma 19:8
					new VerseInfo(39, 6),//Alma 19:9
					new VerseInfo(39, 7),//Alma 19:10
					new VerseInfo(39, 7),//Alma 19:11
					new VerseInfo(39, 8),//Alma 19:12
					new VerseInfo(39, 9),//Alma 19:13
					new VerseInfo(39, 9),//Alma 19:14
					new VerseInfo(39, 10),//Alma 19:15
					new VerseInfo(39, 10, 39, 11),//Alma 19:16
					new VerseInfo(39, 11),//Alma 19:17
					new VerseInfo(39, 12),//Alma 19:18
					new VerseInfo(39, 12, 39, 13),//Alma 19:19
					new VerseInfo(39, 13, 39, 14),//Alma 19:20
					new VerseInfo(39, 15),//Alma 19:21
					new VerseInfo(39, 15),//Alma 19:22
					new VerseInfo(39, 16),//Alma 19:23
					new VerseInfo(39, 17),//Alma 19:24
					new VerseInfo(39, 17),//Alma 19:25
					new VerseInfo(39, 18),//Alma 19:26
					new VerseInfo(39, 19),//Alma 19:27
					new VerseInfo(40, 1),//Alma 19:28
					new VerseInfo(40, 2),//Alma 19:29
					new VerseInfo(40, 3),//Alma 19:30
					new VerseInfo(40, 3),//Alma 19:31
					new VerseInfo(40, 3),//Alma 19:32
					new VerseInfo(40, 4),//Alma 19:33
					new VerseInfo(40, 4),//Alma 19:34
					new VerseInfo(40, 5),//Alma 19:35
					new VerseInfo(40, 6),//Alma 19:36
					new VerseInfo(40, 7),//Alma 19:37
					new VerseInfo(40, 8),//Alma 19:38
					new VerseInfo(40, 9),//Alma 19:39
					new VerseInfo(40, 9),//Alma 19:40
					new VerseInfo(40, 10),//Alma 19:41
					new VerseInfo(40, 11),//Alma 19:42
					new VerseInfo(40, 11),//Alma 19:43
					new VerseInfo(40, 12),//Alma 19:44
					new VerseInfo(40, 13),//Alma 19:45
					new VerseInfo(40, 13),//Alma 19:46
					new VerseInfo(40, 14),//Alma 19:47
					new VerseInfo(40, 15),//Alma 19:48
					new VerseInfo(40, 15),//Alma 19:49
					new VerseInfo(40, 16),//Alma 19:50
					new VerseInfo(40, 17),//Alma 19:51
					new VerseInfo(40, 18),//Alma 19:52
					new VerseInfo(40, 19),//Alma 19:53
					new VerseInfo(40, 19),//Alma 19:54
					new VerseInfo(40, 20),//Alma 19:55
					new VerseInfo(40, 21),//Alma 19:56
					new VerseInfo(40, 22),//Alma 19:57
					new VerseInfo(40, 23),//Alma 19:58
					new VerseInfo(40, 24, 40, 25),//Alma 19:59
					new VerseInfo(40, 26),//Alma 19:60
					new VerseInfo(40, 26),//Alma 19:61
					new VerseInfo(41, 1),//Alma 19:62
					new VerseInfo(41, 1),//Alma 19:63
					new VerseInfo(41, 2),//Alma 19:64
					new VerseInfo(41, 2),//Alma 19:65
					new VerseInfo(41, 3),//Alma 19:66
					new VerseInfo(41, 4),//Alma 19:67
					new VerseInfo(41, 4, 41, 5),//Alma 19:68
					new VerseInfo(41, 6),//Alma 19:69
					new VerseInfo(41, 7),//Alma 19:70
					new VerseInfo(41, 8),//Alma 19:71
					new VerseInfo(41, 9),//Alma 19:72
					new VerseInfo(41, 10),//Alma 19:73
					new VerseInfo(41, 10),//Alma 19:74
					new VerseInfo(41, 11),//Alma 19:75
					new VerseInfo(41, 12),//Alma 19:76
					new VerseInfo(41, 13),//Alma 19:77
					new VerseInfo(41, 14),//Alma 19:78
					new VerseInfo(41, 14),//Alma 19:79
					new VerseInfo(41, 14, 41, 15),//Alma 19:80
					new VerseInfo(42, 1),//Alma 19:81
					new VerseInfo(42, 2),//Alma 19:82
					new VerseInfo(42, 3),//Alma 19:83
					new VerseInfo(42, 4),//Alma 19:84
					new VerseInfo(42, 5),//Alma 19:85
					new VerseInfo(42, 5),//Alma 19:86
					new VerseInfo(42, 6),//Alma 19:87
					new VerseInfo(42, 7),//Alma 19:88
					new VerseInfo(42, 8),//Alma 19:89
					new VerseInfo(42, 9),//Alma 19:90
					new VerseInfo(42, 10),//Alma 19:91
					new VerseInfo(42, 11),//Alma 19:92
					new VerseInfo(42, 12),//Alma 19:93
					new VerseInfo(42, 13),//Alma 19:94
					new VerseInfo(42, 13),//Alma 19:95
					new VerseInfo(42, 14),//Alma 19:96
					new VerseInfo(42, 15),//Alma 19:97
					new VerseInfo(42, 16),//Alma 19:98
					new VerseInfo(42, 17),//Alma 19:99
					new VerseInfo(42, 18),//Alma 19:100
					new VerseInfo(42, 19),//Alma 19:101
					new VerseInfo(42, 20),//Alma 19:102
					new VerseInfo(42, 21),//Alma 19:103
					new VerseInfo(42, 22),//Alma 19:104
					new VerseInfo(42, 23),//Alma 19:105
					new VerseInfo(42, 23, 42, 24),//Alma 19:106
					new VerseInfo(42, 25),//Alma 19:107
					new VerseInfo(42, 26),//Alma 19:108
					new VerseInfo(42, 26, 42, 27),//Alma 19:109
					new VerseInfo(42, 27),//Alma 19:110
					new VerseInfo(42, 28),//Alma 19:111
					new VerseInfo(42, 29),//Alma 19:112
					new VerseInfo(42, 30),//Alma 19:113
					new VerseInfo(42, 30),//Alma 19:114
					new VerseInfo(42, 31),//Alma 19:115
					new VerseInfo(42, 31),//Alma 19:116
					new VerseInfo(42, 31),//Alma 19:117
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 20
					new VerseInfo(43, 1),//Alma 20:1
					new VerseInfo(43, 2),//Alma 20:2
					new VerseInfo(43, 3),//Alma 20:3
					new VerseInfo(43, 4),//Alma 20:4
					new VerseInfo(43, 5),//Alma 20:5
					new VerseInfo(43, 6),//Alma 20:6
					new VerseInfo(43, 7),//Alma 20:7
					new VerseInfo(43, 8),//Alma 20:8
					new VerseInfo(43, 9),//Alma 20:9
					new VerseInfo(43, 9, 43, 10),//Alma 20:10
					new VerseInfo(43, 11),//Alma 20:11
					new VerseInfo(43, 11),//Alma 20:12
					new VerseInfo(43, 12),//Alma 20:13
					new VerseInfo(43, 13),//Alma 20:14
					new VerseInfo(43, 13),//Alma 20:15
					new VerseInfo(43, 14),//Alma 20:16
					new VerseInfo(43, 15),//Alma 20:17
					new VerseInfo(43, 16),//Alma 20:18
					new VerseInfo(43, 17),//Alma 20:19
					new VerseInfo(43, 18),//Alma 20:20
					new VerseInfo(43, 19),//Alma 20:21
					new VerseInfo(43, 20),//Alma 20:22
					new VerseInfo(43, 20),//Alma 20:23
					new VerseInfo(43, 21),//Alma 20:24
					new VerseInfo(43, 22),//Alma 20:25
					new VerseInfo(43, 23),//Alma 20:26
					new VerseInfo(43, 24),//Alma 20:27
					new VerseInfo(43, 24),//Alma 20:28
					new VerseInfo(43, 25),//Alma 20:29
					new VerseInfo(43, 26),//Alma 20:30
					new VerseInfo(43, 27),//Alma 20:31
					new VerseInfo(43, 28),//Alma 20:32
					new VerseInfo(43, 29),//Alma 20:33
					new VerseInfo(43, 30),//Alma 20:34
					new VerseInfo(43, 31, 43, 32),//Alma 20:35
					new VerseInfo(43, 33),//Alma 20:36
					new VerseInfo(43, 34),//Alma 20:37
					new VerseInfo(43, 35),//Alma 20:38
					new VerseInfo(43, 36, 43, 37),//Alma 20:39
					new VerseInfo(43, 37, 43, 38),//Alma 20:40
					new VerseInfo(43, 38),//Alma 20:41
					new VerseInfo(43, 39),//Alma 20:42
					new VerseInfo(43, 40),//Alma 20:43
					new VerseInfo(43, 40),//Alma 20:44
					new VerseInfo(43, 41),//Alma 20:45
					new VerseInfo(43, 42),//Alma 20:46
					new VerseInfo(43, 43),//Alma 20:47
					new VerseInfo(43, 44),//Alma 20:48
					new VerseInfo(43, 44),//Alma 20:49
					new VerseInfo(43, 45),//Alma 20:50
					new VerseInfo(43, 46),//Alma 20:51
					new VerseInfo(43, 47),//Alma 20:52
					new VerseInfo(43, 48),//Alma 20:53
					new VerseInfo(43, 48),//Alma 20:54
					new VerseInfo(43, 49),//Alma 20:55
					new VerseInfo(43, 50),//Alma 20:56
					new VerseInfo(43, 51),//Alma 20:57
					new VerseInfo(43, 52),//Alma 20:58
					new VerseInfo(43, 53),//Alma 20:59
					new VerseInfo(43, 54),//Alma 20:60
					new VerseInfo(44, 1),//Alma 20:61
					new VerseInfo(44, 1),//Alma 20:62
					new VerseInfo(44, 1),//Alma 20:63
					new VerseInfo(44, 2),//Alma 20:64
					new VerseInfo(44, 2),//Alma 20:65
					new VerseInfo(44, 3),//Alma 20:66
					new VerseInfo(44, 3),//Alma 20:67
					new VerseInfo(44, 4),//Alma 20:68
					new VerseInfo(44, 4),//Alma 20:69
					new VerseInfo(44, 5),//Alma 20:70
					new VerseInfo(44, 5, 44, 6),//Alma 20:71
					new VerseInfo(44, 7),//Alma 20:72
					new VerseInfo(44, 7),//Alma 20:73
					new VerseInfo(44, 8),//Alma 20:74
					new VerseInfo(44, 8),//Alma 20:75
					new VerseInfo(44, 9),//Alma 20:76
					new VerseInfo(44, 9),//Alma 20:77
					new VerseInfo(44, 10),//Alma 20:78
					new VerseInfo(44, 11),//Alma 20:79
					new VerseInfo(44, 11),//Alma 20:80
					new VerseInfo(44, 12),//Alma 20:81
					new VerseInfo(44, 12),//Alma 20:82
					new VerseInfo(44, 12),//Alma 20:83
					new VerseInfo(44, 13),//Alma 20:84
					new VerseInfo(44, 14),//Alma 20:85
					new VerseInfo(44, 15),//Alma 20:86
					new VerseInfo(44, 15),//Alma 20:87
					new VerseInfo(44, 16),//Alma 20:88
					new VerseInfo(44, 17),//Alma 20:89
					new VerseInfo(44, 17),//Alma 20:90
					new VerseInfo(44, 18),//Alma 20:91
					new VerseInfo(44, 18),//Alma 20:92
					new VerseInfo(44, 19),//Alma 20:93
					new VerseInfo(44, 20),//Alma 20:94
					new VerseInfo(44, 20),//Alma 20:95
					new VerseInfo(44, 21),//Alma 20:96
					new VerseInfo(44, 22),//Alma 20:97
					new VerseInfo(44, 23),//Alma 20:98
					new VerseInfo(44, 24),//Alma 20:99
					new VerseInfo(44, 24),//Alma 20:100
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 21
					new VerseInfo(45, 1),//Alma 21:1
					new VerseInfo(45, 1),//Alma 21:2
					new VerseInfo(45, 2),//Alma 21:3
					new VerseInfo(45, 3),//Alma 21:4
					new VerseInfo(45, 4, 45, 5),//Alma 21:5
					new VerseInfo(45, 6, 45, 7),//Alma 21:6
					new VerseInfo(45, 8),//Alma 21:7
					new VerseInfo(45, 9),//Alma 21:8
					new VerseInfo(45, 10),//Alma 21:9
					new VerseInfo(45, 11),//Alma 21:10
					new VerseInfo(45, 12),//Alma 21:11
					new VerseInfo(45, 12),//Alma 21:12
					new VerseInfo(45, 13),//Alma 21:13
					new VerseInfo(45, 14),//Alma 21:14
					new VerseInfo(45, 14),//Alma 21:15
					new VerseInfo(45, 15),//Alma 21:16
					new VerseInfo(45, 16),//Alma 21:17
					new VerseInfo(45, 16),//Alma 21:18
					new VerseInfo(45, 17),//Alma 21:19
					new VerseInfo(45, 18),//Alma 21:20
					new VerseInfo(45, 19),//Alma 21:21
					new VerseInfo(45, 19),//Alma 21:22
					new VerseInfo(45, 20),//Alma 21:23
					new VerseInfo(45, 21),//Alma 21:24
					new VerseInfo(45, 22),//Alma 21:25
					new VerseInfo(45, 22),//Alma 21:26
					new VerseInfo(45, 23),//Alma 21:27
					new VerseInfo(45, 24),//Alma 21:28
					new VerseInfo(46, 1),//Alma 21:29
					new VerseInfo(46, 2),//Alma 21:30
					new VerseInfo(46, 3),//Alma 21:31
					new VerseInfo(46, 4),//Alma 21:32
					new VerseInfo(46, 5),//Alma 21:33
					new VerseInfo(46, 6),//Alma 21:34
					new VerseInfo(46, 7),//Alma 21:35
					new VerseInfo(46, 7),//Alma 21:36
					new VerseInfo(46, 8, 46, 9),//Alma 21:37
					new VerseInfo(46, 10),//Alma 21:38
					new VerseInfo(46, 10),//Alma 21:39
					new VerseInfo(46, 11),//Alma 21:40
					new VerseInfo(46, 12),//Alma 21:41
					new VerseInfo(46, 13),//Alma 21:42
					new VerseInfo(46, 13),//Alma 21:43
					new VerseInfo(46, 14, 46, 15),//Alma 21:44
					new VerseInfo(46, 15, 46, 16),//Alma 21:45
					new VerseInfo(46, 17),//Alma 21:46
					new VerseInfo(46, 18),//Alma 21:47
					new VerseInfo(46, 19),//Alma 21:48
					new VerseInfo(46, 20),//Alma 21:49
					new VerseInfo(46, 21),//Alma 21:50
					new VerseInfo(46, 21),//Alma 21:51
					new VerseInfo(46, 22),//Alma 21:52
					new VerseInfo(46, 22),//Alma 21:53
					new VerseInfo(46, 23),//Alma 21:54
					new VerseInfo(46, 23, 46, 24),//Alma 21:55
					new VerseInfo(46, 24),//Alma 21:56
					new VerseInfo(46, 24),//Alma 21:57
					new VerseInfo(46, 25),//Alma 21:58
					new VerseInfo(46, 26),//Alma 21:59
					new VerseInfo(46, 27),//Alma 21:60
					new VerseInfo(46, 28),//Alma 21:61
					new VerseInfo(46, 29),//Alma 21:62
					new VerseInfo(46, 30),//Alma 21:63
					new VerseInfo(46, 30),//Alma 21:64
					new VerseInfo(46, 31),//Alma 21:65
					new VerseInfo(46, 31),//Alma 21:66
					new VerseInfo(46, 32),//Alma 21:67
					new VerseInfo(46, 33),//Alma 21:68
					new VerseInfo(46, 34),//Alma 21:69
					new VerseInfo(46, 35),//Alma 21:70
					new VerseInfo(46, 36),//Alma 21:71
					new VerseInfo(46, 37),//Alma 21:72
					new VerseInfo(46, 38),//Alma 21:73
					new VerseInfo(46, 39),//Alma 21:74
					new VerseInfo(46, 40),//Alma 21:75
					new VerseInfo(46, 40),//Alma 21:76
					new VerseInfo(46, 41),//Alma 21:77
					new VerseInfo(47, 1),//Alma 21:78
					new VerseInfo(47, 2),//Alma 21:79
					new VerseInfo(47, 2),//Alma 21:80
					new VerseInfo(47, 3),//Alma 21:81
					new VerseInfo(47, 4),//Alma 21:82
					new VerseInfo(47, 5),//Alma 21:83
					new VerseInfo(47, 5),//Alma 21:84
					new VerseInfo(47, 6),//Alma 21:85
					new VerseInfo(47, 7),//Alma 21:86
					new VerseInfo(47, 8),//Alma 21:87
					new VerseInfo(47, 9),//Alma 21:88
					new VerseInfo(47, 10),//Alma 21:89
					new VerseInfo(47, 11),//Alma 21:90
					new VerseInfo(47, 11),//Alma 21:91
					new VerseInfo(47, 12),//Alma 21:92
					new VerseInfo(47, 13),//Alma 21:93
					new VerseInfo(47, 14),//Alma 21:94
					new VerseInfo(47, 15),//Alma 21:95
					new VerseInfo(47, 15, 47, 16),//Alma 21:96
					new VerseInfo(47, 16),//Alma 21:97
					new VerseInfo(47, 17),//Alma 21:98
					new VerseInfo(47, 18),//Alma 21:99
					new VerseInfo(47, 19),//Alma 21:100
					new VerseInfo(47, 20),//Alma 21:101
					new VerseInfo(47, 21),//Alma 21:102
					new VerseInfo(47, 22),//Alma 21:103
					new VerseInfo(47, 22),//Alma 21:104
					new VerseInfo(47, 23),//Alma 21:105
					new VerseInfo(47, 24),//Alma 21:106
					new VerseInfo(47, 25, 47, 26),//Alma 21:107
					new VerseInfo(47, 27),//Alma 21:108
					new VerseInfo(47, 27),//Alma 21:109
					new VerseInfo(47, 28),//Alma 21:110
					new VerseInfo(47, 29),//Alma 21:111
					new VerseInfo(47, 30),//Alma 21:112
					new VerseInfo(47, 31),//Alma 21:113
					new VerseInfo(47, 32),//Alma 21:114
					new VerseInfo(47, 33),//Alma 21:115
					new VerseInfo(47, 34),//Alma 21:116
					new VerseInfo(47, 34),//Alma 21:117
					new VerseInfo(47, 34),//Alma 21:118
					new VerseInfo(47, 35),//Alma 21:119
					new VerseInfo(47, 35),//Alma 21:120
					new VerseInfo(47, 36),//Alma 21:121
					new VerseInfo(47, 36),//Alma 21:122
					new VerseInfo(48, 1),//Alma 21:123
					new VerseInfo(48, 2),//Alma 21:124
					new VerseInfo(48, 2, 48, 4),//Alma 21:125
					new VerseInfo(48, 5),//Alma 21:126
					new VerseInfo(48, 6),//Alma 21:127
					new VerseInfo(48, 7),//Alma 21:128
					new VerseInfo(48, 8),//Alma 21:129
					new VerseInfo(48, 9),//Alma 21:130
					new VerseInfo(48, 10),//Alma 21:131
					new VerseInfo(48, 11),//Alma 21:132
					new VerseInfo(48, 12),//Alma 21:133
					new VerseInfo(48, 13),//Alma 21:134
					new VerseInfo(48, 14),//Alma 21:135
					new VerseInfo(48, 14),//Alma 21:136
					new VerseInfo(48, 15),//Alma 21:137
					new VerseInfo(48, 16),//Alma 21:138
					new VerseInfo(48, 16),//Alma 21:139
					new VerseInfo(48, 17),//Alma 21:140
					new VerseInfo(48, 18),//Alma 21:141
					new VerseInfo(48, 19),//Alma 21:142
					new VerseInfo(48, 20),//Alma 21:143
					new VerseInfo(48, 21),//Alma 21:144
					new VerseInfo(48, 22),//Alma 21:145
					new VerseInfo(48, 23),//Alma 21:146
					new VerseInfo(48, 24),//Alma 21:147
					new VerseInfo(48, 25),//Alma 21:148
					new VerseInfo(49, 1),//Alma 21:149
					new VerseInfo(49, 2),//Alma 21:150
					new VerseInfo(49, 3),//Alma 21:151
					new VerseInfo(49, 4),//Alma 21:152
					new VerseInfo(49, 5),//Alma 21:153
					new VerseInfo(49, 6),//Alma 21:154
					new VerseInfo(49, 6),//Alma 21:155
					new VerseInfo(49, 7),//Alma 21:156
					new VerseInfo(49, 8),//Alma 21:157
					new VerseInfo(49, 8),//Alma 21:158
					new VerseInfo(49, 9),//Alma 21:159
					new VerseInfo(49, 10),//Alma 21:160
					new VerseInfo(49, 11),//Alma 21:161
					new VerseInfo(49, 11),//Alma 21:162
					new VerseInfo(49, 12),//Alma 21:163
					new VerseInfo(49, 13),//Alma 21:164
					new VerseInfo(49, 13),//Alma 21:165
					new VerseInfo(49, 14),//Alma 21:166
					new VerseInfo(49, 15),//Alma 21:167
					new VerseInfo(49, 16),//Alma 21:168
					new VerseInfo(49, 17),//Alma 21:169
					new VerseInfo(49, 18),//Alma 21:170
					new VerseInfo(49, 19),//Alma 21:171
					new VerseInfo(49, 20),//Alma 21:172
					new VerseInfo(49, 21),//Alma 21:173
					new VerseInfo(49, 21),//Alma 21:174
					new VerseInfo(49, 22),//Alma 21:175
					new VerseInfo(49, 22),//Alma 21:176
					new VerseInfo(49, 23),//Alma 21:177
					new VerseInfo(49, 23),//Alma 21:178
					new VerseInfo(49, 24),//Alma 21:179
					new VerseInfo(49, 25),//Alma 21:180
					new VerseInfo(49, 25),//Alma 21:181
					new VerseInfo(49, 26),//Alma 21:182
					new VerseInfo(49, 27),//Alma 21:183
					new VerseInfo(49, 28),//Alma 21:184
					new VerseInfo(49, 29, 49, 30),//Alma 21:185
					new VerseInfo(49, 30),//Alma 21:186
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 22
					new VerseInfo(50, 1),//Alma 22:1
					new VerseInfo(50, 2),//Alma 22:2
					new VerseInfo(50, 3, 50, 4),//Alma 22:3
					new VerseInfo(50, 4),//Alma 22:4
					new VerseInfo(50, 5),//Alma 22:5
					new VerseInfo(50, 6),//Alma 22:6
					new VerseInfo(50, 7),//Alma 22:7
					new VerseInfo(50, 8),//Alma 22:8
					new VerseInfo(50, 9),//Alma 22:9
					new VerseInfo(50, 10),//Alma 22:10
					new VerseInfo(50, 11),//Alma 22:11
					new VerseInfo(50, 11),//Alma 22:12
					new VerseInfo(50, 12),//Alma 22:13
					new VerseInfo(50, 13),//Alma 22:14
					new VerseInfo(50, 14),//Alma 22:15
					new VerseInfo(50, 15, 50, 16),//Alma 22:16
					new VerseInfo(50, 17),//Alma 22:17
					new VerseInfo(50, 18),//Alma 22:18
					new VerseInfo(50, 19),//Alma 22:19
					new VerseInfo(50, 19, 50, 20),//Alma 22:20
					new VerseInfo(50, 20),//Alma 22:21
					new VerseInfo(50, 21),//Alma 22:22
					new VerseInfo(50, 22),//Alma 22:23
					new VerseInfo(50, 23),//Alma 22:24
					new VerseInfo(50, 24),//Alma 22:25
					new VerseInfo(50, 25),//Alma 22:26
					new VerseInfo(50, 26),//Alma 22:27
					new VerseInfo(50, 27),//Alma 22:28
					new VerseInfo(50, 28),//Alma 22:29
					new VerseInfo(50, 29),//Alma 22:30
					new VerseInfo(50, 30),//Alma 22:31
					new VerseInfo(50, 31),//Alma 22:32
					new VerseInfo(50, 32),//Alma 22:33
					new VerseInfo(50, 33),//Alma 22:34
					new VerseInfo(50, 34),//Alma 22:35
					new VerseInfo(50, 35),//Alma 22:36
					new VerseInfo(50, 35),//Alma 22:37
					new VerseInfo(50, 35, 50, 36),//Alma 22:38
					new VerseInfo(50, 36),//Alma 22:39
					new VerseInfo(50, 37),//Alma 22:40
					new VerseInfo(50, 38),//Alma 22:41
					new VerseInfo(50, 39),//Alma 22:42
					new VerseInfo(50, 39, 50, 40),//Alma 22:43
					new VerseInfo(50, 40),//Alma 22:44
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 23
					new VerseInfo(51, 1),//Alma 23:1
					new VerseInfo(51, 2),//Alma 23:2
					new VerseInfo(51, 3),//Alma 23:3
					new VerseInfo(51, 4),//Alma 23:4
					new VerseInfo(51, 5),//Alma 23:5
					new VerseInfo(51, 6),//Alma 23:6
					new VerseInfo(51, 7),//Alma 23:7
					new VerseInfo(51, 7),//Alma 23:8
					new VerseInfo(51, 8),//Alma 23:9
					new VerseInfo(51, 9),//Alma 23:10
					new VerseInfo(51, 10),//Alma 23:11
					new VerseInfo(51, 11),//Alma 23:12
					new VerseInfo(51, 11),//Alma 23:13
					new VerseInfo(51, 12),//Alma 23:14
					new VerseInfo(51, 12),//Alma 23:15
					new VerseInfo(51, 13),//Alma 23:16
					new VerseInfo(51, 14),//Alma 23:17
					new VerseInfo(51, 15),//Alma 23:18
					new VerseInfo(51, 16),//Alma 23:19
					new VerseInfo(51, 16),//Alma 23:20
					new VerseInfo(51, 17),//Alma 23:21
					new VerseInfo(51, 18),//Alma 23:22
					new VerseInfo(51, 19),//Alma 23:23
					new VerseInfo(51, 20),//Alma 23:24
					new VerseInfo(51, 21),//Alma 23:25
					new VerseInfo(51, 21),//Alma 23:26
					new VerseInfo(51, 22),//Alma 23:27
					new VerseInfo(51, 23),//Alma 23:28
					new VerseInfo(51, 23),//Alma 23:29
					new VerseInfo(51, 24),//Alma 23:30
					new VerseInfo(51, 25),//Alma 23:31
					new VerseInfo(51, 26),//Alma 23:32
					new VerseInfo(51, 27),//Alma 23:33
					new VerseInfo(51, 28),//Alma 23:34
					new VerseInfo(51, 29),//Alma 23:35
					new VerseInfo(51, 30),//Alma 23:36
					new VerseInfo(51, 31),//Alma 23:37
					new VerseInfo(51, 32),//Alma 23:38
					new VerseInfo(51, 32),//Alma 23:39
					new VerseInfo(51, 33),//Alma 23:40
					new VerseInfo(51, 34),//Alma 23:41
					new VerseInfo(51, 35),//Alma 23:42
					new VerseInfo(51, 36),//Alma 23:43
					new VerseInfo(51, 37),//Alma 23:44
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 24
					new VerseInfo(52, 1),//Alma 24:1
					new VerseInfo(52, 2),//Alma 24:2
					new VerseInfo(52, 3),//Alma 24:3
					new VerseInfo(52, 4),//Alma 24:4
					new VerseInfo(52, 5),//Alma 24:5
					new VerseInfo(52, 5, 52, 6),//Alma 24:6
					new VerseInfo(52, 6),//Alma 24:7
					new VerseInfo(52, 7),//Alma 24:8
					new VerseInfo(52, 8),//Alma 24:9
					new VerseInfo(52, 9),//Alma 24:10
					new VerseInfo(52, 10),//Alma 24:11
					new VerseInfo(52, 10),//Alma 24:12
					new VerseInfo(52, 11),//Alma 24:13
					new VerseInfo(52, 12),//Alma 24:14
					new VerseInfo(52, 13),//Alma 24:15
					new VerseInfo(52, 14),//Alma 24:16
					new VerseInfo(52, 15),//Alma 24:17
					new VerseInfo(52, 16),//Alma 24:18
					new VerseInfo(52, 17),//Alma 24:19
					new VerseInfo(52, 17),//Alma 24:20
					new VerseInfo(52, 18),//Alma 24:21
					new VerseInfo(52, 19),//Alma 24:22
					new VerseInfo(52, 19),//Alma 24:23
					new VerseInfo(52, 20),//Alma 24:24
					new VerseInfo(52, 20),//Alma 24:25
					new VerseInfo(52, 21),//Alma 24:26
					new VerseInfo(52, 22),//Alma 24:27
					new VerseInfo(52, 22),//Alma 24:28
					new VerseInfo(52, 23),//Alma 24:29
					new VerseInfo(52, 23),//Alma 24:30
					new VerseInfo(52, 24),//Alma 24:31
					new VerseInfo(52, 24),//Alma 24:32
					new VerseInfo(52, 25),//Alma 24:33
					new VerseInfo(52, 26),//Alma 24:34
					new VerseInfo(52, 27),//Alma 24:35
					new VerseInfo(52, 28),//Alma 24:36
					new VerseInfo(52, 29),//Alma 24:37
					new VerseInfo(52, 30),//Alma 24:38
					new VerseInfo(52, 31),//Alma 24:39
					new VerseInfo(52, 32),//Alma 24:40
					new VerseInfo(52, 33),//Alma 24:41
					new VerseInfo(52, 34),//Alma 24:42
					new VerseInfo(52, 34),//Alma 24:43
					new VerseInfo(52, 35),//Alma 24:44
					new VerseInfo(52, 36),//Alma 24:45
					new VerseInfo(52, 37),//Alma 24:46
					new VerseInfo(52, 38),//Alma 24:47
					new VerseInfo(52, 39),//Alma 24:48
					new VerseInfo(52, 40),//Alma 24:49
					new VerseInfo(53, 1),//Alma 24:50
					new VerseInfo(53, 2),//Alma 24:51
					new VerseInfo(53, 2),//Alma 24:52
					new VerseInfo(53, 3),//Alma 24:53
					new VerseInfo(53, 3),//Alma 24:54
					new VerseInfo(53, 4),//Alma 24:55
					new VerseInfo(53, 4),//Alma 24:56
					new VerseInfo(53, 5),//Alma 24:57
					new VerseInfo(53, 5),//Alma 24:58
					new VerseInfo(53, 6),//Alma 24:59
					new VerseInfo(53, 7),//Alma 24:60
					new VerseInfo(53, 8),//Alma 24:61
					new VerseInfo(53, 9),//Alma 24:62
					new VerseInfo(53, 10),//Alma 24:63
					new VerseInfo(53, 10, 53, 11),//Alma 24:64
					new VerseInfo(53, 11),//Alma 24:65
					new VerseInfo(53, 12),//Alma 24:66
					new VerseInfo(53, 13),//Alma 24:67
					new VerseInfo(53, 14),//Alma 24:68
					new VerseInfo(53, 15),//Alma 24:69
					new VerseInfo(53, 16),//Alma 24:70
					new VerseInfo(53, 16),//Alma 24:71
					new VerseInfo(53, 17),//Alma 24:72
					new VerseInfo(53, 17),//Alma 24:73
					new VerseInfo(53, 18),//Alma 24:74
					new VerseInfo(53, 19),//Alma 24:75
					new VerseInfo(53, 20),//Alma 24:76
					new VerseInfo(53, 21),//Alma 24:77
					new VerseInfo(53, 22),//Alma 24:78
					new VerseInfo(53, 23),//Alma 24:79
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 25
					new VerseInfo(54, 1),//Alma 25:1
					new VerseInfo(54, 2),//Alma 25:2
					new VerseInfo(54, 3),//Alma 25:3
					new VerseInfo(54, 3, 54, 4),//Alma 25:4
					new VerseInfo(54, 4, 54, 5),//Alma 25:5
					new VerseInfo(54, 6, 54, 7),//Alma 25:6
					new VerseInfo(54, 7),//Alma 25:7
					new VerseInfo(54, 8),//Alma 25:8
					new VerseInfo(54, 9),//Alma 25:9
					new VerseInfo(54, 10),//Alma 25:10
					new VerseInfo(54, 11),//Alma 25:11
					new VerseInfo(54, 12),//Alma 25:12
					new VerseInfo(54, 13),//Alma 25:13
					new VerseInfo(54, 13),//Alma 25:14
					new VerseInfo(54, 14),//Alma 25:15
					new VerseInfo(54, 15, 54, 16),//Alma 25:16
					new VerseInfo(54, 16),//Alma 25:17
					new VerseInfo(54, 17),//Alma 25:18
					new VerseInfo(54, 18),//Alma 25:19
					new VerseInfo(54, 19),//Alma 25:20
					new VerseInfo(54, 20),//Alma 25:21
					new VerseInfo(54, 20),//Alma 25:22
					new VerseInfo(54, 21),//Alma 25:23
					new VerseInfo(54, 22),//Alma 25:24
					new VerseInfo(54, 23, 54, 24),//Alma 25:25
					new VerseInfo(54, 24),//Alma 25:26
					new VerseInfo(55, 1),//Alma 25:27
					new VerseInfo(55, 2),//Alma 25:28
					new VerseInfo(55, 3),//Alma 25:29
					new VerseInfo(55, 4),//Alma 25:30
					new VerseInfo(55, 5),//Alma 25:31
					new VerseInfo(55, 6),//Alma 25:32
					new VerseInfo(55, 7),//Alma 25:33
					new VerseInfo(55, 8),//Alma 25:34
					new VerseInfo(55, 8),//Alma 25:35
					new VerseInfo(55, 9),//Alma 25:36
					new VerseInfo(55, 10),//Alma 25:37
					new VerseInfo(55, 11, 55, 12),//Alma 25:38
					new VerseInfo(55, 13),//Alma 25:39
					new VerseInfo(55, 14),//Alma 25:40
					new VerseInfo(55, 15, 55, 16),//Alma 25:41
					new VerseInfo(55, 16, 55, 17),//Alma 25:42
					new VerseInfo(55, 17, 55, 18),//Alma 25:43
					new VerseInfo(55, 19),//Alma 25:44
					new VerseInfo(55, 20),//Alma 25:45
					new VerseInfo(55, 21),//Alma 25:46
					new VerseInfo(55, 22),//Alma 25:47
					new VerseInfo(55, 23),//Alma 25:48
					new VerseInfo(55, 23, 55, 24),//Alma 25:49
					new VerseInfo(55, 24),//Alma 25:50
					new VerseInfo(55, 25),//Alma 25:51
					new VerseInfo(55, 26),//Alma 25:52
					new VerseInfo(55, 26),//Alma 25:53
					new VerseInfo(55, 27),//Alma 25:54
					new VerseInfo(55, 28),//Alma 25:55
					new VerseInfo(55, 29),//Alma 25:56
					new VerseInfo(55, 30),//Alma 25:57
					new VerseInfo(55, 31),//Alma 25:58
					new VerseInfo(55, 31),//Alma 25:59
					new VerseInfo(55, 32),//Alma 25:60
					new VerseInfo(55, 33),//Alma 25:61
					new VerseInfo(55, 33, 55, 34),//Alma 25:62
					new VerseInfo(55, 35),//Alma 25:63
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 26
					new VerseInfo(56, 1),//Alma 26:1
					new VerseInfo(56, 2),//Alma 26:2
					new VerseInfo(56, 3),//Alma 26:3
					new VerseInfo(56, 3),//Alma 26:4
					new VerseInfo(56, 4, 56, 5),//Alma 26:5
					new VerseInfo(56, 6),//Alma 26:6
					new VerseInfo(56, 7),//Alma 26:7
					new VerseInfo(56, 8),//Alma 26:8
					new VerseInfo(56, 9),//Alma 26:9
					new VerseInfo(56, 9),//Alma 26:10
					new VerseInfo(56, 10),//Alma 26:11
					new VerseInfo(56, 11),//Alma 26:12
					new VerseInfo(56, 12),//Alma 26:13
					new VerseInfo(56, 12),//Alma 26:14
					new VerseInfo(56, 13, 56, 14),//Alma 26:15
					new VerseInfo(56, 15),//Alma 26:16
					new VerseInfo(56, 16),//Alma 26:17
					new VerseInfo(56, 17),//Alma 26:18
					new VerseInfo(56, 18),//Alma 26:19
					new VerseInfo(56, 19),//Alma 26:20
					new VerseInfo(56, 20),//Alma 26:21
					new VerseInfo(56, 20),//Alma 26:22
					new VerseInfo(56, 21),//Alma 26:23
					new VerseInfo(56, 22),//Alma 26:24
					new VerseInfo(56, 23),//Alma 26:25
					new VerseInfo(56, 23),//Alma 26:26
					new VerseInfo(56, 24),//Alma 26:27
					new VerseInfo(56, 25),//Alma 26:28
					new VerseInfo(56, 26),//Alma 26:29
					new VerseInfo(56, 27),//Alma 26:30
					new VerseInfo(56, 28),//Alma 26:31
					new VerseInfo(56, 28),//Alma 26:32
					new VerseInfo(56, 29),//Alma 26:33
					new VerseInfo(56, 30),//Alma 26:34
					new VerseInfo(56, 30),//Alma 26:35
					new VerseInfo(56, 31),//Alma 26:36
					new VerseInfo(56, 32),//Alma 26:37
					new VerseInfo(56, 33),//Alma 26:38
					new VerseInfo(56, 33),//Alma 26:39
					new VerseInfo(56, 34),//Alma 26:40
					new VerseInfo(56, 35),//Alma 26:41
					new VerseInfo(56, 36),//Alma 26:42
					new VerseInfo(56, 36, 56, 37),//Alma 26:43
					new VerseInfo(56, 37),//Alma 26:44
					new VerseInfo(56, 38),//Alma 26:45
					new VerseInfo(56, 38),//Alma 26:46
					new VerseInfo(56, 39),//Alma 26:47
					new VerseInfo(56, 39),//Alma 26:48
					new VerseInfo(56, 40),//Alma 26:49
					new VerseInfo(56, 41),//Alma 26:50
					new VerseInfo(56, 42),//Alma 26:51
					new VerseInfo(56, 43, 56, 44),//Alma 26:52
					new VerseInfo(56, 45),//Alma 26:53
					new VerseInfo(56, 46),//Alma 26:54
					new VerseInfo(56, 46),//Alma 26:55
					new VerseInfo(56, 47),//Alma 26:56
					new VerseInfo(56, 48),//Alma 26:57
					new VerseInfo(56, 49),//Alma 26:58
					new VerseInfo(56, 49),//Alma 26:59
					new VerseInfo(56, 50),//Alma 26:60
					new VerseInfo(56, 51),//Alma 26:61
					new VerseInfo(56, 52),//Alma 26:62
					new VerseInfo(56, 53),//Alma 26:63
					new VerseInfo(56, 54),//Alma 26:64
					new VerseInfo(56, 55),//Alma 26:65
					new VerseInfo(56, 56),//Alma 26:66
					new VerseInfo(56, 56),//Alma 26:67
					new VerseInfo(56, 57),//Alma 26:68
					new VerseInfo(56, 57),//Alma 26:69
					new VerseInfo(57, 1),//Alma 26:70
					new VerseInfo(57, 2),//Alma 26:71
					new VerseInfo(57, 3),//Alma 26:72
					new VerseInfo(57, 4),//Alma 26:73
					new VerseInfo(57, 5),//Alma 26:74
					new VerseInfo(57, 6),//Alma 26:75
					new VerseInfo(57, 6),//Alma 26:76
					new VerseInfo(57, 7),//Alma 26:77
					new VerseInfo(57, 8),//Alma 26:78
					new VerseInfo(57, 9),//Alma 26:79
					new VerseInfo(57, 10),//Alma 26:80
					new VerseInfo(57, 10),//Alma 26:81
					new VerseInfo(57, 11),//Alma 26:82
					new VerseInfo(57, 11),//Alma 26:83
					new VerseInfo(57, 12),//Alma 26:84
					new VerseInfo(57, 13),//Alma 26:85
					new VerseInfo(57, 14),//Alma 26:86
					new VerseInfo(57, 15),//Alma 26:87
					new VerseInfo(57, 15),//Alma 26:88
					new VerseInfo(57, 16),//Alma 26:89
					new VerseInfo(57, 16, 57, 17),//Alma 26:90
					new VerseInfo(57, 17),//Alma 26:91
					new VerseInfo(57, 17),//Alma 26:92
					new VerseInfo(57, 18),//Alma 26:93
					new VerseInfo(57, 19),//Alma 26:94
					new VerseInfo(57, 20, 57, 21),//Alma 26:95
					new VerseInfo(57, 21),//Alma 26:96
					new VerseInfo(57, 22),//Alma 26:97
					new VerseInfo(57, 23),//Alma 26:98
					new VerseInfo(57, 24),//Alma 26:99
					new VerseInfo(57, 25),//Alma 26:100
					new VerseInfo(57, 25),//Alma 26:101
					new VerseInfo(57, 26),//Alma 26:102
					new VerseInfo(57, 26),//Alma 26:103
					new VerseInfo(57, 27),//Alma 26:104
					new VerseInfo(57, 28),//Alma 26:105
					new VerseInfo(57, 29),//Alma 26:106
					new VerseInfo(57, 30),//Alma 26:107
					new VerseInfo(57, 30),//Alma 26:108
					new VerseInfo(57, 31),//Alma 26:109
					new VerseInfo(57, 32),//Alma 26:110
					new VerseInfo(57, 33),//Alma 26:111
					new VerseInfo(57, 33),//Alma 26:112
					new VerseInfo(57, 34),//Alma 26:113
					new VerseInfo(57, 35),//Alma 26:114
					new VerseInfo(57, 35),//Alma 26:115
					new VerseInfo(57, 36),//Alma 26:116
					new VerseInfo(57, 36),//Alma 26:117
					new VerseInfo(58, 1),//Alma 26:118
					new VerseInfo(58, 1),//Alma 26:119
					new VerseInfo(58, 2),//Alma 26:120
					new VerseInfo(58, 3),//Alma 26:121
					new VerseInfo(58, 3),//Alma 26:122
					new VerseInfo(58, 4),//Alma 26:123
					new VerseInfo(58, 4),//Alma 26:124
					new VerseInfo(58, 5),//Alma 26:125
					new VerseInfo(58, 6),//Alma 26:126
					new VerseInfo(58, 7),//Alma 26:127
					new VerseInfo(58, 8),//Alma 26:128
					new VerseInfo(58, 8),//Alma 26:129
					new VerseInfo(58, 9),//Alma 26:130
					new VerseInfo(58, 10),//Alma 26:131
					new VerseInfo(58, 11),//Alma 26:132
					new VerseInfo(58, 12),//Alma 26:133
					new VerseInfo(58, 13),//Alma 26:134
					new VerseInfo(58, 14),//Alma 26:135
					new VerseInfo(58, 15),//Alma 26:136
					new VerseInfo(58, 15),//Alma 26:137
					new VerseInfo(58, 16),//Alma 26:138
					new VerseInfo(58, 17),//Alma 26:139
					new VerseInfo(58, 18),//Alma 26:140
					new VerseInfo(58, 18),//Alma 26:141
					new VerseInfo(58, 19),//Alma 26:142
					new VerseInfo(58, 19),//Alma 26:143
					new VerseInfo(58, 20),//Alma 26:144
					new VerseInfo(58, 21),//Alma 26:145
					new VerseInfo(58, 22),//Alma 26:146
					new VerseInfo(58, 23),//Alma 26:147
					new VerseInfo(58, 23),//Alma 26:148
					new VerseInfo(58, 24),//Alma 26:149
					new VerseInfo(58, 25),//Alma 26:150
					new VerseInfo(58, 26),//Alma 26:151
					new VerseInfo(58, 27),//Alma 26:152
					new VerseInfo(58, 28),//Alma 26:153
					new VerseInfo(58, 29),//Alma 26:154
					new VerseInfo(58, 30),//Alma 26:155
					new VerseInfo(58, 30),//Alma 26:156
					new VerseInfo(58, 31),//Alma 26:157
					new VerseInfo(58, 32),//Alma 26:158
					new VerseInfo(58, 33),//Alma 26:159
					new VerseInfo(58, 34),//Alma 26:160
					new VerseInfo(58, 35),//Alma 26:161
					new VerseInfo(58, 36),//Alma 26:162
					new VerseInfo(58, 37),//Alma 26:163
					new VerseInfo(58, 38),//Alma 26:164
					new VerseInfo(58, 39),//Alma 26:165
					new VerseInfo(58, 40),//Alma 26:166
					new VerseInfo(58, 40),//Alma 26:167
					new VerseInfo(58, 41),//Alma 26:168
					new VerseInfo(58, 41),//Alma 26:169
					new VerseInfo(58, 41),//Alma 26:170
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 27
					new VerseInfo(59, 1),//Alma 27:1
					new VerseInfo(59, 2),//Alma 27:2
					new VerseInfo(59, 3),//Alma 27:3
					new VerseInfo(59, 4),//Alma 27:4
					new VerseInfo(59, 5),//Alma 27:5
					new VerseInfo(59, 6),//Alma 27:6
					new VerseInfo(59, 7),//Alma 27:7
					new VerseInfo(59, 8),//Alma 27:8
					new VerseInfo(59, 9),//Alma 27:9
					new VerseInfo(59, 10),//Alma 27:10
					new VerseInfo(59, 11),//Alma 27:11
					new VerseInfo(59, 12),//Alma 27:12
					new VerseInfo(59, 13),//Alma 27:13
					new VerseInfo(60, 1),//Alma 27:14
					new VerseInfo(60, 2),//Alma 27:15
					new VerseInfo(60, 3),//Alma 27:16
					new VerseInfo(60, 4, 60, 5),//Alma 27:17
					new VerseInfo(60, 5),//Alma 27:18
					new VerseInfo(60, 5, 60, 6),//Alma 27:19
					new VerseInfo(60, 7),//Alma 27:20
					new VerseInfo(60, 7, 60, 8),//Alma 27:21
					new VerseInfo(60, 8),//Alma 27:22
					new VerseInfo(60, 9),//Alma 27:23
					new VerseInfo(60, 9),//Alma 27:24
					new VerseInfo(60, 10),//Alma 27:25
					new VerseInfo(60, 10),//Alma 27:26
					new VerseInfo(60, 11),//Alma 27:27
					new VerseInfo(60, 12),//Alma 27:28
					new VerseInfo(60, 12, 60, 13),//Alma 27:29
					new VerseInfo(60, 14),//Alma 27:30
					new VerseInfo(60, 15, 60, 16),//Alma 27:31
					new VerseInfo(60, 16),//Alma 27:32
					new VerseInfo(60, 16),//Alma 27:33
					new VerseInfo(60, 16),//Alma 27:34
					new VerseInfo(60, 17),//Alma 27:35
					new VerseInfo(60, 18),//Alma 27:36
					new VerseInfo(60, 19),//Alma 27:37
					new VerseInfo(60, 20),//Alma 27:38
					new VerseInfo(60, 20),//Alma 27:39
					new VerseInfo(60, 21),//Alma 27:40
					new VerseInfo(60, 22),//Alma 27:41
					new VerseInfo(60, 23),//Alma 27:42
					new VerseInfo(60, 23),//Alma 27:43
					new VerseInfo(60, 24),//Alma 27:44
					new VerseInfo(60, 25, 60, 26),//Alma 27:45
					new VerseInfo(60, 27),//Alma 27:46
					new VerseInfo(60, 28),//Alma 27:47
					new VerseInfo(60, 29),//Alma 27:48
					new VerseInfo(60, 30),//Alma 27:49
					new VerseInfo(60, 31),//Alma 27:50
					new VerseInfo(60, 32),//Alma 27:51
					new VerseInfo(60, 32),//Alma 27:52
					new VerseInfo(60, 33),//Alma 27:53
					new VerseInfo(60, 33),//Alma 27:54
					new VerseInfo(60, 34),//Alma 27:55
					new VerseInfo(60, 35),//Alma 27:56
					new VerseInfo(60, 35),//Alma 27:57
					new VerseInfo(60, 36),//Alma 27:58
					new VerseInfo(60, 36),//Alma 27:59
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 28
					new VerseInfo(61, 1),//Alma 28:1
					new VerseInfo(61, 1, 61, 2),//Alma 28:2
					new VerseInfo(61, 3),//Alma 28:3
					new VerseInfo(61, 4),//Alma 28:4
					new VerseInfo(61, 4),//Alma 28:5
					new VerseInfo(61, 5),//Alma 28:6
					new VerseInfo(61, 6),//Alma 28:7
					new VerseInfo(61, 7),//Alma 28:8
					new VerseInfo(61, 8),//Alma 28:9
					new VerseInfo(61, 8),//Alma 28:10
					new VerseInfo(61, 9),//Alma 28:11
					new VerseInfo(61, 9),//Alma 28:12
					new VerseInfo(61, 9),//Alma 28:13
					new VerseInfo(61, 10),//Alma 28:14
					new VerseInfo(61, 10),//Alma 28:15
					new VerseInfo(61, 11),//Alma 28:16
					new VerseInfo(61, 12),//Alma 28:17
					new VerseInfo(61, 13),//Alma 28:18
					new VerseInfo(61, 14),//Alma 28:19
					new VerseInfo(61, 15),//Alma 28:20
					new VerseInfo(61, 16),//Alma 28:21
					new VerseInfo(61, 17),//Alma 28:22
					new VerseInfo(61, 18),//Alma 28:23
					new VerseInfo(61, 19),//Alma 28:24
					new VerseInfo(61, 20),//Alma 28:25
					new VerseInfo(61, 21),//Alma 28:26
					new VerseInfo(61, 21),//Alma 28:27
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 29
					new VerseInfo(62, 1),//Alma 29:1
					new VerseInfo(62, 2),//Alma 29:2
					new VerseInfo(62, 3),//Alma 29:3
					new VerseInfo(62, 4),//Alma 29:4
					new VerseInfo(62, 5),//Alma 29:5
					new VerseInfo(62, 6),//Alma 29:6
					new VerseInfo(62, 7),//Alma 29:7
					new VerseInfo(62, 8),//Alma 29:8
					new VerseInfo(62, 9),//Alma 29:9
					new VerseInfo(62, 9),//Alma 29:10
					new VerseInfo(62, 10),//Alma 29:11
					new VerseInfo(62, 11),//Alma 29:12
					new VerseInfo(62, 12),//Alma 29:13
					new VerseInfo(62, 13),//Alma 29:14
					new VerseInfo(62, 13),//Alma 29:15
					new VerseInfo(62, 14),//Alma 29:16
					new VerseInfo(62, 15),//Alma 29:17
					new VerseInfo(62, 16),//Alma 29:18
					new VerseInfo(62, 17),//Alma 29:19
					new VerseInfo(62, 18),//Alma 29:20
					new VerseInfo(62, 18),//Alma 29:21
					new VerseInfo(62, 19),//Alma 29:22
					new VerseInfo(62, 20),//Alma 29:23
					new VerseInfo(62, 21),//Alma 29:24
					new VerseInfo(62, 21),//Alma 29:25
					new VerseInfo(62, 22),//Alma 29:26
					new VerseInfo(62, 23),//Alma 29:27
					new VerseInfo(62, 24),//Alma 29:28
					new VerseInfo(62, 25),//Alma 29:29
					new VerseInfo(62, 26),//Alma 29:30
					new VerseInfo(62, 27),//Alma 29:31
					new VerseInfo(62, 28, 62, 29),//Alma 29:32
					new VerseInfo(62, 29),//Alma 29:33
					new VerseInfo(62, 30),//Alma 29:34
					new VerseInfo(62, 31),//Alma 29:35
					new VerseInfo(62, 32),//Alma 29:36
					new VerseInfo(62, 33),//Alma 29:37
					new VerseInfo(62, 33),//Alma 29:38
					new VerseInfo(62, 34, 62, 35),//Alma 29:39
					new VerseInfo(62, 35),//Alma 29:40
					new VerseInfo(62, 35),//Alma 29:41
					new VerseInfo(62, 36),//Alma 29:42
					new VerseInfo(62, 36),//Alma 29:43
					new VerseInfo(62, 36),//Alma 29:44
					new VerseInfo(62, 37),//Alma 29:45
					new VerseInfo(62, 37),//Alma 29:46
					new VerseInfo(62, 38),//Alma 29:47
					new VerseInfo(62, 39),//Alma 29:48
					new VerseInfo(62, 40),//Alma 29:49
					new VerseInfo(62, 41),//Alma 29:50
					new VerseInfo(62, 41),//Alma 29:51
					new VerseInfo(62, 42),//Alma 29:52
					new VerseInfo(62, 43),//Alma 29:53
					new VerseInfo(62, 44),//Alma 29:54
					new VerseInfo(62, 45),//Alma 29:55
					new VerseInfo(62, 46, 62, 47),//Alma 29:56
					new VerseInfo(62, 47),//Alma 29:57
					new VerseInfo(62, 48),//Alma 29:58
					new VerseInfo(62, 48, 62, 49),//Alma 29:59
					new VerseInfo(62, 50),//Alma 29:60
					new VerseInfo(62, 51),//Alma 29:61
					new VerseInfo(62, 52),//Alma 29:62
					new VerseInfo(62, 52),//Alma 29:63
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Alma 30
					new VerseInfo(63, 1),//Alma 30:1
					new VerseInfo(63, 2),//Alma 30:2
					new VerseInfo(63, 3),//Alma 30:3
					new VerseInfo(63, 3),//Alma 30:4
					new VerseInfo(63, 4),//Alma 30:5
					new VerseInfo(63, 5),//Alma 30:6
					new VerseInfo(63, 6),//Alma 30:7
					new VerseInfo(63, 6),//Alma 30:8
					new VerseInfo(63, 7),//Alma 30:9
					new VerseInfo(63, 7),//Alma 30:10
					new VerseInfo(63, 8),//Alma 30:11
					new VerseInfo(63, 8),//Alma 30:12
					new VerseInfo(63, 9),//Alma 30:13
					new VerseInfo(63, 10),//Alma 30:14
					new VerseInfo(63, 11),//Alma 30:15
					new VerseInfo(63, 12),//Alma 30:16
					new VerseInfo(63, 13),//Alma 30:17
					new VerseInfo(63, 14),//Alma 30:18
					new VerseInfo(63, 15),//Alma 30:19
					new VerseInfo(63, 16),//Alma 30:20
					new VerseInfo(63, 17),//Alma 30:21
				},
			}
		},
		{ "Helaman", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Helaman 1
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
					new VerseInfo(1, 11, 1, 12),//Helaman 1:11
					new VerseInfo(1, 12),//Helaman 1:12
					new VerseInfo(1, 13),//Helaman 1:13
					new VerseInfo(1, 13),//Helaman 1:14
					new VerseInfo(1, 14, 1, 15),//Helaman 1:15
					new VerseInfo(1, 15),//Helaman 1:16
					new VerseInfo(1, 16),//Helaman 1:17
					new VerseInfo(1, 17),//Helaman 1:18
					new VerseInfo(1, 18),//Helaman 1:19
					new VerseInfo(1, 19),//Helaman 1:20
					new VerseInfo(1, 20),//Helaman 1:21
					new VerseInfo(1, 21),//Helaman 1:22
					new VerseInfo(1, 21),//Helaman 1:23
					new VerseInfo(1, 22),//Helaman 1:24
					new VerseInfo(1, 23),//Helaman 1:25
					new VerseInfo(1, 24),//Helaman 1:26
					new VerseInfo(1, 25),//Helaman 1:27
					new VerseInfo(1, 26),//Helaman 1:28
					new VerseInfo(1, 27),//Helaman 1:29
					new VerseInfo(1, 28),//Helaman 1:30
					new VerseInfo(1, 29),//Helaman 1:31
					new VerseInfo(1, 30),//Helaman 1:32
					new VerseInfo(1, 31),//Helaman 1:33
					new VerseInfo(1, 32),//Helaman 1:34
					new VerseInfo(1, 33),//Helaman 1:35
					new VerseInfo(1, 34),//Helaman 1:36
					new VerseInfo(2, 1),//Helaman 1:37
					new VerseInfo(2, 2),//Helaman 1:38
					new VerseInfo(2, 3),//Helaman 1:39
					new VerseInfo(2, 4),//Helaman 1:40
					new VerseInfo(2, 5),//Helaman 1:41
					new VerseInfo(2, 6),//Helaman 1:42
					new VerseInfo(2, 7),//Helaman 1:43
					new VerseInfo(2, 8),//Helaman 1:44
					new VerseInfo(2, 9),//Helaman 1:45
					new VerseInfo(2, 9),//Helaman 1:46
					new VerseInfo(2, 10),//Helaman 1:47
					new VerseInfo(2, 11),//Helaman 1:48
					new VerseInfo(2, 11, 2, 12),//Helaman 1:49
					new VerseInfo(2, 12),//Helaman 1:50
					new VerseInfo(2, 13),//Helaman 1:51
					new VerseInfo(2, 14),//Helaman 1:52
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Helaman 2
					new VerseInfo(3, 1),//Helaman 2:1
					new VerseInfo(3, 2),//Helaman 2:2
					new VerseInfo(3, 3),//Helaman 2:3
					new VerseInfo(3, 4),//Helaman 2:4
					new VerseInfo(3, 5),//Helaman 2:5
					new VerseInfo(3, 6),//Helaman 2:6
					new VerseInfo(3, 7),//Helaman 2:7
					new VerseInfo(3, 8),//Helaman 2:8
					new VerseInfo(3, 9),//Helaman 2:9
					new VerseInfo(3, 10, 3, 11),//Helaman 2:10
					new VerseInfo(3, 12),//Helaman 2:11
					new VerseInfo(3, 13),//Helaman 2:12
					new VerseInfo(3, 14),//Helaman 2:13
					new VerseInfo(3, 15, 3, 16),//Helaman 2:14
					new VerseInfo(3, 17),//Helaman 2:15
					new VerseInfo(3, 18),//Helaman 2:16
					new VerseInfo(3, 19),//Helaman 2:17
					new VerseInfo(3, 20),//Helaman 2:18
					new VerseInfo(3, 21),//Helaman 2:19
					new VerseInfo(3, 22),//Helaman 2:20
					new VerseInfo(3, 23),//Helaman 2:21
					new VerseInfo(3, 24),//Helaman 2:22
					new VerseInfo(3, 25),//Helaman 2:23
					new VerseInfo(3, 26),//Helaman 2:24
					new VerseInfo(3, 27, 3, 28),//Helaman 2:25
					new VerseInfo(3, 29, 3, 30),//Helaman 2:26
					new VerseInfo(3, 31),//Helaman 2:27
					new VerseInfo(3, 32),//Helaman 2:28
					new VerseInfo(3, 33, 3, 34),//Helaman 2:29
					new VerseInfo(3, 34),//Helaman 2:30
					new VerseInfo(3, 35),//Helaman 2:31
					new VerseInfo(3, 36),//Helaman 2:32
					new VerseInfo(3, 37),//Helaman 2:33
					new VerseInfo(3, 37),//Helaman 2:34
					new VerseInfo(4, 1, 4, 2),//Helaman 2:35
					new VerseInfo(4, 3),//Helaman 2:36
					new VerseInfo(4, 4),//Helaman 2:37
					new VerseInfo(4, 5),//Helaman 2:38
					new VerseInfo(4, 6, 4, 7),//Helaman 2:39
					new VerseInfo(4, 8),//Helaman 2:40
					new VerseInfo(4, 8),//Helaman 2:41
					new VerseInfo(4, 9),//Helaman 2:42
					new VerseInfo(4, 10),//Helaman 2:43
					new VerseInfo(4, 11),//Helaman 2:44
					new VerseInfo(4, 12),//Helaman 2:45
					new VerseInfo(4, 13),//Helaman 2:46
					new VerseInfo(4, 14),//Helaman 2:47
					new VerseInfo(4, 14),//Helaman 2:48
					new VerseInfo(4, 15),//Helaman 2:49
					new VerseInfo(4, 16),//Helaman 2:50
					new VerseInfo(4, 17),//Helaman 2:51
					new VerseInfo(4, 18),//Helaman 2:52
					new VerseInfo(4, 19),//Helaman 2:53
					new VerseInfo(4, 20),//Helaman 2:54
					new VerseInfo(4, 21),//Helaman 2:55
					new VerseInfo(4, 22),//Helaman 2:56
					new VerseInfo(4, 22),//Helaman 2:57
					new VerseInfo(4, 23),//Helaman 2:58
					new VerseInfo(4, 24),//Helaman 2:59
					new VerseInfo(4, 25),//Helaman 2:60
					new VerseInfo(4, 26),//Helaman 2:61
					new VerseInfo(4, 26),//Helaman 2:62
					new VerseInfo(5, 1),//Helaman 2:63
					new VerseInfo(5, 2),//Helaman 2:64
					new VerseInfo(5, 3),//Helaman 2:65
					new VerseInfo(5, 4, 5, 5),//Helaman 2:66
					new VerseInfo(5, 5, 5, 6),//Helaman 2:67
					new VerseInfo(5, 6),//Helaman 2:68
					new VerseInfo(5, 7),//Helaman 2:69
					new VerseInfo(5, 8),//Helaman 2:70
					new VerseInfo(5, 9),//Helaman 2:71
					new VerseInfo(5, 10),//Helaman 2:72
					new VerseInfo(5, 11),//Helaman 2:73
					new VerseInfo(5, 12),//Helaman 2:74
					new VerseInfo(5, 12),//Helaman 2:75
					new VerseInfo(5, 13),//Helaman 2:76
					new VerseInfo(5, 14, 5, 15),//Helaman 2:77
					new VerseInfo(5, 16),//Helaman 2:78
					new VerseInfo(5, 17),//Helaman 2:79
					new VerseInfo(5, 18),//Helaman 2:80
					new VerseInfo(5, 19),//Helaman 2:81
					new VerseInfo(5, 20),//Helaman 2:82
					new VerseInfo(5, 21),//Helaman 2:83
					new VerseInfo(5, 22),//Helaman 2:84
					new VerseInfo(5, 23),//Helaman 2:85
					new VerseInfo(5, 23),//Helaman 2:86
					new VerseInfo(5, 24),//Helaman 2:87
					new VerseInfo(5, 25),//Helaman 2:88
					new VerseInfo(5, 26),//Helaman 2:89
					new VerseInfo(5, 27),//Helaman 2:90
					new VerseInfo(5, 27),//Helaman 2:91
					new VerseInfo(5, 28),//Helaman 2:92
					new VerseInfo(5, 29),//Helaman 2:93
					new VerseInfo(5, 30),//Helaman 2:94
					new VerseInfo(5, 31),//Helaman 2:95
					new VerseInfo(5, 32),//Helaman 2:96
					new VerseInfo(5, 32, 5, 33),//Helaman 2:97
					new VerseInfo(5, 34),//Helaman 2:98
					new VerseInfo(5, 35),//Helaman 2:99
					new VerseInfo(5, 36),//Helaman 2:100
					new VerseInfo(5, 36),//Helaman 2:101
					new VerseInfo(5, 37),//Helaman 2:102
					new VerseInfo(5, 37),//Helaman 2:103
					new VerseInfo(5, 38),//Helaman 2:104
					new VerseInfo(5, 39),//Helaman 2:105
					new VerseInfo(5, 40),//Helaman 2:106
					new VerseInfo(5, 41),//Helaman 2:107
					new VerseInfo(5, 42),//Helaman 2:108
					new VerseInfo(5, 43),//Helaman 2:109
					new VerseInfo(5, 44),//Helaman 2:110
					new VerseInfo(5, 45),//Helaman 2:111
					new VerseInfo(5, 46, 5, 47),//Helaman 2:112
					new VerseInfo(5, 48),//Helaman 2:113
					new VerseInfo(5, 49),//Helaman 2:114
					new VerseInfo(5, 50),//Helaman 2:115
					new VerseInfo(5, 51),//Helaman 2:116
					new VerseInfo(5, 52),//Helaman 2:117
					new VerseInfo(6, 1),//Helaman 2:118
					new VerseInfo(6, 2),//Helaman 2:119
					new VerseInfo(6, 3),//Helaman 2:120
					new VerseInfo(6, 3),//Helaman 2:121
					new VerseInfo(6, 4),//Helaman 2:122
					new VerseInfo(6, 5),//Helaman 2:123
					new VerseInfo(6, 6),//Helaman 2:124
					new VerseInfo(6, 6),//Helaman 2:125
					new VerseInfo(6, 7),//Helaman 2:126
					new VerseInfo(6, 8),//Helaman 2:127
					new VerseInfo(6, 9),//Helaman 2:128
					new VerseInfo(6, 10),//Helaman 2:129
					new VerseInfo(6, 11),//Helaman 2:130
					new VerseInfo(6, 12),//Helaman 2:131
					new VerseInfo(6, 12),//Helaman 2:132
					new VerseInfo(6, 13),//Helaman 2:133
					new VerseInfo(6, 13),//Helaman 2:134
					new VerseInfo(6, 14),//Helaman 2:135
					new VerseInfo(6, 15),//Helaman 2:136
					new VerseInfo(6, 15),//Helaman 2:137
					new VerseInfo(6, 16),//Helaman 2:138
					new VerseInfo(6, 17),//Helaman 2:139
					new VerseInfo(6, 17),//Helaman 2:140
					new VerseInfo(6, 18),//Helaman 2:141
					new VerseInfo(6, 18),//Helaman 2:142
					new VerseInfo(6, 18, 6, 19),//Helaman 2:143
					new VerseInfo(6, 20),//Helaman 2:144
					new VerseInfo(6, 21),//Helaman 2:145
					new VerseInfo(6, 22),//Helaman 2:146
					new VerseInfo(6, 23),//Helaman 2:147
					new VerseInfo(6, 24),//Helaman 2:148
					new VerseInfo(6, 25),//Helaman 2:149
					new VerseInfo(6, 26),//Helaman 2:150
					new VerseInfo(6, 26, 6, 27),//Helaman 2:151
					new VerseInfo(6, 27),//Helaman 2:152
					new VerseInfo(6, 28),//Helaman 2:153
					new VerseInfo(6, 28),//Helaman 2:154
					new VerseInfo(6, 29),//Helaman 2:155
					new VerseInfo(6, 30),//Helaman 2:156
					new VerseInfo(6, 31),//Helaman 2:157
					new VerseInfo(6, 31),//Helaman 2:158
					new VerseInfo(6, 32),//Helaman 2:159
					new VerseInfo(6, 33),//Helaman 2:160
					new VerseInfo(6, 34),//Helaman 2:161
					new VerseInfo(6, 35),//Helaman 2:162
					new VerseInfo(6, 36),//Helaman 2:163
					new VerseInfo(6, 37),//Helaman 2:164
					new VerseInfo(6, 38),//Helaman 2:165
					new VerseInfo(6, 39),//Helaman 2:166
					new VerseInfo(6, 40),//Helaman 2:167
					new VerseInfo(6, 41),//Helaman 2:168
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Helaman 3
					new VerseInfo(7, 1, 7, 2),//Helaman 3:1
					new VerseInfo(7, 3),//Helaman 3:2
					new VerseInfo(7, 4, 7, 5),//Helaman 3:3
					new VerseInfo(7, 5),//Helaman 3:4
					new VerseInfo(7, 6),//Helaman 3:5
					new VerseInfo(7, 6, 7, 7),//Helaman 3:6
					new VerseInfo(7, 7),//Helaman 3:7
					new VerseInfo(7, 8),//Helaman 3:8
					new VerseInfo(7, 9),//Helaman 3:9
					new VerseInfo(7, 10),//Helaman 3:10
					new VerseInfo(7, 10),//Helaman 3:11
					new VerseInfo(7, 11),//Helaman 3:12
					new VerseInfo(7, 12),//Helaman 3:13
					new VerseInfo(7, 13),//Helaman 3:14
					new VerseInfo(7, 14),//Helaman 3:15
					new VerseInfo(7, 15),//Helaman 3:16
					new VerseInfo(7, 15, 7, 16),//Helaman 3:17
					new VerseInfo(7, 17),//Helaman 3:18
					new VerseInfo(7, 18),//Helaman 3:19
					new VerseInfo(7, 19),//Helaman 3:20
					new VerseInfo(7, 20),//Helaman 3:21
					new VerseInfo(7, 21),//Helaman 3:22
					new VerseInfo(7, 21, 7, 22),//Helaman 3:23
					new VerseInfo(7, 22),//Helaman 3:24
					new VerseInfo(7, 23),//Helaman 3:25
					new VerseInfo(7, 23, 7, 24),//Helaman 3:26
					new VerseInfo(7, 24),//Helaman 3:27
					new VerseInfo(7, 25),//Helaman 3:28
					new VerseInfo(7, 26, 7, 27),//Helaman 3:29
					new VerseInfo(7, 28),//Helaman 3:30
					new VerseInfo(7, 29),//Helaman 3:31
					new VerseInfo(8, 1),//Helaman 3:32
					new VerseInfo(8, 1),//Helaman 3:33
					new VerseInfo(8, 2),//Helaman 3:34
					new VerseInfo(8, 3),//Helaman 3:35
					new VerseInfo(8, 4, 8, 5),//Helaman 3:36
					new VerseInfo(8, 5),//Helaman 3:37
					new VerseInfo(8, 6),//Helaman 3:38
					new VerseInfo(8, 7),//Helaman 3:39
					new VerseInfo(8, 8),//Helaman 3:40
					new VerseInfo(8, 8, 8, 9),//Helaman 3:41
					new VerseInfo(8, 10),//Helaman 3:42
					new VerseInfo(8, 10),//Helaman 3:43
					new VerseInfo(8, 11),//Helaman 3:44
					new VerseInfo(8, 12),//Helaman 3:45
					new VerseInfo(8, 13),//Helaman 3:46
					new VerseInfo(8, 14),//Helaman 3:47
					new VerseInfo(8, 15),//Helaman 3:48
					new VerseInfo(8, 16),//Helaman 3:49
					new VerseInfo(8, 17),//Helaman 3:50
					new VerseInfo(8, 18),//Helaman 3:51
					new VerseInfo(8, 18),//Helaman 3:52
					new VerseInfo(8, 19, 8, 20),//Helaman 3:53
					new VerseInfo(8, 20),//Helaman 3:54
					new VerseInfo(8, 20),//Helaman 3:55
					new VerseInfo(8, 21),//Helaman 3:56
					new VerseInfo(8, 21),//Helaman 3:57
					new VerseInfo(8, 21, 8, 22),//Helaman 3:58
					new VerseInfo(8, 22),//Helaman 3:59
					new VerseInfo(8, 23),//Helaman 3:60
					new VerseInfo(8, 24),//Helaman 3:61
					new VerseInfo(8, 24),//Helaman 3:62
					new VerseInfo(8, 25),//Helaman 3:63
					new VerseInfo(8, 26),//Helaman 3:64
					new VerseInfo(8, 27),//Helaman 3:65
					new VerseInfo(8, 28),//Helaman 3:66
					new VerseInfo(9, 1),//Helaman 3:67
					new VerseInfo(9, 1, 9, 2),//Helaman 3:68
					new VerseInfo(9, 2),//Helaman 3:69
					new VerseInfo(9, 3),//Helaman 3:70
					new VerseInfo(9, 4),//Helaman 3:71
					new VerseInfo(9, 5),//Helaman 3:72
					new VerseInfo(9, 6),//Helaman 3:73
					new VerseInfo(9, 7),//Helaman 3:74
					new VerseInfo(9, 8),//Helaman 3:75
					new VerseInfo(9, 9),//Helaman 3:76
					new VerseInfo(9, 9),//Helaman 3:77
					new VerseInfo(9, 10),//Helaman 3:78
					new VerseInfo(9, 11),//Helaman 3:79
					new VerseInfo(9, 12),//Helaman 3:80
					new VerseInfo(9, 12),//Helaman 3:81
					new VerseInfo(9, 13),//Helaman 3:82
					new VerseInfo(9, 13, 9, 14),//Helaman 3:83
					new VerseInfo(9, 15),//Helaman 3:84
					new VerseInfo(9, 16),//Helaman 3:85
					new VerseInfo(9, 17),//Helaman 3:86
					new VerseInfo(9, 18),//Helaman 3:87
					new VerseInfo(9, 18),//Helaman 3:88
					new VerseInfo(9, 19),//Helaman 3:89
					new VerseInfo(9, 20),//Helaman 3:90
					new VerseInfo(9, 21),//Helaman 3:91
					new VerseInfo(9, 22),//Helaman 3:92
					new VerseInfo(9, 23),//Helaman 3:93
					new VerseInfo(9, 23),//Helaman 3:94
					new VerseInfo(9, 24),//Helaman 3:95
					new VerseInfo(9, 25),//Helaman 3:96
					new VerseInfo(9, 26, 9, 28),//Helaman 3:97
					new VerseInfo(9, 29, 9, 30),//Helaman 3:98
					new VerseInfo(9, 30),//Helaman 3:99
					new VerseInfo(9, 31),//Helaman 3:100
					new VerseInfo(9, 32, 9, 33),//Helaman 3:101
					new VerseInfo(9, 34),//Helaman 3:102
					new VerseInfo(9, 35),//Helaman 3:103
					new VerseInfo(9, 36),//Helaman 3:104
					new VerseInfo(9, 36),//Helaman 3:105
					new VerseInfo(9, 37),//Helaman 3:106
					new VerseInfo(9, 37),//Helaman 3:107
					new VerseInfo(9, 38),//Helaman 3:108
					new VerseInfo(9, 39),//Helaman 3:109
					new VerseInfo(9, 40, 9, 41),//Helaman 3:110
					new VerseInfo(9, 41),//Helaman 3:111
					new VerseInfo(10, 1),//Helaman 3:112
					new VerseInfo(10, 2),//Helaman 3:113
					new VerseInfo(10, 3),//Helaman 3:114
					new VerseInfo(10, 4),//Helaman 3:115
					new VerseInfo(10, 4),//Helaman 3:116
					new VerseInfo(10, 5),//Helaman 3:117
					new VerseInfo(10, 6),//Helaman 3:118
					new VerseInfo(10, 6),//Helaman 3:119
					new VerseInfo(10, 7),//Helaman 3:120
					new VerseInfo(10, 8),//Helaman 3:121
					new VerseInfo(10, 9),//Helaman 3:122
					new VerseInfo(10, 10),//Helaman 3:123
					new VerseInfo(10, 11),//Helaman 3:124
					new VerseInfo(10, 12),//Helaman 3:125
					new VerseInfo(10, 13),//Helaman 3:126
					new VerseInfo(10, 14),//Helaman 3:127
					new VerseInfo(10, 15),//Helaman 3:128
					new VerseInfo(10, 16),//Helaman 3:129
					new VerseInfo(10, 17),//Helaman 3:130
					new VerseInfo(10, 18),//Helaman 3:131
					new VerseInfo(10, 19),//Helaman 3:132
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Helaman 4
					new VerseInfo(11, 1),//Helaman 4:1
					new VerseInfo(11, 2),//Helaman 4:2
					new VerseInfo(11, 2),//Helaman 4:3
					new VerseInfo(11, 3, 11, 4),//Helaman 4:4
					new VerseInfo(11, 5),//Helaman 4:5
					new VerseInfo(11, 5),//Helaman 4:6
					new VerseInfo(11, 6),//Helaman 4:7
					new VerseInfo(11, 6),//Helaman 4:8
					new VerseInfo(11, 7),//Helaman 4:9
					new VerseInfo(11, 8),//Helaman 4:10
					new VerseInfo(11, 9),//Helaman 4:11
					new VerseInfo(11, 9, 11, 10),//Helaman 4:12
					new VerseInfo(11, 10),//Helaman 4:13
					new VerseInfo(11, 11),//Helaman 4:14
					new VerseInfo(11, 12),//Helaman 4:15
					new VerseInfo(11, 13),//Helaman 4:16
					new VerseInfo(11, 14),//Helaman 4:17
					new VerseInfo(11, 15),//Helaman 4:18
					new VerseInfo(11, 16),//Helaman 4:19
					new VerseInfo(11, 17),//Helaman 4:20
					new VerseInfo(11, 17),//Helaman 4:21
					new VerseInfo(11, 18),//Helaman 4:22
					new VerseInfo(11, 19),//Helaman 4:23
					new VerseInfo(11, 20),//Helaman 4:24
					new VerseInfo(11, 21),//Helaman 4:25
					new VerseInfo(11, 21),//Helaman 4:26
					new VerseInfo(11, 22),//Helaman 4:27
					new VerseInfo(11, 23),//Helaman 4:28
					new VerseInfo(11, 23),//Helaman 4:29
					new VerseInfo(11, 24),//Helaman 4:30
					new VerseInfo(11, 24),//Helaman 4:31
					new VerseInfo(11, 25),//Helaman 4:32
					new VerseInfo(11, 26),//Helaman 4:33
					new VerseInfo(11, 27),//Helaman 4:34
					new VerseInfo(11, 28),//Helaman 4:35
					new VerseInfo(11, 29),//Helaman 4:36
					new VerseInfo(11, 29),//Helaman 4:37
					new VerseInfo(11, 30),//Helaman 4:38
					new VerseInfo(11, 30, 11, 31),//Helaman 4:39
					new VerseInfo(11, 32),//Helaman 4:40
					new VerseInfo(11, 33),//Helaman 4:41
					new VerseInfo(11, 34),//Helaman 4:42
					new VerseInfo(11, 35),//Helaman 4:43
					new VerseInfo(11, 36),//Helaman 4:44
					new VerseInfo(11, 36),//Helaman 4:45
					new VerseInfo(11, 36),//Helaman 4:46
					new VerseInfo(11, 37, 11, 38),//Helaman 4:47
					new VerseInfo(12, 1),//Helaman 4:48
					new VerseInfo(12, 2),//Helaman 4:49
					new VerseInfo(12, 2),//Helaman 4:50
					new VerseInfo(12, 2),//Helaman 4:51
					new VerseInfo(12, 3),//Helaman 4:52
					new VerseInfo(12, 4),//Helaman 4:53
					new VerseInfo(12, 4, 12, 5),//Helaman 4:54
					new VerseInfo(12, 5),//Helaman 4:55
					new VerseInfo(12, 6),//Helaman 4:56
					new VerseInfo(12, 7),//Helaman 4:57
					new VerseInfo(12, 8),//Helaman 4:58
					new VerseInfo(12, 9, 12, 10),//Helaman 4:59
					new VerseInfo(12, 11, 12, 12),//Helaman 4:60
					new VerseInfo(12, 13, 12, 14),//Helaman 4:61
					new VerseInfo(12, 15),//Helaman 4:62
					new VerseInfo(12, 16),//Helaman 4:63
					new VerseInfo(12, 17),//Helaman 4:64
					new VerseInfo(12, 18),//Helaman 4:65
					new VerseInfo(12, 19),//Helaman 4:66
					new VerseInfo(12, 20),//Helaman 4:67
					new VerseInfo(12, 21),//Helaman 4:68
					new VerseInfo(12, 22),//Helaman 4:69
					new VerseInfo(12, 23),//Helaman 4:70
					new VerseInfo(12, 24),//Helaman 4:71
					new VerseInfo(12, 25),//Helaman 4:72
					new VerseInfo(12, 26),//Helaman 4:73
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Helaman 5
					new VerseInfo(13, 1),//Helaman 5:1
					new VerseInfo(13, 2),//Helaman 5:2
					new VerseInfo(13, 2),//Helaman 5:3
					new VerseInfo(13, 3),//Helaman 5:4
					new VerseInfo(13, 4),//Helaman 5:5
					new VerseInfo(13, 5),//Helaman 5:6
					new VerseInfo(13, 6),//Helaman 5:7
					new VerseInfo(13, 7),//Helaman 5:8
					new VerseInfo(13, 7),//Helaman 5:9
					new VerseInfo(13, 8),//Helaman 5:10
					new VerseInfo(13, 9),//Helaman 5:11
					new VerseInfo(13, 10),//Helaman 5:12
					new VerseInfo(13, 10),//Helaman 5:13
					new VerseInfo(13, 11),//Helaman 5:14
					new VerseInfo(13, 12),//Helaman 5:15
					new VerseInfo(13, 12, 13, 13),//Helaman 5:16
					new VerseInfo(13, 13, 13, 14),//Helaman 5:17
					new VerseInfo(13, 14),//Helaman 5:18
					new VerseInfo(13, 14),//Helaman 5:19
					new VerseInfo(13, 15),//Helaman 5:20
					new VerseInfo(13, 16),//Helaman 5:21
					new VerseInfo(13, 17),//Helaman 5:22
					new VerseInfo(13, 18),//Helaman 5:23
					new VerseInfo(13, 19),//Helaman 5:24
					new VerseInfo(13, 19),//Helaman 5:25
					new VerseInfo(13, 20),//Helaman 5:26
					new VerseInfo(13, 20),//Helaman 5:27
					new VerseInfo(13, 21),//Helaman 5:28
					new VerseInfo(13, 21),//Helaman 5:29
					new VerseInfo(13, 22),//Helaman 5:30
					new VerseInfo(13, 22),//Helaman 5:31
					new VerseInfo(13, 23),//Helaman 5:32
					new VerseInfo(13, 24),//Helaman 5:33
					new VerseInfo(13, 25),//Helaman 5:34
					new VerseInfo(13, 26),//Helaman 5:35
					new VerseInfo(13, 26),//Helaman 5:36
					new VerseInfo(13, 27),//Helaman 5:37
					new VerseInfo(13, 28),//Helaman 5:38
					new VerseInfo(13, 28),//Helaman 5:39
					new VerseInfo(13, 29),//Helaman 5:40
					new VerseInfo(13, 30, 13, 31),//Helaman 5:41
					new VerseInfo(13, 31, 13, 32),//Helaman 5:42
					new VerseInfo(13, 32),//Helaman 5:43
					new VerseInfo(13, 32, 13, 33),//Helaman 5:44
					new VerseInfo(13, 33),//Helaman 5:45
					new VerseInfo(13, 34),//Helaman 5:46
					new VerseInfo(13, 35),//Helaman 5:47
					new VerseInfo(13, 36),//Helaman 5:48
					new VerseInfo(13, 37),//Helaman 5:49
					new VerseInfo(13, 37),//Helaman 5:50
					new VerseInfo(13, 38),//Helaman 5:51
					new VerseInfo(13, 38),//Helaman 5:52
					new VerseInfo(13, 39),//Helaman 5:53
					new VerseInfo(14, 1),//Helaman 5:54
					new VerseInfo(14, 2),//Helaman 5:55
					new VerseInfo(14, 3),//Helaman 5:56
					new VerseInfo(14, 4),//Helaman 5:57
					new VerseInfo(14, 4),//Helaman 5:58
					new VerseInfo(14, 5),//Helaman 5:59
					new VerseInfo(14, 6),//Helaman 5:60
					new VerseInfo(14, 7),//Helaman 5:61
					new VerseInfo(14, 8),//Helaman 5:62
					new VerseInfo(14, 9),//Helaman 5:63
					new VerseInfo(14, 10),//Helaman 5:64
					new VerseInfo(14, 11),//Helaman 5:65
					new VerseInfo(14, 12),//Helaman 5:66
					new VerseInfo(14, 13),//Helaman 5:67
					new VerseInfo(14, 14, 14, 15),//Helaman 5:68
					new VerseInfo(14, 15),//Helaman 5:69
					new VerseInfo(14, 16),//Helaman 5:70
					new VerseInfo(14, 17),//Helaman 5:71
					new VerseInfo(14, 18),//Helaman 5:72
					new VerseInfo(14, 18),//Helaman 5:73
					new VerseInfo(14, 19),//Helaman 5:74
					new VerseInfo(14, 20),//Helaman 5:75
					new VerseInfo(14, 20),//Helaman 5:76
					new VerseInfo(14, 21),//Helaman 5:77
					new VerseInfo(14, 22),//Helaman 5:78
					new VerseInfo(14, 23),//Helaman 5:79
					new VerseInfo(14, 24, 14, 25),//Helaman 5:80
					new VerseInfo(14, 26),//Helaman 5:81
					new VerseInfo(14, 27),//Helaman 5:82
					new VerseInfo(14, 28),//Helaman 5:83
					new VerseInfo(14, 29),//Helaman 5:84
					new VerseInfo(14, 30),//Helaman 5:85
					new VerseInfo(14, 31),//Helaman 5:86
					new VerseInfo(15, 1, 15, 2),//Helaman 5:87
					new VerseInfo(15, 2),//Helaman 5:88
					new VerseInfo(15, 3),//Helaman 5:89
					new VerseInfo(15, 3),//Helaman 5:90
					new VerseInfo(15, 4),//Helaman 5:91
					new VerseInfo(15, 4),//Helaman 5:92
					new VerseInfo(15, 5),//Helaman 5:93
					new VerseInfo(15, 6),//Helaman 5:94
					new VerseInfo(15, 7),//Helaman 5:95
					new VerseInfo(15, 7),//Helaman 5:96
					new VerseInfo(15, 8),//Helaman 5:97
					new VerseInfo(15, 9),//Helaman 5:98
					new VerseInfo(15, 9),//Helaman 5:99
					new VerseInfo(15, 10),//Helaman 5:100
					new VerseInfo(15, 11),//Helaman 5:101
					new VerseInfo(15, 12),//Helaman 5:102
					new VerseInfo(15, 12),//Helaman 5:103
					new VerseInfo(15, 13),//Helaman 5:104
					new VerseInfo(15, 14),//Helaman 5:105
					new VerseInfo(15, 15),//Helaman 5:106
					new VerseInfo(15, 16),//Helaman 5:107
					new VerseInfo(15, 17),//Helaman 5:108
					new VerseInfo(16, 1),//Helaman 5:109
					new VerseInfo(16, 1),//Helaman 5:110
					new VerseInfo(16, 2),//Helaman 5:111
					new VerseInfo(16, 2),//Helaman 5:112
					new VerseInfo(16, 3),//Helaman 5:113
					new VerseInfo(16, 4),//Helaman 5:114
					new VerseInfo(16, 5),//Helaman 5:115
					new VerseInfo(16, 5),//Helaman 5:116
					new VerseInfo(16, 6),//Helaman 5:117
					new VerseInfo(16, 6),//Helaman 5:118
					new VerseInfo(16, 7),//Helaman 5:119
					new VerseInfo(16, 8),//Helaman 5:120
					new VerseInfo(16, 9),//Helaman 5:121
					new VerseInfo(16, 10),//Helaman 5:122
					new VerseInfo(16, 11),//Helaman 5:123
					new VerseInfo(16, 12),//Helaman 5:124
					new VerseInfo(16, 13),//Helaman 5:125
					new VerseInfo(16, 14),//Helaman 5:126
					new VerseInfo(16, 15),//Helaman 5:127
					new VerseInfo(16, 16),//Helaman 5:128
					new VerseInfo(16, 17, 16, 18),//Helaman 5:129
					new VerseInfo(16, 18),//Helaman 5:130
					new VerseInfo(16, 19),//Helaman 5:131
					new VerseInfo(16, 20),//Helaman 5:132
					new VerseInfo(16, 20),//Helaman 5:133
					new VerseInfo(16, 21),//Helaman 5:134
					new VerseInfo(16, 21),//Helaman 5:135
					new VerseInfo(16, 22),//Helaman 5:136
					new VerseInfo(16, 22),//Helaman 5:137
					new VerseInfo(16, 23),//Helaman 5:138
					new VerseInfo(16, 24),//Helaman 5:139
					new VerseInfo(16, 25),//Helaman 5:140
				},
			}
		},
		{ "3 Nephi", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//3 Nephi 1
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
					new VerseInfo(1, 12, 1, 13),//3 Nephi 1:12
					new VerseInfo(1, 13),//3 Nephi 1:13
					new VerseInfo(1, 14),//3 Nephi 1:14
					new VerseInfo(1, 14),//3 Nephi 1:15
					new VerseInfo(1, 15),//3 Nephi 1:16
					new VerseInfo(1, 15),//3 Nephi 1:17
					new VerseInfo(1, 16, 1, 17),//3 Nephi 1:18
					new VerseInfo(1, 17),//3 Nephi 1:19
					new VerseInfo(1, 18),//3 Nephi 1:20
					new VerseInfo(1, 19),//3 Nephi 1:21
					new VerseInfo(1, 19),//3 Nephi 1:22
					new VerseInfo(1, 20),//3 Nephi 1:23
					new VerseInfo(1, 21),//3 Nephi 1:24
					new VerseInfo(1, 22),//3 Nephi 1:25
					new VerseInfo(1, 22),//3 Nephi 1:26
					new VerseInfo(1, 23),//3 Nephi 1:27
					new VerseInfo(1, 23, 1, 24),//3 Nephi 1:28
					new VerseInfo(1, 24),//3 Nephi 1:29
					new VerseInfo(1, 25),//3 Nephi 1:30
					new VerseInfo(1, 25),//3 Nephi 1:31
					new VerseInfo(1, 26),//3 Nephi 1:32
					new VerseInfo(1, 27),//3 Nephi 1:33
					new VerseInfo(1, 27),//3 Nephi 1:34
					new VerseInfo(1, 28),//3 Nephi 1:35
					new VerseInfo(1, 29),//3 Nephi 1:36
					new VerseInfo(1, 30),//3 Nephi 1:37
					new VerseInfo(2, 1),//3 Nephi 1:38
					new VerseInfo(2, 1, 2, 2),//3 Nephi 1:39
					new VerseInfo(2, 2),//3 Nephi 1:40
					new VerseInfo(2, 3),//3 Nephi 1:41
					new VerseInfo(2, 3),//3 Nephi 1:42
					new VerseInfo(2, 4, 2, 5),//3 Nephi 1:43
					new VerseInfo(2, 6, 2, 7),//3 Nephi 1:44
					new VerseInfo(2, 8),//3 Nephi 1:45
					new VerseInfo(2, 8, 2, 9),//3 Nephi 1:46
					new VerseInfo(2, 10),//3 Nephi 1:47
					new VerseInfo(2, 11),//3 Nephi 1:48
					new VerseInfo(2, 12),//3 Nephi 1:49
					new VerseInfo(2, 12),//3 Nephi 1:50
					new VerseInfo(2, 13),//3 Nephi 1:51
					new VerseInfo(2, 14, 2, 15),//3 Nephi 1:52
					new VerseInfo(2, 16),//3 Nephi 1:53
					new VerseInfo(2, 17),//3 Nephi 1:54
					new VerseInfo(2, 17, 2, 18),//3 Nephi 1:55
					new VerseInfo(2, 18),//3 Nephi 1:56
					new VerseInfo(2, 19),//3 Nephi 1:57
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//3 Nephi 2
					new VerseInfo(3, 1),//3 Nephi 2:1
					new VerseInfo(3, 1, 3, 2),//3 Nephi 2:2
					new VerseInfo(3, 2),//3 Nephi 2:3
					new VerseInfo(3, 3),//3 Nephi 2:4
					new VerseInfo(3, 4),//3 Nephi 2:5
					new VerseInfo(3, 5),//3 Nephi 2:6
					new VerseInfo(3, 6),//3 Nephi 2:7
					new VerseInfo(3, 7),//3 Nephi 2:8
					new VerseInfo(3, 8),//3 Nephi 2:9
					new VerseInfo(3, 8),//3 Nephi 2:10
					new VerseInfo(3, 9),//3 Nephi 2:11
					new VerseInfo(3, 10),//3 Nephi 2:12
					new VerseInfo(3, 11),//3 Nephi 2:13
					new VerseInfo(3, 11),//3 Nephi 2:14
					new VerseInfo(3, 12),//3 Nephi 2:15
					new VerseInfo(3, 12),//3 Nephi 2:16
					new VerseInfo(3, 13),//3 Nephi 2:17
					new VerseInfo(3, 14),//3 Nephi 2:18
					new VerseInfo(3, 14),//3 Nephi 2:19
					new VerseInfo(3, 15),//3 Nephi 2:20
					new VerseInfo(3, 16),//3 Nephi 2:21
					new VerseInfo(3, 17),//3 Nephi 2:22
					new VerseInfo(3, 18),//3 Nephi 2:23
					new VerseInfo(3, 19),//3 Nephi 2:24
					new VerseInfo(3, 20),//3 Nephi 2:25
					new VerseInfo(3, 21),//3 Nephi 2:26
					new VerseInfo(3, 21),//3 Nephi 2:27
					new VerseInfo(3, 21),//3 Nephi 2:28
					new VerseInfo(3, 22),//3 Nephi 2:29
					new VerseInfo(3, 22),//3 Nephi 2:30
					new VerseInfo(3, 22),//3 Nephi 2:31
					new VerseInfo(3, 23),//3 Nephi 2:32
					new VerseInfo(3, 24),//3 Nephi 2:33
					new VerseInfo(3, 24, 3, 25),//3 Nephi 2:34
					new VerseInfo(3, 25),//3 Nephi 2:35
					new VerseInfo(3, 25),//3 Nephi 2:36
					new VerseInfo(3, 26),//3 Nephi 2:37
					new VerseInfo(3, 26),//3 Nephi 2:38
					new VerseInfo(4, 1),//3 Nephi 2:39
					new VerseInfo(4, 1),//3 Nephi 2:40
					new VerseInfo(4, 2),//3 Nephi 2:41
					new VerseInfo(4, 3),//3 Nephi 2:42
					new VerseInfo(4, 4),//3 Nephi 2:43
					new VerseInfo(4, 4),//3 Nephi 2:44
					new VerseInfo(4, 4),//3 Nephi 2:45
					new VerseInfo(4, 5),//3 Nephi 2:46
					new VerseInfo(4, 6),//3 Nephi 2:47
					new VerseInfo(4, 6),//3 Nephi 2:48
					new VerseInfo(4, 7),//3 Nephi 2:49
					new VerseInfo(4, 7),//3 Nephi 2:50
					new VerseInfo(4, 7),//3 Nephi 2:51
					new VerseInfo(4, 8),//3 Nephi 2:52
					new VerseInfo(4, 9),//3 Nephi 2:53
					new VerseInfo(4, 10),//3 Nephi 2:54
					new VerseInfo(4, 10, 4, 11),//3 Nephi 2:55
					new VerseInfo(4, 11),//3 Nephi 2:56
					new VerseInfo(4, 12),//3 Nephi 2:57
					new VerseInfo(4, 13),//3 Nephi 2:58
					new VerseInfo(4, 13),//3 Nephi 2:59
					new VerseInfo(4, 14),//3 Nephi 2:60
					new VerseInfo(4, 15),//3 Nephi 2:61
					new VerseInfo(4, 15),//3 Nephi 2:62
					new VerseInfo(4, 16),//3 Nephi 2:63
					new VerseInfo(4, 16),//3 Nephi 2:64
					new VerseInfo(4, 17),//3 Nephi 2:65
					new VerseInfo(4, 18, 4, 19),//3 Nephi 2:66
					new VerseInfo(4, 19),//3 Nephi 2:67
					new VerseInfo(4, 20),//3 Nephi 2:68
					new VerseInfo(4, 21),//3 Nephi 2:69
					new VerseInfo(4, 22),//3 Nephi 2:70
					new VerseInfo(4, 23),//3 Nephi 2:71
					new VerseInfo(4, 24),//3 Nephi 2:72
					new VerseInfo(4, 25),//3 Nephi 2:73
					new VerseInfo(4, 26),//3 Nephi 2:74
					new VerseInfo(4, 27, 4, 28),//3 Nephi 2:75
					new VerseInfo(4, 28, 4, 29),//3 Nephi 2:76
					new VerseInfo(4, 30),//3 Nephi 2:77
					new VerseInfo(4, 31),//3 Nephi 2:78
					new VerseInfo(4, 32),//3 Nephi 2:79
					new VerseInfo(4, 33),//3 Nephi 2:80
					new VerseInfo(4, 33),//3 Nephi 2:81
					new VerseInfo(5, 1),//3 Nephi 2:82
					new VerseInfo(5, 1, 5, 2),//3 Nephi 2:83
					new VerseInfo(5, 2),//3 Nephi 2:84
					new VerseInfo(5, 3),//3 Nephi 2:85
					new VerseInfo(5, 4),//3 Nephi 2:86
					new VerseInfo(5, 4),//3 Nephi 2:87
					new VerseInfo(5, 5),//3 Nephi 2:88
					new VerseInfo(5, 6),//3 Nephi 2:89
					new VerseInfo(5, 7),//3 Nephi 2:90
					new VerseInfo(5, 7, 5, 8),//3 Nephi 2:91
					new VerseInfo(5, 8),//3 Nephi 2:92
					new VerseInfo(5, 9),//3 Nephi 2:93
					new VerseInfo(5, 10),//3 Nephi 2:94
					new VerseInfo(5, 11),//3 Nephi 2:95
					new VerseInfo(5, 12),//3 Nephi 2:96
					new VerseInfo(5, 13),//3 Nephi 2:97
					new VerseInfo(5, 14),//3 Nephi 2:98
					new VerseInfo(5, 15),//3 Nephi 2:99
					new VerseInfo(5, 16, 5, 17),//3 Nephi 2:100
					new VerseInfo(5, 18),//3 Nephi 2:101
					new VerseInfo(5, 19, 5, 20),//3 Nephi 2:102
					new VerseInfo(5, 20),//3 Nephi 2:103
					new VerseInfo(5, 21),//3 Nephi 2:104
					new VerseInfo(5, 22),//3 Nephi 2:105
					new VerseInfo(5, 23),//3 Nephi 2:106
					new VerseInfo(5, 24),//3 Nephi 2:107
					new VerseInfo(5, 25),//3 Nephi 2:108
					new VerseInfo(5, 26),//3 Nephi 2:109
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//3 Nephi 3
					new VerseInfo(6, 1),//3 Nephi 3:1
					new VerseInfo(6, 2),//3 Nephi 3:2
					new VerseInfo(6, 2),//3 Nephi 3:3
					new VerseInfo(6, 3),//3 Nephi 3:4
					new VerseInfo(6, 4),//3 Nephi 3:5
					new VerseInfo(6, 5),//3 Nephi 3:6
					new VerseInfo(6, 6),//3 Nephi 3:7
					new VerseInfo(6, 7, 6, 8),//3 Nephi 3:8
					new VerseInfo(6, 9),//3 Nephi 3:9
					new VerseInfo(6, 10),//3 Nephi 3:10
					new VerseInfo(6, 10, 6, 11),//3 Nephi 3:11
					new VerseInfo(6, 12),//3 Nephi 3:12
					new VerseInfo(6, 12),//3 Nephi 3:13
					new VerseInfo(6, 13),//3 Nephi 3:14
					new VerseInfo(6, 14),//3 Nephi 3:15
					new VerseInfo(6, 14),//3 Nephi 3:16
					new VerseInfo(6, 15),//3 Nephi 3:17
					new VerseInfo(6, 16),//3 Nephi 3:18
					new VerseInfo(6, 17),//3 Nephi 3:19
					new VerseInfo(6, 18),//3 Nephi 3:20
					new VerseInfo(6, 19),//3 Nephi 3:21
					new VerseInfo(6, 20),//3 Nephi 3:22
					new VerseInfo(6, 20),//3 Nephi 3:23
					new VerseInfo(6, 21),//3 Nephi 3:24
					new VerseInfo(6, 21),//3 Nephi 3:25
					new VerseInfo(6, 21),//3 Nephi 3:26
					new VerseInfo(6, 22),//3 Nephi 3:27
					new VerseInfo(6, 23),//3 Nephi 3:28
					new VerseInfo(6, 24),//3 Nephi 3:29
					new VerseInfo(6, 25),//3 Nephi 3:30
					new VerseInfo(6, 26),//3 Nephi 3:31
					new VerseInfo(6, 27),//3 Nephi 3:32
					new VerseInfo(6, 28),//3 Nephi 3:33
					new VerseInfo(6, 29),//3 Nephi 3:34
					new VerseInfo(6, 30),//3 Nephi 3:35
					new VerseInfo(7, 1),//3 Nephi 3:36
					new VerseInfo(7, 2),//3 Nephi 3:37
					new VerseInfo(7, 3),//3 Nephi 3:38
					new VerseInfo(7, 4),//3 Nephi 3:39
					new VerseInfo(7, 5),//3 Nephi 3:40
					new VerseInfo(7, 6),//3 Nephi 3:41
					new VerseInfo(7, 7),//3 Nephi 3:42
					new VerseInfo(7, 8),//3 Nephi 3:43
					new VerseInfo(7, 9, 7, 10),//3 Nephi 3:44
					new VerseInfo(7, 10),//3 Nephi 3:45
					new VerseInfo(7, 11),//3 Nephi 3:46
					new VerseInfo(7, 11),//3 Nephi 3:47
					new VerseInfo(7, 12),//3 Nephi 3:48
					new VerseInfo(7, 12),//3 Nephi 3:49
					new VerseInfo(7, 12, 7, 13),//3 Nephi 3:50
					new VerseInfo(7, 13),//3 Nephi 3:51
					new VerseInfo(7, 14),//3 Nephi 3:52
					new VerseInfo(7, 14),//3 Nephi 3:53
					new VerseInfo(7, 14),//3 Nephi 3:54
					new VerseInfo(7, 14),//3 Nephi 3:55
					new VerseInfo(7, 15),//3 Nephi 3:56
					new VerseInfo(7, 16),//3 Nephi 3:57
					new VerseInfo(7, 17),//3 Nephi 3:58
					new VerseInfo(7, 18),//3 Nephi 3:59
					new VerseInfo(7, 19),//3 Nephi 3:60
					new VerseInfo(7, 20),//3 Nephi 3:61
					new VerseInfo(7, 21),//3 Nephi 3:62
					new VerseInfo(7, 21),//3 Nephi 3:63
					new VerseInfo(7, 22),//3 Nephi 3:64
					new VerseInfo(7, 22),//3 Nephi 3:65
					new VerseInfo(7, 23),//3 Nephi 3:66
					new VerseInfo(7, 23),//3 Nephi 3:67
					new VerseInfo(7, 24),//3 Nephi 3:68
					new VerseInfo(7, 25),//3 Nephi 3:69
					new VerseInfo(7, 26),//3 Nephi 3:70
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//3 Nephi 4
					new VerseInfo(8, 1),//3 Nephi 4:1
					new VerseInfo(8, 1),//3 Nephi 4:2
					new VerseInfo(8, 2, 8, 3),//3 Nephi 4:3
					new VerseInfo(8, 3),//3 Nephi 4:4
					new VerseInfo(8, 4),//3 Nephi 4:5
					new VerseInfo(8, 5),//3 Nephi 4:6
					new VerseInfo(8, 6, 8, 7),//3 Nephi 4:7
					new VerseInfo(8, 8, 8, 9),//3 Nephi 4:8
					new VerseInfo(8, 10, 8, 11),//3 Nephi 4:9
					new VerseInfo(8, 12),//3 Nephi 4:10
					new VerseInfo(8, 13, 8, 14),//3 Nephi 4:11
					new VerseInfo(8, 15),//3 Nephi 4:12
					new VerseInfo(8, 16),//3 Nephi 4:13
					new VerseInfo(8, 17),//3 Nephi 4:14
					new VerseInfo(8, 18),//3 Nephi 4:15
					new VerseInfo(8, 19),//3 Nephi 4:16
					new VerseInfo(8, 19),//3 Nephi 4:17
					new VerseInfo(8, 20),//3 Nephi 4:18
					new VerseInfo(8, 21),//3 Nephi 4:19
					new VerseInfo(8, 22),//3 Nephi 4:20
					new VerseInfo(8, 23),//3 Nephi 4:21
					new VerseInfo(8, 23),//3 Nephi 4:22
					new VerseInfo(8, 24),//3 Nephi 4:23
					new VerseInfo(8, 25),//3 Nephi 4:24
					new VerseInfo(8, 25),//3 Nephi 4:25
					new VerseInfo(9, 1, 9, 2),//3 Nephi 4:26
					new VerseInfo(9, 2),//3 Nephi 4:27
					new VerseInfo(9, 3),//3 Nephi 4:28
					new VerseInfo(9, 4),//3 Nephi 4:29
					new VerseInfo(9, 5),//3 Nephi 4:30
					new VerseInfo(9, 6),//3 Nephi 4:31
					new VerseInfo(9, 7),//3 Nephi 4:32
					new VerseInfo(9, 7),//3 Nephi 4:33
					new VerseInfo(9, 8),//3 Nephi 4:34
					new VerseInfo(9, 8),//3 Nephi 4:35
					new VerseInfo(9, 9),//3 Nephi 4:36
					new VerseInfo(9, 9),//3 Nephi 4:37
					new VerseInfo(9, 10),//3 Nephi 4:38
					new VerseInfo(9, 11),//3 Nephi 4:39
					new VerseInfo(9, 12),//3 Nephi 4:40
					new VerseInfo(9, 13),//3 Nephi 4:41
					new VerseInfo(9, 14),//3 Nephi 4:42
					new VerseInfo(9, 14),//3 Nephi 4:43
					new VerseInfo(9, 15),//3 Nephi 4:44
					new VerseInfo(9, 15),//3 Nephi 4:45
					new VerseInfo(9, 16),//3 Nephi 4:46
					new VerseInfo(9, 17),//3 Nephi 4:47
					new VerseInfo(9, 18),//3 Nephi 4:48
					new VerseInfo(9, 19, 9, 20),//3 Nephi 4:49
					new VerseInfo(9, 20),//3 Nephi 4:50
					new VerseInfo(9, 21, 9, 22),//3 Nephi 4:51
					new VerseInfo(9, 22),//3 Nephi 4:52
					new VerseInfo(10, 1),//3 Nephi 4:53
					new VerseInfo(10, 1, 10, 2),//3 Nephi 4:54
					new VerseInfo(10, 3, 10, 4),//3 Nephi 4:55
					new VerseInfo(10, 5),//3 Nephi 4:56
					new VerseInfo(10, 5),//3 Nephi 4:57
					new VerseInfo(10, 6),//3 Nephi 4:58
					new VerseInfo(10, 7),//3 Nephi 4:59
					new VerseInfo(10, 8),//3 Nephi 4:60
					new VerseInfo(10, 9),//3 Nephi 4:61
					new VerseInfo(10, 9),//3 Nephi 4:62
					new VerseInfo(10, 10),//3 Nephi 4:63
					new VerseInfo(10, 10),//3 Nephi 4:64
					new VerseInfo(10, 11),//3 Nephi 4:65
					new VerseInfo(10, 12),//3 Nephi 4:66
					new VerseInfo(10, 13),//3 Nephi 4:67
					new VerseInfo(10, 13),//3 Nephi 4:68
					new VerseInfo(10, 14),//3 Nephi 4:69
					new VerseInfo(10, 15),//3 Nephi 4:70
					new VerseInfo(10, 16),//3 Nephi 4:71
					new VerseInfo(10, 17),//3 Nephi 4:72
					new VerseInfo(10, 17),//3 Nephi 4:73
					new VerseInfo(10, 18, 10, 19),//3 Nephi 4:74
					new VerseInfo(10, 19),//3 Nephi 4:75
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//3 Nephi 5
					new VerseInfo(11, 1),//3 Nephi 5:1
					new VerseInfo(11, 1),//3 Nephi 5:2
					new VerseInfo(11, 2),//3 Nephi 5:3
					new VerseInfo(11, 3),//3 Nephi 5:4
					new VerseInfo(11, 3),//3 Nephi 5:5
					new VerseInfo(11, 4, 11, 5),//3 Nephi 5:6
					new VerseInfo(11, 5, 11, 6),//3 Nephi 5:7
					new VerseInfo(11, 6, 11, 7),//3 Nephi 5:8
					new VerseInfo(11, 8),//3 Nephi 5:9
					new VerseInfo(11, 8),//3 Nephi 5:10
					new VerseInfo(11, 9, 11, 10),//3 Nephi 5:11
					new VerseInfo(11, 11),//3 Nephi 5:12
					new VerseInfo(11, 12),//3 Nephi 5:13
					new VerseInfo(11, 13, 11, 14),//3 Nephi 5:14
					new VerseInfo(11, 15),//3 Nephi 5:15
					new VerseInfo(11, 15),//3 Nephi 5:16
					new VerseInfo(11, 16, 11, 17),//3 Nephi 5:17
					new VerseInfo(11, 18),//3 Nephi 5:18
					new VerseInfo(11, 19),//3 Nephi 5:19
					new VerseInfo(11, 20),//3 Nephi 5:20
					new VerseInfo(11, 21),//3 Nephi 5:21
					new VerseInfo(11, 22),//3 Nephi 5:22
					new VerseInfo(11, 22),//3 Nephi 5:23
					new VerseInfo(11, 23),//3 Nephi 5:24
					new VerseInfo(11, 24, 11, 25),//3 Nephi 5:25
					new VerseInfo(11, 26),//3 Nephi 5:26
					new VerseInfo(11, 27),//3 Nephi 5:27
					new VerseInfo(11, 28),//3 Nephi 5:28
					new VerseInfo(11, 28),//3 Nephi 5:29
					new VerseInfo(11, 29),//3 Nephi 5:30
					new VerseInfo(11, 30),//3 Nephi 5:31
					new VerseInfo(11, 31, 11, 32),//3 Nephi 5:32
					new VerseInfo(11, 32),//3 Nephi 5:33
					new VerseInfo(11, 33),//3 Nephi 5:34
					new VerseInfo(11, 34),//3 Nephi 5:35
					new VerseInfo(11, 35),//3 Nephi 5:36
					new VerseInfo(11, 35),//3 Nephi 5:37
					new VerseInfo(11, 36),//3 Nephi 5:38
					new VerseInfo(11, 37),//3 Nephi 5:39
					new VerseInfo(11, 38),//3 Nephi 5:40
					new VerseInfo(11, 39),//3 Nephi 5:41
					new VerseInfo(11, 40),//3 Nephi 5:42
					new VerseInfo(11, 41),//3 Nephi 5:43
					new VerseInfo(12, 1),//3 Nephi 5:44
					new VerseInfo(12, 1),//3 Nephi 5:45
					new VerseInfo(12, 1),//3 Nephi 5:46
					new VerseInfo(12, 1),//3 Nephi 5:47
					new VerseInfo(12, 2),//3 Nephi 5:48
					new VerseInfo(12, 2),//3 Nephi 5:49
					new VerseInfo(12, 3),//3 Nephi 5:50
					new VerseInfo(12, 4),//3 Nephi 5:51
					new VerseInfo(12, 5),//3 Nephi 5:52
					new VerseInfo(12, 6),//3 Nephi 5:53
					new VerseInfo(12, 7),//3 Nephi 5:54
					new VerseInfo(12, 8),//3 Nephi 5:55
					new VerseInfo(12, 9),//3 Nephi 5:56
					new VerseInfo(12, 10),//3 Nephi 5:57
					new VerseInfo(12, 11),//3 Nephi 5:58
					new VerseInfo(12, 12),//3 Nephi 5:59
					new VerseInfo(12, 13),//3 Nephi 5:60
					new VerseInfo(12, 14),//3 Nephi 5:61
					new VerseInfo(12, 15),//3 Nephi 5:62
					new VerseInfo(12, 16),//3 Nephi 5:63
					new VerseInfo(12, 17),//3 Nephi 5:64
					new VerseInfo(12, 18),//3 Nephi 5:65
					new VerseInfo(12, 19),//3 Nephi 5:66
					new VerseInfo(12, 19, 12, 20),//3 Nephi 5:67
					new VerseInfo(12, 20),//3 Nephi 5:68
					new VerseInfo(12, 21),//3 Nephi 5:69
					new VerseInfo(12, 22),//3 Nephi 5:70
					new VerseInfo(12, 23),//3 Nephi 5:71
					new VerseInfo(12, 24),//3 Nephi 5:72
					new VerseInfo(12, 25),//3 Nephi 5:73
					new VerseInfo(12, 26),//3 Nephi 5:74
					new VerseInfo(12, 26),//3 Nephi 5:75
					new VerseInfo(12, 27),//3 Nephi 5:76
					new VerseInfo(12, 28),//3 Nephi 5:77
					new VerseInfo(12, 29, 12, 30),//3 Nephi 5:78
					new VerseInfo(12, 31),//3 Nephi 5:79
					new VerseInfo(12, 32),//3 Nephi 5:80
					new VerseInfo(12, 33),//3 Nephi 5:81
					new VerseInfo(12, 34, 12, 36),//3 Nephi 5:82
					new VerseInfo(12, 37),//3 Nephi 5:83
					new VerseInfo(12, 38),//3 Nephi 5:84
					new VerseInfo(12, 39),//3 Nephi 5:85
					new VerseInfo(12, 40),//3 Nephi 5:86
					new VerseInfo(12, 41),//3 Nephi 5:87
					new VerseInfo(12, 42),//3 Nephi 5:88
					new VerseInfo(12, 43),//3 Nephi 5:89
					new VerseInfo(12, 44),//3 Nephi 5:90
					new VerseInfo(12, 45, 12, 46),//3 Nephi 5:91
					new VerseInfo(12, 47, 12, 48),//3 Nephi 5:92
					new VerseInfo(13, 1),//3 Nephi 5:93
					new VerseInfo(13, 2),//3 Nephi 5:94
					new VerseInfo(13, 3),//3 Nephi 5:95
					new VerseInfo(13, 4),//3 Nephi 5:96
					new VerseInfo(13, 5),//3 Nephi 5:97
					new VerseInfo(13, 6),//3 Nephi 5:98
					new VerseInfo(13, 7),//3 Nephi 5:99
					new VerseInfo(13, 8),//3 Nephi 5:100
					new VerseInfo(13, 9),//3 Nephi 5:101
					new VerseInfo(13, 9),//3 Nephi 5:102
					new VerseInfo(13, 10),//3 Nephi 5:103
					new VerseInfo(13, 11),//3 Nephi 5:104
					new VerseInfo(13, 12),//3 Nephi 5:105
					new VerseInfo(13, 13),//3 Nephi 5:106
					new VerseInfo(13, 14, 13, 15),//3 Nephi 5:107
					new VerseInfo(13, 16),//3 Nephi 5:108
					new VerseInfo(13, 17, 13, 18),//3 Nephi 5:109
					new VerseInfo(13, 19),//3 Nephi 5:110
					new VerseInfo(13, 20),//3 Nephi 5:111
					new VerseInfo(13, 21),//3 Nephi 5:112
					new VerseInfo(13, 22),//3 Nephi 5:113
					new VerseInfo(13, 23),//3 Nephi 5:114
					new VerseInfo(13, 24),//3 Nephi 5:115
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//3 Nephi 6
					new VerseInfo(13, 25),//3 Nephi 6:1
					new VerseInfo(13, 25),//3 Nephi 6:2
					new VerseInfo(13, 25),//3 Nephi 6:3
					new VerseInfo(13, 26),//3 Nephi 6:4
					new VerseInfo(13, 27),//3 Nephi 6:5
					new VerseInfo(13, 28),//3 Nephi 6:6
					new VerseInfo(13, 29),//3 Nephi 6:7
					new VerseInfo(13, 30),//3 Nephi 6:8
					new VerseInfo(13, 31),//3 Nephi 6:9
					new VerseInfo(13, 32),//3 Nephi 6:10
					new VerseInfo(13, 33),//3 Nephi 6:11
					new VerseInfo(13, 34),//3 Nephi 6:12
					new VerseInfo(14, 1),//3 Nephi 6:13
					new VerseInfo(14, 2),//3 Nephi 6:14
					new VerseInfo(14, 3),//3 Nephi 6:15
					new VerseInfo(14, 4),//3 Nephi 6:16
					new VerseInfo(14, 5),//3 Nephi 6:17
					new VerseInfo(14, 6),//3 Nephi 6:18
					new VerseInfo(14, 7),//3 Nephi 6:19
					new VerseInfo(14, 8),//3 Nephi 6:20
					new VerseInfo(14, 9),//3 Nephi 6:21
					new VerseInfo(14, 10),//3 Nephi 6:22
					new VerseInfo(14, 11),//3 Nephi 6:23
					new VerseInfo(14, 12),//3 Nephi 6:24
					new VerseInfo(14, 13),//3 Nephi 6:25
					new VerseInfo(14, 14),//3 Nephi 6:26
					new VerseInfo(14, 15),//3 Nephi 6:27
					new VerseInfo(14, 16),//3 Nephi 6:28
					new VerseInfo(14, 17),//3 Nephi 6:29
					new VerseInfo(14, 18),//3 Nephi 6:30
					new VerseInfo(14, 19),//3 Nephi 6:31
					new VerseInfo(14, 20),//3 Nephi 6:32
					new VerseInfo(14, 21),//3 Nephi 6:33
					new VerseInfo(14, 22),//3 Nephi 6:34
					new VerseInfo(14, 23),//3 Nephi 6:35
					new VerseInfo(14, 24, 14, 25),//3 Nephi 6:36
					new VerseInfo(14, 26, 14, 27),//3 Nephi 6:37
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//3 Nephi 7
					new VerseInfo(15, 1),//3 Nephi 7:1
					new VerseInfo(15, 1),//3 Nephi 7:2
					new VerseInfo(15, 2),//3 Nephi 7:3
					new VerseInfo(15, 3),//3 Nephi 7:4
					new VerseInfo(15, 4),//3 Nephi 7:5
					new VerseInfo(15, 5),//3 Nephi 7:6
					new VerseInfo(15, 6),//3 Nephi 7:7
					new VerseInfo(15, 7),//3 Nephi 7:8
					new VerseInfo(15, 8),//3 Nephi 7:9
					new VerseInfo(15, 9),//3 Nephi 7:10
					new VerseInfo(15, 10),//3 Nephi 7:11
					new VerseInfo(15, 10),//3 Nephi 7:12
					new VerseInfo(15, 11, 15, 12),//3 Nephi 7:13
					new VerseInfo(15, 13),//3 Nephi 7:14
					new VerseInfo(15, 14, 15, 15),//3 Nephi 7:15
					new VerseInfo(15, 16, 15, 17),//3 Nephi 7:16
					new VerseInfo(15, 18),//3 Nephi 7:17
					new VerseInfo(15, 19),//3 Nephi 7:18
					new VerseInfo(15, 20),//3 Nephi 7:19
					new VerseInfo(15, 21),//3 Nephi 7:20
					new VerseInfo(15, 22),//3 Nephi 7:21
					new VerseInfo(15, 23),//3 Nephi 7:22
					new VerseInfo(15, 24),//3 Nephi 7:23
					new VerseInfo(16, 1),//3 Nephi 7:24
					new VerseInfo(16, 2),//3 Nephi 7:25
					new VerseInfo(16, 3),//3 Nephi 7:26
					new VerseInfo(16, 4),//3 Nephi 7:27
					new VerseInfo(16, 4),//3 Nephi 7:28
					new VerseInfo(16, 5),//3 Nephi 7:29
					new VerseInfo(16, 6),//3 Nephi 7:30
					new VerseInfo(16, 7),//3 Nephi 7:31
					new VerseInfo(16, 8),//3 Nephi 7:32
					new VerseInfo(16, 9),//3 Nephi 7:33
					new VerseInfo(16, 10),//3 Nephi 7:34
					new VerseInfo(16, 10),//3 Nephi 7:35
					new VerseInfo(16, 11),//3 Nephi 7:36
					new VerseInfo(16, 12),//3 Nephi 7:37
					new VerseInfo(16, 13),//3 Nephi 7:38
					new VerseInfo(16, 14),//3 Nephi 7:39
					new VerseInfo(16, 15),//3 Nephi 7:40
					new VerseInfo(16, 15),//3 Nephi 7:41
					new VerseInfo(16, 16),//3 Nephi 7:42
					new VerseInfo(16, 17, 16, 18),//3 Nephi 7:43
					new VerseInfo(16, 19),//3 Nephi 7:44
					new VerseInfo(16, 20),//3 Nephi 7:45
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//3 Nephi 8
					new VerseInfo(17, 1),//3 Nephi 8:1
					new VerseInfo(17, 2),//3 Nephi 8:2
					new VerseInfo(17, 3),//3 Nephi 8:3
					new VerseInfo(17, 4),//3 Nephi 8:4
					new VerseInfo(17, 5),//3 Nephi 8:5
					new VerseInfo(17, 6, 17, 7),//3 Nephi 8:6
					new VerseInfo(17, 7),//3 Nephi 8:7
					new VerseInfo(17, 7, 17, 8),//3 Nephi 8:8
					new VerseInfo(17, 9),//3 Nephi 8:9
					new VerseInfo(17, 10),//3 Nephi 8:10
					new VerseInfo(17, 10),//3 Nephi 8:11
					new VerseInfo(17, 11),//3 Nephi 8:12
					new VerseInfo(17, 12),//3 Nephi 8:13
					new VerseInfo(17, 13),//3 Nephi 8:14
					new VerseInfo(17, 14),//3 Nephi 8:15
					new VerseInfo(17, 15),//3 Nephi 8:16
					new VerseInfo(17, 16),//3 Nephi 8:17
					new VerseInfo(17, 17),//3 Nephi 8:18
					new VerseInfo(17, 17),//3 Nephi 8:19
					new VerseInfo(17, 18),//3 Nephi 8:20
					new VerseInfo(17, 19),//3 Nephi 8:21
					new VerseInfo(17, 20),//3 Nephi 8:22
					new VerseInfo(17, 21),//3 Nephi 8:23
					new VerseInfo(17, 22, 17, 23),//3 Nephi 8:24
					new VerseInfo(17, 24),//3 Nephi 8:25
					new VerseInfo(17, 24, 17, 25),//3 Nephi 8:26
					new VerseInfo(17, 25),//3 Nephi 8:27
					new VerseInfo(18, 1),//3 Nephi 8:28
					new VerseInfo(18, 2),//3 Nephi 8:29
					new VerseInfo(18, 3),//3 Nephi 8:30
					new VerseInfo(18, 4),//3 Nephi 8:31
					new VerseInfo(18, 5),//3 Nephi 8:32
					new VerseInfo(18, 6),//3 Nephi 8:33
					new VerseInfo(18, 7),//3 Nephi 8:34
					new VerseInfo(18, 7),//3 Nephi 8:35
					new VerseInfo(18, 7),//3 Nephi 8:36
					new VerseInfo(18, 8),//3 Nephi 8:37
					new VerseInfo(18, 9),//3 Nephi 8:38
					new VerseInfo(18, 10),//3 Nephi 8:39
					new VerseInfo(18, 11),//3 Nephi 8:40
					new VerseInfo(18, 11),//3 Nephi 8:41
					new VerseInfo(18, 12),//3 Nephi 8:42
					new VerseInfo(18, 12),//3 Nephi 8:43
					new VerseInfo(18, 13),//3 Nephi 8:44
					new VerseInfo(18, 13),//3 Nephi 8:45
					new VerseInfo(18, 14),//3 Nephi 8:46
					new VerseInfo(18, 15),//3 Nephi 8:47
					new VerseInfo(18, 16),//3 Nephi 8:48
					new VerseInfo(18, 16),//3 Nephi 8:49
					new VerseInfo(18, 17, 18, 18),//3 Nephi 8:50
					new VerseInfo(18, 18, 18, 20),//3 Nephi 8:51
					new VerseInfo(18, 21),//3 Nephi 8:52
					new VerseInfo(18, 22),//3 Nephi 8:53
					new VerseInfo(18, 23, 18, 24),//3 Nephi 8:54
					new VerseInfo(18, 24),//3 Nephi 8:55
					new VerseInfo(18, 24, 18, 25),//3 Nephi 8:56
					new VerseInfo(18, 25),//3 Nephi 8:57
					new VerseInfo(18, 26),//3 Nephi 8:58
					new VerseInfo(18, 27),//3 Nephi 8:59
					new VerseInfo(18, 28, 18, 29),//3 Nephi 8:60
					new VerseInfo(18, 29, 18, 30),//3 Nephi 8:61
					new VerseInfo(18, 30),//3 Nephi 8:62
					new VerseInfo(18, 31),//3 Nephi 8:63
					new VerseInfo(18, 32),//3 Nephi 8:64
					new VerseInfo(18, 32),//3 Nephi 8:65
					new VerseInfo(18, 33),//3 Nephi 8:66
					new VerseInfo(18, 34),//3 Nephi 8:67
					new VerseInfo(18, 34),//3 Nephi 8:68
					new VerseInfo(18, 35),//3 Nephi 8:69
					new VerseInfo(18, 36),//3 Nephi 8:70
					new VerseInfo(18, 37),//3 Nephi 8:71
					new VerseInfo(18, 37),//3 Nephi 8:72
					new VerseInfo(18, 38),//3 Nephi 8:73
					new VerseInfo(18, 39),//3 Nephi 8:74
					new VerseInfo(18, 39),//3 Nephi 8:75
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 0),//3 Nephi 9
					new VerseInfo(19, 1),//3 Nephi 9:1
					new VerseInfo(19, 2),//3 Nephi 9:2
					new VerseInfo(19, 3),//3 Nephi 9:3
					new VerseInfo(19, 4),//3 Nephi 9:4
					new VerseInfo(19, 4),//3 Nephi 9:5
					new VerseInfo(19, 5),//3 Nephi 9:6
					new VerseInfo(19, 6),//3 Nephi 9:7
					new VerseInfo(19, 7),//3 Nephi 9:8
					new VerseInfo(19, 7),//3 Nephi 9:9
					new VerseInfo(19, 8, 19, 9),//3 Nephi 9:10
					new VerseInfo(19, 10),//3 Nephi 9:11
					new VerseInfo(19, 11),//3 Nephi 9:12
					new VerseInfo(19, 12),//3 Nephi 9:13
					new VerseInfo(19, 13),//3 Nephi 9:14
					new VerseInfo(19, 14),//3 Nephi 9:15
					new VerseInfo(19, 15),//3 Nephi 9:16
					new VerseInfo(19, 16),//3 Nephi 9:17
					new VerseInfo(19, 17),//3 Nephi 9:18
					new VerseInfo(19, 18),//3 Nephi 9:19
					new VerseInfo(19, 19, 19, 20),//3 Nephi 9:20
					new VerseInfo(19, 21),//3 Nephi 9:21
					new VerseInfo(19, 22),//3 Nephi 9:22
					new VerseInfo(19, 23),//3 Nephi 9:23
					new VerseInfo(19, 24),//3 Nephi 9:24
					new VerseInfo(19, 25),//3 Nephi 9:25
					new VerseInfo(19, 25),//3 Nephi 9:26
					new VerseInfo(19, 26),//3 Nephi 9:27
					new VerseInfo(19, 27, 19, 28),//3 Nephi 9:28
					new VerseInfo(19, 28),//3 Nephi 9:29
					new VerseInfo(19, 29),//3 Nephi 9:30
					new VerseInfo(19, 30),//3 Nephi 9:31
					new VerseInfo(19, 31, 19, 32),//3 Nephi 9:32
					new VerseInfo(19, 33),//3 Nephi 9:33
					new VerseInfo(19, 34),//3 Nephi 9:34
					new VerseInfo(19, 35),//3 Nephi 9:35
					new VerseInfo(19, 36),//3 Nephi 9:36
					new VerseInfo(20, 1),//3 Nephi 9:37
					new VerseInfo(20, 1),//3 Nephi 9:38
					new VerseInfo(20, 2),//3 Nephi 9:39
					new VerseInfo(20, 3),//3 Nephi 9:40
					new VerseInfo(20, 4),//3 Nephi 9:41
					new VerseInfo(20, 5),//3 Nephi 9:42
					new VerseInfo(20, 6, 20, 7),//3 Nephi 9:43
					new VerseInfo(20, 8),//3 Nephi 9:44
					new VerseInfo(20, 9),//3 Nephi 9:45
					new VerseInfo(20, 10),//3 Nephi 9:46
					new VerseInfo(20, 11),//3 Nephi 9:47
					new VerseInfo(20, 12),//3 Nephi 9:48
					new VerseInfo(20, 12, 20, 13),//3 Nephi 9:49
					new VerseInfo(20, 14),//3 Nephi 9:50
					new VerseInfo(20, 15, 20, 16),//3 Nephi 9:51
					new VerseInfo(20, 16),//3 Nephi 9:52
					new VerseInfo(20, 17),//3 Nephi 9:53
					new VerseInfo(20, 18, 20, 19),//3 Nephi 9:54
					new VerseInfo(20, 19),//3 Nephi 9:55
					new VerseInfo(20, 20),//3 Nephi 9:56
					new VerseInfo(20, 21),//3 Nephi 9:57
					new VerseInfo(20, 22),//3 Nephi 9:58
					new VerseInfo(20, 22),//3 Nephi 9:59
					new VerseInfo(20, 23),//3 Nephi 9:60
					new VerseInfo(20, 23),//3 Nephi 9:61
					new VerseInfo(20, 24),//3 Nephi 9:62
					new VerseInfo(20, 25),//3 Nephi 9:63
					new VerseInfo(20, 26),//3 Nephi 9:64
					new VerseInfo(20, 27, 20, 28),//3 Nephi 9:65
					new VerseInfo(20, 28),//3 Nephi 9:66
					new VerseInfo(20, 29),//3 Nephi 9:67
					new VerseInfo(20, 29),//3 Nephi 9:68
					new VerseInfo(20, 30, 20, 31),//3 Nephi 9:69
					new VerseInfo(20, 32),//3 Nephi 9:70
					new VerseInfo(20, 33),//3 Nephi 9:71
					new VerseInfo(20, 34),//3 Nephi 9:72
					new VerseInfo(20, 35),//3 Nephi 9:73
					new VerseInfo(20, 36),//3 Nephi 9:74
					new VerseInfo(20, 37),//3 Nephi 9:75
					new VerseInfo(20, 38),//3 Nephi 9:76
					new VerseInfo(20, 39),//3 Nephi 9:77
					new VerseInfo(20, 40),//3 Nephi 9:78
					new VerseInfo(20, 41),//3 Nephi 9:79
					new VerseInfo(20, 42),//3 Nephi 9:80
					new VerseInfo(20, 43),//3 Nephi 9:81
					new VerseInfo(20, 44),//3 Nephi 9:82
					new VerseInfo(20, 45),//3 Nephi 9:83
					new VerseInfo(20, 46),//3 Nephi 9:84
					new VerseInfo(20, 46),//3 Nephi 9:85
					new VerseInfo(21, 1),//3 Nephi 9:86
					new VerseInfo(21, 2),//3 Nephi 9:87
					new VerseInfo(21, 2),//3 Nephi 9:88
					new VerseInfo(21, 3, 21, 4),//3 Nephi 9:89
					new VerseInfo(21, 4),//3 Nephi 9:90
					new VerseInfo(21, 5),//3 Nephi 9:91
					new VerseInfo(21, 6),//3 Nephi 9:92
					new VerseInfo(21, 7),//3 Nephi 9:93
					new VerseInfo(21, 8),//3 Nephi 9:94
					new VerseInfo(21, 9),//3 Nephi 9:95
					new VerseInfo(21, 10),//3 Nephi 9:96
					new VerseInfo(21, 10),//3 Nephi 9:97
					new VerseInfo(21, 11),//3 Nephi 9:98
					new VerseInfo(21, 12),//3 Nephi 9:99
					new VerseInfo(21, 13),//3 Nephi 9:100
					new VerseInfo(21, 14, 21, 15),//3 Nephi 9:101
					new VerseInfo(21, 16),//3 Nephi 9:102
					new VerseInfo(21, 17),//3 Nephi 9:103
					new VerseInfo(21, 18),//3 Nephi 9:104
					new VerseInfo(21, 19),//3 Nephi 9:105
					new VerseInfo(21, 20, 21, 21),//3 Nephi 9:106
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 10
					new VerseInfo(21, 22, 21, 23),//3 Nephi 10:1
					new VerseInfo(21, 23),//3 Nephi 10:2
					new VerseInfo(21, 24),//3 Nephi 10:3
					new VerseInfo(21, 25, 21, 26),//3 Nephi 10:4
					new VerseInfo(21, 26),//3 Nephi 10:5
					new VerseInfo(21, 27),//3 Nephi 10:6
					new VerseInfo(21, 28),//3 Nephi 10:7
					new VerseInfo(21, 29, 22, 1),//3 Nephi 10:8
					new VerseInfo(22, 1),//3 Nephi 10:9
					new VerseInfo(22, 2),//3 Nephi 10:10
					new VerseInfo(22, 3),//3 Nephi 10:11
					new VerseInfo(22, 4),//3 Nephi 10:12
					new VerseInfo(22, 5),//3 Nephi 10:13
					new VerseInfo(22, 6),//3 Nephi 10:14
					new VerseInfo(22, 7),//3 Nephi 10:15
					new VerseInfo(22, 8),//3 Nephi 10:16
					new VerseInfo(22, 9),//3 Nephi 10:17
					new VerseInfo(22, 10),//3 Nephi 10:18
					new VerseInfo(22, 11),//3 Nephi 10:19
					new VerseInfo(22, 12),//3 Nephi 10:20
					new VerseInfo(22, 13),//3 Nephi 10:21
					new VerseInfo(22, 14),//3 Nephi 10:22
					new VerseInfo(22, 15),//3 Nephi 10:23
					new VerseInfo(22, 16),//3 Nephi 10:24
					new VerseInfo(22, 17),//3 Nephi 10:25
					new VerseInfo(23, 1),//3 Nephi 10:26
					new VerseInfo(23, 1),//3 Nephi 10:27
					new VerseInfo(23, 2),//3 Nephi 10:28
					new VerseInfo(23, 3),//3 Nephi 10:29
					new VerseInfo(23, 4),//3 Nephi 10:30
					new VerseInfo(23, 5),//3 Nephi 10:31
					new VerseInfo(23, 5),//3 Nephi 10:32
					new VerseInfo(23, 6),//3 Nephi 10:33
					new VerseInfo(23, 7),//3 Nephi 10:34
					new VerseInfo(23, 8),//3 Nephi 10:35
					new VerseInfo(23, 9),//3 Nephi 10:36
					new VerseInfo(23, 9),//3 Nephi 10:37
					new VerseInfo(23, 10),//3 Nephi 10:38
					new VerseInfo(23, 11),//3 Nephi 10:39
					new VerseInfo(23, 12),//3 Nephi 10:40
					new VerseInfo(23, 13),//3 Nephi 10:41
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 11
					new VerseInfo(23, 14),//3 Nephi 11:1
					new VerseInfo(24, 1),//3 Nephi 11:2
					new VerseInfo(24, 1),//3 Nephi 11:3
					new VerseInfo(24, 1),//3 Nephi 11:4
					new VerseInfo(24, 2),//3 Nephi 11:5
					new VerseInfo(24, 3),//3 Nephi 11:6
					new VerseInfo(24, 4),//3 Nephi 11:7
					new VerseInfo(24, 5),//3 Nephi 11:8
					new VerseInfo(24, 6),//3 Nephi 11:9
					new VerseInfo(24, 7),//3 Nephi 11:10
					new VerseInfo(24, 8),//3 Nephi 11:11
					new VerseInfo(24, 9),//3 Nephi 11:12
					new VerseInfo(24, 10),//3 Nephi 11:13
					new VerseInfo(24, 11),//3 Nephi 11:14
					new VerseInfo(24, 12),//3 Nephi 11:15
					new VerseInfo(24, 13),//3 Nephi 11:16
					new VerseInfo(24, 14),//3 Nephi 11:17
					new VerseInfo(24, 15),//3 Nephi 11:18
					new VerseInfo(24, 16),//3 Nephi 11:19
					new VerseInfo(24, 17),//3 Nephi 11:20
					new VerseInfo(24, 18),//3 Nephi 11:21
					new VerseInfo(25, 1),//3 Nephi 11:22
					new VerseInfo(25, 2),//3 Nephi 11:23
					new VerseInfo(25, 3),//3 Nephi 11:24
					new VerseInfo(25, 4),//3 Nephi 11:25
					new VerseInfo(25, 5),//3 Nephi 11:26
					new VerseInfo(25, 6),//3 Nephi 11:27
					new VerseInfo(26, 1),//3 Nephi 11:28
					new VerseInfo(26, 2),//3 Nephi 11:29
					new VerseInfo(26, 3),//3 Nephi 11:30
					new VerseInfo(26, 3),//3 Nephi 11:31
					new VerseInfo(26, 4),//3 Nephi 11:32
					new VerseInfo(26, 5),//3 Nephi 11:33
				},
				new VerseInfo?[]
				{
					null,//3 Nephi 12
					new VerseInfo(26, 6, 26, 7),//3 Nephi 12:1
					new VerseInfo(26, 8),//3 Nephi 12:2
					new VerseInfo(26, 9),//3 Nephi 12:3
					new VerseInfo(26, 10),//3 Nephi 12:4
					new VerseInfo(26, 11, 26, 12),//3 Nephi 12:5
					new VerseInfo(26, 12, 26, 13),//3 Nephi 12:6
					new VerseInfo(26, 14),//3 Nephi 12:7
					new VerseInfo(26, 15),//3 Nephi 12:8
					new VerseInfo(26, 16),//3 Nephi 12:9
					new VerseInfo(26, 17),//3 Nephi 12:10
					new VerseInfo(26, 18, 26, 19),//3 Nephi 12:11
					new VerseInfo(26, 20),//3 Nephi 12:12
					new VerseInfo(26, 21),//3 Nephi 12:13
					new VerseInfo(27, 1),//3 Nephi 12:14
					new VerseInfo(27, 2),//3 Nephi 12:15
					new VerseInfo(27, 3),//3 Nephi 12:16
					new VerseInfo(27, 4),//3 Nephi 12:17
					new VerseInfo(27, 5, 27, 6),//3 Nephi 12:18
					new VerseInfo(27, 7, 27, 8),//3 Nephi 12:19
					new VerseInfo(27, 8),//3 Nephi 12:20
					new VerseInfo(27, 9),//3 Nephi 12:21
					new VerseInfo(27, 10),//3 Nephi 12:22
					new VerseInfo(27, 11),//3 Nephi 12:23
					new VerseInfo(27, 12),//3 Nephi 12:24
					new VerseInfo(27, 13),//3 Nephi 12:25
					new VerseInfo(27, 14),//3 Nephi 12:26
					new VerseInfo(27, 14),//3 Nephi 12:27
					new VerseInfo(27, 15),//3 Nephi 12:28
					new VerseInfo(27, 16),//3 Nephi 12:29
					new VerseInfo(27, 17, 27, 18),//3 Nephi 12:30
					new VerseInfo(27, 18, 27, 19),//3 Nephi 12:31
					new VerseInfo(27, 19),//3 Nephi 12:32
					new VerseInfo(27, 20),//3 Nephi 12:33
					new VerseInfo(27, 21),//3 Nephi 12:34
					new VerseInfo(27, 21, 27, 22),//3 Nephi 12:35
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 0, 0, 1),//3 Nephi 13
					new VerseInfo(27, 23, 27, 24),//3 Nephi 13:1
					new VerseInfo(27, 25),//3 Nephi 13:2
					new VerseInfo(27, 26),//3 Nephi 13:3
					new VerseInfo(27, 27),//3 Nephi 13:4
					new VerseInfo(27, 27, 27, 28),//3 Nephi 13:5
					new VerseInfo(27, 28, 27, 29),//3 Nephi 13:6
					new VerseInfo(27, 30),//3 Nephi 13:7
					new VerseInfo(27, 31),//3 Nephi 13:8
					new VerseInfo(27, 32),//3 Nephi 13:9
					new VerseInfo(27, 32),//3 Nephi 13:10
					new VerseInfo(27, 33),//3 Nephi 13:11
					new VerseInfo(28, 1),//3 Nephi 13:12
					new VerseInfo(28, 2),//3 Nephi 13:13
					new VerseInfo(28, 3),//3 Nephi 13:14
					new VerseInfo(28, 4),//3 Nephi 13:15
					new VerseInfo(28, 5),//3 Nephi 13:16
					new VerseInfo(28, 6),//3 Nephi 13:17
					new VerseInfo(28, 7),//3 Nephi 13:18
					new VerseInfo(28, 8),//3 Nephi 13:19
					new VerseInfo(28, 9),//3 Nephi 13:20
					new VerseInfo(28, 9, 28, 10),//3 Nephi 13:21
					new VerseInfo(28, 10),//3 Nephi 13:22
					new VerseInfo(28, 11),//3 Nephi 13:23
					new VerseInfo(28, 12),//3 Nephi 13:24
					new VerseInfo(28, 13),//3 Nephi 13:25
					new VerseInfo(28, 14),//3 Nephi 13:26
					new VerseInfo(28, 15),//3 Nephi 13:27
					new VerseInfo(28, 16),//3 Nephi 13:28
					new VerseInfo(28, 17, 28, 18),//3 Nephi 13:29
					new VerseInfo(28, 18, 28, 19),//3 Nephi 13:30
					new VerseInfo(28, 19, 28, 20),//3 Nephi 13:31
					new VerseInfo(28, 20),//3 Nephi 13:32
					new VerseInfo(28, 21),//3 Nephi 13:33
					new VerseInfo(28, 22),//3 Nephi 13:34
					new VerseInfo(28, 23),//3 Nephi 13:35
					new VerseInfo(28, 23),//3 Nephi 13:36
					new VerseInfo(28, 24),//3 Nephi 13:37
					new VerseInfo(28, 25),//3 Nephi 13:38
					new VerseInfo(28, 26, 28, 27),//3 Nephi 13:39
					new VerseInfo(28, 28),//3 Nephi 13:40
					new VerseInfo(28, 29),//3 Nephi 13:41
					new VerseInfo(28, 30),//3 Nephi 13:42
					new VerseInfo(28, 31),//3 Nephi 13:43
					new VerseInfo(28, 32),//3 Nephi 13:44
					new VerseInfo(28, 33),//3 Nephi 13:45
					new VerseInfo(28, 34),//3 Nephi 13:46
					new VerseInfo(28, 34, 28, 35),//3 Nephi 13:47
					new VerseInfo(28, 35),//3 Nephi 13:48
					new VerseInfo(28, 36),//3 Nephi 13:49
					new VerseInfo(28, 37),//3 Nephi 13:50
					new VerseInfo(28, 38),//3 Nephi 13:51
					new VerseInfo(28, 39),//3 Nephi 13:52
					new VerseInfo(28, 40),//3 Nephi 13:53
					new VerseInfo(29, 1),//3 Nephi 13:54
					new VerseInfo(29, 2),//3 Nephi 13:55
					new VerseInfo(29, 3),//3 Nephi 13:56
					new VerseInfo(29, 4),//3 Nephi 13:57
					new VerseInfo(29, 5),//3 Nephi 13:58
					new VerseInfo(29, 6),//3 Nephi 13:59
					new VerseInfo(29, 7),//3 Nephi 13:60
					new VerseInfo(29, 8),//3 Nephi 13:61
					new VerseInfo(29, 9),//3 Nephi 13:62
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//3 Nephi 14
					new VerseInfo(30, 1),//3 Nephi 14:1
					new VerseInfo(30, 2),//3 Nephi 14:2
					new VerseInfo(30, 2),//3 Nephi 14:3
				},
			}
		},
		{ "4 Nephi", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//4 Nephi 1
					new VerseInfo(1, 1),//4 Nephi 1:1
					new VerseInfo(1, 1),//4 Nephi 1:2
					new VerseInfo(1, 2),//4 Nephi 1:3
					new VerseInfo(1, 3),//4 Nephi 1:4
					new VerseInfo(1, 4),//4 Nephi 1:5
					new VerseInfo(1, 5),//4 Nephi 1:6
					new VerseInfo(1, 5),//4 Nephi 1:7
					new VerseInfo(1, 6),//4 Nephi 1:8
					new VerseInfo(1, 7, 1, 8),//4 Nephi 1:9
					new VerseInfo(1, 9),//4 Nephi 1:10
					new VerseInfo(1, 10),//4 Nephi 1:11
					new VerseInfo(1, 11),//4 Nephi 1:12
					new VerseInfo(1, 12),//4 Nephi 1:13
					new VerseInfo(1, 13),//4 Nephi 1:14
					new VerseInfo(1, 14),//4 Nephi 1:15
					new VerseInfo(1, 14),//4 Nephi 1:16
					new VerseInfo(1, 15),//4 Nephi 1:17
					new VerseInfo(1, 16),//4 Nephi 1:18
					new VerseInfo(1, 16),//4 Nephi 1:19
					new VerseInfo(1, 17),//4 Nephi 1:20
					new VerseInfo(1, 18),//4 Nephi 1:21
					new VerseInfo(1, 19),//4 Nephi 1:22
					new VerseInfo(1, 20),//4 Nephi 1:23
					new VerseInfo(1, 21),//4 Nephi 1:24
					new VerseInfo(1, 22),//4 Nephi 1:25
					new VerseInfo(1, 23),//4 Nephi 1:26
					new VerseInfo(1, 24),//4 Nephi 1:27
					new VerseInfo(1, 25, 1, 26),//4 Nephi 1:28
					new VerseInfo(1, 27),//4 Nephi 1:29
					new VerseInfo(1, 28),//4 Nephi 1:30
					new VerseInfo(1, 29),//4 Nephi 1:31
					new VerseInfo(1, 30),//4 Nephi 1:32
					new VerseInfo(1, 30),//4 Nephi 1:33
					new VerseInfo(1, 31),//4 Nephi 1:34
					new VerseInfo(1, 32, 1, 33),//4 Nephi 1:35
					new VerseInfo(1, 34),//4 Nephi 1:36
					new VerseInfo(1, 34),//4 Nephi 1:37
					new VerseInfo(1, 34),//4 Nephi 1:38
					new VerseInfo(1, 35),//4 Nephi 1:39
					new VerseInfo(1, 36),//4 Nephi 1:40
					new VerseInfo(1, 37),//4 Nephi 1:41
					new VerseInfo(1, 38),//4 Nephi 1:42
					new VerseInfo(1, 38),//4 Nephi 1:43
					new VerseInfo(1, 39),//4 Nephi 1:44
					new VerseInfo(1, 39),//4 Nephi 1:45
					new VerseInfo(1, 40),//4 Nephi 1:46
					new VerseInfo(1, 40),//4 Nephi 1:47
					new VerseInfo(1, 41),//4 Nephi 1:48
					new VerseInfo(1, 41),//4 Nephi 1:49
					new VerseInfo(1, 42),//4 Nephi 1:50
					new VerseInfo(1, 43),//4 Nephi 1:51
					new VerseInfo(1, 44),//4 Nephi 1:52
					new VerseInfo(1, 45),//4 Nephi 1:53
					new VerseInfo(1, 46),//4 Nephi 1:54
					new VerseInfo(1, 46),//4 Nephi 1:55
					new VerseInfo(1, 47),//4 Nephi 1:56
					new VerseInfo(1, 48),//4 Nephi 1:57
					new VerseInfo(1, 48),//4 Nephi 1:58
					new VerseInfo(1, 49),//4 Nephi 1:59
				},
			}
		},
		{ "Mormon", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mormon 1
					new VerseInfo(1, 1),//Mormon 1:1
					new VerseInfo(1, 2),//Mormon 1:2
					new VerseInfo(1, 3),//Mormon 1:3
					new VerseInfo(1, 3),//Mormon 1:4
					new VerseInfo(1, 4),//Mormon 1:5
					new VerseInfo(1, 5),//Mormon 1:6
					new VerseInfo(1, 6, 1, 7),//Mormon 1:7
					new VerseInfo(1, 8),//Mormon 1:8
					new VerseInfo(1, 9),//Mormon 1:9
					new VerseInfo(1, 10),//Mormon 1:10
					new VerseInfo(1, 11),//Mormon 1:11
					new VerseInfo(1, 11),//Mormon 1:12
					new VerseInfo(1, 12),//Mormon 1:13
					new VerseInfo(1, 13),//Mormon 1:14
					new VerseInfo(1, 14),//Mormon 1:15
					new VerseInfo(1, 15),//Mormon 1:16
					new VerseInfo(1, 16),//Mormon 1:17
					new VerseInfo(1, 17),//Mormon 1:18
					new VerseInfo(1, 18),//Mormon 1:19
					new VerseInfo(1, 19),//Mormon 1:20
					new VerseInfo(2, 1),//Mormon 1:21
					new VerseInfo(2, 1),//Mormon 1:22
					new VerseInfo(2, 2),//Mormon 1:23
					new VerseInfo(2, 3),//Mormon 1:24
					new VerseInfo(2, 4),//Mormon 1:25
					new VerseInfo(2, 4),//Mormon 1:26
					new VerseInfo(2, 5, 2, 6),//Mormon 1:27
					new VerseInfo(2, 7),//Mormon 1:28
					new VerseInfo(2, 8),//Mormon 1:29
					new VerseInfo(2, 8),//Mormon 1:30
					new VerseInfo(2, 9),//Mormon 1:31
					new VerseInfo(2, 9),//Mormon 1:32
					new VerseInfo(2, 9),//Mormon 1:33
					new VerseInfo(2, 10),//Mormon 1:34
					new VerseInfo(2, 11),//Mormon 1:35
					new VerseInfo(2, 12),//Mormon 1:36
					new VerseInfo(2, 13),//Mormon 1:37
					new VerseInfo(2, 14),//Mormon 1:38
					new VerseInfo(2, 14),//Mormon 1:39
					new VerseInfo(2, 15),//Mormon 1:40
					new VerseInfo(2, 15),//Mormon 1:41
					new VerseInfo(2, 16),//Mormon 1:42
					new VerseInfo(2, 17),//Mormon 1:43
					new VerseInfo(2, 17),//Mormon 1:44
					new VerseInfo(2, 18),//Mormon 1:45
					new VerseInfo(2, 19),//Mormon 1:46
					new VerseInfo(2, 20),//Mormon 1:47
					new VerseInfo(2, 20),//Mormon 1:48
					new VerseInfo(2, 21),//Mormon 1:49
					new VerseInfo(2, 22),//Mormon 1:50
					new VerseInfo(2, 23),//Mormon 1:51
					new VerseInfo(2, 24),//Mormon 1:52
					new VerseInfo(2, 25),//Mormon 1:53
					new VerseInfo(2, 25),//Mormon 1:54
					new VerseInfo(2, 26),//Mormon 1:55
					new VerseInfo(2, 26),//Mormon 1:56
					new VerseInfo(2, 27),//Mormon 1:57
					new VerseInfo(2, 27),//Mormon 1:58
					new VerseInfo(2, 28),//Mormon 1:59
					new VerseInfo(2, 28),//Mormon 1:60
					new VerseInfo(2, 29),//Mormon 1:61
					new VerseInfo(2, 29),//Mormon 1:62
					new VerseInfo(3, 1),//Mormon 1:63
					new VerseInfo(3, 1),//Mormon 1:64
					new VerseInfo(3, 2),//Mormon 1:65
					new VerseInfo(3, 3),//Mormon 1:66
					new VerseInfo(3, 3),//Mormon 1:67
					new VerseInfo(3, 4),//Mormon 1:68
					new VerseInfo(3, 5),//Mormon 1:69
					new VerseInfo(3, 6),//Mormon 1:70
					new VerseInfo(3, 7),//Mormon 1:71
					new VerseInfo(3, 8),//Mormon 1:72
					new VerseInfo(3, 8),//Mormon 1:73
					new VerseInfo(3, 9),//Mormon 1:74
					new VerseInfo(3, 10),//Mormon 1:75
					new VerseInfo(3, 11),//Mormon 1:76
					new VerseInfo(3, 12),//Mormon 1:77
					new VerseInfo(3, 12),//Mormon 1:78
					new VerseInfo(3, 13),//Mormon 1:79
					new VerseInfo(3, 14, 3, 15),//Mormon 1:80
					new VerseInfo(3, 16),//Mormon 1:81
					new VerseInfo(3, 17),//Mormon 1:82
					new VerseInfo(3, 18),//Mormon 1:83
					new VerseInfo(3, 19),//Mormon 1:84
					new VerseInfo(3, 20),//Mormon 1:85
					new VerseInfo(3, 20),//Mormon 1:86
					new VerseInfo(3, 20, 3, 21),//Mormon 1:87
					new VerseInfo(3, 21),//Mormon 1:88
					new VerseInfo(3, 22),//Mormon 1:89
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mormon 2
					new VerseInfo(4, 1),//Mormon 2:1
					new VerseInfo(4, 2),//Mormon 2:2
					new VerseInfo(4, 2, 4, 3),//Mormon 2:3
					new VerseInfo(4, 3),//Mormon 2:4
					new VerseInfo(4, 4),//Mormon 2:5
					new VerseInfo(4, 5),//Mormon 2:6
					new VerseInfo(4, 6),//Mormon 2:7
					new VerseInfo(4, 7),//Mormon 2:8
					new VerseInfo(4, 8),//Mormon 2:9
					new VerseInfo(4, 8),//Mormon 2:10
					new VerseInfo(4, 9),//Mormon 2:11
					new VerseInfo(4, 10),//Mormon 2:12
					new VerseInfo(4, 11),//Mormon 2:13
					new VerseInfo(4, 12),//Mormon 2:14
					new VerseInfo(4, 13),//Mormon 2:15
					new VerseInfo(4, 14),//Mormon 2:16
					new VerseInfo(4, 15),//Mormon 2:17
					new VerseInfo(4, 16),//Mormon 2:18
					new VerseInfo(4, 17),//Mormon 2:19
					new VerseInfo(4, 18),//Mormon 2:20
					new VerseInfo(4, 19),//Mormon 2:21
					new VerseInfo(4, 20),//Mormon 2:22
					new VerseInfo(4, 21),//Mormon 2:23
					new VerseInfo(4, 22),//Mormon 2:24
					new VerseInfo(4, 23),//Mormon 2:25
					new VerseInfo(5, 1),//Mormon 2:26
					new VerseInfo(5, 2),//Mormon 2:27
					new VerseInfo(5, 3),//Mormon 2:28
					new VerseInfo(5, 4),//Mormon 2:29
					new VerseInfo(5, 4),//Mormon 2:30
					new VerseInfo(5, 5),//Mormon 2:31
					new VerseInfo(5, 6),//Mormon 2:32
					new VerseInfo(5, 7),//Mormon 2:33
					new VerseInfo(5, 8),//Mormon 2:34
					new VerseInfo(5, 8, 5, 9),//Mormon 2:35
					new VerseInfo(5, 9),//Mormon 2:36
					new VerseInfo(5, 10),//Mormon 2:37
					new VerseInfo(5, 11),//Mormon 2:38
					new VerseInfo(5, 12),//Mormon 2:39
					new VerseInfo(5, 13),//Mormon 2:40
					new VerseInfo(5, 14),//Mormon 2:41
					new VerseInfo(5, 14),//Mormon 2:42
					new VerseInfo(5, 15),//Mormon 2:43
					new VerseInfo(5, 15),//Mormon 2:44
					new VerseInfo(5, 16),//Mormon 2:45
					new VerseInfo(5, 17),//Mormon 2:46
					new VerseInfo(5, 18),//Mormon 2:47
					new VerseInfo(5, 19),//Mormon 2:48
					new VerseInfo(5, 20),//Mormon 2:49
					new VerseInfo(5, 21),//Mormon 2:50
					new VerseInfo(5, 22),//Mormon 2:51
					new VerseInfo(5, 23),//Mormon 2:52
					new VerseInfo(5, 23),//Mormon 2:53
					new VerseInfo(5, 24),//Mormon 2:54
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mormon 3
					new VerseInfo(6, 1),//Mormon 3:1
					new VerseInfo(6, 1),//Mormon 3:2
					new VerseInfo(6, 2),//Mormon 3:3
					new VerseInfo(6, 3),//Mormon 3:4
					new VerseInfo(6, 4),//Mormon 3:5
					new VerseInfo(6, 5),//Mormon 3:6
					new VerseInfo(6, 6),//Mormon 3:7
					new VerseInfo(6, 6),//Mormon 3:8
					new VerseInfo(6, 7),//Mormon 3:9
					new VerseInfo(6, 8),//Mormon 3:10
					new VerseInfo(6, 9),//Mormon 3:11
					new VerseInfo(6, 10),//Mormon 3:12
					new VerseInfo(6, 11),//Mormon 3:13
					new VerseInfo(6, 11, 6, 12),//Mormon 3:14
					new VerseInfo(6, 13, 6, 14),//Mormon 3:15
					new VerseInfo(6, 15),//Mormon 3:16
					new VerseInfo(6, 15),//Mormon 3:17
					new VerseInfo(6, 16, 6, 17),//Mormon 3:18
					new VerseInfo(6, 18),//Mormon 3:19
					new VerseInfo(6, 19),//Mormon 3:20
					new VerseInfo(6, 20, 6, 21),//Mormon 3:21
					new VerseInfo(6, 21),//Mormon 3:22
					new VerseInfo(6, 22),//Mormon 3:23
					new VerseInfo(7, 1, 7, 2),//Mormon 3:24
					new VerseInfo(7, 3),//Mormon 3:25
					new VerseInfo(7, 4),//Mormon 3:26
					new VerseInfo(7, 5),//Mormon 3:27
					new VerseInfo(7, 6),//Mormon 3:28
					new VerseInfo(7, 7),//Mormon 3:29
					new VerseInfo(7, 8),//Mormon 3:30
					new VerseInfo(7, 9),//Mormon 3:31
					new VerseInfo(7, 10),//Mormon 3:32
					new VerseInfo(7, 10),//Mormon 3:33
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Mormon 4
					new VerseInfo(8, 1),//Mormon 4:1
					new VerseInfo(8, 2, 8, 3),//Mormon 4:2
					new VerseInfo(8, 3),//Mormon 4:3
					new VerseInfo(8, 3, 8, 4),//Mormon 4:4
					new VerseInfo(8, 5),//Mormon 4:5
					new VerseInfo(8, 5),//Mormon 4:6
					new VerseInfo(8, 6),//Mormon 4:7
					new VerseInfo(8, 7),//Mormon 4:8
					new VerseInfo(8, 8),//Mormon 4:9
					new VerseInfo(8, 8),//Mormon 4:10
					new VerseInfo(8, 9),//Mormon 4:11
					new VerseInfo(8, 10),//Mormon 4:12
					new VerseInfo(8, 11),//Mormon 4:13
					new VerseInfo(8, 12),//Mormon 4:14
					new VerseInfo(8, 12),//Mormon 4:15
					new VerseInfo(8, 13),//Mormon 4:16
					new VerseInfo(8, 13, 8, 14),//Mormon 4:17
					new VerseInfo(8, 14),//Mormon 4:18
					new VerseInfo(8, 15),//Mormon 4:19
					new VerseInfo(8, 16),//Mormon 4:20
					new VerseInfo(8, 16, 8, 17),//Mormon 4:21
					new VerseInfo(8, 17),//Mormon 4:22
					new VerseInfo(8, 18),//Mormon 4:23
					new VerseInfo(8, 19),//Mormon 4:24
					new VerseInfo(8, 20),//Mormon 4:25
					new VerseInfo(8, 21, 8, 22),//Mormon 4:26
					new VerseInfo(8, 23),//Mormon 4:27
					new VerseInfo(8, 23),//Mormon 4:28
					new VerseInfo(8, 24),//Mormon 4:29
					new VerseInfo(8, 24),//Mormon 4:30
					new VerseInfo(8, 24),//Mormon 4:31
					new VerseInfo(8, 25),//Mormon 4:32
					new VerseInfo(8, 26),//Mormon 4:33
					new VerseInfo(8, 26),//Mormon 4:34
					new VerseInfo(8, 27),//Mormon 4:35
					new VerseInfo(8, 28),//Mormon 4:36
					new VerseInfo(8, 29, 8, 30),//Mormon 4:37
					new VerseInfo(8, 31),//Mormon 4:38
					new VerseInfo(8, 31),//Mormon 4:39
					new VerseInfo(8, 31),//Mormon 4:40
					new VerseInfo(8, 32),//Mormon 4:41
					new VerseInfo(8, 33),//Mormon 4:42
					new VerseInfo(8, 33),//Mormon 4:43
					new VerseInfo(8, 33),//Mormon 4:44
					new VerseInfo(8, 34),//Mormon 4:45
					new VerseInfo(8, 35),//Mormon 4:46
					new VerseInfo(8, 35, 8, 36),//Mormon 4:47
					new VerseInfo(8, 36),//Mormon 4:48
					new VerseInfo(8, 36),//Mormon 4:49
					new VerseInfo(8, 37),//Mormon 4:50
					new VerseInfo(8, 38),//Mormon 4:51
					new VerseInfo(8, 38),//Mormon 4:52
					new VerseInfo(8, 38),//Mormon 4:53
					new VerseInfo(8, 39),//Mormon 4:54
					new VerseInfo(8, 40),//Mormon 4:55
					new VerseInfo(8, 41),//Mormon 4:56
					new VerseInfo(9, 1),//Mormon 4:57
					new VerseInfo(9, 2),//Mormon 4:58
					new VerseInfo(9, 2),//Mormon 4:59
					new VerseInfo(9, 3),//Mormon 4:60
					new VerseInfo(9, 3),//Mormon 4:61
					new VerseInfo(9, 3),//Mormon 4:62
					new VerseInfo(9, 4),//Mormon 4:63
					new VerseInfo(9, 5),//Mormon 4:64
					new VerseInfo(9, 6),//Mormon 4:65
					new VerseInfo(9, 7),//Mormon 4:66
					new VerseInfo(9, 8),//Mormon 4:67
					new VerseInfo(9, 9),//Mormon 4:68
					new VerseInfo(9, 10),//Mormon 4:69
					new VerseInfo(9, 11),//Mormon 4:70
					new VerseInfo(9, 12),//Mormon 4:71
					new VerseInfo(9, 13),//Mormon 4:72
					new VerseInfo(9, 13),//Mormon 4:73
					new VerseInfo(9, 14),//Mormon 4:74
					new VerseInfo(9, 15),//Mormon 4:75
					new VerseInfo(9, 15),//Mormon 4:76
					new VerseInfo(9, 16),//Mormon 4:77
					new VerseInfo(9, 17),//Mormon 4:78
					new VerseInfo(9, 18),//Mormon 4:79
					new VerseInfo(9, 18),//Mormon 4:80
					new VerseInfo(9, 19),//Mormon 4:81
					new VerseInfo(9, 19),//Mormon 4:82
					new VerseInfo(9, 20),//Mormon 4:83
					new VerseInfo(9, 21),//Mormon 4:84
					new VerseInfo(9, 22),//Mormon 4:85
					new VerseInfo(9, 22, 9, 23),//Mormon 4:86
					new VerseInfo(9, 24),//Mormon 4:87
					new VerseInfo(9, 25),//Mormon 4:88
					new VerseInfo(9, 26),//Mormon 4:89
					new VerseInfo(9, 26),//Mormon 4:90
					new VerseInfo(9, 26),//Mormon 4:91
					new VerseInfo(9, 27),//Mormon 4:92
					new VerseInfo(9, 27),//Mormon 4:93
					new VerseInfo(9, 28),//Mormon 4:94
					new VerseInfo(9, 29),//Mormon 4:95
					new VerseInfo(9, 30),//Mormon 4:96
					new VerseInfo(9, 31),//Mormon 4:97
					new VerseInfo(9, 32),//Mormon 4:98
					new VerseInfo(9, 33),//Mormon 4:99
					new VerseInfo(9, 34),//Mormon 4:100
					new VerseInfo(9, 35),//Mormon 4:101
					new VerseInfo(9, 36),//Mormon 4:102
					new VerseInfo(9, 37),//Mormon 4:103
				},
			}
		},
		{ "Ether", new VerseInfo?[]?[]
			{
				null,
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Ether 1
					new VerseInfo(1, 1),//Ether 1:1
					new VerseInfo(1, 2),//Ether 1:2
					new VerseInfo(1, 3),//Ether 1:3
					new VerseInfo(1, 4),//Ether 1:4
					new VerseInfo(1, 5, 1, 6),//Ether 1:5
					new VerseInfo(1, 6, 1, 32),//Ether 1:6
					new VerseInfo(1, 33),//Ether 1:7
					new VerseInfo(1, 34),//Ether 1:8
					new VerseInfo(1, 35),//Ether 1:9
					new VerseInfo(1, 36),//Ether 1:10
					new VerseInfo(1, 37),//Ether 1:11
					new VerseInfo(1, 38),//Ether 1:12
					new VerseInfo(1, 38),//Ether 1:13
					new VerseInfo(1, 38),//Ether 1:14
					new VerseInfo(1, 39),//Ether 1:15
					new VerseInfo(1, 40, 1, 41),//Ether 1:16
					new VerseInfo(1, 42),//Ether 1:17
					new VerseInfo(1, 42),//Ether 1:18
					new VerseInfo(1, 43),//Ether 1:19
					new VerseInfo(1, 43),//Ether 1:20
					new VerseInfo(1, 43),//Ether 1:21
					new VerseInfo(2, 1),//Ether 1:22
					new VerseInfo(2, 2),//Ether 1:23
					new VerseInfo(2, 3),//Ether 1:24
					new VerseInfo(2, 4),//Ether 1:25
					new VerseInfo(2, 5),//Ether 1:26
					new VerseInfo(2, 5),//Ether 1:27
					new VerseInfo(2, 6),//Ether 1:28
					new VerseInfo(2, 7),//Ether 1:29
					new VerseInfo(2, 8),//Ether 1:30
					new VerseInfo(2, 9),//Ether 1:31
					new VerseInfo(2, 9, 2, 10),//Ether 1:32
					new VerseInfo(2, 10),//Ether 1:33
					new VerseInfo(2, 11),//Ether 1:34
					new VerseInfo(2, 12),//Ether 1:35
					new VerseInfo(2, 13),//Ether 1:36
					new VerseInfo(2, 13),//Ether 1:37
					new VerseInfo(2, 14),//Ether 1:38
					new VerseInfo(2, 14),//Ether 1:39
					new VerseInfo(2, 15),//Ether 1:40
					new VerseInfo(2, 15),//Ether 1:41
					new VerseInfo(2, 15),//Ether 1:42
					new VerseInfo(2, 16),//Ether 1:43
					new VerseInfo(2, 16),//Ether 1:44
					new VerseInfo(2, 16, 2, 17),//Ether 1:45
					new VerseInfo(2, 17),//Ether 1:46
					new VerseInfo(2, 18),//Ether 1:47
					new VerseInfo(2, 19),//Ether 1:48
					new VerseInfo(2, 19),//Ether 1:49
					new VerseInfo(2, 20),//Ether 1:50
					new VerseInfo(2, 20),//Ether 1:51
					new VerseInfo(2, 21),//Ether 1:52
					new VerseInfo(2, 22),//Ether 1:53
					new VerseInfo(2, 22),//Ether 1:54
					new VerseInfo(2, 23),//Ether 1:55
					new VerseInfo(2, 23, 2, 24),//Ether 1:56
					new VerseInfo(2, 24),//Ether 1:57
					new VerseInfo(2, 25),//Ether 1:58
					new VerseInfo(2, 25),//Ether 1:59
					new VerseInfo(3, 1),//Ether 1:60
					new VerseInfo(3, 1, 3, 2),//Ether 1:61
					new VerseInfo(3, 2),//Ether 1:62
					new VerseInfo(3, 2),//Ether 1:63
					new VerseInfo(3, 3),//Ether 1:64
					new VerseInfo(3, 3),//Ether 1:65
					new VerseInfo(3, 4),//Ether 1:66
					new VerseInfo(3, 5),//Ether 1:67
					new VerseInfo(3, 6),//Ether 1:68
					new VerseInfo(3, 6),//Ether 1:69
					new VerseInfo(3, 7),//Ether 1:70
					new VerseInfo(3, 8),//Ether 1:71
					new VerseInfo(3, 9),//Ether 1:72
					new VerseInfo(3, 10),//Ether 1:73
					new VerseInfo(3, 11),//Ether 1:74
					new VerseInfo(3, 12),//Ether 1:75
					new VerseInfo(3, 13),//Ether 1:76
					new VerseInfo(3, 14),//Ether 1:77
					new VerseInfo(3, 14),//Ether 1:78
					new VerseInfo(3, 15),//Ether 1:79
					new VerseInfo(3, 15),//Ether 1:80
					new VerseInfo(3, 16),//Ether 1:81
					new VerseInfo(3, 17),//Ether 1:82
					new VerseInfo(3, 18),//Ether 1:83
					new VerseInfo(3, 19),//Ether 1:84
					new VerseInfo(3, 19, 3, 20),//Ether 1:85
					new VerseInfo(3, 21),//Ether 1:86
					new VerseInfo(3, 22),//Ether 1:87
					new VerseInfo(3, 23),//Ether 1:88
					new VerseInfo(3, 24),//Ether 1:89
					new VerseInfo(3, 25),//Ether 1:90
					new VerseInfo(3, 26),//Ether 1:91
					new VerseInfo(3, 27),//Ether 1:92
					new VerseInfo(3, 28),//Ether 1:93
					new VerseInfo(4, 1),//Ether 1:94
					new VerseInfo(4, 1),//Ether 1:95
					new VerseInfo(4, 2),//Ether 1:96
					new VerseInfo(4, 3),//Ether 1:97
					new VerseInfo(4, 4, 4, 5),//Ether 1:98
					new VerseInfo(4, 5),//Ether 1:99
					new VerseInfo(4, 6),//Ether 1:100
					new VerseInfo(4, 7),//Ether 1:101
					new VerseInfo(4, 8),//Ether 1:102
					new VerseInfo(4, 9),//Ether 1:103
					new VerseInfo(4, 10),//Ether 1:104
					new VerseInfo(4, 11),//Ether 1:105
					new VerseInfo(4, 11, 4, 12),//Ether 1:106
					new VerseInfo(4, 12),//Ether 1:107
					new VerseInfo(4, 12),//Ether 1:108
					new VerseInfo(4, 13),//Ether 1:109
					new VerseInfo(4, 14),//Ether 1:110
					new VerseInfo(4, 15),//Ether 1:111
					new VerseInfo(4, 15),//Ether 1:112
					new VerseInfo(4, 16),//Ether 1:113
					new VerseInfo(4, 16, 4, 17),//Ether 1:114
					new VerseInfo(4, 18),//Ether 1:115
					new VerseInfo(4, 19),//Ether 1:116
					new VerseInfo(4, 19),//Ether 1:117
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Ether 2
					new VerseInfo(5, 1),//Ether 2:1
					new VerseInfo(5, 2, 5, 3),//Ether 2:2
					new VerseInfo(5, 4),//Ether 2:3
					new VerseInfo(5, 5),//Ether 2:4
					new VerseInfo(5, 6),//Ether 2:5
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Ether 3
					new VerseInfo(6, 1),//Ether 3:1
					new VerseInfo(6, 2),//Ether 3:2
					new VerseInfo(6, 3),//Ether 3:3
					new VerseInfo(6, 4),//Ether 3:4
					new VerseInfo(6, 4),//Ether 3:5
					new VerseInfo(6, 5),//Ether 3:6
					new VerseInfo(6, 6),//Ether 3:7
					new VerseInfo(6, 7),//Ether 3:8
					new VerseInfo(6, 7),//Ether 3:9
					new VerseInfo(6, 8),//Ether 3:10
					new VerseInfo(6, 9),//Ether 3:11
					new VerseInfo(6, 10),//Ether 3:12
					new VerseInfo(6, 11, 6, 12),//Ether 3:13
					new VerseInfo(6, 12),//Ether 3:14
					new VerseInfo(6, 13),//Ether 3:15
					new VerseInfo(6, 14),//Ether 3:16
					new VerseInfo(6, 15),//Ether 3:17
					new VerseInfo(6, 16),//Ether 3:18
					new VerseInfo(6, 17),//Ether 3:19
					new VerseInfo(6, 18),//Ether 3:20
					new VerseInfo(6, 19),//Ether 3:21
					new VerseInfo(6, 20),//Ether 3:22
					new VerseInfo(6, 20),//Ether 3:23
					new VerseInfo(6, 21),//Ether 3:24
					new VerseInfo(6, 22),//Ether 3:25
					new VerseInfo(6, 23),//Ether 3:26
					new VerseInfo(6, 23),//Ether 3:27
					new VerseInfo(6, 24),//Ether 3:28
					new VerseInfo(6, 25),//Ether 3:29
					new VerseInfo(6, 25),//Ether 3:30
					new VerseInfo(6, 25),//Ether 3:31
					new VerseInfo(6, 26),//Ether 3:32
					new VerseInfo(6, 27),//Ether 3:33
					new VerseInfo(6, 28),//Ether 3:34
					new VerseInfo(6, 29),//Ether 3:35
					new VerseInfo(6, 30),//Ether 3:36
					new VerseInfo(7, 1),//Ether 3:37
					new VerseInfo(7, 2),//Ether 3:38
					new VerseInfo(7, 3),//Ether 3:39
					new VerseInfo(7, 3),//Ether 3:40
					new VerseInfo(7, 4),//Ether 3:41
					new VerseInfo(7, 5),//Ether 3:42
					new VerseInfo(7, 6),//Ether 3:43
					new VerseInfo(7, 7),//Ether 3:44
					new VerseInfo(7, 8),//Ether 3:45
					new VerseInfo(7, 9),//Ether 3:46
					new VerseInfo(7, 10),//Ether 3:47
					new VerseInfo(7, 11),//Ether 3:48
					new VerseInfo(7, 12),//Ether 3:49
					new VerseInfo(7, 13),//Ether 3:50
					new VerseInfo(7, 14),//Ether 3:51
					new VerseInfo(7, 14),//Ether 3:52
					new VerseInfo(7, 15),//Ether 3:53
					new VerseInfo(7, 16),//Ether 3:54
					new VerseInfo(7, 17),//Ether 3:55
					new VerseInfo(7, 18, 7, 19),//Ether 3:56
					new VerseInfo(7, 19),//Ether 3:57
					new VerseInfo(7, 20),//Ether 3:58
					new VerseInfo(7, 21),//Ether 3:59
					new VerseInfo(7, 22),//Ether 3:60
					new VerseInfo(7, 23),//Ether 3:61
					new VerseInfo(7, 24),//Ether 3:62
					new VerseInfo(7, 24, 7, 25),//Ether 3:63
					new VerseInfo(7, 26),//Ether 3:64
					new VerseInfo(7, 26),//Ether 3:65
					new VerseInfo(7, 27),//Ether 3:66
					new VerseInfo(8, 1),//Ether 3:67
					new VerseInfo(8, 1),//Ether 3:68
					new VerseInfo(8, 2),//Ether 3:69
					new VerseInfo(8, 2),//Ether 3:70
					new VerseInfo(8, 3),//Ether 3:71
					new VerseInfo(8, 4),//Ether 3:72
					new VerseInfo(8, 4, 8, 5),//Ether 3:73
					new VerseInfo(8, 5),//Ether 3:74
					new VerseInfo(8, 6),//Ether 3:75
					new VerseInfo(8, 6),//Ether 3:76
					new VerseInfo(8, 7),//Ether 3:77
					new VerseInfo(8, 8),//Ether 3:78
					new VerseInfo(8, 9),//Ether 3:79
					new VerseInfo(8, 9),//Ether 3:80
					new VerseInfo(8, 9),//Ether 3:81
					new VerseInfo(8, 10),//Ether 3:82
					new VerseInfo(8, 11),//Ether 3:83
					new VerseInfo(8, 11),//Ether 3:84
					new VerseInfo(8, 12),//Ether 3:85
					new VerseInfo(8, 13),//Ether 3:86
					new VerseInfo(8, 14),//Ether 3:87
					new VerseInfo(8, 14, 8, 15),//Ether 3:88
					new VerseInfo(8, 15),//Ether 3:89
					new VerseInfo(8, 16),//Ether 3:90
					new VerseInfo(8, 17),//Ether 3:91
					new VerseInfo(8, 18),//Ether 3:92
					new VerseInfo(8, 19),//Ether 3:93
					new VerseInfo(8, 20, 8, 21),//Ether 3:94
					new VerseInfo(8, 22),//Ether 3:95
					new VerseInfo(8, 23),//Ether 3:96
					new VerseInfo(8, 23),//Ether 3:97
					new VerseInfo(8, 24),//Ether 3:98
					new VerseInfo(8, 25),//Ether 3:99
					new VerseInfo(8, 25),//Ether 3:100
					new VerseInfo(8, 25),//Ether 3:101
					new VerseInfo(8, 26),//Ether 3:102
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Ether 4
					new VerseInfo(9, 1),//Ether 4:1
					new VerseInfo(9, 1, 9, 2),//Ether 4:2
					new VerseInfo(9, 3),//Ether 4:3
					new VerseInfo(9, 3),//Ether 4:4
					new VerseInfo(9, 4),//Ether 4:5
					new VerseInfo(9, 5),//Ether 4:6
					new VerseInfo(9, 6),//Ether 4:7
					new VerseInfo(9, 7),//Ether 4:8
					new VerseInfo(9, 8),//Ether 4:9
					new VerseInfo(9, 9),//Ether 4:10
					new VerseInfo(9, 10),//Ether 4:11
					new VerseInfo(9, 11),//Ether 4:12
					new VerseInfo(9, 12),//Ether 4:13
					new VerseInfo(9, 12, 9, 13),//Ether 4:14
					new VerseInfo(9, 14),//Ether 4:15
					new VerseInfo(9, 15),//Ether 4:16
					new VerseInfo(9, 15),//Ether 4:17
					new VerseInfo(9, 16),//Ether 4:18
					new VerseInfo(9, 16, 9, 17),//Ether 4:19
					new VerseInfo(9, 18),//Ether 4:20
					new VerseInfo(9, 19),//Ether 4:21
					new VerseInfo(9, 20),//Ether 4:22
					new VerseInfo(9, 21),//Ether 4:23
					new VerseInfo(9, 22),//Ether 4:24
					new VerseInfo(9, 23),//Ether 4:25
					new VerseInfo(9, 23),//Ether 4:26
					new VerseInfo(9, 24),//Ether 4:27
					new VerseInfo(9, 24),//Ether 4:28
					new VerseInfo(9, 25),//Ether 4:29
					new VerseInfo(9, 26),//Ether 4:30
					new VerseInfo(9, 27),//Ether 4:31
					new VerseInfo(9, 28),//Ether 4:32
					new VerseInfo(9, 29),//Ether 4:33
					new VerseInfo(9, 29),//Ether 4:34
					new VerseInfo(9, 30, 9, 31),//Ether 4:35
					new VerseInfo(9, 31),//Ether 4:36
					new VerseInfo(9, 32),//Ether 4:37
					new VerseInfo(9, 33),//Ether 4:38
					new VerseInfo(9, 34),//Ether 4:39
					new VerseInfo(9, 34),//Ether 4:40
					new VerseInfo(9, 35),//Ether 4:41
					new VerseInfo(9, 35),//Ether 4:42
					new VerseInfo(10, 1),//Ether 4:43
					new VerseInfo(10, 2),//Ether 4:44
					new VerseInfo(10, 3),//Ether 4:45
					new VerseInfo(10, 4),//Ether 4:46
					new VerseInfo(10, 4),//Ether 4:47
					new VerseInfo(10, 5),//Ether 4:48
					new VerseInfo(10, 6),//Ether 4:49
					new VerseInfo(10, 6, 10, 7),//Ether 4:50
					new VerseInfo(10, 7, 10, 8),//Ether 4:51
					new VerseInfo(10, 9),//Ether 4:52
					new VerseInfo(10, 9),//Ether 4:53
					new VerseInfo(10, 10),//Ether 4:54
					new VerseInfo(10, 11),//Ether 4:55
					new VerseInfo(10, 12),//Ether 4:56
					new VerseInfo(10, 13),//Ether 4:57
					new VerseInfo(10, 13),//Ether 4:58
					new VerseInfo(10, 14),//Ether 4:59
					new VerseInfo(10, 15),//Ether 4:60
					new VerseInfo(10, 15),//Ether 4:61
					new VerseInfo(10, 16),//Ether 4:62
					new VerseInfo(10, 17),//Ether 4:63
					new VerseInfo(10, 18),//Ether 4:64
					new VerseInfo(10, 19),//Ether 4:65
					new VerseInfo(10, 19),//Ether 4:66
					new VerseInfo(10, 19),//Ether 4:67
					new VerseInfo(10, 20),//Ether 4:68
					new VerseInfo(10, 21),//Ether 4:69
					new VerseInfo(10, 21, 10, 22),//Ether 4:70
					new VerseInfo(10, 23),//Ether 4:71
					new VerseInfo(10, 23),//Ether 4:72
					new VerseInfo(10, 24),//Ether 4:73
					new VerseInfo(10, 25),//Ether 4:74
					new VerseInfo(10, 26),//Ether 4:75
					new VerseInfo(10, 27),//Ether 4:76
					new VerseInfo(10, 27),//Ether 4:77
					new VerseInfo(10, 28),//Ether 4:78
					new VerseInfo(10, 28),//Ether 4:79
					new VerseInfo(10, 29),//Ether 4:80
					new VerseInfo(10, 30),//Ether 4:81
					new VerseInfo(10, 30),//Ether 4:82
					new VerseInfo(10, 30),//Ether 4:83
					new VerseInfo(10, 31),//Ether 4:84
					new VerseInfo(10, 31),//Ether 4:85
					new VerseInfo(10, 32),//Ether 4:86
					new VerseInfo(10, 32),//Ether 4:87
					new VerseInfo(10, 33),//Ether 4:88
					new VerseInfo(10, 34),//Ether 4:89
					new VerseInfo(11, 1),//Ether 4:90
					new VerseInfo(11, 2, 11, 3),//Ether 4:91
					new VerseInfo(11, 4),//Ether 4:92
					new VerseInfo(11, 4),//Ether 4:93
					new VerseInfo(11, 5),//Ether 4:94
					new VerseInfo(11, 6),//Ether 4:95
					new VerseInfo(11, 6),//Ether 4:96
					new VerseInfo(11, 7),//Ether 4:97
					new VerseInfo(11, 8),//Ether 4:98
					new VerseInfo(11, 9),//Ether 4:99
					new VerseInfo(11, 10),//Ether 4:100
					new VerseInfo(11, 10),//Ether 4:101
					new VerseInfo(11, 11),//Ether 4:102
					new VerseInfo(11, 12),//Ether 4:103
					new VerseInfo(11, 13),//Ether 4:104
					new VerseInfo(11, 14),//Ether 4:105
					new VerseInfo(11, 14),//Ether 4:106
					new VerseInfo(11, 15),//Ether 4:107
					new VerseInfo(11, 16),//Ether 4:108
					new VerseInfo(11, 17),//Ether 4:109
					new VerseInfo(11, 18),//Ether 4:110
					new VerseInfo(11, 19),//Ether 4:111
					new VerseInfo(11, 20),//Ether 4:112
					new VerseInfo(11, 21),//Ether 4:113
					new VerseInfo(11, 22),//Ether 4:114
					new VerseInfo(11, 23),//Ether 4:115
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Ether 5
					new VerseInfo(12, 1),//Ether 5:1
					new VerseInfo(12, 2),//Ether 5:2
					new VerseInfo(12, 3),//Ether 5:3
					new VerseInfo(12, 4),//Ether 5:4
					new VerseInfo(12, 5),//Ether 5:5
					new VerseInfo(12, 6),//Ether 5:6
					new VerseInfo(12, 6, 12, 7),//Ether 5:7
					new VerseInfo(12, 7),//Ether 5:8
					new VerseInfo(12, 8),//Ether 5:9
					new VerseInfo(12, 9),//Ether 5:10
					new VerseInfo(12, 10, 12, 11),//Ether 5:11
					new VerseInfo(12, 11),//Ether 5:12
					new VerseInfo(12, 12),//Ether 5:13
					new VerseInfo(12, 13),//Ether 5:14
					new VerseInfo(12, 14),//Ether 5:15
					new VerseInfo(12, 15, 12, 16),//Ether 5:16
					new VerseInfo(12, 17),//Ether 5:17
					new VerseInfo(12, 18),//Ether 5:18
					new VerseInfo(12, 19),//Ether 5:19
					new VerseInfo(12, 20),//Ether 5:20
					new VerseInfo(12, 21),//Ether 5:21
					new VerseInfo(12, 22),//Ether 5:22
					new VerseInfo(12, 23),//Ether 5:23
					new VerseInfo(12, 23, 12, 24),//Ether 5:24
					new VerseInfo(12, 24),//Ether 5:25
					new VerseInfo(12, 25),//Ether 5:26
					new VerseInfo(12, 26),//Ether 5:27
					new VerseInfo(12, 27),//Ether 5:28
					new VerseInfo(12, 28),//Ether 5:29
					new VerseInfo(12, 29, 12, 30),//Ether 5:30
					new VerseInfo(12, 30, 12, 31),//Ether 5:31
					new VerseInfo(12, 31, 12, 32),//Ether 5:32
					new VerseInfo(12, 33),//Ether 5:33
					new VerseInfo(12, 34),//Ether 5:34
					new VerseInfo(12, 35),//Ether 5:35
					new VerseInfo(12, 36),//Ether 5:36
					new VerseInfo(12, 37),//Ether 5:37
					new VerseInfo(12, 37),//Ether 5:38
					new VerseInfo(12, 38),//Ether 5:39
					new VerseInfo(12, 39, 12, 40),//Ether 5:40
					new VerseInfo(12, 41),//Ether 5:41
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Ether 6
					new VerseInfo(13, 1),//Ether 6:1
					new VerseInfo(13, 2),//Ether 6:2
					new VerseInfo(13, 2, 13, 3),//Ether 6:3
					new VerseInfo(13, 4, 13, 5),//Ether 6:4
					new VerseInfo(13, 5),//Ether 6:5
					new VerseInfo(13, 6, 13, 7),//Ether 6:6
					new VerseInfo(13, 7),//Ether 6:7
					new VerseInfo(13, 8),//Ether 6:8
					new VerseInfo(13, 9),//Ether 6:9
					new VerseInfo(13, 10),//Ether 6:10
					new VerseInfo(13, 11),//Ether 6:11
					new VerseInfo(13, 11),//Ether 6:12
					new VerseInfo(13, 12),//Ether 6:13
					new VerseInfo(13, 13),//Ether 6:14
					new VerseInfo(13, 14),//Ether 6:15
					new VerseInfo(13, 15),//Ether 6:16
					new VerseInfo(13, 16),//Ether 6:17
					new VerseInfo(13, 17),//Ether 6:18
					new VerseInfo(13, 18),//Ether 6:19
					new VerseInfo(13, 19),//Ether 6:20
					new VerseInfo(13, 20),//Ether 6:21
					new VerseInfo(13, 21),//Ether 6:22
					new VerseInfo(13, 21),//Ether 6:23
					new VerseInfo(13, 22),//Ether 6:24
					new VerseInfo(13, 23),//Ether 6:25
					new VerseInfo(13, 24),//Ether 6:26
					new VerseInfo(13, 25),//Ether 6:27
					new VerseInfo(13, 26),//Ether 6:28
					new VerseInfo(13, 27),//Ether 6:29
					new VerseInfo(13, 28),//Ether 6:30
					new VerseInfo(13, 28),//Ether 6:31
					new VerseInfo(13, 29),//Ether 6:32
					new VerseInfo(13, 30),//Ether 6:33
					new VerseInfo(13, 31),//Ether 6:34
					new VerseInfo(14, 1),//Ether 6:35
					new VerseInfo(14, 2),//Ether 6:36
					new VerseInfo(14, 3),//Ether 6:37
					new VerseInfo(14, 4),//Ether 6:38
					new VerseInfo(14, 5),//Ether 6:39
					new VerseInfo(14, 6),//Ether 6:40
					new VerseInfo(14, 7),//Ether 6:41
					new VerseInfo(14, 8),//Ether 6:42
					new VerseInfo(14, 9),//Ether 6:43
					new VerseInfo(14, 10),//Ether 6:44
					new VerseInfo(14, 11),//Ether 6:45
					new VerseInfo(14, 12),//Ether 6:46
					new VerseInfo(14, 13),//Ether 6:47
					new VerseInfo(14, 14),//Ether 6:48
					new VerseInfo(14, 15),//Ether 6:49
					new VerseInfo(14, 15),//Ether 6:50
					new VerseInfo(14, 16),//Ether 6:51
					new VerseInfo(14, 17),//Ether 6:52
					new VerseInfo(14, 17),//Ether 6:53
					new VerseInfo(14, 18),//Ether 6:54
					new VerseInfo(14, 19),//Ether 6:55
					new VerseInfo(14, 20),//Ether 6:56
					new VerseInfo(14, 21),//Ether 6:57
					new VerseInfo(14, 22),//Ether 6:58
					new VerseInfo(14, 23),//Ether 6:59
					new VerseInfo(14, 24),//Ether 6:60
					new VerseInfo(14, 25),//Ether 6:61
					new VerseInfo(14, 26),//Ether 6:62
					new VerseInfo(14, 27),//Ether 6:63
					new VerseInfo(14, 27, 14, 28),//Ether 6:64
					new VerseInfo(14, 28),//Ether 6:65
					new VerseInfo(14, 28),//Ether 6:66
					new VerseInfo(14, 29),//Ether 6:67
					new VerseInfo(14, 29),//Ether 6:68
					new VerseInfo(14, 30),//Ether 6:69
					new VerseInfo(14, 30),//Ether 6:70
					new VerseInfo(14, 31),//Ether 6:71
					new VerseInfo(15, 1),//Ether 6:72
					new VerseInfo(15, 2),//Ether 6:73
					new VerseInfo(15, 3),//Ether 6:74
					new VerseInfo(15, 4),//Ether 6:75
					new VerseInfo(15, 5),//Ether 6:76
					new VerseInfo(15, 6),//Ether 6:77
					new VerseInfo(15, 6),//Ether 6:78
					new VerseInfo(15, 7),//Ether 6:79
					new VerseInfo(15, 8),//Ether 6:80
					new VerseInfo(15, 9),//Ether 6:81
					new VerseInfo(15, 10),//Ether 6:82
					new VerseInfo(15, 11),//Ether 6:83
					new VerseInfo(15, 12),//Ether 6:84
					new VerseInfo(15, 13),//Ether 6:85
					new VerseInfo(15, 14),//Ether 6:86
					new VerseInfo(15, 15),//Ether 6:87
					new VerseInfo(15, 16),//Ether 6:88
					new VerseInfo(15, 17),//Ether 6:89
					new VerseInfo(15, 17),//Ether 6:90
					new VerseInfo(15, 18),//Ether 6:91
					new VerseInfo(15, 19),//Ether 6:92
					new VerseInfo(15, 20, 15, 21),//Ether 6:93
					new VerseInfo(15, 22, 15, 23),//Ether 6:94
					new VerseInfo(15, 23),//Ether 6:95
					new VerseInfo(15, 24),//Ether 6:96
					new VerseInfo(15, 25),//Ether 6:97
					new VerseInfo(15, 26),//Ether 6:98
					new VerseInfo(15, 26),//Ether 6:99
					new VerseInfo(15, 27),//Ether 6:100
					new VerseInfo(15, 28),//Ether 6:101
					new VerseInfo(15, 29),//Ether 6:102
					new VerseInfo(15, 29),//Ether 6:103
					new VerseInfo(15, 30),//Ether 6:104
					new VerseInfo(15, 31),//Ether 6:105
					new VerseInfo(15, 32),//Ether 6:106
					new VerseInfo(15, 33),//Ether 6:107
					new VerseInfo(15, 33),//Ether 6:108
					new VerseInfo(15, 34),//Ether 6:109
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
					new VerseInfo(3, 2, 3, 3),//Moroni 3:2
					new VerseInfo(3, 4),//Moroni 3:3
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 4
					new VerseInfo(4, 1),//Moroni 4:1
					new VerseInfo(4, 1),//Moroni 4:2
					new VerseInfo(4, 2),//Moroni 4:3
					new VerseInfo(4, 3),//Moroni 4:4
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 5
					new VerseInfo(5, 1),//Moroni 5:1
					new VerseInfo(5, 1),//Moroni 5:2
					new VerseInfo(5, 2),//Moroni 5:3
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 6
					new VerseInfo(6, 1),//Moroni 6:1
					new VerseInfo(6, 1, 6, 2),//Moroni 6:2
					new VerseInfo(6, 3),//Moroni 6:3
					new VerseInfo(6, 4),//Moroni 6:4
					new VerseInfo(6, 4),//Moroni 6:5
					new VerseInfo(6, 5, 6, 6),//Moroni 6:6
					new VerseInfo(6, 7),//Moroni 6:7
					new VerseInfo(6, 7, 6, 8),//Moroni 6:8
					new VerseInfo(6, 9),//Moroni 6:9
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 7
					new VerseInfo(7, 1),//Moroni 7:1
					new VerseInfo(7, 2),//Moroni 7:2
					new VerseInfo(7, 3),//Moroni 7:3
					new VerseInfo(7, 4, 7, 5),//Moroni 7:4
					new VerseInfo(7, 6),//Moroni 7:5
					new VerseInfo(7, 7),//Moroni 7:6
					new VerseInfo(7, 8),//Moroni 7:7
					new VerseInfo(7, 9, 7, 10),//Moroni 7:8
					new VerseInfo(7, 11),//Moroni 7:9
					new VerseInfo(7, 12),//Moroni 7:10
					new VerseInfo(7, 13),//Moroni 7:11
					new VerseInfo(7, 14),//Moroni 7:12
					new VerseInfo(7, 15),//Moroni 7:13
					new VerseInfo(7, 16),//Moroni 7:14
					new VerseInfo(7, 16, 7, 17),//Moroni 7:15
					new VerseInfo(7, 17),//Moroni 7:16
					new VerseInfo(7, 18),//Moroni 7:17
					new VerseInfo(7, 19),//Moroni 7:18
					new VerseInfo(7, 20),//Moroni 7:19
					new VerseInfo(7, 21),//Moroni 7:20
					new VerseInfo(7, 22),//Moroni 7:21
					new VerseInfo(7, 23),//Moroni 7:22
					new VerseInfo(7, 24),//Moroni 7:23
					new VerseInfo(7, 25),//Moroni 7:24
					new VerseInfo(7, 26),//Moroni 7:25
					new VerseInfo(7, 26),//Moroni 7:26
					new VerseInfo(7, 27),//Moroni 7:27
					new VerseInfo(7, 28, 7, 29),//Moroni 7:28
					new VerseInfo(7, 29),//Moroni 7:29
					new VerseInfo(7, 29),//Moroni 7:30
					new VerseInfo(7, 30),//Moroni 7:31
					new VerseInfo(7, 31),//Moroni 7:32
					new VerseInfo(7, 32),//Moroni 7:33
					new VerseInfo(7, 32),//Moroni 7:34
					new VerseInfo(7, 33),//Moroni 7:35
					new VerseInfo(7, 34),//Moroni 7:36
					new VerseInfo(7, 35),//Moroni 7:37
					new VerseInfo(7, 36),//Moroni 7:38
					new VerseInfo(7, 36),//Moroni 7:39
					new VerseInfo(7, 36),//Moroni 7:40
					new VerseInfo(7, 37),//Moroni 7:41
					new VerseInfo(7, 37, 7, 38),//Moroni 7:42
					new VerseInfo(7, 38),//Moroni 7:43
					new VerseInfo(7, 39),//Moroni 7:44
					new VerseInfo(7, 40),//Moroni 7:45
					new VerseInfo(7, 40, 7, 41),//Moroni 7:46
					new VerseInfo(7, 41),//Moroni 7:47
					new VerseInfo(7, 42),//Moroni 7:48
					new VerseInfo(7, 43, 7, 44),//Moroni 7:49
					new VerseInfo(7, 44),//Moroni 7:50
					new VerseInfo(7, 45, 7, 46),//Moroni 7:51
					new VerseInfo(7, 46, 7, 47),//Moroni 7:52
					new VerseInfo(7, 48),//Moroni 7:53
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 8
					new VerseInfo(8, 1),//Moroni 8:1
					new VerseInfo(8, 1, 8, 2),//Moroni 8:2
					new VerseInfo(8, 3),//Moroni 8:3
					new VerseInfo(8, 4),//Moroni 8:4
					new VerseInfo(8, 5),//Moroni 8:5
					new VerseInfo(8, 6),//Moroni 8:6
					new VerseInfo(8, 7),//Moroni 8:7
					new VerseInfo(8, 7, 8, 8),//Moroni 8:8
					new VerseInfo(8, 8),//Moroni 8:9
					new VerseInfo(8, 9),//Moroni 8:10
					new VerseInfo(8, 10, 8, 11),//Moroni 8:11
					new VerseInfo(8, 11),//Moroni 8:12
					new VerseInfo(8, 12),//Moroni 8:13
					new VerseInfo(8, 13),//Moroni 8:14
					new VerseInfo(8, 14),//Moroni 8:15
					new VerseInfo(8, 15),//Moroni 8:16
					new VerseInfo(8, 16),//Moroni 8:17
					new VerseInfo(8, 16, 8, 17),//Moroni 8:18
					new VerseInfo(8, 18),//Moroni 8:19
					new VerseInfo(8, 19),//Moroni 8:20
					new VerseInfo(8, 20),//Moroni 8:21
					new VerseInfo(8, 21),//Moroni 8:22
					new VerseInfo(8, 21),//Moroni 8:23
					new VerseInfo(8, 21),//Moroni 8:24
					new VerseInfo(8, 22),//Moroni 8:25
					new VerseInfo(8, 22),//Moroni 8:26
					new VerseInfo(8, 23),//Moroni 8:27
					new VerseInfo(8, 24),//Moroni 8:28
					new VerseInfo(8, 25, 8, 26),//Moroni 8:29
					new VerseInfo(8, 27),//Moroni 8:30
					new VerseInfo(8, 27),//Moroni 8:31
					new VerseInfo(8, 28),//Moroni 8:32
					new VerseInfo(8, 28),//Moroni 8:33
					new VerseInfo(8, 29),//Moroni 8:34
					new VerseInfo(8, 30),//Moroni 8:35
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
					new VerseInfo(9, 7),//Moroni 9:7
					new VerseInfo(9, 7),//Moroni 9:8
					new VerseInfo(9, 8),//Moroni 9:9
					new VerseInfo(9, 9),//Moroni 9:10
					new VerseInfo(9, 9, 9, 10),//Moroni 9:11
					new VerseInfo(9, 11, 9, 14),//Moroni 9:12
					new VerseInfo(9, 15),//Moroni 9:13
					new VerseInfo(9, 15),//Moroni 9:14
					new VerseInfo(9, 16),//Moroni 9:15
					new VerseInfo(9, 17),//Moroni 9:16
					new VerseInfo(9, 18),//Moroni 9:17
					new VerseInfo(9, 18, 9, 19),//Moroni 9:18
					new VerseInfo(9, 19),//Moroni 9:19
					new VerseInfo(9, 20),//Moroni 9:20
					new VerseInfo(9, 20),//Moroni 9:21
					new VerseInfo(9, 21),//Moroni 9:22
					new VerseInfo(9, 22),//Moroni 9:23
					new VerseInfo(9, 22, 9, 23),//Moroni 9:24
					new VerseInfo(9, 24),//Moroni 9:25
					new VerseInfo(9, 24),//Moroni 9:26
					new VerseInfo(9, 25),//Moroni 9:27
					new VerseInfo(9, 26),//Moroni 9:28
				},
				new VerseInfo?[]
				{
					new VerseInfo(0, 1, 0, 1),//Moroni 10
					new VerseInfo(10, 1),//Moroni 10:1
					new VerseInfo(10, 2),//Moroni 10:2
					new VerseInfo(10, 3),//Moroni 10:3
					new VerseInfo(10, 4),//Moroni 10:4
					new VerseInfo(10, 4, 10, 5),//Moroni 10:5
					new VerseInfo(10, 6),//Moroni 10:6
					new VerseInfo(10, 7),//Moroni 10:7
					new VerseInfo(10, 8),//Moroni 10:8
					new VerseInfo(10, 8),//Moroni 10:9
					new VerseInfo(10, 9, 10, 11),//Moroni 10:10
					new VerseInfo(10, 12, 10, 16),//Moroni 10:11
					new VerseInfo(10, 17),//Moroni 10:12
					new VerseInfo(10, 18),//Moroni 10:13
					new VerseInfo(10, 19),//Moroni 10:14
					new VerseInfo(10, 20, 10, 21),//Moroni 10:15
					new VerseInfo(10, 21, 10, 22),//Moroni 10:16
					new VerseInfo(10, 23),//Moroni 10:17
					new VerseInfo(10, 24),//Moroni 10:18
					new VerseInfo(10, 25),//Moroni 10:19
					new VerseInfo(10, 25),//Moroni 10:20
					new VerseInfo(10, 26),//Moroni 10:21
					new VerseInfo(10, 27),//Moroni 10:22
					new VerseInfo(10, 27),//Moroni 10:23
					new VerseInfo(10, 28),//Moroni 10:24
					new VerseInfo(10, 28),//Moroni 10:25
					new VerseInfo(10, 29),//Moroni 10:26
					new VerseInfo(10, 30),//Moroni 10:27
					new VerseInfo(10, 31),//Moroni 10:28
					new VerseInfo(10, 32),//Moroni 10:29
					new VerseInfo(10, 33),//Moroni 10:30
					new VerseInfo(10, 34),//Moroni 10:31
				},
			}
		},
	};
}
