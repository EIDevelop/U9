﻿using System;
using System.Collections;
using System.Collections.Generic ;
using System.Runtime.Serialization;

namespace UFIDA.U9.CC.CustomerBE
{
	
	/// <summary>
	/// 实体: 客户信息
	/// 
	/// </summary>
	[Serializable]	
	public  partial class Customer : UFSoft.UBF.Business.BusinessEntity
	{





		#region Create Instance
		/// <summary>
		/// Constructor
		/// </summary>
		public Customer(){
		}


	
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Instance</returns>
		public  static Customer Create() {
			Customer entity = (Customer)UFSoft.UBF.Business.Entity.Create(CurrentClassKey, null);
																																										 
			return entity;
		}

		/// <summary>
		/// use for Serialization
		/// </summary>
		protected Customer(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
			:base(info,context)
		{
		}
		protected override bool IsMainEntity
		{
			get { return true ;}
		}
		#endregion

		#region Create Default 
		/// <summary>
		/// Create Instance
		/// </summary>
		/// <returns>Default Instance</returns>
		public static Customer CreateDefault() {
		#if Test		
			return CreateDefault_Extend() ;
		#else 
		    return null;
		#endif
		}
		/// <summary>
		/// Create DefaultComponent
		/// </summary>
		/// <returns>DefaultComponent Instance</returns>
		public static Customer CreateDefaultComponent(){
		#if Test		
			return CreateDefaultComponent_Extend() ;
		#else 
		    return null;
		#endif
		}

		#endregion

		#region ClassKey
		protected override string ClassKey_FullName
        {
            get { return "UFIDA.U9.CC.CustomerBE.Customer"; }    
        }
		//private static UFSoft.UBF.PL.IClassKey _currentClassKey;
		//由于可能每次访问时的Enterprise不一样，所以每次重取.
		private static UFSoft.UBF.PL.IClassKey CurrentClassKey
		{
			get {
				return  UFSoft.UBF.PL.ClassKeyFacatory.CreateKey("UFIDA.U9.CC.CustomerBE.Customer");
			}
		}
		


		#endregion 

		#region EntityKey
		/// <summary>
		/// Strong Class Customer EntityKey 
		/// </summary>
		[Serializable()]
	    [DataContract(Name = "EntityKey", Namespace = "UFSoft.UBF.Business.BusinessEntity")]
		public new partial class EntityKey : UFSoft.UBF.Business.BusinessEntity.EntityKey
		{
			public EntityKey(long id): this(id, "UFIDA.U9.CC.CustomerBE.Customer")
			{}
			//Construct using by freamwork.
			protected EntityKey(long id , string entityType):base(id,entityType)
			{}
			/// <summary>
			/// 得到当前Key所对应的Entity．(Session级有缓存,性能不用考虑．)
			/// </summary>
			public new Customer GetEntity()
			{
				return (Customer)base.GetEntity();
			}
			public static bool operator ==(EntityKey obja, EntityKey objb)
			{
				if (object.ReferenceEquals(obja, null))
				{
					if (object.ReferenceEquals(objb, null))
						return true;
					return false;
				}
				return obja.Equals(objb);
			}
			public static bool operator !=(EntityKey obja, EntityKey objb)
			{
				return !(obja == objb);
			}
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}
			public override bool Equals(object obj)
			{
				return base.Equals(obj);
			}
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityKey CreateEntityKey()
		{
			return new EntityKey(this.ID);
		}
		/// <summary>
		/// Strong Class EntityKey Property
		/// </summary>
		public new EntityKey Key
		{
			get
			{
				return base.Key as EntityKey;
			}
		}
		#endregion

		#region Finder
		/// <summary>
		/// Strong Class EntityFinder
		/// </summary>
		public new partial class EntityFinder : UFSoft.UBF.Business.BusinessEntity.EntityFinder<Customer> 
		{
		    public EntityFinder():base(CurrentClassKey)
			{
			}
			public new EntityList FindAll(string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(opath, oqlParameters));                
			}
			public new EntityList FindAll(UFSoft.UBF.PL.ObjectQueryOptions options, string opath, params UFSoft.UBF.PL.OqlParam[] oqlParameters)
			{
				return new EntityList(base.FindAll(options,opath, oqlParameters));                
			}









			/// <summary>
			/// 业务主键查询参数类型
			/// </summary>
			public class BusinessKeyParameter
			{
				private System.String m_Code ;
				public  System.String Code
				{
					get { return m_Code ;}
					set { m_Code = value ;}
				}
				private UFIDA.U9.Base.Organization.Organization.EntityKey m_Org ;
				public  UFIDA.U9.Base.Organization.Organization.EntityKey Org
				{
					get { return m_Org ;}
					set { m_Org = value ;}
				}
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			public Customer FindByBusinessKey(  System.String code  , UFIDA.U9.Base.Organization.Organization.EntityKey org  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
				
				parameter.Code = code ;
				
				parameter.Org = org ;
				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询 -业务主键展开方式,会受业务主键调整影响接口.建议使用另一参数类型对象接口查询．
			/// </summary>
			[Obsolete("请使用另一FindByBusinessKey重载接口，参数为EntityKey类型，提高效率 ")]
			public Customer FindByBusinessKey(  System.String code  , UFIDA.U9.Base.Organization.Organization org  )
			{
				BusinessKeyParameter　parameter = new BusinessKeyParameter() ;
								parameter.Code = code ;				
				parameter.Org = org==null?null:org.Key ;

				return this.FindByBusinessKey(parameter) ;
			}
			/// <summary>
			/// 通过实体设置的业务主键进行查询－建议使用.
			/// </summary>
			public Customer FindByBusinessKey(BusinessKeyParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(40*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
                
								
				

				sbuilder.Append("Code = @Code");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Code",parameter.Code));												
				

				sbuilder.Append(" and Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));				
						
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
			/// <summary>
			/// UFIDA_U9_CC_CustomerBE_BizEntity_BusinessKey_Index索引查询参数类型
			/// </summary>
			public class UFIDAU9CCCustomerBEBizEntityBusinessKeyIndexParameter
			{
				private System.String m_Code ;
				public  System.String Code
				{
					get { return m_Code ;}
					set { m_Code = value ;}
				}				private UFIDA.U9.Base.Organization.Organization.EntityKey m_Org ;
				public  UFIDA.U9.Base.Organization.Organization.EntityKey Org
				{
					get { return m_Org ;}
					set { m_Org = value ;}
				}
			}
			
			
			/// <summary>
			/// 通过索引UFIDA_U9_CC_CustomerBE_BizEntity_BusinessKey_Index进行查询(参数对象接口)
			/// </summary>
			public Customer FindByUFIDAU9CCCustomerBEBizEntityBusinessKeyIndex(UFIDAU9CCCustomerBEBizEntityBusinessKeyIndexParameter parameter)
			{
                if (parameter == null)
                    throw new ArgumentException("parameter");
                System.Text.StringBuilder sbuilder = new System.Text.StringBuilder(20*2);
                UFSoft.UBF.PL.OqlParamList paramlist = new UFSoft.UBF.PL.OqlParamList();
				
				sbuilder.Append("Code = @Code");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Code",parameter.Code));				
				sbuilder.Append(" and Org = @Org");
				paramlist.Add(new UFSoft.UBF.PL.OqlParam("Org",parameter.Org.ID));				
				return this.Find(sbuilder.ToString(), paramlist.ToArray());
			}
			
		}

		//private static EntityFinder _finder  ;

		/// <summary>
		/// Finder
		/// </summary>
		public static EntityFinder Finder {
			get {
				//if (_finder == null)
				//	_finder =  new EntityFinder() ;
				return new EntityFinder() ;
			}
		}
		#endregion
			
		#region List

		/// <summary>
		/// EntityList
		/// </summary>
		public partial class EntityList :UFSoft.UBF.Business.Entity.EntityList<Customer>{
		    #region constructor 
		    /// <summary>
		    /// EntityList 无参的构造方法,用于其它特殊情况
		    /// </summary>
		    public EntityList()
		    {
		    }

		    /// <summary>
		    /// EntityList Constructor With Collection .主要用于查询返回实体集时使用.
		    /// </summary>
		    public EntityList(IList list) : base(list)
		    { 
		    }
		    
		    /// <summary>
		    ///  EntityList Constructor , used by  peresidence
		    /// </summary>
		    /// <param name="childAttrName">this EntityList's child Attribute Name</param>
		    /// <param name="parentEntity">this EntityList's Parent Entity </param>
		    /// <param name="parentAttrName">Parent Entity's Attribute Name with this EntityList's </param>
		    /// <param name="list">list </param>
		    public EntityList(string childAttrName,UFSoft.UBF.Business.BusinessEntity parentEntity, string parentAttrName, IList list)
			    :base(childAttrName,parentEntity,parentAttrName,list) 
		    { 
			
		    }

		    #endregion 
		    //用于一对多关联.	
		    internal IList InnerList
		    {
		    	//get { return this.innerList; }
		    	set {
		    		if (value != null)
		    		    this.innerList = value; 
		    	}
		    }
		    protected override bool IsMainEntity
		    {
			    get { return true ;}
		    }
		}
		#endregion
		
		#region Typeed OriginalData
		/// <summary>
		/// 当前实体对象的旧数据对象(为上次更新后的数据)
		/// </summary>
		public new EntityOriginal OriginalData
		{
			get {
				return (EntityOriginal)base.OriginalData;
			}
            protected set
            {
				base.OriginalData = value ;
            }
		}
		protected override UFSoft.UBF.Business.BusinessEntity.EntityOriginal CreateOriginalData()
		{
			return new EntityOriginal(this);
		}
		
		public new partial class EntityOriginal: UFSoft.UBF.Business.Entity.EntityOriginal
		{
		    //private Customer ContainerEntity ;
		    public  new Customer ContainerEntity 
		    {
				get { return  (Customer)base.ContainerEntity ;}
				set { base.ContainerEntity = value ;}
		    }
		    
		    public EntityOriginal(Customer container)
		    {
				if (container == null )
					throw new ArgumentNullException("container") ;
				ContainerEntity = container ;
				base.innerData = container.OldValues ;
				InitInnerData();
		    }
	




			#region member					
			
			/// <summary>
			///  OrginalData属性。只可读。
			/// ID (该属性不可为空,且无默认值)
			/// 客户信息.Key.ID
			/// </summary>
			/// <value></value>
			public  System.Int64 ID
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("ID");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建时间 (该属性可为空,且无默认值)
			/// 客户信息.Sys.创建时间
			/// </summary>
			/// <value></value>
			public  System.DateTime CreatedOn
			{
				get
				{
					object obj = base.GetValue("CreatedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 创建人 (该属性可为空,且无默认值)
			/// 客户信息.Sys.创建人
			/// </summary>
			/// <value></value>
			public  System.String CreatedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("CreatedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改时间 (该属性可为空,且无默认值)
			/// 客户信息.Sys.修改时间
			/// </summary>
			/// <value></value>
			public  System.DateTime ModifiedOn
			{
				get
				{
					object obj = base.GetValue("ModifiedOn");
					if (obj == null)
						return System.DateTime.MinValue;
					else
					       return (System.DateTime)obj;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 修改人 (该属性可为空,且无默认值)
			/// 客户信息.Sys.修改人
			/// </summary>
			/// <value></value>
			public  System.String ModifiedBy
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ModifiedBy");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 事务版本 (该属性可为空,但有默认值)
			/// 客户信息.Sys.事务版本
			/// </summary>
			/// <value></value>
			public  System.Int64 SysVersion
			{
				get
				{
					System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 编码 (该属性不可为空,且无默认值)
			/// 客户信息.Misc.编码
			/// </summary>
			/// <value></value>
			public  System.String Code
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Code");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 名称 (该属性可为空,且无默认值)
			/// 客户信息.Misc.名称
			/// </summary>
			/// <value></value>
			public  System.String Name
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Name");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 简称 (该属性可为空,且无默认值)
			/// 客户信息.Misc.简称
			/// </summary>
			/// <value></value>
			public  System.String ShortName
			{
				get
				{
					System.String value  = (System.String)base.GetValue("ShortName");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 备注 (该属性可为空,且无默认值)
			/// 客户信息.Misc.备注
			/// </summary>
			/// <value></value>
			public  System.String Memo
			{
				get
				{
					System.String value  = (System.String)base.GetValue("Memo");
					return value;
						}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 币种 (该属性可为空,且无默认值)
			/// 客户信息.Misc.币种
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency Currency
			{
				get
				{
					if (CurrencyKey == null)
						return null ;
					UFIDA.U9.Base.Currency.Currency value =  (UFIDA.U9.Base.Currency.Currency)CurrencyKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_CurrencyKey ;
		/// <summary>
		/// EntityKey 属性
		/// 币种 的Key (该属性可为空,且无默认值)
		/// 客户信息.Misc.币种
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey CurrencyKey
		{
			get 
			{
				object obj = base.GetValue("Currency") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CurrencyKey==null || m_CurrencyKey.ID != key )
					m_CurrencyKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_CurrencyKey ;
			}
		}

				

			private UFIDA.U9.Base.PropertyTypes.Effective.PropertyOriginal m_Effective ;
			/// <summary>
			///  OrginalData属性。只可读。
			/// 有效性 (该属性可为空,且无默认值)
			/// 客户信息.Misc.有效性
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.PropertyTypes.Effective.PropertyOriginal Effective
			{
				get
				{
					if (m_Effective == null )
						m_Effective = new UFIDA.U9.Base.PropertyTypes.Effective.PropertyOriginal(this.ContainerEntity.OriginalData, "Effective");
					return m_Effective;
				}
			}
		



				
			/// <summary>
			///  OrginalData属性。只可读。
			/// 组织 (该属性不可为空,且无默认值)
			/// 客户信息.Misc.组织
			/// </summary>
			/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization Org
			{
				get
				{
					if (OrgKey == null)
						return null ;
					UFIDA.U9.Base.Organization.Organization value =  (UFIDA.U9.Base.Organization.Organization)OrgKey.GetEntity();
					return value ;
				}
			}
		


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_OrgKey ;
		/// <summary>
		/// EntityKey 属性
		/// 组织 的Key (该属性不可为空,且无默认值)
		/// 客户信息.Misc.组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey OrgKey
		{
			get 
			{
				object obj = base.GetValue("Org") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrgKey==null || m_OrgKey.ID != key )
					m_OrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_OrgKey ;
			}
		}

		

			#endregion

			#region List member						
			#endregion

			#region Be List member						
			#endregion



		    
		}
		#endregion 







		#region member					
		
			/// <summary>
		/// ID (该属性不可为空,且无默认值)
		/// 客户信息.Key.ID
		/// </summary>
		/// <value></value>
	 
		public new System.Int64 ID
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("ID");
				return value;
				}
				set
			{
				
								base.SetValue("ID", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建时间 (该属性可为空,且无默认值)
		/// 客户信息.Sys.创建时间
		/// </summary>
		/// <value></value>
			public  System.DateTime CreatedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("CreatedOn");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 创建人 (该属性可为空,且无默认值)
		/// 客户信息.Sys.创建人
		/// </summary>
		/// <value></value>
			public  System.String CreatedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("CreatedBy");
				return value;
				}
				set
			{
				
								base.SetValue("CreatedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改时间 (该属性可为空,且无默认值)
		/// 客户信息.Sys.修改时间
		/// </summary>
		/// <value></value>
			public  System.DateTime ModifiedOn
		{
			get
			{
				System.DateTime value  = (System.DateTime)base.GetValue("ModifiedOn");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedOn", value);
						 
			}
		}
	



		
			/// <summary>
		/// 修改人 (该属性可为空,且无默认值)
		/// 客户信息.Sys.修改人
		/// </summary>
		/// <value></value>
			public  System.String ModifiedBy
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ModifiedBy");
				return value;
				}
				set
			{
				
								base.SetValue("ModifiedBy", value);
						 
			}
		}
	



		
			/// <summary>
		/// 事务版本 (该属性可为空,但有默认值)
		/// 客户信息.Sys.事务版本
		/// </summary>
		/// <value></value>
			public  System.Int64 SysVersion
		{
			get
			{
				System.Int64 value  = (System.Int64)base.GetValue("SysVersion");
				return value;
				}
				set
			{
				
								base.SetValue("SysVersion", value);
						 
			}
		}
	



		
			/// <summary>
		/// 编码 (该属性不可为空,且无默认值)
		/// 客户信息.Misc.编码
		/// </summary>
		/// <value></value>
			public  System.String Code
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Code");
				return value;
				}
				set
			{
				
								base.SetValue("Code", value);
						 
			}
		}
	



		
			/// <summary>
		/// 名称 (该属性可为空,且无默认值)
		/// 客户信息.Misc.名称
		/// </summary>
		/// <value></value>
			public  System.String Name
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Name");
				return value;
				}
				set
			{
				
								base.SetValue("Name", value);
						 
			}
		}
	



		
			/// <summary>
		/// 简称 (该属性可为空,且无默认值)
		/// 客户信息.Misc.简称
		/// </summary>
		/// <value></value>
			public  System.String ShortName
		{
			get
			{
				System.String value  = (System.String)base.GetValue("ShortName");
				return value;
				}
				set
			{
				
								base.SetValue("ShortName", value);
						 
			}
		}
	



		
			/// <summary>
		/// 备注 (该属性可为空,且无默认值)
		/// 客户信息.Misc.备注
		/// </summary>
		/// <value></value>
			public  System.String Memo
		{
			get
			{
				System.String value  = (System.String)base.GetValue("Memo");
				return value;
				}
				set
			{
				
								base.SetValue("Memo", value);
						 
			}
		}
	



		
			/// <summary>
		/// 币种 (该属性可为空,且无默认值)
		/// 客户信息.Misc.币种
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Currency.Currency Currency
		{
			get
			{
				object  obj = this.GetRelation("Currency");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Currency.Currency value  = (UFIDA.U9.Base.Currency.Currency)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Currency", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Currency.Currency.EntityKey m_CurrencyKey ;
		/// <summary>
		/// 币种 的Key (该属性可为空,且无默认值)
		/// 客户信息.Misc.币种
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Currency.Currency.EntityKey CurrencyKey
		{
			get 
			{
				object obj = base.GetValue("Currency") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_CurrencyKey==null || m_CurrencyKey.ID != key )
					m_CurrencyKey = new UFIDA.U9.Base.Currency.Currency.EntityKey(key); 
				return m_CurrencyKey ;
			}
			set
			{	
				if (CurrencyKey==value)
					return ;
				this.SetRelation("Currency", null);
				m_CurrencyKey = value ;
				if (value != null) 
				{
					base.SetValue("Currency",value.ID);
				}
				else
					base.SetValue("Currency",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

		
		private UFIDA.U9.Base.PropertyTypes.Effective m_Effective ;
			/// <summary>
		/// 有效性 (该属性可为空,且无默认值)
		/// 客户信息.Misc.有效性
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.PropertyTypes.Effective Effective
		{
			get
			{
				if (m_Effective == null )
					m_Effective = new UFIDA.U9.Base.PropertyTypes.Effective(this, "Effective");
				return m_Effective;
			}
				set
			{
				
				if (value == null)
					return ;
				if (this.m_Effective == null)
					this.m_Effective = new UFIDA.U9.Base.PropertyTypes.Effective(this,"Effective");
								this.m_Effective.IsEffective = value.IsEffective ;
												this.m_Effective.EffectiveDate = value.EffectiveDate ;
												this.m_Effective.DisableDate = value.DisableDate ;
				
					 
			}
		}
	



		
			/// <summary>
		/// 组织 (该属性不可为空,且无默认值)
		/// 客户信息.Misc.组织
		/// </summary>
		/// <value></value>
			public  UFIDA.U9.Base.Organization.Organization Org
		{
			get
			{
				object  obj = this.GetRelation("Org");
				if (obj == null)
				{
					return null ;
				}
				else
				{
					UFIDA.U9.Base.Organization.Organization value  = (UFIDA.U9.Base.Organization.Organization)obj;
					return value;
				 }
			}
				set
			{
				
				this.SetRelation("Org", value);
					 
			}
		}
	


   		private UFIDA.U9.Base.Organization.Organization.EntityKey m_OrgKey ;
		/// <summary>
		/// 组织 的Key (该属性不可为空,且无默认值)
		/// 客户信息.Misc.组织
		/// </summary>
		/// <value></value>
		public  UFIDA.U9.Base.Organization.Organization.EntityKey OrgKey
		{
			get 
			{
				object obj = base.GetValue("Org") ;
				if (obj == null || (Int64)obj==UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag || (Int64)obj==0)
					return null ;
				Int64 key = (System.Int64)obj ;
				if (m_OrgKey==null || m_OrgKey.ID != key )
					m_OrgKey = new UFIDA.U9.Base.Organization.Organization.EntityKey(key); 
				return m_OrgKey ;
			}
			set
			{	
				if (OrgKey==value)
					return ;
				this.SetRelation("Org", null);
				m_OrgKey = value ;
				if (value != null) 
				{
					base.SetValue("Org",value.ID);
				}
				else
					base.SetValue("Org",UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag);
			}
		}

	

		#endregion

		#region List member						
		#endregion

		#region Be List member						
		#endregion
		
		#region ModelResource 其余去除，保留EntityName
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  string Res_EntityName {	get {return Res_EntityNameS ;}	}
		/// <summary>
		/// Entity的显示名称资源-请使用EntityRes.GetResource(EntityRes.BE_FullName)的方式取 Entity的显示名称资源.
		/// </summary>
		[Obsolete("")]
		public  static string Res_EntityNameS {	get {return EntityRes.GetResource("UFIDA.U9.CC.CustomerBE.Customer")  ;}	}
		#endregion 		

		#region ModelResource,这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource()内部类的方式取资源
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ID")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ID　{ get { return EntityRes.GetResource("ID");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedOn　{ get { return EntityRes.GetResource("CreatedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("CreatedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_CreatedBy　{ get { return EntityRes.GetResource("CreatedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedOn")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedOn　{ get { return EntityRes.GetResource("ModifiedOn");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ModifiedBy")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ModifiedBy　{ get { return EntityRes.GetResource("ModifiedBy");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("SysVersion")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_SysVersion　{ get { return EntityRes.GetResource("SysVersion");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Code")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Code　{ get { return EntityRes.GetResource("Code");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Name")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Name　{ get { return EntityRes.GetResource("Name");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("ShortName")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_ShortName　{ get { return EntityRes.GetResource("ShortName");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Memo")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Memo　{ get { return EntityRes.GetResource("Memo");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Currency")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Currency　{ get { return EntityRes.GetResource("Currency");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Effective")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Effective　{ get { return EntityRes.GetResource("Effective");　}　}
		/// <summary>
		/// 这种已经被取消，请使用这块代码的人自己调整程序，改为引用EntityRes.GetResource("Org")的方式取资源
		/// </summary>
		[Obsolete("")]
		public string Res_Org　{ get { return EntityRes.GetResource("Org");　}　}
		#endregion 



		#region EntityResource 实体的属性名称及相应显示名称资源访问方法
		public class EntityRes
		{
			/// <summary>
			/// EntityName的名称
			/// </summary>
			public static string BE_Name { get { return "Customer";　}　}
			
			/// <summary>
			/// Entity　的全名. 
			/// </summary>
			public static string BE_FullName { get { return "UFIDA.U9.CC.CustomerBE.Customer";　}　}
		
			/// <summary>
			/// 属性: ID 的名称
			/// </summary>
			public static string ID　{ get { return "ID";　}　}
				
			/// <summary>
			/// 属性: 创建时间 的名称
			/// </summary>
			public static string CreatedOn　{ get { return "CreatedOn";　}　}
				
			/// <summary>
			/// 属性: 创建人 的名称
			/// </summary>
			public static string CreatedBy　{ get { return "CreatedBy";　}　}
				
			/// <summary>
			/// 属性: 修改时间 的名称
			/// </summary>
			public static string ModifiedOn　{ get { return "ModifiedOn";　}　}
				
			/// <summary>
			/// 属性: 修改人 的名称
			/// </summary>
			public static string ModifiedBy　{ get { return "ModifiedBy";　}　}
				
			/// <summary>
			/// 属性: 事务版本 的名称
			/// </summary>
			public static string SysVersion　{ get { return "SysVersion";　}　}
				
			/// <summary>
			/// 属性: 编码 的名称
			/// </summary>
			public static string Code　{ get { return "Code";　}　}
				
			/// <summary>
			/// 属性: 名称 的名称
			/// </summary>
			public static string Name　{ get { return "Name";　}　}
				
			/// <summary>
			/// 属性: 简称 的名称
			/// </summary>
			public static string ShortName　{ get { return "ShortName";　}　}
				
			/// <summary>
			/// 属性: 备注 的名称
			/// </summary>
			public static string Memo　{ get { return "Memo";　}　}
				
			/// <summary>
			/// 属性: 币种 的名称
			/// </summary>
			public static string Currency　{ get { return "Currency";　}　}
				
			/// <summary>
			/// 属性类型属性: Effective 的名称
			/// </summary>
			public static string Effective { get { return "Effective";　}　}
			/// <summary>
			/// 属性类型属性: Effective 的类型全名
			/// </summary>
			public static string Effective_TypeFullName { get { return "UFIDA.U9.Base.PropertyTypes.Effective";　}　}
			/// <summary>
			/// 属性类型属性展开:Effective.IsEffective的名称
			/// </summary>
			public static string Effective_IsEffective { get { return "Effective.IsEffective";　}　}
			/// <summary>
			/// 属性类型属性展开:Effective.EffectiveDate的名称
			/// </summary>
			public static string Effective_EffectiveDate { get { return "Effective.EffectiveDate";　}　}
			/// <summary>
			/// 属性类型属性展开:Effective.DisableDate的名称
			/// </summary>
			public static string Effective_DisableDate { get { return "Effective.DisableDate";　}　}
				
			/// <summary>
			/// 属性: 组织 的名称
			/// </summary>
			public static string Org　{ get { return "Org";　}　}
		
			/// <summary>
			/// 获取显示名称资源方法
			/// </summary>
			public static string GetResource(String attrName){
				if (attrName == BE_Name || attrName== BE_FullName)
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetEntityResource(BE_FullName);
																								
				if (attrName.StartsWith("Effective."))
					return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetPropertyResource(Effective_TypeFullName, attrName);
				
				return UFSoft.UBF.Business.Tool.ExtendHelpAPI.GetAttrResource(BE_FullName, attrName);
			}

		}
		#endregion 


		#region EntityObjectBuilder 持久化性能优化
        private Dictionary<string, string> multiLangAttrs = null;
        private Dictionary<string, string> exdMultiLangAttrs = null;
        private string col_ID_Name = string.Empty;

        public override  Dictionary<string, string> MultiLangAttrs
        {
			get
			{
				return multiLangAttrs;
			}
        }
        public override  Dictionary<string, string> ExdMultiLangAttrs
        {
			get
			{
				return exdMultiLangAttrs;
			}
        }
        public override string Col_ID_Name
        {
			get
			{
				return col_ID_Name;
			}
        }  
        public override void IniData()
        {
			this.multiLangAttrs = new Dictionary<string, string>();
			this.exdMultiLangAttrs = new Dictionary<string, string>();
	
			this.col_ID_Name ="ID";
			this.exdMultiLangAttrs.Add("ID","ID");
			this.exdMultiLangAttrs.Add("CreatedOn","CreatedOn");
			this.exdMultiLangAttrs.Add("CreatedBy","CreatedBy");
			this.exdMultiLangAttrs.Add("ModifiedOn","ModifiedOn");
			this.exdMultiLangAttrs.Add("ModifiedBy","ModifiedBy");
			this.exdMultiLangAttrs.Add("SysVersion","SysVersion");
			this.exdMultiLangAttrs.Add("Code","Code");
			this.exdMultiLangAttrs.Add("Name","Name");
			this.exdMultiLangAttrs.Add("ShortName","ShortName");
			this.exdMultiLangAttrs.Add("Memo","Memo");
			this.exdMultiLangAttrs.Add("Currency","Currency");
			this.exdMultiLangAttrs.Add("Effective.IsEffective","Effective_IsEffective");
			this.exdMultiLangAttrs.Add("Effective.EffectiveDate","Effective_EffectiveDate");
			this.exdMultiLangAttrs.Add("Effective.DisableDate","Effective_DisableDate");
			this.exdMultiLangAttrs.Add("Org","Org");
        }
	#endregion 




		
		
		#region override SetTypeValue method(Use By UICommonCRUD OR Weakly Type Operation)
		public override void SetTypeValue(object propName, object value)
		{
			
			string propstr = propName.ToString();
			switch(propstr)
			{
			
																																									
									

			

				default:
					//调用基类的实现，最终Entity基类为SetValue()
					base.SetTypeValue(propName,value);
					return;
			}
		}
		#endregion


	


		#region EntityData exchange
		
		#region  DeSerializeKey -ForEntityPorpertyType
		//反序化Key到Data的ID中 --由FromEntityData自动调用一次。实际可以分离,由跨组织服务去调用.
		private void DeSerializeKey(CustomerData data)
		{
		
			

			

			

			

			

			

			

			

			

			

			if (data.Currency == -1 && data.Currency_SKey!=null)
				data.Currency = data.Currency_SKey.GetEntity().ID ;
	

			

			if (data.Org == -1 && data.Org_SKey!=null)
				data.Org = data.Org_SKey.GetEntity().ID ;
	
	
			//Entity中没有EntityKey集合，不用处理。
		}
		
		#endregion 	
        public override void FromEntityData(UFSoft.UBF.Business.DataTransObjectBase dto)
        {
			CustomerData data = dto as CustomerData ;
			if (data == null)
				return ;
            this.FromEntityData(data) ;
        }

        public override UFSoft.UBF.Business.DataTransObjectBase ToEntityDataBase()
        {
            return this.ToEntityData();
        }
		/// <summary>
		/// Copy Entity From EntityData
		/// </summary>
		public void FromEntityData(CustomerData data)
		{
			this.FromEntityData(data,new Hashtable());
		}
		//used by ubf..
		public void FromEntityData(CustomerData data,IDictionary dict)
		{
			if (data == null)
				return;
			bool m_isNeedPersistable = this.NeedPersistable ;
			this.NeedPersistable = false ;
			
			//this.innerData.ChangeEventEnabled = false;
			//this.innerRelation.RelationEventEnabled = false;
				
			if (dict == null ) dict = new Hashtable() ;
			dict[data] = this;
			this.SysState = data.SysState ;
			DeSerializeKey(data);
			#region 组件外属性
		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

		
			//ID与系统字段不处理 --Sysversion需要处理。

								this.SetTypeValue("SysVersion",data.SysVersion);
		
								this.SetTypeValue("Code",data.Code);
		
								this.SetTypeValue("Name",data.Name);
		
								this.SetTypeValue("ShortName",data.ShortName);
		
								this.SetTypeValue("Memo",data.Memo);
		
								this.SetTypeValue("Currency",data.Currency);
		
								this.Effective.FromEntityData(data.Effective);
		
								this.SetTypeValue("Org",data.Org);
		
			#endregion 

			#region 组件内属性
	
			#endregion 
			this.NeedPersistable = m_isNeedPersistable ;
			dict[data] = this;
		}

		/// <summary>
		/// Create EntityData From Entity
		/// </summary>
		public CustomerData ToEntityData()
		{
			return ToEntityData(null,null);
		}
		/// <summary>
		/// Create EntityData From Entity - used by ubf 
		/// </summary>
		public CustomerData ToEntityData(CustomerData data, IDictionary dict){
			if (data == null)
				data = new CustomerData();
			
			if (dict == null ) dict = new Hashtable() ;
			//就直接用ID,如果不同实体会出现相同ID，则到时候要改进。? ID一定要有。
			dict["UFIDA.U9.CC.CustomerBE.Customer"+this.ID.ToString()] = data;
		
			data.SysState = this.SysState ;
			#region 组件外属性 -BusinessEntity,"简单值对象",简单类型,多语言.不可能存在一对多.没有集合可能.
	    
			{
				object obj =this.GetValue("ID");
				if (obj != null)
					data.ID=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedOn");
				if (obj != null)
					data.CreatedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("CreatedBy");
				if (obj != null)
					data.CreatedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedOn");
				if (obj != null)
					data.ModifiedOn=(System.DateTime)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ModifiedBy");
				if (obj != null)
					data.ModifiedBy=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("SysVersion");
				if (obj != null)
					data.SysVersion=(System.Int64)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Code");
				if (obj != null)
					data.Code=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Name");
				if (obj != null)
					data.Name=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("ShortName");
				if (obj != null)
					data.ShortName=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Memo");
				if (obj != null)
					data.Memo=(System.String)obj;
			}
	     
	    
			{
				object obj =this.GetValue("Currency");
				if (obj != null)
					data.Currency=(System.Int64)obj;
			}
	     
	    
			if (this.Effective != null)
			{
				data.Effective=this.Effective.ToEntityData();
			}
	     
	    
			{
				object obj =this.GetValue("Org");
				if (obj != null)
					data.Org=(System.Int64)obj;
			}
	     
			#endregion 

			#region 组件内属性 -Entity,"复杂值对象",枚举,实体集合.
	

			#endregion 
			return data ;
		}

		#endregion
	



	
        #region EntityValidator 
	//实体检验： 含自身检验器检验，内嵌属性类型的检验以及属性类型上的校验器的检验。
        private bool SelfEntityValidator()
        {
        











			
			//调用UFIDA.U9.Base.PropertyTypes.Effective属性类型的内置校验方法.
			this.Effective.OnValidate() ;
	

			//调用实体自身校验器代码.
            return true; 
        }
		//校验属性是否为空的检验。主要是关联对象的效验
		public override void SelfNullableVlidator()
		{
			base.SelfNullableVlidator();
		
			if (string.IsNullOrEmpty((string)base.GetValue("Code"))){
				UFSoft.UBF.Business.AttributeInValidException Code_Exception =new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.CC.CustomerBE.Customer","Code","aeb1aeb7-6640-4ef5-838a-4415aca8dc0e");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					Code_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(Code_Exception);
			}

			if (Convert.ToInt64(base.GetValue("Org")) == UFSoft.UBF.PL.Tool.Constant.ID_NULL_Flag){
				UFSoft.UBF.Business.AttributeInValidException Org_Exception = new UFSoft.UBF.Business.AttributeInValidException("UFIDA.U9.CC.CustomerBE.Customer","Org","61151abc-8a4c-462d-ba88-cd3521823a2e");
				if (UFSoft.UBF.PL.Tool.ConfigParm.SupportNullableVlidatorStackTrace)
					Org_Exception.MyStackTrace =  new System.Diagnostics.StackTrace(true).ToString();
				this.PropertyExceptions.Add(Org_Exception);
			}

			
		}
			    
	#endregion 
	
	
		#region 应用版型代码区
		#endregion 


	}	
}