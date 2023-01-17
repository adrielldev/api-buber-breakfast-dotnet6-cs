namespace BuberBreakfast.Services.Breakfasts;
using BuberBreakfast.Models;
using ErrorOr;

public interface IBreakfastService
{

    void CreateBreakfast(Breakfast breakfast);
    void DeleteBreakfast(Guid id);
    ErrorOr<Breakfast> GetBreakfast (Guid id);
    void UpsertBreakfast(Breakfast breakfast);
}