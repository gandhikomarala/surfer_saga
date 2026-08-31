namespace MetroRush.Missions
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cyberpunk Daily Bounty & Encrypted Contract #237
    /// Defines repeatable high-speed objectives, hoverboard stunts, and token rewards.
    /// </summary>
    [CreateAssetMenu(fileName = "DailyBountyDefinition_237", menuName = "MetroRush/Missions/Bounty #237")]
    public class DailyBountyDefinition_237 : ScriptableObject
    {
        public enum BountyType { CollectTokens, DodgeTrains, RideHoverboard, JumpTrainRoofs, OutrunDrones }

        [SerializeField] private string bountyId = "BOUNTY_237";
        [SerializeField] private string title = "Encrypted Protocol #237";
        [SerializeField] private string briefing = "Complete the high-speed transit extraction without drone apprehension.";
        [SerializeField] private BountyType type = BountyType.DodgeTrains;
        [SerializeField] private int targetRequirement = 50 + (237 * 15);
        [SerializeField] private int rewardTokens = 500 + (237 * 30);

        public string BountyId => bountyId;
        public string Title => title;
        public string Briefing => briefing;
        public BountyType Type => type;
        public int TargetRequirement => targetRequirement;
        public int RewardTokens => rewardTokens;

        public bool EvaluateCompletion(int currentProgress)
        {
            return currentProgress >= targetRequirement;
        }
    }
}
