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
namespace PolyMYR.Coin.Daemon.Responses
{
    public class MiningInfo
    {
        public int Blocks { get; set; }
        public int CurrentBockSize { get; set; }
        public int CurrentBlockTx { get; set; }
        public double Difficulty { get; set; }
        public string Errors { get; set; }
        public bool Generate { get; set; }
        public int GenProcLimit { get; set; }
        public int HashesPerSec { get; set; }
        public int PooledTx { get; set; }
        public bool Testnet { get; set; }
    }
}
