using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textEffect : MonoBehaviour
{

    [SerializeField] protected List<Text> textList;

    // Update is called once per frame
    void Update()
    {
        if (textList.Count == 0) {
            Destroy(gameObject);
            return;
        }
        
        for (int i=0;i<textList.Count;i++)
        {
            var text = textList[i];
            if (text.transform.position.x > -500)
                text.transform.position = new Vector3(text.transform.position.x - Time.deltaTime * 300f,
                    text.transform.position.y, text.transform.position.z);
            else
            {
                text.gameObject.SetActive(false);
                textList.Remove(text);
            }
        }
        
    }
}
