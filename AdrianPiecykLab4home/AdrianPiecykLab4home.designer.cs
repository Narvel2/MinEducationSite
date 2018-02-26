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

namespace AdrianPiecykLab4home
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AdrianPiecykLab4home")]
	public partial class AdrianPiecykLab4homeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertStudent(Student instance);
    partial void UpdateStudent(Student instance);
    partial void DeleteStudent(Student instance);
    partial void InsertPlace(Place instance);
    partial void UpdatePlace(Place instance);
    partial void DeletePlace(Place instance);
    partial void InsertLecturer(Lecturer instance);
    partial void UpdateLecturer(Lecturer instance);
    partial void DeleteLecturer(Lecturer instance);
    partial void InsertCourse(Course instance);
    partial void UpdateCourse(Course instance);
    partial void DeleteCourse(Course instance);
    partial void InsertEnrollment(Enrollment instance);
    partial void UpdateEnrollment(Enrollment instance);
    partial void DeleteEnrollment(Enrollment instance);
    #endregion
		
		public AdrianPiecykLab4homeDataContext() : 
				base(global::AdrianPiecykLab4home.Properties.Settings.Default.AdrianPiecykLab4homeConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AdrianPiecykLab4homeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AdrianPiecykLab4homeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AdrianPiecykLab4homeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AdrianPiecykLab4homeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Student> Students
		{
			get
			{
				return this.GetTable<Student>();
			}
		}
		
		public System.Data.Linq.Table<Place> Places
		{
			get
			{
				return this.GetTable<Place>();
			}
		}
		
		public System.Data.Linq.Table<Lecturer> Lecturers
		{
			get
			{
				return this.GetTable<Lecturer>();
			}
		}
		
		public System.Data.Linq.Table<Course> Courses
		{
			get
			{
				return this.GetTable<Course>();
			}
		}
		
		public System.Data.Linq.Table<Enrollment> Enrollments
		{
			get
			{
				return this.GetTable<Enrollment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Students")]
	public partial class Student : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Surname;
		
		private string _StudentNumber;
		
		private string _DateOfBirth;
		
		private string _PESEL;
		
		private string _Email;
		
		private string _NameOfMother;
		
		private string _NameOfFather;
		
		private string _Sex;
		
		private string _PlaceOfResistance;
		
		private string _NumberOfHouse;
		
		private string _Voivodeship;
		
		private string _Street;
		
		private EntitySet<Enrollment> _Enrollments;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnStudentNumberChanging(string value);
    partial void OnStudentNumberChanged();
    partial void OnDateOfBirthChanging(string value);
    partial void OnDateOfBirthChanged();
    partial void OnPESELChanging(string value);
    partial void OnPESELChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnNameOfMotherChanging(string value);
    partial void OnNameOfMotherChanged();
    partial void OnNameOfFatherChanging(string value);
    partial void OnNameOfFatherChanged();
    partial void OnSexChanging(string value);
    partial void OnSexChanged();
    partial void OnPlaceOfResistanceChanging(string value);
    partial void OnPlaceOfResistanceChanged();
    partial void OnNumberOfHouseChanging(string value);
    partial void OnNumberOfHouseChanged();
    partial void OnVoivodeshipChanging(string value);
    partial void OnVoivodeshipChanged();
    partial void OnStreetChanging(string value);
    partial void OnStreetChanged();
    #endregion
		
		public Student()
		{
			this._Enrollments = new EntitySet<Enrollment>(new Action<Enrollment>(this.attach_Enrollments), new Action<Enrollment>(this.detach_Enrollments));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NVarChar(50)")]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentNumber", DbType="NVarChar(50)")]
		public string StudentNumber
		{
			get
			{
				return this._StudentNumber;
			}
			set
			{
				if ((this._StudentNumber != value))
				{
					this.OnStudentNumberChanging(value);
					this.SendPropertyChanging();
					this._StudentNumber = value;
					this.SendPropertyChanged("StudentNumber");
					this.OnStudentNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateOfBirth", DbType="NVarChar(50)")]
		public string DateOfBirth
		{
			get
			{
				return this._DateOfBirth;
			}
			set
			{
				if ((this._DateOfBirth != value))
				{
					this.OnDateOfBirthChanging(value);
					this.SendPropertyChanging();
					this._DateOfBirth = value;
					this.SendPropertyChanged("DateOfBirth");
					this.OnDateOfBirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PESEL", DbType="NVarChar(50)")]
		public string PESEL
		{
			get
			{
				return this._PESEL;
			}
			set
			{
				if ((this._PESEL != value))
				{
					this.OnPESELChanging(value);
					this.SendPropertyChanging();
					this._PESEL = value;
					this.SendPropertyChanged("PESEL");
					this.OnPESELChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameOfMother", DbType="NVarChar(50)")]
		public string NameOfMother
		{
			get
			{
				return this._NameOfMother;
			}
			set
			{
				if ((this._NameOfMother != value))
				{
					this.OnNameOfMotherChanging(value);
					this.SendPropertyChanging();
					this._NameOfMother = value;
					this.SendPropertyChanged("NameOfMother");
					this.OnNameOfMotherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameOfFather", DbType="NVarChar(50)")]
		public string NameOfFather
		{
			get
			{
				return this._NameOfFather;
			}
			set
			{
				if ((this._NameOfFather != value))
				{
					this.OnNameOfFatherChanging(value);
					this.SendPropertyChanging();
					this._NameOfFather = value;
					this.SendPropertyChanged("NameOfFather");
					this.OnNameOfFatherChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sex", DbType="NVarChar(50)")]
		public string Sex
		{
			get
			{
				return this._Sex;
			}
			set
			{
				if ((this._Sex != value))
				{
					this.OnSexChanging(value);
					this.SendPropertyChanging();
					this._Sex = value;
					this.SendPropertyChanged("Sex");
					this.OnSexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlaceOfResistance", DbType="NVarChar(50)")]
		public string PlaceOfResistance
		{
			get
			{
				return this._PlaceOfResistance;
			}
			set
			{
				if ((this._PlaceOfResistance != value))
				{
					this.OnPlaceOfResistanceChanging(value);
					this.SendPropertyChanging();
					this._PlaceOfResistance = value;
					this.SendPropertyChanged("PlaceOfResistance");
					this.OnPlaceOfResistanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumberOfHouse", DbType="NVarChar(50)")]
		public string NumberOfHouse
		{
			get
			{
				return this._NumberOfHouse;
			}
			set
			{
				if ((this._NumberOfHouse != value))
				{
					this.OnNumberOfHouseChanging(value);
					this.SendPropertyChanging();
					this._NumberOfHouse = value;
					this.SendPropertyChanged("NumberOfHouse");
					this.OnNumberOfHouseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Voivodeship", DbType="NVarChar(50)")]
		public string Voivodeship
		{
			get
			{
				return this._Voivodeship;
			}
			set
			{
				if ((this._Voivodeship != value))
				{
					this.OnVoivodeshipChanging(value);
					this.SendPropertyChanging();
					this._Voivodeship = value;
					this.SendPropertyChanged("Voivodeship");
					this.OnVoivodeshipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Street", DbType="NVarChar(50)")]
		public string Street
		{
			get
			{
				return this._Street;
			}
			set
			{
				if ((this._Street != value))
				{
					this.OnStreetChanging(value);
					this.SendPropertyChanging();
					this._Street = value;
					this.SendPropertyChanged("Street");
					this.OnStreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Enrollment", Storage="_Enrollments", ThisKey="ID", OtherKey="StudentID")]
		public EntitySet<Enrollment> Enrollments
		{
			get
			{
				return this._Enrollments;
			}
			set
			{
				this._Enrollments.Assign(value);
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
		
		private void attach_Enrollments(Enrollment entity)
		{
			this.SendPropertyChanging();
			entity.Student = this;
		}
		
		private void detach_Enrollments(Enrollment entity)
		{
			this.SendPropertyChanging();
			entity.Student = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Places")]
	public partial class Place : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Building;
		
		private string _RoomNumber;
		
		private EntitySet<Course> _Courses;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnBuildingChanging(string value);
    partial void OnBuildingChanged();
    partial void OnRoomNumberChanging(string value);
    partial void OnRoomNumberChanged();
    #endregion
		
		public Place()
		{
			this._Courses = new EntitySet<Course>(new Action<Course>(this.attach_Courses), new Action<Course>(this.detach_Courses));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Building", DbType="NVarChar(50)")]
		public string Building
		{
			get
			{
				return this._Building;
			}
			set
			{
				if ((this._Building != value))
				{
					this.OnBuildingChanging(value);
					this.SendPropertyChanging();
					this._Building = value;
					this.SendPropertyChanged("Building");
					this.OnBuildingChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomNumber", DbType="NVarChar(50)")]
		public string RoomNumber
		{
			get
			{
				return this._RoomNumber;
			}
			set
			{
				if ((this._RoomNumber != value))
				{
					this.OnRoomNumberChanging(value);
					this.SendPropertyChanging();
					this._RoomNumber = value;
					this.SendPropertyChanged("RoomNumber");
					this.OnRoomNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Place_Course", Storage="_Courses", ThisKey="ID", OtherKey="PlacesID")]
		public EntitySet<Course> Courses
		{
			get
			{
				return this._Courses;
			}
			set
			{
				this._Courses.Assign(value);
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
		
		private void attach_Courses(Course entity)
		{
			this.SendPropertyChanging();
			entity.Place = this;
		}
		
		private void detach_Courses(Course entity)
		{
			this.SendPropertyChanging();
			entity.Place = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Lecturers")]
	public partial class Lecturer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Surname;
		
		private string _Degree;
		
		private EntitySet<Course> _Courses;
		
		private EntitySet<Enrollment> _Enrollments;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnDegreeChanging(string value);
    partial void OnDegreeChanged();
    #endregion
		
		public Lecturer()
		{
			this._Courses = new EntitySet<Course>(new Action<Course>(this.attach_Courses), new Action<Course>(this.detach_Courses));
			this._Enrollments = new EntitySet<Enrollment>(new Action<Enrollment>(this.attach_Enrollments), new Action<Enrollment>(this.detach_Enrollments));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NVarChar(50)")]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Degree", DbType="NVarChar(50)")]
		public string Degree
		{
			get
			{
				return this._Degree;
			}
			set
			{
				if ((this._Degree != value))
				{
					this.OnDegreeChanging(value);
					this.SendPropertyChanging();
					this._Degree = value;
					this.SendPropertyChanged("Degree");
					this.OnDegreeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lecturer_Course", Storage="_Courses", ThisKey="ID", OtherKey="LecturersID")]
		public EntitySet<Course> Courses
		{
			get
			{
				return this._Courses;
			}
			set
			{
				this._Courses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lecturer_Enrollment", Storage="_Enrollments", ThisKey="ID", OtherKey="LecturersID")]
		public EntitySet<Enrollment> Enrollments
		{
			get
			{
				return this._Enrollments;
			}
			set
			{
				this._Enrollments.Assign(value);
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
		
		private void attach_Courses(Course entity)
		{
			this.SendPropertyChanging();
			entity.Lecturer = this;
		}
		
		private void detach_Courses(Course entity)
		{
			this.SendPropertyChanging();
			entity.Lecturer = null;
		}
		
		private void attach_Enrollments(Enrollment entity)
		{
			this.SendPropertyChanging();
			entity.Lecturer = this;
		}
		
		private void detach_Enrollments(Enrollment entity)
		{
			this.SendPropertyChanging();
			entity.Lecturer = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Courses")]
	public partial class Course : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _NameOfCourse;
		
		private System.Nullable<int> _ECTSPoints;
		
		private System.Nullable<int> _CourseHours;
		
		private System.Nullable<int> _LecturersID;
		
		private System.Nullable<int> _PlacesID;
		
		private EntitySet<Enrollment> _Enrollments;
		
		private EntityRef<Lecturer> _Lecturer;
		
		private EntityRef<Place> _Place;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameOfCourseChanging(string value);
    partial void OnNameOfCourseChanged();
    partial void OnECTSPointsChanging(System.Nullable<int> value);
    partial void OnECTSPointsChanged();
    partial void OnCourseHoursChanging(System.Nullable<int> value);
    partial void OnCourseHoursChanged();
    partial void OnLecturersIDChanging(System.Nullable<int> value);
    partial void OnLecturersIDChanged();
    partial void OnPlacesIDChanging(System.Nullable<int> value);
    partial void OnPlacesIDChanged();
    #endregion
		
		public Course()
		{
			this._Enrollments = new EntitySet<Enrollment>(new Action<Enrollment>(this.attach_Enrollments), new Action<Enrollment>(this.detach_Enrollments));
			this._Lecturer = default(EntityRef<Lecturer>);
			this._Place = default(EntityRef<Place>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameOfCourse", DbType="NVarChar(50)")]
		public string NameOfCourse
		{
			get
			{
				return this._NameOfCourse;
			}
			set
			{
				if ((this._NameOfCourse != value))
				{
					this.OnNameOfCourseChanging(value);
					this.SendPropertyChanging();
					this._NameOfCourse = value;
					this.SendPropertyChanged("NameOfCourse");
					this.OnNameOfCourseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ECTSPoints", DbType="Int")]
		public System.Nullable<int> ECTSPoints
		{
			get
			{
				return this._ECTSPoints;
			}
			set
			{
				if ((this._ECTSPoints != value))
				{
					this.OnECTSPointsChanging(value);
					this.SendPropertyChanging();
					this._ECTSPoints = value;
					this.SendPropertyChanged("ECTSPoints");
					this.OnECTSPointsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CourseHours", DbType="Int")]
		public System.Nullable<int> CourseHours
		{
			get
			{
				return this._CourseHours;
			}
			set
			{
				if ((this._CourseHours != value))
				{
					this.OnCourseHoursChanging(value);
					this.SendPropertyChanging();
					this._CourseHours = value;
					this.SendPropertyChanged("CourseHours");
					this.OnCourseHoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LecturersID", DbType="Int")]
		public System.Nullable<int> LecturersID
		{
			get
			{
				return this._LecturersID;
			}
			set
			{
				if ((this._LecturersID != value))
				{
					if (this._Lecturer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLecturersIDChanging(value);
					this.SendPropertyChanging();
					this._LecturersID = value;
					this.SendPropertyChanged("LecturersID");
					this.OnLecturersIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlacesID", DbType="Int")]
		public System.Nullable<int> PlacesID
		{
			get
			{
				return this._PlacesID;
			}
			set
			{
				if ((this._PlacesID != value))
				{
					if (this._Place.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnPlacesIDChanging(value);
					this.SendPropertyChanging();
					this._PlacesID = value;
					this.SendPropertyChanged("PlacesID");
					this.OnPlacesIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Enrollment", Storage="_Enrollments", ThisKey="ID", OtherKey="CoursesID")]
		public EntitySet<Enrollment> Enrollments
		{
			get
			{
				return this._Enrollments;
			}
			set
			{
				this._Enrollments.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lecturer_Course", Storage="_Lecturer", ThisKey="LecturersID", OtherKey="ID", IsForeignKey=true)]
		public Lecturer Lecturer
		{
			get
			{
				return this._Lecturer.Entity;
			}
			set
			{
				Lecturer previousValue = this._Lecturer.Entity;
				if (((previousValue != value) 
							|| (this._Lecturer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Lecturer.Entity = null;
						previousValue.Courses.Remove(this);
					}
					this._Lecturer.Entity = value;
					if ((value != null))
					{
						value.Courses.Add(this);
						this._LecturersID = value.ID;
					}
					else
					{
						this._LecturersID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Lecturer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Place_Course", Storage="_Place", ThisKey="PlacesID", OtherKey="ID", IsForeignKey=true)]
		public Place Place
		{
			get
			{
				return this._Place.Entity;
			}
			set
			{
				Place previousValue = this._Place.Entity;
				if (((previousValue != value) 
							|| (this._Place.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Place.Entity = null;
						previousValue.Courses.Remove(this);
					}
					this._Place.Entity = value;
					if ((value != null))
					{
						value.Courses.Add(this);
						this._PlacesID = value.ID;
					}
					else
					{
						this._PlacesID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Place");
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
		
		private void attach_Enrollments(Enrollment entity)
		{
			this.SendPropertyChanging();
			entity.Course = this;
		}
		
		private void detach_Enrollments(Enrollment entity)
		{
			this.SendPropertyChanging();
			entity.Course = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Enrollment")]
	public partial class Enrollment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Data;
		
		private System.Nullable<int> _StudentID;
		
		private System.Nullable<int> _CoursesID;
		
		private System.Nullable<int> _LecturersID;
		
		private EntityRef<Enrollment> _Enrollment2;
		
		private EntityRef<Course> _Course;
		
		private EntityRef<Enrollment> _Enrollment1;
		
		private EntityRef<Lecturer> _Lecturer;
		
		private EntityRef<Student> _Student;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDataChanging(string value);
    partial void OnDataChanged();
    partial void OnStudentIDChanging(System.Nullable<int> value);
    partial void OnStudentIDChanged();
    partial void OnCoursesIDChanging(System.Nullable<int> value);
    partial void OnCoursesIDChanged();
    partial void OnLecturersIDChanging(System.Nullable<int> value);
    partial void OnLecturersIDChanged();
    #endregion
		
		public Enrollment()
		{
			this._Enrollment2 = default(EntityRef<Enrollment>);
			this._Course = default(EntityRef<Course>);
			this._Enrollment1 = default(EntityRef<Enrollment>);
			this._Lecturer = default(EntityRef<Lecturer>);
			this._Student = default(EntityRef<Student>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
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
					if (this._Enrollment1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Data", DbType="NVarChar(50)")]
		public string Data
		{
			get
			{
				return this._Data;
			}
			set
			{
				if ((this._Data != value))
				{
					this.OnDataChanging(value);
					this.SendPropertyChanging();
					this._Data = value;
					this.SendPropertyChanged("Data");
					this.OnDataChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StudentID", DbType="Int")]
		public System.Nullable<int> StudentID
		{
			get
			{
				return this._StudentID;
			}
			set
			{
				if ((this._StudentID != value))
				{
					if (this._Student.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnStudentIDChanging(value);
					this.SendPropertyChanging();
					this._StudentID = value;
					this.SendPropertyChanged("StudentID");
					this.OnStudentIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CoursesID", DbType="Int")]
		public System.Nullable<int> CoursesID
		{
			get
			{
				return this._CoursesID;
			}
			set
			{
				if ((this._CoursesID != value))
				{
					if (this._Course.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCoursesIDChanging(value);
					this.SendPropertyChanging();
					this._CoursesID = value;
					this.SendPropertyChanged("CoursesID");
					this.OnCoursesIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LecturersID", DbType="Int")]
		public System.Nullable<int> LecturersID
		{
			get
			{
				return this._LecturersID;
			}
			set
			{
				if ((this._LecturersID != value))
				{
					if (this._Lecturer.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnLecturersIDChanging(value);
					this.SendPropertyChanging();
					this._LecturersID = value;
					this.SendPropertyChanged("LecturersID");
					this.OnLecturersIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Enrollment_Enrollment", Storage="_Enrollment2", ThisKey="ID", OtherKey="ID", IsUnique=true, IsForeignKey=false)]
		public Enrollment Enrollment2
		{
			get
			{
				return this._Enrollment2.Entity;
			}
			set
			{
				Enrollment previousValue = this._Enrollment2.Entity;
				if (((previousValue != value) 
							|| (this._Enrollment2.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Enrollment2.Entity = null;
						previousValue.Enrollment1 = null;
					}
					this._Enrollment2.Entity = value;
					if ((value != null))
					{
						value.Enrollment1 = this;
					}
					this.SendPropertyChanged("Enrollment2");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Course_Enrollment", Storage="_Course", ThisKey="CoursesID", OtherKey="ID", IsForeignKey=true)]
		public Course Course
		{
			get
			{
				return this._Course.Entity;
			}
			set
			{
				Course previousValue = this._Course.Entity;
				if (((previousValue != value) 
							|| (this._Course.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Course.Entity = null;
						previousValue.Enrollments.Remove(this);
					}
					this._Course.Entity = value;
					if ((value != null))
					{
						value.Enrollments.Add(this);
						this._CoursesID = value.ID;
					}
					else
					{
						this._CoursesID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Course");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Enrollment_Enrollment", Storage="_Enrollment1", ThisKey="ID", OtherKey="ID", IsForeignKey=true)]
		public Enrollment Enrollment1
		{
			get
			{
				return this._Enrollment1.Entity;
			}
			set
			{
				Enrollment previousValue = this._Enrollment1.Entity;
				if (((previousValue != value) 
							|| (this._Enrollment1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Enrollment1.Entity = null;
						previousValue.Enrollment2 = null;
					}
					this._Enrollment1.Entity = value;
					if ((value != null))
					{
						value.Enrollment2 = this;
						this._ID = value.ID;
					}
					else
					{
						this._ID = default(int);
					}
					this.SendPropertyChanged("Enrollment1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Lecturer_Enrollment", Storage="_Lecturer", ThisKey="LecturersID", OtherKey="ID", IsForeignKey=true)]
		public Lecturer Lecturer
		{
			get
			{
				return this._Lecturer.Entity;
			}
			set
			{
				Lecturer previousValue = this._Lecturer.Entity;
				if (((previousValue != value) 
							|| (this._Lecturer.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Lecturer.Entity = null;
						previousValue.Enrollments.Remove(this);
					}
					this._Lecturer.Entity = value;
					if ((value != null))
					{
						value.Enrollments.Add(this);
						this._LecturersID = value.ID;
					}
					else
					{
						this._LecturersID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Lecturer");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Student_Enrollment", Storage="_Student", ThisKey="StudentID", OtherKey="ID", IsForeignKey=true)]
		public Student Student
		{
			get
			{
				return this._Student.Entity;
			}
			set
			{
				Student previousValue = this._Student.Entity;
				if (((previousValue != value) 
							|| (this._Student.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Student.Entity = null;
						previousValue.Enrollments.Remove(this);
					}
					this._Student.Entity = value;
					if ((value != null))
					{
						value.Enrollments.Add(this);
						this._StudentID = value.ID;
					}
					else
					{
						this._StudentID = default(Nullable<int>);
					}
					this.SendPropertyChanged("Student");
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