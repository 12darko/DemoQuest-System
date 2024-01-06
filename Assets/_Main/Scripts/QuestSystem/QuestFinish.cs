using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QuestFinish : MonoBehaviour
{
    public void Finish(GameObject questObject)
    {
        var qManager = QuestManager.Instance;

        foreach (var qHolder in qManager.Quests)
        {
            if (qHolder.properties.count >= qHolder.properties.requiredCount)
            {
                qHolder.isFinish = true;
              //  PlayerPrefs.SetInt("Id", qHolder.id);
                DestroyItem(questObject.transform.parent.GetChild(qHolder.id).gameObject, qHolder);
            }
            else
            {
                qHolder.isFinish = false;
            }
        }
    }


    private void DestroyItem(GameObject objects, QuestHolder holder)
    {
        if (holder.isFinish)
        {
            objects.SetActive(false);
            Debug.Log(PlayerPrefs.GetInt("Id"));
            PlayerPrefs.DeleteKey("Id");
        }
    }
}