using System;
using System.Globalization;
using System.Threading;

namespace MultilingualApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("CurrentCulture: {0}", Thread.CurrentThread.CurrentCulture.Name);

			// 日本語
			Console.WriteLine(Strings.HelloWorld);

			// 英語
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
			Console.WriteLine(Strings.HelloWorld);

			// フランス語
			Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
			Console.WriteLine(Strings.HelloWorld);
		}
	}
}
