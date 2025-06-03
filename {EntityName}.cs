// IMPORTANT: Replace YourProjectName with your actual project's root namespace (e.g., LashaShraieri)
namespace YourProjectName.Final.Models
{
    // IMPORTANT: Replace {EntityName} with the singular name of your entity (e.g., Car, Cat, Person)
    public class {EntityName}
    {
        public int Id { get; set; }
        // IMPORTANT: Replace {Property1Name} and {Property1Type} with your actual property names and C# types
        public {Property1Type} {Property1Name} { get; set; } // e.g., public string Model { get; set; }
        public {Property2Type} {Property2Name} { get; set; } // e.g., public float Weight { get; set; }
        public {Property3Type} {Property3Name} { get; set; } // e.g., public int Speed { get; set; }

        // IMPORTANT: Update constructor parameters and assignments to match your new properties
        public {EntityName}({Property1Type} {Property1Name.ToLower()}, {Property2Type} {Property2Name.ToLower()}, {Property3Type} {Property3Name.ToLower()})
        {
            {Property1Name} = {Property1Name.ToLower()};
            {Property2Name} = {Property2Name.ToLower()};
            {Property3Name} = {Property3Name.ToLower()};
        }

        public override string ToString()
        {
            // IMPORTANT: Adjust this string to display your new properties meaningfully in the listbox
            // Example for Car: return $"{Model} (Weight: {Weight} kg, Speed: {Speed} km/h)";
            // Example for Cat: return $"{Name} (Breed: {Breed}, Age: {Age} years)";
            return $"{Property1Name} ({Property2Name}: {Property2Name}, {Property3Name}: {Property3Name})";
        }
    }
}
