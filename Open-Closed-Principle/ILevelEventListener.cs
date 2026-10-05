using UnityEngine;

// open for extension, new listeners can be added.
public interface ILevelEventListener
{
    void OnLevelFlip(bool isUprightRotation);
}
