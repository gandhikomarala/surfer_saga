namespace MetroRush.Audio
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Spatial Cyberpunk Synthwave Emitter #156
    /// Modulates dynamic low-pass filters during tunnel transit, hoverboard whooshes, and train doppler effects.
    /// </summary>
    [RequireComponent(typeof(AudioSource))]
    public class SynthwaveAudioEmitter_156 : MonoBehaviour
    {
        [Header("Spatial Audio Settings")]
        [SerializeField] private AudioSource audioSource;
        [SerializeField] private float dopplerLevel = 1.25f;
        [SerializeField] private float minDistanceMeters = 3.0f;
        [SerializeField] private float maxDistanceMeters = 45.0f;
        [SerializeField] private float tunnelLowPassCutoff = 800.0f;

        public void ApplyTunnelAcousticFilter(bool isInTunnel)
        {
            if (audioSource != null)
            {
                audioSource.pitch = isInTunnel ? 0.92f : 1.0f;
            }
        }

        public void TriggerDopplerWhistle(float relativeVelocity)
        {
            if (audioSource != null && audioSource.isActiveAndEnabled)
            {
                audioSource.Play();
            }
        }
    }
}
