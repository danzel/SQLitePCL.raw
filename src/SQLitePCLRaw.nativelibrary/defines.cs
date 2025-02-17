/*
   Copyright 2014-2019 SourceGear, LLC

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;

namespace SQLitePCL
{
    public static partial class NativeLibrary
    {
        public const int WHERE_PLAIN = 0x01;
        public const int WHERE_RUNTIME_RID = 0x02;
        public const int WHERE_ARCH = 0x04;
        public const int WHERE_ADJACENT = 0x08;
    }
}

