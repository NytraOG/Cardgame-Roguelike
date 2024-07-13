// ReSharper disable InconsistentNaming

namespace CardgameRoguelike;

public sealed class EventSystemSingleton
{
    public delegate void DamageDealtEvent();

    private static readonly EventSystemSingleton instance = null;
    private static readonly object               padlock  = new();

    private EventSystemSingleton() { }

    public static EventSystemSingleton Instance
    {
        get
        {
            lock (padlock)
            {
                return instance ?? new EventSystemSingleton();
            }
        }
    }

    public event DamageDealtEvent DamageDealt;
}