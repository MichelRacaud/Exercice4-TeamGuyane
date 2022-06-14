using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
	public class Employee : IEmployee
	{
		string eid;
		string name;

		public Employee(string eid, string name)
		{
			if (eid.Length != 3)
			{
				throw new BadIDException();
			}
			for (var i = 0; i <= 2; i++)
			{
				char chari = eid[i];
				if (char.IsLetter(chari) == false)
				{
					throw new BadIDException();
				}
			}
			this.eid = eid;
			this.name = name;
		}

		int IComparable<IEmployee>.CompareTo(IEmployee other)
		{
			throw new NotImplementedException();
		}

		bool IEquatable<IEmployee>.Equals(IEmployee other)
		{
			throw new NotImplementedException();
		}

		string IEmployee.GetEID()
		{
			return this.eid;
		}

		string IPerson.GetName()
		{
			return this.name;
		}

		void IPrintable.Print(IPrinter printer)
		{
			printer.PrintLine("[" + this.eid + "] " + this.name);
		}
	}
}
