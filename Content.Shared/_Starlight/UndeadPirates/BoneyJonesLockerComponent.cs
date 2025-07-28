

using Robust.Shared.Audio;
using Robust.Shared.GameStates;

namespace Content.Shared.UndeadPirates.BoneyJonesLocker;

[RegisterComponent, NetworkedComponent]
[AutoGenerateComponentState]
public sealed partial class BoneyJonesLockerComponent : Component
{
    #region Prototypes

    [DataField]
    public List<SoundSpecifier?> ConsumeSoundPool = new()
    {
        new SoundPathSpecifier("/Audio/Effects/gib1.ogg"),
        new SoundPathSpecifier("/Audio/Effects/gib2.ogg"),
        new SoundPathSpecifier("/Audio/Effects/gib3.ogg"),
    };

    public List<SoundSpecifier?> OpenForConsumeSoundPool = new();

    public List<SoundSpecifier?> OpenForDeliverySoundPool = new();

    /// <summary>
    /// Used for when the pirates buy something.
    /// </summary>
    public bool HasDelivery = false;

    /// <summary>
    /// How much treasure the Locker has absorbed; used as currency by the Pirate Captain.
    /// </summary>
    [DataField, AutoNetworkedField]
    public float Treasure = 20f;

    #endregion
}