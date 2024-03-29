using Figures;

namespace FigureCalculator.Tests;

public class FigureCalculatorTests
{
	[Theory]
	[InlineData(12, 452.389)]
	[InlineData(43, 5808.804)]
	[InlineData(14.5, 660.519)]
	public void GetCircleArea_True(
		float radius,
		float expectedResult
	)
	{
		var circle = new Circle(radius);

		var actualResult = FigureCalculator.GetArea(circle);

		Assert.Equal(expectedResult, actualResult, 0.1);
	}

	[Theory]
	[InlineData(12, 454.389)]
	[InlineData(43, 589.804)]
	[InlineData(14.5, 620.519)]
	public void GetCircleArea_False(
		float radius,
		float expectedResult
	)
	{
		var circle = new Circle(radius);

		var actualResult = FigureCalculator.GetArea(circle);

		Assert.NotEqual(expectedResult, actualResult);
	}

	[Theory]
	[InlineData(12, 15, 19, 89.977)]
	[InlineData(7, 24, 25, 84)]
	[InlineData(3, 3, 3, 3.897)]
	public void GetTriangleArea_True(
		float a,
		float b,
		float c,
		float expectedResult
	)
	{
		var triangle = new Triangle(a, b, c);

		var actualResult = FigureCalculator.GetArea(triangle);

		Assert.Equal(expectedResult, actualResult, 0.1);
	}

	[Theory]
	[InlineData(12, 15, 19, 89.876)]
	[InlineData(7, 24, 25, 85)]
	[InlineData(3, 3, 3, 4.897)]
	public void GetTriangleArea_False(
		float a,
		float b,
		float c,
		float expectedResult
	)
	{
		var triangle = new Triangle(a, b, c);

		var actualResult = FigureCalculator.GetArea(triangle);

		Assert.NotEqual(expectedResult, actualResult);
	}
	
	[Theory]
	[InlineData(5, 24)]
	[InlineData(4, 17)]
	[InlineData(2, 5)]
	public void GetSquareArea_False(
		float side,
		float expectedResult
	)
	{
		var square = new Square(side);

		var actualResult = FigureCalculator.GetArea(square);

		Assert.NotEqual(expectedResult, actualResult);
	}
	
	[Theory]
	[InlineData(5, 25)]
	[InlineData(4, 16)]
	[InlineData(2, 4)]
	public void GetSquareArea_True(
		float side,
		float expectedResult
	)
	{
		var square = new Square(side);

		var actualResult = FigureCalculator.GetArea(square);

		Assert.Equal(expectedResult, actualResult, 0.1);
	}
}