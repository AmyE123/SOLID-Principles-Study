using UnityEngine;

// Narrow capability: something that can be killed and respawned
public interface IKillable
{
    void Kill(ParticleSystem explosion);
}
