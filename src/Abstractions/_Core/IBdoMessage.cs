﻿using BindOpen.Kernel;
using BindOpen.Kernel.Data;
using System;
using System.Collections.Generic;

namespace BindOpen.Labs.Messages
{
    /// <summary>
    /// This class represents the message.
    /// </summary>
    public interface IBdoMessage : IBdoObject, IIdentified, IReferenced, IDated, IBdoDetailed
    {
        /// <summary>
        /// Subject of this instance.
        /// </summary>
        ITBdoDictionary<string> Subject { get; set; }

        /// <summary>
        /// Body of this instance.
        /// </summary>
        ITBdoDictionary<string> Body { get; set; }

        /// <summary>
        /// Indicates whether the content is in html.
        /// </summary>
        bool IsBodyHtml { get; set; }

        /// <summary>
        /// Attached files.
        /// </summary>
        List<String> AttachedFiles { get; set; }

        /// <summary>
        /// Priority of this isntance.
        /// </summary>
        ActionPriorities Priority { get; set; }
    }
}
