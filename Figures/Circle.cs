namespace Figures;

public class Circle : ICircle
{
	/// <summary>
	/// Circle
	/// </summary>
	/// <param name="radius">Radius of a circle</param>
	/// <exception cref="ArithmeticException">Radius less or equal zero</exception>
	public Circle(float radius)
	{
		if (radius <= 0)
			throw new ArithmeticException();

		Radius = radius;
	}

	public double Radius { get; init; }
}