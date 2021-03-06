using System;
using System.Text;
using SAP.Connector;

namespace VC_SAP.Tables
{
[Serializable]
public class ZSPI_DETALLE_VENTable : SAPTable 
{
public override Type GetElementType() 
{
return (typeof(ZSPI_DETALLE_VEN));
}
public override object CreateNewRow()
{ 
return new ZSPI_DETALLE_VEN();
}
public ZSPI_DETALLE_VEN this[int index] 
{
get 
{
return ((ZSPI_DETALLE_VEN)(List[index]));
}
set 
{
List[index]=value;
}
}
public int Add(ZSPI_DETALLE_VEN value) 
{
return List.Add(value);
}
public void Insert(int index, ZSPI_DETALLE_VEN value) 
{
List.Insert(index, value);
}
public int IndexOf(ZSPI_DETALLE_VEN value) 
{
return List.IndexOf(value);
}
public bool Contains(ZSPI_DETALLE_VEN value) 
{
return List.Contains(value);
}
public void Remove(ZSPI_DETALLE_VEN value) 
{
List.Remove(value);
}
public void CopyTo(ZSPI_DETALLE_VEN[] array, int index) 
{
List.CopyTo(array, index);
}
}
}