using strange.extensions.context.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root : ContextView
{

    private void Awake()
    {
        this.context = new RootContext(this);

        //  context.Start();


    }
}
