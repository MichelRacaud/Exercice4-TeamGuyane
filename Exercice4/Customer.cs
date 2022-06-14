using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class Customer : ICustomer
	{
		string cid;
		string name;

		public Customer(string cid, string name)
		{
			this.cid = cid;
			this.name = name;
		}

		int IComparable<ICustomer>.CompareTo(ICustomer other)
		{
			throw new NotImplementedException();
		}

		bool IEquatable<ICustomer>.Equals(ICustomer other)
		{
			throw new NotImplementedException();
		}

		string ICustomer.GetCID()
		{
			return this.cid;
		}

		string IPerson.GetName()
		{
			return this.name;
		}

		void IPrintable.Print(IPrinter printer)
		{
			printer.PrintLine("[" + this.cid + "] " + this.name);
		}
	}
}
