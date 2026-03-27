namespace FoodSelection.Models
{
    public class FoodProductDto
    {
        public string Name { get; set; } = null!;
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public string Category { get; set; } = null!;
        public bool IsVegan { get; set; }
        public bool IsVegetarian { get; set; }
    }

    
}
