using Figures;

namespace FigureCalculator;

public static class FigureCalculator
{
	public static float GetArea(IFigure figure)
	{
		var area = figure switch
		{
			ICircle circle => GetCircleArea(circle),
			ITriangle triangle => GetTriangleArea(triangle),
			_ => throw new ArgumentOutOfRangeException(nameof(figure), figure, null)
		};
		return (float)Math.Round(area, 3);
	}

	private static double GetCircleArea(ICircle circle)
		=> Math.PI * Math.Pow(circle.Radius, 2);

	private static double GetTriangleArea(ITriangle triangle)
	{
		if (triangle.IsTriangleRight)
			return triangle.A * triangle.B / 2;

		var p = triangle.SemiPerimeter;
		return Math.Sqrt(p * (p - triangle.A) * (p - triangle.B) * (p - triangle.C));
	}
}