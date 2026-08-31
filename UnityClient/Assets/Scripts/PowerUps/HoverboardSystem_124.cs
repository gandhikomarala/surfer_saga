namespace MetroRush.PowerUps
{
    using System;
    using UnityEngine;

    /// <summary>
    /// High-Tech Hoverboard & Quantum Power-Up #124
    /// Handles double-tap hoverboard summon, secondary collision buffer, and particle exhaust trails.
    /// </summary>
    public class HoverboardSystem_124 : MonoBehaviour
    {
        public enum PowerUpClass { Hoverboard, QuantumPull, PulseShield, VelocityDrive, ScoreAmplifier }

        [Header("Hoverboard Configuration")]
        [SerializeField] private PowerUpClass powerUpClass = PowerUpClass.Hoverboard;
        [SerializeField] private float activeDurationSeconds = 30.0f;
        [SerializeField] private float speedMultiplier = 1.35f;
        [SerializeField] private bool absorbsFatalImpact = true;

        public PowerUpClass Type => powerUpClass;
        public float ActiveDurationSeconds => activeDurationSeconds;
        public bool AbsorbsFatalImpact => absorbsFatalImpact;

        public void ActivateHoverboard()
        {
            // Trigger hoverboard mesh attachment and magnetic particle thrusters
        }
    }
}
