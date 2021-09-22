using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries
{
    class Country
    {

		//atributes
		public String name;
		public String capital;
		public String language;
		public double population;
		public String continent;
		private bool english;


		//constructor
		public Country(String n, String cap, String lang, double pop, String cont, bool eng)
		{

			this.name = n;
			this.capital = cap;
			this.language = lang;
			this.population = pop;
			this.continent = cont;
			this.english = eng;

		}

		public String getName()
		{
			return this.name;
		}

		public void setName(String n)
		{
			this.name = n;
		}


		public String getCapital()
		{
			return this.capital;
		}

		public void setCapital(String cap)
		{
			this.capital = cap;
		}

		public String getLanguage()
		{
			return this.language;
		}

		public void setLanguage(String lang)
		{
			this.language = lang;
		}

		public double getPopulation()
		{
			return this.population;
		}

		public void setPopulation(double pop)
		{
			this.population = pop;
		}

		public String getContinent()
		{
			return this.continent;
		}

		public void setContinent(String cont)
		{
			this.continent = cont;
		}


		public String available(bool av)
		{
			return av ? "Yes" : "No";
		}


		public void profile()
		{
			Console.WriteLine("==================================================");
			Console.WriteLine("Name: " + this.name);
			Console.WriteLine("Capital: " + this.getCapital());
			Console.WriteLine("Habitants: " + this.getPopulation() + " million");
			Console.WriteLine("Official Language: " + this.getLanguage());
			Console.WriteLine("Continent: " + this.getContinent());
			Console.WriteLine("English Available: " + available(this.english));
			Console.WriteLine("==================================================");

		}
	}
}
