using TMPro;
using UnityEngine;

namespace _Main.Scripts.CraftSystem.Old_System_Example
{
    public class MaterialList : MonoBehaviour
    {
        public void List()
        {
            var cManager = CraftManager.Instance;
            foreach (var cHolder in cManager.MaterialHolders)
            {
                var item = Instantiate(cManager.MaterialObject,cManager.Content.transform);
                cManager.CoinTextUpdate += () =>
                {
                    item.transform.GetChild(1).GetComponent<TMP_Text>().text =
                        cHolder.craftMaterials.materialCount.ToString();
                };

            }
        }
    }
}