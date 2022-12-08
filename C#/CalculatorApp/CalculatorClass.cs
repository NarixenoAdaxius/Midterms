using System;

public delegate double Formulas(double num1, double num2);

public class CalculatorClass
{
	public Formulas Sum;
	public Formulas Difference;
	public Formulas Product;
	public Formulas Quotient;


	// Event Accessors
	public event Formulas SumEvent
    {
        add
        {
			Console.WriteLine("Adding the delegate to the event " + value);
			Sum += value;
        }
        remove
        {
			Console.WriteLine("Removing the delegate from the event " + value);
			Sum -= value;
        }
    }
	public event Formulas DifferenceEvent
	{
		add
		{
			Console.WriteLine("Adding the delegate to the event " + value);
			Difference += value;
		}
		remove
		{
			Console.WriteLine("Removing the delegate from the event " + value);
			Difference -= value;
		}
	}
	public event Formulas ProductEvent
	{
		add
		{
			Console.WriteLine("Adding the delegate to the event " + value);
			Product += value;
		}
		remove
		{
			Console.WriteLine("Removing the delegate from the event " + value);
			Product -= value;
		}
	}
	public event Formulas QuotientEvent
	{
		add
		{
			Console.WriteLine("Adding the delegate to the event " + value);
			Quotient += value;
		}
		remove
		{
			Console.WriteLine("Removing the delegate from the event " + value);
			Quotient -= value;
		}
	}

	//Delegate methods
	public double addNumbers(double num1, double num2)
	{
		Console.WriteLine("Sum: "+ (num1+num2));
		return num1 + num2;
	}
	public double subtractNumbers(double num1, double num2)
	{
		Console.WriteLine("Difference " + (num1 - num2));
		return num1 - num2;
	}
	public double multiplyNumbers(double num1, double num2)
	{
		Console.WriteLine("Product: " + (num1 * num2));
		return num1 * num2;
	}
	public double divideNumbers(double num1, double num2)
	{
		if (num2 == 0)
        {
			throw new DivideByZeroException();
        }
		Console.WriteLine("Quotient: " + (num1 / num2));
		return num1 / num2;
	}
	// AUTHOR : N4RX(DAUIS)
}
