namespace Application.ModelDto;

public record TopicResponseDto(
    Guid Id,
    string Title,
    string Summary,
    string TopicType,
    DateTime EventStart,
    LocationDto Location
);