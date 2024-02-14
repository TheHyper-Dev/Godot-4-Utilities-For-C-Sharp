using Godot;

public static class Physics
{
    private static readonly StringName
    position = "position",
    collider = "collider",
    collider_id = "collider_id",
    collider_rid = "rid",
    normal = "normal",
    shape = "shape";

    public static Vector3 CollisionPoint(Godot.Collections.Dictionary cast_result) => (Vector3)cast_result[position];
    public static Vector3 CollisionNormal(Godot.Collections.Dictionary cast_result) => (Vector3)cast_result[normal];
    public static int CollisionShapeIndex(Godot.Collections.Dictionary cast_result) => (int)cast_result[shape];
    public static Variant Collider(Godot.Collections.Dictionary cast_result) => cast_result[collider];
    public static int ColliderID(Godot.Collections.Dictionary cast_result) => (int)cast_result[collider_id];
    public static Rid ColliderRID(Godot.Collections.Dictionary cast_result) => (Rid)cast_result[collider_rid];
    public static T Collider<T>(Godot.Collections.Dictionary cast_result) where T : CollisionObject3D => (T)cast_result[collider];
}
