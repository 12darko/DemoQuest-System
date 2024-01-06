using System.Collections;
using System.Collections.Generic;
using _Main.Scripts.CraftSystem.Old_System_Example;
using _Main.Scripts.QuestSystem;
using UnityEngine;

[System.Serializable]
public class QuestHolder
{
   public Quest quest;
   public bool isFinish;
   public int id;
   public QuestType type;
   public MaterialType mType;
   public QuestProperties properties;
   public bool questEnable = false;
   public GameObject questObject = null;
}
