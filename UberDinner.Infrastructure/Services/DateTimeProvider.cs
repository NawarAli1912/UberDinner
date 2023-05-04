using UberDinner.Application.Common.Services;

namespace UberDinner.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow; 
}
