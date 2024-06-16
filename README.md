# Jellyshare

A Jellyfin plugin for sharing libraries between servers.

# Limitations

This plugin is in a very early alpha state. Do not expect stability.

- Is only able to handle Movie libraries.
- Is only able to handle Direct Play media.
- Is not able to handle URL or server name changes.
- Is not able to handle library name changes.

# Development

## Requirements

- .NET 6+
- Docker
- PowerShell

## Preamble

Create three directories at /DevData/Media/{1,2,3}. Place any number of movies
in each directory. The Blender Foundation has produced many freely licensed
movies which may be useful for this purpose.

## Build

    $ Scripts/Run

## Use

Three Jellyfin instances will be running at http://localhost:8081,
http://localhost:8082, and http://localhost:8083. Access each instance and go
through their installers. Create a Movie library in each instance using the
relevant media folders discussed previously in the preamble.

Create a new API key for each instance. Pick any instance, access its Jellyshare
configuration in the Plugins tab, and add two new remote servers. Be warned that
error handling is almost non existent. If invalid data is preventing the server
from launching, you may need to first delete
DevData/Config/?/plugins/configuration/Jellyshare.xml.

Start the Jellyshare Sync task within the Schedules Tasks tab. The task should
take a few seconds at most.

If an error occurs at any step, check the latest log file. Feel free to create
an issue with all your relevant information, but remember that this software is
freely provided and I provide no guarantee of support.

# License

Licensed under AGPL-3.0-or-later. The license can be found at /COPYING.
