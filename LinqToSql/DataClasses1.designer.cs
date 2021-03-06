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

namespace LinqToSql
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LinqDataBase")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCar(Car instance);
    partial void UpdateCar(Car instance);
    partial void DeleteCar(Car instance);
    partial void InsertManufacturer(Manufacturer instance);
    partial void UpdateManufacturer(Manufacturer instance);
    partial void DeleteManufacturer(Manufacturer instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::LinqToSql.Properties.Settings.Default.LinqDataBaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Car> Cars
		{
			get
			{
				return this.GetTable<Car>();
			}
		}
		
		public System.Data.Linq.Table<Manufacturer> Manufacturers
		{
			get
			{
				return this.GetTable<Manufacturer>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Cars")]
	public partial class Car : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private System.Nullable<int> _Year;
		
		private string _Manufacturer;
		
		private string _Name;
		
		private System.Nullable<decimal> _Displacement;
		
		private System.Nullable<int> _Cylinders;
		
		private System.Nullable<int> _City;
		
		private System.Nullable<int> _Highway;
		
		private System.Nullable<int> _Combined;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnYearChanging(System.Nullable<int> value);
    partial void OnYearChanged();
    partial void OnManufacturerChanging(string value);
    partial void OnManufacturerChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDisplacementChanging(System.Nullable<decimal> value);
    partial void OnDisplacementChanged();
    partial void OnCylindersChanging(System.Nullable<int> value);
    partial void OnCylindersChanged();
    partial void OnCityChanging(System.Nullable<int> value);
    partial void OnCityChanged();
    partial void OnHighwayChanging(System.Nullable<int> value);
    partial void OnHighwayChanged();
    partial void OnCombinedChanging(System.Nullable<int> value);
    partial void OnCombinedChanged();
    #endregion
		
		public Car()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int")]
		public System.Nullable<int> Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Manufacturer", DbType="VarChar(50)")]
		public string Manufacturer
		{
			get
			{
				return this._Manufacturer;
			}
			set
			{
				if ((this._Manufacturer != value))
				{
					this.OnManufacturerChanging(value);
					this.SendPropertyChanging();
					this._Manufacturer = value;
					this.SendPropertyChanged("Manufacturer");
					this.OnManufacturerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(20)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Displacement", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Displacement
		{
			get
			{
				return this._Displacement;
			}
			set
			{
				if ((this._Displacement != value))
				{
					this.OnDisplacementChanging(value);
					this.SendPropertyChanging();
					this._Displacement = value;
					this.SendPropertyChanged("Displacement");
					this.OnDisplacementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cylinders", DbType="Int")]
		public System.Nullable<int> Cylinders
		{
			get
			{
				return this._Cylinders;
			}
			set
			{
				if ((this._Cylinders != value))
				{
					this.OnCylindersChanging(value);
					this.SendPropertyChanging();
					this._Cylinders = value;
					this.SendPropertyChanged("Cylinders");
					this.OnCylindersChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="Int")]
		public System.Nullable<int> City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Highway", DbType="Int")]
		public System.Nullable<int> Highway
		{
			get
			{
				return this._Highway;
			}
			set
			{
				if ((this._Highway != value))
				{
					this.OnHighwayChanging(value);
					this.SendPropertyChanging();
					this._Highway = value;
					this.SendPropertyChanged("Highway");
					this.OnHighwayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Combined", DbType="Int")]
		public System.Nullable<int> Combined
		{
			get
			{
				return this._Combined;
			}
			set
			{
				if ((this._Combined != value))
				{
					this.OnCombinedChanging(value);
					this.SendPropertyChanging();
					this._Combined = value;
					this.SendPropertyChanged("Combined");
					this.OnCombinedChanged();
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

		public static Car ParseFromCSV(string line)
		{
			var columns = line.Split(new string[] { ","},StringSplitOptions.None);
			return new Car
			{
				Year = int.Parse(columns[0]),
				Manufacturer = columns[1],
				Name = columns[2],
				Displacement = decimal.Parse(columns[3]),
				Cylinders = int.Parse(columns[4]),
				City = int.Parse(columns[5]),
				Highway = int.Parse(columns[6]),
				Combined = int.Parse(columns[7])


			};
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Table]")]
	public partial class Manufacturer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Headquarters;
		
		private System.Nullable<int> _Year;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnHeadquartersChanging(string value);
    partial void OnHeadquartersChanged();
    partial void OnYearChanging(System.Nullable<int> value);
    partial void OnYearChanged();
    #endregion
		
		public Manufacturer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(40)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Headquarters", DbType="VarChar(40)")]
		public string Headquarters
		{
			get
			{
				return this._Headquarters;
			}
			set
			{
				if ((this._Headquarters != value))
				{
					this.OnHeadquartersChanging(value);
					this.SendPropertyChanging();
					this._Headquarters = value;
					this.SendPropertyChanged("Headquarters");
					this.OnHeadquartersChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Year", DbType="Int")]
		public System.Nullable<int> Year
		{
			get
			{
				return this._Year;
			}
			set
			{
				if ((this._Year != value))
				{
					this.OnYearChanging(value);
					this.SendPropertyChanging();
					this._Year = value;
					this.SendPropertyChanged("Year");
					this.OnYearChanged();
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
