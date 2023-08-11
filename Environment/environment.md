## 開発環境
- Ubuntu22.04

## ダウンロードとインストール
https://dotnet.microsoft.com/ja-jp/learn/dotnet/hello-world-tutorial/install

## ダウンロード  
[Ubuntu に .NET SDK または .NET ランタイムをインストールする](https://learn.microsoft.com/ja-jp/dotnet/core/install/linux-ubuntu)

- Ubuntu上で `lsb_release -a` コマンドを実行してディストリビューションのバージョンを確認
```
$ lsb_release -a
No LSB modules are available.
Distributor ID: Ubuntu
Description:    Ubuntu 22.04.2 LTS
Release:        22.04
Codename:       jammy
```

[Ubuntu 22.04 に .NET SDK または .NET ランタイムをインストールする](https://learn.microsoft.com/ja-jp/dotnet/core/install/linux-ubuntu-2204)

- .NET アプリを開発する場合は、SDK をインストールする必要がある
- アプリを実行するだけの場合はランタイムをインストールする。
  - ランタイムをインストールする場合は、ASP.NET Coreランタイムをインストールすることをお勧めする
  - ASP.NET Coreランタイムには、.NET CoreとASP.NET Coreの両方が含まれている

- .NETがインストールされているか確認バージョンを確認

[.NET が既にインストールされていることを確認する方法](https://learn.microsoft.com/ja-jp/dotnet/core/install/how-to-detect-installed-versions?pivots=os-linux)

```
# SDKのバージョン確認(インストールされている場合こんな感じ)
$ dotnet --list-sdks
7.0.110 [/usr/lib/dotnet/sdk]

# ランタイムのバージョン確認
$ dotnet --list-runtimes(インストールされている場合こんな感じ)
Microsoft.AspNetCore.App 7.0.10 [/usr/lib/dotnet/shared/Microsoft.AspNetCore.App]
Microsoft.NETCore.App 7.0.10 [/usr/lib/dotnet/shared/Microsoft.NETCore.App]
```

- SDKバージョン7.0をインストール
```
sudo apt update && \
  sudo apt install -y dotnet-sdk-7.0
```

- ランタイムをインストール
```
sudo apt-get install -y dotnet-runtime-7.0
```

- オプションについて  
`-y` = YesかNoかを聞かれた時にYesで実行する

- `dotnet --info` を使うと、SDKバージョンやランタイムバージョンなど詳細情報を見ることができる

- .NETをアンインストールするには  
[.NET ランタイムと SDK を削除する方法](https://learn.microsoft.com/ja-jp/dotnet/core/install/remove-runtime-sdk-versions?pivots=os-linux#uninstall-net)

```
	製品	Type	パッケージ
7.0	ASP.NET Core	ランタイム	aspnetcore-runtime-7.0
7.0	.NET	ランタイム	dotnet-runtime-7.0
7.0	.NET	SDK	dotnet-sdk-7.0
6.0	ASP.NET Core	ランタイム	aspnetcore-runtime-6.0
6.0	.NET	ランタイム	dotnet-runtime-6.0
6.0	.NET	SDK	dotnet-sdk-6.0
```

```
# SDKを削除
$ sudo apt remove dotnet-sdk-7.0
# ASP.NET Coreと.NET Core両方を削除
$ sudo apt remove dotnet-runtime-7.0
# ASP.NET Coreのみを削除
$ sudo apt remove aspnetcore-runtime-7.0
```

