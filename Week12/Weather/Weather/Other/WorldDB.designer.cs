﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Weather.Other
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="World")]
	public partial class WorldDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcity(city instance);
    partial void Updatecity(city instance);
    partial void Deletecity(city instance);
    partial void Insertcountry(country instance);
    partial void Updatecountry(country instance);
    partial void Deletecountry(country instance);
    partial void Insertcountrylanguage(countrylanguage instance);
    partial void Updatecountrylanguage(countrylanguage instance);
    partial void Deletecountrylanguage(countrylanguage instance);
    #endregion
		
		public WorldDBDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WorldConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WorldDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WorldDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WorldDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WorldDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<city> cities
		{
			get
			{
				return this.GetTable<city>();
			}
		}
		
		public System.Data.Linq.Table<country> countries
		{
			get
			{
				return this.GetTable<country>();
			}
		}
		
		public System.Data.Linq.Table<countrylanguage> countrylanguages
		{
			get
			{
				return this.GetTable<countrylanguage>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.city")]
	public partial class city : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _CountryCode;
		
		private string _District;
		
		private int _Population;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnCountryCodeChanging(string value);
    partial void OnCountryCodeChanged();
    partial void OnDistrictChanging(string value);
    partial void OnDistrictChanged();
    partial void OnPopulationChanging(int value);
    partial void OnPopulationChanged();
    #endregion
		
		public city()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="Char(35) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryCode", DbType="Char(3) NOT NULL", CanBeNull=false)]
		public string CountryCode
		{
			get
			{
				return this._CountryCode;
			}
			set
			{
				if ((this._CountryCode != value))
				{
					this.OnCountryCodeChanging(value);
					this.SendPropertyChanging();
					this._CountryCode = value;
					this.SendPropertyChanged("CountryCode");
					this.OnCountryCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_District", DbType="Char(20) NOT NULL", CanBeNull=false)]
		public string District
		{
			get
			{
				return this._District;
			}
			set
			{
				if ((this._District != value))
				{
					this.OnDistrictChanging(value);
					this.SendPropertyChanging();
					this._District = value;
					this.SendPropertyChanged("District");
					this.OnDistrictChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Population", DbType="Int NOT NULL")]
		public int Population
		{
			get
			{
				return this._Population;
			}
			set
			{
				if ((this._Population != value))
				{
					this.OnPopulationChanging(value);
					this.SendPropertyChanging();
					this._Population = value;
					this.SendPropertyChanged("Population");
					this.OnPopulationChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.country")]
	public partial class country : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Code;
		
		private string _Name;
		
		private string _Continent;
		
		private string _Region;
		
		private decimal _SurfaceArea;
		
		private System.Nullable<short> _IndepYear;
		
		private int _Population;
		
		private System.Nullable<decimal> _LifeExpectancy;
		
		private System.Nullable<decimal> _GNP;
		
		private System.Nullable<decimal> _GNPOld;
		
		private string _LocalName;
		
		private string _GovernmentForm;
		
		private string _HeadOfState;
		
		private System.Nullable<int> _Capital;
		
		private string _Code2;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCodeChanging(string value);
    partial void OnCodeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnContinentChanging(string value);
    partial void OnContinentChanged();
    partial void OnRegionChanging(string value);
    partial void OnRegionChanged();
    partial void OnSurfaceAreaChanging(decimal value);
    partial void OnSurfaceAreaChanged();
    partial void OnIndepYearChanging(System.Nullable<short> value);
    partial void OnIndepYearChanged();
    partial void OnPopulationChanging(int value);
    partial void OnPopulationChanged();
    partial void OnLifeExpectancyChanging(System.Nullable<decimal> value);
    partial void OnLifeExpectancyChanged();
    partial void OnGNPChanging(System.Nullable<decimal> value);
    partial void OnGNPChanged();
    partial void OnGNPOldChanging(System.Nullable<decimal> value);
    partial void OnGNPOldChanged();
    partial void OnLocalNameChanging(string value);
    partial void OnLocalNameChanged();
    partial void OnGovernmentFormChanging(string value);
    partial void OnGovernmentFormChanged();
    partial void OnHeadOfStateChanging(string value);
    partial void OnHeadOfStateChanged();
    partial void OnCapitalChanging(System.Nullable<int> value);
    partial void OnCapitalChanged();
    partial void OnCode2Changing(string value);
    partial void OnCode2Changed();
    #endregion
		
		public country()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="Char(3) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="Char(52) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Continent", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Continent
		{
			get
			{
				return this._Continent;
			}
			set
			{
				if ((this._Continent != value))
				{
					this.OnContinentChanging(value);
					this.SendPropertyChanging();
					this._Continent = value;
					this.SendPropertyChanged("Continent");
					this.OnContinentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Region", DbType="Char(26) NOT NULL", CanBeNull=false)]
		public string Region
		{
			get
			{
				return this._Region;
			}
			set
			{
				if ((this._Region != value))
				{
					this.OnRegionChanging(value);
					this.SendPropertyChanging();
					this._Region = value;
					this.SendPropertyChanged("Region");
					this.OnRegionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SurfaceArea", DbType="Decimal(10,2) NOT NULL")]
		public decimal SurfaceArea
		{
			get
			{
				return this._SurfaceArea;
			}
			set
			{
				if ((this._SurfaceArea != value))
				{
					this.OnSurfaceAreaChanging(value);
					this.SendPropertyChanging();
					this._SurfaceArea = value;
					this.SendPropertyChanged("SurfaceArea");
					this.OnSurfaceAreaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IndepYear", DbType="SmallInt")]
		public System.Nullable<short> IndepYear
		{
			get
			{
				return this._IndepYear;
			}
			set
			{
				if ((this._IndepYear != value))
				{
					this.OnIndepYearChanging(value);
					this.SendPropertyChanging();
					this._IndepYear = value;
					this.SendPropertyChanged("IndepYear");
					this.OnIndepYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Population", DbType="Int NOT NULL")]
		public int Population
		{
			get
			{
				return this._Population;
			}
			set
			{
				if ((this._Population != value))
				{
					this.OnPopulationChanging(value);
					this.SendPropertyChanging();
					this._Population = value;
					this.SendPropertyChanged("Population");
					this.OnPopulationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LifeExpectancy", DbType="Decimal(3,1)")]
		public System.Nullable<decimal> LifeExpectancy
		{
			get
			{
				return this._LifeExpectancy;
			}
			set
			{
				if ((this._LifeExpectancy != value))
				{
					this.OnLifeExpectancyChanging(value);
					this.SendPropertyChanging();
					this._LifeExpectancy = value;
					this.SendPropertyChanged("LifeExpectancy");
					this.OnLifeExpectancyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GNP", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> GNP
		{
			get
			{
				return this._GNP;
			}
			set
			{
				if ((this._GNP != value))
				{
					this.OnGNPChanging(value);
					this.SendPropertyChanging();
					this._GNP = value;
					this.SendPropertyChanged("GNP");
					this.OnGNPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GNPOld", DbType="Decimal(10,2)")]
		public System.Nullable<decimal> GNPOld
		{
			get
			{
				return this._GNPOld;
			}
			set
			{
				if ((this._GNPOld != value))
				{
					this.OnGNPOldChanging(value);
					this.SendPropertyChanging();
					this._GNPOld = value;
					this.SendPropertyChanged("GNPOld");
					this.OnGNPOldChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LocalName", DbType="Char(45) NOT NULL", CanBeNull=false)]
		public string LocalName
		{
			get
			{
				return this._LocalName;
			}
			set
			{
				if ((this._LocalName != value))
				{
					this.OnLocalNameChanging(value);
					this.SendPropertyChanging();
					this._LocalName = value;
					this.SendPropertyChanged("LocalName");
					this.OnLocalNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GovernmentForm", DbType="Char(45) NOT NULL", CanBeNull=false)]
		public string GovernmentForm
		{
			get
			{
				return this._GovernmentForm;
			}
			set
			{
				if ((this._GovernmentForm != value))
				{
					this.OnGovernmentFormChanging(value);
					this.SendPropertyChanging();
					this._GovernmentForm = value;
					this.SendPropertyChanged("GovernmentForm");
					this.OnGovernmentFormChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HeadOfState", DbType="Char(60)")]
		public string HeadOfState
		{
			get
			{
				return this._HeadOfState;
			}
			set
			{
				if ((this._HeadOfState != value))
				{
					this.OnHeadOfStateChanging(value);
					this.SendPropertyChanging();
					this._HeadOfState = value;
					this.SendPropertyChanged("HeadOfState");
					this.OnHeadOfStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Capital", DbType="Int")]
		public System.Nullable<int> Capital
		{
			get
			{
				return this._Capital;
			}
			set
			{
				if ((this._Capital != value))
				{
					this.OnCapitalChanging(value);
					this.SendPropertyChanging();
					this._Capital = value;
					this.SendPropertyChanged("Capital");
					this.OnCapitalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code2", DbType="Char(2) NOT NULL", CanBeNull=false)]
		public string Code2
		{
			get
			{
				return this._Code2;
			}
			set
			{
				if ((this._Code2 != value))
				{
					this.OnCode2Changing(value);
					this.SendPropertyChanging();
					this._Code2 = value;
					this.SendPropertyChanged("Code2");
					this.OnCode2Changed();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.countrylanguage")]
	public partial class countrylanguage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CountryCode;
		
		private string _Language;
		
		private char _IsOfficial;
		
		private decimal _Percentage;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCountryCodeChanging(string value);
    partial void OnCountryCodeChanged();
    partial void OnLanguageChanging(string value);
    partial void OnLanguageChanged();
    partial void OnIsOfficialChanging(char value);
    partial void OnIsOfficialChanged();
    partial void OnPercentageChanging(decimal value);
    partial void OnPercentageChanged();
    #endregion
		
		public countrylanguage()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryCode", DbType="Char(3) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CountryCode
		{
			get
			{
				return this._CountryCode;
			}
			set
			{
				if ((this._CountryCode != value))
				{
					this.OnCountryCodeChanging(value);
					this.SendPropertyChanging();
					this._CountryCode = value;
					this.SendPropertyChanged("CountryCode");
					this.OnCountryCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Language", DbType="Char(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string Language
		{
			get
			{
				return this._Language;
			}
			set
			{
				if ((this._Language != value))
				{
					this.OnLanguageChanging(value);
					this.SendPropertyChanging();
					this._Language = value;
					this.SendPropertyChanged("Language");
					this.OnLanguageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsOfficial", DbType="Char(1) NOT NULL")]
		public char IsOfficial
		{
			get
			{
				return this._IsOfficial;
			}
			set
			{
				if ((this._IsOfficial != value))
				{
					this.OnIsOfficialChanging(value);
					this.SendPropertyChanging();
					this._IsOfficial = value;
					this.SendPropertyChanged("IsOfficial");
					this.OnIsOfficialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Percentage", DbType="Decimal(4,1) NOT NULL")]
		public decimal Percentage
		{
			get
			{
				return this._Percentage;
			}
			set
			{
				if ((this._Percentage != value))
				{
					this.OnPercentageChanging(value);
					this.SendPropertyChanging();
					this._Percentage = value;
					this.SendPropertyChanged("Percentage");
					this.OnPercentageChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
