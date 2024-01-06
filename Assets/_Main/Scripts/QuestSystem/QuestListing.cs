using System;
using System.Collections.Generic;
using _Main.Scripts.CraftSystem.Old_System_Example;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace _Main.Scripts.QuestSystem
{
    public class QuestListing : MonoBehaviour
    {
        #region Class

        [SerializeField] private QuestController controller;

        #endregion

        [SerializeField] private GameObject questContent;
        [SerializeField] private GameObject questItem;

        #region Props

        public GameObject QuestContent => questContent;

        #endregion

        public void List()
        {
            var qManager = QuestManager.Instance;
            foreach (var qHolder in qManager.Quests)
            {
                var item = Instantiate(questItem, questContent.transform);
                if (qHolder.questEnable)
                {
                    item.gameObject.SetActive(true);
                    if (qHolder.isFinish)
                    {
                        Destroy(item);
                    }
                    else
                    {
                        item.transform.GetChild(0).GetComponent<TMP_Text>().text = qHolder.quest.QuestTitle;
                        item.transform.GetChild(1).GetComponent<TMP_Text>().text = qHolder.quest.QuestMessage;
          
                        MaterialIsHave(item, qHolder);
                        qManager.QuestTextUpdate += () =>
                        {
                            item.transform.GetChild(2).GetComponent<TMP_Text>().text =
                                qHolder.properties.count + " / " + qHolder.properties.requiredCount;
                            
                            qHolder.id = item.transform.GetSiblingIndex();
                            qHolder.questObject.GetComponent<MaterialInObject>().QId = item.transform.GetSiblingIndex();
                        };
                      
                    }
                }
                else
                {
                    item.gameObject.SetActive(false);
                }
            }
        }

        private void MaterialIsHave(GameObject item, QuestHolder holder)
        {
            if (holder.mType != MaterialType.None)
            {
                item.transform.GetChild(3).GetComponent<TMP_Text>().text = "ISTENEN MALZEME : " + holder.mType;
            }
            else
            {
                item.transform.GetChild(3).gameObject.SetActive(false);
            }
        }
    }
}