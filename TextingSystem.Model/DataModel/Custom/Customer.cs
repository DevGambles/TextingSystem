using TextingSystem.Core.Domain;

namespace TextingSystem.Model.DataModel
{
    public partial class CustomerProfile : IAggregateRoot
    {
        public CustomerProfile()
        {
        }
        public string title { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string phone { get; set; }
        public string company { get; set; }
        public string userName { get; set; }
        public string UserId { get; set; }
        public string email { get; set; }
    }

}
