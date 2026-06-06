using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using static System.Reflection.Metadata.BlobBuilder;

namespace SeekingYHWH.Scriptures;

public sealed class Options
{
	public const string DefaultDirection = "L";
	public const string DefaultConvert = "A";

	public const string DefaultLDSBoM = "S";
	public const string DefaultLDSBoMPre = "(LDS ";
	public const string DefaultLDSBoMCenter = ")(RLDS ";
	public const string DefaultLDSBoMPost = ")";

	public const string DefaultLDSDnCSourcePre = "(LDS ";
	public const string DefaultLDSDnCSourcePost = ")";
	public const string DefaultLDSDnCOthersPre = "(";
	public const string DefaultLDSDnCOthersPost = ")";
	public const bool DefaultLDSDnC1833 = false;
	public const bool DefaultLDSDnC1835 = false;
	public const bool DefaultLDSDnC1844 = false;

	public const string DefaultRLDSBoM = "S";
	public const string DefaultRLDSBoMPre = "(RLDS ";
	public const string DefaultRLDSBoMCenter = ")(LDS ";
	public const string DefaultRLDSBoMPost = ")";

	public const string DefaultRLDSDnCSourcePre = "(RLDS ";
	public const string DefaultRLDSDnCSourcePost = ")";
	public const string DefaultRLDSDnCOthersPre = "(";
	public const string DefaultRLDSDnCOthersPost = ")";
	public const bool DefaultRLDSDnC1833 = false;
	public const bool DefaultRLDSDnC1835 = false;
	public const bool DefaultRLDSDnC1844 = false;

	private string? direction;
	private string? directionPrev;

	private string? convert;
	private string? convertPrev;

	private string? ldsBoM;
	private string? ldsBoMPrev;
	private string? ldsBoMPre;
	private string? ldsBoMPrePrev;
	private string? ldsBoMCenter;
	private string? ldsBoMCenterPrev;
	private string? ldsBoMPost;
	private string? ldsBoMPostPrev;

	private string? ldsDnCSourcePre;
	private string? ldsDnCSourcePrePrev;
	private string? ldsDnCSourcePost;
	private string? ldsDnCSourcePostPrev;
	private string? ldsDnCOthersPre;
	private string? ldsDnCOthersPrePrev;
	private string? ldsDnCOthersPost;
	private string? ldsDnCOthersPostPrev;
	private bool ldsDnC1833;
	private bool ldsDnC1833Prev;
	private bool ldsDnC1835;
	private bool ldsDnC1835Prev;
	private bool ldsDnC1844;
	private bool ldsDnC1844Prev;

	private string? rldsBoM;
	private string? rldsBoMPrev;
	private string? rldsBoMPre;
	private string? rldsBoMPrePrev;
	private string? rldsBoMCenter;
	private string? rldsBoMCenterPrev;
	private string? rldsBoMPost;
	private string? rldsBoMPostPrev;

	private string? rldsDnCSourcePre;
	private string? rldsDnCSourcePrePrev;
	private string? rldsDnCSourcePost;
	private string? rldsDnCSourcePostPrev;
	private string? rldsDnCOthersPre;
	private string? rldsDnCOthersPrePrev;
	private string? rldsDnCOthersPost;
	private string? rldsDnCOthersPostPrev;
	private bool rldsDnC1833;
	private bool rldsDnC1833Prev;
	private bool rldsDnC1835;
	private bool rldsDnC1835Prev;
	private bool rldsDnC1844;
	private bool rldsDnC1844Prev;

	public Options()
	{
	}

	public string? Direction { get =>  direction; set => direction = value; }

	public string? DirectionPrev { get => directionPrev; set => directionPrev = value; }

	public bool DirectionLDS
	{
		get => direction == "L";
		set
		{
			if (!value)
			{
				return;
			}
			direction = "L";
		}
	}

	public bool DirectionRLDS
	{
		get => direction == "R";
		set
		{
			if (!value)
			{
				return;
			}
			direction = "R";
		}
	}

	public string? Convert { get => convert; set => convert = value; }

	public bool ConvertNever
	{
		get => convert == "N";
		set
		{
			if (!value)
			{
				return;
			}
			convert = "N";
		}
	}

	public bool ConvertAlways
	{
		get => convert == "A";
		set
		{
			if (!value)
			{
				return;
			}
			convert = "A";
		}
	}

	public bool ConvertSuccess
	{
		get => convert == "S";
		set
		{
			if (!value)
			{
				return;
			}
			convert = "S";
		}
	}

	public string? LDSBoM { get => ldsBoM; set => ldsBoM = value; }

	public bool LDSBoMS
	{
		get => ldsBoM == "S";
		set
		{
			if (!value)
			{
				return;
			}
			ldsBoM = "S";
		}
	}

	public bool LDSBoMO
	{
		get => ldsBoM == "O";
		set
		{
			if (!value)
			{
				return;
			}
			ldsBoM = "O";
		}
	}

	public bool LDSBoMN
	{
		get => ldsBoM == "N";
		set
		{
			if (!value)
			{
				return;
			}
			ldsBoM = "N";
		}
	}

	public string? LDSBoMPre { get => ldsBoMPre; set => ldsBoMPre = value; }

	public string? LDSBoMCenter { get => ldsBoMCenter; set => ldsBoMCenter = value; }

	public string? LDSBoMPost { get => ldsBoMPost; set => ldsBoMPost = value; }

	public string? LDSDnCSourcePre { get => ldsDnCSourcePre; set => ldsDnCSourcePre = value; }

	public string? LDSDnCSourcePost { get => ldsDnCSourcePost; set => ldsDnCSourcePost = value; }

	public string? LDSDnCOthersPre { get => ldsDnCOthersPre; set => ldsDnCOthersPre = value; }

	public string? LDSDnCOthersPost { get => ldsDnCOthersPost; set => ldsDnCOthersPost = value; }

	public bool LDSDnC1833 { get => ldsDnC1833; set => ldsDnC1833 = value; }

	public bool LDSDnC1835 { get => ldsDnC1835; set => ldsDnC1835 = value; }

	public bool LDSDnC1844 { get => ldsDnC1844; set => ldsDnC1844 = value; }

	public string? RLDSBoM { get => rldsBoM; set => rldsBoM = value; }

	public bool RLDSBoMS
	{
		get => rldsBoM == "S";
		set
		{
			if (!value)
			{
				return;
			}
			rldsBoM = "S";
		}
	}

	public bool RLDSBoMO
	{
		get => rldsBoM == "O";
		set
		{
			if (!value)
			{
				return;
			}
			rldsBoM = "O";
		}
	}

	public bool RLDSBoMN
	{
		get => rldsBoM == "N";
		set
		{
			if (!value)
			{
				return;
			}
			rldsBoM = "N";
		}
	}

	public string? RLDSBoMPre { get => rldsBoMPre; set => rldsBoMPre = value; }

	public string? RLDSBoMCenter { get => rldsBoMCenter; set => rldsBoMCenter = value; }

	public string? RLDSBoMPost { get => rldsBoMPost; set => rldsBoMPost = value; }

	public string? RLDSDnCSourcePre { get => rldsDnCSourcePre; set => rldsDnCSourcePre = value; }

	public string? RLDSDnCSourcePost { get => rldsDnCSourcePost; set => rldsDnCSourcePost = value; }

	public string? RLDSDnCOthersPre { get => rldsDnCOthersPre; set => rldsDnCOthersPre = value; }

	public string? RLDSDnCOthersPost { get => rldsDnCOthersPost; set => rldsDnCOthersPost = value; }

	public bool RLDSDnC1833 { get => rldsDnC1833; set => rldsDnC1833 = value; }

	public bool RLDSDnC1835 { get => rldsDnC1835; set => rldsDnC1835 = value; }

	public bool RLDSDnC1844 { get => rldsDnC1844; set => rldsDnC1844 = value; }

	public bool Changed
	{
		get
		{
			return
				direction != directionPrev ||
				convert != convertPrev ||
				ldsBoM != ldsBoMPrev ||
				ldsBoMPre != ldsBoMPrePrev ||
				ldsBoMCenter != ldsBoMCenterPrev ||
				ldsBoMPost != ldsBoMPostPrev ||
				ldsDnCSourcePre != ldsDnCSourcePrePrev ||
				ldsDnCSourcePost != ldsDnCSourcePostPrev ||
				ldsDnCOthersPre != ldsDnCOthersPrePrev ||
				ldsDnCOthersPost != ldsDnCOthersPostPrev ||
				ldsDnC1833 != ldsDnC1833Prev ||
				ldsDnC1835 != ldsDnC1835Prev ||
				ldsDnC1844 != ldsDnC1844Prev ||
				rldsBoM != rldsBoMPrev ||
				rldsBoMPre != rldsBoMPrePrev ||
				rldsBoMCenter != rldsBoMCenterPrev ||
				rldsBoMPost != rldsBoMPostPrev ||
				rldsDnCSourcePre != rldsDnCSourcePrePrev ||
				rldsDnCSourcePost != rldsDnCSourcePostPrev ||
				rldsDnCOthersPre != rldsDnCOthersPrePrev ||
				rldsDnCOthersPost != rldsDnCOthersPostPrev ||
				rldsDnC1833 != rldsDnC1833Prev ||
				rldsDnC1835 != rldsDnC1835Prev ||
				rldsDnC1844 != rldsDnC1844Prev;
		}
	}

	public void ClearChanged()
	{
		directionPrev = direction;
		convertPrev = convert;
		ldsBoMPrev = ldsBoM;
		ldsBoMPrePrev = ldsBoMPre;
		ldsBoMCenterPrev = ldsBoMCenter;
		ldsBoMPostPrev = ldsBoMPost;
		ldsDnCSourcePrePrev = ldsDnCSourcePre;
		ldsDnCSourcePostPrev = ldsDnCSourcePost;
		ldsDnCOthersPrePrev = ldsDnCOthersPre;
		ldsDnCOthersPostPrev = ldsDnCOthersPost;
		ldsDnC1833Prev = ldsDnC1833;
		ldsDnC1835Prev = ldsDnC1835;
		ldsDnC1844Prev = ldsDnC1844;
		rldsBoMPrev = rldsBoM;
		rldsBoMPrePrev = rldsBoMPre;
		rldsBoMCenterPrev = rldsBoMCenter;
		rldsBoMPostPrev = rldsBoMPost;
		rldsDnCSourcePrePrev = rldsDnCSourcePre;
		rldsDnCSourcePostPrev = rldsDnCSourcePost;
		rldsDnCOthersPrePrev = rldsDnCOthersPre;
		rldsDnCOthersPostPrev = rldsDnCOthersPost;
		rldsDnC1833Prev = rldsDnC1833;
		rldsDnC1835Prev = rldsDnC1835;
		rldsDnC1844Prev = rldsDnC1844;
	}

	public void Read(string path)
	{
		//Defaults
		direction = DefaultDirection;
		convert = DefaultConvert;

		//LDS BoM
		ldsBoM = DefaultLDSBoM;
		ldsBoMPre = DefaultLDSBoMPre;
		ldsBoMCenter = DefaultLDSBoMCenter;
		ldsBoMPost = DefaultLDSBoMPost;

		//LDS DnC
		ldsDnCSourcePre = DefaultLDSDnCSourcePre;
		ldsDnCSourcePost = DefaultLDSDnCSourcePost;
		ldsDnCOthersPre = DefaultLDSDnCOthersPre;
		ldsDnCOthersPost = DefaultLDSDnCOthersPost;
		ldsDnC1833 = DefaultLDSDnC1833;
		ldsDnC1835 = DefaultLDSDnC1835;
		ldsDnC1844 = DefaultLDSDnC1844;

		//RLDS BoM
		rldsBoM = DefaultRLDSBoM;
		rldsBoMPre = DefaultRLDSBoMPre;
		rldsBoMCenter = DefaultRLDSBoMCenter;
		rldsBoMPost = DefaultRLDSBoMPost;

		//RLDS DnC
		rldsDnCSourcePre = DefaultRLDSDnCSourcePre;
		rldsDnCSourcePost = DefaultRLDSDnCSourcePost;
		rldsDnCOthersPre = DefaultRLDSDnCOthersPre;
		rldsDnCOthersPost = DefaultRLDSDnCOthersPost;
		rldsDnC1833 = DefaultRLDSDnC1833;
		rldsDnC1835 = DefaultRLDSDnC1835;
		rldsDnC1844 = DefaultRLDSDnC1844;

		//Read
		var readerStream = (FileStream?)null;
		var reader = (StreamReader?)null;
		string? line;
		string?[] columns;
		try
		{
			readerStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
			reader = new StreamReader(readerStream, Encoding.UTF8);

			line = reader.ReadLine();
			switch (line)
			{
			case "L":
			case "l":
				direction = "L";
				break;

			case "R":
			case "r":
				direction = "R";
				break;

			default:
				direction = DefaultDirection;
				break;
			}

			line = reader.ReadLine();
			switch (line)
			{
			case "N":
			case "n":
				convert = "N";
				break;

			case "A":
			case "a":
				convert = "A";
				break;

			case "S":
			case "s":
				convert = "S";
				break;

			default:
				convert = DefaultConvert;
				break;
			}

			//LDS BoM
			line = reader.ReadLine();
			columns = line.Split('\t');
			try
			{
				switch (columns[0])
				{
				case "S":
				case "s":
					ldsBoM = "S";
					ldsBoMPre = DefaultLDSBoMPre;
					ldsBoMCenter = DefaultLDSBoMCenter;
					ldsBoMPost = DefaultLDSBoMPost;
					ldsBoMPre = columns[1];
					ldsBoMCenter = columns[2];
					ldsBoMPost = columns[3];
					break;

				case "O":
				case "o":
					ldsBoM = "O";
					ldsBoMPre = "(RLDS ";
					ldsBoMCenter = ")(LDS ";
					ldsBoMPost = ")";
					ldsBoMPre = columns[1];
					ldsBoMCenter = columns[2];
					ldsBoMPost = columns[3];
					break;

				case "N":
				case "n":
					ldsBoM = "N";
					ldsBoMPre = null;
					ldsBoMCenter = null;
					ldsBoMPost = null;
					ldsBoMPre = columns[1];
					ldsBoMPost = columns[2];
					break;

				default:
					ldsBoM = DefaultLDSBoM;
					ldsBoMPre = DefaultLDSBoMPre;
					ldsBoMCenter = DefaultLDSBoMCenter;
					ldsBoMPost = DefaultLDSBoMPost;
					break;
				}
			}
			catch
			{
				//Nothing on purpose
			}

			//LDS DnC
			line = reader.ReadLine();
			columns = line.Split('\t');
			try
			{
				ldsDnCSourcePre = columns[0];
				ldsDnCSourcePost = columns[1];
				ldsDnCOthersPre = columns[2];
				ldsDnCOthersPost = columns[3];
				ldsDnC1833 = columns[4] == "1";
				ldsDnC1835 = columns[5] == "1";
				ldsDnC1844 = columns[6] == "1";
			}
			catch
			{
				//Nothing on purpose
			}

			//RLDS BoM
			line = reader.ReadLine();
			columns = line.Split('\t');
			try
			{
				switch (columns[0])
				{
				case "S":
				case "s":
					rldsBoM = "S";
					rldsBoMPre = DefaultRLDSBoMPre;
					rldsBoMCenter = DefaultRLDSBoMCenter;
					rldsBoMPost = DefaultRLDSBoMPost;
					rldsBoMPre = columns[1];
					rldsBoMCenter = columns[2];
					rldsBoMPost = columns[3];
					break;

				case "O":
				case "o":
					rldsBoM = "O";
					rldsBoMPre = "(LDS ";
					rldsBoMCenter = ")(RLDS ";
					rldsBoMPost = ")";
					rldsBoMPre = columns[1];
					rldsBoMCenter = columns[2];
					rldsBoMPost = columns[3];
					break;

				case "N":
				case "n":
					rldsBoM = "N";
					rldsBoMPre = null;
					rldsBoMCenter = null;
					rldsBoMPost = null;
					rldsBoMPre = columns[1];
					rldsBoMPost = columns[2];
					break;

				default:
					rldsBoM = DefaultRLDSBoM;
					rldsBoMPre = DefaultRLDSBoMPre;
					rldsBoMCenter = DefaultRLDSBoMCenter;
					rldsBoMPost = DefaultRLDSBoMPost;
					break;
				}
			}
			catch
			{
				//Nothing on purpose
			}

			//RLDS DnC
			line = reader.ReadLine();
			columns = line.Split('\t');
			try
			{
				rldsDnCSourcePre = columns[0];
				rldsDnCSourcePost = columns[1];
				rldsDnCOthersPre = columns[2];
				rldsDnCOthersPost = columns[3];
				rldsDnC1833 = columns[4] == "1";
				rldsDnC1835 = columns[5] == "1";
				rldsDnC1844 = columns[6] == "1";
			}
			catch
			{
				//Nothing on purpose
			}
		}
		catch
		{
			//Nothing on purpose
		}
		finally
		{
			reader?.Dispose();
			readerStream?.Dispose();
		}
	}

	public void SetInitialize(PassagesConverter converter, Dictionary<string, BookConverter> lds, Dictionary<string, BookConverter> rlds)
	{
		SetInitializeLDSBoM(converter, lds);
		SetInitializeLDSDnC(converter, lds);
		SetInitializeRLDSBoM(converter, rlds);
		SetInitializeRLDSDnC(converter, rlds);
	}

	public void SetInitializeChanged(PassagesConverter converter, Dictionary<string, BookConverter> lds, Dictionary<string, BookConverter> rlds)
	{
		if (ldsBoM != ldsBoMPrev ||
			ldsBoMPre != ldsBoMPrePrev || ldsBoMCenter != ldsBoMCenterPrev || ldsBoMPost != ldsBoMPostPrev)
		{
			SetInitializeLDSBoM(converter, lds);
		}
		if (ldsDnCSourcePre != ldsDnCSourcePrePrev || ldsDnCSourcePost != ldsDnCSourcePostPrev ||
			ldsDnCOthersPre != ldsDnCOthersPrePrev || ldsDnCOthersPost != ldsDnCOthersPostPrev ||
			ldsDnC1833 != ldsDnC1833Prev || ldsDnC1835 != ldsDnC1835Prev || ldsDnC1844 != ldsDnC1844Prev)
		{
			SetInitializeLDSDnC(converter, lds);
		}
		if (rldsBoM != ldsBoMPrev ||
			ldsBoMPre != ldsBoMPrePrev || ldsBoMCenter != ldsBoMCenterPrev || ldsBoMPost != ldsBoMPostPrev)
		{
			SetInitializeRLDSBoM(converter, rlds);
		}
		if (rldsDnCSourcePre != rldsDnCSourcePrePrev || rldsDnCSourcePost != rldsDnCSourcePostPrev ||
			rldsDnCOthersPre != rldsDnCOthersPrePrev || rldsDnCOthersPost != rldsDnCOthersPostPrev ||
			rldsDnC1833 != rldsDnC1833Prev || rldsDnC1835 != rldsDnC1835Prev || rldsDnC1844 != rldsDnC1844Prev)
		{
			SetInitializeRLDSDnC(converter, lds);
		}
	}

	private void SetInitializeLDSBoM(PassagesConverter converter, Dictionary<string, BookConverter> books)
	{
		switch (ldsBoM)
		{
		case "S":
		case "s":
		default:
			SourceOtherVersesConverter.SetInitialize(converter, books, BoMLDS.Books, ldsBoMPre, ldsBoMCenter, ldsBoMPost);
			break;

		case "O":
		case "o":
			OtherSourceVersesConverter.SetInitialize(converter, books, BoMLDS.Books, ldsBoMPre, ldsBoMCenter, ldsBoMPost);
			break;

		case "N":
		case "n":
			NewVersesConverter.SetInitialize(converter, books, BoMLDS.Books, ldsBoMPre, ldsBoMPost);
			break;
		}
	}

	private void SetInitializeLDSDnC(PassagesConverter converter, Dictionary<string, BookConverter> books)
	{
		DnCLDS.SetAddInitialize(converter, books, true, ldsDnC1833, ldsDnC1835, ldsDnC1844);
	}

	private void SetInitializeRLDSBoM(PassagesConverter converter, Dictionary<string, BookConverter> books)
	{
		switch (rldsBoM)
		{
		case "S":
		case "s":
		default:
			SourceOtherVersesConverter.SetInitialize(converter, books, BoMRLDS.Books, rldsBoMPre, rldsBoMCenter, rldsBoMPost);
			break;

		case "O":
		case "o":
			OtherSourceVersesConverter.SetInitialize(converter, books, BoMRLDS.Books, rldsBoMPre, rldsBoMCenter, rldsBoMPost);
			break;

		case "N":
		case "n":
			NewVersesConverter.SetInitialize(converter, books, BoMRLDS.Books, rldsBoMPre, rldsBoMPost);
			break;
		}
	}

	private void SetInitializeRLDSDnC(PassagesConverter converter, Dictionary<string, BookConverter> books)
	{
		DnCRLDS.SetAddInitialize(converter, books, true, rldsDnC1833, rldsDnC1835, rldsDnC1844);
	}

	public void Write(string path)
	{
		var writerStream = (FileStream?)null;
		var writer = (StreamWriter?)null;
		try
		{
			writerStream = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Read);
			writer = new StreamWriter(writerStream, Encoding.UTF8);

			writer.WriteLine(direction);
			writer.WriteLine(convert);

			//LDS BoM
			writer.Write(ldsBoM);
			switch (ldsBoM)
			{
			case "S":
			case "s":
			case "O":
			case "o":
			default:
				writer.Write('\t');
				writer.Write(ldsBoMPre);
				writer.Write('\t');
				writer.Write(ldsBoMCenter);
				writer.Write('\t');
				writer.Write(ldsBoMPost);
				break;

			case "N":
			case "n":
				writer.Write('\t');
				writer.Write(ldsBoMPre);
				writer.Write('\t');
				writer.Write(ldsBoMPost);
				break;
			}
			writer.WriteLine();

			//LDS DnC
			writer.Write(ldsDnCSourcePre);
			writer.Write('\t');
			writer.Write(ldsDnCSourcePost);
			writer.Write('\t');
			writer.Write(ldsDnCOthersPre);
			writer.Write('\t');
			writer.Write(ldsDnCOthersPost);
			writer.Write('\t');
			if (ldsDnC1833)
			{
				writer.Write('1');
			}
			else
			{
				writer.Write('0');
			}
			writer.Write('\t');
			if (ldsDnC1835)
			{
				writer.Write('1');
			}
			else
			{
				writer.Write('0');
			}
			writer.Write('\t');
			if (ldsDnC1844)
			{
				writer.Write('1');
			}
			else
			{
				writer.Write('0');
			}
			writer.WriteLine();

			//RLDS BoM
			writer.Write(rldsBoM);
			switch (rldsBoM)
			{
			case "S":
			case "s":
			case "O":
			case "o":
			default:
				writer.Write('\t');
				writer.Write(rldsBoMPre);
				writer.Write('\t');
				writer.Write(rldsBoMCenter);
				writer.Write('\t');
				writer.Write(rldsBoMPost);
				break;

			case "N":
			case "n":
				writer.Write('\t');
				writer.Write(rldsBoMPre);
				writer.Write('\t');
				writer.Write(rldsBoMPost);
				break;
			}
			writer.WriteLine();

			//RLDS DnC
			writer.Write(rldsDnCSourcePre);
			writer.Write('\t');
			writer.Write(rldsDnCSourcePost);
			writer.Write('\t');
			writer.Write(rldsDnCOthersPre);
			writer.Write('\t');
			writer.Write(rldsDnCOthersPost);
			writer.Write('\t');
			if (rldsDnC1833)
			{
				writer.Write('1');
			}
			else
			{
				writer.Write('0');
			}
			writer.Write('\t');
			if (rldsDnC1835)
			{
				writer.Write('1');
			}
			else
			{
				writer.Write('0');
			}
			writer.Write('\t');
			if (rldsDnC1844)
			{
				writer.Write('1');
			}
			else
			{
				writer.Write('0');
			}
			writer.WriteLine();
		}
		catch
		{
			//Nothing on Purpose
		}
		finally
		{
			writer?.Dispose();
			writerStream?.Dispose();
		}
	}
}
