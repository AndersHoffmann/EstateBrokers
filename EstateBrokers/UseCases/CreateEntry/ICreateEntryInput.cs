﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.CreateEntry
{
    public interface ICreateEntryInput
    {
        public void CreateEntry(CreateEntryRequestModel request);
    }
}
