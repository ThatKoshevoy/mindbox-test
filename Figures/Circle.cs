namespace Figures;

public class Circle : ICircle
{
	public Circle(float radius)
	{
		if (radius <= 0)
			throw new ArithmeticException();

		Radius = radius;
	}

	public double Radius { get; init; }
}