using System;
using System.Collections.Generic;
using System.Text;

namespace SeekingYHWH.Scriptures;

public sealed class PassagesConverter
{
	public static Dictionary<string, BookConverter> CreateBooksEmpty()
	{
		var books = new Dictionary<string, BookConverter>(StringComparer.InvariantCultureIgnoreCase);
		return books;
	}

	private Dictionary<string, BookConverter> books;

	private readonly StringBuilder builder = new StringBuilder();
	private StringBuilder parsingBuilder = new StringBuilder();
	private int parsingValue;
	private string book;
	private StringBuilder openChapterBuilder = new StringBuilder();
	private int openChapterValue;
	private StringBuilder openVerseBuilder = new StringBuilder();
	private int openVerseValue;
	private StringBuilder closeChapterBuilder = new StringBuilder();
	private int closeChapterValue;
	private StringBuilder closeVerseBuilder = new StringBuilder();
	private int closeVerseValue;
	private readonly StringBuilder tempBuilder = new StringBuilder();
	private StringBuilder[] builders;
	private bool spaced;
	private bool error;

	public PassagesConverter()
	{
	}

	public PassagesConverter (Dictionary<string, BookConverter> books)
		: this()
	{
		this.books = books;
	}

	public Dictionary<string, BookConverter> Books { get => books; set => books = value; }

	public StringBuilder Builder => builder;
	public string Book => book;
	public StringBuilder OpenChapterBuilder => openChapterBuilder;
	public int OpenChapterValue => openChapterValue;
	public StringBuilder OpenVerseBuilder => openVerseBuilder;
	public int OpenVerseValue => openVerseValue;
	public StringBuilder CloseChapterBuilder => closeChapterBuilder;
	public int CloseChapterValue => closeChapterValue;
	public StringBuilder CloseVerseBuilder => closeVerseBuilder;
	public int CloseVerseValue => closeVerseValue;
	public StringBuilder TempBuilder => tempBuilder;
	public StringBuilder[] Builders => builders;
	public bool Error => error;

	public void Initialize()
	{
		foreach (var book in books.Values)
		{
			book.Initialize(this);
		}
	}

	public void Initialize(BookConverter book)
	{
		book.Initialize(this);
	}

	public void Initialize(Dictionary<string, BookConverter> books)
	{
		foreach (var book in books.Values)
		{
			book.Initialize(this);
		}
	}

	public void InitializeBuilder(int i)
	{
		var count = i + 1;
		var length = builders != null ? builders.Length : 0;
		if (count > length)
		{
			Array.Resize(ref builders, count);
		}
		if (builders[i] == null)
		{
			builders[i] = new StringBuilder();
		}
	}

	public string Convert(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return value;
		}
		builder.Clear();
		error = false;
		var valueLength = value.Length;
		var offset = 0;
		char v;
		BookConverter converter;
		goto PrepareTest;
	Prepare:
		++offset;
	PrepareTest:
		if (offset >= valueLength)
		{
			goto Finish;
		}
		v = value[offset];
		parsingBuilder.Clear();
		parsingValue = 0;
		openChapterBuilder.Clear();
		openChapterValue = 0;
		openVerseBuilder.Clear();
		openVerseValue = 0;
		closeChapterBuilder.Clear();
		closeChapterValue = 0;
		closeVerseBuilder.Clear();
		closeVerseValue = 0;
		tempBuilder.Clear();
		if (builders != null)
		{
			foreach (var b in builders)
			{
				b?.Clear();
			}
		}
		spaced = false;
		converter = null;
	BookBefore:
		if (char.IsLetter(v))
		{
			parsingBuilder.Append(v);
			goto BookLetter;
		}
		else if (char.IsDigit(v))
		{
			parsingBuilder.Append(v);
			goto BookDigit;
		}
		else if (char.IsWhiteSpace(v) || v == ';')
		{
			++offset;
			if (offset >= valueLength)
			{
				goto Finish;
			}
			v = value[offset];
			goto BookBefore;
		}
		else
		{
			builder.Append(v);
			error = true;
			goto Copy;
		}
	BookDigit:
		++offset;
		if (offset >= valueLength)
		{
			error = true;
			goto Finish;
		}
		v = value[offset];
		if (char.IsDigit(v))
		{
			parsingBuilder.Append(v);
			goto BookDigit;
		}
		else if (char.IsWhiteSpace(v))
		{
			parsingBuilder.Append(' ');
			goto BookDigitAfter;
		}
		else
		{
			error = true;
			builder.Append(v);
			goto Copy;
		}
	BookDigitAfter:
		++offset;
		if (offset >= valueLength)
		{
			error = true;
			goto Finish;
		}
		v = value[offset];
		if (char.IsLetter(v))
		{
			parsingBuilder.Append(v);
			goto BookLetter;
		}
		else if (char.IsWhiteSpace(v))
		{
			spaced = true;
			goto BookDigitAfter;
		}
		else
		{
			error = true;
			builder.Append(parsingBuilder);
			if (spaced)
			{
				builder.Append(' ');
				spaced = false;
			}
			builder.Append(v);
			goto Copy;
		}
	BookLetter:
		++offset;
		if (offset >= valueLength)
		{
			builder.Append(parsingBuilder);
			goto Finish;
		}
		v = value[offset];
		if (char.IsLetter(v) || v == '&')
		{
			if (spaced)
			{
				parsingBuilder.Append(' ');
				spaced = false;
			}
			parsingBuilder.Append(v);
			goto BookLetter;
		}
		else if (char.IsWhiteSpace(v))
		{
			spaced = true;
			goto BookLetter;
		}
		else if (char.IsDigit(v))
		{
			if (!spaced)
			{
				builder.Append(parsingBuilder);
				builder.Append(v);
				goto Copy;
			}

			book = parsingBuilder.ToString();
			if (books.TryGetValue(book, out converter))
			{
				if (converter.Rename != null)
				{
					builder.Append(converter.Rename);
				}
				else
				{
					builder.Append(book);
				}
				builder.Append(' ');

				converter.Begin(this);

				openChapterBuilder.Clear();
				openChapterBuilder.Append(v);
				openChapterValue = v - '0';
				goto OpenChapter;
			}
			else
			{
				builder.Append(book);
				builder.Append(' ');
				builder.Append(v);
				spaced = false;
				goto Copy;
			}
		}
		else if (v == ';')
		{
			builder.Append(parsingBuilder);
			builder.Append(v);
			goto Prepare;
		}
		else
		{
			error = true;
			builder.Append(parsingBuilder);
			if (spaced)
			{
				builder.Append(' ');
				spaced = false;
			}
			builder.Append(v);
			goto Copy;
		}
	OpenChapterBefore:
		++offset;
		if (offset >= valueLength)
		{
			error = true;
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (char.IsDigit(v))
		{
			openChapterBuilder.Append(v);
			openChapterValue = v - '0';
			goto OpenChapter;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto OpenChapterBefore;
		}
		else
		{
			error = true;
			if (v == ';')
			{
				converter.End(this);
				builder.Append(v);
				goto Prepare;
			}
			else
			{
				converter.Error(this, v);
				goto Error;
			}
		}
	OpenChapter:
		++offset;
		if (offset >= valueLength)
		{
			converter.Chapter(this);
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (char.IsDigit(v))
		{
			openChapterBuilder.Append(v);
			openChapterValue = (10 * openChapterValue) + (v - '0');
			goto OpenChapter;
		}
		else if (v == ';')
		{
			converter.Chapter(this);
			converter.End(this);
			builder.Append(v);
			goto Prepare;
		}
		else if (v == ':')
		{
			goto OpenVerseBefore;
		}
		else if (v == '-')
		{
			goto ChaptersBefore;
		}
		else if (v == ',')
		{
			converter.Chapter(this);
			converter.Additional(this);
			openChapterBuilder.Clear();
			openChapterValue = 0;
			goto OpenChapterBefore;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto OpenChapterAfter;
		}
		else
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, v);
			goto Error;
		}
	OpenChapterAfter:
		++offset;
		if (offset >= valueLength)
		{
			converter.Chapter(this);
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (v == ';')
		{
			converter.Chapter(this);
			converter.End(this);
			builder.Append(v);
			goto Prepare;
		}
		else if (v == ':')
		{
			goto OpenVerseBefore;
		}
		else if (v == '-')
		{
			goto ChaptersBefore;
		}
		else if (v == ',')
		{
			converter.Chapter(this);
			converter.Additional(this);
			openChapterBuilder.Clear();
			openChapterValue = 0;
			goto OpenChapterBefore;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto OpenChapterAfter;
		}
		else
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, ' ');
			converter.Error(this, v);
			goto Error;
		}
	ChaptersBefore:
		++offset;
		if (offset >= valueLength)
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, '-');
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (char.IsDigit(v))
		{
			closeChapterBuilder.Append(v);
			closeChapterValue = v - '0';
			goto Chapters;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto ChaptersBefore;
		}
		else
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, '-');
			if (v == ';')
			{
				converter.End(this);
				builder.Append(v);
				goto Prepare;
			}
			else
			{
				converter.Error(this, v);
				goto Error;
			}
		}
	Chapters:
		++offset;
		if (offset >= valueLength)
		{
			converter.Chapters(this);
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (char.IsDigit(v))
		{
			closeChapterBuilder.Append(v);
			closeChapterValue = (10 * closeChapterValue) + (v -  '0');
			goto Chapters;
		}
		else if (v == ';')
		{
			converter.Chapters(this);
			converter.End(this);
			builder.Append(v);
			goto Prepare;
		}
		else if (v == ',')
		{
			converter.Chapters(this);
			converter.Additional(this);
			openChapterBuilder.Clear();
			openChapterValue = 0;
			closeChapterBuilder.Clear();
			closeChapterValue = 0;
			parsingBuilder.Clear();
			parsingValue = 0;
			goto OpenChapterBefore;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto ChaptersAfter;
		}
		else
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, '-');
			converter.Error(this, closeChapterBuilder);
			converter.Error(this, v);
			goto Error;
		}
	ChaptersAfter:
		++offset;
		if (offset >= valueLength)
		{
			converter.Chapters(this);
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (v == ';')
		{
			converter.Chapters(this);
			converter.End(this);
			builder.Append(v);
			goto Prepare;
		}
		else if (v == ',')
		{
			converter.Chapters(this);
			converter.Additional(this);
			openChapterBuilder.Clear();
			openChapterValue = 0;
			closeChapterBuilder.Clear();
			closeChapterValue = 0;
			parsingBuilder.Clear();
			parsingValue = 0;
			goto OpenChapterBefore;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto ChaptersAfter;
		}
		else
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, '-');
			converter.Error(this, closeChapterBuilder);
			converter.Error(this, ' ');
			converter.Error(this, v);
			goto Error;
		}
	OpenVerseBefore:
		++offset;
		if (offset >= valueLength)
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, ':');
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (char.IsDigit(v))
		{
			openVerseBuilder.Append(v);
			openVerseValue = v -  '0';
			goto OpenVerse;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto OpenVerseBefore;
		}
		else
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, ':');
			if (v == ';')
			{
				converter.End(this);
				builder.Append(v);
				goto Prepare;
			}
			else
			{
				converter.Error(this, v);
				goto Error;
			}
		}
	OpenVerse:
		++offset;
		if (offset >= valueLength)
		{
			converter.ChapterVerse(this);
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (char.IsDigit(v))
		{
			openVerseBuilder.Append(v);
			openVerseValue = (10 * openVerseValue) + (v - '0');
			goto OpenVerse;
		}
		else if (v == ';')
		{
			converter.ChapterVerse(this);
			converter.End(this);
			builder.Append(v);
			goto Prepare;
		}
		else if (v == ',')
		{
			converter.ChapterVerse(this);
			converter.Additional(this);
			parsingBuilder.Clear();
			parsingValue = 0;
			goto AdditionalBefore;
		}
		else if (v == '-')
		{
			parsingBuilder.Clear();
			parsingValue = 0;
			goto CloseBefore;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto OpenVerseAfter;
		}
		else
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, ':');
			converter.Error(this, openVerseBuilder);
			converter.Error(this, v);
			goto Error;
		}
	OpenVerseAfter:
		++offset;
		if (offset >= valueLength)
		{
			converter.ChapterVerse(this);
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (v == ';')
		{
			converter.ChapterVerse(this);
			converter.End(this);
			builder.Append(v);
			goto Prepare;
		}
		else if (v == ',')
		{
			converter.ChapterVerse(this);
			converter.Additional(this);
			parsingBuilder.Clear();
			parsingValue = 0;
			goto AdditionalBefore;
		}
		else if (v == '-')
		{
			parsingBuilder.Clear();
			parsingValue = 0;
			goto CloseBefore;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto OpenVerseAfter;
		}
		else
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, ':');
			converter.Error(this, openVerseBuilder);
			converter.Error(this, ' ');
			converter.Error(this, v);
			goto Error;
		}
	AdditionalBefore:
		++offset;
		if (offset >= valueLength)
		{
			error = true;
			goto Finish;
		}
		v = value[offset];
		if (char.IsDigit(v))
		{
			parsingBuilder.Append(v);
			parsingValue = v - '0';
			goto Additional;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto AdditionalBefore;
		}
		else
		{
			error = true;
			if (v == ';')
			{
				converter.End(this);
				builder.Append(v);
				goto Prepare;
			}
			else
			{
				converter.Error(this, v);
				goto Error;
			}
		}
	Additional:
		++offset;
		if (offset >= valueLength)
		{
			(openVerseBuilder, openVerseValue, parsingBuilder) = (parsingBuilder, parsingValue, openVerseBuilder);
			converter.Verse(this);
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (char.IsDigit(v))
		{
			parsingBuilder.Append(v);
			parsingValue = (10 * parsingValue) + (v - '0');
			goto Additional;
		}
		else if (v == ';')
		{
			(openVerseBuilder, openVerseValue, parsingBuilder) = (parsingBuilder, parsingValue, openVerseBuilder);
			converter.Verse(this);
			converter.End(this);
			goto Prepare;
		}
		else if (v == ',')
		{
			(openVerseBuilder, openVerseValue, parsingBuilder) = (parsingBuilder, parsingValue, openVerseBuilder);
			converter.Verse(this);
			converter.Additional(this);
			parsingBuilder.Clear();
			parsingValue = 0;
			goto AdditionalBefore;
		}
		else if (v == ':')
		{
			(openChapterBuilder, openChapterValue, parsingBuilder) = (parsingBuilder, parsingValue, openChapterBuilder);
			goto OpenVerseBefore;
		}
		else if (v == '-')
		{
			(openVerseBuilder, openVerseValue, parsingBuilder) = (parsingBuilder, parsingValue, openVerseBuilder);
			closeVerseBuilder.Clear();
			closeVerseValue = 0;
			goto VersesBefore;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto AdditionalAfter;
		}
		else
		{
			error = true;
			converter.Error(this, parsingBuilder);
			converter.Error(this, v);
			goto Error;
		}
	AdditionalAfter:
		++offset;
		if (offset >= valueLength)
		{
			throw new NotImplementedException("AdditionalAfter");
		}
		v = value[offset];
		if (v == ';')
		{
			(openVerseBuilder, openVerseValue, parsingBuilder) = (parsingBuilder, parsingValue, openVerseBuilder);
			converter.Verse(this);
			converter.End(this);
			goto Prepare;
		}
		else if (v == ',')
		{
			(openVerseBuilder, openVerseValue, parsingBuilder) = (parsingBuilder, parsingValue, openVerseBuilder);
			converter.Verse(this);
			converter.Additional(this);
			parsingBuilder.Clear();
			parsingValue = 0;
			goto AdditionalBefore;
		}
		else if (v == ':')
		{
			(openChapterBuilder, openChapterValue, parsingBuilder) = (parsingBuilder, parsingValue, openChapterBuilder);
			goto OpenVerseBefore;
		}
		else if (v == '-')
		{
			(openVerseBuilder, openVerseValue, parsingBuilder) = (parsingBuilder, parsingValue, openVerseBuilder);
			closeVerseBuilder.Clear();
			closeVerseValue = 0;
			goto VersesBefore;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto AdditionalAfter;
		}
		else
		{
			error = true;
			converter.Error(this, parsingBuilder);
			converter.Error(this, ' ');
			converter.Error(this, v);
			goto Error;
		}
	VersesBefore:
		++offset;
		if (offset >= valueLength)
		{
			error = true;
			converter.Error(this, openVerseBuilder);
			converter.Error(this, '-');
			goto Finish;
		}
		v = value[offset];
		if (char.IsDigit(v))
		{
			closeVerseBuilder.Append(v);
			closeVerseValue = v - '0';
			goto Verses;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto VersesBefore;
		}
		else
		{
			error = true;
			converter.Error(this, openVerseBuilder);
			converter.Error(this, '-');
			if (v == ';')
			{
				converter.End(this);
				builder.Append(v);
				goto Prepare;
			}
			else
			{
				converter.Error(this, v);
				goto Error;
			}
		}
	Verses:
		++offset;
		if (offset >= valueLength)
		{
			converter.Verses(this);
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (char.IsDigit(v))
		{
			closeVerseBuilder.Append(v);
			closeVerseValue = (10 * closeVerseValue) + (v - '0');
			goto Verses;
		}
		else if (v == ';')
		{
			converter.Verses(this);
			converter.End(this);
			builder.Append(v);
			goto Prepare;
		}
		else if (v == ',')
		{
			converter.Verses(this);
			converter.Additional(this);
			parsingBuilder.Clear();
			parsingValue = 0;
			goto AdditionalBefore;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto VersesAfter;
		}
		else
		{
			error = true;
			converter.Error(this, openVerseBuilder);
			converter.Error(this, '-');
			converter.Error(this, closeVerseBuilder);
			converter.Error(this, v);
			goto Error;
		}
	VersesAfter:
		++offset;
		if (offset >= valueLength)
		{
			converter.Verses(this);
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (v == ';')
		{
			converter.Verses(this);
			converter.End(this);
			builder.Append(v);
			goto Prepare;
		}
		else if (v == ',')
		{
			converter.Verses(this);
			converter.Additional(this);
			parsingBuilder.Clear();
			parsingValue = 0;
			goto AdditionalBefore;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto VersesAfter;
		}
		else
		{
			error = true;
			converter.Error(this, openVerseBuilder);
			converter.Error(this, '-');
			converter.Error(this, closeVerseBuilder);
			converter.Error(this, ' ');
			converter.Error(this, v);
			goto Error;
		}
	CloseBefore:
		++offset;
		if (offset >= valueLength)
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, ':');
			converter.Error(this, openVerseBuilder);
			converter.Error(this, '-');
			goto Error;
		}
		v = value[offset];
		if (char.IsDigit(v))
		{
			parsingBuilder.Append(v);
			parsingValue = v - '0';
			goto Close;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto CloseBefore;
		}
		else
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, ':');
			converter.Error(this, openVerseBuilder);
			converter.Error(this, '-');
			if (v == ';')
			{
				converter.End(this);
				builder.Append(v);
				goto Prepare;
			}
			else
			{
				converter.Error(this, v);
				goto Error;
			}
		}
	Close:
		++offset;
		if (offset >= valueLength)
		{
			(closeVerseBuilder, closeVerseValue, parsingBuilder) = (parsingBuilder, parsingValue, closeVerseBuilder);
			converter.ChapterVerses(this);
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (char.IsDigit(v))
		{
			parsingBuilder.Append(v);
			parsingValue = (10 * parsingValue) + (v - '0');
			goto Close;
		}
		else if (v == ';')
		{
			(closeVerseBuilder, closeVerseValue, parsingBuilder) = (parsingBuilder, parsingValue, closeVerseBuilder);
			converter.ChapterVerses(this);
			converter.End(this);
			builder.Append(v);
			goto Prepare;
		}
		else if (v == ':')
		{
			(closeChapterBuilder, closeChapterValue, parsingBuilder) = (parsingBuilder, parsingValue, closeChapterBuilder);
			goto CloseVerseBefore;
		}
		else if (v == ',')
		{
			(closeVerseBuilder, closeVerseValue, parsingBuilder) = (parsingBuilder, parsingValue, closeVerseBuilder);
			converter.ChapterVerses(this);
			converter.Additional(this);
			parsingBuilder.Clear();
			parsingValue = 0;
			goto AdditionalBefore;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto CloseAfter;
		}
		else
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, ':');
			converter.Error(this, openVerseBuilder);
			converter.Error(this, '-');
			converter.Error(this, parsingBuilder);
			converter.Error(this, v);
			goto Error;
		}
	CloseAfter:
		++offset;
		if (offset >= valueLength)
		{
			(closeVerseBuilder, closeVerseValue, parsingBuilder) = (parsingBuilder, parsingValue, closeVerseBuilder);
			converter.ChapterVerses(this);
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (v == ';')
		{
			(closeVerseBuilder, closeVerseValue, parsingBuilder) = (parsingBuilder, parsingValue, closeVerseBuilder);
			converter.ChapterVerses(this);
			converter.End(this);
			builder.Append(v);
			goto Prepare;
		}
		else if (v == ':')
		{
			(closeChapterBuilder, closeChapterValue, parsingBuilder) = (parsingBuilder, parsingValue, closeChapterBuilder);
			goto CloseVerseBefore;
		}
		else if (v == ',')
		{
			(closeVerseBuilder, closeVerseValue, parsingBuilder) = (parsingBuilder, parsingValue, closeVerseBuilder);
			converter.ChapterVerses(this);
			converter.Additional(this);
			parsingBuilder.Clear();
			parsingValue = 0;
			goto AdditionalBefore;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto CloseAfter;
		}
		else
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, ':');
			converter.Error(this, openVerseBuilder);
			converter.Error(this, '-');
			converter.Error(this, parsingBuilder);
			converter.Error(this, ' ');
			converter.Error(this, v);
			goto Error;
		}
	CloseVerseBefore:
		++offset;
		if (offset >= valueLength)
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, ':');
			converter.Error(this, openVerseBuilder);
			converter.Error(this, '-');
			converter.Error(this, closeChapterBuilder);
			converter.Error(this, ':');
			goto Error;
		}
		v = value[offset];
		if (char.IsDigit(v))
		{
			closeVerseBuilder.Append(v);
			closeVerseValue = v - '0';
			goto CloseVerse;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto CloseVerseBefore;
		}
		else
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, ':');
			converter.Error(this, openVerseBuilder);
			converter.Error(this, '-');
			converter.Error(this, closeChapterBuilder);
			converter.Error(this, ':');
			if (v == ';')
			{
				converter.End(this);
				builder.Append(v);
				goto Prepare;
			}
			else
			{
				converter.Error(this, v);
				goto Error;
			}
		}
	CloseVerse:
		++offset;
		if (offset >= valueLength)
		{
			converter.ChaptersVerses(this);
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (char.IsDigit(v))
		{
			closeVerseBuilder.Append(v);
			closeVerseValue = (10 * closeVerseValue) + (v - '0');
			goto CloseVerse;
		}
		else if (v == ';')
		{
			converter.ChaptersVerses(this);
			converter.End(this);
			builder.Append(v);
			goto Prepare;
		}
		else if (v == ',')
		{
			converter.ChaptersVerses(this);
			converter.Additional(this);
			openChapterBuilder.Clear();
			openChapterValue = 0;
			openVerseBuilder.Clear();
			openVerseValue = 0;
			closeChapterBuilder.Clear();
			closeChapterValue = 0;
			closeVerseBuilder.Clear();
			closeVerseValue = 0;
			parsingBuilder.Clear();
			parsingValue = 0;
			goto AdditionalBefore;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto CloseVerseAfter;
		}
		else
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, ':');
			converter.Error(this, openVerseBuilder);
			converter.Error(this, '-');
			converter.Error(this, closeChapterBuilder);
			converter.Error(this, ':');
			converter.Error(this, closeVerseBuilder);
			converter.Error(this, v);
			goto Error;
		}
	CloseVerseAfter:
		++offset;
		if (offset >= valueLength)
		{
			converter.ChaptersVerses(this);
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (v == ';')
		{
			converter.ChaptersVerses(this);
			converter.End(this);
			builder.Append(v);
			goto Prepare;
		}
		else if (v == ',')
		{
			converter.ChaptersVerses(this);
			converter.Additional(this);
			openChapterBuilder.Clear();
			openChapterValue = 0;
			openVerseBuilder.Clear();
			openVerseValue = 0;
			closeChapterBuilder.Clear();
			closeChapterValue = 0;
			closeVerseBuilder.Clear();
			closeVerseValue = 0;
			parsingBuilder.Clear();
			parsingValue = 0;
			goto AdditionalBefore;
		}
		else if (char.IsWhiteSpace(v))
		{
			goto CloseVerseAfter;
		}
		else
		{
			error = true;
			converter.Error(this, openChapterBuilder);
			converter.Error(this, ':');
			converter.Error(this, openVerseBuilder);
			converter.Error(this, '-');
			converter.Error(this, closeChapterBuilder);
			converter.Error(this, ':');
			converter.Error(this, closeVerseBuilder);
			converter.Error(this, ' ');
			converter.Error(this, v);
			goto Error;
		}
	Copy:
		++offset;
		if (offset >= valueLength)
		{
			goto Finish;
		}
		v = value[offset];
		if (v == ';')
		{
			builder.Append(v);
			goto Prepare;
		}
		else if (char.IsWhiteSpace(v))
		{
			if (!spaced)
			{
				builder.Append(' ');
				spaced = true;
			}
			goto Copy;
		}
		else
		{
			spaced = false;
			builder.Append(v);
			goto Copy;
		}
	Error:
		++offset;
		if (offset >= valueLength)
		{
			converter.End(this);
			goto Finish;
		}
		v = value[offset];
		if (v == ';')
		{
			converter.End(this);
			builder.Append(v);
			goto Prepare;
		}
		else if (char.IsWhiteSpace(v))
		{
			if (!spaced)
			{
				converter.Error(this, ' ');
				spaced = true;
			}
			goto Error;
		}
		else
		{
			spaced = false;
			converter.Error(this, v);
			goto Error;
		}
	Finish:
		var text = builder.ToString();
		builder.Clear();
		parsingBuilder.Clear();
		openChapterBuilder.Clear();
		openVerseBuilder.Clear();
		closeChapterBuilder.Clear();
		closeVerseBuilder.Clear();
		return text;
	}

	public void SetErrored()
	{
		error = true;
	}
}
