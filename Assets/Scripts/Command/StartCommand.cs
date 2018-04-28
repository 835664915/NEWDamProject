using strange.extensions.command.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCommand : Command
{

    /// <summary>
    /// 当这个命令被执行的时候会默认调用Execute这个方法
    /// </summary>
    public override void Execute()
    {
        //base.Execute();
        Debug.Log("开始框架");
    }


}
