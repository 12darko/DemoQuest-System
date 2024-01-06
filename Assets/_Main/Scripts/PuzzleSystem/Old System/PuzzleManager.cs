using System;
using System.Collections;
using System.Collections.Generic;
using _Main.Scripts.CraftSystem;
using _Main.Scripts.PuzzleSystem;
using DG.Tweening;
using EMA.Scripts.PatternClasses;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoSingleton<PuzzleManager>
{
    [SerializeField] private PuzzleObjects[] puzzleObjects;
    [SerializeField] private PuzzleBackPiecesList puzzleBackPiecesList;
    [SerializeField] private PuzzleHolder[] puzzleHolders;
    [SerializeField] private PuzzlePoint[] puzzlePoint;
    [SerializeField] private PuzzleObjects previousPuzzleObject ,selectedPuzzleObject;
    [SerializeField] private PuzzleObjectScale puzzleObjectScale;
    [SerializeField] private int trueControl;
    #region Props

    public PuzzleHolder[] PuzzleHolders => puzzleHolders;

    public PuzzlePoint[] PuzzlePoint => puzzlePoint;
    
    public int TrueControl
    {
        get => trueControl;
        set => trueControl = value;
    }

    #endregion

    #region Local Props

    private RaycastHit _hit;

    #endregion
  
 
    private void Start()
    {
        puzzleObjects = gameObject.GetComponentsInChildren<PuzzleObjects>(); 
        puzzleBackPiecesList.List();
    }

    private void FixedUpdate()
    {
        if (TrueControl == 1)
        {
            Debug.Log("Doğru Bitti");
        }
        ClickToPuzzleObject();

        if (previousPuzzleObject == selectedPuzzleObject) return;
        if (previousPuzzleObject != null)
            puzzleObjectScale.PuzzleSize(previousPuzzleObject.transform.gameObject, 2.5f, 3f);
    }

    private void ClickToPuzzleObject()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        if (Camera.main == null) return;
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (!Physics.Raycast(ray, out _hit, 100.0f)) return;
        if (_hit.transform != null)
        {
            Debug.Log(_hit.transform.name);
            puzzleObjectScale.PuzzleSize(_hit.transform.gameObject, 3f, 4f);
            previousPuzzleObject = selectedPuzzleObject;
            selectedPuzzleObject = _hit.transform.GetComponent<PuzzleObjects>();
            
        }
    }
}