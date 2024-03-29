namespace Alba.Required.Models
{
    public class RequiredModel
    {
        public required string Id { get; set; }
    }

    public class OptionalModel
    {
        public required string Id { get; set; }
    }

    public class Group
    {
        public required RequiredModel RequiredModel { get; set; }
        public OptionalModel? OptionalModel { get; set; }
    }
}
