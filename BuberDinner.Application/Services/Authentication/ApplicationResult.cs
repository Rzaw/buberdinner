using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Services.Authentication;

public record ApplicationResult(
    User User,
    string Token
);
