namespace MetroRush.Missions
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cyberpunk Daily Bounty & Encrypted Contract #045
    /// Defines repeatable high-speed objectives, hoverboard stunts, and token rewards.
    /// </summary>
    [CreateAssetMenu(fileName = "DailyBountyDefinition_045", menuName = "MetroRush/Missions/Bounty #045")]
    public class DailyBountyDefinition_045 : ScriptableObject
    {
        public enum BountyType { CollectTokens, DodgeTrains, RideHoverboard, JumpTrainRoofs, OutrunDrones }

        [SerializeField] private string bountyId = "BOUNTY_045";
        [SerializeField] private string title = "Encrypted Protocol #045";
        [SerializeField] private string briefing = "Complete the high-speed transit extraction without drone apprehension.";
        [SerializeField] private BountyType type = BountyType.DodgeTrains;
        [SerializeField] private int targetRequirement = 50 + (45 * 15);
        [SerializeField] private int rewardTokens = 500 + (45 * 30);

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
