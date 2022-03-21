﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JxUnity.Mods
{
    public class ModScriptInfo
    {
        public string ScriptName { get; set; }
        public string Class { get; set; }
    }

    //鉴于Mod功能叠加与修改的复杂性，Mod应有严谨的启动顺序，应不支持在游戏过程中对Mod的加载与卸载，仅在启动时对Mod进行顺序加载。
    public class ModInfo
    {
        //unique ident
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public ModScriptInfo Script { get; set; }
        public string Version { get; set; }
        public string Author { get; set; }
        public int Order { get; set; }
    }

}