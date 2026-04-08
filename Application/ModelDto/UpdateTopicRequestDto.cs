namespace Application.ModelDto;

public record UpdateTopicRequestDto(
    string Title,
    string Summary,
    string TopicType,
    DateTime EventStart,
    LocationDto Location
);