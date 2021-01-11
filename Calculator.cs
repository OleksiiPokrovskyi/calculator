#if !MYCALCULATOR
#define MYCALCULATOR

namespace MyCalculator
{
	using System;
	public class Calculator : ICalculator {
		public double Add (double a, double b) {
			return a + b;
		}

		public double Sub (double a, double b) {
			return Add (a, -b);
		}
	}
}
#endif