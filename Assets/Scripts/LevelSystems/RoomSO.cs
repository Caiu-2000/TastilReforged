using UnityEngine;

[CreateAssetMenu(fileName = "Room", menuName = "Scriptable Objects/Room")]
public class RoomSO : ScriptableObject
{
    public Room roomPrefab;
    public Room[] nextRoom;
    public bool isFirstRoom;
    public bool hasMultipleExits;
}
