namespace MetroRush.Missions
{
    using System;
    using UnityEngine;

    /// <summary>
    /// Cyberpunk Daily Bounty & Encrypted Contract #020
    /// Defines repeatable high-speed objectives, hoverboard stunts, and token rewards.
    /// </summary>
    [CreateAssetMenu(fileName = "DailyBountyDefinition_020", menuName = "MetroRush/Missions/Bounty #020")]
    public class DailyBountyDefinition_020 : ScriptableObject
    {
        public enum BountyType { CollectTokens, DodgeTrains, RideHoverboard, JumpTrainRoofs, OutrunDrones }

        [SerializeField] private string bountyId = "BOUNTY_020";
        [SerializeField] private string title = "Encrypted Protocol #020";
        [SerializeField] private string briefing = "Complete the high-speed transit extraction without drone apprehension.";
        [SerializeField] private BountyType type = BountyType.DodgeTrains;
        [SerializeField] private int targetRequirement = 50 + (20 * 15);
        [SerializeField] private int rewardTokens = 500 + (20 * 30);

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
