using UnityEngine;

namespace _Main.Scripts.QuestSystem
{
    [CreateAssetMenu(fileName = "Quest", menuName = "QuestSystem/Quest", order = 0)]
    public class Quest : ScriptableObject
    {
        [SerializeField] private string questTitle;
        [SerializeField] private string questMessage;
        
        public string QuestTitle
        {
            get => questTitle;
            set => questTitle = value;
        }

        public string QuestMessage
        {
            get => questMessage;
            set => questMessage = value;
        }

    }
}