namespace BuberDinner.Application.Services.Authentication;

public record ApplicationResult(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token
);
