﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/t4models).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

using LinqToDB;
using LinqToDB.Mapping;

namespace InformixDataContext
{
	/// <summary>
	/// Database       : TestData
	/// Data Source    : ol_informix1170
	/// Server Version : 11.70.0000 FC5DE
	/// </summary>
	public partial class TestDataDB : LinqToDB.Data.DataConnection
	{
		public ITable<alltype>      alltypes       { get { return this.GetTable<alltype>(); } }
		public ITable<child>        children       { get { return this.GetTable<child>(); } }
		public ITable<doctor>       doctors        { get { return this.GetTable<doctor>(); } }
		public ITable<grandchild>   grandchilds    { get { return this.GetTable<grandchild>(); } }
		public ITable<linqdatatype> linqdatatypes  { get { return this.GetTable<linqdatatype>(); } }
		public ITable<parent>       parents        { get { return this.GetTable<parent>(); } }
		public ITable<patient>      patients       { get { return this.GetTable<patient>(); } }
		public ITable<person>       people         { get { return this.GetTable<person>(); } }
		public ITable<personview>   personviews    { get { return this.GetTable<personview>(); } }
		public ITable<testfkunique> testfkuniques  { get { return this.GetTable<testfkunique>(); } }
		public ITable<testidentity> testidentities { get { return this.GetTable<testidentity>(); } }
		public ITable<testtable2>   testtable2     { get { return this.GetTable<testtable2>(); } }
		public ITable<testtable3>   testtable3     { get { return this.GetTable<testtable3>(); } }
		public ITable<testunique>   testuniques    { get { return this.GetTable<testunique>(); } }

		public TestDataDB()
		{
			InitDataContext();
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
		}

		partial void InitDataContext();
	}

	[Table("alltypes")]
	public partial class alltype
	{
		[PrimaryKey, Identity] public int       id               { get; set; } // SERIAL
		[Column,     Nullable] public long?     bigintdatatype   { get; set; } // BIGINT
		[Column,     Nullable] public long?     int8datatype     { get; set; } // INT8
		[Column,     Nullable] public int?      intdatatype      { get; set; } // INTEGER
		[Column,     Nullable] public short?    smallintdatatype { get; set; } // SMALLINT
		[Column,     Nullable] public decimal?  decimaldatatype  { get; set; } // DECIMAL
		[Column,     Nullable] public decimal?  moneydatatype    { get; set; } // MONEY(16,2)
		[Column,     Nullable] public float?    realdatatype     { get; set; } // SMALLFLOAT
		[Column,     Nullable] public double?   floatdatatype    { get; set; } // FLOAT
		[Column,     Nullable] public bool?     booldatatype     { get; set; } // BOOLEAN
		[Column,     Nullable] public char?     chardatatype     { get; set; } // CHAR(1)
		[Column,     Nullable] public string    varchardatatype  { get; set; } // VARCHAR(10)
		[Column,     Nullable] public string    nchardatatype    { get; set; } // NCHAR(10)
		[Column,     Nullable] public string    nvarchardatatype { get; set; } // NVARCHAR(10)
		[Column,     Nullable] public string    lvarchardatatype { get; set; } // LVARCHAR(10)
		[Column,     Nullable] public string    textdatatype     { get; set; } // TEXT
		[Column,     Nullable] public DateTime? datedatatype     { get; set; } // DATE
		[Column,     Nullable] public DateTime? datetimedatatype { get; set; } // DATETIME YEAR TO SECOND
		[Column,     Nullable] public TimeSpan? intervaldatatype { get; set; } // INTERVAL HOUR TO SECOND
		[Column,     Nullable] public byte[]    bytedatatype     { get; set; } // BYTE
	}

	[Table("child")]
	public partial class child
	{
		[Column, Nullable] public int? parentid { get; set; } // INTEGER
		[Column, Nullable] public int? childid  { get; set; } // INTEGER
	}

	[Table("doctor")]
	public partial class doctor
	{
		[Column, NotNull] public int    personid { get; set; } // INTEGER
		[Column, NotNull] public string taxonomy { get; set; } // NVARCHAR(50)

		#region Associations

		/// <summary>
		/// FK_doctor_person
		/// </summary>
		[Association(ThisKey="personid", OtherKey="personid", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_doctor_person", BackReferenceName="doctors")]
		public person person { get; set; }

		#endregion
	}

	[Table("grandchild")]
	public partial class grandchild
	{
		[Column, Nullable] public int? parentid     { get; set; } // INTEGER
		[Column, Nullable] public int? childid      { get; set; } // INTEGER
		[Column, Nullable] public int? grandchildid { get; set; } // INTEGER
	}

	[Table("linqdatatypes")]
	public partial class linqdatatype
	{
		[Column, Nullable] public int?      id             { get; set; } // INTEGER
		[Column, Nullable] public decimal?  moneyvalue     { get; set; } // DECIMAL(10,4)
		[Column, Nullable] public DateTime? datetimevalue  { get; set; } // DATETIME YEAR TO FRACTION(3)
		[Column, Nullable] public DateTime? datetimevalue2 { get; set; } // DATETIME YEAR TO FRACTION(3)
		[Column, Nullable] public bool?     boolvalue      { get; set; } // BOOLEAN
		[Column, Nullable] public string    guidvalue      { get; set; } // CHAR(36)
		[Column, Nullable] public byte[]    binaryvalue    { get; set; } // BYTE
		[Column, Nullable] public short?    smallintvalue  { get; set; } // SMALLINT
		[Column, Nullable] public int?      intvalue       { get; set; } // INTEGER
		[Column, Nullable] public long?     bigintvalue    { get; set; } // BIGINT
	}

	[Table("parent")]
	public partial class parent
	{
		[Column, Nullable] public int? parentid { get; set; } // INTEGER
		[Column, Nullable] public int? value1   { get; set; } // INTEGER
	}

	[Table("patient")]
	public partial class patient
	{
		[Column, NotNull] public int    personid  { get; set; } // INTEGER
		[Column, NotNull] public string diagnosis { get; set; } // NVARCHAR(100)
	}

	[Table("person")]
	public partial class person
	{
		[PrimaryKey, Identity   ] public int    personid   { get; set; } // SERIAL
		[Column,     NotNull    ] public string firstname  { get; set; } // NVARCHAR(50)
		[Column,     NotNull    ] public string lastname   { get; set; } // NVARCHAR(50)
		[Column,        Nullable] public string middlename { get; set; } // NVARCHAR(50)
		[Column,     NotNull    ] public char   gender     { get; set; } // CHAR(1)

		#region Associations

		/// <summary>
		/// FK_doctor_person_BackReference
		/// </summary>
		[Association(ThisKey="personid", OtherKey="personid", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<doctor> doctors { get; set; }

		#endregion
	}

	[Table("personview", IsView=true)]
	public partial class personview
	{
		[Identity             ] public int    personid   { get; set; } // SERIAL
		[Column,   NotNull    ] public string firstname  { get; set; } // NVARCHAR(50)
		[Column,   NotNull    ] public string lastname   { get; set; } // NVARCHAR(50)
		[Column,      Nullable] public string middlename { get; set; } // NVARCHAR(50)
		[Column,   NotNull    ] public char   gender     { get; set; } // CHAR(1)
	}

	[Table("testfkunique")]
	public partial class testfkunique
	{
		[Column, NotNull] public int id1 { get; set; } // INTEGER
		[Column, NotNull] public int id2 { get; set; } // INTEGER
		[Column, NotNull] public int id3 { get; set; } // INTEGER
		[Column, NotNull] public int id4 { get; set; } // INTEGER

		#region Associations

		/// <summary>
		/// FK_testfkunique_testunique
		/// </summary>
		[Association(ThisKey="id1, id2", OtherKey="id1, id2", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_testfkunique_testunique", BackReferenceName="testfkuniques")]
		public testunique testunique { get; set; }

		/// <summary>
		/// FK_testfkunique_testunique_1
		/// </summary>
		[Association(ThisKey="id3, id4", OtherKey="id3, id4", CanBeNull=false, Relationship=Relationship.ManyToOne, KeyName="FK_testfkunique_testunique_1", BackReferenceName="testfkunique1")]
		public testunique testunique1 { get; set; }

		#endregion
	}

	[Table("testidentity")]
	public partial class testidentity
	{
		[PrimaryKey, Identity] public int id { get; set; } // SERIAL
	}

	[Table("testtable2")]
	public partial class testtable2
	{
		[PrimaryKey, Identity   ] public int       id          { get; set; } // SERIAL
		[Column,     NotNull    ] public string    name        { get; set; } // NVARCHAR(50)
		[Column,        Nullable] public string    description { get; set; } // NVARCHAR(250)
		[Column,        Nullable] public DateTime? createdon   { get; set; } // DATETIME YEAR TO FRACTION(3)
	}

	[Table("testtable3")]
	public partial class testtable3
	{
		[PrimaryKey, NotNull] public int    id   { get; set; } // INTEGER
		[Column,     NotNull] public string name { get; set; } // NVARCHAR(50)
	}

	[Table("testunique")]
	public partial class testunique
	{
		[PrimaryKey(0), NotNull] public int id1 { get; set; } // INTEGER
		[PrimaryKey(1), NotNull] public int id2 { get; set; } // INTEGER
		[Column,        NotNull] public int id3 { get; set; } // INTEGER
		[Column,        NotNull] public int id4 { get; set; } // INTEGER

		#region Associations

		/// <summary>
		/// FK_testfkunique_testunique_BackReference
		/// </summary>
		[Association(ThisKey="id1, id2", OtherKey="id1, id2", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<testfkunique> testfkuniques { get; set; }

		/// <summary>
		/// FK_testfkunique_testunique_1_BackReference
		/// </summary>
		[Association(ThisKey="id3, id4", OtherKey="id3, id4", CanBeNull=true, Relationship=Relationship.OneToMany, IsBackReference=true)]
		public IEnumerable<testfkunique> testfkunique1 { get; set; }

		#endregion
	}

	public static partial class TableExtensions
	{
		public static alltype Find(this ITable<alltype> table, int id)
		{
			return table.FirstOrDefault(t =>
				t.id == id);
		}

		public static person Find(this ITable<person> table, int personid)
		{
			return table.FirstOrDefault(t =>
				t.personid == personid);
		}

		public static testidentity Find(this ITable<testidentity> table, int id)
		{
			return table.FirstOrDefault(t =>
				t.id == id);
		}

		public static testtable2 Find(this ITable<testtable2> table, int id)
		{
			return table.FirstOrDefault(t =>
				t.id == id);
		}

		public static testtable3 Find(this ITable<testtable3> table, int id)
		{
			return table.FirstOrDefault(t =>
				t.id == id);
		}

		public static testunique Find(this ITable<testunique> table, int id1, int id2)
		{
			return table.FirstOrDefault(t =>
				t.id1 == id1 &&
				t.id2 == id2);
		}
	}
}
