using UnityEngine;

// Narrow capability: something that can be stopped at a position
public interface IBlockable
{
    void BlockAt(Vector3 position);
}
