namespace YourProjectName.Final.Models
{
    public class EntityName
    {
        public int Id { get; set; }
        public Property1Type Property1Name { get; set; }
        public Property2Type Property2Name { get; set; }
        public Property3Type Property3Name { get; set; }

        public EntityName(Property1Type property1Name, Property2Type property2Name, Property3Type property3Name)
        {
            Property1Name = property1Name;
            Property2Name = property2Name;
            Property3Name = property3Name;
        }

        public override string ToString()
        {
            return $"{Property1Name} ({Property2Name}: {Property2Name}, {Property3Name}: {Property3Name})";
        }
    }
}
