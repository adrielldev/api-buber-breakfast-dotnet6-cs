namespace BuberBreakfast.Services.Breakfasts;
using BuberBreakfast.Models;

public class BreakfastService : IBreakfastService
{
    private static readonly Dictionary<Guid,Breakfast> _breakfasts = new();

    public void CreateBreakfast(Breakfast breakfast)
    {
        _breakfasts.Add(breakfast.Id,breakfast);
    }

    public Breakfast GetBreakfast(Guid id)
    {
        return _breakfasts[id];
    }
}