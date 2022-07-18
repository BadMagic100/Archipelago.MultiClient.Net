﻿using Archipelago.MultiClient.Net.Helpers;
#if USE_OCULUS_NEWTONSOFT
using Oculus.Newtonsoft.Json;
using Oculus.Newtonsoft.Json.Linq;
#else
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
#endif
using System;

#if !NET35
using System.Threading.Tasks;
#endif

namespace Archipelago.MultiClient.Net.Models
{
    class DataStorageElementContext
    {
        internal string Key { get; set; }

        internal Action<string, DataStorageHelper.DataStorageUpdatedHandler> AddHandler { get; set; }
        internal Action<string, DataStorageHelper.DataStorageUpdatedHandler> RemoveHandler { get; set; }
        internal Func<string, JToken> GetData { get; set; }
        internal Action<string, JToken> Initialize { get; set; }
#if NET35
        internal Action<string, Action<JToken>> GetAsync { get; set; }
#else
        internal Func<string, Task<JToken>> GetAsync { get; set; }
#endif

        public override string ToString()
        {
            return $"Key: {Key}";
        }
    }
}