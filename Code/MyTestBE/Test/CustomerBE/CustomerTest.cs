
using System;
using System.Collections;
using System.Transactions;
using NUnit.Framework;
using UFSoft.UBF.Business;

namespace UFIDA.U9.CC.CustomerBE.TestSuite{

	/// <summary>
	/// Customer Auto Test Class
	/// </summary>
	[TestFixture]
	public partial class CustomerTest{
		/// <summary>
		/// test Create
		/// </summary>
		//[Test]
		public void CustomerCRUD() {
		/*	using (TransactionScope scope = new TransactionScope())
			{
				#region __merge CustomVariable
				UFIDA.U9.CC.CustomerBE.Customer obj;
				//add you custome variable code here ...
				#endregion

				using (ISession session = Session.Open()) {
					#region __merge CreateCustomer
										obj  = UFIDA.U9.CC.CustomerBE.Customer.Create() ;
					//add you custome assign code here ...
					#endregion

					Assert.IsNotNull(obj, " Create <" + typeof(Customer).ToString() + "> failed.");
					session.Commit();
				}
	
				UFIDA.U9.CC.CustomerBE.Customer.EntityList list = UFIDA.U9.CC.CustomerBE.Customer.Finder.FindAll("");
				Assert.IsTrue(list.Contains(obj), " Add <" + typeof(UFIDA.U9.CC.CustomerBE.Customer).ToString() + "> failed.");
				using (ISession session = Session.Open()) {
					#region __merge RemoveCustomer	
					obj.Remove();
					//add you custom remove code here ...
					#endregion

					session.Commit();
				}
				list = UFIDA.U9.CC.CustomerBE.Customer.Finder.FindAll("");
				Assert.IsFalse(list.Contains(obj), " Delete <" + typeof(UFIDA.U9.CC.CustomerBE.Customer).ToString() + "> failed.");
			}
		*/
		}
	}
}

