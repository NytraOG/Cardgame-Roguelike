// ReSharper disable InconsistentNaming

namespace CardgameRoguelike;

public sealed class EventSystemSingleton
{
    private static readonly EventSystemSingleton instance = null;
    private static readonly object               padlock  = new();

    private EventSystemSingleton() { }

    public EventSystemSingleton Instance
    {
        get
        {
            lock (padlock)
            {
                return instance ?? new EventSystemSingleton();
            }
        }
    }
}