using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FoodSelection.Model
{
    public class FoodProductResponseDto
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Calories { get; set; }
        public double Protein { get; set; }
        public double Carbs { get; set; }
        public double Fats { get; set; }
        public string Category { get; set; } = null!;
        public bool IsVegan { get; set; }
        public bool IsVegetarian { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}