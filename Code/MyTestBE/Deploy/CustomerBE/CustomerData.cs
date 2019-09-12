
	using System; 
	using System.Collections;
	using System.Collections.Generic ;
	using System.Runtime.Serialization;

namespace UFIDA.U9.CC.CustomerBE
{
	/// <summary>
	/// 客户信息 缺省DTO 
	/// 
	/// </summary>
	[DataContract(Name = "UFIDA.U9.CC.CustomerBE.CustomerData", Namespace = "http://www.UFIDA.org/EntityData",IsReference=true)]	
	[Serializable]
    [KnownType("GetKnownTypes")]
	public partial class CustomerData : UFSoft.UBF.Business.DataTransObjectBase
	{

	    public static IList<Type> GetKnownTypes()
        {
            IList<Type> knownTypes = new List<Type>();
            
                        
                        
                        
                        
                        
                        
                        
                        
                        
                                        knownTypes.Add(typeof(UFIDA.U9.Base.Currency.CurrencyData));
                                        knownTypes.Add(typeof(UFIDA.U9.Base.PropertyTypes.EffectiveData));
                                        knownTypes.Add(typeof(UFIDA.U9.Base.Organization.OrganizationData));
            
                knownTypes.Add(typeof(UFSoft.UBF.Util.Data.MultiLangDataDict));
            return knownTypes;
        }
		/// <summary>
		/// Default Constructor
		/// </summary>
		public CustomerData()
		{
			initData() ;
		}
		private void initData()
		{
			//设置默认值
	     			
	     			
	     			
	     			
	     			
	     							SysVersion= 0; 			     			
	     			
	     			
	     			
	     			
	     			
	     			


			//设置组合的集合属性为List<>对象. -目前直接在属性上处理.
			
			//调用默认值初始化服务进行配置方式初始化
			UFSoft.UBF.Service.DTOService.InitConfigDefault(this);
		}		
		[System.Runtime.Serialization.OnDeserializing]
        internal void OnDeserializing(System.Runtime.Serialization.StreamingContext context)
        {
			 initData();
        }
        
		#region System Fields
		///<summary>
		/// 实体类型. 
		/// </summary>
		[DataMember(IsRequired=false)]
		public override string SysEntityType
		{
			get { return "UFIDA.U9.CC.CustomerBE.Customer" ;}
		}
		#endregion


		
		#region Properties Inner Component
	
		#endregion	

		#region Properties Outer Component
		
				/// <summary>
		/// ID
		/// 客户信息.Key.ID
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_iD ;
		public System.Int64 ID
		{
			get	
			{	
				return m_iD  ;
			}
			set	
			{	
				m_iD = value ;	
			}
		}
		

				/// <summary>
		/// 创建时间
		/// 客户信息.Sys.创建时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_createdOn ;
		public System.DateTime CreatedOn
		{
			get	
			{	
				return m_createdOn  ;
			}
			set	
			{	
				m_createdOn = value ;	
			}
		}
		

				/// <summary>
		/// 创建人
		/// 客户信息.Sys.创建人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_createdBy ;
		public System.String CreatedBy
		{
			get	
			{	
				return m_createdBy  ;
			}
			set	
			{	
				m_createdBy = value ;	
			}
		}
		

				/// <summary>
		/// 修改时间
		/// 客户信息.Sys.修改时间
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.DateTime m_modifiedOn ;
		public System.DateTime ModifiedOn
		{
			get	
			{	
				return m_modifiedOn  ;
			}
			set	
			{	
				m_modifiedOn = value ;	
			}
		}
		

				/// <summary>
		/// 修改人
		/// 客户信息.Sys.修改人
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_modifiedBy ;
		public System.String ModifiedBy
		{
			get	
			{	
				return m_modifiedBy  ;
			}
			set	
			{	
				m_modifiedBy = value ;	
			}
		}
		

				/// <summary>
		/// 事务版本
		/// 客户信息.Sys.事务版本
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.Int64 m_sysVersion ;
		public System.Int64 SysVersion
		{
			get	
			{	
				return m_sysVersion  ;
			}
			set	
			{	
				m_sysVersion = value ;	
			}
		}
		

				/// <summary>
		/// 编码
		/// 客户信息.Misc.编码
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_code ;
		public System.String Code
		{
			get	
			{	
				return m_code  ;
			}
			set	
			{	
				m_code = value ;	
			}
		}
		

				/// <summary>
		/// 名称
		/// 客户信息.Misc.名称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_name ;
		public System.String Name
		{
			get	
			{	
				return m_name  ;
			}
			set	
			{	
				m_name = value ;	
			}
		}
		

				/// <summary>
		/// 简称
		/// 客户信息.Misc.简称
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_shortName ;
		public System.String ShortName
		{
			get	
			{	
				return m_shortName  ;
			}
			set	
			{	
				m_shortName = value ;	
			}
		}
		

				/// <summary>
		/// 备注
		/// 客户信息.Misc.备注
		/// </summary>
		[DataMember(IsRequired=false)]
		private System.String m_memo ;
		public System.String Memo
		{
			get	
			{	
				return m_memo  ;
			}
			set	
			{	
				m_memo = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_currency_SKey ;
		/// <summary>
		/// 币种 序列化Key属性。（传递跨组织序列列字段）
		/// 客户信息.Misc.币种
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Currency_SKey
		{
			get 
			{
				return m_currency_SKey ;					
			}
			set
			{
				 m_currency_SKey = value ;	
			}
		}
		/// <summary>
		/// 币种
		/// 客户信息.Misc.币种
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Currency
		{
			get	
			{	
				if (Currency_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Currency_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Currency_SKey = null ;
				else
				{
					if (Currency_SKey == null )
						Currency_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.Currency.Currency") ;
					else
						Currency_SKey.ID = value ;
				}
			}
		}
		

				/// <summary>
		/// 有效性
		/// 客户信息.Misc.有效性
		/// </summary>
		[DataMember(IsRequired=false)]
		private UFIDA.U9.Base.PropertyTypes.EffectiveData m_effective ;
		public UFIDA.U9.Base.PropertyTypes.EffectiveData Effective
		{
			get	
			{	
				return m_effective  ;
			}
			set	
			{	
				m_effective = value ;	
			}
		}
		

		
		private UFSoft.UBF.Business.BusinessEntity.EntityKey m_org_SKey ;
		/// <summary>
		/// 组织 序列化Key属性。（传递跨组织序列列字段）
		/// 客户信息.Misc.组织
		/// </summary>
		[DataMember(IsRequired=false)]
		public UFSoft.UBF.Business.BusinessEntity.EntityKey Org_SKey
		{
			get 
			{
				return m_org_SKey ;					
			}
			set
			{
				 m_org_SKey = value ;	
			}
		}
		/// <summary>
		/// 组织
		/// 客户信息.Misc.组织
		/// </summary>
		[DataMember(IsRequired=false)]
		public System.Int64 Org
		{
			get	
			{	
				if (Org_SKey == null)
					return UFSoft.UBF.Business.Entity.EmptyObjectValue ;
				else
					return Org_SKey.ID ;
			}
			set	
			{	
				if (value == 0 || value == UFSoft.UBF.Business.Entity.EmptyObjectValue )
					Org_SKey = null ;
				else
				{
					if (Org_SKey == null )
						Org_SKey = new UFSoft.UBF.Business.BusinessEntity.EntityKey(value,"UFIDA.U9.Base.Organization.Organization") ;
					else
						Org_SKey.ID = value ;
				}
			}
		}
		
		#endregion	

		#region Multi_Fields
													
		#endregion 		
	}	

}

