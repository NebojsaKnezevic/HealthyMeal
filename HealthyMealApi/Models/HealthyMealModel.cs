namespace HealthyMeal.api.Models
{
    public class HealthyMealModel
    {
        public Guid Id { get;  }
        public string Name { get;  }
        public string Description { get;  }
        //public int Healthy { get; }
        public DateTime StartDateTime { get; }
        public DateTime EndDateTime { get; }
        public DateTime LastModifiedDateTime { get; }
        public List<string> Savory { get; }
        public List<string> Sweet { get; }

        public HealthyMealModel(Guid id, string name, string description,
                       DateTime startDateTime, DateTime endDateTime,
                       List<string> savory, List<string> sweet)
        {
            //Here enforce invariants
            Id = id;
            Name = name;
            Description = description;
            //Healthy = healthy;
            StartDateTime = startDateTime;
            EndDateTime = endDateTime;
            LastModifiedDateTime = DateTime.Now;
            Savory = savory ?? new List<string>();
            Sweet = sweet ?? new List<string>();
        }
    }
}
