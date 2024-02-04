namespace Figures;

public class Square : ISquare
{
	/// <summary>
	/// Square
	/// </summary>
	/// <param name="sideSize">size of square side</param>
	/// <exception cref="ArithmeticException">side is less or equal zero</exception>
	public Square(double sideSize)
	{
		if (sideSize <= 0)
			throw new ArithmeticException();
		
		SideSize = sideSize;
	}

	public double SideSize { get; set; }
}