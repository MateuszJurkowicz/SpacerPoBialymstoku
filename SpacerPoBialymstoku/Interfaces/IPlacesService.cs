using SpacerPoBialymstoku.Models;

namespace SpacerPoBialymstoku.Interfaces
{
    public interface IPlacesService
    {
        IList<Place> GetPlacesFromDatabase();
        void SavePlace(Place place);
        Place GetPlaceFromDatabase(int id);
        void DeletePlaceFromDatabase(Place place);
        void UpdatePlaceInDatabase(Place place);
        void IncreasePlaceRating(int id);
        void DecreasePlaceRating(int id);
    }
}
