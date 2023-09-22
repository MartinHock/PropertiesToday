using Domain;

namespace Application
{
    public interface IPropertyRepo
    {
        IEnumerable<Property> GetAllProperties();
        Property GetPropertyById(int id);
        void AddProperty(Property property);
        void UpdateProperty(Property property);
        void DeleteProperty(Property property);
        bool SaveChanges();
    }
}