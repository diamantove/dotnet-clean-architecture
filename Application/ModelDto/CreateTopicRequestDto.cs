using Domain.ValueObjects;

namespace Application.ModelDto;

public record CreateTopicRequestDto (
    string Title,
    string Summary,
    string TopicType,
    DateTime EventStart,
    LocationDto Location
);

