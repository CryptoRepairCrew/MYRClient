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
using System.Collections.Generic;

namespace PolyMYR.Coin.Daemon.Responses
{
    public class Block
    {
        public string Hash { get; set; }
        public int Confirmations { get; set; }
        public int Size { get; set; }
        public int Height { get; set; }
        public int Version { get; set; }
        public string MerkleRoot { get; set; }
        public List<string> Tx { get; set; }
        public int Time { get; set; }
        public int Nonce { get; set; }
        public string Bits { get; set; }
        public double Difficulty { get; set; }
        public string NextBlockHash { get; set; }
    }
}
