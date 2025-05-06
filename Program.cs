
            using System;

class Program
        {
            // Calculate the perimeter of the circular pond
            static double CalculatePerimeter(double radius) => 2 * Math.PI * radius;

            // Calculate the number of tiles needed for covering the pond wall
            static int CalculateTilesForWall(double perimeter, double height, double tileSize)
            {
                double wallArea = perimeter * height;
                return (int)Math.Ceiling(wallArea / tileSize);
            }

            // Calculate the number of tiles needed for covering the gallery floor
            static int CalculateTilesForFloor(double area, double tileSize) =>
                (int)Math.Ceiling(area / tileSize);

            static void Main()
            {
                // Get the radius of the circular pond
                Console.Write("Enter the radius of the circular pond (in meters): ");
                double radius = double.Parse(Console.ReadLine());

                if (radius < 0)
                {
                    Console.WriteLine("The radius cannot be negative!");
                }
                else
                {
                    // Calculate the perimeter of the pond and the number of tiles for the pond wall
                    double perimeter = CalculatePerimeter(radius);
                    Console.WriteLine($"The perimeter of the pond: {perimeter} meters");

                    double tileSizeForWall = 0.0225; // Area of each 15×15 cm tile
                    int numTilesForWall = CalculateTilesForWall(perimeter, 0.3, tileSizeForWall); // Height of 30 cm
                    Console.WriteLine($"Number of tiles needed (15×15 cm) to cover the pond wall: {numTilesForWall} tiles");
                }

                // Get the area of the gallery
                Console.Write("\nEnter the area of the gallery (square meters): ");
                double area = double.Parse(Console.ReadLine());

                if (area < 0)
                {
                    Console.WriteLine("The area cannot be negative!");
                }
                else
                {
                    // Calculate the number of tiles for the gallery floor
                    double tileSizeForFloor = 0.18; // Area of each 60×30 cm tile
                    int numTilesForFloor = CalculateTilesForFloor(area, tileSizeForFloor);
                    Console.WriteLine($"Number of tiles needed (60×30 cm) to cover the gallery floor: {numTilesForFloor} tiles");
                }
            }
        }
