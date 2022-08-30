//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;

namespace Cfg
{
   
public partial class TbStartZone
{
    private readonly Dictionary<int, StartZone> _dataMap;
    private readonly List<StartZone> _dataList;
    private static TbStartZone _instance;
    
    public TbStartZone(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, StartZone>();
        _dataList = new List<StartZone>();
        _instance = this;
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            StartZone _v;
            _v = StartZone.DeserializeStartZone(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public static TbStartZone Instance => _instance;
    public Dictionary<int, StartZone> DataMap => _dataMap;
    public List<StartZone> DataList => _dataList;

    public StartZone GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public StartZone Get(int key) => _dataMap[key];
    public StartZone this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}