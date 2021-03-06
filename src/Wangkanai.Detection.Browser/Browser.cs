// Copyright (c) 2016 Sarin Na Wangkanai, All Rights Reserved.
// The GNU GPLv3. See License.txt in the project root for license information.

using System;

namespace Wangkanai.Detection
{
    public class Browser : IBrowser
    {
        public string Name { get; set; }
        public string Maker { get; set; }
        public BrowserType Type { get; set; }
        public IVersion Version { get; set; }
        public byte Bits { get; set; }
        public Feature Feature { get; set; }

        public Browser() { }
        public Browser(BrowserType browserType)
            => Type = browserType;
        public Browser(BrowserType browserType, IVersion version)
            : this(browserType)
            => Version = version;

        public Browser(string name)
        {
            BrowserType type;

            if (!Enum.TryParse(name, true, out type))
                throw new BrowserNotFoundException(name, "not found");

            Type = type;
        }
    }
}