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
using System;
using System.Collections.Generic;

namespace PolyMYR.Daemon.Responses
{
    public interface IBlockTemplate
    {
        string Bits { get; set; }

        UInt32 CurTime { get; set; }

        int Height { get; set; }

        string PreviousBlockHash { get; set; }

        int SigOpLimit { get; set; }

        int SizeLimit { get; set; }

        BlockTemplateTransaction[] Transactions { get; set; }

        UInt32 Version { get; set; }

        CoinBaseAux CoinBaseAux { get; set; }

        int CoinbaseTxt { get; set; }

        Int64 Coinbasevalue { get; set; }

        int WorkId { get; set; }

        string Target { get; set; }

        UInt32 MinTime { get; set; }

        List<string> Mutable { get; set; }

        string NonceRange { get; set; }
    }
}
