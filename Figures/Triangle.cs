namespace Figures;

public class Triangle : ITriangle
{
	/// <summary>
	/// Triangle
	/// </summary>
	/// <param name="a">Leg</param>
	/// <param name="b">Leg</param>
	/// <param name="c">Hypotenuse</param>
	/// <exception cref="ArithmeticException">If any of arguments less or equal zero</exception>
	public Triangle(float a, float b, float c)
	{
		if (a <= 0 || b <= 0 || c <= 0)
			throw new ArithmeticException();

		A = a;
		B = b;
		C = c;
	}

	public float A { get; set; }

	public float B { get; set; }

	public float C { get; set; }

	public float Perimeter => A + B + C;

	public float SemiPerimeter => Perimeter / 2;

	public bool IsTriangleRight => Math.Pow(C, 2).Equals(Math.Pow(A, 2) + Math.Pow(B, 2));
}