using UnityEngine;

[CreateAssetMenu(fileName = "Room", menuName = "Scriptable Objects/Room")]
public class RoomSO : ScriptableObject
{
    public Room roomPrefab;
    public RoomSO[] nextRooms;
    public bool hasMultipleExits;

}
