﻿using System;

namespace ReadyApi.Common.Model
{
    public class BasicErrorResponse
    {
        public string CorrelationId { get; private set; }
        public string FriendlyMessage { get; set; }

        public void AddErrorMessage(string message)
        {
            FriendlyMessage = string.IsNullOrEmpty(FriendlyMessage)
                                  ? message
                                  : $"{FriendlyMessage}{Environment.NewLine}{message}";
        }

        public void SetCorrelationId(string correlationId)
        {
            this.CorrelationId = correlationId;
        }
    }
}