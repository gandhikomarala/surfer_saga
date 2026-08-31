namespace MetroRush.Cosmetics
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cyberpunk Courier Skin & Neon Trail Definition #097
    /// Controls holographic visor shaders, particle exhaust colors, and unlock milestones.
    /// </summary>
    [CreateAssetMenu(fileName = "CyberSkinCatalog_097", menuName = "MetroRush/Cosmetics/Skin #097")]
    public class CyberSkinCatalog_097 : ScriptableObject
    {
        public enum SkinRarity { Standard, Enhanced, Quantum, CyberLegend }

        [Header("Skin Metadata")]
        [SerializeField] private string skinId = "CYBER_SKIN_097";
        [SerializeField] private string courierName = "Courier Outfit #097";
        [SerializeField] private SkinRarity rarity = SkinRarity.Quantum;
        [SerializeField] private Color neonGlow = new Color(0.0f, 0.95f, 1.0f, 0.9f);

        [Header("Progression Cost")]
        [SerializeField] private int requiredEnergyTokens = 600 + (97 * 40);
        [SerializeField] private int requiredDistanceMeters = 97 * 900;
        [SerializeField] private bool isUnlockedByDefault = false;

        public string SkinId => skinId;
        public string CourierName => courierName;
        public SkinRarity Rarity => rarity;
        public Color NeonGlow => neonGlow;
        public int RequiredEnergyTokens => requiredEnergyTokens;
        public int RequiredDistanceMeters => requiredDistanceMeters;

        public bool CanUnlock(int playerTokens, float playerDistance)
        {
            return playerTokens >= requiredEnergyTokens && playerDistance >= requiredDistanceMeters;
        }

        public float GetMultiplierBonus()
        {
            return rarity switch
            {
                SkinRarity.Standard => 1.0f,
                SkinRarity.Enhanced => 1.25f,
                SkinRarity.Quantum => 1.5f,
                SkinRarity.CyberLegend => 2.0f,
                _ => 1.0f
            };
        }
    }
}
