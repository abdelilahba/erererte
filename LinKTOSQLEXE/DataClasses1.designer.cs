﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinKTOSQLEXE
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Garage")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Définitions de méthodes d'extensibilité
    partial void OnCreated();
    partial void InsertGarage(Garage instance);
    partial void UpdateGarage(Garage instance);
    partial void DeleteGarage(Garage instance);
    partial void InsertPiece(Piece instance);
    partial void UpdatePiece(Piece instance);
    partial void DeletePiece(Piece instance);
    partial void InsertReparation(Reparation instance);
    partial void UpdateReparation(Reparation instance);
    partial void DeleteReparation(Reparation instance);
    partial void Insertutilise(utilise instance);
    partial void Updateutilise(utilise instance);
    partial void Deleteutilise(utilise instance);
    partial void Insertvoiture(voiture instance);
    partial void Updatevoiture(voiture instance);
    partial void Deletevoiture(voiture instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::LinKTOSQLEXE.Properties.Settings.Default.GarageConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Garage> Garage
		{
			get
			{
				return this.GetTable<Garage>();
			}
		}
		
		public System.Data.Linq.Table<Piece> Piece
		{
			get
			{
				return this.GetTable<Piece>();
			}
		}
		
		public System.Data.Linq.Table<Reparation> Reparation
		{
			get
			{
				return this.GetTable<Reparation>();
			}
		}
		
		public System.Data.Linq.Table<utilise> utilise
		{
			get
			{
				return this.GetTable<utilise>();
			}
		}
		
		public System.Data.Linq.Table<voiture> voiture
		{
			get
			{
				return this.GetTable<voiture>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Garage")]
	public partial class Garage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _idgarage;
		
		private string _nomGarage;
		
		private EntitySet<Reparation> _Reparation;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidgarageChanging(long value);
    partial void OnidgarageChanged();
    partial void OnnomGarageChanging(string value);
    partial void OnnomGarageChanged();
    #endregion
		
		public Garage()
		{
			this._Reparation = new EntitySet<Reparation>(new Action<Reparation>(this.attach_Reparation), new Action<Reparation>(this.detach_Reparation));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idgarage", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long idgarage
		{
			get
			{
				return this._idgarage;
			}
			set
			{
				if ((this._idgarage != value))
				{
					this.OnidgarageChanging(value);
					this.SendPropertyChanging();
					this._idgarage = value;
					this.SendPropertyChanged("idgarage");
					this.OnidgarageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nomGarage", DbType="VarChar(MAX)")]
		public string nomGarage
		{
			get
			{
				return this._nomGarage;
			}
			set
			{
				if ((this._nomGarage != value))
				{
					this.OnnomGarageChanging(value);
					this.SendPropertyChanging();
					this._nomGarage = value;
					this.SendPropertyChanged("nomGarage");
					this.OnnomGarageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Garage_Reparation", Storage="_Reparation", ThisKey="idgarage", OtherKey="idGarage")]
		public EntitySet<Reparation> Reparation
		{
			get
			{
				return this._Reparation;
			}
			set
			{
				this._Reparation.Assign(value);
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
		
		private void attach_Reparation(Reparation entity)
		{
			this.SendPropertyChanging();
			entity.Garage = this;
		}
		
		private void detach_Reparation(Reparation entity)
		{
			this.SendPropertyChanging();
			entity.Garage = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Piece")]
	public partial class Piece : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _idPiece;
		
		private string _NomPiece;
		
		private System.Nullable<decimal> _PrixPiece;
		
		private EntitySet<utilise> _utilise;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidPieceChanging(long value);
    partial void OnidPieceChanged();
    partial void OnNomPieceChanging(string value);
    partial void OnNomPieceChanged();
    partial void OnPrixPieceChanging(System.Nullable<decimal> value);
    partial void OnPrixPieceChanged();
    #endregion
		
		public Piece()
		{
			this._utilise = new EntitySet<utilise>(new Action<utilise>(this.attach_utilise), new Action<utilise>(this.detach_utilise));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idPiece", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long idPiece
		{
			get
			{
				return this._idPiece;
			}
			set
			{
				if ((this._idPiece != value))
				{
					this.OnidPieceChanging(value);
					this.SendPropertyChanging();
					this._idPiece = value;
					this.SendPropertyChanged("idPiece");
					this.OnidPieceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NomPiece", DbType="VarChar(100)")]
		public string NomPiece
		{
			get
			{
				return this._NomPiece;
			}
			set
			{
				if ((this._NomPiece != value))
				{
					this.OnNomPieceChanging(value);
					this.SendPropertyChanging();
					this._NomPiece = value;
					this.SendPropertyChanged("NomPiece");
					this.OnNomPieceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrixPiece", DbType="Money")]
		public System.Nullable<decimal> PrixPiece
		{
			get
			{
				return this._PrixPiece;
			}
			set
			{
				if ((this._PrixPiece != value))
				{
					this.OnPrixPieceChanging(value);
					this.SendPropertyChanging();
					this._PrixPiece = value;
					this.SendPropertyChanged("PrixPiece");
					this.OnPrixPieceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Piece_utilise", Storage="_utilise", ThisKey="idPiece", OtherKey="idPiece")]
		public EntitySet<utilise> utilise
		{
			get
			{
				return this._utilise;
			}
			set
			{
				this._utilise.Assign(value);
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
		
		private void attach_utilise(utilise entity)
		{
			this.SendPropertyChanging();
			entity.Piece = this;
		}
		
		private void detach_utilise(utilise entity)
		{
			this.SendPropertyChanging();
			entity.Piece = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Reparation")]
	public partial class Reparation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _idReparation;
		
		private System.Nullable<System.DateTime> _dateReparation;
		
		private System.Nullable<decimal> _PrixReparation;
		
		private System.Nullable<long> _idGarage;
		
		private string _immatricule;
		
		private EntitySet<utilise> _utilise;
		
		private EntityRef<Garage> _Garage;
		
		private EntityRef<voiture> _voiture;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidReparationChanging(long value);
    partial void OnidReparationChanged();
    partial void OndateReparationChanging(System.Nullable<System.DateTime> value);
    partial void OndateReparationChanged();
    partial void OnPrixReparationChanging(System.Nullable<decimal> value);
    partial void OnPrixReparationChanged();
    partial void OnidGarageChanging(System.Nullable<long> value);
    partial void OnidGarageChanged();
    partial void OnimmatriculeChanging(string value);
    partial void OnimmatriculeChanged();
    #endregion
		
		public Reparation()
		{
			this._utilise = new EntitySet<utilise>(new Action<utilise>(this.attach_utilise), new Action<utilise>(this.detach_utilise));
			this._Garage = default(EntityRef<Garage>);
			this._voiture = default(EntityRef<voiture>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idReparation", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long idReparation
		{
			get
			{
				return this._idReparation;
			}
			set
			{
				if ((this._idReparation != value))
				{
					this.OnidReparationChanging(value);
					this.SendPropertyChanging();
					this._idReparation = value;
					this.SendPropertyChanged("idReparation");
					this.OnidReparationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateReparation", DbType="Date")]
		public System.Nullable<System.DateTime> dateReparation
		{
			get
			{
				return this._dateReparation;
			}
			set
			{
				if ((this._dateReparation != value))
				{
					this.OndateReparationChanging(value);
					this.SendPropertyChanging();
					this._dateReparation = value;
					this.SendPropertyChanged("dateReparation");
					this.OndateReparationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PrixReparation", DbType="Money")]
		public System.Nullable<decimal> PrixReparation
		{
			get
			{
				return this._PrixReparation;
			}
			set
			{
				if ((this._PrixReparation != value))
				{
					this.OnPrixReparationChanging(value);
					this.SendPropertyChanging();
					this._PrixReparation = value;
					this.SendPropertyChanged("PrixReparation");
					this.OnPrixReparationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idGarage", DbType="BigInt")]
		public System.Nullable<long> idGarage
		{
			get
			{
				return this._idGarage;
			}
			set
			{
				if ((this._idGarage != value))
				{
					if (this._Garage.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidGarageChanging(value);
					this.SendPropertyChanging();
					this._idGarage = value;
					this.SendPropertyChanged("idGarage");
					this.OnidGarageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_immatricule", DbType="VarChar(20)")]
		public string immatricule
		{
			get
			{
				return this._immatricule;
			}
			set
			{
				if ((this._immatricule != value))
				{
					if (this._voiture.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnimmatriculeChanging(value);
					this.SendPropertyChanging();
					this._immatricule = value;
					this.SendPropertyChanged("immatricule");
					this.OnimmatriculeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Reparation_utilise", Storage="_utilise", ThisKey="idReparation", OtherKey="idReparation")]
		public EntitySet<utilise> utilise
		{
			get
			{
				return this._utilise;
			}
			set
			{
				this._utilise.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Garage_Reparation", Storage="_Garage", ThisKey="idGarage", OtherKey="idgarage", IsForeignKey=true)]
		public Garage Garage
		{
			get
			{
				return this._Garage.Entity;
			}
			set
			{
				Garage previousValue = this._Garage.Entity;
				if (((previousValue != value) 
							|| (this._Garage.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Garage.Entity = null;
						previousValue.Reparation.Remove(this);
					}
					this._Garage.Entity = value;
					if ((value != null))
					{
						value.Reparation.Add(this);
						this._idGarage = value.idgarage;
					}
					else
					{
						this._idGarage = default(Nullable<long>);
					}
					this.SendPropertyChanged("Garage");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="voiture_Reparation", Storage="_voiture", ThisKey="immatricule", OtherKey="immatricule", IsForeignKey=true)]
		public voiture voiture
		{
			get
			{
				return this._voiture.Entity;
			}
			set
			{
				voiture previousValue = this._voiture.Entity;
				if (((previousValue != value) 
							|| (this._voiture.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._voiture.Entity = null;
						previousValue.Reparation.Remove(this);
					}
					this._voiture.Entity = value;
					if ((value != null))
					{
						value.Reparation.Add(this);
						this._immatricule = value.immatricule;
					}
					else
					{
						this._immatricule = default(string);
					}
					this.SendPropertyChanged("voiture");
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
		
		private void attach_utilise(utilise entity)
		{
			this.SendPropertyChanging();
			entity.Reparation = this;
		}
		
		private void detach_utilise(utilise entity)
		{
			this.SendPropertyChanging();
			entity.Reparation = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.utilise")]
	public partial class utilise : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _idReparation;
		
		private long _idPiece;
		
		private System.Nullable<int> _qte;
		
		private EntityRef<Piece> _Piece;
		
		private EntityRef<Reparation> _Reparation;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidReparationChanging(long value);
    partial void OnidReparationChanged();
    partial void OnidPieceChanging(long value);
    partial void OnidPieceChanged();
    partial void OnqteChanging(System.Nullable<int> value);
    partial void OnqteChanged();
    #endregion
		
		public utilise()
		{
			this._Piece = default(EntityRef<Piece>);
			this._Reparation = default(EntityRef<Reparation>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idReparation", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long idReparation
		{
			get
			{
				return this._idReparation;
			}
			set
			{
				if ((this._idReparation != value))
				{
					if (this._Reparation.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidReparationChanging(value);
					this.SendPropertyChanging();
					this._idReparation = value;
					this.SendPropertyChanged("idReparation");
					this.OnidReparationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idPiece", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long idPiece
		{
			get
			{
				return this._idPiece;
			}
			set
			{
				if ((this._idPiece != value))
				{
					if (this._Piece.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidPieceChanging(value);
					this.SendPropertyChanging();
					this._idPiece = value;
					this.SendPropertyChanged("idPiece");
					this.OnidPieceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qte", DbType="Int")]
		public System.Nullable<int> qte
		{
			get
			{
				return this._qte;
			}
			set
			{
				if ((this._qte != value))
				{
					this.OnqteChanging(value);
					this.SendPropertyChanging();
					this._qte = value;
					this.SendPropertyChanged("qte");
					this.OnqteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Piece_utilise", Storage="_Piece", ThisKey="idPiece", OtherKey="idPiece", IsForeignKey=true)]
		public Piece Piece
		{
			get
			{
				return this._Piece.Entity;
			}
			set
			{
				Piece previousValue = this._Piece.Entity;
				if (((previousValue != value) 
							|| (this._Piece.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Piece.Entity = null;
						previousValue.utilise.Remove(this);
					}
					this._Piece.Entity = value;
					if ((value != null))
					{
						value.utilise.Add(this);
						this._idPiece = value.idPiece;
					}
					else
					{
						this._idPiece = default(long);
					}
					this.SendPropertyChanged("Piece");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Reparation_utilise", Storage="_Reparation", ThisKey="idReparation", OtherKey="idReparation", IsForeignKey=true)]
		public Reparation Reparation
		{
			get
			{
				return this._Reparation.Entity;
			}
			set
			{
				Reparation previousValue = this._Reparation.Entity;
				if (((previousValue != value) 
							|| (this._Reparation.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Reparation.Entity = null;
						previousValue.utilise.Remove(this);
					}
					this._Reparation.Entity = value;
					if ((value != null))
					{
						value.utilise.Add(this);
						this._idReparation = value.idReparation;
					}
					else
					{
						this._idReparation = default(long);
					}
					this.SendPropertyChanged("Reparation");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.voiture")]
	public partial class voiture : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _immatricule;
		
		private string _marque;
		
		private string _Modele;
		
		private string _TelephonePro;
		
		private EntitySet<Reparation> _Reparation;
		
    #region Définitions de méthodes d'extensibilité
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnimmatriculeChanging(string value);
    partial void OnimmatriculeChanged();
    partial void OnmarqueChanging(string value);
    partial void OnmarqueChanged();
    partial void OnModeleChanging(string value);
    partial void OnModeleChanged();
    partial void OnTelephoneProChanging(string value);
    partial void OnTelephoneProChanged();
    #endregion
		
		public voiture()
		{
			this._Reparation = new EntitySet<Reparation>(new Action<Reparation>(this.attach_Reparation), new Action<Reparation>(this.detach_Reparation));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_immatricule", DbType="VarChar(20) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string immatricule
		{
			get
			{
				return this._immatricule;
			}
			set
			{
				if ((this._immatricule != value))
				{
					this.OnimmatriculeChanging(value);
					this.SendPropertyChanging();
					this._immatricule = value;
					this.SendPropertyChanged("immatricule");
					this.OnimmatriculeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_marque", DbType="VarChar(MAX)")]
		public string marque
		{
			get
			{
				return this._marque;
			}
			set
			{
				if ((this._marque != value))
				{
					this.OnmarqueChanging(value);
					this.SendPropertyChanging();
					this._marque = value;
					this.SendPropertyChanged("marque");
					this.OnmarqueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modele", DbType="VarChar(MAX)")]
		public string Modele
		{
			get
			{
				return this._Modele;
			}
			set
			{
				if ((this._Modele != value))
				{
					this.OnModeleChanging(value);
					this.SendPropertyChanging();
					this._Modele = value;
					this.SendPropertyChanged("Modele");
					this.OnModeleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelephonePro", DbType="VarChar(MAX)")]
		public string TelephonePro
		{
			get
			{
				return this._TelephonePro;
			}
			set
			{
				if ((this._TelephonePro != value))
				{
					this.OnTelephoneProChanging(value);
					this.SendPropertyChanging();
					this._TelephonePro = value;
					this.SendPropertyChanged("TelephonePro");
					this.OnTelephoneProChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="voiture_Reparation", Storage="_Reparation", ThisKey="immatricule", OtherKey="immatricule")]
		public EntitySet<Reparation> Reparation
		{
			get
			{
				return this._Reparation;
			}
			set
			{
				this._Reparation.Assign(value);
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
		
		private void attach_Reparation(Reparation entity)
		{
			this.SendPropertyChanging();
			entity.voiture = this;
		}
		
		private void detach_Reparation(Reparation entity)
		{
			this.SendPropertyChanging();
			entity.voiture = null;
		}
	}
}
#pragma warning restore 1591
