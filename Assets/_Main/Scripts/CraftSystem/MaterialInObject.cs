using System;
using _Main.Scripts.CraftSystem;
using _Main.Scripts.CraftSystem.Old_System_Example;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Main.Scripts
{
    public class MaterialInObject : MonoBehaviour
    {
        [SerializeField] private MaterialType type;
        [SerializeField] private MaterialController controller;
        [SerializeField] private int qId;
        public int QId
        {
            get => qId;
            set => qId = value;
        }

        public MaterialType Type => type;

        public MaterialController Controller => controller;

        private void Start()
        {
            type = (MaterialType)Random.Range(1, System.Enum.GetValues(typeof(MaterialType)).Length);//Rastgele enum kullanabiliriz
            controller.Controller(type);
        }

        private void OnCollisionEnter(Collision collision)
        {
           // Debug.Log(controller.MaterialAmount);
            Debug.Log(collision.collider.name);
            CraftManager.Instance.MaterialHolders[(int)type].craftMaterials.materialCount += controller.MaterialAmount;
            PlayerPrefs.SetInt("Id", qId);
 
        }
    }
}