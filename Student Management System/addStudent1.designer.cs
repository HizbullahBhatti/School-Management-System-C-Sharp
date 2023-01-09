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

namespace Student_Management_System
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="StudentManagement")]
	public partial class addStudentDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertaddStudent(addStudent instance);
    partial void UpdateaddStudent(addStudent instance);
    partial void DeleteaddStudent(addStudent instance);
    #endregion
		
		public addStudentDataContext() : 
				base(global::Student_Management_System.Properties.Settings.Default.StudentManagementConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public addStudentDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public addStudentDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public addStudentDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public addStudentDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<addStudent> addStudents
		{
			get
			{
				return this.GetTable<addStudent>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.addStudent")]
	public partial class addStudent : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _roll_number;
		
		private string _first_name;
		
		private string _lastname;
		
		private string _password;
		
		private string _fathers_name;
		
		private string _caste;
		
		private string _religion;
		
		private string _gender;
		
		private string _dob;
		
		private string _guardians_no;
		
		private string _StudentClass;
		
		private string _place_of_birth;
		
		private string _guardians_CNIC;
		
		private string _nationality;
		
		private string _address;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onroll_numberChanging(string value);
    partial void Onroll_numberChanged();
    partial void Onfirst_nameChanging(string value);
    partial void Onfirst_nameChanged();
    partial void OnlastnameChanging(string value);
    partial void OnlastnameChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void Onfathers_nameChanging(string value);
    partial void Onfathers_nameChanged();
    partial void OncasteChanging(string value);
    partial void OncasteChanged();
    partial void OnreligionChanging(string value);
    partial void OnreligionChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OndobChanging(string value);
    partial void OndobChanged();
    partial void Onguardians_noChanging(string value);
    partial void Onguardians_noChanged();
    partial void OnStudentClassChanging(string value);
    partial void OnStudentClassChanged();
    partial void Onplace_of_birthChanging(string value);
    partial void Onplace_of_birthChanged();
    partial void Onguardians_CNICChanging(string value);
    partial void Onguardians_CNICChanged();
    partial void OnnationalityChanging(string value);
    partial void OnnationalityChanged();
    partial void OnaddressChanging(string value);
    partial void OnaddressChanged();
    #endregion
		
		public addStudent()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[roll number]", Storage="_roll_number", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string roll_number
		{
			get
			{
				return this._roll_number;
			}
			set
			{
				if ((this._roll_number != value))
				{
					this.Onroll_numberChanging(value);
					this.SendPropertyChanging();
					this._roll_number = value;
					this.SendPropertyChanged("roll_number");
					this.Onroll_numberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[first name]", Storage="_first_name", DbType="VarChar(50)")]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this.Onfirst_nameChanging(value);
					this.SendPropertyChanging();
					this._first_name = value;
					this.SendPropertyChanged("first_name");
					this.Onfirst_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastname", DbType="VarChar(50)")]
		public string lastname
		{
			get
			{
				return this._lastname;
			}
			set
			{
				if ((this._lastname != value))
				{
					this.OnlastnameChanging(value);
					this.SendPropertyChanging();
					this._lastname = value;
					this.SendPropertyChanged("lastname");
					this.OnlastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[fathers name]", Storage="_fathers_name", DbType="VarChar(50)")]
		public string fathers_name
		{
			get
			{
				return this._fathers_name;
			}
			set
			{
				if ((this._fathers_name != value))
				{
					this.Onfathers_nameChanging(value);
					this.SendPropertyChanging();
					this._fathers_name = value;
					this.SendPropertyChanged("fathers_name");
					this.Onfathers_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_caste", DbType="VarChar(50)")]
		public string caste
		{
			get
			{
				return this._caste;
			}
			set
			{
				if ((this._caste != value))
				{
					this.OncasteChanging(value);
					this.SendPropertyChanging();
					this._caste = value;
					this.SendPropertyChanged("caste");
					this.OncasteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_religion", DbType="VarChar(50)")]
		public string religion
		{
			get
			{
				return this._religion;
			}
			set
			{
				if ((this._religion != value))
				{
					this.OnreligionChanging(value);
					this.SendPropertyChanging();
					this._religion = value;
					this.SendPropertyChanged("religion");
					this.OnreligionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="VarChar(50)")]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dob", DbType="VarChar(50)")]
		public string dob
		{
			get
			{
				return this._dob;
			}
			set
			{
				if ((this._dob != value))
				{
					this.OndobChanging(value);
					this.SendPropertyChanging();
					this._dob = value;
					this.SendPropertyChanged("dob");
					this.OndobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[guardians no]", Storage="_guardians_no", DbType="VarChar(50)")]
		public string guardians_no
		{
			get
			{
				return this._guardians_no;
			}
			set
			{
				if ((this._guardians_no != value))
				{
					this.Onguardians_noChanging(value);
					this.SendPropertyChanging();
					this._guardians_no = value;
					this.SendPropertyChanged("guardians_no");
					this.Onguardians_noChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentClass", DbType="VarChar(50)")]
		public string StudentClass
		{
			get
			{
				return this._StudentClass;
			}
			set
			{
				if ((this._StudentClass != value))
				{
					this.OnStudentClassChanging(value);
					this.SendPropertyChanging();
					this._StudentClass = value;
					this.SendPropertyChanged("StudentClass");
					this.OnStudentClassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[place of birth]", Storage="_place_of_birth", DbType="VarChar(50)")]
		public string place_of_birth
		{
			get
			{
				return this._place_of_birth;
			}
			set
			{
				if ((this._place_of_birth != value))
				{
					this.Onplace_of_birthChanging(value);
					this.SendPropertyChanging();
					this._place_of_birth = value;
					this.SendPropertyChanged("place_of_birth");
					this.Onplace_of_birthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[guardians CNIC]", Storage="_guardians_CNIC", DbType="VarChar(50)")]
		public string guardians_CNIC
		{
			get
			{
				return this._guardians_CNIC;
			}
			set
			{
				if ((this._guardians_CNIC != value))
				{
					this.Onguardians_CNICChanging(value);
					this.SendPropertyChanging();
					this._guardians_CNIC = value;
					this.SendPropertyChanged("guardians_CNIC");
					this.Onguardians_CNICChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nationality", DbType="VarChar(50)")]
		public string nationality
		{
			get
			{
				return this._nationality;
			}
			set
			{
				if ((this._nationality != value))
				{
					this.OnnationalityChanging(value);
					this.SendPropertyChanging();
					this._nationality = value;
					this.SendPropertyChanged("nationality");
					this.OnnationalityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_address", DbType="VarChar(50)")]
		public string address
		{
			get
			{
				return this._address;
			}
			set
			{
				if ((this._address != value))
				{
					this.OnaddressChanging(value);
					this.SendPropertyChanging();
					this._address = value;
					this.SendPropertyChanged("address");
					this.OnaddressChanged();
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
