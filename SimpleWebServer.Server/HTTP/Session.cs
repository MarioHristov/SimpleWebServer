﻿using SimpleWebServer.Server.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebServer.Server.HTTP
{
    public class Session
    {
        public const string SessionCookieName = "MyWebServerSID";
        public const string SessionCurrentDateKey = "CurrentDate";

        public string Id { get; init; }

        private Dictionary<string, string> data;

        public Session(string id)
        {
            Guard.AgainstNull(id, nameof(id));

            this.Id = id;

            this.data = new Dictionary<string, string>();
        }
        public string this[string key]
        {
            get => this.data[key];
            set => this.data[key] = value;
        }
        public bool ContainsKey(string key) => this.data.ContainsKey(key);
    }
}
