﻿using System;

namespace ContextualDates.Library
{
    public class DateContext
    {
        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public DateTime ContextDateTime { get; set; }
    }
}