namespace Conference.Data;

public class Session
{
    public int Id { get; init; }

    public DateTime When { get; init; }

    public Author? Chair { get; set; }

    public HashSet<Lecture> Lectures { get; init; } = new HashSet<Lecture>();

    public Session(int sessionId, DateTime when) =>
        (Id, When) = (sessionId, when);
}