using Content.Shared.Body.Systems;
using Robust.Shared.Containers;
using Robust.Shared.GameStates;
using Content.Shared.Body.Components;
using Content.Shared.Body.Part;

namespace Content.Shared.Body.Bone;

public sealed partial class BoneComponent : Component
{
    /// <summary>
    /// The Uid of the body this bone is in
    /// </summary>
    [DataField, AutoNetworkedField]
    public EntityUid? body;

    /// <summary>
    /// The part this bone belongs in, and which it functions in
    /// </summary>
    [DataField, AutoNetworkedField]
    public BodyPartType intendedPart = BodyPartType.Other;

    /// <summary>
    /// Organs inside this bone.
    /// </summary>
    [DataField, AutoNetworkedField]
    public Dictionary<string, OrganSlot> organs = new();

    /// <summary>
    /// Whether or not this bone is essential for moving the child-parts of its host part.
    /// Aka, if you break your hip, you can't use your legs either.
    /// If you break your spine, nothing below it works either.
    /// </summary>
    [DataField, AutoNetworkedField]
    public bool jointEssentiality = false;
}