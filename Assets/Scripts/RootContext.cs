using strange.extensions.context.api;
using strange.extensions.context.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootContext : MVCSContext
{
    public RootContext(MonoBehaviour view):base(view)
    {



    }
    protected override void mapBindings()
    {


       
        injectionBinder.Bind<LocalModel>().To<LocalModel>().ToSingleton();



        mediationBinder.Bind<RightMenuPanelView>().To<RightMenuPanelMeditor>();
      injectionBinder.Bind<IUIPanelServer>().To<UIPanelServer>().ToSingleton();


        commandBinder.Bind(CommandEvent.RequstDamName).To<ResqustDamNameCommand>();



        commandBinder.Bind(ContextEvent.START).To<StartCommand>().Once();

    }


}
