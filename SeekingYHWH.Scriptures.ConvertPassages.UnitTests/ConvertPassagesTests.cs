namespace SeekingYHWH.Scriptures;

public class ConvertPassagesTests
{
	[Fact]
	public void Test1()
	{
		var books = PassagesConverter.CreateBooksEmpty();
		NewVersesConverter.Set(books, BoMLDS.Books, null, null);
		DnCLDS.SetAdd(books);
		var converter = new PassagesConverter(books);
		converter.Initialize();
		var passage = "1 Nephi 1:1;Words of Mormon 1:2;D&C 1:1";
		var expected = "1 Nephi 1:1;Words of Mormon 1:2-3;D&C (LDS 1:1)(RLDS 1)(1833 1)(1835 1)(1844 1)";
		var actual = converter.Convert(passage);
		Assert.False(converter.Error);
		Assert.Equal(expected, actual);
	}

	[Fact]
	public void CopyTest()
	{
		var books = PassagesConverter.CreateBooksEmpty();
		var converter = new PassagesConverter(books);
		converter.Initialize();
		var passage = "John 1:1";
		var expected = "John 1:1";
		var actual = converter.Convert(passage);
		Assert.False(converter.Error);
		Assert.Equal(expected, actual);
	}

	[Fact]
	public void ChapterTest()
	{
		var books = PassagesConverter.CreateBooksEmpty();
		NewVersesConverter.Set(books, BoMLDS.Books, null, null);
		DnCLDS.SetAdd(books);
		var converter = new PassagesConverter(books);
		converter.Initialize();
		var passage = "1 Nephi 1;Alma 13";
		var expected = "1 Nephi 1:1-23;Alma 9:62-10:31";
		var actual = converter.Convert(passage);
		Assert.False(converter.Error);
		Assert.Equal(expected, actual);
	}
}