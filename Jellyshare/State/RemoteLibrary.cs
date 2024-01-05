using System;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Library;

namespace Jellyshare.State;

public class RemoteLibrary
{
    public Guid LocalId { get; init; }
    public Guid ExternalId { get; init; }
    public Uri RemoteAddress { get; init; }
}