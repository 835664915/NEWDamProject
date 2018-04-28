using strange.extensions.dispatcher.eventdispatcher.api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUIPanelServer
{
    void OnResquestUIPanelInfoServer();
    void ResqustUIPanelInfo();


   IEventDispatcher dispatcher { get; set; }


	
}
