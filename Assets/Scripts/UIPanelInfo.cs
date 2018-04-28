using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class UIPanelInfo
{

    [SerializeField]
    public List<panelInfo>  panelInfos;



}
[Serializable]
public class panelInfo
{
    
  

    [SerializeField]
    public string panelName;
    [SerializeField]
    public string panelUrl;


}
[Serializable]
public class ModelTest
{
    public List<bamClass> damName;



}

[Serializable]
public class bamClass
{

    public string name;

    public override string ToString()
    {
        return string.Format("<name:{0}>", name);
    }


}
