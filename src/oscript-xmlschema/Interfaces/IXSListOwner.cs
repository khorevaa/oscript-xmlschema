﻿
namespace OneScript.XMLSchema
{
    internal interface IXSListOwner
    {
        void OnListInsert(XSComponentList list, IXSComponent component);
        void OnListDelete(XSComponentList list, IXSComponent component);
    }
}
