<<<<<<< HEAD
﻿using System.Collections.Generic;
using Signals;
using UnityEngine;
using System.Linq;
=======
using UnityEngine;
using System.Collections.Generic;
>>>>>>> origin/main

public class UIPanelController : MonoBehaviour
{
    #region Self Variables

    #region Serialized Variables

    [SerializeField] private List<Transform> layers = new List<Transform>();

    #endregion

<<<<<<< HEAD

=======
>>>>>>> origin/main
    #endregion

    private void OnEnable()
    {
<<<<<<< HEAD

        SubscribeEvents();
        
    }
    
    private void SubscribeEvents()
    {
        CoreUISignals.Instance.onOpenPanel += OnOpenPanel;
        CoreUISignals.Instance.onClosePanel += OnClosePanel;
        CoreUISignals.Instance.onCloseAllPanels += OnCloseAllPanels;

    }
    private void UnSubscribeEvents()
    {
        CoreUISignals.Instance.onOpenPanel -= OnOpenPanel;
        CoreUISignals.Instance.onClosePanel -= OnClosePanel;
        CoreUISignals.Instance.onCloseAllPanels -= OnCloseAllPanels;
=======
        SubscribeEvents();
    }

    private void SubscribeEvents()
    {

    }

    private void UnSubscribeEvents()
    {
>>>>>>> origin/main

    }

    private void OnDisable()
    {
        UnSubscribeEvents();
    }
<<<<<<< HEAD
    
    private void OnOpenPanel(UIPanelTypes type, int layerPos)
    {
        Instantiate(Resources.Load<GameObject>($"Screens/{type}Panel"), layers[layerPos]);
    }
    
    private void OnClosePanel(int layerPos)
    {
        if (layers[layerPos].transform.childCount > 0) 
            Destroy(layers[layerPos].GetChild(0).gameObject);
=======
    //[Button("OnOpenPanel")]
    private void OnOpenPanel(UIPanelTypes type, int layerValue)
    {
        OnClosePanel(layerValue);
        Instantiate(Resources.Load<GameObject>($"Screens/{type}Panel"), layers[layerValue]);
    }
    //[Button("OnClosePanel")]
    private void OnClosePanel(int layerValue)
    {
        if(layers[layerValue].childCount > 0)
        {
            Destroy(layers[layerValue].GetChild(0).gameObject);
        }
>>>>>>> origin/main
    }

    private void OnCloseAllPanels()
    {
<<<<<<< HEAD
        for (int i = 0; i < layers.Count; i++)
        {
            if (layers[i].transform.childCount > 0) 
                Destroy(layers[i].GetChild(0).gameObject);
        }
    }

}
=======
        for(int i = 0; i < layers.Count; i++)
        {
            if(layers[i].childCount > 0)
            {
                Destroy(layers[i].gameObject);
            }
        }
    }

}
>>>>>>> origin/main
