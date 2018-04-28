using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RightMenuPanelView : View
{
 




    [Inject(ContextKeys.CONTEXT_DISPATCHER)]
    public IEventDispatcher dispatcher { get; set; }
 
    private Dropdown dropDown;
  

    private  List<Dropdown.OptionData> dOList = new List<Dropdown.OptionData>();
  
    public void Init()
    {
      


		dropDown=transform.GetChild (0).GetComponent<Dropdown>();

        dropDown.options.Clear();
      


      
    }

    /// <summary>
    /// 显示主坝名,图片
    /// </summary>
    public void ShowMainDamName(List<string> AllName)
    {

        for (int i = 0; i < AllName.Count; i++)
        {
            Dropdown.OptionData dropDownTemp = new Dropdown.OptionData();
            
            dropDown.value = i;
            dropDownTemp.text = AllName[i];
           
            dropDown.options.Add(dropDownTemp);

        }
     dropDown.captionText.text = AllName[0];

        // dropDown.AddOptions(AllName);
        // dropDown.AddOptions(listSprite);



    }


}
