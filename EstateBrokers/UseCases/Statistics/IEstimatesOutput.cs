﻿using System;
using ViewModels;
namespace UseCases.Statistics
{
    public interface IEstimatesOutput
    {
        public void DisplayData(EstimatesResponseModel response);

    }
}
