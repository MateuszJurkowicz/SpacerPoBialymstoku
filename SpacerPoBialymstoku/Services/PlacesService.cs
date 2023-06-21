using SpacerPoBialymstoku.Data;
using SpacerPoBialymstoku.Interfaces;
using SpacerPoBialymstoku.Models;

namespace SpacerPoBialymstoku.Services
{
    public class PlacesService : IPlacesService
    {
        private readonly PlaceDbContext _context;
        public PlacesService(PlaceDbContext context)
        {
            _context = context;
        }
        public IList<Place> GetPlacesFromDatabase()
        {
            return _context.Place.ToList();
        }
        public void SavePlace(Place place)
        { 
            _context.Place.Add(place);
            _context.SaveChanges();
        }
        public Place GetPlaceFromDatabase(int id)
        {
            return _context.Place.Find(id);
        }
        public void DeletePlaceFromDatabase(Place place) 
        {
            _context.Place.Remove(place);
            _context.SaveChanges();
        }
        public void UpdatePlaceInDatabase(Place Newplace)
        {
            Place place = _context.Place.Find(Newplace.Id);
            place.Title = Newplace.Title;
            place.Description = Newplace.Description;
            place.OldImageData = Newplace.OldImageData;
            place.ActualImageData = Newplace.ActualImageData;
            _context.SaveChanges();
        }
        public void IncreasePlaceRating(int Id)
        {
            _context.Place.Find(Id).Rating++;
            _context.SaveChanges();
        }
        public void DecreasePlaceRating(int Id)
        {
            _context.Place.Find(Id).Rating--;
            _context.SaveChanges();
        }
    }
}
