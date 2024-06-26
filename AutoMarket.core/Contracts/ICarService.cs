﻿using AutoMarket.core.Models.Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.core.Contracts
{
    public interface ICarService
    {
        Task<IEnumerable<CarImageAndNameViewModel>> GetPicturesAsync();
    }
}
