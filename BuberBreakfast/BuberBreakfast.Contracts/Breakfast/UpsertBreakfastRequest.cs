namespace BuberBreakfast.Contracts.Breakfast;
using System;
using System.Collections.Generic;

public record UpsertBreakfastRequest(

    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> Savory,
    List<string> Sweet);