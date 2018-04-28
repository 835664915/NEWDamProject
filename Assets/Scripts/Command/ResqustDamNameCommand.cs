using strange.extensions.command.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResqustDamNameCommand : EventCommand
{
  [Inject]
   public IUIPanelServer iUIpanelServer { get; set; }

    public override void Execute()
    {
      
     
   Retain(); //因为会有延迟，这个可以保证这个命令不会被销毁

     iUIpanelServer.dispatcher.AddListener(SerivcesEvent.RequstDamName, OnComplete);

        Debug.Log("执行了Execute");

        iUIpanelServer.ResqustUIPanelInfo();

    }
    /// <summary>
    /// 重服务器上得到了15个坝的名字
    /// </summary>
    /// <param name="payload"></param>
    private void OnComplete(IEvent payload)
    {
       
        iUIpanelServer.dispatcher.RemoveListener(SerivcesEvent.RequstDamName, OnComplete);
        //---可以报存在本地数据上-----


        dispatcher.Dispatch(MeditorEvent.GetDamName, payload.data);
        Debug.Log("发送了");

        Release();//释放命令
    }
}
