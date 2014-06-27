﻿#region License
// 
//     PolyMYRServ - Crypto Currency Mining Pool Server Software
//     Copyright (C) 2013 - 2014, PolyMYRServ Project - http://www.PolyMYR.org
//     https://github.com/PolyMYRServ/PolyMYRServ
// 
//     This software is dual-licensed: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
//    
//     For the terms of this license, see licenses/gpl_v3.txt.
// 
//     Alternatively, you can license this software under a commercial
//     license or white-label it as set out in licenses/commercial.txt.
// 
#endregion
namespace PolyMYR.Daemon.Responses
{
    public class PeerInfo
    {
        public string Addr { get; set; }
        public string Services { get; set; }
        public int LastSend { get; set; }
        public int LastRecv { get; set; }
        public int BytesSent { get; set; }
        public int BytesRecv { get; set; }
        public int ConnTime { get; set; }
        public int Version { get; set; }
        public string SubVer { get; set; }
        public bool Inbound { get; set; }
        public int StartingHeight { get; set; }
        public int BanScore { get; set; }
        public bool SyncNode { get; set; }
    }
}
