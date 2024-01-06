using System;
using System.Collections;
using System.Collections.Generic;
using _Main.Scripts.QuestSystem;
using EMA.Scripts.PatternClasses;
using UnityEngine;
using UnityEngine.Events;

public class QuestManager : MonoSingleton<QuestManager>
{
    [SerializeField] private QuestHolder[] quests;

    #region Quest Class
    [SerializeField] private QuestListing listing;
    [SerializeField] private QuestFinish finish;
    #endregion

 
    public UnityAction QuestTextUpdate;
    private UnityAction _questIsFinish;

    public QuestHolder[] Quests => quests;

    private void Start()
    {
        Debug.Log(quests.Length);
        listing.List();
    }

    private void FixedUpdate()
    {
        QuestTextUpdate?.Invoke();
        finish.Finish(listing.QuestContent.transform.GetChild(PlayerPrefs.GetInt("Id")).gameObject);
    }
}
