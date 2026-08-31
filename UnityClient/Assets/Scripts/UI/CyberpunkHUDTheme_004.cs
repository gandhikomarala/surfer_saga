namespace MetroRush.UI
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cyberpunk HUD Visual Theme & CRT Post-Processing #004
    /// Renders holographic speedometers, token multipliers, scanlines, and chromatic aberration.
    /// </summary>
    [CreateAssetMenu(fileName = "CyberpunkHUDTheme_004", menuName = "MetroRush/UI/HUD Theme #004")]
    public class CyberpunkHUDTheme_004 : ScriptableObject
    {
        [Header("HUD Color Palette")]
        [SerializeField] private string themeId = "HUD_THEME_004";
        [SerializeField] private Color primaryNeonCyan = new Color(0.0f, 0.95f, 1.0f, 1.0f);
        [SerializeField] private Color warningMagenta = new Color(0.95f, 0.1f, 0.6f, 1.0f);
        [SerializeField] private float scanlineIntensity = 0.35f;
        [SerializeField] private bool enableGlitchDistortion = true;

        public string ThemeId => themeId;
        public Color PrimaryColor => primaryNeonCyan;
        public Color WarningColor => warningMagenta;
        public float ScanlineIntensity => scanlineIntensity;

        public void ApplyThemeToCanvas(Canvas targetCanvas)
        {
            // Apply holographic shaders and scanline overlays
        }
    }
}
