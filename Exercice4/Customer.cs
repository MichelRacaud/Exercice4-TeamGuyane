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
			bool cidbool;
			int cidint;
			for (var i = 0; i < cid.Length; i++)
			{
				char chari = cid[i];
				if (char.IsDigit(chari) == false)
                {
					throw new BadIDException();
				}
			}
			cidbool = int.TryParse(cid, out cidint);
			if (cidbool == false)
			{
				throw new BadIDException();
			}
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
