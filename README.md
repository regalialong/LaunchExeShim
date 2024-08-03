# VRCX launch.exe shim

VRCX's handling of the game argument override [unfortunately is very strict](https://github.com/vrcx-team/VRCX/blob/df49805194862806b624e86eb2ac25163f0935bf/Dotnet/AppApi/GameHandler.cs#L117-L121), leaving little headroom for hacks.

While I'm still too lazy to implement [#804](https://github.com/vrcx-team/VRCX/issues/804), this is a dirty workaround that shims what would be launch.exe to pass it to Steam as URL instead.