﻿// Copyright (c) Rixian. All rights reserved.
// Licensed under the Apache License, Version 2.0 license. See LICENSE file in the project root for full license information.

#pragma warning disable CA2227 // Collection properties should be read only
namespace VendorHub.Forms
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// A form submission.
    /// </summary>
    public class FormSubmission
    {
        /// <summary>
        /// Gets or sets the form ID.
        /// </summary>
        [JsonProperty("formId")]
        public Guid FormId { get; set; }

        /// <summary>
        /// Gets or sets the submission ID.
        /// </summary>
        [JsonProperty("submissionId")]
        public Guid SubmissionId { get; set; }

        /// <summary>
        /// Gets or sets the submission date.
        /// </summary>
        [JsonProperty("submittedOn")]
        public DateTimeOffset SubmittedOn { get; set; }

        /// <summary>
        /// Gets or sets the submission fields.
        /// </summary>
        [JsonProperty("fields")]
        public List<FormField> Fields { get; set; }

        /// <summary>
        /// Gets or sets the submission attachments.
        /// </summary>
        [JsonProperty("attachments")]
        public List<FormSubmissionAttachment> Attachments { get; set; }
    }
}
#pragma warning restore CA2227 // Collection properties should be read only
