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
using PolyMYR.Common.Context;
using PolyMYR.Common.Repository.Registries;
using Nancy.TinyIoc;

namespace PolyMYR.Common.Repository
{
    /// <summary>
    /// IOC & DI registry.
    /// To get a better overview of IOC, check http://joelabrahamsson.com/inversion-of-control-an-introduction-with-examples-in-net/
    /// </summary>
    public class Bootstrapper
    {
        private readonly TinyIoCContainer _container ;

        public Bootstrapper(TinyIoCContainer container)
        {
            _container = container;
        }

        public void Run()
        {
            var masterRegistry = new Registry(_container);
            masterRegistry.RegisterInstances();

            var applicationContext = _container.Resolve<IApplicationContext>();
            applicationContext.Initialize(_container);

            foreach (var registry in _container.ResolveAll<IRegistry>())
            {
                registry.RegisterInstances();
            }
        }
    }
}
