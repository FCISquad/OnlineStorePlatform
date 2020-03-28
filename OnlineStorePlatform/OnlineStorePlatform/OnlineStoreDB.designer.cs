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

namespace OnlineStorePlatform
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="onlineStoreDB")]
	public partial class OnlineStoreDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public OnlineStoreDBDataContext() : 
				base(global::OnlineStorePlatform.Properties.Settings.Default.onlineStoreDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public OnlineStoreDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OnlineStoreDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OnlineStoreDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public OnlineStoreDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DB_User> DB_Users
		{
			get
			{
				return this.GetTable<DB_User>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DB_User")]
	public partial class DB_User
	{
		
		private int _BD_Id;
		
		private string _DB_Username;
		
		private string _DB_Email;
		
		private string _DB_Password;
		
		private int _DB_Type;
		
		private System.Nullable<int> _DB_Age;
		
		public DB_User()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BD_Id", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int BD_Id
		{
			get
			{
				return this._BD_Id;
			}
			set
			{
				if ((this._BD_Id != value))
				{
					this._BD_Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DB_Username", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DB_Username
		{
			get
			{
				return this._DB_Username;
			}
			set
			{
				if ((this._DB_Username != value))
				{
					this._DB_Username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DB_Email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DB_Email
		{
			get
			{
				return this._DB_Email;
			}
			set
			{
				if ((this._DB_Email != value))
				{
					this._DB_Email = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DB_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string DB_Password
		{
			get
			{
				return this._DB_Password;
			}
			set
			{
				if ((this._DB_Password != value))
				{
					this._DB_Password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DB_Type", DbType="Int NOT NULL")]
		public int DB_Type
		{
			get
			{
				return this._DB_Type;
			}
			set
			{
				if ((this._DB_Type != value))
				{
					this._DB_Type = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DB_Age", DbType="Int")]
		public System.Nullable<int> DB_Age
		{
			get
			{
				return this._DB_Age;
			}
			set
			{
				if ((this._DB_Age != value))
				{
					this._DB_Age = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
