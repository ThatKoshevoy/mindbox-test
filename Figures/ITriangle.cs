namespace Figures;

public interface ITriangle : IFigure
{

	/// <summary>
	/// Leg
	/// </summary>
	public float A { get; set; }

	/// <summary>
	/// Leg
	/// </summary>
	public  float B { get; set; }

	/// <summary>
	/// Hypotenuse
	/// </summary>
	public float C { get; set; }

	/// <summary>
	/// Sum of all sides
	/// </summary>
	public float Perimeter { get; }

	/// <summary>
	/// Half of the perimeter
	/// </summary>
	public float SemiPerimeter { get; }

	/// <summary>
	/// True if triangle is right, false otherwise
	/// </summary>
	public bool IsTriangleRight { get; }
}