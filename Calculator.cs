#if !MYCALCULATOR
#define MYCALCULATOR

namespace MyCalculator
{
	using System;
	public class Calculator : ICalculator {
		public int Add (double a, double b) {
			return (int)(a + b);
		}

		public int Sub (double a, double b) {
			return Add (a, -b);
		}
	}
}
#endif