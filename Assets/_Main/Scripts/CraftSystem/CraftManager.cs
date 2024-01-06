using System;
using System.Collections;
using System.Collections.Generic;
using _Main.Scripts.CraftSystem.Old_System_Example;
using EMA.Scripts.PatternClasses;
using UnityEngine;
using UnityEngine.Events;

public class CraftManager : MonoSingleton<CraftManager>
{
    [SerializeField] private MaterialHolder[] materialHolders;
    
    [SerializeField] private GameObject content;
    [SerializeField] private GameObject materialObject;

    public UnityAction CoinTextUpdate;

    #region Props
    public MaterialHolder[] MaterialHolders => materialHolders;

    public GameObject Content => content;

    public GameObject MaterialObject => materialObject;

    #endregion
    
    
    #region Class

    [SerializeField] private MaterialList listMaterial;
    
    #endregion


    private void Start()
    {
        listMaterial.List();
    }

    private void FixedUpdate()
    {
        CoinTextUpdate?.Invoke();
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            materialHolders[1].craftMaterials.materialCount += 500;
        }
    }
}
