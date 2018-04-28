using strange.extensions.command.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPanelCommand : EventCommand
{

    [Inject]
    public LocalModel localModel { get; set; }



    /// <summary>  
    /// 当该事件被绑定后，将执行该函数  
    /// </summary>  
    public override void Execute()
    {


        Debug.Log("执行了Execute");
        Retain();

   

    }
    public void OnComplete(IEvent evt)
    {

        // dispatcher.AddListener(localModel.RequestScore, OnComplete);
       



    }



}
