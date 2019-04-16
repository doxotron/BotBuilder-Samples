﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using QnAPrompting.Models;

namespace QnAPrompting.Helpers
{
    public interface IQnAServiceHelper
    {
        Task<QnAResult[]> QueryQnAServiceAsync(string query, QnABotState qnAcontext);
    }
}
