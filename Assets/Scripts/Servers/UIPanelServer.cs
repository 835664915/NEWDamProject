using System.Collections;
using System.Collections.Generic;
using strange.extensions.dispatcher.eventdispatcher.api;
using UnityEngine;

public class UIPanelServer : IUIPanelServer {
    [Inject]
    public IEventDispatcher dispatcher { get; set; }

    public List<string> rightUpDamName=new List<string> ();
   
    public void ResqustUIPanelInfo()
    {
        OnResquestUIPanelInfoServer();
      //  Debug.Log("ResqustUIPanelInfo" + rightUpDamName.Count);
          dispatcher.Dispatch(SerivcesEvent.RequstDamName, rightUpDamName);

    }

    public void OnResquestUIPanelInfoServer()
    {


        GetUIPanelUrl();
        Debug.Log("OnResquestUIPanelInfoServer");
        GetDropdown();
      


 




    }
    /// <summary>
    /// 本地用Resources，网络把预至物打包上传
    /// </summary>
    void GetUIPanelUrl()
    {
        UIPanelInfo uiPanelInfo = new UIPanelInfo();

        string blostr = Resources.Load<TextAsset>("JsonInfo/MainPanel").text;

        uiPanelInfo = JsonUtility.FromJson<UIPanelInfo>(blostr);

        for (int i = 0; i < uiPanelInfo.panelInfos.Count; i++)
        {
            Debug.Log(uiPanelInfo.panelInfos[i].panelName);


        }




    }


    /// <summary>
    /// 获取坝的名字
    /// </summary>
    void GetDropdown()
    {
      
        ModelTest m = new ModelTest();
        string blostr = Resources.Load<TextAsset>("JsonInfo/RightPanelJson").text;

        m = JsonUtility.FromJson<ModelTest>(blostr);

        for (int i = 0; i < m.damName.Count; i++)
        {
            rightUpDamName.Add(m.damName[i].name);
          //  Debug.Log("GetDropdown"+ rightUpDamName.Count);
        }

    }

   
}


