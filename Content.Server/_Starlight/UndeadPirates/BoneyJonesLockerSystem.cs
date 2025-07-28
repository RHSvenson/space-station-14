using Content.Server.Storage.Components;
using Content.Shared.UndeadPirates.BoneyJonesLocker;
using Content.Shared.Nutrition.EntitySystems;

namespace Content.Server.UndeadPirates.BoneyJonesLocker;


public sealed partial class BoneyJonesLockerSystem : EntitySystem
{

    public void Initalize()
    {
        base.Initialize();

        SubscribeLocalEvent<BoneyJonesLockerComponent, OpenableOpenedEvent>(OnOpened);
        SubscribeLocalEvent<BoneyJonesLockerComponent, OpenableClosedEvent>(OnClosed);
    }

    #region Basic Actions

    private void OnOpened(EntityUid uid, BoneyJonesLockerComponent? locker, OpenableOpenedEvent args)
    {
    
    }

    private void OnClosed(EntityUid uid, BoneyJonesLockerComponent? locker, OpenableClosedEvent args)
    {
        if (!TryComp<EntityStorageComponent>(uid, out var contents))
            return;

        ConsumeTreasure(uid, locker, contents);

    }
    /// <summary>
    /// Triggered when the locker is closed, consuming all within it.
    /// </summary>
    /// <param name="uid"></param>
    private void ConsumeTreasure(EntityUid uid, BoneyJonesLockerComponent? locker = null, EntityStorageComponent? contents = null)
    {
        
    }
    
    #endregion
}