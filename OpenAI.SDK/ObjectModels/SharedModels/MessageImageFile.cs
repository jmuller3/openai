﻿using System.Text.Json.Serialization;

namespace OpenAI.ObjectModels.SharedModels;

/// <summary>
///     An image File in the content of a message.
/// </summary>
public record MessageImageFile
{
    /// <summary>
    ///     The File ID of the image in the message content.
    /// </summary>
    [JsonPropertyName("file_id")]
    public string FileId { get; set; }
}