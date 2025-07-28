

using Content.Shared.Actions;
using Robust.Shared.GameStates;

namespace Content.Shared.UndeadPirates.BoneyJonesLocker;

#region Events - Basic

public sealed partial class OpenTreasureMenuEvent : InstantActionEvent { }
public sealed partial class OnClosedEvent : EntityTargetActionEvent { }
public sealed partial class OnDeliverEvent : InstantActionEvent { }

#endregion