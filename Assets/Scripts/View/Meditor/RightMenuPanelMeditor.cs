using strange.extensions.context.api;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMenuPanelMeditor : Mediator
{
    [Inject]
    public RightMenuPanelView rightMenuPanelView { get; set; }
    /// <summary>
    /// 模块与模块之间的调用都是通过dispatcher触发的，这里是触发请求分数的命令，这个命令是一个全局的命令所以要用ContextKeys.CONTEXT_DISPATCHER，全局的派发器
    /// </summary>
    [Inject(ContextKeys.CONTEXT_DISPATCHER)]
    public IEventDispatcher dispatcher { get; set; }
    [Inject]
    public LocalModel loacalModel { get; set; }

    public override void OnRegister()
    {
        rightMenuPanelView.Init();

        dispatcher.AddListener(MeditorEvent.GetDamName, OnGetDamName);
        //这里是高数命令模块，你要执行excit（）这个放发了，不是得到数据的
        dispatcher.Dispatch(CommandEvent.RequstDamName);



    }

    private void OnGetDamName(IEvent payload)
    {
        List<string> damName = new List<string>();

        damName = (payload.data) as List<string>;

        rightMenuPanelView.ShowMainDamName(damName);


    }

    public override void OnRemove()
    {
        dispatcher.RemoveListener(MeditorEvent.GetDamName, OnGetDamName);


    }




}
