﻿# このソフトウェアについて

　C#で標準入力を取得する。

# 開発環境

* <time datetime="2019-12-24T11:09:08+0900">2019-12-24</time>
* [Raspbierry pi](https://ja.wikipedia.org/wiki/Raspberry_Pi) 3 Model B+
* [Raspbian](https://www.raspberrypi.org/downloads/raspbian/) 9.0 stretch 2018-11-13 Desktop [※](http://ytyaru.hatenablog.com/entry/2020/03/29/000000)
* [C# dotnet 3.0.100](http://ytyaru.hatenablog.com/entry/2021/11/27/000000) [※](http://ytyaru.hatenablog.com/entry/2022/01/01/000000) [※](http://ytyaru.hatenablog.com/entry/2022/02/07/000000)
    * [.NET Core 2.2](http://ytyaru.hatenablog.com/entry/2020/02/08/000000), [MonoDevelop参照方法](http://ytyaru.hatenablog.com/entry/2020/02/09/000000)
    * [Mono 5.18.0.240](http://ytyaru.hatenablog.com/entry/2020/01/17/000000)
        * Eto.Forms 2.4.1 [拡張機能](http://ytyaru.hatenablog.com/entry/2020/01/23/000000), [NuGetパッケージ](http://ytyaru.hatenablog.com/entry/2020/01/21/000000)

```sh
$ uname -a
Linux raspberrypi 4.19.75-v7l+ #1270 SMP Tue Sep 24 18:51:41 BST 2019 armv7l GNU/Linux
```
```sh
$ dotnet --version
3.1.100
```
```sh
$ mono --version
Mono JIT compiler version 6.4.0.198 (tarball Tue Sep 24 01:45:47 UTC 2019)
Copyright (C) 2002-2014 Novell, Inc, Xamarin Inc and Contributors. www.mono-project.com
	TLS:           __thread
	SIGSEGV:       normal
	Notifications: epoll
	Architecture:  armel,vfp+hard
	Disabled:      none
	Misc:          softdebug 
	Interpreter:   yes
	LLVM:          yes(610)
	Suspend:       preemptive
	GC:            sgen (concurrent by default)
```

# ライセンス

　このソフトウェアはCC0ライセンスである。

[![CC0](http://i.creativecommons.org/p/zero/1.0/88x31.png "CC0")](http://creativecommons.org/publicdomain/zero/1.0/deed.ja)

