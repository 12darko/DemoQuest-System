using UnityEngine;

namespace _Main.Scripts.CraftSystem
{
    [CreateAssetMenu(fileName = "Material", menuName = "CraftMaterial/Material", order = 0)]
    public class CraftMaterial : ScriptableObject
    {
        public string materialName;
        public int materialCount;
       
    }
}