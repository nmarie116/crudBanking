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

namespace Transaction
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dbTransaction")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblTransaction(tblTransaction instance);
    partial void UpdatetblTransaction(tblTransaction instance);
    partial void DeletetblTransaction(tblTransaction instance);
    partial void InserttblUser(tblUser instance);
    partial void UpdatetblUser(tblUser instance);
    partial void DeletetblUser(tblUser instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Transaction.Properties.Settings.Default.dbTransactionConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<tblTransaction> tblTransactions
		{
			get
			{
				return this.GetTable<tblTransaction>();
			}
		}
		
		public System.Data.Linq.Table<tblUser> tblUsers
		{
			get
			{
				return this.GetTable<tblUser>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_DeleteUser")]
		public int sp_DeleteUser([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ViewUser")]
		public ISingleResult<sp_ViewUserResult> sp_ViewUser()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_ViewUserResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_UpdateUser")]
		public int sp_UpdateUser([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string fname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string lname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, fname, lname, username, password);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_DeleteTra")]
		public int sp_DeleteTra([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> transId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), transId);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_InsertTra")]
		public int sp_InsertTra([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,2)")] System.Nullable<decimal> amount, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string tranType, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> tdate, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), amount, tranType, tdate, id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_UpdateTra")]
		public int sp_UpdateTra([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> transId, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,2)")] System.Nullable<decimal> amount, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string transType, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> tdate)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), transId, amount, transType, tdate);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_ViewTra")]
		public ISingleResult<sp_ViewTraResult> sp_ViewTra()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<sp_ViewTraResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.sp_InsertUser")]
		public int sp_InsertUser([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string fname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string lname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> pin, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Decimal(18,0)")] System.Nullable<decimal> balance)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fname, lname, username, password, pin, balance);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ValidateLogin", IsComposable=true)]
		public System.Nullable<bool> ValidateLogin([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(50)")] string password)
		{
			return ((System.Nullable<bool>)(this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password).ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblTransaction")]
	public partial class tblTransaction : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _transactionId;
		
		private System.Nullable<decimal> _amount;
		
		private string _transType;
		
		private System.Nullable<System.DateTime> _transDate;
		
		private System.Nullable<int> _userid;
		
		private EntityRef<tblUser> _tblUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntransactionIdChanging(int value);
    partial void OntransactionIdChanged();
    partial void OnamountChanging(System.Nullable<decimal> value);
    partial void OnamountChanged();
    partial void OntransTypeChanging(string value);
    partial void OntransTypeChanged();
    partial void OntransDateChanging(System.Nullable<System.DateTime> value);
    partial void OntransDateChanged();
    partial void OnuseridChanging(System.Nullable<int> value);
    partial void OnuseridChanged();
    #endregion
		
		public tblTransaction()
		{
			this._tblUser = default(EntityRef<tblUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_transactionId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int transactionId
		{
			get
			{
				return this._transactionId;
			}
			set
			{
				if ((this._transactionId != value))
				{
					this.OntransactionIdChanging(value);
					this.SendPropertyChanging();
					this._transactionId = value;
					this.SendPropertyChanged("transactionId");
					this.OntransactionIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Decimal(1,0)")]
		public System.Nullable<decimal> amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this.OnamountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("amount");
					this.OnamountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_transType", DbType="VarChar(50)")]
		public string transType
		{
			get
			{
				return this._transType;
			}
			set
			{
				if ((this._transType != value))
				{
					this.OntransTypeChanging(value);
					this.SendPropertyChanging();
					this._transType = value;
					this.SendPropertyChanged("transType");
					this.OntransTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_transDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> transDate
		{
			get
			{
				return this._transDate;
			}
			set
			{
				if ((this._transDate != value))
				{
					this.OntransDateChanging(value);
					this.SendPropertyChanging();
					this._transDate = value;
					this.SendPropertyChanged("transDate");
					this.OntransDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userid", DbType="Int")]
		public System.Nullable<int> userid
		{
			get
			{
				return this._userid;
			}
			set
			{
				if ((this._userid != value))
				{
					if (this._tblUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuseridChanging(value);
					this.SendPropertyChanging();
					this._userid = value;
					this.SendPropertyChanged("userid");
					this.OnuseridChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblUser_tblTransaction", Storage="_tblUser", ThisKey="userid", OtherKey="userId", IsForeignKey=true)]
		public tblUser tblUser
		{
			get
			{
				return this._tblUser.Entity;
			}
			set
			{
				tblUser previousValue = this._tblUser.Entity;
				if (((previousValue != value) 
							|| (this._tblUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblUser.Entity = null;
						previousValue.tblTransactions.Remove(this);
					}
					this._tblUser.Entity = value;
					if ((value != null))
					{
						value.tblTransactions.Add(this);
						this._userid = value.userId;
					}
					else
					{
						this._userid = default(Nullable<int>);
					}
					this.SendPropertyChanged("tblUser");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblUser")]
	public partial class tblUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _userId;
		
		private string _username;
		
		private string _upassword;
		
		private System.Nullable<int> _userpin;
		
		private string _fname;
		
		private string _lname;
		
		private System.Nullable<int> _Balance;
		
		private EntitySet<tblTransaction> _tblTransactions;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIdChanging(int value);
    partial void OnuserIdChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnupasswordChanging(string value);
    partial void OnupasswordChanged();
    partial void OnuserpinChanging(System.Nullable<int> value);
    partial void OnuserpinChanged();
    partial void OnfnameChanging(string value);
    partial void OnfnameChanged();
    partial void OnlnameChanging(string value);
    partial void OnlnameChanged();
    partial void OnBalanceChanging(System.Nullable<int> value);
    partial void OnBalanceChanged();
    #endregion
		
		public tblUser()
		{
			this._tblTransactions = new EntitySet<tblTransaction>(new Action<tblTransaction>(this.attach_tblTransactions), new Action<tblTransaction>(this.detach_tblTransactions));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					this.OnuserIdChanging(value);
					this.SendPropertyChanging();
					this._userId = value;
					this.SendPropertyChanged("userId");
					this.OnuserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_upassword", DbType="VarChar(50)")]
		public string upassword
		{
			get
			{
				return this._upassword;
			}
			set
			{
				if ((this._upassword != value))
				{
					this.OnupasswordChanging(value);
					this.SendPropertyChanging();
					this._upassword = value;
					this.SendPropertyChanged("upassword");
					this.OnupasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userpin", DbType="Int")]
		public System.Nullable<int> userpin
		{
			get
			{
				return this._userpin;
			}
			set
			{
				if ((this._userpin != value))
				{
					this.OnuserpinChanging(value);
					this.SendPropertyChanging();
					this._userpin = value;
					this.SendPropertyChanged("userpin");
					this.OnuserpinChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fname", DbType="VarChar(50)")]
		public string fname
		{
			get
			{
				return this._fname;
			}
			set
			{
				if ((this._fname != value))
				{
					this.OnfnameChanging(value);
					this.SendPropertyChanging();
					this._fname = value;
					this.SendPropertyChanged("fname");
					this.OnfnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lname", DbType="VarChar(50)")]
		public string lname
		{
			get
			{
				return this._lname;
			}
			set
			{
				if ((this._lname != value))
				{
					this.OnlnameChanging(value);
					this.SendPropertyChanging();
					this._lname = value;
					this.SendPropertyChanged("lname");
					this.OnlnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balance", DbType="Int")]
		public System.Nullable<int> Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				if ((this._Balance != value))
				{
					this.OnBalanceChanging(value);
					this.SendPropertyChanging();
					this._Balance = value;
					this.SendPropertyChanged("Balance");
					this.OnBalanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblUser_tblTransaction", Storage="_tblTransactions", ThisKey="userId", OtherKey="userid")]
		public EntitySet<tblTransaction> tblTransactions
		{
			get
			{
				return this._tblTransactions;
			}
			set
			{
				this._tblTransactions.Assign(value);
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
		
		private void attach_tblTransactions(tblTransaction entity)
		{
			this.SendPropertyChanging();
			entity.tblUser = this;
		}
		
		private void detach_tblTransactions(tblTransaction entity)
		{
			this.SendPropertyChanging();
			entity.tblUser = null;
		}
	}
	
	public partial class sp_ViewUserResult
	{
		
		private int _userId;
		
		private string _username;
		
		private string _upassword;
		
		private System.Nullable<int> _userpin;
		
		private string _fname;
		
		private string _lname;
		
		private System.Nullable<int> _Balance;
		
		public sp_ViewUserResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userId", DbType="Int NOT NULL")]
		public int userId
		{
			get
			{
				return this._userId;
			}
			set
			{
				if ((this._userId != value))
				{
					this._userId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(50)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this._username = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_upassword", DbType="VarChar(50)")]
		public string upassword
		{
			get
			{
				return this._upassword;
			}
			set
			{
				if ((this._upassword != value))
				{
					this._upassword = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userpin", DbType="Int")]
		public System.Nullable<int> userpin
		{
			get
			{
				return this._userpin;
			}
			set
			{
				if ((this._userpin != value))
				{
					this._userpin = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fname", DbType="VarChar(50)")]
		public string fname
		{
			get
			{
				return this._fname;
			}
			set
			{
				if ((this._fname != value))
				{
					this._fname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lname", DbType="VarChar(50)")]
		public string lname
		{
			get
			{
				return this._lname;
			}
			set
			{
				if ((this._lname != value))
				{
					this._lname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Balance", DbType="Int")]
		public System.Nullable<int> Balance
		{
			get
			{
				return this._Balance;
			}
			set
			{
				if ((this._Balance != value))
				{
					this._Balance = value;
				}
			}
		}
	}
	
	public partial class sp_ViewTraResult
	{
		
		private int _transactionId;
		
		private System.Nullable<decimal> _amount;
		
		private string _transType;
		
		private System.Nullable<System.DateTime> _transDate;
		
		private System.Nullable<int> _userid;
		
		public sp_ViewTraResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_transactionId", DbType="Int NOT NULL")]
		public int transactionId
		{
			get
			{
				return this._transactionId;
			}
			set
			{
				if ((this._transactionId != value))
				{
					this._transactionId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_amount", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((this._amount != value))
				{
					this._amount = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_transType", DbType="VarChar(50)")]
		public string transType
		{
			get
			{
				return this._transType;
			}
			set
			{
				if ((this._transType != value))
				{
					this._transType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_transDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> transDate
		{
			get
			{
				return this._transDate;
			}
			set
			{
				if ((this._transDate != value))
				{
					this._transDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userid", DbType="Int")]
		public System.Nullable<int> userid
		{
			get
			{
				return this._userid;
			}
			set
			{
				if ((this._userid != value))
				{
					this._userid = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
