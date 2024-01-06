using System;
using _Main.Scripts.CraftSystem.Old_System_Example;
using UnityEngine;
using Random = UnityEngine.Random;


namespace _Main.Scripts.CraftSystem
{
    public class MaterialController : MonoBehaviour
    {
        /*Materyal Düşücek Objelere,moblara eklenicek*/

        [SerializeField] private int materialAmount;
    
        public int MaterialAmount
        {
            get => materialAmount;
            set => materialAmount = value;
        }

        public void Controller(MaterialType type)
        {
            var cManager = CraftManager.Instance;

            switch (type)
            {
                case MaterialType.Uranium:
                    materialAmount = Random.Range(1, 50);
                    break;
                case MaterialType.Affaryum:
                    materialAmount = Random.Range(1, 50);
                    break;
                case MaterialType.Letanyum:
                    materialAmount = Random.Range(1, 50);
                    break;
                case MaterialType.Setanyum:
                    materialAmount = Random.Range(1, 50);
                    break;
                case MaterialType.Gold:
                    materialAmount = Random.Range(1, 50);
                    break;
                case MaterialType.Silver:
                    materialAmount = Random.Range(1, 50);
                    break;
                case MaterialType.None:
                    materialAmount = 0;
                    break;
                default:
                    materialAmount = 1;
                    break;
            }
        }
    }
}